using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_GiaiDoan1.Data
{
    public class DichVu
    {
        public int ID { get; set; }
        public string TenDV { get; set; }
        public decimal DonGia { get; set; }
        public string DonViTinh { get; set; }

        public virtual ObservableCollectionListSource<ChiTietHoaDon> ChiTietHoaDon { get; } = new();
    }
}
