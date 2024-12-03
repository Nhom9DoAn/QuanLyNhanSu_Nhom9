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
using KimPhuong.BUS;
using KimPhuong.BUL;
using KimPhuong.DTO;

namespace KimPhuong.GUI
{
    public partial class frmThamGiaDaoTao : UIPage
    {
        NhanVienBUS nvbll = new NhanVienBUS();
        KhoaDaoTaoBUS kdtbll = new KhoaDaoTaoBUS();
        ThamGiaKhoaDaoTaoBLL tgbll = new ThamGiaKhoaDaoTaoBLL();
        bool them, sua, tim = false;
        Button btnDelete = new Button();
        private ContextMenuStrip contextMenu = new ContextMenuStrip();
        public frmThamGiaDaoTao()
        {
            InitializeComponent();

            //tạo button xóa ở dgv
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

            dgv_QLThamGiaDaoTao.ContextMenuStrip = contextMenu;
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_QLThamGiaDaoTao.SelectedRows.Count > 0)
            {
                int maNV = Convert.ToInt32(dgv_QLThamGiaDaoTao.SelectedRows[0].Cells["MaNV"].Value);
                int maKhoaDT = Convert.ToInt32(dgv_QLThamGiaDaoTao.SelectedRows[0].Cells["MaKhoaDaoTao"].Value);
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool success = tgbll.DeleteThamGiaDaoTao(maNV, maKhoaDT);
                    if (success)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadThamGia();
                        btnDelete.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void loadNhanVien()
        {
            cb_NhanVien.DataSource = nvbll.GetAll();
            cb_NhanVien.ValueMember = "MaNV";
            cb_NhanVien.DisplayMember = "HoTen";
        }

        public void loadKhoaDaoTao()
        {
            cb_KhoaDaoTao.DataSource = kdtbll.GetAll();
            cb_KhoaDaoTao.ValueMember = "MaKhoaDaoTao";
            cb_KhoaDaoTao.DisplayMember = "TenKhoaHoc";
        }

        public void loadThamGia()
        {
            dgv_QLThamGiaDaoTao.DataSource = tgbll.getAllKhoaDaoTao();
        }

        private void frmThamGiaDaoTao_Load(object sender, EventArgs e)
        {
            loadNhanVien();
            loadKhoaDaoTao();
            loadThamGia();
            disable();
        }

        private void dgv_QLThamGiaDaoTao_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_QLThamGiaDaoTao.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dgv_QLThamGiaDaoTao.SelectedRows[0];
                int manv = Convert.ToInt32(selected.Cells["MaNV"].Value);
                cb_NhanVien.SelectedValue = Convert.ToInt32(selected.Cells["MaNV"].Value);
                cb_KhoaDaoTao.SelectedValue = Convert.ToInt32(selected.Cells["MaKhoaDaoTao"].Value);

                dtp_NgayThamGia.Value = Convert.ToDateTime(selected.Cells["NgayThamGia"].Value);
                txt_KetQua.Text = selected.Cells["KetQua"].Value.ToString();
                lbl_FilePath.Text = selected.Cells["ChungChi"].Value?.ToString();

            }
        }



        private void btn_UploadFileChungChi_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files|*.pdf|Word Documents|*.docx|All Files|*.*";
            openFileDialog.Title = "Select a File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                lbl_FilePath.Text = filePath;

