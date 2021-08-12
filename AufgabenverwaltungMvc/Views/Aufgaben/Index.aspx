<%@ Page Language="VB" Inherits="System.Web.Mvc.ViewPage(Of AufgabenverwaltungMvc.Aufgabenliste)" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Alle Aufgaben - Aufgabenverwaltung</title>
    <link rel="stylesheet" href="~/Content/aufgabenverwaltung.css" type="text/css" />
</head>
<body>
    <!-- Es gibt eine harmlose, aber seltsame Fehlermeldung, die die Deklaration einer Variable __o fordert. 
        Damit dieser Fehler nicht auftritt, muss die folgende Anweisung stehen: -->
    <%="" %> 

    <div>
        <h1>Aufgabenverwaltung</h1>
        <p>Die moderne Aufgabenverwaltung.</p>

        <h2>Alle Aufgaben</h2>

        <table>
            <tr>
                <th>ID</th>
                <th>Titel</th>
                <th>Fällig</th>
                <th>Erledigt</th>
                <th>Aktion</th>
            </tr>

            <% For Each auf In Model.Aufgaben%>

            <tr>
                <td><%= auf.Id%></td>
                <td><%= auf.Titel%></td>
                <td><%= auf.Faellig%></td>
                <td><%= auf.Erledigt%></td>
                <td>
                    <%= Html.ActionLink("Bearbeiten", "Bearbeiten", New With{.id = auf.Id}) %>
                    <%= Html.ActionLink("Löschen", "Loeschen", New With{.id = auf.Id}) %>
                </td>
            </tr>

            <% Next %>

        </table>

         <%= Html.ActionLink("Hinzufügen", "Hinzufuegen", Nothing, New With{.class="btn btn-primary", .role="button"}) %>
    </div>
</body>
</html>
