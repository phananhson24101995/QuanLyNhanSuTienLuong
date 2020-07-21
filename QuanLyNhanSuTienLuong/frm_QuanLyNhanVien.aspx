<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frm_QuanLyNhanVien.aspx.cs" Inherits="QuanLyNhanSuTienLuong.frm_QuanLyNhanVien" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 285px;
        }
        .auto-style2 {
            width: 253px;
        }
        .auto-style3 {
            width: 1363px;
        }
        .auto-style4 {
            margin-left:53px;
        }
        .auto-style5 {
            margin-left: 0;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="w3-main" style="margin-left:300px;margin-top:43px;">

  <!-- Header -->
  <header class="w3-container" style="padding-top:22px">
        <table class="auto-style3">
            <tr>
                <td>
                    <h5><b>Danh Sách Nhân Viên KLAND</b></h5>
                </td>
                <td class="auto-style1"></td>
                <td>
                    <asp:TextBox ID="txt_timkiem" runat="server" placeholder="Tìm kiếm theo mã, tên, sđt..." Width="326px" Height="33px" CssClass="auto-style5"></asp:TextBox>
                   
                    <%-- <asp:TemplateField HeaderText="Năm Sinh" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <p style="color:#332221;font-weight:bold;"> <%# Eval("NamSinh") %></p>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:Label ID="txtNamSinh" runat="server" Text='<%# Bind("NamSinh", "{0:dd/MM/yyyy}") %>'></asp:Label>
                    </EditItemTemplate>
                </asp:TemplateField>--%>
                    <asp:Button ID="btn_timkiem" runat="server" OnClick="btn_timkiem_Click" Text="Tìm kiếm" />
                   
                </td>
                <td class="auto-style2">
                    <asp:Button ID="btn_them" runat="server" CssClass="auto-style4" Text="Thêm Nhân Viên" OnClick="btn_them_Click" />
                </td>
            </tr>
            <tr>
                <asp:Label ID="lbl_tb" runat="server" Text=""></asp:Label></tr>
        </table>
  </header>
       <div class="w3-panel" style ="margin-bottom: 100px">
              <asp:GridView ID="gvNhanVien" runat="server" Width="100%" 
            AutoGenerateColumns="False" 
            onrowcancelingedit="gvNhanVien_RowCancelingEdit" 
            onrowediting="gvNhanVien_RowEditing" DataKeyNames="MaNV" 
            onrowupdating="gvNhanVien_RowUpdating" 
            OnPageIndexChanging="datagrid_PageIndexChanging"
            onrowdeleting="gvNhanVien_RowDeleting"  DataSourceID="SqlDataSource1" AllowPaging="True" PageSize="20" AllowSorting="True" OnSelectedIndexChanged="gvNhanVien_SelectedIndexChanged" OnSelectedIndexChanging="gvNhanVien_SelectedIndexChanging">
            <Columns>
                
               <%-- <asp:TemplateField HeaderText="Năm Sinh" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <p style="color:#332221;font-weight:bold;"> <%# Eval("NamSinh") %></p>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:Label ID="txtNamSinh" runat="server" Text='<%# Bind("NamSinh", "{0:dd/MM/yyyy}") %>'></asp:Label>
                    </EditItemTemplate>
                </asp:TemplateField>--%>
                
                <asp:BoundField HeaderText = "Mã NV" DataField="MaNV" ReadOnly="true" 
                    ItemStyle-HorizontalAlign="Center" >
                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                </asp:BoundField>
                
                <asp:TemplateField HeaderText = "Họ tên" ItemStyle-HorizontalAlign="Center"> 
                    <ItemTemplate>
                        <p style="color:#332221;font-weight:bold;"> <%# Eval("HoTen") %></p>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtHoTen" runat="server" Text='<%# Eval("HoTen") %>' Width="100px"/>
                    </EditItemTemplate>

                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                </asp:TemplateField>
                
                
                        <asp:TemplateField HeaderText = "Năm Sinh"   ItemStyle-HorizontalAlign="Center"> 
                    <ItemTemplate>
                        <p style="color:#332221;font-weight:bold;"> <%# Eval("NamSinh", "{0:dd/MM/yyyy}") %></p>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtNamSinh" runat="server" Text='<%# Eval("NamSinh") %>' Width="100px"/>
                    </EditItemTemplate>

                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                </asp:TemplateField>
                
                
                 <asp:TemplateField HeaderText = "Giới tính" ItemStyle-HorizontalAlign="Center"> 
                    <ItemTemplate>
                        <p style="color:#332221;font-weight:bold;"> <%# Eval("GioiTinh").Equals(false)? "Nam":"Nữ" %></p>
                    </ItemTemplate>
                    <EditItemTemplate>
                         <asp:DropDownList ID="ddlGioiTinh" runat="server">
                            <asp:ListItem Text="Nam" Value = "0" Selected="False"></asp:ListItem>
                            <asp:ListItem Text="Nữ" Value = "1"></asp:ListItem>
                        </asp:DropDownList>
                    </EditItemTemplate>

                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                </asp:TemplateField>

                 <asp:TemplateField HeaderText = "Số CMND" ItemStyle-HorizontalAlign="Center"> 
                    <ItemTemplate>
                        <p style="color:#332221;font-weight:bold;"> <%# Eval("SoCMND") %></p>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtSoCMND" runat="server" Text='<%# Eval("SoCMND") %>' Width="100px"/>
                    </EditItemTemplate>

                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                </asp:TemplateField>

                                 <asp:TemplateField HeaderText = "Địa chỉ" ItemStyle-HorizontalAlign="Center"> 
                    <ItemTemplate>
                        <p style="color:#332221;font-weight:bold;"> <%# Eval("DiaChi") %></p>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtDiaChi" runat="server" Text='<%# Eval("DiaChi") %>' Width="100px"/>
                    </EditItemTemplate>

                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                </asp:TemplateField>

                
                <asp:TemplateField HeaderText = "Điện thoại" ItemStyle-HorizontalAlign="Center"> 
                    <ItemTemplate>
                        <p style="color:#332221;font-weight:bold;"> <%# Eval("SDT") %></p>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtSDT" runat="server" Text='<%# Eval("SDT") %>' Width="100px"/>
                    </EditItemTemplate>

                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText = "Email" ItemStyle-HorizontalAlign="Center"> 
                    <ItemTemplate>
                        <p style="color:#332221;font-weight:bold;"> <%# Eval("Email") %></p>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEmail" runat="server" Text='<%# Eval("Email") %>' Width="100px"/>
                    </EditItemTemplate>

                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                </asp:TemplateField>


                <asp:TemplateField HeaderText = "Phòng ban" ItemStyle-HorizontalAlign="Center"> 
                    <ItemTemplate>
                        <p style="color:#332221;font-weight:bold;"> <%# Eval("MaPB") %></p>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtMaPB" runat="server" Text='<%# Eval("MaPB") %>' Width="100px"/>
                    </EditItemTemplate>

<ItemStyle HorizontalAlign="Center"></ItemStyle>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText = "Chức Vụ" ItemStyle-HorizontalAlign="Center"> 
                    <ItemTemplate>
                        <p style="color:#332221;font-weight:bold;"> <%# Eval("MaCV") %></p>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtMaCV" runat="server" Text='<%# Eval("MaCV") %>' Width="100px"/>
                    </EditItemTemplate>

                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                </asp:TemplateField>
                   <asp:CommandField HeaderText="Xem chi tiết" SelectText="Xem chi tiết" ShowSelectButton="True"  />
                   <asp:TemplateField HeaderText = "Cập nhật" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <asp:LinkButton ID="lbtnCapNhat" runat="server" CommandName="Edit">Cập nhật</asp:LinkButton>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:LinkButton ID="lbtnOK" runat="server" CommandName="Update">Xác nhận</asp:LinkButton>
                        <asp:LinkButton ID="lbtnHuy" runat="server" CommandName = "Cancel">Hủy</asp:LinkButton>
                    </EditItemTemplate>

                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText = "Xóa" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <span onclick="return confirm('Bạn có chắc chắn muốn xóa không ?')">
                              <asp:LinkButton ID="lbtnXoa" runat="server" CommandName="Delete">Xóa</asp:LinkButton>
                        </span>
                    </ItemTemplate>

                <ItemStyle HorizontalAlign="Center"></ItemStyle>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>
              <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QLNhanSuTienLuongConnectionString %>" SelectCommand="SELECT [MaNV], [HoTen], [NamSinh], [DiaChi], [GioiTinh], [SoCMND], [SDT], [Email], [MaPB], [MaCV] FROM [NhanVien]"></asp:SqlDataSource>
              <asp:Label ID="lbltb" runat="server"></asp:Label>
              <br />
           </div>
       </div>
</asp:Content>
