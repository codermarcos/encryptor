using Encryptor.Views.Shared;

namespace Encryptor.Views.criptografias
{
    partial class AssimetricasFrm
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
            this.decriptarGroup = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptografarBtn = new System.Windows.Forms.Button();
            this.vPrivadaBtn = new System.Windows.Forms.CheckBox();
            this.privadaBox = new System.Windows.Forms.TextBox();
            this.encriptarGruop = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vPublicaBtn = new System.Windows.Forms.CheckBox();
            this.publicaBox = new System.Windows.Forms.TextBox();
            this.gerarGroup = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gPrivadaBox = new System.Windows.Forms.TextBox();
            this.output_PublicKeyLbl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.vgPrivadaBtn = new System.Windows.Forms.CheckBox();
            this.chaveBtn = new System.Windows.Forms.Button();
            this.vgPublicaBtn = new System.Windows.Forms.CheckBox();
            this.gPublicaBox = new System.Windows.Forms.TextBox();
            this.header1 = new Encryptor.Views.Shared.Header();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.outputLbl = new System.Windows.Forms.TextBox();
            this.decriptarGroup.SuspendLayout();
            this.encriptarGruop.SuspendLayout();
            this.gerarGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.criptografarBtn.Location = new System.Drawing.Point(6, 59);
            this.criptografarBtn.Name = "criptografarBtn";
            this.criptografarBtn.Size = new System.Drawing.Size(324, 40);
            this.criptografarBtn.TabIndex = 18;
            this.criptografarBtn.Text = "CRIPTOGRAFAR";
            this.criptografarBtn.UseVisualStyleBackColor = true;
            this.criptografarBtn.Click += new System.EventHandler(this.Criptografar);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(603, 66);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(105, 32);
            this.clearBtn.TabIndex = 16;
            this.clearBtn.Text = "LIMPAR";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.Limpar);
            // 
            // decriptarGroup
            // 
            this.decriptarGroup.Controls.Add(this.label4);
            this.decriptarGroup.Controls.Add(this.descriptografarBtn);
            this.decriptarGroup.Controls.Add(this.vPrivadaBtn);
            this.decriptarGroup.Controls.Add(this.privadaBox);
            this.decriptarGroup.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decriptarGroup.Location = new System.Drawing.Point(372, 208);
            this.decriptarGroup.Name = "decriptarGroup";
            this.decriptarGroup.Size = new System.Drawing.Size(336, 110);
            this.decriptarGroup.TabIndex = 15;
            this.decriptarGroup.TabStop = false;
            this.decriptarGroup.Text = "Decriptar";
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
            // encriptarGruop
            // 
            this.encriptarGruop.Controls.Add(this.label5);
            this.encriptarGruop.Controls.Add(this.criptografarBtn);
            this.encriptarGruop.Controls.Add(this.vPublicaBtn);
            this.encriptarGruop.Controls.Add(this.publicaBox);
            this.encriptarGruop.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encriptarGruop.Location = new System.Drawing.Point(12, 208);
            this.encriptarGruop.Name = "encriptarGruop";
            this.encriptarGruop.Size = new System.Drawing.Size(336, 110);
            this.encriptarGruop.TabIndex = 24;
            this.encriptarGruop.TabStop = false;
            this.encriptarGruop.Text = "Encriptar";
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
            // gerarGroup
            // 
            this.gerarGroup.Controls.Add(this.label8);
            this.gerarGroup.Controls.Add(this.gPrivadaBox);
            this.gerarGroup.Controls.Add(this.output_PublicKeyLbl);
            this.gerarGroup.Controls.Add(this.label7);
            this.gerarGroup.Controls.Add(this.label6);
            this.gerarGroup.Controls.Add(this.vgPrivadaBtn);
            this.gerarGroup.Controls.Add(this.chaveBtn);
            this.gerarGroup.Controls.Add(this.vgPublicaBtn);
            this.gerarGroup.Controls.Add(this.gPublicaBox);
            this.gerarGroup.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerarGroup.Location = new System.Drawing.Point(12, 98);
            this.gerarGroup.Name = "gerarGroup";
            this.gerarGroup.Size = new System.Drawing.Size(696, 104);
            this.gerarGroup.TabIndex = 25;
            this.gerarGroup.TabStop = false;
            this.gerarGroup.Text = "Gerar chave publica";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(430, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 22);
            this.label8.TabIndex = 34;
            this.label8.Text = "Saida:";
            // 
            // gPrivadaBox
            // 
            this.gPrivadaBox.Location = new System.Drawing.Point(491, 28);
            this.gPrivadaBox.Name = "gPrivadaBox";
            this.gPrivadaBox.Size = new System.Drawing.Size(170, 28);
            this.gPrivadaBox.TabIndex = 24;
            this.gPrivadaBox.UseSystemPasswordChar = true;
            // 
            // output_PublicKeyLbl
            // 
            this.output_PublicKeyLbl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.output_PublicKeyLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output_PublicKeyLbl.Location = new System.Drawing.Point(491, 61);
            this.output_PublicKeyLbl.Multiline = true;
            this.output_PublicKeyLbl.Name = "output_PublicKeyLbl";
            this.output_PublicKeyLbl.ReadOnly = true;
            this.output_PublicKeyLbl.Size = new System.Drawing.Size(199, 36);
            this.output_PublicKeyLbl.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 22);
            this.label7.TabIndex = 33;
            this.label7.Text = "Chave Publica:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(366, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "Chave Privada:";
            // 
            // vgPrivadaBtn
            // 
            this.vgPrivadaBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.vgPrivadaBtn.AutoSize = true;
            this.vgPrivadaBtn.Location = new System.Drawing.Point(664, 25);
            this.vgPrivadaBtn.Name = "vgPrivadaBtn";
            this.vgPrivadaBtn.Size = new System.Drawing.Size(26, 32);
            this.vgPrivadaBtn.TabIndex = 25;
            this.vgPrivadaBtn.Text = "-";
            this.vgPrivadaBtn.UseVisualStyleBackColor = true;
            this.vgPrivadaBtn.CheckedChanged += new System.EventHandler(this.ChangeVisibility);
            // 
            // chaveBtn
            // 
            this.chaveBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chaveBtn.Location = new System.Drawing.Point(6, 61);
            this.chaveBtn.Name = "chaveBtn";
            this.chaveBtn.Size = new System.Drawing.Size(324, 40);
            this.chaveBtn.TabIndex = 18;
            this.chaveBtn.Text = "GERAR";
            this.chaveBtn.UseVisualStyleBackColor = true;
            this.chaveBtn.Click += new System.EventHandler(this.GerarChave);
            // 
            // vgPublicaBtn
            // 
            this.vgPublicaBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.vgPublicaBtn.AutoSize = true;
            this.vgPublicaBtn.Location = new System.Drawing.Point(304, 23);
            this.vgPublicaBtn.Name = "vgPublicaBtn";
            this.vgPublicaBtn.Size = new System.Drawing.Size(26, 32);
            this.vgPublicaBtn.TabIndex = 1;
            this.vgPublicaBtn.Text = "-";
            this.vgPublicaBtn.UseVisualStyleBackColor = true;
            this.vgPublicaBtn.CheckedChanged += new System.EventHandler(this.ChangeVisibility);
            // 
            // gPublicaBox
            // 
            this.gPublicaBox.Location = new System.Drawing.Point(131, 25);
            this.gPublicaBox.Name = "gPublicaBox";
            this.gPublicaBox.Size = new System.Drawing.Size(170, 28);
            this.gPublicaBox.TabIndex = 0;
            this.gPublicaBox.UseSystemPasswordChar = true;
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
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(6, 27);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(684, 150);
            this.inputBox.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputBox);
            this.groupBox1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 183);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.outputLbl);
            this.groupBox2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 513);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 153);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saida:";
            // 
            // outputLbl
            // 
            this.outputLbl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.outputLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputLbl.Location = new System.Drawing.Point(6, 27);
            this.outputLbl.Multiline = true;
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.ReadOnly = true;
            this.outputLbl.Size = new System.Drawing.Size(684, 120);
            this.outputLbl.TabIndex = 20;
            // 
            // AssimetricasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(720, 720);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gerarGroup);
            this.Controls.Add(this.encriptarGruop);
            this.Controls.Add(this.decriptarGroup);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.header1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AssimetricasFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.decriptarGroup.ResumeLayout(false);
            this.decriptarGroup.PerformLayout();
            this.encriptarGruop.ResumeLayout(false);
            this.encriptarGruop.PerformLayout();
            this.gerarGroup.ResumeLayout(false);
            this.gerarGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Header header1;
        private System.Windows.Forms.Button criptografarBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.GroupBox decriptarGroup;
        private System.Windows.Forms.TextBox privadaBox;
        private System.Windows.Forms.Button descriptografarBtn;
        private System.Windows.Forms.CheckBox vPrivadaBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox encriptarGruop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox vPublicaBtn;
        private System.Windows.Forms.TextBox publicaBox;
        private System.Windows.Forms.GroupBox gerarGroup;
        private System.Windows.Forms.CheckBox vgPrivadaBtn;
        private System.Windows.Forms.TextBox gPrivadaBox;
        private System.Windows.Forms.Button chaveBtn;
        private System.Windows.Forms.CheckBox vgPublicaBtn;
        private System.Windows.Forms.TextBox gPublicaBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox output_PublicKeyLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox outputLbl;
    }
}