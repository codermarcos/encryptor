using System;
using System.Drawing;
using System.Windows.Forms;
using Encryptor.Views.conclusao;
using Encryptor.Views.criptografias;
using Encryptor.Views.grupo;

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

        private void Header_Load(object sender, EventArgs e)
        {
            _parent = ParentForm;
        }

        #region grupo
        private void CallGrupoFrm(object sender, EventArgs e)
        {
            _parent.Dispose();
            new GrupoFrm().Show();
        }
        #endregion

        #region conclusao
        private void CallConclusaoFrm(object sender, EventArgs e)
        {
            _parent.Dispose();
            new ConclusaoFrm().Show();
        }
        #endregion

        #region cryptografias
        private void CallAssimetricasFrm(object sender, EventArgs e)
        {
            _parent.Dispose();
            new AssimetricasFrm().Show();
        }

        private void CallSimetricasFrm(object sender, EventArgs e)
        {
            _parent.Dispose();
            new SimetricasFrm().Show();
        }

        private void CallHashFrm(object sender, EventArgs e)
        {
            _parent.Dispose();
            new HashFrm().Show(); 
        }
        #endregion

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
