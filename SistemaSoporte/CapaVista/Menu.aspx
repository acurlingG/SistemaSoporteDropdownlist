<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="SistemaSoporte.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../css/menu.css" rel="stylesheet" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul>
                <li><a class="active" href="#home">Home</a></li>
                <li><a href="Usuarios.aspx">Usuarios</a></li>
                <li><a href="Equipos.aspx">Equipos</a></li>
                <li><a href="#about">Tecnicos</a></li>
                <li><a href="#about">Reparaciones</a></li>
                <li><a href="#about">Asignaciones</a></li>
          
            </ul>
        </div>
    </form>
</body>
</html>
