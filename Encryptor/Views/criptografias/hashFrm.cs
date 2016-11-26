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
        private File _file;

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFile();
        }

        public void Criptografar(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_file?.Input))
            {
                MessageBox.Show(@"Abra o arquivo primeiro !"); return;
            }
            if (string.IsNullOrEmpty(_type))
            {
                MessageBox.Show(@"Selecione qual o hash !"); return;
            }

            Encrypt();
        }

        private void Salvar(object sender, EventArgs e)
        {
            if (_file == null)
            {
                MessageBox.Show(@"Abra o arquivo antes de salvar !"); return;
            }
            if (string.IsNullOrEmpty(_file.Output))
            {
                MessageBox.Show(@"Criptografe o arquivo antes de salvar !"); return;
            }

            SaveFile();
        }

        private void Limpar(object sender, EventArgs e)
        {
            _type = null;
            _file = null;
            rMD5.Checked = false;
            rSHA1.Checked = false;
            outputLbl.Text = string.Empty;
        }

        private void OpenFile()
        {
            using (var dialog = new OpenFileDialog
            {
                Title = @"Selecione o arquivo a ser Encryptado!",
                Filter = @"Text Files |*.txt|Encrypted Files |*.crp",
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
            switch (_type)
            {
                case "MD5":
                    _file.Output = Hash.Encrypt.Md5(_file.Read());
                    break;
                case "SHA1":
                    _file.Output = Hash.Encrypt.Sha1(_file.Read());
                    break;
            }

            outputLbl.Text = _file.Output;
        }

        private void SaveFile()
        {
            using (var dialog = new SaveFileDialog()
            {
                Title = @"Onde deseja salvar o arquivo!",
                Filter = @"Encryptor |*.crp",
                FileName = _file.Name
            })
            {
                if (dialog.ShowDialog() == DialogResult.Cancel) return;
                _file.Path = dialog.FileName;
                _file.Save();
                MessageBox.Show(@"Arquivo salvo com sucesso !");
                Limpar(null, null);
            }
        }

        private void ChangeSelect(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked) return;
            _type = ((RadioButton)sender).Text;
        }
    }
}
