<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frm_ThemNhanVien.aspx.cs" Inherits="QuanLyNhanSuTienLuong.frm_ThemNhanVien" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 516px;
        }
        .auto-style3 {
            width: 1363px;
        }
        .auto-style5 {
            height: 84px;
        }
        .auto-style6 {
            width: 119px;
        }
        .auto-style7 {
            width: 155px;
        }
        .auto-style8 {
            height: 84px;
            width: 155px;
        }
        .auto-style9 {
            width: 211px;
        }
        .auto-style10 {
            width: 955px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="w3-main" style="margin-left:300px;margin-top:43px;">
          <header class="w3-container" style="padding-top:22px">
        <table class="auto-style3">
            <tr>
                <td>
                    <h3><b>Thêm Nhân Viên KLAND</b></h3>
                    <p>
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </p>
                </td>
                <td class="auto-style1"></td>
                
            </tr>
            <tr>
                <asp:Label ID="lbl_tb" runat="server" Text=""></asp:Label></tr>
        </table>
  </header>
        <div class="w3-panel">
            <table class="auto-style10">
                <%--<tr>
                    <td class="auto-style7"><h4>Mã nhân viên:</h4></td>
                    <td>

                        <asp:TextBox ID="txt_manv" runat="server" Width="547px"></asp:TextBox>

                    &nbsp;</td>
                    <td>

                    </td>
                </tr>--%>
                <tr>
                    <td class="auto-style7">
                        <h4>Họ tên:</h4>
                    </td>
                    <td>

                        <asp:TextBox ID="txt_hoten" runat="server" Width="547px"></asp:TextBox>
                        
                    </td>
                    <td class="auto-style9" >

                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ErrorMessage="Nhập tên nhân viên" ForeColor="Red" 
                    ControlToValidate="txt_hoten"></asp:RequiredFieldValidator></td>
                    
                </tr>
                <tr>
                    <td class="auto-style7">
                        <h4 class="auto-style6">Năm sinh:                 </td>
                    <td>

                        <asp:TextBox ID="txt_namsinh" runat="server" Width="176px"></asp:TextBox>

                    </td>
                    <td class="auto-style9">

                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <h4>Giới tính:</h4>
                    </td>
                    <td class="auto-style5">

                        <asp:DropDownList ID="ddl_gioitinh" runat="server">
                            <asp:ListItem>Nam</asp:ListItem>
                            <asp:ListItem>Nữ</asp:ListItem>
                        </asp:DropDownList>

                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <h4>Địa chỉ:</h4>
                    </td>
                    <td>

                        <asp:TextBox ID="txt_diachi" runat="server" Width="547px"></asp:TextBox>

                    </td>
                    <td class="auto-style9">

                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ErrorMessage="Nhập địa chỉ" ForeColor="Red" 
                    ControlToValidate="txt_diachi"></asp:RequiredFieldValidator>

                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <h4>Số CMND:</h4>
                    </td>
                    <td>

                        <asp:TextBox ID="txt_cmnd" runat="server" Width="547px"></asp:TextBox>

                    </td>
                    <td class="auto-style9">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ErrorMessage="Nhập số chứng minh nhân dân" ForeColor="Red" 
                    ControlToValidate="txt_cmnd"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <h4>Số điện thoại:</h4>
                    </td>
                    <td>

                        <asp:TextBox ID="txt_sdt" runat="server" Width="547px"></asp:TextBox>

                    </td>
                    <td class="auto-style9">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ErrorMessage="Nhập số điện thoại" ForeColor="Red" 
                    ControlToValidate="txt_sdt"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <h4>Email:</h4>
                    </td>
                    <td>

                        <asp:TextBox ID="txt_email" runat="server" Width="547px"></asp:TextBox>

                    </td>
                    <td class="auto-style9">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                    ErrorMessage="Nhập Email" ForeColor="Red" 
                    ControlToValidate="txt_email"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <h4>Phòng ban:                </h4> </td>
                    <td>

                        <asp:DropDownList ID="ddl_phongban" runat="server" Width="263px">
                            <asp:ListItem>Khu vực Dragon</asp:ListItem>
                            <asp:ListItem>Khu vực Thunder</asp:ListItem>
                            <asp:ListItem>Khu vực Rainbow</asp:ListItem>
                            <asp:ListItem>Khu vực Sunshine</asp:ListItem>
                            <asp:ListItem>Khu vực Tornado</asp:ListItem>
                            <asp:ListItem>Khu vực Hydra</asp:ListItem>
                            <asp:ListItem>Khu vực Poseidon</asp:ListItem>
                            <asp:ListItem>Nhóm Arrow</asp:ListItem>
                            <asp:ListItem>Nhóm ME-Dự án</asp:ListItem>
                            <asp:ListItem>Phòng hành chính</asp:ListItem>
                            <asp:ListItem>Phòng ban tổng</asp:ListItem>
                            <asp:ListItem>Phòng kế toán</asp:ListItem>
                        </asp:DropDownList>

                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <h4>Chức vụ:</h4>
                    </td>
                    <td>

                        <asp:DropDownList ID="ddl_chucvu" runat="server" Width="263px">
                            <asp:ListItem>Nhân Viên</asp:ListItem>
                            <asp:ListItem>Quản Lý Bán Hàng</asp:ListItem>
                            <asp:ListItem>Quản lý nhân viên</asp:ListItem>
                            <asp:ListItem>Giám Đốc</asp:ListItem>
                            <asp:ListItem>Kế Toán</asp:ListItem>
                        </asp:DropDownList>

                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">                        <asp:LinkButton ID="lbtn_quaylai" runat="server" ForeColor="Blue"><h4>&lt;&lt;Quay lại</h4></asp:LinkButton></td>
                    <td>


                        <asp:Button ID="btn_luu" runat="server" Text="Lưu" Width="112px" OnClick="btn_luu_Click" />

                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
