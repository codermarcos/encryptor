using System;
using System.Windows.Forms;
using Logic;
using Logic.Criptographys;

namespace Encryptor.Views.criptografias
{
    public partial class AssimetricasFrm : Form
    {
        public AssimetricasFrm()
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
            if (string.IsNullOrEmpty(_type))
            {
                MessageBox.Show(@"Selecione qual é a simetrica !"); return;
            }
            if (string.IsNullOrEmpty(_input?.Content))
            {
                MessageBox.Show(@"Abra o arquivo antes de encriptar !"); return;
            }

            Encrypt();
        }

        public void Descriptografar(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_type))
            {
                MessageBox.Show(@"Selecione qual é a simetrica !"); return;
            }
            if (string.IsNullOrEmpty(_input?.Content))
            {
                MessageBox.Show(@"Abra o arquivo que vai encriptar !"); return;
            }
            if (_input.Extension != "crp")
            {
                MessageBox.Show(@"Apenas arquivos crp podem ser descriptografados !"); return;
            }

            Decrypt();
        }

        private void Salvar(object sender, EventArgs e)
        {
            if (_input == null)
            {
                MessageBox.Show(@"Abra o arquivo que vai encriptar !"); return;
            }
            if (_output == null)
            {
                MessageBox.Show(@"Realize uma acão antes de salvar !"); return;
            }

            SaveFile();
        }

        private void Limpar(object sender, EventArgs e)
        {
            _type = null;
            _input = null;
            rRSA.Checked = false;
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
                case "RSA":
                    _output.Content = Assimetricas.Encript.Rsa(_input.Read());
                    break;
            }

            outputLbl.Text = _output.Content;
        }

        private void Decrypt()
        {
            _output = _input;
            switch (_type)
            {
                case "RSA":
                    _output.Content = Assimetricas.Decript.Rsa(_input.Read());
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
                Limpar(null, null);
            }
        }

        private void ChangeSelect(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked) return;
            _type = ((RadioButton)sender).Text;
        }

        private void AssimetricasFrm_Load(object sender, EventArgs e)
        {
        }
    }
}