                if (dgv_QLThamGiaDaoTao.SelectedRows.Count > 0)
                {
                    DataGridViewRow selected = dgv_QLThamGiaDaoTao.SelectedRows[0];
                    selected.Cells["ChungChi"].Value = filePath;
                }
            }
        }

        public void resetText()
        {
            dtp_NgayThamGia.Value = DateTime.Now;
            txt_KetQua.Enabled = true;
        }

        public void enable()
        {
            cb_KhoaDaoTao.Enabled = cb_NhanVien.Enabled = dtp_NgayThamGia.Enabled = btn_UploadFileChungChi.Enabled = txt_KetQua.Enabled = true;
        }

        public void disable()
        {
            cb_KhoaDaoTao.Enabled = cb_NhanVien.Enabled = dtp_NgayThamGia.Enabled = btn_UploadFileChungChi.Enabled = txt_KetQua.Enabled = false;
        }

        private void menu_QLThamGiaDaoTao_ButtonClicked(object sender, DynamicControl.menucontrol2.ButtonType buttonType, EventArgs e)
        {
            switch (buttonType)
            {
                case DynamicControl.menucontrol2.ButtonType.Add:
                    them = true;
                    resetText();
                    enable();
                    break;

                case DynamicControl.menucontrol2.ButtonType.Edit:
                    if (dgv_QLThamGiaDaoTao.SelectedRows.Count > 0)
                    {
                            sua = true;
                            enable();
                        cb_NhanVien.Enabled = cb_KhoaDaoTao.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn dữ liệu cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;

                case DynamicControl.menucontrol2.ButtonType.Save:
                    int maNV = Convert.ToInt32(cb_NhanVien.SelectedValue);
                    int maDT = Convert.ToInt32(cb_KhoaDaoTao.SelectedValue);

                    var newThamGiaDaoTao = new ThamGiaKhoaDaoTaoDTO
                    {
                       MaNV = maNV,
                       MaKhoaDaoTao = maDT,
                        NgayThamGia = dtp_NgayThamGia.Value,
                       KetQua = txt_KetQua.Text,
                       ChungChi = lbl_FilePath.Text
                    };

                    if (them)
                    {
                        tgbll.AddThamGiaDaoTao(newThamGiaDaoTao);
                        
                        loadThamGia();
                        disable();
                    }
                    else if (sua)
                    {
                        newThamGiaDaoTao.MaNV = Convert.ToInt32(dgv_QLThamGiaDaoTao.SelectedRows[0].Cells["MaNV"].Value);
                        newThamGiaDaoTao.MaKhoaDaoTao = Convert.ToInt32(dgv_QLThamGiaDaoTao.SelectedRows[0].Cells["MaKhoaDaoTao"].Value);

                        newThamGiaDaoTao.MaNV = Convert.ToInt32(cb_NhanVien.SelectedValue);
                        newThamGiaDaoTao.MaKhoaDaoTao = Convert.ToInt32(cb_KhoaDaoTao.SelectedValue);
                        bool isUpdated = tgbll.UpdateThamGiaDaoTao(newThamGiaDaoTao);
                        if (isUpdated)
                        {
                            MessageBox.Show("Cập nhật thành công!", "Thông báo");
                            loadThamGia();
                            sua = false;
                            disable();
                            menu_QLThamGiaDaoTao.SetStatus(DynamicControl.menucontrol2.Status.View);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (tim == true)
                    {
                        int filterMonth = dtp_NgayThamGia.Value.Month;
                        int filterYear = dtp_NgayThamGia.Value.Year;
                        var filteredData = tgbll.getAllKhoaDaoTao();
                        filteredData = filteredData.Where(hd =>
                            hd.NgayThamGia.Month == filterMonth && hd.NgayThamGia.Year == filterYear).ToList();
                        dgv_QLThamGiaDaoTao.DataSource = filteredData;
                    }

                    break;

                case DynamicControl.menucontrol2.ButtonType.Cancel:
                    break;

                case DynamicControl.menucontrol2.ButtonType.Loc:
                    tim = true; dtp_NgayThamGia.Enabled = true;
                    break;

                case DynamicControl.menucontrol2.ButtonType.Reload:
                    loadKhoaDaoTao();
                    disable();
                    break;

                case DynamicControl.menucontrol2.ButtonType.Exit:
                    Application.Exit();
                    break;
            }
        }

        private void dgv_QLThamGiaDaoTao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_QLThamGiaDaoTao.Columns["ChungChi"].Index)
            {
                string filePath = dgv_QLThamGiaDaoTao.Rows[e.RowIndex].Cells["ChungChi"].Value?.ToString();

                if (!string.IsNullOrEmpty(filePath))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(filePath); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể mở file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Không có file nào để mở.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
