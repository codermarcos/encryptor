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

namespace Encryptor.Views.criptografias
{
    public partial class AssimetricasFrm : Form
    {
        public AssimetricasFrm()
        {
            InitializeComponent();
        }

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
                        MessageBox.Show(file.ToHex());
                    }
                }
            }
            
        }
    }
}
