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
Partial Public Class tSituazioneDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Definizioni metodo Extensibility"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InserttSituazione(instance As tSituazione)
    End Sub
  Partial Private Sub UpdatetSituazione(instance As tSituazione)
    End Sub
  Partial Private Sub DeletetSituazione(instance As tSituazione)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.COSiFa.My.MySettings.Default.SituationConnectionString1, mappingSource)
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
	
	Public ReadOnly Property tSituazione() As System.Data.Linq.Table(Of tSituazione)
		Get
			Return Me.GetTable(Of tSituazione)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.tSituazione")>  _
Partial Public Class tSituazione
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _Id As Integer
	
	Private _Anno As Integer
	
	Private _Produttore As String
	
	Private _Equipment As String
	
	Private _SettoreCommerciale As String
	
	Private _CanaleDistributivo As String
	
	Private _OdV As String
	
	Private _CodiceCliente As String
	
	Private _AnagraficaCliente As String
	
	Private _Nazione As String
	
	Private _Posizione As String
	
	Private _CodiceMateriale As String
	
	Private _AnagraficaMateriale As String
	
	Private _SituazioneSpedizione As String
	
	Private _DataSpedizione As Date
	
	Private _DtSped1 As System.Nullable(Of Date)
	
	Private _DtSped2 As System.Nullable(Of Date)
	
	Private _Autore As String
	
	Private _Note As String
	
	Private _RifProgramma As String
	
	Private _DataUscita As System.Nullable(Of Date)
	
	Private _DataConsegnaPrevista As System.Nullable(Of Date)
	
	Private _Studio As String
	
	Private _CentroDiCosto As String
	
	Private _OdA As String
	
	Private _PosizioneOdA As String
	
	Private _Catalogo As String
	
	Private _DataArchiviazione As System.Nullable(Of Date)
	
	Private _NumeroArchiviazione As String
	
	Private _NumeroArchiviazioneTavole As String
	
	Private _OreSAP As System.Nullable(Of Decimal)
	
	Private _OreDisegno As System.Nullable(Of Decimal)
	
	Private _CostoFatturato As System.Nullable(Of Decimal)
	
	Private _CostoPrevisto As System.Nullable(Of Decimal)
	
	Private _Scostamento As System.Nullable(Of Decimal)
	
	Private _NoteAgg As String
	
	Private _IsAtm As System.Nullable(Of Boolean)
	
	Private _AtmString As String
	
    Private _IsStringBefore As System.Nullable(Of Boolean)

    Private _HasException As Boolean

	
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
    Partial Private Sub OnAnnoChanging(value As Integer)
    End Sub
    Partial Private Sub OnAnnoChanged()
    End Sub
    Partial Private Sub OnProduttoreChanging(value As String)
    End Sub
    Partial Private Sub OnProduttoreChanged()
    End Sub
    Partial Private Sub OnEquipmentChanging(value As String)
    End Sub
    Partial Private Sub OnEquipmentChanged()
    End Sub
    Partial Private Sub OnSettoreCommercialeChanging(value As String)
    End Sub
    Partial Private Sub OnSettoreCommercialeChanged()
    End Sub
    Partial Private Sub OnCanaleDistributivoChanging(value As String)
    End Sub
    Partial Private Sub OnCanaleDistributivoChanged()
    End Sub
    Partial Private Sub OnOdVChanging(value As String)
    End Sub
    Partial Private Sub OnOdVChanged()
    End Sub
    Partial Private Sub OnCodiceClienteChanging(value As String)
    End Sub
    Partial Private Sub OnCodiceClienteChanged()
    End Sub
    Partial Private Sub OnAnagraficaClienteChanging(value As String)
    End Sub
    Partial Private Sub OnAnagraficaClienteChanged()
    End Sub
    Partial Private Sub OnNazioneChanging(value As String)
    End Sub
    Partial Private Sub OnNazioneChanged()
    End Sub
    Partial Private Sub OnPosizioneChanging(value As String)
    End Sub
    Partial Private Sub OnPosizioneChanged()
    End Sub
    Partial Private Sub OnCodiceMaterialeChanging(value As String)
    End Sub
    Partial Private Sub OnCodiceMaterialeChanged()
    End Sub
    Partial Private Sub OnAnagraficaMaterialeChanging(value As String)
    End Sub
    Partial Private Sub OnAnagraficaMaterialeChanged()
    End Sub
    Partial Private Sub OnSituazioneSpedizioneChanging(value As String)
    End Sub
    Partial Private Sub OnSituazioneSpedizioneChanged()
    End Sub
    Partial Private Sub OnDataSpedizioneChanging(value As Date)
    End Sub
    Partial Private Sub OnDataSpedizioneChanged()
    End Sub
    Partial Private Sub OnDtSped1Changing(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnDtSped1Changed()
    End Sub
    Partial Private Sub OnDtSped2Changing(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnDtSped2Changed()
    End Sub
    Partial Private Sub OnAutoreChanging(value As String)
    End Sub
    Partial Private Sub OnAutoreChanged()
    End Sub
    Partial Private Sub OnNoteChanging(value As String)
    End Sub
    Partial Private Sub OnNoteChanged()
    End Sub
    Partial Private Sub OnRifProgrammaChanging(value As String)
    End Sub
    Partial Private Sub OnRifProgrammaChanged()
    End Sub
    Partial Private Sub OnDataUscitaChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnDataUscitaChanged()
    End Sub
    Partial Private Sub OnDataConsegnaPrevistaChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnDataConsegnaPrevistaChanged()
    End Sub
    Partial Private Sub OnStudioChanging(value As String)
    End Sub
    Partial Private Sub OnStudioChanged()
    End Sub
    Partial Private Sub OnCentroDiCostoChanging(value As String)
    End Sub
    Partial Private Sub OnCentroDiCostoChanged()
    End Sub
    Partial Private Sub OnOdAChanging(value As String)
    End Sub
    Partial Private Sub OnOdAChanged()
    End Sub
    Partial Private Sub OnPosizioneOdAChanging(value As String)
    End Sub
    Partial Private Sub OnPosizioneOdAChanged()
    End Sub
    Partial Private Sub OnCatalogoChanging(value As String)
    End Sub
    Partial Private Sub OnCatalogoChanged()
    End Sub
    Partial Private Sub OnDataArchiviazioneChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnDataArchiviazioneChanged()
    End Sub
    Partial Private Sub OnNumeroArchiviazioneChanging(value As String)
    End Sub
    Partial Private Sub OnNumeroArchiviazioneChanged()
    End Sub
    Partial Private Sub OnNumeroArchiviazioneTavoleChanging(value As String)
    End Sub
    Partial Private Sub OnNumeroArchiviazioneTavoleChanged()
    End Sub
    Partial Private Sub OnOreSAPChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnOreSAPChanged()
    End Sub
    Partial Private Sub OnOreDisegnoChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnOreDisegnoChanged()
    End Sub
    Partial Private Sub OnCostoFatturatoChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnCostoFatturatoChanged()
    End Sub
    Partial Private Sub OnCostoPrevistoChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnCostoPrevistoChanged()
    End Sub
    Partial Private Sub OnScostamentoChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnScostamentoChanged()
    End Sub
    Partial Private Sub OnNoteAggChanging(value As String)
    End Sub
    Partial Private Sub OnNoteAggChanged()
    End Sub
    Partial Private Sub OnIsAtmChanging(value As System.Nullable(Of Boolean))
    End Sub
    Partial Private Sub OnIsAtmChanged()
    End Sub
    Partial Private Sub OnAtmStringChanging(value As String)
    End Sub
    Partial Private Sub OnAtmStringChanged()
    End Sub
    Partial Private Sub OnIsStringBeforeChanging(value As System.Nullable(Of Boolean))
    End Sub
    Partial Private Sub OnIsStringBeforeChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Id", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
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
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Anno", DbType:="Int NOT NULL")>  _
	Public Property Anno() As Integer
		Get
			Return Me._Anno
		End Get
		Set
			If ((Me._Anno = value)  _
						= false) Then
				Me.OnAnnoChanging(value)
				Me.SendPropertyChanging
				Me._Anno = value
				Me.SendPropertyChanged("Anno")
				Me.OnAnnoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Produttore", DbType:="VarChar(50)")>  _
	Public Property Produttore() As String
		Get
			Return Me._Produttore
		End Get
		Set
			If (String.Equals(Me._Produttore, value) = false) Then
				Me.OnProduttoreChanging(value)
				Me.SendPropertyChanging
				Me._Produttore = value
				Me.SendPropertyChanged("Produttore")
				Me.OnProduttoreChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Equipment", DbType:="VarChar(8) NOT NULL", CanBeNull:=false)>  _
	Public Property Equipment() As String
		Get
			Return Me._Equipment
		End Get
		Set
			If (String.Equals(Me._Equipment, value) = false) Then
				Me.OnEquipmentChanging(value)
				Me.SendPropertyChanging
				Me._Equipment = value
				Me.SendPropertyChanged("Equipment")
				Me.OnEquipmentChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SettoreCommerciale", DbType:="VarChar(4) NOT NULL", CanBeNull:=false)>  _
	Public Property SettoreCommerciale() As String
		Get
			Return Me._SettoreCommerciale
		End Get
		Set
			If (String.Equals(Me._SettoreCommerciale, value) = false) Then
				Me.OnSettoreCommercialeChanging(value)
				Me.SendPropertyChanging
				Me._SettoreCommerciale = value
				Me.SendPropertyChanged("SettoreCommerciale")
				Me.OnSettoreCommercialeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CanaleDistributivo", DbType:="VarChar(2) NOT NULL", CanBeNull:=false)>  _
	Public Property CanaleDistributivo() As String
		Get
			Return Me._CanaleDistributivo
		End Get
		Set
			If (String.Equals(Me._CanaleDistributivo, value) = false) Then
				Me.OnCanaleDistributivoChanging(value)
				Me.SendPropertyChanging
				Me._CanaleDistributivo = value
				Me.SendPropertyChanged("CanaleDistributivo")
				Me.OnCanaleDistributivoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_OdV", DbType:="VarChar(18) NOT NULL", CanBeNull:=false)>  _
	Public Property OdV() As String
		Get
			Return Me._OdV
		End Get
		Set
			If (String.Equals(Me._OdV, value) = false) Then
				Me.OnOdVChanging(value)
				Me.SendPropertyChanging
				Me._OdV = value
				Me.SendPropertyChanged("OdV")
				Me.OnOdVChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CodiceCliente", DbType:="VarChar(10) NOT NULL", CanBeNull:=false)>  _
	Public Property CodiceCliente() As String
		Get
			Return Me._CodiceCliente
		End Get
		Set
			If (String.Equals(Me._CodiceCliente, value) = false) Then
				Me.OnCodiceClienteChanging(value)
				Me.SendPropertyChanging
				Me._CodiceCliente = value
				Me.SendPropertyChanged("CodiceCliente")
				Me.OnCodiceClienteChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_AnagraficaCliente", DbType:="VarChar(40) NOT NULL", CanBeNull:=false)>  _
	Public Property AnagraficaCliente() As String
		Get
			Return Me._AnagraficaCliente
		End Get
		Set
			If (String.Equals(Me._AnagraficaCliente, value) = false) Then
				Me.OnAnagraficaClienteChanging(value)
				Me.SendPropertyChanging
				Me._AnagraficaCliente = value
				Me.SendPropertyChanged("AnagraficaCliente")
				Me.OnAnagraficaClienteChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Nazione", DbType:="VarChar(2) NOT NULL", CanBeNull:=false)>  _
	Public Property Nazione() As String
		Get
			Return Me._Nazione
		End Get
		Set
			If (String.Equals(Me._Nazione, value) = false) Then
				Me.OnNazioneChanging(value)
				Me.SendPropertyChanging
				Me._Nazione = value
				Me.SendPropertyChanged("Nazione")
				Me.OnNazioneChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Posizione", DbType:="VarChar(10) NOT NULL", CanBeNull:=false)>  _
	Public Property Posizione() As String
		Get
			Return Me._Posizione
		End Get
		Set
			If (String.Equals(Me._Posizione, value) = false) Then
				Me.OnPosizioneChanging(value)
				Me.SendPropertyChanging
				Me._Posizione = value
				Me.SendPropertyChanged("Posizione")
				Me.OnPosizioneChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CodiceMateriale", DbType:="VarChar(15) NOT NULL", CanBeNull:=false)>  _
	Public Property CodiceMateriale() As String
		Get
			Return Me._CodiceMateriale
		End Get
		Set
			If (String.Equals(Me._CodiceMateriale, value) = false) Then
				Me.OnCodiceMaterialeChanging(value)
				Me.SendPropertyChanging
				Me._CodiceMateriale = value
				Me.SendPropertyChanged("CodiceMateriale")
				Me.OnCodiceMaterialeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_AnagraficaMateriale", DbType:="VarChar(40) NOT NULL", CanBeNull:=false)>  _
	Public Property AnagraficaMateriale() As String
		Get
			Return Me._AnagraficaMateriale
		End Get
		Set
			If (String.Equals(Me._AnagraficaMateriale, value) = false) Then
				Me.OnAnagraficaMaterialeChanging(value)
				Me.SendPropertyChanging
				Me._AnagraficaMateriale = value
				Me.SendPropertyChanged("AnagraficaMateriale")
				Me.OnAnagraficaMaterialeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SituazioneSpedizione", DbType:="VarChar(1)")>  _
	Public Property SituazioneSpedizione() As String
		Get
			Return Me._SituazioneSpedizione
		End Get
		Set
			If (String.Equals(Me._SituazioneSpedizione, value) = false) Then
				Me.OnSituazioneSpedizioneChanging(value)
				Me.SendPropertyChanging
				Me._SituazioneSpedizione = value
				Me.SendPropertyChanged("SituazioneSpedizione")
				Me.OnSituazioneSpedizioneChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DataSpedizione", DbType:="Date NOT NULL")>  _
	Public Property DataSpedizione() As Date
		Get
			Return Me._DataSpedizione
		End Get
		Set
			If ((Me._DataSpedizione = value)  _
						= false) Then
				Me.OnDataSpedizioneChanging(value)
				Me.SendPropertyChanging
				Me._DataSpedizione = value
				Me.SendPropertyChanged("DataSpedizione")
				Me.OnDataSpedizioneChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DtSped1", DbType:="Date")>  _
	Public Property DtSped1() As System.Nullable(Of Date)
		Get
			Return Me._DtSped1
		End Get
		Set
			If (Me._DtSped1.Equals(value) = false) Then
				Me.OnDtSped1Changing(value)
				Me.SendPropertyChanging
				Me._DtSped1 = value
				Me.SendPropertyChanged("DtSped1")
				Me.OnDtSped1Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DtSped2", DbType:="Date")>  _
	Public Property DtSped2() As System.Nullable(Of Date)
		Get
			Return Me._DtSped2
		End Get
		Set
			If (Me._DtSped2.Equals(value) = false) Then
				Me.OnDtSped2Changing(value)
				Me.SendPropertyChanging
				Me._DtSped2 = value
				Me.SendPropertyChanged("DtSped2")
				Me.OnDtSped2Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Autore", DbType:="VarChar(40)")>  _
	Public Property Autore() As String
		Get
			Return Me._Autore
		End Get
		Set
			If (String.Equals(Me._Autore, value) = false) Then
				Me.OnAutoreChanging(value)
				Me.SendPropertyChanging
				Me._Autore = value
				Me.SendPropertyChanged("Autore")
				Me.OnAutoreChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Note", DbType:="VarChar(255)")>  _
	Public Property Note() As String
		Get
			Return Me._Note
		End Get
		Set
			If (String.Equals(Me._Note, value) = false) Then
				Me.OnNoteChanging(value)
				Me.SendPropertyChanging
				Me._Note = value
				Me.SendPropertyChanged("Note")
				Me.OnNoteChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_RifProgramma", DbType:="VarChar(15) NOT NULL", CanBeNull:=false)>  _
	Public Property RifProgramma() As String
		Get
			Return Me._RifProgramma
		End Get
		Set
			If (String.Equals(Me._RifProgramma, value) = false) Then
				Me.OnRifProgrammaChanging(value)
				Me.SendPropertyChanging
				Me._RifProgramma = value
				Me.SendPropertyChanged("RifProgramma")
				Me.OnRifProgrammaChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DataUscita", DbType:="Date")>  _
	Public Property DataUscita() As System.Nullable(Of Date)
		Get
			Return Me._DataUscita
		End Get
		Set
			If (Me._DataUscita.Equals(value) = false) Then
				Me.OnDataUscitaChanging(value)
				Me.SendPropertyChanging
				Me._DataUscita = value
				Me.SendPropertyChanged("DataUscita")
				Me.OnDataUscitaChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DataConsegnaPrevista", DbType:="Date")>  _
	Public Property DataConsegnaPrevista() As System.Nullable(Of Date)
		Get
			Return Me._DataConsegnaPrevista
		End Get
		Set
			If (Me._DataConsegnaPrevista.Equals(value) = false) Then
				Me.OnDataConsegnaPrevistaChanging(value)
				Me.SendPropertyChanging
				Me._DataConsegnaPrevista = value
				Me.SendPropertyChanged("DataConsegnaPrevista")
				Me.OnDataConsegnaPrevistaChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Studio", DbType:="VarChar(20)")>  _
	Public Property Studio() As String
		Get
			Return Me._Studio
		End Get
		Set
			If (String.Equals(Me._Studio, value) = false) Then
				Me.OnStudioChanging(value)
				Me.SendPropertyChanging
				Me._Studio = value
				Me.SendPropertyChanged("Studio")
				Me.OnStudioChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CentroDiCosto", DbType:="VarChar(15)")>  _
	Public Property CentroDiCosto() As String
		Get
			Return Me._CentroDiCosto
		End Get
		Set
			If (String.Equals(Me._CentroDiCosto, value) = false) Then
				Me.OnCentroDiCostoChanging(value)
				Me.SendPropertyChanging
				Me._CentroDiCosto = value
				Me.SendPropertyChanged("CentroDiCosto")
				Me.OnCentroDiCostoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_OdA", DbType:="VarChar(20)")>  _
	Public Property OdA() As String
		Get
			Return Me._OdA
		End Get
		Set
			If (String.Equals(Me._OdA, value) = false) Then
				Me.OnOdAChanging(value)
				Me.SendPropertyChanging
				Me._OdA = value
				Me.SendPropertyChanged("OdA")
				Me.OnOdAChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PosizioneOdA", DbType:="VarChar(12)")>  _
	Public Property PosizioneOdA() As String
		Get
			Return Me._PosizioneOdA
		End Get
		Set
			If (String.Equals(Me._PosizioneOdA, value) = false) Then
				Me.OnPosizioneOdAChanging(value)
				Me.SendPropertyChanging
				Me._PosizioneOdA = value
				Me.SendPropertyChanged("PosizioneOdA")
				Me.OnPosizioneOdAChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Catalogo", DbType:="VarChar(10)")>  _
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
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DataArchiviazione", DbType:="Date")>  _
	Public Property DataArchiviazione() As System.Nullable(Of Date)
		Get
			Return Me._DataArchiviazione
		End Get
		Set
			If (Me._DataArchiviazione.Equals(value) = false) Then
				Me.OnDataArchiviazioneChanging(value)
				Me.SendPropertyChanging
				Me._DataArchiviazione = value
				Me.SendPropertyChanged("DataArchiviazione")
				Me.OnDataArchiviazioneChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_NumeroArchiviazione", DbType:="VarChar(20)")>  _
	Public Property NumeroArchiviazione() As String
		Get
			Return Me._NumeroArchiviazione
		End Get
		Set
			If (String.Equals(Me._NumeroArchiviazione, value) = false) Then
				Me.OnNumeroArchiviazioneChanging(value)
				Me.SendPropertyChanging
				Me._NumeroArchiviazione = value
				Me.SendPropertyChanged("NumeroArchiviazione")
				Me.OnNumeroArchiviazioneChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_NumeroArchiviazioneTavole", DbType:="VarChar(20)")>  _
	Public Property NumeroArchiviazioneTavole() As String
		Get
			Return Me._NumeroArchiviazioneTavole
		End Get
		Set
			If (String.Equals(Me._NumeroArchiviazioneTavole, value) = false) Then
				Me.OnNumeroArchiviazioneTavoleChanging(value)
				Me.SendPropertyChanging
				Me._NumeroArchiviazioneTavole = value
				Me.SendPropertyChanged("NumeroArchiviazioneTavole")
				Me.OnNumeroArchiviazioneTavoleChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_OreSAP", DbType:="Decimal(4,1)")>  _
	Public Property OreSAP() As System.Nullable(Of Decimal)
		Get
			Return Me._OreSAP
		End Get
		Set
			If (Me._OreSAP.Equals(value) = false) Then
				Me.OnOreSAPChanging(value)
				Me.SendPropertyChanging
				Me._OreSAP = value
				Me.SendPropertyChanged("OreSAP")
				Me.OnOreSAPChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_OreDisegno", DbType:="Decimal(4,1)")>  _
	Public Property OreDisegno() As System.Nullable(Of Decimal)
		Get
			Return Me._OreDisegno
		End Get
		Set
			If (Me._OreDisegno.Equals(value) = false) Then
				Me.OnOreDisegnoChanging(value)
				Me.SendPropertyChanging
				Me._OreDisegno = value
				Me.SendPropertyChanged("OreDisegno")
				Me.OnOreDisegnoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CostoFatturato", DbType:="Decimal(4,1)")>  _
	Public Property CostoFatturato() As System.Nullable(Of Decimal)
		Get
			Return Me._CostoFatturato
		End Get
		Set
			If (Me._CostoFatturato.Equals(value) = false) Then
				Me.OnCostoFatturatoChanging(value)
				Me.SendPropertyChanging
				Me._CostoFatturato = value
				Me.SendPropertyChanged("CostoFatturato")
				Me.OnCostoFatturatoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CostoPrevisto", DbType:="Decimal(4,1)")>  _
	Public Property CostoPrevisto() As System.Nullable(Of Decimal)
		Get
			Return Me._CostoPrevisto
		End Get
		Set
			If (Me._CostoPrevisto.Equals(value) = false) Then
				Me.OnCostoPrevistoChanging(value)
				Me.SendPropertyChanging
				Me._CostoPrevisto = value
				Me.SendPropertyChanged("CostoPrevisto")
				Me.OnCostoPrevistoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Scostamento", DbType:="Decimal(4,1)")>  _
	Public Property Scostamento() As System.Nullable(Of Decimal)
		Get
			Return Me._Scostamento
		End Get
		Set
			If (Me._Scostamento.Equals(value) = false) Then
				Me.OnScostamentoChanging(value)
				Me.SendPropertyChanging
				Me._Scostamento = value
				Me.SendPropertyChanged("Scostamento")
				Me.OnScostamentoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_NoteAgg", DbType:="VarChar(255)")>  _
	Public Property NoteAgg() As String
		Get
			Return Me._NoteAgg
		End Get
		Set
			If (String.Equals(Me._NoteAgg, value) = false) Then
				Me.OnNoteAggChanging(value)
				Me.SendPropertyChanging
				Me._NoteAgg = value
				Me.SendPropertyChanged("NoteAgg")
				Me.OnNoteAggChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_IsAtm", DbType:="Bit")>  _
	Public Property IsAtm() As System.Nullable(Of Boolean)
		Get
			Return Me._IsAtm
		End Get
		Set
			If (Me._IsAtm.Equals(value) = false) Then
				Me.OnIsAtmChanging(value)
				Me.SendPropertyChanging
				Me._IsAtm = value
				Me.SendPropertyChanged("IsAtm")
				Me.OnIsAtmChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_AtmString", DbType:="VarChar(15)")>  _
	Public Property AtmString() As String
		Get
			Return Me._AtmString
		End Get
		Set
			If (String.Equals(Me._AtmString, value) = false) Then
				Me.OnAtmStringChanging(value)
				Me.SendPropertyChanging
				Me._AtmString = value
				Me.SendPropertyChanged("AtmString")
				Me.OnAtmStringChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_IsStringBefore", DbType:="Bit")>  _
	Public Property IsStringBefore() As System.Nullable(Of Boolean)
		Get
			Return Me._IsStringBefore
		End Get
		Set
			If (Me._IsStringBefore.Equals(value) = false) Then
				Me.OnIsStringBeforeChanging(value)
				Me.SendPropertyChanging
				Me._IsStringBefore = value
				Me.SendPropertyChanged("IsStringBefore")
				Me.OnIsStringBeforeChanged
			End If
		End Set
	End Property

    Public Property HasException As Boolean

        Get
            Return _HasException
        End Get
        Set(value As Boolean)
            _HasException = value
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
