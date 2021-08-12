Public Class Aufgabenliste

    Private mlstAufgaben As List(Of Aufgabe)

    Public Sub New()
        mlstAufgaben = New List(Of Aufgabe)
    End Sub

    Public Sub New(plstAufgaben As List(Of Aufgabe))
        mlstAufgaben = plstAufgaben
    End Sub

    Public Property Aufgaben() As List(Of Aufgabe)
        Get
            Return mlstAufgaben
        End Get
        Set(value As List(Of Aufgabe))
            mlstAufgaben = value
        End Set
    End Property

    Public Sub hinzufuegen(plstAufgaben As List(Of Aufgabe))
        mlstAufgaben.AddRange(plstAufgaben)
    End Sub

    Public Sub hinzufuegen(pAufgabe As Aufgabe)
        mlstAufgaben.Add(pAufgabe)
    End Sub

    Public Sub leeren()
        mlstAufgaben.Clear()
    End Sub

End Class
