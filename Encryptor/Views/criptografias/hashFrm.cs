using System;
using System.Windows.Forms;
using Logic;
using Logic.Criptographys;

namespace Encryptor.Views.criptografias
{
    public partial class HashFrm : Form
    {
        public HashFrm()
        {
            InitializeComponent();
        }

        private string _type;
        
        public void Criptografar(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputBox.Text))
            {
                MessageBox.Show(@"Digite a entreda para encriptar !"); return;
            }
            if (string.IsNullOrEmpty(_type))
            {
                MessageBox.Show(@"Selecione qual o hash !"); return;
            }

            Encrypt();
        }

        private void Limpar(object sender, EventArgs e)
        {
            _type = null;
            rMD5.Checked = false;
            rSHA1.Checked = false;
            inputBox.Text = string.Empty;
            outputLbl.Text = string.Empty;
        }

        private void Encrypt()
        {
            switch (_type)
            {
                case "MD5":
                    outputLbl.Text = Hash.Encrypt.Md5(inputBox.Text);
                    break;
                case "SHA1":
                    outputLbl.Text = Hash.Encrypt.Sha1(inputBox.Text);
                    break;
            }
        }

        private void ChangeSelect(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked) return;
            _type = ((RadioButton)sender).Text;
        }
    }
}
