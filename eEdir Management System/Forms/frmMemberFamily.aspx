<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmMemberFamily.aspx.cs" Inherits="eEdir_Management_System.Forms.frmMemberFamily" %>

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
                <asp:Label ID="Label1" runat="server" Text="Fullname:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtFullname" runat="server" Width="100%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Relation Type:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlRelationType" runat="server" Width="100%">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Region:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlRegion" runat="server" Width="100%" OnSelectedIndexChanged="ddlRegion_SelectedIndexChanged" AutoPostBack="True">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Subcity:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlSubcity" runat="server" Width="100%" OnSelectedIndexChanged="ddlSubcity_SelectedIndexChanged" AutoPostBack="True">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Woreda:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlWoreda" runat="server" Width="100%">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="House Number:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtHouseNumber" runat="server" Width="100%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Phone Number"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPhoneNumber" runat="server" Width="100%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                &nbsp;<asp:Button ID="btnUpdate" runat="server" Text="Update" />
                &nbsp;<asp:Button ID="btnDelete" runat="server" Text="Delete" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="grvwMemberFamily" runat="server" Width="100%" AutoGenerateColumns="False" OnSelectedIndexChanged="grvwMemberFamily_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="ID" />
                        <asp:BoundField DataField="tblMember.Fullname" HeaderText="Member" />
                        <asp:BoundField DataField="Fullname" HeaderText="Fullname" />
                        <asp:BoundField DataField="tblRelationType.Title" HeaderText="Relation Type" />
                        <asp:BoundField DataField="HouseNumber" HeaderText="House Number" />
                        <asp:BoundField DataField="PhoneNumber" HeaderText="Phone Number" />
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
