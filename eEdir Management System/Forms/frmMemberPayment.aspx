<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmMemberPayment.aspx.cs" Inherits="eEdir_Management_System.Forms.frmMemberPayment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;">
        <tr>
            <td colspan="2">
                <asp:Label ID="lblMessage" runat="server" Text="[Message]"></asp:Label>
            </td>
        </tr>
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
                <asp:Label ID="Label10" runat="server" Text="Payment Period:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlPaymentPeriod" runat="server" Width="100%">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Payment Year:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPaymentYear" runat="server" Width="100%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Payment Date:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPaymentDate" runat="server" Width="100%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Payment Amount:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPaymentAmount" runat="server" Width="100%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Payment Transaction Code:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPaymentTransactionCode" runat="server" Width="100%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                &nbsp;<asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                &nbsp;<asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="grvwMemberPayment" runat="server" Width="100%" AutoGenerateColumns="False" OnSelectedIndexChanged="grvwMemberPayment_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="ID" />
                        <asp:BoundField DataField="tblMember.Fullname" HeaderText="Member" />
                        <asp:BoundField DataField="tblPaymentPeriod.Title" HeaderText="Payment Period" />
                        <asp:BoundField DataField="PaymentYear" HeaderText="Payment Year" />
                        <asp:BoundField DataField="PaymentDate" HeaderText="Payment Date" />
                        <asp:BoundField DataField="PaymentAmount" HeaderText="Payment Amount" />
                        <asp:BoundField DataField="PaymentTransactionCode" HeaderText="Payment Transaction Code" />
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
