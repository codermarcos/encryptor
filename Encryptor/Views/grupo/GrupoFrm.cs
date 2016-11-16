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

namespace Encryptor.Views.grupo
{
    public partial class GrupoFrm : Form
    {
        public GrupoFrm()
        {
            InitializeComponent();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            
        }


        private void Image_1_Mike(object sender, EventArgs e)
        {
            mike.Image = Properties.Resources._11;
        }
        private void Image_0_Mike(object sender, EventArgs e)
        {
            mike.Image = Properties.Resources._01;
        }
    }
}
