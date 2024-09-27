using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;

namespace DynamicControl
{
    public partial class menucontrol : UserControl
    {
        public enum Status
        {
            View, Edit
        }
        public enum ButtonType
        {
            Add, Delete, Edit, Save, Exit, Cancel, Search
        }
        private Status currentStatus;

        public menucontrol()
        {
            InitializeComponent();
        }
        public delegate void ButtonClickedHandler(object sender, ButtonType buttonType, EventArgs e);
        public event ButtonClickedHandler ButtonClicked;

        protected virtual void OnButtonClicked(object sender, ButtonType buttonType, EventArgs e)
        {
            ButtonClicked?.Invoke(sender, buttonType, e);
        }
        private void SetStatus(Status status)
        {
            currentStatus = status;
            switch(status)
            {
                case Status.View:
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThoat.Enabled = true;
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                    break;

                case Status.Edit:
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnThoat.Enabled = false;
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                    break;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            SetStatus(Status.Edit);
            OnButtonClicked(sender, ButtonType.Add, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SetStatus(Status.Edit);
            OnButtonClicked(sender, ButtonType.Edit, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SetStatus(Status.View);
            OnButtonClicked(sender, ButtonType.Delete, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SetStatus(Status.View);
            OnButtonClicked(sender, ButtonType.Save, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetStatus(Status.View);
            OnButtonClicked(sender, ButtonType.Cancel, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            OnButtonClicked(sender, ButtonType.Exit, e);
        }
    }
}
