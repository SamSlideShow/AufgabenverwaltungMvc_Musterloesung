﻿'------------------------------------------------------------------------------
' <auto-generated>
'    Dieser Code wurde aus einer Vorlage generiert.
'
'    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
'    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class AufgabenDbEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=AufgabenDbEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Property tblAufgaben() As DbSet(Of AufgabeEntity)

End Class
