using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ONTHI
{
    public partial class Default : System.Web.UI.Page
    {
        Code cd = new Code();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                hienthi();
            }
        }
        public void hienthi()
        {
            GridView1.DataSource = cd.HTLop();
            GridView1.DataBind();
            GridView2.DataSource = cd.HTSV();
            GridView2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text != "")
            {
                GridView2.DataSource = cd.TKSVT(TextBox1.Text);
                GridView2.DataBind();
            }
            else
            {
                Response.Write("<script> alert ('Nhập thông tin tìm kiếm'); </script> ");
            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {   
            if(TextBox2.Text == "" || TextBox3.Text =="")
            {
                Response.Write("<script> alert ('Vui lòng nhập đầy đủ thông tin!'); </script> ");
            }
            else if(cd.ThemLop(TextBox2.Text, TextBox3.Text))
            { 
            Response.Write("<script> alert ('Thêm lớp thành công'); window.location ='Default.aspx' </script> ");
            }
            else
            {
                Response.Write("<script> alert ('Mã lớp đã tồn tại!'); </script> ");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox4.Text != "")
            {
                GridView1.DataSource = cd.TKL(TextBox4.Text);
                GridView1.DataBind();
            }
            else
            {
                Response.Write("<script> alert ('Nhập thông tin tìm kiếm'); </script> ");
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
           if (TextBox5.Text == "" || TextBox6.Text == "" || TextBox8.Text == "" || TextBox9.Text == "" || TextBox10.Text == "")
            {
                Response.Write("<script> alert ('Vui lòng nhập đầy đủ thông tin!'); </script> ");
            }
            else if (cd.ThemSV(int.Parse(TextBox5.Text), TextBox6.Text,DateTime.Parse(TextBox8.Text), RadioButtonList1.Text, TextBox9.Text, TextBox10.Text, DropDownList1.Text))
            {
                Response.Write("<script> alert ('Thêm sinh viên thành công'); window.location ='Default.aspx' </script> ");
            }
            else
            {
                Response.Write("<script> alert ('Mã sinh viên đã tồn tại!'); </script> ");
            }
        }

        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string a = GridView1.DataKeys[e.RowIndex].Values["MaLop"].ToString();
            if(cd.XoaLop(a))
            {
                Response.Write("<script> alert ('Xóa lớp thành công'); window.location ='Default.aspx' </script> ");
            }
            else
            {
                Response.Write("<script> alert ('Mã lớp đã tồn tại liên kết!'); window.location ='Default.aspx' </script> ");
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (Label1.Text == "" || TextBox3.Text == "")
            {
                Response.Write("<script> alert ('Vui lòng nhập đầy đủ thông tin!'); </script> ");
            }
            else if (cd.SuaLop(Label1.Text, TextBox3.Text))
            {
                Response.Write("<script> alert ('Sửa lớp thành công'); window.location ='Default.aspx' </script> ");
            }
            else
            {
                Response.Write("<script> alert ('Cập nhật thất bại!'); </script> ");
            }
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView2.SelectedRow;
            this.Label3.Text = HttpUtility.HtmlDecode(row.Cells[0].Text);
            this.TextBox6.Text = HttpUtility.HtmlDecode(row.Cells[2].Text);
            this.DropDownList1.SelectedValue = row.Cells[1].Text;
            this.RadioButtonList1.Text = HttpUtility.HtmlDecode(row.Cells[4].Text);
            this.TextBox8.Text = HttpUtility.HtmlDecode(row.Cells[5].Text);
            this.TextBox9.Text = HttpUtility.HtmlDecode(row.Cells[6].Text);
            this.TextBox10.Text = HttpUtility.HtmlDecode(row.Cells[7].Text);
           

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;      
            this.Label1.Text = HttpUtility.HtmlDecode(row.Cells[0].Text);
            this.TextBox3.Text = HttpUtility.HtmlDecode(row.Cells[1].Text);
           
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (Label3.Text == "" || TextBox6.Text == "" || TextBox8.Text == "" || TextBox9.Text == "" || TextBox10.Text == "")
            {
                Response.Write("<script> alert ('Vui lòng nhập đầy đủ thông tin!'); </script> ");
            }
            else if (cd.SuaSV(int.Parse(Label3.Text), TextBox6.Text, DateTime.Parse(TextBox8.Text), RadioButtonList1.Text, TextBox9.Text, TextBox10.Text, DropDownList1.Text))
            {
                Response.Write("<script> alert ('Sửa sinh viên thành công'); window.location ='Default.aspx' </script> ");
            }
            else
            {
                Response.Write("<script> alert ('Mã sinh viên đã tồn tại!'); </script> ");
            }
        }
    }
}