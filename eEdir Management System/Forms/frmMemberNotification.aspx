<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmMemberNotification.aspx.cs" Inherits="eEdir_Management_System.Forms.frmMemberNotification" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<table style="width: 100%;">
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Member:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlMember" runat="server" Width="100%">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Notification Type:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlNotificationType" runat="server" Width="100%">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Message:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMessage" runat="server" Width="100%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Notification Date:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNotificationDate" runat="server" Width="100%"></asp:TextBox>
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
                <asp:GridView ID="grvwMemberPayment" runat="server" Width="100%" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="ID" />
                        <asp:BoundField DataField="tblMember.Fullname" HeaderText="Member" />
                        <asp:BoundField DataField="tblNotificationType.Title" HeaderText="Notification Type" />
                        <asp:BoundField DataField="Message" HeaderText="Message" />
                        <asp:BoundField DataField="NotificationDate" HeaderText="Notification Date" />
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
