Public Class AufgabenController
    Inherits System.Web.Mvc.Controller

    Private db As AufgabenDbEntities = New AufgabenDbEntities

    '
    ' GET: /Aufgaben
    '
    ' Alle Aufgaben anzeigen
    Function Index() As ActionResult

        ' Deklaration
        Dim aufListe As Aufgabenliste
        Dim auf As Aufgabe

        ' Leere Liste initislisieren
        aufListe = New Aufgabenliste

        ' Alle Aufgaben aus der Datenbank holen
        For Each aufEntity In db.tblAufgaben.ToList
            ' Objekt der Entity-Klasse in Objekt der Model-Klasse umwandeln
            auf = New Aufgabe(aufEntity)
            ' Objekt der Model-Klasse zur Liste hinzufügen
            aufListe.hinzufuegen(auf)
        Next

        ' Gesamte list anzeigen
        Return View(aufListe)
    End Function

    '
    ' GET: /Aufgaben/Bearbeiten
    '
    ' Eine Aufgabe mit der ausgewählten ID zur Bearbeitung anbieten
    <HttpGet>
    Function Bearbeiten(ID As Integer) As ActionResult
        ' Deklaration
        Dim auf As Aufgabe
        Dim aufEntity As AufgabeEntity

        ' Anhang der ID den Datensatz in der Tabelle finden
        ' und als Objekt der Entity-Klasse erhalten
        aufEntity = db.tblAufgaben.Find(ID)
        ' Umwandeln in ein Objekt der Model-Klasse
        auf = New Aufgabe(aufEntity)

        Return View(auf)
    End Function

    '
    ' POST: /Aufgaben/Bearbeiten
    '
    ' Eine bearbeitete Aufgabe in der Datenbank aktualisieren
    <HttpPost>
    Function Bearbeiten(pAufg As Aufgabe) As ActionResult
        Dim aufEntity As AufgabeEntity

        ' Prüfen, ob Model alle Pflichteingaben hat usw.
        If Not (ModelState.IsValid) Then
            ' Wenn nicht, dann zurück an die View
            Return View(pAufg)
        End If

        ' Objekt der Model-Klasse in Objekt der Entity-Klasse umwandeln
        aufEntity = pAufg.gibAlsAufgabeEntity()

        ' Objekt der Entity-Klasse wieder mit der Datenbank bekannt machen
        db.tblAufgaben.Attach(aufEntity)
        db.Entry(aufEntity).State = EntityState.Modified

        ' Speichern der Änderungen
        db.SaveChanges() ' Hier müsste man noch auf Fehler prüfen, das ist in der endgültigen Musterlösung umgesetzt

        Return RedirectToAction("Index")
    End Function


    '
    ' GET: /Aufgaben/Hinzufuegen
    '
    ' Neue Aufgabe vom Benutzer erfassen lassen
    <HttpGet>
    Function Hinzufuegen() As ActionResult
        ' Muss nur eine leere View anzeigen
        Return View()
    End Function


    '
    ' GET: /Aufgaben/Hinzufuegen
    '
    ' Vom Benutzer erfasste Aufgabe in der Datenbank speichern
    <HttpPost>
    Function Hinzufuegen(pAufg As Aufgabe) As ActionResult
        Dim aufEntity As AufgabeEntity

        If Not (ModelState.IsValid) Then
            Return View(pAufg)
        End If

        ' Objekt der Model-Klasse in Objekt der Entity-Klasse umwandeln
        aufEntity = pAufg.gibAlsAufgabeEntity()

        ' Objekt der Entity-Klasse wieder mit der Datenbank bekannt machen
        db.tblAufgaben.Attach(aufEntity)
        db.Entry(aufEntity).State = EntityState.Added

        ' Speichern der Änderungen
        db.SaveChanges() ' Hier müsste man noch auf Fehler prüfen, das ist in der endgültigen Musterlösung umgesetzt

        Return RedirectToAction("Index")
    End Function


    '
    ' GET: /Aufgaben/Hinzufuegen
    '
    ' Neue Aufgabe hinzufügen
    <HttpGet>
    Function Loeschen(ID As Integer) As ActionResult
        ' Deklaration
        Dim auf As Aufgabe
        Dim aufEntity As AufgabeEntity

        ' Anhang der ID den Datensatz in der Tabelle finden
        ' und als Objekt der Entity-Klasse erhalten
        aufEntity = db.tblAufgaben.Find(ID)
        ' Umwandeln in ein Objekt der Model-Klasse
        auf = New Aufgabe(aufEntity)

        Return View(auf)
    End Function

    <HttpPost>
    <ActionName("Loeschen")>
    Function LoeschenBestaetigt(ID As Integer) As ActionResult
        ' Deklaration
        Dim aufEntity As AufgabeEntity

        ' Anhang der ID den Datensatz in der Tabelle finden
        ' und als Objekt der Entity-Klasse erhalten
        aufEntity = db.tblAufgaben.Find(ID)

        ' Festlegen, dass es gelöscht wurde
        db.Entry(aufEntity).State = EntityState.Deleted

        ' Speichern der Änderungen
        db.SaveChanges() ' Hier müsste man noch auf Fehler prüfen, das ist in der endgültigen Musterlösung umgesetzt

        Return RedirectToAction("Index")
    End Function
End Class