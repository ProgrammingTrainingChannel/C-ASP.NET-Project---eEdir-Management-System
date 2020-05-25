<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmPaymentPeriod.aspx.cs" Inherits="eEdir_Management_System.Forms.frmPaymentPeriod" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;">
        <tr>
            <td>
                <asp:Label ID="lblTitle" runat="server" Text="Title"></asp:Label></td>
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
                <asp:GridView ID="grvwPaymentPeriod" runat="server" Width="100%"></asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
