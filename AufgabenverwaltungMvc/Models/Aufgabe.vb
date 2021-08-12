Imports System.ComponentModel.DataAnnotations

Public Class Aufgabe

    Private mstrTitel As String
    Private mstrBeschreibung As String
    Private mdatFaellig As Date
    Private mbolErledigt As Boolean
    Private mintId As Integer

    Public Sub New()
        mintId = -1
        mstrTitel = String.Empty
        mstrBeschreibung = String.Empty
        mdatFaellig = Nothing
        mbolErledigt = False
    End Sub

    Public Sub New(pstrTitel As String,
                   pstrBeschreibung As String,
                   pdatFaellig As Date,
                   pbolErledigt As Boolean)
        mintId = -1
        mstrTitel = pstrTitel
        mstrBeschreibung = pstrBeschreibung
        mdatFaellig = pdatFaellig
        mbolErledigt = pbolErledigt
    End Sub

    Sub New(paufEntity As AufgabeEntity)
        mintId = paufEntity.aufIdPk
        mstrTitel = paufEntity.aufTitel
        mstrBeschreibung = paufEntity.aufBeschreibung
        mdatFaellig = paufEntity.aufFaellig
        mbolErledigt = paufEntity.aufErledigt
    End Sub

    Public Property Id() As Integer
        Get
            Return mintId
        End Get
        Set(value As Integer)
            mintId = value
        End Set
    End Property

    Public Property Erledigt() As Boolean
        Get
            Return mbolErledigt
        End Get
        Set(ByVal value As Boolean)
            mbolErledigt = value
        End Set
    End Property

    <Display(Name:="Fälligkeitsdatum")>
    Public Property Faellig() As Date
        Get
            Return mdatFaellig
        End Get
        Set(ByVal value As Date)
            mdatFaellig = value
        End Set
    End Property

    <StringLength(100)>
    Public Property Beschreibung() As String
        Get
            Return mstrBeschreibung
        End Get
        Set(ByVal value As String)
            mstrBeschreibung = value
        End Set
    End Property

    <Required(ErrorMessage:="Titel ist ein Pfichtfeld.")>
    <StringLength(50)>
    Public Property Titel() As String
        Get
            Return mstrTitel
        End Get
        Set(ByVal value As String)
            mstrTitel = value
        End Set
    End Property

    ''' <summary>
    ''' Objekt der Model-Klasse als Objekt der Entity-Klasse zurückgeben
    ''' </summary>
    ''' <returns>Objekt der Entity-Klassse mit den Attributwerten der Objekts der Model-Klasse.</returns>
    ''' <remarks></remarks>
    Public Function gibAlsAufgabeEntity() As AufgabeEntity
        Dim aufE As AufgabeEntity
        aufE = New AufgabeEntity

        aufE.aufIdPk = mintId

        aufE.aufErledigt = mbolErledigt
        aufE.aufFaellig = mdatFaellig
        aufE.aufBeschreibung = mstrBeschreibung
        aufE.aufTitel = mstrTitel

        Return aufE
    End Function


End Class
