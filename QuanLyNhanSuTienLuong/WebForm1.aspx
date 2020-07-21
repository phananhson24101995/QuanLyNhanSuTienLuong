<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="QuanLyNhanSuTienLuong.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form enctype="multipart/form-data" id="form1" runat="server"><div><table id="table1" border="0" cellpadding="0" style= "border-collapse:collapse" width="100%"><tr><td width="125">&nbsp;Image Name</td><td width="10">&nbsp;</td>
        <td>
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>

        </td>
</tr>
        <tr>
            <td>
                &nbsp;File to Upload

            </td>
            <td>&nbsp;</td>
            <td>
                <input id="fileimage" runat="server" type="file"/>

            </td>

        </tr>
        <tr>
            <td>&nbsp;</td><td>&nbsp;</td>
    <td>
        <asp:Button ID="btupload" runat="server" Text="Upload"  />

    </td>

                                                                                                                   </tr><tr><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr></table></div></form>

</asp:Content>
