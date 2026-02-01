using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_GiaiDoan1.Data
{
    public class ThanhToan
    {
        public int ID { get; set; }
        public int HDID { get; set; }
        public string HinhThuc { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public virtual HoaDon HoaDon { get; set; } = null!;
    }
}
