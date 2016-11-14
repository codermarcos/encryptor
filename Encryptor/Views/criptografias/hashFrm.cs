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
        private File _input;
        private File _output;

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFile();
        }

        public void Criptografar(object sender, EventArgs e)
        {
            Crypt crypt = new Crypt(CryptProvider.DES); // Tipos: DES, RC2, Rijndael e TripleDES
            crypt.Key = "1456";

            string textoCriptografado = crypt.Encrypt("MARCOS JUNIOR");

            MessageBox.Show(textoCriptografado);


            string textoDescripto = crypt.Decrypt(textoCriptografado);

            MessageBox.Show(textoDescripto);

            if (string.IsNullOrEmpty(_type))
            {
                MessageBox.Show(@"Selecione qual o hash !"); return;
            }
            if (string.IsNullOrEmpty(_input?.Content))
            {
                MessageBox.Show(@"Abra o arquivo antes de  !"); return;
            }

            Encrypt();
        }

        private void Salvar(object sender, EventArgs e)
        {
            if (_input == null)
            {
                MessageBox.Show(@"Abra o arquivo primeiro !"); return;
            }
            if (_output == null)
            {
                MessageBox.Show(@"Criptografe o arquivo antes de salvar !"); return;
            }

            SaveFile();
        }

        private void Limpar(object sender, EventArgs e)
        {
            _type = null;
            _input = null;
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
                _input = dialog.ShowDialog() == DialogResult.Cancel ? null : new File(dialog.FileName);

                if (_input == null) return;

                outputLbl.Text = _input.Read();
            }
        }

        private void Encrypt()
        {
            _output = _input;  
            switch (_type)
            {
                case "MD5":
                    _output.Content = Hash.Encrypt.Md5(_input.Read());
                    break;
                case "SHA1":
                    _output.Content = Hash.Encrypt.Md5(_input.Read());
                    break;
            }

            outputLbl.Text = _output.Content;
        }

        private void SaveFile()
        {
            using (var dialog = new SaveFileDialog()
            {
                Title = @"Onde deseja salvar o arquivo!",
                Filter = @"Encryptor |*.crp",
                FileName = _input.Name
            })
            {
                if (dialog.ShowDialog() == DialogResult.Cancel) return;
                _output.Path = dialog.FileName;
                _output.Save();
                MessageBox.Show(@"Arquivo salvo com sucesso !");
            }
        }

        private void ChangeSelect(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked) return;
            _type = ((RadioButton)sender).Text;
        }
    }
}
