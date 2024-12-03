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
using System.IO;
using KimPhuong.BUS;
using OfficeOpenXml;

namespace KimPhuong.GUI
{
    public partial class frmQLUngVien : UIPage
    {
        UngVienBLL uvbll = new UngVienBLL();
        TuyenDungBLL tdbll = new TuyenDungBLL();
        NhanVienBUS nvbll = new NhanVienBUS();
        bool them, sua, tim = false;
        Button btnDelete = new Button();
        private ContextMenuStrip contextMenu = new ContextMenuStrip();
        public frmQLUngVien()
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

            dgv_QLUngVien.ContextMenuStrip = contextMenu;
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_QLUngVien.SelectedRows.Count > 0)
            {
                int maTP = Convert.ToInt32(dgv_QLUngVien.SelectedRows[0].Cells["MaUngVien"].Value);
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool success = uvbll.DeleteUngVien(maTP);
                    if (success)
                    {
                        MessageBox.Show("Xóa thưởng phạt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadUngVien();
                        btnDelete.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Xóa thưởng phạt thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }


        public void loadUngVien()
        {
            dgv_QLUngVien.DataSource = uvbll.getAllUngVien();

            if (dgv_QLUngVien.Columns["MaUT"] != null)
            {
                dgv_QLUngVien.Columns["MaUT"].Visible = false;
            }
            if (dgv_QLUngVien.Columns["FileName"] != null)
            {
                dgv_QLUngVien.Columns["FileName"].Visible = false;
            }

            dgv_QLUngVien.Columns["NgayUngTuyen"].DefaultCellStyle.Format = "dd/MM/yyyy";

            if (dgv_QLUngVien.Columns["IsEmployee"] == null)
            {
                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
                checkColumn.Name = "IsEmployee";
                checkColumn.HeaderText = "Become Employee";
                checkColumn.ReadOnly = true; 
                dgv_QLUngVien.Columns.Add(checkColumn);
            }

            foreach (DataGridViewRow row in dgv_QLUngVien.Rows)
            {
                var status = row.Cells["TrangThai"].Value?.ToString()?.Trim(); 
                if (status == "Đậu phỏng vấn")
                {
                    row.Cells["IsEmployee"].Value = true; 
                }
                else
                {
                    row.Cells["IsEmployee"].Value = false; 
                }
            }
        }



        //private void setupDataGridView()
        //{
        //    //// Tạo cột chứa đường dẫn file (DuongDan)
        //    //DataGridViewTextBoxColumn duongDanColumn = new DataGridViewTextBoxColumn();
        //    //duongDanColumn.Name = "DuongDan";
        //    //duongDanColumn.HeaderText = "Đường Dẫn CV";
        //    //dgv_QLUngVien.Columns.Add(duongDanColumn);

        //    //// Cột chứa byte array (FileData), có thể ẩn nếu không cần hiển thị
        //    //DataGridViewTextBoxColumn fileDataColumn = new DataGridViewTextBoxColumn();
        //    //fileDataColumn.Name = "FileData";
        //    //fileDataColumn.HeaderText = "File CV";
        //    //fileDataColumn.Visible = false; // Ẩn cột này
        //    //dgv_QLUngVien.Columns.Add(fileDataColumn);

        //    // Cột hiển thị tên file (hoặc đường dẫn file)
        //    //DataGridViewTextBoxColumn fileNameColumn = new DataGridViewTextBoxColumn();
        //    //fileNameColumn.Name = "FileName";
        //    //fileNameColumn.HeaderText = "Tên File CV";
        //    //dgv_QLUngVien.Columns.Add(fileNameColumn);
        //}

        private void frmQLUngVien_Load(object sender, EventArgs e)
        {
            loadUngVien();
            loadViTri();
            //setupDataGridView();
            disable();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
        }



        public void loadViTri()
        {
            cb_ViTriUT.DataSource = tdbll.getAllTuyenDung();
            cb_ViTriUT.ValueMember = "MaUT";
            cb_ViTriUT.DisplayMember = "TenViTri";
        }

        private void dgv_QLUngVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_QLUngVien.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dgv_QLUngVien.SelectedRows[0];
                txt_HoTenUV.Text = selected.Cells["HoTen"].Value.ToString();
                txt_EmailUV.Text = selected.Cells["Email"].Value.ToString();
                txt_SDTUV.Text = selected.Cells["DienThoai"].Value.ToString();
                dtp_NgayUT.Value = Convert.ToDateTime(selected.Cells["NgayUngTuyen"].Value);
                cb_TrangThai.SelectedItem = selected.Cells["TrangThai"].Value.ToString();
                cb_ViTriUT.SelectedValue = Convert.ToInt32(selected.Cells["MaUT"].Value);
                lbl_FilePath.Text = selected.Cells["DuongDanCV"].Value?.ToString();
            }
        }
        public void disable()
        {
            txt_HoTenUV.Enabled = txt_EmailUV.Enabled = txt_SDTUV.Enabled = cb_TrangThai.Enabled =
                cb_ViTriUT.Enabled = dtp_NgayUT.Enabled = lbl_FilePath.Enabled= btn_UploadFileCV.Enabled = false;
        }

