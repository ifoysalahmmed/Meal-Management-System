<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Meal_Management_System._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />
        <asp:Button ID="Button1" runat="server" Text="Meal Description" OnClick="Button1_Click" Width="160px" />
    <br />
    <br />
        <asp:Button ID="Button2" runat="server" Text="Add Meal" OnClick="Button2_Click" Width="160px" />
    <br />
    <br />
        <asp:Button ID="Button3" runat="server" Text="Deposit" OnClick="Button3_Click" Width="160px" />
    <br />
    <br />
        <asp:Button ID="Button4" runat="server" Text="Bazar List" OnClick="Button4_Click" Width="159px" />
    <br />
    <br />
    <td>
        <b>
             Member Profile
        </b>       
    </td>
    <td>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Prosenjit</asp:ListItem>
            <asp:ListItem>Limon</asp:ListItem>
            <asp:ListItem>Shila</asp:ListItem>
    </asp:DropDownList>
    </td>
    <td>
        <asp:Button ID="Button5" runat="server" Text="View Profile" OnClick="Button5_Click" />
    </td>          
    <br />   
    <br />

</asp:Content>
