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
        private File _file;

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFile();
        }

        public void Criptografar(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_type))
            {
                MessageBox.Show(@"Selecione qual é a simetrica !"); return;
            }
            if (string.IsNullOrEmpty(_file?.Input))
            {
                MessageBox.Show(@"Abra o arquivo antes de encriptar !"); return;
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
            if (string.IsNullOrEmpty(_file?.Output))
            {
                MessageBox.Show(@"Abra o arquivo que vai encriptar !"); return;
            }
            if (string.IsNullOrEmpty(passwordBox.Text))
            {
                MessageBox.Show(@"Digite uma senha antes de encriptar !"); return;
            }
            if (!_file.IsCrpFile())
            {
                MessageBox.Show(@"Apenas arquivos crp podem ser descriptografados !"); return;
            }

            Decrypt();
        }

        private void Salvar(object sender, EventArgs e)
        {
            if (_file == null)
            {
                MessageBox.Show(@"Abra o arquivo que vai encriptar !"); return;
            }
            if (string.IsNullOrEmpty(_file?.Output) || string.IsNullOrEmpty(_file?.Input))
            {
                MessageBox.Show(@"Descriptogafe ou Encriptografe antes de salvar !"); return;
            }

            SaveFile();
        }

        private void Limpar(object sender, EventArgs e)
        {
            _type = null;
            _file = null;
            rDES.Checked = false;
            rRINJDAEL.Checked = false;
            outputLbl.Text = string.Empty;
            passwordBox.Text = string.Empty; 
            visibiladadeBtn.Checked = false;
        }

        private void OpenFile()
        {
            using (var dialog = new OpenFileDialog
            {
                Title = @"Selecione o arquivo a ser Encryptado!",
                Filter = @"Encrypted Files |*.crp|Text Files |*.txt",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            })
            {
                _file = dialog.ShowDialog() == DialogResult.Cancel ? null : new File(dialog.FileName);

                if (_file == null) return;

                outputLbl.Text = _file.Read();
            }
        }

        private void Encrypt()
        {
            _file.Password = passwordBox.Text;
            switch (_type)
            {
                case "RIJNDAEL":
                    _file.Output = Simetricas.Encript.Rijndael(_file.Read(), _file.Password);
                    break;
                case "DES":
                    _file.Output = Simetricas.Encript.Des(_file.Read(), _file.Password);
                    break;
            }

            outputLbl.Text = _file.Output;
        }

        private void Decrypt()
        {
            _file.Password = passwordBox.Text;
            switch (_type)
            {
                case "RIJNDAEL":
                    _file.Input = Simetricas.Decript.Rijndael(_file.Read(), _file.Password);
                    break;
                case "DES":
                    _file.Input = Simetricas.Decript.Des(_file.Read(), _file.Password);
                    break;
            }

            outputLbl.Text = _file.Input;
        }

        private void SaveFile()
        {
            using (var dialog = new SaveFileDialog()
            {
                Title = @"Onde deseja salvar o arquivo!",
                Filter = _file.IsCrpFile() ? @"Text Files |*.txt" : @"Encryptor |*.crp",
                FileName = _file.Name
            })
            {
                if (dialog.ShowDialog() == DialogResult.Cancel) return;
                _file.Path = dialog.FileName;
                _file.Save();
                MessageBox.Show(@"Arquivo salvo com sucesso !");
                Limpar(null,null);
            }
        }

        private void GeneratePassword(object sender, EventArgs e)
        {
            visibiladadeBtn.Checked = true;
            switch (((Button)sender).Text)
            {
                case "16":
                    passwordBox.Text = Guid.NewGuid().ToString().Replace(@"-", "").ToUpper().Substring(0,16);
                        break;
                case "24":
                    passwordBox.Text = Guid.NewGuid().ToString().Replace(@"-", "").ToUpper().Substring(0, 24);
                    break;
                case "32":
                    passwordBox.Text = Guid.NewGuid().ToString().Replace(@"-", "").ToUpper().Substring(0, 32);
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
