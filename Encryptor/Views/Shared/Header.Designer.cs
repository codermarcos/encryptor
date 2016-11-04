namespace Encryptor.Views.Shared
{
    partial class Header
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.head = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.minBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.menuSubHeader = new System.Windows.Forms.MenuStrip();
            this.criptografiasBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.hashBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.simetricasBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.assimetricasBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.conclusaoBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.body = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.menuSubHeader.SuspendLayout();
            this.body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Encryptor";
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.Color.DimGray;
            this.head.Controls.Add(this.label2);
            this.head.Controls.Add(this.minBtn);
            this.head.Controls.Add(this.exitBtn);
            this.head.Controls.Add(this.pictureLogo);
            this.head.Dock = System.Windows.Forms.DockStyle.Top;
            this.head.Location = new System.Drawing.Point(0, 0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(720, 34);
            this.head.TabIndex = 10;
            this.head.MouseDown += new System.Windows.Forms.MouseEventHandler(this.head_MouseDown);
            this.head.MouseMove += new System.Windows.Forms.MouseEventHandler(this.head_MouseMove);
            this.head.MouseUp += new System.Windows.Forms.MouseEventHandler(this.head_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Encryptor";
            // 
            // minBtn
            // 
            this.minBtn.BackgroundImage = global::Encryptor.Properties.Resources.MIN;
            this.minBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minBtn.CausesValidation = false;
            this.minBtn.FlatAppearance.BorderSize = 0;
            this.minBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minBtn.Location = new System.Drawing.Point(601, 4);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(55, 25);
            this.minBtn.TabIndex = 9;
            this.minBtn.UseVisualStyleBackColor = true;
            this.minBtn.Click += new System.EventHandler(this.Minificar);
            // 
            // exitBtn
            // 
            this.exitBtn.BackgroundImage = global::Encryptor.Properties.Resources.EXIT;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitBtn.CausesValidation = false;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(662, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(55, 25);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.Sair);
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::Encryptor.Properties.Resources.ICONE;
            this.pictureLogo.Location = new System.Drawing.Point(3, 2);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(44, 32);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 7;
            this.pictureLogo.TabStop = false;
            // 
            // menuSubHeader
            // 
            this.menuSubHeader.BackColor = System.Drawing.Color.Silver;
            this.menuSubHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criptografiasBtn,
            this.conclusaoBtn,
            this.grupoBtn});
            this.menuSubHeader.Location = new System.Drawing.Point(0, 0);
            this.menuSubHeader.Name = "menuSubHeader";
            this.menuSubHeader.Size = new System.Drawing.Size(720, 30);
            this.menuSubHeader.TabIndex = 9;
            this.menuSubHeader.Text = "menuStrip1";
            // 
            // criptografiasBtn
            // 
            this.criptografiasBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hashBtn,
            this.simetricasBtn,
            this.assimetricasBtn});
            this.criptografiasBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criptografiasBtn.Name = "criptografiasBtn";
            this.criptografiasBtn.Size = new System.Drawing.Size(129, 26);
            this.criptografiasBtn.Text = "CRIPTOGRAFIAS";
            // 
            // hashBtn
            // 
            this.hashBtn.Name = "hashBtn";
            this.hashBtn.Size = new System.Drawing.Size(176, 26);
            this.hashBtn.Text = "HASH";
            this.hashBtn.Click += new System.EventHandler(this.CallHashFrm);
            // 
            // simetricasBtn
            // 
            this.simetricasBtn.Name = "simetricasBtn";
            this.simetricasBtn.Size = new System.Drawing.Size(176, 26);
            this.simetricasBtn.Text = "SIMETRICAS";
            this.simetricasBtn.Click += new System.EventHandler(this.CallSimetricasFrm);
            // 
            // assimetricasBtn
            // 
            this.assimetricasBtn.Name = "assimetricasBtn";
            this.assimetricasBtn.Size = new System.Drawing.Size(176, 26);
            this.assimetricasBtn.Text = "ASSIMETRICAS";
            this.assimetricasBtn.Click += new System.EventHandler(this.CallAssimetricasFrm);
            // 
            // conclusaoBtn
            // 
            this.conclusaoBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conclusaoBtn.Name = "conclusaoBtn";
            this.conclusaoBtn.Size = new System.Drawing.Size(102, 26);
            this.conclusaoBtn.Text = "CONCLUSÃO";
            this.conclusaoBtn.Click += new System.EventHandler(this.CallConclusaoFrm);
            // 
            // grupoBtn
            // 
            this.grupoBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoBtn.Name = "grupoBtn";
            this.grupoBtn.Size = new System.Drawing.Size(70, 26);
            this.grupoBtn.Text = "GRUPO";
            this.grupoBtn.Click += new System.EventHandler(this.CallGrupoFrm);
            // 
            // body
            // 
            this.body.BackColor = System.Drawing.Color.Transparent;
            this.body.Controls.Add(this.menuSubHeader);
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(0, 34);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(720, 132);
            this.body.TabIndex = 11;
            // 
            // btnMin
            // 
            this.btnMin.BackgroundImage = global::Encryptor.Properties.Resources.MIN;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMin.CausesValidation = false;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(610, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(55, 25);
            this.btnMin.TabIndex = 5;
            this.btnMin.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Encryptor.Properties.Resources.EXIT;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.CausesValidation = false;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(665, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 25);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // logo
            // 
            this.logo.Image = global::Encryptor.Properties.Resources.ICONE;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(44, 32);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // Header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.body);
            this.Controls.Add(this.head);
            this.Name = "Header";
            this.Size = new System.Drawing.Size(720, 166);
            this.Load += new System.EventHandler(this.Header_Load);
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.menuSubHeader.ResumeLayout(false);
            this.menuSubHeader.PerformLayout();
            this.body.ResumeLayout(false);
            this.body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuSubHeader;
        private System.Windows.Forms.ToolStripMenuItem criptografiasBtn;
        private System.Windows.Forms.ToolStripMenuItem hashBtn;
        private System.Windows.Forms.ToolStripMenuItem simetricasBtn;
        private System.Windows.Forms.ToolStripMenuItem assimetricasBtn;
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.ToolStripMenuItem conclusaoBtn;
        private System.Windows.Forms.ToolStripMenuItem grupoBtn;
    }
}
