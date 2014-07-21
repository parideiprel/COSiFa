﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Il codice è stato generato da uno strumento.
'     Versione runtime:4.0.30319.18444
'
'     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
'     il codice viene rigenerato.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="Situation")>  _
Partial Public Class tOreDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Definizioni metodo Extensibility"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InserttOre(instance As tOre)
    End Sub
  Partial Private Sub UpdatetOre(instance As tOre)
    End Sub
  Partial Private Sub DeletetOre(instance As tOre)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.COSiFa.My.MySettings.Default.SituationConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property tOre() As System.Data.Linq.Table(Of tOre)
		Get
			Return Me.GetTable(Of tOre)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.tOre")>  _
Partial Public Class tOre
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _Id As Integer
	
	Private _Catalogo As String
	
	Private _OreSap As Decimal
	
	Private _OreDisegno As Decimal
	
	Private _Utente As String
	
    #Region "Definizioni metodo Extensibility"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnIdChanged()
    End Sub
    Partial Private Sub OnCatalogoChanging(value As String)
    End Sub
    Partial Private Sub OnCatalogoChanged()
    End Sub
    Partial Private Sub OnOreSapChanging(value As Decimal)
    End Sub
    Partial Private Sub OnOreSapChanged()
    End Sub
    Partial Private Sub OnOreDisegnoChanging(value As Decimal)
    End Sub
    Partial Private Sub OnOreDisegnoChanged()
    End Sub
    Partial Private Sub OnUtenteChanging(value As String)
    End Sub
    Partial Private Sub OnUtenteChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Id", DbType:="Int NOT NULL", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property Id() As Integer
		Get
			Return Me._Id
		End Get
		Set
			If ((Me._Id = value)  _
						= false) Then
				Me.OnIdChanging(value)
				Me.SendPropertyChanging
				Me._Id = value
				Me.SendPropertyChanged("Id")
				Me.OnIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Catalogo", DbType:="VarChar(4) NOT NULL", CanBeNull:=false)>  _
	Public Property Catalogo() As String
		Get
			Return Me._Catalogo
		End Get
		Set
			If (String.Equals(Me._Catalogo, value) = false) Then
				Me.OnCatalogoChanging(value)
				Me.SendPropertyChanging
				Me._Catalogo = value
				Me.SendPropertyChanged("Catalogo")
				Me.OnCatalogoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_OreSap", DbType:="Decimal(5,1) NOT NULL")>  _
	Public Property OreSap() As Decimal
		Get
			Return Me._OreSap
		End Get
		Set
			If ((Me._OreSap = value)  _
						= false) Then
				Me.OnOreSapChanging(value)
				Me.SendPropertyChanging
				Me._OreSap = value
				Me.SendPropertyChanged("OreSap")
				Me.OnOreSapChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_OreDisegno", DbType:="Decimal(5,1) NOT NULL")>  _
	Public Property OreDisegno() As Decimal
		Get
			Return Me._OreDisegno
		End Get
		Set
			If ((Me._OreDisegno = value)  _
						= false) Then
				Me.OnOreDisegnoChanging(value)
				Me.SendPropertyChanging
				Me._OreDisegno = value
				Me.SendPropertyChanged("OreDisegno")
				Me.OnOreDisegnoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Utente", DbType:="VarChar(10) NOT NULL", CanBeNull:=false)>  _
	Public Property Utente() As String
		Get
			Return Me._Utente
		End Get
		Set
			If (String.Equals(Me._Utente, value) = false) Then
				Me.OnUtenteChanging(value)
				Me.SendPropertyChanging
				Me._Utente = value
				Me.SendPropertyChanged("Utente")
				Me.OnUtenteChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class
