
namespace RestaurantApp
{
    partial class FrmPeopleQuantity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPeopleQuantity));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnContinue = new System.Windows.Forms.Button();
            this.lblCantidadPersona = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CbxCantidadDePersonas = new System.Windows.Forms.ComboBox();
            this.PnInit = new System.Windows.Forms.Panel();
            this.PbxIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.PnInit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.32323F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.67677F));
            this.tableLayoutPanel1.Controls.Add(this.BtnContinue, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCantidadPersona, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CbxCantidadDePersonas, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.82482F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.17518F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(495, 137);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BtnContinue
            // 
            this.BtnContinue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContinue.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnContinue.ForeColor = System.Drawing.Color.White;
            this.BtnContinue.Image = ((System.Drawing.Image)(resources.GetObject("BtnContinue.Image")));
            this.BtnContinue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnContinue.Location = new System.Drawing.Point(3, 74);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Size = new System.Drawing.Size(253, 60);
            this.BtnContinue.TabIndex = 3;
            this.BtnContinue.Text = "Continue";
            this.BtnContinue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnContinue.UseVisualStyleBackColor = true;
            this.BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // lblCantidadPersona
            // 
            this.lblCantidadPersona.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCantidadPersona.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadPersona.ForeColor = System.Drawing.Color.White;
            this.lblCantidadPersona.Location = new System.Drawing.Point(3, 44);
            this.lblCantidadPersona.Name = "lblCantidadPersona";
            this.lblCantidadPersona.Size = new System.Drawing.Size(253, 27);
            this.lblCantidadPersona.TabIndex = 0;
            this.lblCantidadPersona.Text = "Quantity of People:";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(262, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancelar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CbxCantidadDePersonas
            // 
            this.CbxCantidadDePersonas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CbxCantidadDePersonas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CbxCantidadDePersonas.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbxCantidadDePersonas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(46)))), ((int)(((byte)(119)))));
            this.CbxCantidadDePersonas.FormattingEnabled = true;
            this.CbxCantidadDePersonas.Location = new System.Drawing.Point(262, 41);
            this.CbxCantidadDePersonas.Name = "CbxCantidadDePersonas";
            this.CbxCantidadDePersonas.Size = new System.Drawing.Size(230, 27);
            this.CbxCantidadDePersonas.TabIndex = 1;
            // 
            // PnInit
            // 
            this.PnInit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(55)))), ((int)(((byte)(5)))));
            this.PnInit.Controls.Add(this.LblTitle);
            this.PnInit.Controls.Add(this.PbxIcon);
            this.PnInit.Controls.Add(this.pictureBox3);
            this.PnInit.Controls.Add(this.pictureBox2);
            this.PnInit.Controls.Add(this.pictureBox1);
            this.PnInit.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnInit.ForeColor = System.Drawing.Color.Black;
            this.PnInit.Location = new System.Drawing.Point(0, 0);
            this.PnInit.Name = "PnInit";
            this.PnInit.Size = new System.Drawing.Size(495, 34);
            this.PnInit.TabIndex = 1;
            this.PnInit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnInit_MouseDown);
            // 
            // PbxIcon
            // 
            this.PbxIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.PbxIcon.Image = ((System.Drawing.Image)(resources.GetObject("PbxIcon.Image")));
            this.PbxIcon.Location = new System.Drawing.Point(0, 0);
            this.PbxIcon.Name = "PbxIcon";
            this.PbxIcon.Size = new System.Drawing.Size(32, 34);
            this.PbxIcon.TabIndex = 15;
            this.PbxIcon.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(405, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 26);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(435, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 28);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(467, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 28);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(37, 5);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(131, 25);
            this.LblTitle.TabIndex = 17;
            this.LblTitle.Text = "QUANTITY PEOPLE";
            // 
            // FrmPeopleQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(495, 137);
            this.Controls.Add(this.PnInit);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPeopleQuantity";
            this.Text = "Quantity of People";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPeopleQuantity_FormClosed);
            this.Load += new System.EventHandler(this.FrmCantidadPersona_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PnInit.ResumeLayout(false);
            this.PnInit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox CbxCantidadDePersonas;
        private System.Windows.Forms.Label lblCantidadPersona;
        private System.Windows.Forms.Panel PnInit;
        private System.Windows.Forms.Button BtnContinue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox PbxIcon;
        private System.Windows.Forms.Label LblTitle;
    }
}