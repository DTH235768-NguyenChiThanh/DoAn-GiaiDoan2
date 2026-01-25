using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_GiaiDoan1.Data
{
    public class Phong
    {
        public int ID {  get; set; }
        public string TenPhong { get; set; }
        public string LoaiPhong { get; set; }
        public decimal GiaGio { get; set; }
        public string TrangThai { get; set; }
        
        public virtual ObservableCollectionListSource<HoaDon> HoaDon { get; } = new();
        public virtual ObservableCollectionListSource<DatPhong> DatPhong { get; } = new();
    }
}
