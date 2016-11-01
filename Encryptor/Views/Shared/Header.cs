using System;
using System.Drawing;
using System.Windows.Forms;
using Encryptor.Views.criptografias;

namespace Encryptor.Views.Shared
{
    public partial class Header : UserControl
    {
        public Header()
        {
            InitializeComponent();
        }


        private Form _parent;
        private Point _point;
        private bool _dragging;


        private void hashBtn_Click(object sender, EventArgs e)
        {
            _parent.Dispose();
            new HashFrm().Show(); 
        }
        private void Header_Load(object sender, EventArgs e)
        {
            _parent = ParentForm;
        }

        #region HEAD
        private void head_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _point = new Point(e.X, e.Y);
        }    
        private void head_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
        private void head_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var p = PointToScreen(e.Location);
            _parent.Location = new Point(p.X - _point.X, p.Y - _point.Y);
        }
        private void Sair(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Minificar(object sender, EventArgs e)
        {
            _parent.WindowState = FormWindowState.Minimized;
        }

        #endregion
    }
}