        public void resetText()
        {
            txt_HoTenUV.ResetText();
            txt_EmailUV.ResetText();
            txt_SDTUV.ResetText();
            dtp_NgayUT.Value = DateTime.Now;
            lbl_FilePath.ResetText();
        }

        private void btn_UploadFileCV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files|*.pdf|Word Documents|*.docx|All Files|*.*";
            openFileDialog.Title = "Select a File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                lbl_FilePath.Text = filePath;

                if (dgv_QLUngVien.SelectedRows.Count > 0)
                {
                    DataGridViewRow selected = dgv_QLUngVien.SelectedRows[0];
                    selected.Cells["DuongDanCV"].Value = filePath;
                }
            }
        }

        private void dgv_QLUngVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_QLUngVien.Columns["DuongDanCV"].Index)
            {
                string filePath = dgv_QLUngVien.Rows[e.RowIndex].Cells["DuongDanCV"].Value?.ToString();

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

        public void enable()
        {
             txt_HoTenUV.Enabled = txt_EmailUV.Enabled = txt_SDTUV.Enabled = cb_TrangThai.Enabled =
                cb_ViTriUT.Enabled = dtp_NgayUT.Enabled = lbl_FilePath.Enabled = btn_UploadFileCV.Enabled =true;
        }

        private void btn_XuatFile_Click(object sender, EventArgs e)
        {
            try
            {

                var filteredData = uvbll.getAllUngVien()
                                        .Where(u => u.TrangThai.Equals("Đậu phỏng vấn", StringComparison.OrdinalIgnoreCase))
                                        .ToList();

                if (filteredData.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Danh sách ứng viên 'Đậu phỏng vấn':");

                    foreach (var uv in filteredData)
                    {
                        sb.AppendLine($"- {uv.HoTen} - {uv.Email} - {uv.DienThoai} - {uv.NgayUngTuyen.ToString("dd/MM/yyyy")}");
                    }
                    MessageBox.Show(sb.ToString(), "Thông tin ứng viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không có ứng viên nào 'Đậu phỏng vấn'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (filteredData.Count == 0)
                {
                    MessageBox.Show("Không có ứng viên nào có trạng thái 'Đậu phỏng vấn'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using (var package = new ExcelPackage())
                {

                    var worksheet = package.Workbook.Worksheets.Add("UngVien");


                    worksheet.Cells[1, 1].Value = "Mã Ứng Viên";
                    worksheet.Cells[1, 2].Value = "Họ Tên";
                    worksheet.Cells[1, 3].Value = "Email";
                    worksheet.Cells[1, 4].Value = "Số Điện Thoại";
                    worksheet.Cells[1, 5].Value = "Đường Dẫn CV";
                    worksheet.Cells[1, 6].Value = "Ngày Ứng Tuyển";
                    worksheet.Cells[1, 7].Value = "Vị Trí Ứng Tuyển";
                    worksheet.Cells[1, 8].Value = "Trạng Thái";

                    int row = 2;
                    foreach (var uv in filteredData)
                    {
                        // Điền thông tin ứng viên vào các cột tương ứng
                        worksheet.Cells[row, 1].Value = uv.MaUngVien;
                        worksheet.Cells[row, 2].Value = uv.HoTen;
                        worksheet.Cells[row, 3].Value = uv.Email;
                        worksheet.Cells[row, 4].Value = uv.DienThoai;
                        worksheet.Cells[row, 6].Value = uv.NgayUngTuyen.ToString("dd/MM/yyyy");
                        worksheet.Cells[row, 7].Value = tdbll.GetViTriById(uv.MaUT)?.TenViTri;
                        worksheet.Cells[row, 8].Value = uv.TrangThai;

                        string cvFilePath = uv.DuongDanCV;
                        if (!string.IsNullOrEmpty(cvFilePath))
                        {
                            worksheet.Cells[row, 5].Hyperlink = new Uri(cvFilePath);
                            worksheet.Cells[row, 5].Value = "Mở File CV"; 
                            worksheet.Cells[row, 5].Style.Font.UnderLine = true;
                            worksheet.Cells[row, 5].Style.Font.Color.SetColor(Color.Blue);
                        }

                        row++;
                    }

                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    // Lưu file Excel
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Lưu File Excel";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        FileInfo fi = new FileInfo(saveFileDialog.FileName);
                        package.SaveAs(fi);
                        MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

                }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void validateForm()
        {
            if (string.IsNullOrWhiteSpace(txt_HoTenUV.Text))
            {
                MessageBox.Show("Họ tên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (string.IsNullOrWhiteSpace(txt_EmailUV.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txt_EmailUV.Text, emailPattern))
            {
                MessageBox.Show("Email không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_SDTUV.Text) || !txt_SDTUV.Text.All(char.IsDigit) || txt_SDTUV.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải là 10 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtp_NgayUT.Value < DateTime.Now.Date)
            {
                MessageBox.Show("Ngày ứng tuyển không được sớm hơn ngày hiện tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cb_TrangThai.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn trạng thái.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }


        private void menu_QLUngVien_ButtonClicked(object sender, DynamicControl.menucontrol2.ButtonType buttonType, EventArgs e)
        {



            switch (buttonType)
            {
                case DynamicControl.menucontrol2.ButtonType.Add:
                    them = true;
                    resetText();
                    enable();
                    break;

                case DynamicControl.menucontrol2.ButtonType.Edit:
                    if (dgv_QLUngVien.SelectedRows.Count > 0)
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

                case DynamicControl.menucontrol2.ButtonType.Save:
                    int maUT = Convert.ToInt32(cb_ViTriUT.SelectedValue);

                    // Validate data before saving
                    var newUngVien = new UngVienDTO
                    {
                        MaUngVien = sua ? Convert.ToInt32(dgv_QLUngVien.SelectedRows[0].Cells["MaUngVien"].Value) : 0,
                        MaUT = maUT,
                        HoTen = txt_HoTenUV.Text,
                        Email = txt_EmailUV.Text,
                        DienThoai = txt_SDTUV.Text,
                        NgayUngTuyen = dtp_NgayUT.Value,
                        TrangThai = cb_TrangThai.SelectedItem.ToString(),
                    };

                    if (!string.IsNullOrEmpty(lbl_FilePath.Text))
                    {
                        newUngVien.DuongDanCV = lbl_FilePath.Text;
                    }

                    // Validate form fields
                    if (string.IsNullOrWhiteSpace(txt_HoTenUV.Text))
                    {
                        MessageBox.Show("Họ tên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                    if (string.IsNullOrWhiteSpace(txt_EmailUV.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txt_EmailUV.Text, emailPattern))
                    {
                        MessageBox.Show("Email không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(txt_SDTUV.Text) || !txt_SDTUV.Text.All(char.IsDigit) || txt_SDTUV.Text.Length != 10)
                    {
                        MessageBox.Show("Số điện thoại phải là 10 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (dtp_NgayUT.Value < DateTime.Now.Date)
                    {
                        MessageBox.Show("Ngày ứng tuyển không được sớm hơn ngày hiện tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (cb_TrangThai.SelectedItem == null)
                    {
                        MessageBox.Show("Vui lòng chọn trạng thái.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (them)
                    {
                        uvbll.AddUngVien(newUngVien);
                        loadUngVien();
                        disable();
                    }
                    else if (sua)
                    {
                        bool isUpdated = uvbll.UpdateUngVien(newUngVien);
                        if (isUpdated)
                        {
                            MessageBox.Show("Cập nhật thành công!", "Thông báo");
                            loadUngVien();
                            sua = false;
                            disable();
                            menu_QLUngVien.SetStatus(DynamicControl.menucontrol2.Status.View);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (tim == true)
                    {
                        string loc_TrangThai = cb_TrangThai.SelectedItem?.ToString();

                        var filteredData = uvbll.getAllUngVien();
                        if (!string.IsNullOrEmpty(loc_TrangThai))
                        {
                            filteredData = filteredData.Where(hd => hd.TrangThai.Equals(loc_TrangThai, StringComparison.OrdinalIgnoreCase)).ToList();
                        }
                        int recordCount = filteredData.Count;
                        MessageBox.Show($"Tìm thấy {recordCount} bản ghi tương ứng.", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgv_QLUngVien.DataSource = filteredData;
                    }
                    break;

                case DynamicControl.menucontrol2.ButtonType.Cancel:
                    break;

                case DynamicControl.menucontrol2.ButtonType.Loc:
                    tim = true; cb_TrangThai.Enabled = true;
                    break;

                case DynamicControl.menucontrol2.ButtonType.Reload:
                    loadUngVien();
                    disable();
                    break;

                case DynamicControl.menucontrol2.ButtonType.Exit:
                    Application.Exit();
                    break;
            }
        }
    }
}
