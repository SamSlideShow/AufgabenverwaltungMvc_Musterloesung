<%@ Page Language="VB" Inherits="System.Web.Mvc.ViewPage(Of AufgabenverwaltungMVC.Aufgabe)" %>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Hinzufügen - Aufgabenverwaltung</title>
    <link rel="stylesheet" href="~/Content/aufgabenverwaltung.css" type="text/css" />
</head>
<body>
    <div>
        <h1>Aufgabenverwaltung</h1>
        <p>Die moderne Aufgabenverwaltung.</p>

        <h2>Neue Aufgabe hinzufügen</h2>
        
        <% Using Html.BeginForm()%>

        <%= Html.ValidationSummary(False, "Aktion nicht erfolgreich, bitte korrigieren Sie die folgenden Fehler!")%>

        <!-- Im Gegensatz zum Bearbeiten, wird beim Hinzufügen keine ID benötigt,
             weil diese erst beim Speichern in der Datenbank als Autowert (Identity)
            erzeugt wird
         -->

        <p>
            <%= Html.Label("Titel")%>
            <%= Html.TextBox("Titel")%>
            <%= Html.ValidationMessage("Titel") %>
        </p>

        <p>
            <%= Html.Label("Beschreibung")%>
            <%= Html.TextArea("Beschreibung")%>
            <%= Html.ValidationMessage("Beschreibung")%>
        </p>

        <p>
            <%= Html.Label("Faellig")%>
            <%= Html.TextBox("Faellig")%>
            <%= Html.ValidationMessage("Faellig") %>
        </p>

        <p>
            <%= Html.Label("Erledigt")%>
            <%= Html.CheckBox("Erledigt")%>
            <%= Html.ValidationMessage("Erledigt") %>
        </p>
        <%= Html.ActionLink("Abbrechen", "Index") %>
        <input type="submit" value="Speichern" />
        <% Html.EndForm  %>
        <% End Using  %>

    </div>
</body>
</html>
