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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.criptografarBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.AssimetricasCriptographys = new System.Windows.Forms.GroupBox();
            this.rRSA = new System.Windows.Forms.RadioButton();
            this.openBtn = new System.Windows.Forms.Button();
            this.outputLbl = new System.Windows.Forms.TextBox();
            this.descriptografarBtn = new System.Windows.Forms.Button();
            this.header1 = new Encryptor.Views.Shared.Header();
            this.AssimetricasCriptographys.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ASSIMETRICAS";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // criptografarBtn
            // 
            this.criptografarBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criptografarBtn.Location = new System.Drawing.Point(12, 197);
            this.criptografarBtn.Name = "criptografarBtn";
            this.criptografarBtn.Size = new System.Drawing.Size(353, 40);
            this.criptografarBtn.TabIndex = 18;
            this.criptografarBtn.Text = "CRIPTOGRAFAR";
            this.criptografarBtn.UseVisualStyleBackColor = true;
            this.criptografarBtn.Click += new System.EventHandler(this.Criptografar);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(494, 111);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(105, 80);
            this.clearBtn.TabIndex = 17;
            this.clearBtn.Text = "LIMPAR";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.Limpar);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(605, 111);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(105, 80);
            this.saveBtn.TabIndex = 16;
            this.saveBtn.Text = "SALVAR";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.Salvar);
            // 
            // AssimetricasCriptographys
            // 
            this.AssimetricasCriptographys.Controls.Add(this.rRSA);
            this.AssimetricasCriptographys.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssimetricasCriptographys.Location = new System.Drawing.Point(12, 101);
            this.AssimetricasCriptographys.Name = "AssimetricasCriptographys";
            this.AssimetricasCriptographys.Size = new System.Drawing.Size(353, 90);
            this.AssimetricasCriptographys.TabIndex = 15;
            this.AssimetricasCriptographys.TabStop = false;
            this.AssimetricasCriptographys.Text = "Selecione qual Assimetrica :";
            // 
            // rRSA
            // 
            this.rRSA.AutoSize = true;
            this.rRSA.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rRSA.Location = new System.Drawing.Point(80, 42);
            this.rRSA.Name = "rRSA";
            this.rRSA.Size = new System.Drawing.Size(56, 26);
            this.rRSA.TabIndex = 4;
            this.rRSA.TabStop = true;
            this.rRSA.Text = "RSA";
            this.rRSA.UseVisualStyleBackColor = true;
            this.rRSA.CheckedChanged += new System.EventHandler(this.ChangeSelect);
            // 
            // openBtn
            // 
            this.openBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openBtn.Location = new System.Drawing.Point(383, 111);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(105, 80);
            this.openBtn.TabIndex = 14;
            this.openBtn.Text = "ABRIR";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.OpenFile);
            // 
            // outputLbl
            // 
            this.outputLbl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.outputLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputLbl.Location = new System.Drawing.Point(12, 243);
            this.outputLbl.Multiline = true;
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.ReadOnly = true;
            this.outputLbl.Size = new System.Drawing.Size(696, 468);
            this.outputLbl.TabIndex = 21;
            // 
            // descriptografarBtn
            // 
            this.descriptografarBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptografarBtn.Location = new System.Drawing.Point(383, 197);
            this.descriptografarBtn.Name = "descriptografarBtn";
            this.descriptografarBtn.Size = new System.Drawing.Size(327, 40);
            this.descriptografarBtn.TabIndex = 22;
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
            // AssimetricasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(720, 720);
            this.Controls.Add(this.descriptografarBtn);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.criptografarBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.AssimetricasCriptographys);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.header1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AssimetricasFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AssimetricasFrm_Load);
            this.AssimetricasCriptographys.ResumeLayout(false);
            this.AssimetricasCriptographys.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Header header1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button criptografarBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox AssimetricasCriptographys;
        private System.Windows.Forms.RadioButton rRSA;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.TextBox outputLbl;
        private System.Windows.Forms.Button descriptografarBtn;
    }
}