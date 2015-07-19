<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Blog.WebUI.Admin.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Користувачі:</h1>

  <asp:ObjectDataSource ID="User_List" runat="server"
        TypeName="Blog.Repositories.EFUserRepository"
        SelectMethod="GetUsers"
        OnUpdating="ObjectDataSource1_Updating"
        UpdateMethod="UpdateUser">
        <UpdateParameters> 
            <asp:Parameter Name="IsEnable" Type="Boolean" />
        </UpdateParameters>
    </asp:ObjectDataSource>

    <asp:GridView ID="GridView1" runat="server"
        DataSourceID="User_List" DataKeyNames="ID_User" Height="256px" Width="218px"
        AutoGenerateColumns="False" AllowPaging="True" CellPadding="4"
        ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />

   <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:BoundField DataField="ID_User" HeaderText="ID_User" SortExpression="ID_User" ReadOnly="true" />
            <asp:BoundField DataField="Logins" HeaderText="Logins" SortExpression="Logins" ReadOnly="true" />
            <asp:BoundField DataField="Fist_name" HeaderText="Fist_name" SortExpression="Fist_name" ReadOnly="true" />
            <asp:BoundField DataField="Surname" HeaderText="Surname" SortExpression="Surname"  ReadOnly="true"/>
            <asp:BoundField DataField="Passwords" HeaderText="Passwords" SortExpression="Passwords" ReadOnly="true"/>
            <asp:BoundField DataField="Date_of_birth" HeaderText="Date_of_birth" SortExpression="Date_of_birth"  ReadOnly="true"/>
            <asp:CheckBoxField DataField="IsAdmin" HeaderText="IsAdmin" SortExpression="IsAdmin" ReadOnly="true" />
            <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" ReadOnly="true"/>
            <asp:BoundField DataField="Date_of_registration" HeaderText="Date_of_registration" SortExpression="Date_of_registration" ReadOnly="true"/>
            <asp:CheckBoxField DataField="IsEnable" HeaderText="IsEnable" SortExpression="IsEnable" />
        </Columns>

        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
    </asp:GridView>

</asp:Content>