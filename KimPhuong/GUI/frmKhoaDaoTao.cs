using KimPhuong.BUL;
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
    public partial class frmKhoaDaoTao : UIPage
    {
        KhoaDaoTaoBUS khoaDaoTaoBUS;
        public frmKhoaDaoTao()
        {
            InitializeComponent();
            khoaDaoTaoBUS = new KhoaDaoTaoBUS();
            loadKhoaDaoTao();
        }
        private void loadKhoaDaoTao()
        {
            var khoa = khoaDaoTaoBUS.GetAll();

            dgvKhoaDaoTao.DataSource = khoa;
        }
    }
}
