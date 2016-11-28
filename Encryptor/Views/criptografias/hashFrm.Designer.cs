using Encryptor.Views.Shared;

namespace Encryptor.Views.criptografias
{
    partial class HashFrm
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
            this.header = new Encryptor.Views.Shared.Header();
            this.labelHASH = new System.Windows.Forms.Label();
            this.rMD5 = new System.Windows.Forms.RadioButton();
            this.rSHA1 = new System.Windows.Forms.RadioButton();
            this.hashCriptographys = new System.Windows.Forms.GroupBox();
            this.criptografarBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.outputLbl = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.hashCriptographys.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(720, 166);
            this.header.TabIndex = 0;
            // 
            // labelHASH
            // 
            this.labelHASH.AutoSize = true;
            this.labelHASH.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHASH.Location = new System.Drawing.Point(326, 67);
            this.labelHASH.Name = "labelHASH";
            this.labelHASH.Size = new System.Drawing.Size(71, 32);
            this.labelHASH.TabIndex = 1;
            this.labelHASH.Text = "HASH";
            // 
            // rMD5
            // 
            this.rMD5.AutoSize = true;
            this.rMD5.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rMD5.Location = new System.Drawing.Point(20, 27);
            this.rMD5.Name = "rMD5";
            this.rMD5.Size = new System.Drawing.Size(61, 26);
            this.rMD5.TabIndex = 4;
            this.rMD5.TabStop = true;
            this.rMD5.Text = "MD5";
            this.rMD5.UseVisualStyleBackColor = true;
            this.rMD5.CheckedChanged += new System.EventHandler(this.ChangeSelect);
            // 
            // rSHA1
            // 
            this.rSHA1.AutoSize = true;
            this.rSHA1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rSHA1.Location = new System.Drawing.Point(114, 27);
            this.rSHA1.Name = "rSHA1";
            this.rSHA1.Size = new System.Drawing.Size(66, 26);
            this.rSHA1.TabIndex = 5;
            this.rSHA1.TabStop = true;
            this.rSHA1.Text = "SHA1";
            this.rSHA1.UseVisualStyleBackColor = true;
            this.rSHA1.CheckedChanged += new System.EventHandler(this.ChangeSelect);
            // 
            // hashCriptographys
            // 
            this.hashCriptographys.Controls.Add(this.rMD5);
            this.hashCriptographys.Controls.Add(this.rSHA1);
            this.hashCriptographys.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashCriptographys.Location = new System.Drawing.Point(12, 98);
            this.hashCriptographys.Name = "hashCriptographys";
            this.hashCriptographys.Size = new System.Drawing.Size(196, 68);
            this.hashCriptographys.TabIndex = 7;
            this.hashCriptographys.TabStop = false;
            this.hashCriptographys.Text = "Selecione qual hash :";
            // 
            // criptografarBtn
            // 
            this.criptografarBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criptografarBtn.Location = new System.Drawing.Point(214, 108);
            this.criptografarBtn.Name = "criptografarBtn";
            this.criptografarBtn.Size = new System.Drawing.Size(223, 55);
            this.criptografarBtn.TabIndex = 11;
            this.criptografarBtn.Text = "CRIPTOGRAFAR";
            this.criptografarBtn.UseVisualStyleBackColor = true;
            this.criptografarBtn.Click += new System.EventHandler(this.Criptografar);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.outputLbl);
            this.groupBox2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 378);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(702, 153);
            this.groupBox2.TabIndex = 35;
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
            this.outputLbl.Size = new System.Drawing.Size(690, 120);
            this.outputLbl.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputBox);
            this.groupBox1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 183);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada :";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(6, 27);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(690, 150);
            this.inputBox.TabIndex = 26;
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(606, 69);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(105, 32);
            this.clearBtn.TabIndex = 21;
            this.clearBtn.Text = "LIMPAR";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.Limpar);
            // 
            // HashFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(720, 720);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.criptografarBtn);
            this.Controls.Add(this.hashCriptographys);
            this.Controls.Add(this.labelHASH);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HashFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.hashCriptographys.ResumeLayout(false);
            this.hashCriptographys.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Header header;
        private System.Windows.Forms.Label labelHASH;
        private System.Windows.Forms.RadioButton rMD5;
        private System.Windows.Forms.RadioButton rSHA1;
        private System.Windows.Forms.GroupBox hashCriptographys;
        private System.Windows.Forms.Button criptografarBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox outputLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button clearBtn;
    }
}