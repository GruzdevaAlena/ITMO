<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="students.ShowStudents" MasterPageFile="~/home.master" Title="Дневник"%>

<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="students.SampleContext" EntityTypeName="" Select="new (FirstName, LastName, points, id, sum)" TableName="_Students">
        </asp:LinqDataSource>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Black">Выберите студента</asp:Label>
         &nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator runat="server" ControlToValidate="TextBox1"
            ValidationExpression="[0-9]+"
            ErrorMessage="Только цифры!" Display="Dynamic"
            ForeColor="Red">Только цифры!</asp:RegularExpressionValidator>
        

    <button type="submit">Выставить</button>
   
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Height="22px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="110px">
        <asp:ListItem>Обычный</asp:ListItem>
        <asp:ListItem>Лучшие</asp:ListItem>
        <asp:ListItem>Худшие</asp:ListItem>
    </asp:DropDownList>
                &nbsp;<table style="width: 100%">
            <tr>
                <td style="width: 761px"><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="LinqDataSource1" GridLines="Horizontal" Width="956px" Height="174px" HorizontalAlign="Left" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="margin-left: 0px" AutoGenerateSelectButton="True" ViewStateMode="Enabled" PageSize="5" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" >
        <Columns>
            <asp:BoundField DataField="id" HeaderText="ID" ReadOnly="True" SortExpression="id" >
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="LastName" HeaderText="Фамилия" ReadOnly="True" SortExpression="LastName" >
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="FirstName" HeaderText="Имя" ReadOnly="True" SortExpression="FirstName" >
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="points" HeaderText="Баллы" ReadOnly="True" SortExpression="points" >
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="sum" HeaderText="Сумма баллов" ReadOnly="True" SortExpression="sum" >
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
        </Columns>
                    <EmptyDataTemplate>
                        ID
                    </EmptyDataTemplate>
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
        <PagerSettings PageButtonCount="1" Visible="False" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#487575" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#275353" />
        </asp:GridView>
                </td>
            </tr>
</table>
</asp:Content>

