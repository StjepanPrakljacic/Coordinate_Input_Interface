using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Coordinate_Input_Interface
{
    public partial class OrchardFieldForm : Form
    {
        public OrchardFieldForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string list_of_FieldID = FieldCoordID.Text;
            string list_of_FieldX = X_FieldValue.Text;
            string list_of_FieldY = Y_FieldValue.Text;
            string list_of_OrchardX = X_OrchardValue.Text;
            string list_of_OrchardY = Y_OrchardValue.Text;
            char[] seperator = { ',' };

            Int16 coordFieldCnt = 0;
            Int16 coordOrchardCnt = 0;

            string[] strarrFieldID = null;
            string[] strarrFieldX = null;
            string[] strarrFieldY = null;
            string[] strarrOrchardX = null;
            string[] strarrOrchardY = null;

            strarrFieldID = list_of_FieldID.Split(seperator);
            strarrFieldX = list_of_FieldX.Split(seperator);
            strarrFieldY = list_of_FieldY.Split(seperator);
            strarrOrchardX = list_of_OrchardX.Split(seperator);
            strarrOrchardY = list_of_OrchardY.Split(seperator);

            if (int.Equals(list_of_FieldID.Length, 0) && int.Equals(list_of_FieldX.Length, 0) && int.Equals(list_of_FieldY.Length, 0))
            {
                if(Field_coordinates.Items.Count == 0)
                {
                    MessageBox.Show("Enter the coordinates of Field!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else if (int.Equals(strarrFieldID.Length, strarrFieldX.Length) && int.Equals(strarrFieldID.Length, strarrFieldY.Length) && int.Equals(strarrFieldX.Length, strarrFieldY.Length))
            {
                int FieldCoordlenght = strarrFieldID.Length;
                for(coordFieldCnt = 0; coordFieldCnt < FieldCoordlenght; coordFieldCnt++)
                {
                ListViewItem newFieldCoordinate = new ListViewItem(strarrFieldID[coordFieldCnt]);
                newFieldCoordinate.SubItems.Add(strarrFieldX[coordFieldCnt]);
                newFieldCoordinate.SubItems.Add(strarrFieldY[coordFieldCnt]);
                Field_coordinates.Items.Add(newFieldCoordinate);
                
                }
                FieldCoordID.Clear();
                X_FieldValue.Clear();
                Y_FieldValue.Clear();
                FieldCoordID.Focus();

            }
            else
            {
                MessageBox.Show("You must enter the same number of values!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FieldCoordID.Focus();
            }

            if (int.Equals(list_of_OrchardX.Length, 0) && int.Equals(list_of_OrchardY.Length, 0))
            {
                if (Orchard_coordinates.Items.Count == 0)
                {
                    MessageBox.Show("Enter the coordinates of Orchard!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }
            else if(int.Equals(strarrOrchardX.Length, strarrOrchardY.Length))
            {
                if (string.IsNullOrEmpty(NumberOfRows.Text))
                {
                    MessageBox.Show("You must enter number of Rows!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    lblOrchardRows.Text = "Uneseni broj redova je:";
                    NumberOfRows.Text = NumberOfRows.Text;
                    int FieldOrchardlenght = strarrOrchardX.Length;
                    for (coordOrchardCnt = 0; coordOrchardCnt < FieldOrchardlenght; coordOrchardCnt++)
                    {
                        ListViewItem newOrchardCoordinate = new ListViewItem(strarrOrchardX[coordOrchardCnt]);
                        newOrchardCoordinate.SubItems.Add(strarrOrchardY[coordOrchardCnt]);
                        Orchard_coordinates.Items.Add(newOrchardCoordinate);
                    }

                    
                    X_OrchardValue.Clear();
                    Y_OrchardValue.Clear();
                    X_OrchardValue.Focus();
                }
               
            }
            else
            {
                MessageBox.Show("You must enter the same number of values!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                X_OrchardValue.Focus();
            }
        }

        private void btnRemoveFieldCoord_Click(object sender, EventArgs e)
        {
            
            if (Field_coordinates.Items.Count > 0)
            {
                Field_coordinates.Items.RemoveAt(Field_coordinates.SelectedIndices[0]);
                
            }
            

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xls", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Oznaka";
                    ws.Cells[2, 1] = "Koordinate polja X";
                    ws.Cells[3, 1] = "Koordinate polja Y";
                    ws.Cells[4, 1] = "Broj redova";
                    ws.Cells[5, 1] = "Koordinate vocnjaka X";
                    ws.Cells[6, 1] = "Koordinate vocnjaka Y";
                    int i = 2;
                    int j = 2;
                    foreach (ListViewItem item in Field_coordinates.Items)
                    {
                        ws.Cells[1, i] = item.SubItems[0].Text;
                        ws.Cells[2, i] = item.SubItems[1].Text;
                        ws.Cells[3, i] = item.SubItems[2].Text;
                        i++;
                    }
                    ws.Cells[4, 2] = NumberOfRows.Text;
                    foreach (ListViewItem item in Orchard_coordinates.Items)
                    {
                        ws.Cells[5, j] = item.SubItems[0].Text;
                        ws.Cells[6, j] = item.SubItems[1].Text;
                        j++;
                    }
                    wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("Your data has been successfully created.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }   
        }

        private void btnRemoveOrchardCoord_Click(object sender, EventArgs e)
        {
            if (Orchard_coordinates.Items.Count > 0)
            {
                Orchard_coordinates.Items.RemoveAt(Orchard_coordinates.SelectedIndices[0]);

            }
        }
    }
}

       

