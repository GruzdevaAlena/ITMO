﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Start.aspx.cs" Inherits="RSVP.Start" %>
<asp:MenuItem NavigateUrl="~/SummaryBD.aspx" Text="Список участников"/>
<asp:MenuItem NavigateUrl="~/Summary.aspx" Text="Регистрации"/>
<asp:MenuItem NavigateUrl="~/reg.aspx" Text="Регистрация"/>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="Styles.css" />

</head>
<body>
        <li><a href="SummaryBD.aspx">Список участников</a> <a href="Summary.aspx">Регистрации</a></li>
    <form id="form1" runat="server">
        <div>
            <div class="rek">
                     <h1>Приглашение на семинар</h1>
                     <p>Вы приглашены на наш семинар</p>
                     <p>Подтвердите свое согласие, пройдя регистрацию</p>
                 </div>
                 <div class="info">
                      Семинар состоится 1 января 2020 года в 7.30
                 </div>
                    <li><a href="reg.aspx">Регистрация</a> </li>
        </div>
    </form>
</body>
</html>
