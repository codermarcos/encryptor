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
            this.hashCriptographys = new System.Windows.Forms.GroupBox();
            this.rDES = new System.Windows.Forms.RadioButton();
            this.rRINJDAEL = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.visibiladadeBtn = new System.Windows.Forms.CheckBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.descriptografarBtn = new System.Windows.Forms.Button();
            this.header1 = new Encryptor.Views.Shared.Header();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.outputLbl = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.hashCriptographys.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.criptografarBtn.Location = new System.Drawing.Point(12, 167);
            this.criptografarBtn.Name = "criptografarBtn";
            this.criptografarBtn.Size = new System.Drawing.Size(332, 40);
            this.criptografarBtn.TabIndex = 18;
            this.criptografarBtn.Text = "CRIPTOGRAFAR";
            this.criptografarBtn.UseVisualStyleBackColor = true;
            this.criptografarBtn.Click += new System.EventHandler(this.Criptografar);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(603, 67);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(105, 32);
            this.clearBtn.TabIndex = 16;
            this.clearBtn.Text = "LIMPAR";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.Limpar);
            // 
            // hashCriptographys
            // 
            this.hashCriptographys.Controls.Add(this.rDES);
            this.hashCriptographys.Controls.Add(this.rRINJDAEL);
            this.hashCriptographys.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashCriptographys.Location = new System.Drawing.Point(12, 98);
            this.hashCriptographys.Name = "hashCriptographys";
            this.hashCriptographys.Size = new System.Drawing.Size(332, 63);
            this.hashCriptographys.TabIndex = 14;
            this.hashCriptographys.TabStop = false;
            this.hashCriptographys.Text = "Selecione qual simetrica :";
            // 
            // rDES
            // 
            this.rDES.AutoSize = true;
            this.rDES.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rDES.Location = new System.Drawing.Point(195, 27);
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
            this.rRINJDAEL.Location = new System.Drawing.Point(31, 27);
            this.rRINJDAEL.Name = "rRINJDAEL";
            this.rRINJDAEL.Size = new System.Drawing.Size(97, 26);
            this.rRINJDAEL.TabIndex = 4;
            this.rRINJDAEL.TabStop = true;
            this.rRINJDAEL.Text = "RIJNDAEL";
            this.rRINJDAEL.UseVisualStyleBackColor = true;
            this.rRINJDAEL.CheckedChanged += new System.EventHandler(this.ChangeSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.visibiladadeBtn);
            this.groupBox1.Controls.Add(this.passwordBox);
            this.groupBox1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(355, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 63);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Digite  a senha da criptografia :";
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
            // descriptografarBtn
            // 
            this.descriptografarBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptografarBtn.Location = new System.Drawing.Point(355, 167);
            this.descriptografarBtn.Name = "descriptografarBtn";
            this.descriptografarBtn.Size = new System.Drawing.Size(353, 40);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.outputLbl);
            this.groupBox2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 402);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 153);
            this.groupBox2.TabIndex = 37;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.InputBox);
            this.groupBox3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(696, 183);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Entrada :";
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(6, 27);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(684, 150);
            this.InputBox.TabIndex = 26;
            // 
            // SimetricasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(720, 720);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.descriptografarBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.criptografarBtn);
            this.Controls.Add(this.hashCriptographys);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.header1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SimetricasFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.hashCriptographys.ResumeLayout(false);
            this.hashCriptographys.PerformLayout();
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
        private System.Windows.Forms.GroupBox hashCriptographys;
        private System.Windows.Forms.RadioButton rRINJDAEL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button descriptografarBtn;
        private System.Windows.Forms.CheckBox visibiladadeBtn;
        private System.Windows.Forms.RadioButton rDES;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox outputLbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox InputBox;
    }
}