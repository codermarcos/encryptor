using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Logic.Criptographys;

namespace Encryptor.Views.criptografias
{
    public partial class hashFrm : Form
    {
        public hashFrm()
        {
            InitializeComponent();
        }

        private string _content;
        private string _file;

        private void openBtn_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog
            {
                Title = @"Selecione o arquivo a ser Encryptado!",
                Filter = @"AllFiles |*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            })
            {
                if (dialog.ShowDialog() != DialogResult.Cancel)
                {
                    using (var file = new File(dialog.FileName))
                    {
                        _file = dialog.SafeFileName;
                        _content = file.ToHex();
                    }
                }
            }
            
        }

        private void salvarBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_content))return;
            using (var dialog = new SaveFileDialog()
            {
                Title = @"Onde deseja salvar o arquivo!",
                Filter = @"Encryptor |*.crp",
                FileName = _file
            })
            {
                if (dialog.ShowDialog() != DialogResult.Cancel)
                {
                    using (var file = new File(dialog.FileName))
                    {   
                        file.Write(_content);
                    }
                }
            }
        }        
    }
}
