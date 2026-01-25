using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_GiaiDoan1.Data
{
    public class DatPhong
    {
        public int ID { get; set; }
        public int KHID { get; set; }
        public int PhongID {  get; set; }
        public DateTime TGBatDau { get; set; }
        public DateTime TGKetThuc { get; set; }
        public DateTime NgayDat {  get; set; }
        public string TrangThai { get; set; }

        public virtual KhachHang KhachHang { get; set; } = null!;
        public virtual Phong Phong { get; set; } = null!;
        
    }
}
