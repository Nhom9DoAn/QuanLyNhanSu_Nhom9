using KimPhuong.BUL;
using KimPhuong.DAL;
using KimPhuong.DTO;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KimPhuong.GUI
{
    public partial class frmNghiPhep : UIPage
    {
        NghiPhepBUL nghiPhepBUL;
        BUS_NhanVien nhanVienBUS;
        BUS_ChucVu chucVuBUS;
        bool them, xoa, sua, tim = false;

        private void dgvNghiPhep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblNgaySinh_Click(object sender, EventArgs e)
        {

        }
        private void LoadCombobox()
        {

            List<DTO_NhanVien> nhanVienList = nhanVienBUS.getAll();
            nhanVienList.Insert(0, new DTO_NhanVien { MaNV = "Tất cả", HoTen = "" });
            BindComboBox(cboMaNV, nhanVienList, "MaNV", "MaNV");

            List<DTO_ChucVu> chucVuList = chucVuBUS.getAll();
            chucVuList.Insert(0, new DTO_ChucVu { MaCV = "", TenCV = "Tất cả" });
            BindComboBox(cboChucVu, chucVuList, "TenCV", "MaCV");
        }
        private void BindComboBox<T>(ComboBox comboBox, List<T> dataSource, string displayMember, string valueMember, bool isCurrency = false)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource = dataSource;

            comboBox.DataSource = bindingSource;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }
        private void LoadControls()
        {

            txtMaNP.Text = txtLyDo.Text = dtpTuNgay.Text = dtpDenNgay.Text = dtpNgaySinh.Text = txtTenNV.Text = txtSDT.Text = "";

            cboMaNV.SelectedValue = "Tất cả";
            cboChucVu.SelectedValue = "Tất cả";


            dgvNghiPhep.ClearSelection();
        }

        private void dgvNghiPhep_SelectionChanged(object sender, EventArgs e)
        {
            LoadCombobox();
            dgvNghiPhep.Columns["MaNP"].HeaderText = "Mã Phòng Ban";
            dgvNghiPhep.Columns["TuNgay"].HeaderText = "Từ Ngày";
            dgvNghiPhep.Columns["DenNgay"].HeaderText = "Đến Ngày";
            dgvNghiPhep.Columns["LyDo"].HeaderText = "Lý Do";
            dgvNghiPhep.Columns["TinhTrang"].HeaderText = "Tình Trạng";
            dgvNghiPhep.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            if (dgvNghiPhep.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dgvNghiPhep.SelectedRows[0];
                string maNP = selected.Cells["MaNP"].Value.ToString();
                string tuNgay = selected.Cells["TuNgay"].Value.ToString();
                string denNgay = selected.Cells["DenNgay"].Value.ToString();
                string lyDo = selected.Cells["LyDo"].Value.ToString();
                string tinhTrang = selected.Cells["TinhTrang"].Value.ToString();
                if (tinhTrang == "Chưa duyệt")
                {
                    radChuaDuyet.Checked = true;
                    radDaDuyet.Checked = false;
                }
                else
                {
                    radChuaDuyet.Checked = false;
                    radDaDuyet.Checked = true;
                }

                string maNV = selected.Cells["MaNV"].Value.ToString();
                string tenNV = nghiPhepBUL.LayTenNhanVienTuMa(maNV);
                string ngaySinh = nghiPhepBUL.LayNgaySinhNhanVienTuMa(maNV);
                string sdt = nghiPhepBUL.LaySDTNhanVienTuMa(maNV);
                string maCV = nghiPhepBUL.LayTenCV(maNV);

                txtMaNP.Text = maNP;
                txtLyDo.Text = lyDo;
                cboMaNV.SelectedValue = maNV;
                dtpTuNgay.Text = tuNgay;
                dtpDenNgay.Text = denNgay;
                txtTenNV.Text = tenNV;
                dtpNgaySinh.Text = ngaySinh;
                txtSDT.Text = sdt;
                cboChucVu.Text = maCV;
            }
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaNV.SelectedIndex > 0)
            {
                string maNV = cboMaNV.SelectedValue.ToString();


                string tenNV = nghiPhepBUL.LayTenNhanVienTuMa(maNV);
                string ngaySinh = nghiPhepBUL.LayNgaySinhNhanVienTuMa(maNV);
                string sdt = nghiPhepBUL.LaySDTNhanVienTuMa(maNV);
                string chucVu = nghiPhepBUL.LayTenCV(maNV);

                txtTenNV.Text = tenNV;
                dtpNgaySinh.Text = ngaySinh;
                txtSDT.Text = sdt;
                cboChucVu.Text = chucVu;
            }
        }

        private void txtMaNP_TextChanged(object sender, EventArgs e)
        {
            if (them == true)
            {
                if (!txtMaNP.Text.StartsWith("NP"))
                {
                    txtMaNP.Text = "NP" + txtMaNP.Text;
                    txtMaNP.SelectionStart = txtMaNP.Text.Length;
                }
            }
        }

        private void dgvNghiPhep_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dgvNghiPhep.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
            else
            {
                dgvNghiPhep.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        public frmNghiPhep()
        {
            InitializeComponent();
            nghiPhepBUL = new NghiPhepBUL();
            LoadData();
            dgvNghiPhep.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14);
            LoadControls();
            nhanVienBUS = new BUS_NhanVien();
            chucVuBUS = new BUS_ChucVu();
        }

        private void LoadData()
        {
            dgvNghiPhep.DataSource = null;
            nghiPhepBUL = new NghiPhepBUL();
            dgvNghiPhep.DataSource = nghiPhepBUL.getAll();

            dgvNghiPhep.Columns["MaNP"].HeaderText = "Mã Phòng Ban";
            dgvNghiPhep.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            dgvNghiPhep.Columns["TuNgay"].HeaderText = "Từ Ngày";
            dgvNghiPhep.Columns["DenNgay"].HeaderText = "Đến Ngày";
            dgvNghiPhep.Columns["LyDo"].HeaderText = "Lý Do";
            dgvNghiPhep.Columns["TinhTrang"].HeaderText = "Tình Trạng";
        }

        private void frmNghiPhep_Load(object sender, EventArgs e)
        {

        }

        private void menucontrol1_ButtonClicked(object sender, DynamicControl.menucontrol.ButtonType buttonType, EventArgs e)
        {
            switch (buttonType)
            {
                case DynamicControl.menucontrol.ButtonType.Add:
                    them = true;
                    txtMaNP.Enabled = txtLyDo.Enabled = txtSDT.Enabled = dtpDenNgay.Enabled = dtpTuNgay.Enabled = radChuaDuyet.Checked = true;
                    cboMaNV.Enabled = true;
                    txtSDT.Enabled = false;
                    txtMaNP.Text = txtLyDo.Text = "";
                    txtMaNP.Focus();
                    break;
                case DynamicControl.menucontrol.ButtonType.Edit:
                    sua = true;
                    txtLyDo.Enabled = radChuaDuyet.Enabled = radDaDuyet.Enabled = true;
                    break;
                case DynamicControl.menucontrol.ButtonType.Search:
                    tim = true;
                    cboMaNV.Enabled = true;
                    break;
                case DynamicControl.menucontrol.ButtonType.Delete:
                    if (dgvNghiPhep.SelectedRows.Count > 0)
                    {

                        DialogResult result = MessageBox.Show("Bạn có xác nhận xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (result == DialogResult.OK)
                        {
                            DataGridViewRow selectedRow = dgvNghiPhep.SelectedRows[0];
                            string maNP = selectedRow.Cells["MaNP"].Value.ToString();

                            NghiPhepDTO nghiPhepDTO = new NghiPhepDTO();
                            nghiPhepDTO.MaNP = maNP;
                            bool kq = nghiPhepBUL.delete(nghiPhepDTO);
                            if (kq == true)
                            {
                                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Xóa không thành công");
                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hãy chọn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case DynamicControl.menucontrol.ButtonType.Cancel:
                    txtMaNP.Enabled = txtLyDo.Enabled = txtSDT.Enabled = dtpDenNgay.Enabled = dtpTuNgay.Enabled = cboMaNV.Enabled = false;
                    them = xoa = sua = tim = false;
                    break;
                case DynamicControl.menucontrol.ButtonType.Save:
                    if (them)
                    {
                        DateTime tuNgay, denNgay;
                        DateTime ngayhientai = DateTime.Now;

                        if (cboMaNV.SelectedIndex > 0)
                        {
                            if (DateTime.TryParse(dtpTuNgay.Text, out tuNgay) &&
                            DateTime.TryParse(dtpDenNgay.Text, out denNgay))
                            {
                                if (tuNgay <= denNgay)
                                {
                                    if (nghiPhepBUL.KiemTraTrungMa(txtMaNP.Text))
                                    {
                                        bool isChuaDuyet = radChuaDuyet.Checked;

                                        string tinhTrang = isChuaDuyet ? "Chưa duyệt" : "Đã duyệt";
                                        nghiPhepBUL.insert(new NghiPhepDTO
                                        {
                                            MaNP = txtMaNP.Text,
                                            MaNV = cboMaNV.SelectedValue.ToString(),
                                            TuNgay = tuNgay,
                                            DenNgay = denNgay,
                                            LyDo = txtLyDo.Text,
                                            TinhTrang = tinhTrang
                                        });

                                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        them = false;
                                        LoadData();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Mã nghỉ phép đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Ngày bắt đầu hoặc ngày kết thúc không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Dữ liệu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nhân viên không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else if (sua)
                    {
                        DateTime tuNgay, denNgay;
                        if (CheckInput() != false)
                        {
                            if (cboMaNV.SelectedIndex > 0 &&
                                DateTime.TryParse(dtpTuNgay.Text, out tuNgay) &&
                                DateTime.TryParse(dtpDenNgay.Text, out denNgay))
                            {
                                if (tuNgay <= denNgay)
                                {
                                    string tinhTrang = radChuaDuyet.Checked ? "Chưa duyệt" : "Đã duyệt";
                                    nghiPhepBUL.update(new NghiPhepDTO
                                    {
                                        MaNP = txtMaNP.Text,
                                        MaNV = cboMaNV.SelectedValue.ToString(),
                                        LyDo = txtLyDo.Text,
                                        TuNgay = tuNgay,
                                        DenNgay = denNgay,
                                        TinhTrang = tinhTrang
                                    });
                                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    sua = false;
                                    LoadData();
                                }
                                else
                                {
                                    MessageBox.Show("Dữ liệu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Dữ liệu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Dữ liệu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else if (tim)
                    {
                        string maNV = cboMaNV.Text.Trim();

                        dgvNghiPhep.DataSource = null;

                        List<NghiPhepDTO> result = nghiPhepBUL.searchLinq(maNV);

                        dgvNghiPhep.DataSource = result;

                        if (result.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy kết quả phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        cboMaNV.Enabled = false;
                        tim = false;
                    }
                    break;
                case DynamicControl.menucontrol.ButtonType.Reload:
                    LoadData();
                    txtMaNP.Enabled = txtLyDo.Enabled = txtSDT.Enabled = dtpDenNgay.Enabled = dtpTuNgay.Enabled = false;
                    cboMaNV.Enabled = false;
                    break;

                case DynamicControl.menucontrol.ButtonType.Exit:
                    Application.Exit();
                    break;
            }
        }

        private bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtMaNP.Text) || string.IsNullOrEmpty(txtLyDo.Text)
                || string.IsNullOrEmpty(dtpTuNgay.Text) || string.IsNullOrEmpty(dtpDenNgay.Text)
                || cboMaNV.SelectedValue.ToString() == "Tất cả" || radDaDuyet.Checked == false && radChuaDuyet.Checked == false)
                return false;
            else
                return true;
        }
    }
}
