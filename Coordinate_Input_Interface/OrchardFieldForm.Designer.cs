
namespace Coordinate_Input_Interface
{
    partial class OrchardFieldForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Field_coordinates = new System.Windows.Forms.ListView();
            this.FieldCoordMark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FieldCoordX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FieldCoordY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.X_FieldValue = new System.Windows.Forms.TextBox();
            this.Y_FieldValue = new System.Windows.Forms.TextBox();
            this.lblFieldY = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRemoveFieldCoord = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.FieldCoordID = new System.Windows.Forms.TextBox();
            this.lblFieldMark = new System.Windows.Forms.Label();
            this.lblFieldX = new System.Windows.Forms.Label();
            this.Orchard_coordinates = new System.Windows.Forms.ListView();
            this.OrchardCoordX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrchardCoordY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblOrchardX = new System.Windows.Forms.Label();
            this.Y_OrchardValue = new System.Windows.Forms.TextBox();
            this.lblOrchardY = new System.Windows.Forms.Label();
            this.X_OrchardValue = new System.Windows.Forms.TextBox();
            this.lblOrchardRows = new System.Windows.Forms.Label();
            this.lblTitleOrchard = new System.Windows.Forms.Label();
            this.NumberOfRows = new System.Windows.Forms.TextBox();
            this.btnRemoveOrchardCoord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Field_coordinates
            // 
            this.Field_coordinates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FieldCoordMark,
            this.FieldCoordX,
            this.FieldCoordY});
            this.Field_coordinates.FullRowSelect = true;
            this.Field_coordinates.GridLines = true;
            this.Field_coordinates.HideSelection = false;
            this.Field_coordinates.Location = new System.Drawing.Point(45, 219);
            this.Field_coordinates.Name = "Field_coordinates";
            this.Field_coordinates.Size = new System.Drawing.Size(385, 216);
            this.Field_coordinates.TabIndex = 3;
            this.Field_coordinates.UseCompatibleStateImageBehavior = false;
            this.Field_coordinates.View = System.Windows.Forms.View.Details;
            // 
            // FieldCoordMark
            // 
            this.FieldCoordMark.Text = "FieldCoordMark";
            this.FieldCoordMark.Width = 100;
            // 
            // FieldCoordX
            // 
            this.FieldCoordX.Text = "FieldCoordX";
            this.FieldCoordX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FieldCoordX.Width = 140;
            // 
            // FieldCoordY
            // 
            this.FieldCoordY.Text = "FieldCoordY";
            this.FieldCoordY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FieldCoordY.Width = 140;
            // 
            // X_FieldValue
            // 
            this.X_FieldValue.Location = new System.Drawing.Point(168, 99);
            this.X_FieldValue.Name = "X_FieldValue";
            this.X_FieldValue.Size = new System.Drawing.Size(129, 20);
            this.X_FieldValue.TabIndex = 4;
            // 
            // Y_FieldValue
            // 
            this.Y_FieldValue.Location = new System.Drawing.Point(168, 139);
            this.Y_FieldValue.Name = "Y_FieldValue";
            this.Y_FieldValue.Size = new System.Drawing.Size(129, 20);
            this.Y_FieldValue.TabIndex = 6;
            // 
            // lblFieldY
            // 
            this.lblFieldY.AutoSize = true;
            this.lblFieldY.Location = new System.Drawing.Point(48, 142);
            this.lblFieldY.Name = "lblFieldY";
            this.lblFieldY.Size = new System.Drawing.Size(96, 13);
            this.lblFieldY.TabIndex = 5;
            this.lblFieldY.Text = "Koordinate polja  Y";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(48, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 13);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Unos koordinata polja";
            // 
            // btnRemoveFieldCoord
            // 
            this.btnRemoveFieldCoord.Location = new System.Drawing.Point(306, 190);
            this.btnRemoveFieldCoord.Name = "btnRemoveFieldCoord";
            this.btnRemoveFieldCoord.Size = new System.Drawing.Size(124, 23);
            this.btnRemoveFieldCoord.TabIndex = 8;
            this.btnRemoveFieldCoord.Text = "&Ukloni koordinatu polja";
            this.btnRemoveFieldCoord.UseVisualStyleBackColor = true;
            this.btnRemoveFieldCoord.Click += new System.EventHandler(this.btnRemoveFieldCoord_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(634, 99);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "&Dodaj koordinate";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(656, 447);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(95, 23);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "&KreirajPolje";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // FieldCoordID
            // 
            this.FieldCoordID.Location = new System.Drawing.Point(168, 60);
            this.FieldCoordID.Name = "FieldCoordID";
            this.FieldCoordID.Size = new System.Drawing.Size(129, 20);
            this.FieldCoordID.TabIndex = 12;
            // 
            // lblFieldMark
            // 
            this.lblFieldMark.AutoSize = true;
            this.lblFieldMark.Location = new System.Drawing.Point(48, 63);
            this.lblFieldMark.Name = "lblFieldMark";
            this.lblFieldMark.Size = new System.Drawing.Size(97, 13);
            this.lblFieldMark.TabIndex = 11;
            this.lblFieldMark.Text = "Oznaka koordinate";
            // 
            // lblFieldX
            // 
            this.lblFieldX.AutoSize = true;
            this.lblFieldX.Location = new System.Drawing.Point(48, 99);
            this.lblFieldX.Name = "lblFieldX";
            this.lblFieldX.Size = new System.Drawing.Size(96, 13);
            this.lblFieldX.TabIndex = 13;
            this.lblFieldX.Text = "Koordinate polja  X";
            // 
            // Orchard_coordinates
            // 
            this.Orchard_coordinates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrchardCoordX,
            this.OrchardCoordY});
            this.Orchard_coordinates.FullRowSelect = true;
            this.Orchard_coordinates.GridLines = true;
            this.Orchard_coordinates.HideSelection = false;
            this.Orchard_coordinates.Location = new System.Drawing.Point(463, 219);
            this.Orchard_coordinates.Name = "Orchard_coordinates";
            this.Orchard_coordinates.Size = new System.Drawing.Size(288, 216);
            this.Orchard_coordinates.TabIndex = 14;
            this.Orchard_coordinates.UseCompatibleStateImageBehavior = false;
            this.Orchard_coordinates.View = System.Windows.Forms.View.Details;
            // 
            // OrchardCoordX
            // 
            this.OrchardCoordX.Text = "OrchardCoordX";
            this.OrchardCoordX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OrchardCoordX.Width = 140;
            // 
            // OrchardCoordY
            // 
            this.OrchardCoordY.Text = "OrchardCoordY";
            this.OrchardCoordY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OrchardCoordY.Width = 140;
            // 
            // lblOrchardX
            // 
            this.lblOrchardX.AutoSize = true;
            this.lblOrchardX.Location = new System.Drawing.Point(347, 99);
            this.lblOrchardX.Name = "lblOrchardX";
            this.lblOrchardX.Size = new System.Drawing.Size(118, 13);
            this.lblOrchardX.TabIndex = 18;
            this.lblOrchardX.Text = "Koordinate vočnjaka  X";
            // 
            // Y_OrchardValue
            // 
            this.Y_OrchardValue.Location = new System.Drawing.Point(483, 139);
            this.Y_OrchardValue.Name = "Y_OrchardValue";
            this.Y_OrchardValue.Size = new System.Drawing.Size(129, 20);
            this.Y_OrchardValue.TabIndex = 17;
            // 
            // lblOrchardY
            // 
            this.lblOrchardY.AutoSize = true;
            this.lblOrchardY.Location = new System.Drawing.Point(347, 142);
            this.lblOrchardY.Name = "lblOrchardY";
            this.lblOrchardY.Size = new System.Drawing.Size(115, 13);
            this.lblOrchardY.TabIndex = 16;
            this.lblOrchardY.Text = "Koordinate vočnjaka Y";
            // 
            // X_OrchardValue
            // 
            this.X_OrchardValue.Location = new System.Drawing.Point(483, 99);
            this.X_OrchardValue.Name = "X_OrchardValue";
            this.X_OrchardValue.Size = new System.Drawing.Size(129, 20);
            this.X_OrchardValue.TabIndex = 15;
            // 
            // lblOrchardRows
            // 
            this.lblOrchardRows.AutoSize = true;
            this.lblOrchardRows.Location = new System.Drawing.Point(347, 60);
            this.lblOrchardRows.Name = "lblOrchardRows";
            this.lblOrchardRows.Size = new System.Drawing.Size(108, 13);
            this.lblOrchardRows.TabIndex = 19;
            this.lblOrchardRows.Text = "Broj redova vočnjaka";
            // 
            // lblTitleOrchard
            // 
            this.lblTitleOrchard.AutoSize = true;
            this.lblTitleOrchard.Location = new System.Drawing.Point(346, 25);
            this.lblTitleOrchard.Name = "lblTitleOrchard";
            this.lblTitleOrchard.Size = new System.Drawing.Size(132, 13);
            this.lblTitleOrchard.TabIndex = 21;
            this.lblTitleOrchard.Text = "Unos koordinata vočnjaka";
            // 
            // NumberOfRows
            // 
            this.NumberOfRows.Location = new System.Drawing.Point(483, 60);
            this.NumberOfRows.Name = "NumberOfRows";
            this.NumberOfRows.Size = new System.Drawing.Size(129, 20);
            this.NumberOfRows.TabIndex = 22;
            // 
            // btnRemoveOrchardCoord
            // 
            this.btnRemoveOrchardCoord.Location = new System.Drawing.Point(604, 190);
            this.btnRemoveOrchardCoord.Name = "btnRemoveOrchardCoord";
            this.btnRemoveOrchardCoord.Size = new System.Drawing.Size(147, 23);
            this.btnRemoveOrchardCoord.TabIndex = 23;
            this.btnRemoveOrchardCoord.Text = "&Ukloni koordinatu vočnjaka";
            this.btnRemoveOrchardCoord.UseVisualStyleBackColor = true;
            this.btnRemoveOrchardCoord.Click += new System.EventHandler(this.btnRemoveOrchardCoord_Click);
            // 
            // OrchardFieldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 482);
            this.Controls.Add(this.btnRemoveOrchardCoord);
            this.Controls.Add(this.NumberOfRows);
            this.Controls.Add(this.lblTitleOrchard);
            this.Controls.Add(this.lblOrchardRows);
            this.Controls.Add(this.lblOrchardX);
            this.Controls.Add(this.Y_OrchardValue);
            this.Controls.Add(this.lblOrchardY);
            this.Controls.Add(this.X_OrchardValue);
            this.Controls.Add(this.Orchard_coordinates);
            this.Controls.Add(this.lblFieldX);
            this.Controls.Add(this.FieldCoordID);
            this.Controls.Add(this.lblFieldMark);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemoveFieldCoord);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.Y_FieldValue);
            this.Controls.Add(this.lblFieldY);
            this.Controls.Add(this.X_FieldValue);
            this.Controls.Add(this.Field_coordinates);
            this.Name = "OrchardFieldForm";
            this.Text = "OrchardFieldForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView Field_coordinates;
        private System.Windows.Forms.ColumnHeader FieldCoordMark;
        private System.Windows.Forms.ColumnHeader FieldCoordX;
        private System.Windows.Forms.ColumnHeader FieldCoordY;
        private System.Windows.Forms.TextBox X_FieldValue;
        private System.Windows.Forms.TextBox Y_FieldValue;
        private System.Windows.Forms.Label lblFieldY;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRemoveFieldCoord;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox FieldCoordID;
        private System.Windows.Forms.Label lblFieldMark;
        private System.Windows.Forms.Label lblFieldX;
        private System.Windows.Forms.ListView Orchard_coordinates;
        private System.Windows.Forms.ColumnHeader OrchardCoordX;
        private System.Windows.Forms.ColumnHeader OrchardCoordY;
        private System.Windows.Forms.Label lblOrchardX;
        private System.Windows.Forms.TextBox Y_OrchardValue;
        private System.Windows.Forms.Label lblOrchardY;
        private System.Windows.Forms.TextBox X_OrchardValue;
        private System.Windows.Forms.Label lblOrchardRows;
        private System.Windows.Forms.Label lblTitleOrchard;
        private System.Windows.Forms.TextBox NumberOfRows;
        private System.Windows.Forms.Button btnRemoveOrchardCoord;
    }
}

