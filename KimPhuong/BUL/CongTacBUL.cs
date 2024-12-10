using KimPhuong.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KimPhuong.DAL;

namespace KimPhuong.BUL
{
    public class CongTacBUL
    {
        CongTacDAO ctdal = new CongTacDAO();
        public List<CongTacDTO> GetAll()
        {
            return ctdal.GetAll();
        }
        public bool AddCongTac(CongTacDTO congTac)
        {
            // Bạn có thể kiểm tra logic nghiệp vụ trước khi thêm dữ liệu
            if (string.IsNullOrEmpty(congTac.DiaDiem) || string.IsNullOrEmpty(congTac.MucDich))
            {
                throw new Exception("Địa điểm và mục đích không được để trống.");
            }

            return ctdal.InsertCongTac(congTac);
        }
        //cập nhật
        public bool UpdateCongTac(CongTacDTO congTac)
        {
            try
            {
                return ctdal.UpdateCongTac(congTac);
            }
            catch (Exception ex)
            {
                throw new Exception($"BLL: Lỗi khi cập nhật công tác: {ex.Message}");
            }
        }

        //xóa
        public bool DeleteCongTac(int maCT)
        {
            try
            {
                return ctdal.DeleteCongTac(maCT);
            }
            catch (Exception ex)
            {
                throw new Exception($"BLL: Lỗi khi xóa công tác: {ex.Message}");
            }
        }

        //lọc
        public List<CongTacDTO> FilterCongTac(DateTime? startDate, DateTime? endDate, string employeeName)
        {
            try
            {
                return ctdal.FilterCongTac(startDate, endDate, employeeName);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lọc công tác: {ex.Message}");
            }
        }

    }
}
