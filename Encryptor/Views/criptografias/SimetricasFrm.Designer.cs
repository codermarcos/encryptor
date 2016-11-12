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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.hashCriptographys = new System.Windows.Forms.GroupBox();
            this.rMD5 = new System.Windows.Forms.RadioButton();
            this.rSHA152 = new System.Windows.Forms.RadioButton();
            this.rSHA1 = new System.Windows.Forms.RadioButton();
            this.closeBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.header1 = new Encryptor.Views.Shared.Header();
            this.label1 = new System.Windows.Forms.Label();
            this.hashCriptographys.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // hashCriptographys
            // 
            this.hashCriptographys.Controls.Add(this.rMD5);
            this.hashCriptographys.Controls.Add(this.rSHA152);
            this.hashCriptographys.Controls.Add(this.rSHA1);
            this.hashCriptographys.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashCriptographys.Location = new System.Drawing.Point(12, 102);
            this.hashCriptographys.Name = "hashCriptographys";
            this.hashCriptographys.Size = new System.Drawing.Size(414, 64);
            this.hashCriptographys.TabIndex = 12;
            this.hashCriptographys.TabStop = false;
            this.hashCriptographys.Text = "Selecione qual simetrica :";
            // 
            // rMD5
            // 
            this.rMD5.AutoSize = true;
            this.rMD5.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rMD5.Location = new System.Drawing.Point(6, 27);
            this.rMD5.Name = "rMD5";
            this.rMD5.Size = new System.Drawing.Size(61, 26);
            this.rMD5.TabIndex = 4;
            this.rMD5.TabStop = true;
            this.rMD5.Text = "MD5";
            this.rMD5.UseVisualStyleBackColor = true;
            // 
            // rSHA152
            // 
            this.rSHA152.AutoSize = true;
            this.rSHA152.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rSHA152.Location = new System.Drawing.Point(323, 27);
            this.rSHA152.Name = "rSHA152";
            this.rSHA152.Size = new System.Drawing.Size(84, 26);
            this.rSHA152.TabIndex = 6;
            this.rSHA152.TabStop = true;
            this.rSHA152.Text = "SHA152";
            this.rSHA152.UseVisualStyleBackColor = true;
            // 
            // rSHA1
            // 
            this.rSHA1.AutoSize = true;
            this.rSHA1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rSHA1.Location = new System.Drawing.Point(162, 27);
            this.rSHA1.Name = "rSHA1";
            this.rSHA1.Size = new System.Drawing.Size(66, 26);
            this.rSHA1.TabIndex = 5;
            this.rSHA1.TabStop = true;
            this.rSHA1.Text = "SHA1";
            this.rSHA1.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(573, 112);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(135, 55);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.Text = "SALVAR";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(432, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 55);
            this.button1.TabIndex = 10;
            this.button1.Text = "ABRIR";
            this.button1.UseVisualStyleBackColor = true;
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
            // SimetricasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(720, 720);
            this.Controls.Add(this.hashCriptographys);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.header1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SimetricasFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.hashCriptographys.ResumeLayout(false);
            this.hashCriptographys.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox hashCriptographys;
        private System.Windows.Forms.RadioButton rMD5;
        private System.Windows.Forms.RadioButton rSHA152;
        private System.Windows.Forms.RadioButton rSHA1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button button1;
        private Header header1;
        private System.Windows.Forms.Label label1;
    }
}