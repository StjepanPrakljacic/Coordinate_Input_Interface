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
        char[] separator = { ',' };
        Int16 CoordFieldCnt = 0;
        Int16 CoordOrchardCnt = 0;
        int FieldCoordlenght;
        int FieldOrchardlenght;

        string[] StrarrFieldID = null;
        string[] StrarrFieldX = null;
        string[] StrarrFieldY = null;
        string[] StrarrOrchardID = null;
        string[] StrarrOrchardX = null;
        string[] StrarrOrchardY = null;
        string[] StrarrOrchardElevation = null;

       

        public OrchardFieldForm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            #region User Input 

            string ListOfFieldID = TbFieldCoordID.Text;
            string ListOfFieldX = TbFieldX.Text;
            string ListOfFieldY = TbFieldY.Text;
            string ListOfOrchardID = TbOrchardCoordID.Text;
            string ListOfOrchardX = TbOrchardX.Text;
            string ListOfOrchardY = TbOrchardY.Text;
            string ListOfElevation = TbElevation.Text;

            #endregion

            #region Adding new Field Coordinates

            if (int.Equals(ListOfFieldID.Length, 0) && 
                int.Equals(ListOfFieldX.Length, 0) && 
                int.Equals(ListOfFieldY.Length, 0))
            {
                if(LvField.Items.Count == 0)
                {
                    MessageBox.Show("Enter the coordinates of Field!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }

            else if (int.Equals(ListOfFieldID.Length, ListOfFieldX.Length) &&   
                     int.Equals(ListOfFieldID.Length, ListOfFieldY.Length))
            {
                #region Input separation

                StrarrFieldID = ListOfFieldID.Split(separator);
                StrarrFieldX = ListOfFieldX.Split(separator);
                StrarrFieldY = ListOfFieldY.Split(separator);

                #endregion

                FieldCoordlenght = StrarrFieldID.Length;
                for(CoordFieldCnt = 0; CoordFieldCnt < FieldCoordlenght; CoordFieldCnt++)
                {
                    ListViewItem newFieldCoordinate = new ListViewItem(StrarrFieldID[CoordFieldCnt]);
                    newFieldCoordinate.SubItems.Add(StrarrFieldX[CoordFieldCnt]);
                    newFieldCoordinate.SubItems.Add(StrarrFieldY[CoordFieldCnt]);
                    LvField.Items.Add(newFieldCoordinate);
                }
                TbFieldCoordID.Clear();
                TbFieldX.Clear();
                TbFieldY.Clear();
                TbFieldCoordID.Focus();
            }
            else
            {
                MessageBox.Show("You must enter the same number of values!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbFieldCoordID.Focus();
            }
            #endregion

            #region Adding new Orchard Coordinates

            if (int.Equals(ListOfOrchardID.Length, 0) &&
               int.Equals(ListOfOrchardX.Length, 0) &&
               int.Equals(ListOfOrchardY.Length, 0) &&
               int.Equals(ListOfElevation.Length, 0))
            {
                if (LvOrchard.Items.Count == 0)
                {
                    MessageBox.Show("Enter the coordinates of Orchard!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            else if (int.Equals(ListOfOrchardID.Length, ListOfOrchardX.Length) &&
                    int.Equals(ListOfOrchardID.Length, ListOfOrchardY.Length) &&
                    int.Equals(ListOfOrchardID.Length, ListOfElevation.Length))
            {
                if (string.IsNullOrEmpty(TbRows.Text))
                {
                    MessageBox.Show("You must enter number of Rows!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    #region Input separation
                    StrarrOrchardID = ListOfOrchardID.Split(separator);
                    StrarrOrchardX = ListOfOrchardX.Split(separator);
                    StrarrOrchardY = ListOfOrchardY.Split(separator);
                    StrarrOrchardElevation = ListOfElevation.Split(separator);

                    #endregion

                    FieldOrchardlenght = StrarrOrchardID.Length;
                    for (CoordOrchardCnt = 0; CoordOrchardCnt < FieldOrchardlenght; CoordOrchardCnt++)
                    {
                        #region Adding new Orchard Coordinates

                        ListViewItem newOrchardCoordinate = new ListViewItem(StrarrOrchardID[CoordOrchardCnt]);
                        newOrchardCoordinate.SubItems.Add(StrarrOrchardX[CoordOrchardCnt]);
                        newOrchardCoordinate.SubItems.Add(StrarrOrchardY[CoordOrchardCnt]);
                        newOrchardCoordinate.SubItems.Add(StrarrOrchardElevation[CoordOrchardCnt]);
                        LvOrchard.Items.Add(newOrchardCoordinate);

                        #endregion
                    }
                    
                    TbOrchardCoordID.Clear();
                    TbOrchardX.Clear();
                    TbOrchardY.Clear();
                    TbElevation.Clear();
                    TbOrchardCoordID.Focus();
                }
            }
            else
            {
                MessageBox.Show("You must enter the same number of values!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbOrchardCoordID.Focus();
            }
            #endregion
        }

        private void BtnRemoveFieldCoord_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in LvField.SelectedItems)
            {
                LvField.Items.Remove(item);
            }

        }

        private void BtnRemoveOrchardCoord_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in LvOrchard.SelectedItems)
            {
                LvOrchard.Items.Remove(item);
            }

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (LvField.Items.Count == 0)
            {
                MessageBox.Show("Enter the coordinates of Field!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if(LvOrchard.Items.Count == 0)
            {
                MessageBox.Show("Enter the coordinates of Orchard!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                        Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                        Worksheet ws = (Worksheet)app.ActiveSheet;
                        app.Visible = false;
                        ws.Cells[1, 1] = "Oznake polja";
                        ws.Cells[1, 2] = "Koordinate polja X";
                        ws.Cells[1, 3] = "Koordinate polja Y";
                        ws.Cells[1, 4] = "Broj redova";
                        ws.Cells[1, 5] = "Oznake vocnjaka";
                        ws.Cells[1, 6] = "Koordinate vocnjaka X";
                        ws.Cells[1, 7] = "Koordinate vocnjaka Y";
                        ws.Cells[1, 8] = "Visinske kote vocnjaka";
                        int i = 2;
                        int j = 2;
                        foreach (ListViewItem item in LvField.Items)
                        {
                            ws.Cells[i, 1] = item.SubItems[0].Text;
                            ws.Cells[i, 2] = item.SubItems[1].Text;
                            ws.Cells[i, 3] = item.SubItems[2].Text;
                            i++;
                        }
                        ws.Cells[2, 4] = TbRows.Text;
                        foreach (ListViewItem item in LvOrchard.Items)
                        {
                            ws.Cells[j, 5] = item.SubItems[0].Text;
                            ws.Cells[j, 6] = item.SubItems[1].Text;
                            ws.Cells[j, 7] = item.SubItems[2].Text;
                            ws.Cells[j, 8] = item.SubItems[3].Text;
                            j++;
                        }
                        wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                        app.Quit();
                        MessageBox.Show("Your data has been successfully created.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void BtnAdd_MouseEnter(object sender, EventArgs e)
        {
            BtnAdd.BackColor = Color.DeepSkyBlue;
        }

        private void BtnAdd_MouseLeave(object sender, EventArgs e)
        {
            BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
        }

        private void BtnCreate_MouseEnter(object sender, EventArgs e)
        {
            BtnCreate.BackColor = Color.DeepSkyBlue;
        }

        private void BtnCreate_MouseLeave(object sender, EventArgs e)
        {
            BtnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
        }

        private void btnRemoveFieldCoord_MouseEnter(object sender, EventArgs e)
        {
            btnRemoveFieldCoord.BackColor = Color.DeepSkyBlue;
            btnRemoveFieldCoord.ForeColor = Color.Gainsboro;
        }

        private void btnRemoveFieldCoord_MouseLeave(object sender, EventArgs e)
        {
            btnRemoveFieldCoord.BackColor = Color.White;
            btnRemoveFieldCoord.ForeColor = Color.Black;
        }

        private void btnRemoveOrchardCoord_MouseEnter(object sender, EventArgs e)
        {
            btnRemoveOrchardCoord.BackColor = Color.DeepSkyBlue;
            btnRemoveOrchardCoord.ForeColor = Color.Gainsboro;
        }

        private void btnRemoveOrchardCoord_MouseLeave(object sender, EventArgs e)
        {
            btnRemoveOrchardCoord.BackColor = Color.White;
            btnRemoveOrchardCoord.ForeColor = Color.Black;
        }
    }
}

       

