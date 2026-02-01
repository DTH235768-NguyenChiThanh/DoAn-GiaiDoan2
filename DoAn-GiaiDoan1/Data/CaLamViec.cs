using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_GiaiDoan1.Data
{
    public class CaLamViec
    {
        public int ID { get; set; }
        public string TenCa { get; set; }
        public DateTime GioBatDau { get; set; }
        public DateTime GioKetThuc { get; set; }
        public virtual ObservableCollectionListSource<PhanCong> PhanCong { get; } = new();
    }
}
