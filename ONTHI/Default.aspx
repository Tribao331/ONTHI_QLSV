<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ONTHI.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
        }
        .auto-style4 {
            height: 29px;
        }
        .auto-style5 {
            text-align: center;
        }
        .auto-style6 {
            width: 464px;
            text-align: center;
        }
        .auto-style7 {
            text-align: right;
        }
        .auto-style8 {
            width: 464px;
            height: 194px;
            text-align: center;
        }
        .auto-style9 {
            height: 194px;
        }
        .auto-style10 {
            height: 26px;
            text-align: right;
        }
        .auto-style11 {
            height: 29px;
            text-align: right;
            width: 194px;
        }
        .auto-style12 {
            text-align: right;
            width: 184px;
            height: 32px;
        }
        .auto-style13 {
            height: 29px;
            text-align: right;
            width: 194px;
        }
        .auto-style14 {
            text-align: right;
            width: 194px;
        }
        .auto-style15 {
            height: 26px;
            width: 194px;
        }
        .auto-style16 {
            height: 32px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style8">
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style7">
            <asp:TextBox ID="TextBox4"   placeholder ="Nhập thông tin cần tìm" title ="" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Button ID="Button3" runat="server" Height="28px" Text="Tìm" Width="51px" OnClick="Button3_Click" />
                            </td>
                        </tr>
                    </table>
                    <br />
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style12">
                                <asp:Label ID="Label1" runat="server" Text="Mã lớp"></asp:Label>
                                <br />
                            </td>
                            <td class="auto-style16">
            <asp:TextBox ID="TextBox2" placeholder ="Nhập mã lớp" title ="Mã lớp bao gồm chữ và số tối đa 10 ký tự" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style13">
                                <asp:Label ID="Label2" runat="server" Text="Tên lớp"></asp:Label>
                            </td>
                            <td class="auto-style4">
            <asp:TextBox ID="TextBox3" placeholder ="Nhập tên lớp"  title ="Tên lớp bao gồm chữ và số tối đa 50 ký tự" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                    <table class="auto-style1">
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td class="auto-style7">&nbsp;</td>
                        </tr>
                    </table>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Thêm" />
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Sửa" />
                    <br />
                </td>
                <td class="auto-style9">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" CssClass="auto-style2" DataKeyNames="MaLop" OnRowDeleting="GridView1_RowDeleting" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="MaLop" HeaderText="Mã lớp" />
                            <asp:BoundField DataField="TenLop" HeaderText="Tên lớp" />
                            <asp:CommandField DeleteText="Xóa" ShowDeleteButton="True" />
                            <asp:CommandField SelectText="Chọn" ShowSelectButton="True" />
                        </Columns>
                        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FFF1D4" />
                        <SortedAscendingHeaderStyle BackColor="#B95C30" />
                        <SortedDescendingCellStyle BackColor="#F1E5CE" />
                        <SortedDescendingHeaderStyle BackColor="#93451F" />
                    </asp:GridView>
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style7">
            <asp:TextBox ID="TextBox1"  placeholder ="Nhập thông tin cần tìm" title ="Mã sinh viên bao gồm số tối đa 9 ký tự" runat="server"></asp:TextBox>
                            </td>
                            <td>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Tìm" Height="24px" Width="52px" />
                            </td>
                        </tr>
                    </table>
                    <br />
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style11">
                                <asp:Label ID="Label3" runat="server" Text="Mã số sinh viên"></asp:Label>
                                </td>
                            <td class="auto-style4">
            <asp:TextBox ID="TextBox5" pattern="[Z0-9]{1,9}"  placeholder ="Nhập mã số sinh viên" title ="Mã sinh viên bao gồm số tối đa 9 ký tự" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style14">
                                <asp:Label ID="Label4" runat="server" Text="Họ tên"></asp:Label>
                            </td>
                            <td>
            <asp:TextBox ID="TextBox6"   placeholder ="Nhập họ tên" title ="Mã sinh viên bao gồm số tối đa 9 ký tự" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style14">
                                <asp:Label ID="Label5" runat="server" Text="Lớp"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="TenLop" DataValueField="MaLop" Width="170px" AutoPostBack="True">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QL_SVConnectionString %>" SelectCommand="SELECT * FROM [Lop]"></asp:SqlDataSource>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style14">
                                <asp:Label ID="Label6" runat="server" Text="Giới tính"></asp:Label>
                            </td>
                            <td>
                                <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="165px" AutoPostBack="True">
                                    <asp:ListItem>Nam</asp:ListItem>
                                    <asp:ListItem>Nữ</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style11">
                                <asp:Label ID="Label9" runat="server" Text="Ngày sinh"></asp:Label>
                            </td>
                            <td class="auto-style4">
            <asp:TextBox ID="TextBox8"   placeholder ="Nhập ngày sinh" title ="Mã sinh viên bao gồm số tối đa 9 ký tự" runat="server" Width="166px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style14">
                                <asp:Label ID="Label7" runat="server" Text="Địa chỉ"></asp:Label>
                            </td>
                            <td>
            <asp:TextBox ID="TextBox9"   placeholder ="Nhập địa chỉ" title ="Mã sinh viên bao gồm số tối đa 9 ký tự" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style14">
                                <asp:Label ID="Label8" runat="server" Text="Số điện thoại"></asp:Label>
                            </td>
                            <td>
            <asp:TextBox ID="TextBox10"  placeholder ="Nhập số điện thoại" title ="Mã sinh viên bao gồm số tối đa 9 ký tự" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style15">
                                &nbsp;</td>
                            <td class="auto-style10">&nbsp;</td>
                        </tr>
                    </table>
                                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Thêm" />
                    <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Sửa" />
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:QL_SVConnectionString %>" SelectCommand="SELECT * FROM [Lop]"></asp:SqlDataSource>
                </td>
                <td class="auto-style2">
                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" CssClass="auto-style3" OnRowDeleting="GridView2_RowDeleting" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="MaSV" HeaderText="Mã số sinh viên" />
                            <asp:BoundField DataField="MaLop" HeaderText="Mã Lớp" />
                            <asp:BoundField DataField="TenSV" HeaderText="Họ tên" />
                            <asp:BoundField DataField="TenLop" HeaderText="Lớp" />
                            <asp:BoundField DataField="GioiTinh" HeaderText="Giới tính" />
                            <asp:BoundField DataField="NgaySinh" DataFormatString="{0:MM/dd/yyyy}" HeaderText="Ngày sinh" />
                            <asp:BoundField DataField="DiaChi" HeaderText="Địa chỉ" />
                            <asp:BoundField DataField="Sdt" HeaderText="Số điện thoại" />
                            <asp:CommandField DeleteText="Xóa" ShowDeleteButton="True" />
                            <asp:CommandField ShowSelectButton="True" SelectText="Chọn" />
                        </Columns>
                        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FFF1D4" />
                        <SortedAscendingHeaderStyle BackColor="#B95C30" />
                        <SortedDescendingCellStyle BackColor="#F1E5CE" />
                        <SortedDescendingHeaderStyle BackColor="#93451F" />
                    </asp:GridView>
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
