using System;
using System.Windows.Forms;
using Logic.Criptographys;

namespace Encryptor.Views.criptografias
{
    public partial class AssimetricasFrm : Form
    {
        public AssimetricasFrm()
        {
            InitializeComponent();
        }

        private void GerarChave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gPrivadaBox.Text))
            {
                MessageBox.Show(@"Digite uma chave privada antes de gerar !"); return;
            }
            if (string.IsNullOrEmpty(gPublicaBox.Text))
            {
                MessageBox.Show(@"Digite uma chave publica antes de gerar !"); return;
            }

            GetPublicKey();
        }

        public void Criptografar(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputBox.Text))
            {
                MessageBox.Show(@"Digite a entreda para encriptar !"); return;
            }
            if (string.IsNullOrEmpty(publicaBox.Text))
            {
                MessageBox.Show(@"Digite uma chave publica antes de encriptar !"); return;
            }

            Encrypt();
        }

        public void Descriptografar(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputBox.Text))
            {
                MessageBox.Show(@"Digite a entreda para encriptar !"); return;
            }
            if (string.IsNullOrEmpty(privadaBox.Text))
            {
                MessageBox.Show(@"Digite uma chave privada antes de Decriptar !"); return;
            }

            Decrypt();
        }

        private void Limpar(object sender, EventArgs e)
        {
            outputLbl.Text = string.Empty;
            inputBox.Text = string.Empty;
            output_PublicKeyLbl.Text = string.Empty;
            privadaBox.Text = string.Empty; 
            publicaBox.Text = string.Empty;
            gPrivadaBox.Text = string.Empty;
            gPublicaBox.Text = string.Empty;
            vPrivadaBtn.Checked = false;
            vPublicaBtn.Checked = false;
            vgPrivadaBtn.Checked = false;
            vgPublicaBtn.Checked = false;
        }


        private void Encrypt()
        {
            outputLbl.Text = Assimetricas.Encript.Mikcipher(inputBox.Text, publicaBox.Text);
        }

        private void Decrypt()
        {
            outputLbl.Text = Assimetricas.Decript.Mikcipher(inputBox.Text, privadaBox.Text);
        }

        private void GetPublicKey()
        {
            output_PublicKeyLbl.Text = Assimetricas.Generate.PublicKey(gPublicaBox.Text, gPrivadaBox.Text);
        }

        #region visibilidade senha
        private void ChangeVisibility(object sender, EventArgs e)
        {
            var btn = ((CheckBox)sender);
            switch (btn.Name)
            {
                case "vgPrivadaBtn":
                    if (vgPrivadaBtn.Checked)
                    {
                        gPrivadaBox.UseSystemPasswordChar = false;
                        vgPrivadaBtn.Text = @"o";
                    }
                    else
                    {
                        gPrivadaBox.UseSystemPasswordChar = true;
                        vgPrivadaBtn.Text = @"-";
                    }
                    break;
                case "vPrivadaBtn":
                    if (vPrivadaBtn.Checked)
                    {
                        privadaBox.UseSystemPasswordChar = false;
                        vPrivadaBtn.Text = @"o";
                    }
                    else
                    {
                        privadaBox.UseSystemPasswordChar = true;
                        vPrivadaBtn.Text = @"-";
                    }
                    break;
                case "vgPublicaBtn":
                    if (vgPublicaBtn.Checked)
                    {
                        gPublicaBox.UseSystemPasswordChar = false;
                        vgPublicaBtn.Text = @"o";
                    }
                    else
                    {
                        gPublicaBox.UseSystemPasswordChar = true;
                        vgPublicaBtn.Text = @"-";
                    }
                    break;
                case "vPublicaBtn":
                    if (vPublicaBtn.Checked)
                    {
                        publicaBox.UseSystemPasswordChar = false;
                        vPublicaBtn.Text = @"o";
                    }
                    else
                    {
                        publicaBox.UseSystemPasswordChar = true;
                        vPublicaBtn.Text = @"-";
                    }
                    break;
            }
            #endregion
        }
    }
}
