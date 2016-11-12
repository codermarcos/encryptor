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

        private string _content;
        private string _file;
        private string _type;

        private void openBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_type))
            {
                MessageBox.Show(@"Selecione qual o hash !"); return;
            }

            using (var dialog = new OpenFileDialog
            {
                Title = @"Selecione o arquivo a ser Encryptado!",
                Filter = @"AllFiles |*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            })
            {
                if (dialog.ShowDialog() == DialogResult.Cancel) return;

                using (var file = new File(dialog.FileName))
                {
                    _file = dialog.SafeFileName;
                    _content = file.ToHex();
                }
            }
        }

        private void salvarBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_content))
            {
                MessageBox.Show(@"Abra o arquivo primeiro !"); return;
            }

            using (var dialog = new SaveFileDialog()
            {
                Title = @"Onde deseja salvar o arquivo!",
                Filter = @"Encryptor |*.crp",
                FileName = _file
            })
            {
                if (dialog.ShowDialog() == DialogResult.Cancel) return;               

                using (var file = new File(dialog.FileName))
                {
                    switch (_type)
                    {
                        case "MD5":
                            file.Write(Hash.Md5(_content));
                            break;
                        case "SHA1":
                            file.Write(Hash.Sha1(_content));
                            break;
                        case "SHA152":
                            file.Write(Hash.Sha512(_content));
                            break;
                    }
                }
            }
        }

        private void ChangeSelect(object sender, EventArgs e)
        {
            if (!((RadioButton) sender).Checked) return;
                _type = ((RadioButton)sender).Text;
        }
    }
}
