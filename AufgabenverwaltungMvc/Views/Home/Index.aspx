<%@ Page Language="VB" Inherits="System.Web.Mvc.ViewPage" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Willkommen - Aufgabenverwaltung</title>
    <link rel="stylesheet" href="~/Content/aufgabenverwaltung.css" type="text/css" />
</head>
<body>
    <div>
        <h1>Aufgabenverwaltung</h1>
        <p>Die moderne Aufgabenverwaltung.</p>

        <h2>Willkommen</h2>
        <p><%=Html.ActionLink("Hier geht's zu den Aufgaben...", "Index", "Aufgaben") %></p>

    </div>
</body>
</html>
