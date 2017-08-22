<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionEx.aspx.cs" Inherits="SessionTest.SessionEx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <%=Session["test"].ToString() %>
    <%=Application["test"].ToString() %>
    </div>
    </form>
</body>
</html>
