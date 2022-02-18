using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ONTHI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICode" in both code and config file together.
    [ServiceContract]
    public interface ICode
    {
        // hiển thị dữ liệu của một bảng
        [OperationContract]
        List<Lop> HTLop();
        // hiển thị từng thuộc tính của một bảng
        [OperationContract]
        List<HTLop> HTLop1();
        // Hiển thị sinh viên
        [OperationContract]
        List<HTSV> HTSV();

        // tìm kiếm sinh viên
        [OperationContract]
        List<TKSV> TKSV( int MaSV);

        // tìm kiếm lớp
        [OperationContract]
        List<TKL> TKL(string TenLop);
        // thêm lớp
        [OperationContract]
        bool ThemLop( string MaLop, string TenLop);
        // thêm sinh viên
        [OperationContract]
        bool ThemSV(int MaSV, string TenSV,DateTime NgaySinh, string GioiTinh, string DiaChi, string Sdt, string MaLop);
        // tìm kiếm sinh viên theo tên
        [OperationContract]
        List<TKSVT> TKSVT( string TenSV);
        // Xóa lớp
        [OperationContract]
        bool XoaLop( string MaLop);
        // sửa lớp
        [OperationContract]
        bool SuaLop ( string MaLop, string TenLop);
        // sửa sinh viên
        [OperationContract]
        bool SuaSV(int MaSV, string TenSV, DateTime NgaySinh, string GioiTinh, string DiaChi, string Sdt, string MaLop);
    }
}
