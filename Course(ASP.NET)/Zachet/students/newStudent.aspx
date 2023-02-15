<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="newStudent.aspx.cs" Inherits="students.AddStudent" MasterPageFile="~/home.master"  UnobtrusiveValidationMode="None" Title="Добавление студента" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 140px">
        

        <table style="width: 100%">
            <tr>
                <td style="width: 10px">    <div>
        <label style="width: 114px">Имя студента:</label></div>
                </td>
                <td style="width: 284px">
                    <asp:TextBox ID="FirstName" runat="server"  Width="134px"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                    ControlToValidate="FirstName" ErrorMessage="Заполните поле имени" ForeColor="Red">Не оставляйте поле пустым</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator runat="server" ControlToValidate="FirstName"
                ValidationExpression="[а-яА-ЯёЁ]+"
                ErrorMessage="Только буквы" Display="Dynamic"
                ForeColor="Red">Только буквы</asp:RegularExpressionValidator>

                </td>
            </tr>
            <tr>
                <td style="width: 10px">
    <div>
        <label style="width: 134px">Фамилия студента:</label></div>
                </td>
                <td style="width: 284px">
                    <asp:TextBox ID="LastName" runat="server"  Width="134px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                    ControlToValidate="LastName" ErrorMessage="Заполните поле имени" ForeColor="Red">Не оставляйте поле пустым</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator runat="server" ControlToValidate="LastName"
                ValidationExpression="[а-яА-ЯёЁ]+"
                ErrorMessage="Только буквы" Display="Dynamic"
                ForeColor="Red">Только буквы</asp:RegularExpressionValidator>
                </td>
            </tr>
        </table>
        <button type="submit">Добавить</button>
    </div>
</asp:Content>

