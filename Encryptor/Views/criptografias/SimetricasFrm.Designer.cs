using Encryptor.Views.Shared;

namespace Encryptor.Views.criptografias
{
    partial class SimetricasFrm
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
            this.hashCriptographys = new System.Windows.Forms.GroupBox();
            this.rDES = new System.Windows.Forms.RadioButton();
            this.rRINJDAEL = new System.Windows.Forms.RadioButton();
            this.openBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.char32Btn = new System.Windows.Forms.Button();
            this.char24Btn = new System.Windows.Forms.Button();
            this.char16Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.visibiladadeBtn = new System.Windows.Forms.CheckBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.outputLbl = new System.Windows.Forms.TextBox();
            this.descriptografarBtn = new System.Windows.Forms.Button();
            this.header1 = new Encryptor.Views.Shared.Header();
            this.hashCriptographys.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "SIMETRICAS";
            // 
            // criptografarBtn
            // 
            this.criptografarBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criptografarBtn.Location = new System.Drawing.Point(381, 203);
            this.criptografarBtn.Name = "criptografarBtn";
            this.criptografarBtn.Size = new System.Drawing.Size(327, 40);
            this.criptografarBtn.TabIndex = 18;
            this.criptografarBtn.Text = "CRIPTOGRAFAR";
            this.criptografarBtn.UseVisualStyleBackColor = true;
            this.criptografarBtn.Click += new System.EventHandler(this.Criptografar);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(492, 108);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(105, 80);
            this.clearBtn.TabIndex = 16;
            this.clearBtn.Text = "LIMPAR";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.Limpar);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(603, 108);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(105, 80);
            this.saveBtn.TabIndex = 15;
            this.saveBtn.Text = "SALVAR";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.Salvar);
            // 
            // hashCriptographys
            // 
            this.hashCriptographys.Controls.Add(this.rDES);
            this.hashCriptographys.Controls.Add(this.rRINJDAEL);
            this.hashCriptographys.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashCriptographys.Location = new System.Drawing.Point(12, 98);
            this.hashCriptographys.Name = "hashCriptographys";
            this.hashCriptographys.Size = new System.Drawing.Size(353, 90);
            this.hashCriptographys.TabIndex = 14;
            this.hashCriptographys.TabStop = false;
            this.hashCriptographys.Text = "Selecione qual simetrica :";
            // 
            // rDES
            // 
            this.rDES.AutoSize = true;
            this.rDES.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rDES.Location = new System.Drawing.Point(215, 44);
            this.rDES.Name = "rDES";
            this.rDES.Size = new System.Drawing.Size(54, 26);
            this.rDES.TabIndex = 5;
            this.rDES.TabStop = true;
            this.rDES.Text = "DES";
            this.rDES.UseVisualStyleBackColor = true;
            this.rDES.CheckedChanged += new System.EventHandler(this.ChangeSelect);
            // 
            // rRINJDAEL
            // 
            this.rRINJDAEL.AutoSize = true;
            this.rRINJDAEL.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rRINJDAEL.Location = new System.Drawing.Point(69, 44);
            this.rRINJDAEL.Name = "rRINJDAEL";
            this.rRINJDAEL.Size = new System.Drawing.Size(97, 26);
            this.rRINJDAEL.TabIndex = 4;
            this.rRINJDAEL.TabStop = true;
            this.rRINJDAEL.Text = "RIJNDAEL";
            this.rRINJDAEL.UseVisualStyleBackColor = true;
            this.rRINJDAEL.CheckedChanged += new System.EventHandler(this.ChangeSelect);
            // 
            // openBtn
            // 
            this.openBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openBtn.Location = new System.Drawing.Point(381, 108);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(105, 80);
            this.openBtn.TabIndex = 13;
            this.openBtn.Text = "ABRIR";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.OpenFile);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.char32Btn);
            this.groupBox1.Controls.Add(this.char24Btn);
            this.groupBox1.Controls.Add(this.char16Btn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.visibiladadeBtn);
            this.groupBox1.Controls.Add(this.passwordBox);
            this.groupBox1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 95);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Digite  a senha da criptografia :";
            // 
            // char32Btn
            // 
            this.char32Btn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.char32Btn.Location = new System.Drawing.Point(277, 59);
            this.char32Btn.Name = "char32Btn";
            this.char32Btn.Size = new System.Drawing.Size(70, 30);
            this.char32Btn.TabIndex = 23;
            this.char32Btn.Text = "32";
            this.char32Btn.UseVisualStyleBackColor = true;
            this.char32Btn.Click += new System.EventHandler(this.GeneratePassword);
            // 
            // char24Btn
            // 
            this.char24Btn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.char24Btn.Location = new System.Drawing.Point(199, 59);
            this.char24Btn.Name = "char24Btn";
            this.char24Btn.Size = new System.Drawing.Size(70, 30);
            this.char24Btn.TabIndex = 22;
            this.char24Btn.Text = "24";
            this.char24Btn.UseVisualStyleBackColor = true;
            this.char24Btn.Click += new System.EventHandler(this.GeneratePassword);
            // 
            // char16Btn
            // 
            this.char16Btn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.char16Btn.Location = new System.Drawing.Point(121, 59);
            this.char16Btn.Name = "char16Btn";
            this.char16Btn.Size = new System.Drawing.Size(70, 30);
            this.char16Btn.TabIndex = 21;
            this.char16Btn.Text = "16";
            this.char16Btn.UseVisualStyleBackColor = true;
            this.char16Btn.Click += new System.EventHandler(this.GeneratePassword);
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
            // visibiladadeBtn
            // 
            this.visibiladadeBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.visibiladadeBtn.AutoSize = true;
            this.visibiladadeBtn.Location = new System.Drawing.Point(321, 25);
            this.visibiladadeBtn.Name = "visibiladadeBtn";
            this.visibiladadeBtn.Size = new System.Drawing.Size(26, 32);
            this.visibiladadeBtn.TabIndex = 1;
            this.visibiladadeBtn.Text = "-";
            this.visibiladadeBtn.UseVisualStyleBackColor = true;
            this.visibiladadeBtn.CheckedChanged += new System.EventHandler(this.ChangeVisibility);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(6, 28);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(312, 28);
            this.passwordBox.TabIndex = 0;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // outputLbl
            // 
            this.outputLbl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.outputLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputLbl.Location = new System.Drawing.Point(18, 295);
            this.outputLbl.Multiline = true;
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.ReadOnly = true;
            this.outputLbl.Size = new System.Drawing.Size(696, 418);
            this.outputLbl.TabIndex = 19;
            // 
            // descriptografarBtn
            // 
            this.descriptografarBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptografarBtn.Location = new System.Drawing.Point(381, 249);
            this.descriptografarBtn.Name = "descriptografarBtn";
            this.descriptografarBtn.Size = new System.Drawing.Size(327, 40);
            this.descriptografarBtn.TabIndex = 20;
            this.descriptografarBtn.Text = "DESCRIPTOGRAFAR";
            this.descriptografarBtn.UseVisualStyleBackColor = true;
            this.descriptografarBtn.Click += new System.EventHandler(this.Descriptografar);
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
            // SimetricasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(720, 720);
            this.Controls.Add(this.descriptografarBtn);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.criptografarBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.hashCriptographys);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.header1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SimetricasFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.hashCriptographys.ResumeLayout(false);
            this.hashCriptographys.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Header header1;
        private System.Windows.Forms.Button criptografarBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox hashCriptographys;
        private System.Windows.Forms.RadioButton rRINJDAEL;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox outputLbl;
        private System.Windows.Forms.Button descriptografarBtn;
        private System.Windows.Forms.CheckBox visibiladadeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button char16Btn;
        private System.Windows.Forms.Button char32Btn;
        private System.Windows.Forms.Button char24Btn;
        private System.Windows.Forms.RadioButton rDES;
    }
}