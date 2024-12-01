using KimPhuong.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimPhuong.BUL
{
    public class KhoaDaoTaoBUS
    {
        KhoaDaoTaoDAO khoaDaoTaoDAO;
        public KhoaDaoTaoBUS()
        {
            khoaDaoTaoDAO = new KhoaDaoTaoDAO();
        }
        public List<dynamic> GetAll()
        {
            return khoaDaoTaoDAO.GetAll();
        }
        public bool Insert(string tenkh, string donvi,
            DateTime ngaybd, DateTime ngaykt,
            int chiPhi, string ghiChu)
        {
            return khoaDaoTaoDAO.Insert(tenkh, donvi, ngaybd, ngaykt, chiPhi, ghiChu);
        }
        public bool Update(int maKDT, string tenkh, string donvi,
           DateTime ngaybd, DateTime ngaykt,
           int chiPhi, string ghiChu)
        {
            return khoaDaoTaoDAO.Update(maKDT, tenkh, donvi, ngaybd,ngaykt, chiPhi, ghiChu);
        }
        public bool Delete(int maKDT)
        {
            return khoaDaoTaoDAO.Delete(maKDT);
        }
        public List<dynamic> Search(string keyword)
        {
            return khoaDaoTaoDAO.Search(keyword);
        }
    }
}
