<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ThongTinCTNV.aspx.cs" Inherits="QuanLyNhanSuTienLuong.ThongTinCTNV" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 516px;
        }
        .auto-style3 {
            width: 1363px;
        }
        .auto-style10 {
            width: 955px;
        }
        .auto-style11 {
            width: 457px;
        }
        .auto-style12 {
            width: 330px;
        }
        .auto-style13 {
            width: 210px;
        }
    .auto-style14 {
        width: 200px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="w3-main" style="margin-left:300px;margin-top:43px;">
          <header class="w3-container" style="padding-top:22px">
        <table class="auto-style3">
            <tr>
                <td>
                    <h3><b>Thông tin chi tiết nhân viên <asp:Label ID="lbl_ma" runat="server"></asp:Label></b></h3>
                </td>
                <td class="auto-style1"></td>
                
            </tr>
            <tr>
                <asp:Label ID="lbl_tb" runat="server" Text=""></asp:Label></tr>
        </table>
  </header>
        <div class="w3-panel">
            <table class="auto-style10" Width="100%">
                <tr>
                    <td class="auto-style12">
                        <h5>Họ tên:</h5><br />
                        <h5>Giới tính:</h5>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txt_hoten" runat="server" Width="328px" ReadOnly="true"></asp:TextBox>
                        <br />
                        <br />
                        <br />
                        <asp:TextBox ID="txt_gt" runat="server" Width="328px" ReadOnly="true"></asp:TextBox>
                    </td>
                    <td class="auto-style13">
                        
                    </td>
                    <td>
                        <asp:Image ID="img_anh" runat="server" Height="163px" Width="150px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <h5>&nbsp;</h5>
                    </td>
                    <td class="auto-style11">
                        &nbsp;</td>
                    <td class="auto-style13">
                        
                    </td>
                    <td> 
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <h5>Năm Sinh:</h5>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txt_namsinh" runat="server" Width="328px" ReadOnly="true"></asp:TextBox>
                    </td>
                    <td class="auto-style13">
                        <h5>Số CMND:</h5>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txt_cmnd" runat="server" Width="328px" ReadOnly="true"></asp:TextBox>
                    </td>
                 </tr>
                <tr>
                    <td class="auto-style12">
                        <h5>Địa chỉ:</h5>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txt_diachi" runat="server" Width="328px" ReadOnly="true"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    
                    <td class="auto-style12">
                        
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <h5>Số điện thoại:</h5>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txt_sdt" runat="server" Width="328px" ReadOnly="true"></asp:TextBox>
                    </td>
                    <td class="auto-style13">
                        <h5>Mail:</h5>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txt_mail" runat="server" Width="328px" ReadOnly="true"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    
                    <td class="auto-style12">
                        
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <h5>Phòng ban:</h5>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txt_pb" runat="server" Width="328px" ReadOnly="true"></asp:TextBox>
                    </td>
                    <td class="auto-style13">
                        <h5>Chức vụ:</h5>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txt_cv" runat="server" Width="328px" ReadOnly="true"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    
                    <td class="auto-style12">
                        
                    </td>
                </tr>
            </table>
            <table>
                <tr>
                    <td class="auto-style14"></td>
                    <td>
                        <asp:Button ID="btn_Sua" runat="server" Text="Sửa" Width="123px" OnClick="btn_Sua_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btb_Luu" runat="server" Text="Lưu" Width="123px" />
                    </td>
                </tr>
            </table>
            
            
            <asp:LinkButton ID="lbtn_quaylai" runat="server" ForeColor="Blue" OnClick="lbtn_quaylai_Click"><h4>&lt;&lt;Quay lại</h4></asp:LinkButton></td>
        </div>
    </div>
</asp:Content>
