using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_GiaiDoan1.Data
{
    public class KhachHang
    {
        public int ID { get; set; }
        public string TenKH { get; set; }
        public string SDT { get; set; }

        public virtual ObservableCollectionListSource<HoaDon> HoaDon { get; } = new();
        public virtual ObservableCollectionListSource<DatPhong> DatPhong { get; } = new();
    }
}
