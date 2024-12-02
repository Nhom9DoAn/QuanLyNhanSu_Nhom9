using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using KimPhuong.DTO;
using KimPhuong.BUL;

namespace KimPhuong.GUI
{
    public partial class frmChucVu : UIPage
    {
        ChucVuBLL cvbll = new ChucVuBLL();
        bool them, sua, tim = false;
        Button btnDelete = new Button();
        private ContextMenuStrip contextMenu = new ContextMenuStrip();
        public frmChucVu()
        {
            InitializeComponent();

            btnDelete.Text = "Delete";
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.White;
            btnDelete.Size = new Size(100, 40);
            btnDelete.Location = new Point(200, 400);
            this.Controls.Add(btnDelete);
            btnDelete.Visible = false;

            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Delete");
            deleteMenuItem.BackColor = Color.Red;
            deleteMenuItem.ForeColor = Color.Black;
            deleteMenuItem.Font = new Font(deleteMenuItem.Font, FontStyle.Bold);
            deleteMenuItem.Click += DeleteMenuItem_Click;
            contextMenu.Items.Add(deleteMenuItem);

            dgv_ChucVu.ContextMenuStrip = contextMenu;
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_ChucVu.SelectedRows.Count > 0)
            {
                int maCV = Convert.ToInt32(dgv_ChucVu.SelectedRows[0].Cells["MaCV"].Value);
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa công tác này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool success = cvbll.DeleteChucVu(maCV);
                    if (success)
                    {
                        MessageBox.Show("Xóa chức vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadChucVu();
                        btnDelete.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Xóa chức vụ thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public void loadChucVu()
        {
            dgv_ChucVu.DataSource = cvbll.GetAllChucVu();
        }
        private void frmChucVu_Load(object sender, EventArgs e)
        {
            loadChucVu();
            disable();
        }

        public void enable()
        {
            txt_TenChucVu.Enabled = txt_MoTaChucVu.Enabled = true;
        }

        public void resetText()
        {
            txt_TenChucVu.ResetText();
            txt_MoTaChucVu.ResetText();
        }

        private void menu_QLChucVu_ButtonClicked(object sender, DynamicControl.menucontrol2.ButtonType buttonType, EventArgs e)
        {
            switch (buttonType)
            {
                case DynamicControl.menucontrol2.ButtonType.Add:
                    them = true;
                    resetText();
                    enable();
                    break;

                case DynamicControl.menucontrol2.ButtonType.Edit:
                    if (dgv_ChucVu.SelectedRows.Count > 0)
                    {
                        sua = true;
                        enable();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn dữ liệu cần sửa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    break;

                case DynamicControl.menucontrol2.ButtonType.Delete:

                    break;

                case DynamicControl.menucontrol2.ButtonType.Save:
                    var newChucVu = new ChucVuDTO
                    {
                        MaCV = sua ? Convert.ToInt32(dgv_ChucVu.SelectedRows[0].Cells["MaCV"].Value) : 0,
                        TenCV = txt_TenChucVu.Text,
                        Mota = txt_MoTaChucVu.Text
                    };
                    if(txt_TenChucVu.Text =="" || txt_MoTaChucVu.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin đầy đủ");
                    }
                    if (them)
                    {

                        cvbll.InsertChucVu(newChucVu);
                        loadChucVu();
                        disable();
                    }
                    else if (sua)
                    {
                        if (cvbll.UpdateChucVu(newChucVu))
                        {
                            MessageBox.Show("Cập nhật thành công!", "Thông báo");
                            loadChucVu();
                            sua = false;
                            disable();
                            menu_QLChucVu.SetStatus(DynamicControl.menucontrol2.Status.View);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (tim == true)
                    {
                        string search_tencv = txt_TenChucVu.Text;

                        var filteredData = cvbll.GetAllChucVu();

                        if (!string.IsNullOrEmpty(search_tencv))
                        {
                            filteredData = filteredData.Where(ct => ct.TenCV.Equals(search_tencv)).ToList();
                        }
                        int recordCount = filteredData.Count;
                        MessageBox.Show($"Tìm thấy {recordCount} bản ghi tương ứng.", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgv_ChucVu.DataSource = filteredData;
                    }


                    break;

                case DynamicControl.menucontrol2.ButtonType.Cancel:
                    enable();
                    break;

                case DynamicControl.menucontrol2.ButtonType.Search:
                    tim = true; enable();
                    break;

                case DynamicControl.menucontrol2.ButtonType.Reload:
                    loadChucVu();
                    disable();
                    break;

                case DynamicControl.menucontrol2.ButtonType.Exit:
                    Application.Exit();
                    break;
            }
        }

        public void disable()
        {
            txt_TenChucVu.Enabled = txt_MoTaChucVu.Enabled = false;
        }

        private void dgv_ChucVu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_ChucVu.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dgv_ChucVu.SelectedRows[0];
                txt_TenChucVu.Text = selected.Cells["TenCV"].Value.ToString();
                txt_MoTaChucVu.Text = selected.Cells["MoTa"].Value.ToString();
            }
        }
    }
}
