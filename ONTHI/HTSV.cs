using System;

namespace ONTHI
{
    public class HTSV
    {
        public int MaSV { get;  set; }
        public string TenSV { get;  set; }
        public string GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string DiaChi { get;  set; }
        public string Sdt { get; set; }
        public string TenLop { get;  set; }
        public string MaLop { get; internal set; }
    }
}