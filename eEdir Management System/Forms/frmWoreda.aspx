<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmWoreda.aspx.cs" Inherits="eEdir_Management_System.Forms.frmWoreda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Subcity:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlSubcity" runat="server" Width="100%">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Title:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTitle" runat="server" Width="100%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnSave" runat="server" Text="Save" />
&nbsp;<asp:Button ID="btnUpdate" runat="server" Text="Update" />
&nbsp;<asp:Button ID="btnDelete" runat="server" Text="Delete" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="grvwWoreda" runat="server" Width="100%">
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
