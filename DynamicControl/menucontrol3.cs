using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicControl
{
    public partial class menucontrol3 : UserControl
    {
        public menucontrol3()
        {
            InitializeComponent();
            SetStatus(Status.View);
        }
        public enum Status
        {
            View, Edit
        }
        public enum ButtonType
        {
            Add, Delete, Edit, Save, Exit, Cancel, Search, Reload, Loc
        }
        private Status currentStatus;
        public delegate void ButtonClickedHandler(object sender, ButtonType buttonType, EventArgs e);
        public event ButtonClickedHandler ButtonClicked;

        protected virtual void OnButtonClicked(object sender, ButtonType buttonType, EventArgs e)
        {
            ButtonClicked?.Invoke(sender, buttonType, e);
        }
        public void SetStatus(Status status)
        {
            currentStatus = status;
            switch (status)
            {
                case Status.View:
                    btnSua.Enabled = true;
                    btnThem.Enabled = true;
                    btnThoat.Enabled = true;
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;

                    btnLoc.Enabled = true;
                    btnTaiLai.Enabled = true;
                    break;

                case Status.Edit:
                    btnSua.Enabled = false;
                    btnThem.Enabled = false;

                    btnThoat.Enabled = false;
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                    btnLoc.Enabled = false;
                    btnTaiLai.Enabled = true;
                    break;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SetStatus(Status.Edit);
            OnButtonClicked(sender, ButtonType.Add, e);
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            OnButtonClicked(sender, ButtonType.Reload, e);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            SetStatus(Status.Edit);
            OnButtonClicked(sender, ButtonType.Loc, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            OnButtonClicked(sender, ButtonType.Save, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            OnButtonClicked(sender, ButtonType.Exit, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetStatus(Status.View);
            OnButtonClicked(sender, ButtonType.Cancel, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SetStatus(Status.Edit);
            OnButtonClicked(sender, ButtonType.Edit, e);
        }
    }
}
