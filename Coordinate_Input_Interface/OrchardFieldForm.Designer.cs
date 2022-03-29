
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrchardFieldForm));
            this.TbFieldX = new System.Windows.Forms.TextBox();
            this.TbFieldY = new System.Windows.Forms.TextBox();
            this.lblFieldY = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.TbFieldCoordID = new System.Windows.Forms.TextBox();
            this.lblFieldMark = new System.Windows.Forms.Label();
            this.lblFieldX = new System.Windows.Forms.Label();
            this.lblOrchardX = new System.Windows.Forms.Label();
            this.TbOrchardY = new System.Windows.Forms.TextBox();
            this.lblOrchardY = new System.Windows.Forms.Label();
            this.TbOrchardX = new System.Windows.Forms.TextBox();
            this.lblOrchardRows = new System.Windows.Forms.Label();
            this.TbRows = new System.Windows.Forms.TextBox();
            this.TbOrchardCoordID = new System.Windows.Forms.TextBox();
            this.lblOrchardMark = new System.Windows.Forms.Label();
            this.TbElevation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputPnel = new System.Windows.Forms.Panel();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.PenelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRemoveFieldCoord = new System.Windows.Forms.Button();
            this.btnRemoveOrchardCoord = new System.Windows.Forms.Button();
            this.LvField = new System.Windows.Forms.ListView();
            this.FieldCoordMark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FieldCoordX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FieldCoordY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvOrchard = new System.Windows.Forms.ListView();
            this.OrchardCoordMark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrchardCoordX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrchardCoordY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrchardElevation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InputPnel.SuspendLayout();
            this.PenelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbFieldX
            // 
            this.TbFieldX.Location = new System.Drawing.Point(138, 217);
            this.TbFieldX.Name = "TbFieldX";
            this.TbFieldX.Size = new System.Drawing.Size(129, 20);
            this.TbFieldX.TabIndex = 4;
            // 
            // TbFieldY
            // 
            this.TbFieldY.Location = new System.Drawing.Point(138, 257);
            this.TbFieldY.Name = "TbFieldY";
            this.TbFieldY.Size = new System.Drawing.Size(129, 20);
            this.TbFieldY.TabIndex = 6;
            // 
            // lblFieldY
            // 
            this.lblFieldY.AutoSize = true;
            this.lblFieldY.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFieldY.Location = new System.Drawing.Point(18, 260);
            this.lblFieldY.Name = "lblFieldY";
            this.lblFieldY.Size = new System.Drawing.Size(96, 13);
            this.lblFieldY.TabIndex = 5;
            this.lblFieldY.Text = "Koordinate polja  Y";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnAdd.Location = new System.Drawing.Point(0, 566);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(306, 42);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "&Dodaj koordinate";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            this.BtnAdd.MouseEnter += new System.EventHandler(this.BtnAdd_MouseEnter);
            this.BtnAdd.MouseLeave += new System.EventHandler(this.BtnAdd_MouseLeave);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnCreate.FlatAppearance.BorderSize = 0;
            this.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreate.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnCreate.Location = new System.Drawing.Point(0, 608);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(306, 42);
            this.BtnCreate.TabIndex = 10;
            this.BtnCreate.Text = "&KreirajPolje";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            this.BtnCreate.MouseEnter += new System.EventHandler(this.BtnCreate_MouseEnter);
            this.BtnCreate.MouseLeave += new System.EventHandler(this.BtnCreate_MouseLeave);
            // 
            // TbFieldCoordID
            // 
            this.TbFieldCoordID.Location = new System.Drawing.Point(138, 178);
            this.TbFieldCoordID.Name = "TbFieldCoordID";
            this.TbFieldCoordID.Size = new System.Drawing.Size(129, 20);
            this.TbFieldCoordID.TabIndex = 12;
            // 
            // lblFieldMark
            // 
            this.lblFieldMark.AutoSize = true;
            this.lblFieldMark.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFieldMark.Location = new System.Drawing.Point(18, 181);
            this.lblFieldMark.Name = "lblFieldMark";
            this.lblFieldMark.Size = new System.Drawing.Size(97, 13);
            this.lblFieldMark.TabIndex = 11;
            this.lblFieldMark.Text = "Oznaka koordinate";
            // 
            // lblFieldX
            // 
            this.lblFieldX.AutoSize = true;
            this.lblFieldX.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFieldX.Location = new System.Drawing.Point(18, 217);
            this.lblFieldX.Name = "lblFieldX";
            this.lblFieldX.Size = new System.Drawing.Size(96, 13);
            this.lblFieldX.TabIndex = 13;
            this.lblFieldX.Text = "Koordinate polja  X";
            // 
            // lblOrchardX
            // 
            this.lblOrchardX.AutoSize = true;
            this.lblOrchardX.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblOrchardX.Location = new System.Drawing.Point(18, 400);
            this.lblOrchardX.Name = "lblOrchardX";
            this.lblOrchardX.Size = new System.Drawing.Size(115, 13);
            this.lblOrchardX.TabIndex = 18;
            this.lblOrchardX.Text = "Koordinate vocnjaka X";
            // 
            // TbOrchardY
            // 
            this.TbOrchardY.Location = new System.Drawing.Point(154, 440);
            this.TbOrchardY.Name = "TbOrchardY";
            this.TbOrchardY.Size = new System.Drawing.Size(129, 20);
            this.TbOrchardY.TabIndex = 17;
            // 
            // lblOrchardY
            // 
            this.lblOrchardY.AutoSize = true;
            this.lblOrchardY.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblOrchardY.Location = new System.Drawing.Point(18, 443);
            this.lblOrchardY.Name = "lblOrchardY";
            this.lblOrchardY.Size = new System.Drawing.Size(115, 13);
            this.lblOrchardY.TabIndex = 16;
            this.lblOrchardY.Text = "Koordinate vocnjaka Y";
            // 
            // TbOrchardX
            // 
            this.TbOrchardX.Location = new System.Drawing.Point(154, 400);
            this.TbOrchardX.Name = "TbOrchardX";
            this.TbOrchardX.Size = new System.Drawing.Size(129, 20);
            this.TbOrchardX.TabIndex = 15;
            // 
            // lblOrchardRows
            // 
            this.lblOrchardRows.AutoSize = true;
            this.lblOrchardRows.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblOrchardRows.Location = new System.Drawing.Point(18, 324);
            this.lblOrchardRows.Name = "lblOrchardRows";
            this.lblOrchardRows.Size = new System.Drawing.Size(108, 13);
            this.lblOrchardRows.TabIndex = 19;
            this.lblOrchardRows.Text = "Broj redova vocnjaka";
            // 
            // TbRows
            // 
            this.TbRows.Location = new System.Drawing.Point(154, 321);
            this.TbRows.Name = "TbRows";
            this.TbRows.Size = new System.Drawing.Size(129, 20);
            this.TbRows.TabIndex = 22;
            // 
            // TbOrchardCoordID
            // 
            this.TbOrchardCoordID.Location = new System.Drawing.Point(154, 360);
            this.TbOrchardCoordID.Name = "TbOrchardCoordID";
            this.TbOrchardCoordID.Size = new System.Drawing.Size(129, 20);
            this.TbOrchardCoordID.TabIndex = 25;
            // 
            // lblOrchardMark
            // 
            this.lblOrchardMark.AutoSize = true;
            this.lblOrchardMark.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblOrchardMark.Location = new System.Drawing.Point(18, 360);
            this.lblOrchardMark.Name = "lblOrchardMark";
            this.lblOrchardMark.Size = new System.Drawing.Size(100, 13);
            this.lblOrchardMark.TabIndex = 26;
            this.lblOrchardMark.Text = "Oznaka koordinate ";
            // 
            // TbElevation
            // 
            this.TbElevation.Location = new System.Drawing.Point(154, 485);
            this.TbElevation.Name = "TbElevation";
            this.TbElevation.Size = new System.Drawing.Size(129, 20);
            this.TbElevation.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(18, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Visinske kote vocnjaka";
            // 
            // InputPnel
            // 
            this.InputPnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.InputPnel.Controls.Add(this.PanelLogo);
            this.InputPnel.Controls.Add(this.TbElevation);
            this.InputPnel.Controls.Add(this.BtnAdd);
            this.InputPnel.Controls.Add(this.label1);
            this.InputPnel.Controls.Add(this.BtnCreate);
            this.InputPnel.Controls.Add(this.lblOrchardMark);
            this.InputPnel.Controls.Add(this.TbOrchardCoordID);
            this.InputPnel.Controls.Add(this.lblFieldX);
            this.InputPnel.Controls.Add(this.TbFieldX);
            this.InputPnel.Controls.Add(this.TbRows);
            this.InputPnel.Controls.Add(this.lblFieldY);
            this.InputPnel.Controls.Add(this.TbFieldY);
            this.InputPnel.Controls.Add(this.lblOrchardRows);
            this.InputPnel.Controls.Add(this.lblFieldMark);
            this.InputPnel.Controls.Add(this.lblOrchardX);
            this.InputPnel.Controls.Add(this.TbFieldCoordID);
            this.InputPnel.Controls.Add(this.TbOrchardY);
            this.InputPnel.Controls.Add(this.TbOrchardX);
            this.InputPnel.Controls.Add(this.lblOrchardY);
            this.InputPnel.Dock = System.Windows.Forms.DockStyle.Left;
            this.InputPnel.Location = new System.Drawing.Point(0, 0);
            this.InputPnel.Name = "InputPnel";
            this.InputPnel.Size = new System.Drawing.Size(306, 650);
            this.InputPnel.TabIndex = 29;
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(306, 122);
            this.PanelLogo.TabIndex = 0;
            // 
            // PenelTitle
            // 
            this.PenelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.PenelTitle.Controls.Add(this.lblTitle);
            this.PenelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PenelTitle.Location = new System.Drawing.Point(306, 0);
            this.PenelTitle.Name = "PenelTitle";
            this.PenelTitle.Size = new System.Drawing.Size(1060, 122);
            this.PenelTitle.TabIndex = 30;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Magneto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(405, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(268, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Unos Koordinata Vocnjaka";
            // 
            // btnRemoveFieldCoord
            // 
            this.btnRemoveFieldCoord.BackColor = System.Drawing.Color.White;
            this.btnRemoveFieldCoord.FlatAppearance.BorderSize = 0;
            this.btnRemoveFieldCoord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFieldCoord.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveFieldCoord.Location = new System.Drawing.Point(676, 572);
            this.btnRemoveFieldCoord.Name = "btnRemoveFieldCoord";
            this.btnRemoveFieldCoord.Size = new System.Drawing.Size(158, 36);
            this.btnRemoveFieldCoord.TabIndex = 8;
            this.btnRemoveFieldCoord.Text = "&Ukloni koordinatu polja";
            this.btnRemoveFieldCoord.UseVisualStyleBackColor = false;
            this.btnRemoveFieldCoord.Click += new System.EventHandler(this.BtnRemoveFieldCoord_Click);
            this.btnRemoveFieldCoord.MouseEnter += new System.EventHandler(this.btnRemoveFieldCoord_MouseEnter);
            this.btnRemoveFieldCoord.MouseLeave += new System.EventHandler(this.btnRemoveFieldCoord_MouseLeave);
            // 
            // btnRemoveOrchardCoord
            // 
            this.btnRemoveOrchardCoord.FlatAppearance.BorderSize = 0;
            this.btnRemoveOrchardCoord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveOrchardCoord.Location = new System.Drawing.Point(1196, 569);
            this.btnRemoveOrchardCoord.Name = "btnRemoveOrchardCoord";
            this.btnRemoveOrchardCoord.Size = new System.Drawing.Size(158, 36);
            this.btnRemoveOrchardCoord.TabIndex = 23;
            this.btnRemoveOrchardCoord.Text = "&Ukloni koordinatu vocnjaka";
            this.btnRemoveOrchardCoord.UseVisualStyleBackColor = true;
            this.btnRemoveOrchardCoord.Click += new System.EventHandler(this.BtnRemoveOrchardCoord_Click);
            this.btnRemoveOrchardCoord.MouseEnter += new System.EventHandler(this.btnRemoveOrchardCoord_MouseEnter);
            this.btnRemoveOrchardCoord.MouseLeave += new System.EventHandler(this.btnRemoveOrchardCoord_MouseLeave);
            // 
            // LvField
            // 
            this.LvField.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FieldCoordMark,
            this.FieldCoordX,
            this.FieldCoordY});
            this.LvField.FullRowSelect = true;
            this.LvField.HideSelection = false;
            this.LvField.Location = new System.Drawing.Point(346, 171);
            this.LvField.Name = "LvField";
            this.LvField.Size = new System.Drawing.Size(488, 395);
            this.LvField.TabIndex = 3;
            this.LvField.UseCompatibleStateImageBehavior = false;
            this.LvField.View = System.Windows.Forms.View.Details;
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
            // LvOrchard
            // 
            this.LvOrchard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrchardCoordMark,
            this.OrchardCoordX,
            this.OrchardCoordY,
            this.OrchardElevation});
            this.LvOrchard.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LvOrchard.FullRowSelect = true;
            this.LvOrchard.HideSelection = false;
            this.LvOrchard.Location = new System.Drawing.Point(860, 171);
            this.LvOrchard.Name = "LvOrchard";
            this.LvOrchard.Size = new System.Drawing.Size(488, 392);
            this.LvOrchard.TabIndex = 14;
            this.LvOrchard.UseCompatibleStateImageBehavior = false;
            this.LvOrchard.View = System.Windows.Forms.View.Details;
            // 
            // OrchardCoordMark
            // 
            this.OrchardCoordMark.Text = "OrchardCoordMark";
            this.OrchardCoordMark.Width = 120;
            // 
            // OrchardCoordX
            // 
            this.OrchardCoordX.Text = "OrchardCoordX";
            this.OrchardCoordX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OrchardCoordX.Width = 120;
            // 
            // OrchardCoordY
            // 
            this.OrchardCoordY.Text = "OrchardCoordY";
            this.OrchardCoordY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OrchardCoordY.Width = 120;
            // 
            // OrchardElevation
            // 
            this.OrchardElevation.Text = "Elevation";
            this.OrchardElevation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OrchardElevation.Width = 120;
            // 
            // OrchardFieldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1366, 650);
            this.Controls.Add(this.LvOrchard);
            this.Controls.Add(this.btnRemoveFieldCoord);
            this.Controls.Add(this.LvField);
            this.Controls.Add(this.btnRemoveOrchardCoord);
            this.Controls.Add(this.PenelTitle);
            this.Controls.Add(this.InputPnel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrchardFieldForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrchardFieldForm";
            this.InputPnel.ResumeLayout(false);
            this.InputPnel.PerformLayout();
            this.PenelTitle.ResumeLayout(false);
            this.PenelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TbFieldX;
        private System.Windows.Forms.TextBox TbFieldY;
        private System.Windows.Forms.Label lblFieldY;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.TextBox TbFieldCoordID;
        private System.Windows.Forms.Label lblFieldMark;
        private System.Windows.Forms.Label lblFieldX;
        private System.Windows.Forms.Label lblOrchardX;
        private System.Windows.Forms.TextBox TbOrchardY;
        private System.Windows.Forms.Label lblOrchardY;
        private System.Windows.Forms.TextBox TbOrchardX;
        private System.Windows.Forms.Label lblOrchardRows;
        private System.Windows.Forms.TextBox TbRows;
        private System.Windows.Forms.TextBox TbOrchardCoordID;
        private System.Windows.Forms.Label lblOrchardMark;
        private System.Windows.Forms.TextBox TbElevation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel InputPnel;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Panel PenelTitle;
        private System.Windows.Forms.Button btnRemoveFieldCoord;
        private System.Windows.Forms.Button btnRemoveOrchardCoord;
        private System.Windows.Forms.ListView LvField;
        private System.Windows.Forms.ColumnHeader FieldCoordMark;
        private System.Windows.Forms.ColumnHeader FieldCoordX;
        private System.Windows.Forms.ColumnHeader FieldCoordY;
        private System.Windows.Forms.ListView LvOrchard;
        private System.Windows.Forms.ColumnHeader OrchardCoordMark;
        private System.Windows.Forms.ColumnHeader OrchardCoordX;
        private System.Windows.Forms.ColumnHeader OrchardCoordY;
        private System.Windows.Forms.ColumnHeader OrchardElevation;
        private System.Windows.Forms.Label lblTitle;
    }
}

