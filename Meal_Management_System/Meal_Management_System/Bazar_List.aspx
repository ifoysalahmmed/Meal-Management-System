<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Bazar_List.aspx.cs" Inherits="Meal_Management_System.Bazar_List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    Bazar List
    <br />
    <br />
    <table class="nav-justified">
        <tr>
            <td>Date</td>
            <td>Name</td>
            <td>Amount</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtdate" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="txtamount" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
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
        </tr>
    </table>
    <br />
    <br />
    <asp:GridView ID="bazarGridView" runat="server" AutoGenerateColumns="False" OnPageIndexChanging="bazarGridView_PageIndexChanging" OnRowCancelingEdit="bazarGridView_RowCancelingEdit" OnRowEditing="bazarGridView_RowEditing" OnRowUpdating="bazarGridView_RowUpdating">
        <Columns>
            <asp:TemplateField HeaderText="Serial No">                
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("serial_no") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Date">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("date") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("date") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Name">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("name") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("name") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Amount">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("amount") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("amount") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ShowEditButton="True" />
        </Columns>
    </asp:GridView>
    <br />
        <asp:Button ID="Button1" runat="server" Text="Home" OnClick="Button1_Click" />
    <br />
    <br />
    <br />

</asp:Content>
