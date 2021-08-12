<%@ Page Language="VB" Inherits="System.Web.Mvc.ViewPage(Of AufgabenverwaltungMvc.Aufgabe)" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Löschen - Aufgabenverwaltung</title>
    <link rel="stylesheet" href="~/Content/aufgabenverwaltung.css" type="text/css" />
</head>
<body>
    <div>
        <h1>Aufgabenverwaltung</h1>
        <p>Die moderne Aufgabenverwaltung.</p>

        <h2>Aufgabe "<%=Model.Titel%>" löschen</h2>
        <p>Möchten Sie die Aufgabe "<%=Model.Titel%>" wirklich löschen?</p>

        <% Using Html.BeginForm()%>

        <%= Html.Hidden("Id")%>

        
        <%= Html.ActionLink("Nein", "Index")%>
        <input type="submit" value="Ja" />
        
        <% Html.EndForm  %>
        <% End Using  %>

    </div>
</body>
</html>
