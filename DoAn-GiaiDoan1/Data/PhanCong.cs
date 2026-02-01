using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_GiaiDoan1.Data
{
    public class PhanCong
    {
        public int ID { get; set; }
        public int NVID { get; set; }
        public int CaLamViecID { get; set; }
        public DateTime NgayLam { get; set; }
        public virtual CaLamViec CaLamViec { get; set; } = null!;
        public virtual NhanVien NhanVien { get; set; } = null!;

    }
}
