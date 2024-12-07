<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="SistemaSoporte.CapaVista.Usuarios" %>

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
        <div>
            <h2>CATALOGO DE USUARIOS</h2>

            <br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <br />
            Codigo:
             <br />
            <asp:TextBox ID="tcodigo" runat="server"></asp:TextBox>
            <br />
            Nombre:
             <br />
            <asp:TextBox ID="tnombre" runat="server" required></asp:TextBox>
            <br />

            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            <br />

            <asp:Button ID="bagregar" runat="server" Text="Agregar" OnClick="bagregar_Click" />
            <br />
            <asp:Button ID="bborrar" runat="server" Text="Borrar" OnClick="bborrar_Click" />

        </div>
    </form>
</body>
</html>
