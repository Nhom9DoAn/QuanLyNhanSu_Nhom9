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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace KimPhuong.GUI
{
    public partial class frm_BaoCaoTongKetCongTac : UIPage
    {
        BaoCaoTongKetCongTacBLL bc_bll = new BaoCaoTongKetCongTacBLL();
        public string tennv, phongban;
        public frm_BaoCaoTongKetCongTac()
        {
            InitializeComponent();
        }
        public frm_BaoCaoTongKetCongTac(string tennv, string phongban)
        {
            InitializeComponent();
            this.tennv = tennv;
            this.phongban = phongban;
        }
        private void ExportToPDF(DataGridView dgv, string filePath)
        {
            // Khởi tạo Document và PdfWriter
            Document doc = new Document(PageSize.A4);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            BaseFont baseFont = BaseFont.CreateFont("c:\\Windows\\Fonts\\times.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 12);

            PdfPTable headerTable = new PdfPTable(2);
            headerTable.WidthPercentage = 100;
            headerTable.AddCell(new PdfPCell(new Phrase("CÔNG TY TNHH XYZ", font))
            {
                Border = 0,
                HorizontalAlignment = Element.ALIGN_LEFT,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                PaddingBottom = 10
            });
            headerTable.AddCell(new PdfPCell(new Phrase("CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM\nĐộc lập - Tự do - Hạnh phúc", font))
            {
                Border = 0,
                HorizontalAlignment = Element.ALIGN_CENTER,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                PaddingBottom = 10
            });
            doc.Add(headerTable);
            doc.Add(new Paragraph("\n", font));

            string currentDate = DateTime.Now.ToString("dd 'tháng' MM 'năm' yyyy", new System.Globalization.CultureInfo("vi-VN"));
            string headerText = "TPHCM, ngày " + currentDate;

            Paragraph headerParagraph = new Paragraph(headerText, font)
            {
                Alignment = Element.ALIGN_RIGHT,
                SpacingAfter = 10
            };
            doc.Add(headerParagraph);

            // Tiêu đề báo cáo
            var titleFont = new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD);
            var title = new Paragraph("BÁO CÁO DANH SÁCH TỔNG KÊT NHÂN VIÊN XUẤT SẮC TRONG THÁNG " + dtp_NgayTongKet.Value.Month, titleFont)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingAfter = 20
            };
            doc.Add(title);

            doc.Add(new Paragraph("Người lập báo cáo: " + tennv, font));
            var departmentText = new Paragraph("Bộ phận: " + phongban, font)
            {
                Alignment = Element.ALIGN_LEFT,
                SpacingAfter = 10
            };
            doc.Add(departmentText);
            doc.Add(new Paragraph("\n", font));

            PdfPTable table = new PdfPTable(dgv.Columns.Count - 1)
            {
                WidthPercentage = 100
            };

            float[] columnWidths = new float[dgv.Columns.Count - 1];
            for (int i = 0; i < dgv.Columns.Count - 1; i++)
            {
                columnWidths[i] = 1f;
            }
            table.SetWidths(columnWidths);

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Name != "MaNV")
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font))
                    {
                        BackgroundColor = BaseColor.LIGHT_GRAY,
                        HorizontalAlignment = Element.ALIGN_CENTER,
                        VerticalAlignment = Element.ALIGN_MIDDLE,
                        Padding = 5
                    };
                    table.AddCell(cell);
                }
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.OwningColumn.Name != "MaNV")
                        {
                            table.AddCell(new PdfPCell(new Phrase(cell.Value?.ToString() ?? "", font))
                            {
                                HorizontalAlignment = Element.ALIGN_CENTER,
                                VerticalAlignment = Element.ALIGN_MIDDLE,
                                Padding = 5
                            });
                        }
                    }
                }
            }

            doc.Add(table);
            doc.Add(new Paragraph("\n", font));

            PdfPTable footerTable = new PdfPTable(2)
            {
                WidthPercentage = 100
            };

            footerTable.AddCell(new PdfPCell(new Phrase("Người lập báo cáo\n\n " + tennv, font))
            {
                Border = 0,
                HorizontalAlignment = Element.ALIGN_CENTER,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                PaddingTop = 10
            });

            footerTable.AddCell(new PdfPCell(new Phrase("Người duyệt báo cáo\n\n ", font))
            {
                Border = 0,
                HorizontalAlignment = Element.ALIGN_CENTER,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                PaddingTop = 10
            });

            doc.Add(footerTable);

            var evaluationFont = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.ITALIC);

            var evaluationHeader = new Paragraph("Ghi chú: Đánh giá tổng quan về kết quả công việc của các nhân viên xuất sắc trong tháng:\n", evaluationFont)
            {
                Alignment = Element.ALIGN_LEFT,
                SpacingAfter = 5
            };
            doc.Add(evaluationHeader);
            var evaluationText = new Paragraph("1. Nhân viên xuất sắc đều có thái độ làm việc tích cực, năng suất cao.\n" +
                                               "2. Các thành tích công tác, chuyên môn được ghi nhận rõ ràng.\n" +
                                               "3. Có sự đóng góp đáng kể vào mục tiêu công ty.\n", evaluationFont)
            {
                Alignment = Element.ALIGN_LEFT,
                SpacingAfter = 20
            };
            doc.Add(evaluationText);

            doc.Close();
        }
        private void btn_ExportReportPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PDF file (*.pdf)|*.pdf",
                FileName = "BaoCaoCongTac.pdf"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportToPDF(dgv_BaoCaoTongKetDSNV, sfd.FileName);
                MessageBox.Show("Xuất báo cáo thành công!", "Thông báo");
            }
        }

        private void btn_LocNV_Click(object sender, EventArgs e)
        {
            int thang = dtp_NgayTongKet.Value.Month;
            int nam = dtp_NgayTongKet.Value.Year;
            dgv_BaoCaoTongKetDSNV.DataSource = bc_bll.GetNhanVienXuatSacTheoThang(thang, nam);
            dgv_BaoCaoTongKetDSNV.Columns["HoTen"].HeaderText = "Họ Tên Nhân Viên";
            dgv_BaoCaoTongKetDSNV.Columns["TenPB"].HeaderText = "Phòng Ban Làm Việc";
            dgv_BaoCaoTongKetDSNV.Columns["LuongCB"].HeaderText = "Lương Cơ Bản";
            dgv_BaoCaoTongKetDSNV.Columns["Thuong"].HeaderText = "Thưởng";
            dgv_BaoCaoTongKetDSNV.Columns["SoNgayCong"].HeaderText = "Số Ngày Công";
            dgv_BaoCaoTongKetDSNV.Columns["SoChuyenCongTac"].HeaderText = "Số Chuyến Công Tác";
        }
    }
}
