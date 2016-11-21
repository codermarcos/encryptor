using Encryptor.Views.Shared;

namespace Encryptor.Views.criptografias
{
    partial class MikcipherFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.criptografarBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptografarBtn = new System.Windows.Forms.Button();
            this.vPrivadaBtn = new System.Windows.Forms.CheckBox();
            this.privadaBox = new System.Windows.Forms.TextBox();
            this.outputLbl = new System.Windows.Forms.TextBox();
            this.header1 = new Encryptor.Views.Shared.Header();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vPublicaBtn = new System.Windows.Forms.CheckBox();
            this.publicaBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gerarR32 = new System.Windows.Forms.Button();
            this.gerarR24 = new System.Windows.Forms.Button();
            this.gerarR16 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.vgPrivadaBtn = new System.Windows.Forms.CheckBox();
            this.gPrivadaBox = new System.Windows.Forms.TextBox();
            this.gerarP32 = new System.Windows.Forms.Button();
            this.gerarP24 = new System.Windows.Forms.Button();
            this.gerarP16 = new System.Windows.Forms.Button();
            this.chaveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.vgPublicaBtn = new System.Windows.Forms.CheckBox();
            this.gPublicaBox = new System.Windows.Forms.TextBox();
            this.output_PublicKeyLbl = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "MIKCIPHER";
            // 
            // criptografarBtn
            // 
            this.criptografarBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criptografarBtn.Location = new System.Drawing.Point(6, 62);
            this.criptografarBtn.Name = "criptografarBtn";
            this.criptografarBtn.Size = new System.Drawing.Size(324, 40);
            this.criptografarBtn.TabIndex = 18;
            this.criptografarBtn.Text = "CRIPTOGRAFAR";
            this.criptografarBtn.UseVisualStyleBackColor = true;
            this.criptografarBtn.Click += new System.EventHandler(this.Criptografar);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(123, 335);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(105, 59);
            this.clearBtn.TabIndex = 16;
            this.clearBtn.Text = "LIMPAR";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.Limpar);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(234, 335);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(105, 59);
            this.saveBtn.TabIndex = 15;
            this.saveBtn.Text = "SALVAR";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.Salvar);
            // 
            // openBtn
            // 
            this.openBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openBtn.Location = new System.Drawing.Point(12, 335);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(105, 59);
            this.openBtn.TabIndex = 13;
            this.openBtn.Text = "ABRIR";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.OpenFile);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.descriptografarBtn);
            this.groupBox1.Controls.Add(this.vPrivadaBtn);
            this.groupBox1.Controls.Add(this.privadaBox);
            this.groupBox1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 110);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Decriptar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 22);
            this.label4.TabIndex = 30;
            this.label4.Text = "Chave Privada:";
            // 
            // descriptografarBtn
            // 
            this.descriptografarBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptografarBtn.Location = new System.Drawing.Point(6, 59);
            this.descriptografarBtn.Name = "descriptografarBtn";
            this.descriptografarBtn.Size = new System.Drawing.Size(324, 40);
            this.descriptografarBtn.TabIndex = 20;
            this.descriptografarBtn.Text = "DESCRIPTOGRAFAR";
            this.descriptografarBtn.UseVisualStyleBackColor = true;
            this.descriptografarBtn.Click += new System.EventHandler(this.Descriptografar);
            // 
            // vPrivadaBtn
            // 
            this.vPrivadaBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.vPrivadaBtn.AutoSize = true;
            this.vPrivadaBtn.Location = new System.Drawing.Point(304, 25);
            this.vPrivadaBtn.Name = "vPrivadaBtn";
            this.vPrivadaBtn.Size = new System.Drawing.Size(26, 32);
            this.vPrivadaBtn.TabIndex = 1;
            this.vPrivadaBtn.Text = "-";
            this.vPrivadaBtn.UseVisualStyleBackColor = true;
            this.vPrivadaBtn.CheckedChanged += new System.EventHandler(this.ChangeVisibility);
            // 
            // privadaBox
            // 
            this.privadaBox.Location = new System.Drawing.Point(131, 28);
            this.privadaBox.Name = "privadaBox";
            this.privadaBox.Size = new System.Drawing.Size(170, 28);
            this.privadaBox.TabIndex = 0;
            this.privadaBox.UseSystemPasswordChar = true;
            // 
            // outputLbl
            // 
            this.outputLbl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.outputLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputLbl.Location = new System.Drawing.Point(12, 400);
            this.outputLbl.Multiline = true;
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.ReadOnly = true;
            this.outputLbl.Size = new System.Drawing.Size(696, 308);
            this.outputLbl.TabIndex = 19;
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.Transparent;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(720, 166);
            this.header1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.criptografarBtn);
            this.groupBox2.Controls.Add(this.vPublicaBtn);
            this.groupBox2.Controls.Add(this.publicaBox);
            this.groupBox2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 115);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encriptar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 22);
            this.label5.TabIndex = 31;
            this.label5.Text = "Chave Publica:";
            // 
            // vPublicaBtn
            // 
            this.vPublicaBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.vPublicaBtn.AutoSize = true;
            this.vPublicaBtn.Location = new System.Drawing.Point(304, 26);
            this.vPublicaBtn.Name = "vPublicaBtn";
            this.vPublicaBtn.Size = new System.Drawing.Size(26, 32);
            this.vPublicaBtn.TabIndex = 1;
            this.vPublicaBtn.Text = "-";
            this.vPublicaBtn.UseVisualStyleBackColor = true;
            this.vPublicaBtn.CheckedChanged += new System.EventHandler(this.ChangeVisibility);
            // 
            // publicaBox
            // 
            this.publicaBox.Location = new System.Drawing.Point(131, 28);
            this.publicaBox.Name = "publicaBox";
            this.publicaBox.Size = new System.Drawing.Size(170, 28);
            this.publicaBox.TabIndex = 0;
            this.publicaBox.UseSystemPasswordChar = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.gerarR32);
            this.groupBox3.Controls.Add(this.gerarR24);
            this.groupBox3.Controls.Add(this.gerarR16);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.vgPrivadaBtn);
            this.groupBox3.Controls.Add(this.gPrivadaBox);
            this.groupBox3.Controls.Add(this.gerarP32);
            this.groupBox3.Controls.Add(this.gerarP24);
            this.groupBox3.Controls.Add(this.gerarP16);
            this.groupBox3.Controls.Add(this.chaveBtn);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.vgPublicaBtn);
            this.groupBox3.Controls.Add(this.gPublicaBox);
            this.groupBox3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(355, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 296);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gerar chave publica";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 22);
            this.label7.TabIndex = 33;
            this.label7.Text = "Chave Publica:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "Chave Privada:";
            // 
            // gerarR32
            // 
            this.gerarR32.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerarR32.Location = new System.Drawing.Point(277, 147);
            this.gerarR32.Name = "gerarR32";
            this.gerarR32.Size = new System.Drawing.Size(70, 30);
            this.gerarR32.TabIndex = 29;
            this.gerarR32.Text = "32";
            this.gerarR32.UseVisualStyleBackColor = true;
            this.gerarR32.Click += new System.EventHandler(this.GeneratePassword);
            // 
            // gerarR24
            // 
            this.gerarR24.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerarR24.Location = new System.Drawing.Point(199, 147);
            this.gerarR24.Name = "gerarR24";
            this.gerarR24.Size = new System.Drawing.Size(70, 30);
            this.gerarR24.TabIndex = 28;
            this.gerarR24.Text = "24";
            this.gerarR24.UseVisualStyleBackColor = true;
            this.gerarR24.Click += new System.EventHandler(this.GeneratePassword);
            // 
            // gerarR16
            // 
            this.gerarR16.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerarR16.Location = new System.Drawing.Point(121, 147);
            this.gerarR16.Name = "gerarR16";
            this.gerarR16.Size = new System.Drawing.Size(70, 30);
            this.gerarR16.TabIndex = 26;
            this.gerarR16.Text = "16";
            this.gerarR16.UseVisualStyleBackColor = true;
            this.gerarR16.Click += new System.EventHandler(this.GeneratePassword);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "Gerar senha :";
            // 
            // vgPrivadaBtn
            // 
            this.vgPrivadaBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.vgPrivadaBtn.AutoSize = true;
            this.vgPrivadaBtn.Location = new System.Drawing.Point(321, 113);
            this.vgPrivadaBtn.Name = "vgPrivadaBtn";
            this.vgPrivadaBtn.Size = new System.Drawing.Size(26, 32);
            this.vgPrivadaBtn.TabIndex = 25;
            this.vgPrivadaBtn.Text = "-";
            this.vgPrivadaBtn.UseVisualStyleBackColor = true;
            this.vgPrivadaBtn.CheckedChanged += new System.EventHandler(this.ChangeVisibility);
            // 
            // gPrivadaBox
            // 
            this.gPrivadaBox.Location = new System.Drawing.Point(121, 116);
            this.gPrivadaBox.Name = "gPrivadaBox";
            this.gPrivadaBox.Size = new System.Drawing.Size(197, 28);
            this.gPrivadaBox.TabIndex = 24;
            this.gPrivadaBox.UseSystemPasswordChar = true;
            // 
            // gerarP32
            // 
            this.gerarP32.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerarP32.Location = new System.Drawing.Point(277, 59);
            this.gerarP32.Name = "gerarP32";
            this.gerarP32.Size = new System.Drawing.Size(70, 30);
            this.gerarP32.TabIndex = 23;
            this.gerarP32.Text = "32";
            this.gerarP32.UseVisualStyleBackColor = true;
            this.gerarP32.Click += new System.EventHandler(this.GeneratePassword);
            // 
            // gerarP24
            // 
            this.gerarP24.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerarP24.Location = new System.Drawing.Point(199, 59);
            this.gerarP24.Name = "gerarP24";
            this.gerarP24.Size = new System.Drawing.Size(70, 30);
            this.gerarP24.TabIndex = 22;
            this.gerarP24.Text = "24";
            this.gerarP24.UseVisualStyleBackColor = true;
            this.gerarP24.Click += new System.EventHandler(this.GeneratePassword);
            // 
            // gerarP16
            // 
            this.gerarP16.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerarP16.Location = new System.Drawing.Point(121, 59);
            this.gerarP16.Name = "gerarP16";
            this.gerarP16.Size = new System.Drawing.Size(70, 30);
            this.gerarP16.TabIndex = 21;
            this.gerarP16.Text = "16";
            this.gerarP16.UseVisualStyleBackColor = true;
            this.gerarP16.Click += new System.EventHandler(this.GeneratePassword);
            // 
            // chaveBtn
            // 
            this.chaveBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chaveBtn.Location = new System.Drawing.Point(9, 180);
            this.chaveBtn.Name = "chaveBtn";
            this.chaveBtn.Size = new System.Drawing.Size(337, 40);
            this.chaveBtn.TabIndex = 18;
            this.chaveBtn.Text = "GERAR";
            this.chaveBtn.UseVisualStyleBackColor = true;
            this.chaveBtn.Click += new System.EventHandler(this.GerarChave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Gerar senha :";
            // 
            // vgPublicaBtn
            // 
            this.vgPublicaBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.vgPublicaBtn.AutoSize = true;
            this.vgPublicaBtn.Location = new System.Drawing.Point(321, 25);
            this.vgPublicaBtn.Name = "vgPublicaBtn";
            this.vgPublicaBtn.Size = new System.Drawing.Size(26, 32);
            this.vgPublicaBtn.TabIndex = 1;
            this.vgPublicaBtn.Text = "-";
            this.vgPublicaBtn.UseVisualStyleBackColor = true;
            this.vgPublicaBtn.CheckedChanged += new System.EventHandler(this.ChangeVisibility);
            // 
            // gPublicaBox
            // 
            this.gPublicaBox.Location = new System.Drawing.Point(121, 28);
            this.gPublicaBox.Name = "gPublicaBox";
            this.gPublicaBox.Size = new System.Drawing.Size(197, 28);
            this.gPublicaBox.TabIndex = 0;
            this.gPublicaBox.UseSystemPasswordChar = true;
            // 
            // output_PublicKeyLbl
            // 
            this.output_PublicKeyLbl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.output_PublicKeyLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output_PublicKeyLbl.Location = new System.Drawing.Point(361, 324);
            this.output_PublicKeyLbl.Multiline = true;
            this.output_PublicKeyLbl.Name = "output_PublicKeyLbl";
            this.output_PublicKeyLbl.ReadOnly = true;
            this.output_PublicKeyLbl.Size = new System.Drawing.Size(340, 64);
            this.output_PublicKeyLbl.TabIndex = 26;
            // 
            // MikcipherFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(720, 720);
            this.Controls.Add(this.output_PublicKeyLbl);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.header1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MikcipherFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Header header1;
        private System.Windows.Forms.Button criptografarBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox privadaBox;
        private System.Windows.Forms.TextBox outputLbl;
        private System.Windows.Forms.Button descriptografarBtn;
        private System.Windows.Forms.CheckBox vPrivadaBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox vPublicaBtn;
        private System.Windows.Forms.TextBox publicaBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button gerarR32;
        private System.Windows.Forms.Button gerarR24;
        private System.Windows.Forms.Button gerarR16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox vgPrivadaBtn;
        private System.Windows.Forms.TextBox gPrivadaBox;
        private System.Windows.Forms.Button gerarP32;
        private System.Windows.Forms.Button gerarP24;
        private System.Windows.Forms.Button gerarP16;
        private System.Windows.Forms.Button chaveBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox vgPublicaBtn;
        private System.Windows.Forms.TextBox gPublicaBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox output_PublicKeyLbl;
    }
}