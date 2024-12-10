using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimPhuong.DTO
{
    public class ThamGiaKhoaDaoTaoDTO
    {

        private int maKhoaDaoTao;
        private DateTime ngayThamGia;
        private string chungChi;
        private int maNV;
        private string hoTen;
        private string tenKhoaHoc;
        private string ketQua;

        public ThamGiaKhoaDaoTaoDTO() { }
        public ThamGiaKhoaDaoTaoDTO(int maNV, string hoTen, int maKhoaDaoTao, string tenKhoaHoc, DateTime ngayThamGia,   string ketQua, string chungChi)
        {
            MaNV = maNV;
            HoTen = hoTen;
            MaKhoaDaoTao = maKhoaDaoTao;
            TenKhoaHoc = tenKhoaHoc;
            NgayThamGia = ngayThamGia;
            KetQua = ketQua;
            ChungChi = chungChi;
        }

        public int MaNV { get => maNV; set => maNV = value; }
        public int MaKhoaDaoTao { get => maKhoaDaoTao; set => maKhoaDaoTao = value; }
        public DateTime NgayThamGia { get => ngayThamGia; set => ngayThamGia = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string TenKhoaHoc { get => tenKhoaHoc; set => tenKhoaHoc = value; }
        public string KetQua { get => ketQua; set => ketQua = value; }
        public string ChungChi { get => chungChi; set => chungChi = value; }
    }
}
