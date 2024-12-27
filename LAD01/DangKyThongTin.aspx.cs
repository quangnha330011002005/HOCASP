using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAD01
{
    public partial class DangKyThongTin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                KhoiTao();
            }
        }

        private void KhoiTao()
        {
            //Khởi tạo dữ liệu Trình độ
            ddlTrinhDo.Items.Add( new ListItem("Phổ Thông","1"));
            ddlTrinhDo.Items.Add( new ListItem("Cao Đẳng","02"));
            ddlTrinhDo.Items.Add( new ListItem("Đại Học","03"));
            ddlTrinhDo.Items.Add( new ListItem("Sau Đại Học","04"));

            //khởi tạo dữ liệu Nghề Nghiệp
            lbNgheNghiep.Items.Add(new ListItem("Bác sĩ","01"));
            lbNgheNghiep.Items.Add( new ListItem("Kỹ Sư","02"));
            lbNgheNghiep.Items.Add( new ListItem("Công An","03"));
            lbNgheNghiep.Items.Add(new ListItem("Kiễn Trúc Sư","04"));
            lbNgheNghiep.Items.Add(new ListItem("Công Nhân","05"));

            //Khởi tạo dữ liệu cho clkSoThich
            cklSoThich.Items.Add(new ListItem("Shoping","01"));
            cklSoThich.Items.Add(new ListItem("Du Lịch", "02"));
            cklSoThich.Items.Add(new ListItem("Nghe Nhạc","03"));
            cklSoThich.Items.Add(new ListItem("Chơi Game", "04"));
            cklSoThich.Items.Add(new ListItem("Ngủ", "05"));
        }

        protected void btGui_Click(object sender, EventArgs e)
        {
            //b1.Lấy thông tin từ client
            string kq = "<ul>";
            kq += string.Format("<li> Họ Tên:<b> {0}</b>", txtHoTen.Text);
            kq += string.Format("<li> Ngày Sinh:<b> {0}</b>", txtNgaySinh.Text);
            kq += string.Format("<li> Giới Tính:<b> {0}</b>", (rdNam.Checked?rdNam.Text:rdNu.Text));
            kq += string.Format("<li> Trình Độ:<b> {0}</b>", ddlTrinhDo.SelectedItem.Text);
            kq += string.Format("<li> Nghề Nghiệp:<b> {0}</b>", lbNgheNghiep.SelectedItem.Text);

            //xử lý hình ảnh
            if (FHinh.HasFile){
                string path = Server.MapPath("~/Uploads");
                string filename = FHinh.FileName;
                FHinh.SaveAs(path + "/" + filename);
                kq += string.Format("<li>Ảnh Đại Diện:<img src='/Uploads/{0}' width='200px'>",filename);
            }
            //Lấy thông tin swor thích
            string sothich = "";
            foreach(ListItem item in cklSoThich.Items)
            {
                if (item.Selected)
                {
                    sothich += item.Text + "...";
                }
            }
            kq += string.Format("<li> Sở Thích:<b> {0}</b>", sothich);
            kq += "</ul>";
            //b2.Hồi đáp kết quả
            lbThongTin.Text = kq;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtNgaySinh.Text = "";
            ddlTrinhDo.SelectedIndex = 0;
            lbNgheNghiep.SelectedIndex = -1;
            foreach(ListItem item in cklSoThich.Items)
            {
                item.Selected = false;
            }
            lbThongTin.Text = "";
        }
    }
}