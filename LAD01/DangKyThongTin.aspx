<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangKyThongTin.aspx.cs" Inherits="LAD01.DangKyThongTin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            margin-left: 40px;
        }
        .auto-style3 {
            height: 41px;
            text-align: center;
            background-color: #00CCFF;
        }
        .auto-style4 {
            text-align: center;
            background-color: #99FF33;
            height: 27px;
        }
        .auto-style5 {
            font-size: 12pt;
        }
        .auto-style6 {
            height: 90px;
        }
    </style>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table cellpadding="4" cellspacing="0" class="auto-style1">
                <tr>
                    <td class="auto-style3" colspan="2"><strong>ĐĂNG KÝ THÔNG TIN&nbsp;</strong></td>
                </tr>
                <tr>
                    <td class="auto-style2">Họ Tên</td>
                    <td>
                        <asp:TextBox ID="txtHoTen" runat="server" required="true"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Ngày Sinh</td>
                    <td>
                        <asp:TextBox ID="txtNgaySinh" placeholder="dd/mm/yyyy" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Giới Tính</td>
                    <td>
                        <asp:RadioButton ID="rdNam" runat="server" Text="Nam" GroupName="GT" />
                        <asp:RadioButton ID="rdNu" runat="server" Text="Nữ" GroupName="GT" />
                    </td>
                </tr>
                <tr>
                    <td>Trình Độ</td>
                    <td>
                        <asp:DropDownList ID="ddlTrinhDo" runat="server" required="true">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Nghề Nghiệp</td>
                    <td class="auto-style6">
                        <asp:ListBox ID="lbNgheNghiep" runat="server" Width="87px" required="true"></asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td>Hình</td>
                    <td class="auto-style5">
                        <asp:FileUpload ID="FHinh" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>Sở Thích</td>
                    <td>
                        <asp:CheckBoxList ID="cklSoThich" runat="server">
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btGui" runat="server" Text="Gửi" OnClick="btGui_Click" />
&nbsp;
                        <asp:Button ID="btreset" runat="server" Text="Làm Lại" OnClick="Button2_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="2"><strong>KẾT QUẢ ĐĂNG KÝ</strong></td>
                </tr>
                <tr>
                    <td id="lbThongTin">
                        <asp:Label ID="lbThongTin" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
