<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Meal_Description.aspx.cs" Inherits="Meal_Management_System.Meal_Description" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
    <tr>
        <td>
            <br />
            Date</td>
        <td>Prosenjit</td>
        <td>Limon</td>
        <td>Shila</td>
        <td>Abul</td>
    </tr>
    <tr>
        <td style="height: 24px">
            <asp:TextBox ID="txtdate" runat="server"></asp:TextBox>
        </td>
        <td style="height: 24px">
            <asp:TextBox ID="txtprosen" runat="server"></asp:TextBox>
        </td>
        <td style="height: 24px">
            <asp:TextBox ID="txtlimon" runat="server"></asp:TextBox>
        </td>
        <td style="height: 24px">
            <asp:TextBox ID="txtshila" runat="server"></asp:TextBox>
        </td>
        <td style="height: 24px">
            <asp:TextBox ID="txtabul" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" />
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Home" OnClick="Button1_Click" />
<br />
</asp:Content>
