using System;
using System.Windows.Forms;
using Logic;
using Logic.Criptographys;

namespace Encryptor.Views.criptografias
{
    public partial class SimetricasFrm : Form
    {
        public SimetricasFrm()
        {
            InitializeComponent();
        }

        private string _type;

        public void Criptografar(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_type))
            {
                MessageBox.Show(@"Selecione qual é a simetrica !"); return;
            }
            if (string.IsNullOrEmpty(InputBox.Text))
            {
                MessageBox.Show(@"Digite a entreda para encriptar !"); return;
            }
            if (string.IsNullOrEmpty(passwordBox.Text))
            {
                MessageBox.Show(@"Digite uma senha antes de encriptar !"); return;
            }

            Encrypt();
        }

        public void Descriptografar(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_type))
            {
                MessageBox.Show(@"Selecione qual é a simetrica !"); return;
            }
            if (string.IsNullOrEmpty(InputBox.Text))
            {
                MessageBox.Show(@"Digite a entreda para encriptar !"); return;
            }
            if (string.IsNullOrEmpty(passwordBox.Text))
            {
                MessageBox.Show(@"Digite uma senha antes de encriptar !"); return;
            }

            Decrypt();
        }

        private void Limpar(object sender, EventArgs e)
        {
            _type = null;
            rDES.Checked = false;
            rRINJDAEL.Checked = false;
            InputBox.Text = string.Empty;
            outputLbl.Text = string.Empty;
            passwordBox.Text = string.Empty; 
            visibiladadeBtn.Checked = false;
        }

        private void Encrypt()
        {
            switch (_type)
            {
                case "RIJNDAEL":
                    outputLbl.Text = Simetricas.Encript.Rijndael(InputBox.Text, passwordBox.Text);
                    break;
                case "DES":
                    outputLbl.Text = Simetricas.Encript.Des(InputBox.Text, passwordBox.Text);
                    break;
            }
        }

        private void Decrypt()
        {
            switch (_type)
            {
                case "RIJNDAEL":
                    outputLbl.Text = Simetricas.Decript.Rijndael(InputBox.Text, passwordBox.Text);
                    break;
                case "DES":
                    outputLbl.Text = Simetricas.Decript.Des(InputBox.Text, passwordBox.Text);
                    break;
            }
        }

        private void ChangeVisibility(object sender, EventArgs e)
        {
            if (visibiladadeBtn.Checked)
            {
                passwordBox.UseSystemPasswordChar = false;
                visibiladadeBtn.Text = @"o";
            }
            else
            {
                passwordBox.UseSystemPasswordChar = true;
                visibiladadeBtn.Text = @"-";
            }
        }

        private void ChangeSelect(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked) return;
            _type = ((RadioButton)sender).Text;
        }
    }
}
