using System;
using System.Windows.Forms;
using Logic;
using Logic.Criptographys;

namespace Encryptor.Views.criptografias
{
    public partial class MikcipherFrm : Form
    {
        public MikcipherFrm()
        {
            InitializeComponent();
        }
        private File _file;
        private Mikcipher _mikcipher;

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFile();
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
            if (string.IsNullOrEmpty(_file?.Input))
            {
                MessageBox.Show(@"Abra o arquivo antes de encriptar !"); return;
            }
            if (string.IsNullOrEmpty(publicaBox.Text))
            {
                MessageBox.Show(@"Digite uma chave publica antes de encriptar !"); return;
            }

            Encrypt();
        }

        public void Descriptografar(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_file?.Output))
            {
                MessageBox.Show(@"Abra o arquivo que vai encriptar !"); return;
            }
            if (string.IsNullOrEmpty(privadaBox.Text))
            {
                MessageBox.Show(@"Digite uma chave privada antes de Decriptar !"); return;
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
            _file = null;
            _mikcipher = null;
            outputLbl.Text = string.Empty;
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
                _mikcipher = new Mikcipher(_file.IsCrpFile() ? _file.Output : _file.Input);
            }
        }


        private void Encrypt()
        {
            _file.Password = publicaBox.Text;
            _file.Output = _mikcipher.Encript(_file.Password);
            outputLbl.Text = _file.Output;
        }

        private void Decrypt()
        {
            _file.Password = privadaBox.Text;
            _file.Input = _mikcipher.Decript(_file.Password);
            outputLbl.Text = _file.Input;
        }

        private void GetPublicKey()
        {
            using (var mikchiper = new Mikcipher(string.Empty))
                output_PublicKeyLbl.Text = mikchiper.GetPublickey(gPublicaBox.Text, gPrivadaBox.Text);
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

        #region gerar senha 
        private void GeneratePassword(object sender, EventArgs e)
        {
            var btn = ((Button) sender);
            var key = btn.Name.Contains("R");
            if (key)
            {
                vgPrivadaBtn.Checked = true;
            }
            else
            {
                vgPublicaBtn.Checked = true;
            }
            switch (btn.Text)
            {
                case "16":
                    if (key)
                    {
                        gPrivadaBox.Text = Guid.NewGuid().ToString().Replace(@"-", "").ToUpper().Substring(0, 16);
                    }
                    else
                    {
                        gPublicaBox.Text = Guid.NewGuid().ToString().Replace(@"-", "").ToUpper().Substring(0, 16);
                    }
                    break;
                case "24":
                    if (key)
                    {
                        gPrivadaBox.Text = Guid.NewGuid().ToString().Replace(@"-", "").ToUpper().Substring(0, 24);
                    }
                    else
                    {
                        gPublicaBox.Text = Guid.NewGuid().ToString().Replace(@"-", "").ToUpper().Substring(0, 24);
                    }
                    break;
                case "32":
                    if (key)
                    {
                        gPrivadaBox.Text = Guid.NewGuid().ToString().Replace(@"-", "").ToUpper().Substring(0, 32);
                    }
                    else
                    {
                        gPublicaBox.Text = Guid.NewGuid().ToString().Replace(@"-", "").ToUpper().Substring(0, 32);
                    }
                    break;
            }
        }
        #endregion

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
