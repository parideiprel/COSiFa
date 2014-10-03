Public Class ClsDatiExcel
    Private _xAnno As Integer
    Private _xProduttore As String
    Private _xEquipment As String
    Private _xSettoreCommerciale As String
    Private _xCanaleDistributivo As String
    Private _xOdV As String
    Private _xCodiceCliente As String
    Private _xAnagraficaCliente As String
    Private _xNazione As String
    Private _xPosizione As String
    Private _xCodiceMateriale As String
    Private _xAnagraficaMateriale As String
    Private _xSituazioneSpedizione As String
    Private _xDataSpedizione As Date
    Private _xDtSped1 As Date
    Private _xDtSped2 As Date
    Private _xAutore As String
    Private _xNote As String
    Private _xRiferimentoProgramma As String
    Private _xDataUscita As Date
    Private _xDataConsegnaPrevista As Date
    Private _xStudio As String
    Private _xCdC As String
    Private _xOdA As String
    Private _xPosizioneOdA As String
    Private _xCatalogo As String
    Private _xDataArchiviazione As Date
    Private _xNumeroArchiviazione As String
    Private _xNumeroArchiviazioneTavole As String
    Private _xOreSap As Single
    Private _xOreDisegno As Single
    Private _xCostoFatturato As Decimal
    Private _xCostoPreventivato As Single
    Private _xScostamento As Single
    Private _xNoteAgg As String
    Private _xIsAtm As Boolean
    Private _xAtmString As String = String.Empty
    Private _xIsStringBefore As Boolean


    Public Property XAnno As Integer
        Get
            Return _xAnno
        End Get
        Set(value As Integer)
            _xAnno = value
        End Set
    End Property

    Public Property XProduttore As String
        Get
            Return _xProduttore
        End Get
        Set(value As String)
            _xProduttore = value
        End Set
    End Property

    Public Property XEquipment As String
        Get
            Return _xEquipment
        End Get
        Set(value As String)
            _xEquipment = value
        End Set
    End Property

    Public Property XSettoreCommerciale As String
        Get
            Return _xSettoreCommerciale
        End Get
        Set(value As String)
            _xSettoreCommerciale = value
        End Set
    End Property

    Public Property XCanaleDistributivo As String
        Get
            Return _xCanaleDistributivo
        End Get
        Set(value As String)
            _xCanaleDistributivo = value
        End Set
    End Property

    Public Property XOdV As String
        Get
            Return _xOdV
        End Get
        Set(value As String)
            _xOdV = value
        End Set
    End Property

    Public Property XCodiceCliente As String
        Get
            Return _xCodiceCliente
        End Get
        Set(value As String)
            _xCodiceCliente = value
        End Set
    End Property

    Public Property XAnagraficaCliente As String
        Get
            Return _xAnagraficaCliente
        End Get
        Set(value As String)
            _xAnagraficaCliente = value
        End Set
    End Property

    Public Property XNazione As String
        Get
            Return _xNazione
        End Get
        Set(value As String)
            _xNazione = value
        End Set
    End Property

    Public Property XPosizione As String
        Get
            Return _xPosizione
        End Get
        Set(value As String)
            _xPosizione = value
        End Set
    End Property

    Public Property XCodiceMateriale As String
        Get
            Return _xCodiceMateriale
        End Get
        Set(value As String)
            _xCodiceMateriale = value
        End Set
    End Property

    Public Property XAnagraficaMateriale As String
        Get
            Return _xAnagraficaMateriale
        End Get
        Set(value As String)
            _xAnagraficaMateriale = value
        End Set
    End Property

    Public Property XSituazioneSpedizione As String
        Get
            Return _xSituazioneSpedizione
        End Get
        Set(value As String)
            _xSituazioneSpedizione = value
        End Set
    End Property

    Public Property XDataSpedizione As Date
        Get
            Return _xDataSpedizione
        End Get
        Set(value As Date)
            _xDataSpedizione = value
        End Set
    End Property

    Public Property XDtSped1 As Date
        Get
            Return _xDtSped1
        End Get
        Set(value As Date)
            _xDtSped1 = value
        End Set
    End Property

    Public Property XDtSped2 As Date
        Get
            Return _xDtSped2
        End Get
        Set(value As Date)
            _xDtSped2 = value
        End Set
    End Property

    Public Property XAutore As String
        Get
            Return _xAutore
        End Get
        Set(value As String)
            _xAutore = value
        End Set
    End Property

    Public Property XNote As String
        Get
            Return _xNote
        End Get
        Set(value As String)
            _xNote = value
        End Set
    End Property

    Public Property XRiferimentoProgramma As String
        Get
            Return _xRiferimentoProgramma
        End Get
        Set(value As String)
            _xRiferimentoProgramma = value
        End Set
    End Property

    Public Property XDataUscita As Date
        Get
            Return _xDataUscita
        End Get
        Set(value As Date)
            _xDataUscita = value
        End Set
    End Property

    Public Property XDataConsegnaPrevista As Date
        Get
            Return _xDataConsegnaPrevista
        End Get
        Set(value As Date)
            _xDataConsegnaPrevista = value
        End Set
    End Property

    Public Property XStudio As String
        Get
            Return _xStudio
        End Get
        Set(value As String)
            _xStudio = value
        End Set
    End Property

    Public Property XCdC As String
        Get
            Return _xCdC
        End Get
        Set(value As String)
            _xCdC = value
        End Set
    End Property

    Public Property XOdA As String
        Get
            Return _xOdA
        End Get
        Set(value As String)
            _xOdA = value
        End Set
    End Property

    Public Property XPosizioneOdA As String
        Get
            Return _xPosizioneOdA
        End Get
        Set(value As String)
            _xPosizioneOdA = value
        End Set
    End Property

    Public Property XCatalogo As String
        Get
            Return _xCatalogo
        End Get
        Set(value As String)
            _xCatalogo = value
        End Set
    End Property

    Public Property XDataArchiviazione As Date
        Get
            Return _xDataArchiviazione
        End Get
        Set(value As Date)
            _xDataArchiviazione = value
        End Set
    End Property

    Public Property XNumeroArchiviazione As String
        Get
            Return _xNumeroArchiviazione
        End Get
        Set(value As String)
            _xNumeroArchiviazione = value
        End Set
    End Property

    Public Property XNumeroArchiviazioneTavole As String
        Get
            Return _xNumeroArchiviazioneTavole
        End Get
        Set(value As String)
            _xNumeroArchiviazioneTavole = value
        End Set
    End Property

    Public Property XOreSap As Single
        Get
            Return _xOreSap
        End Get
        Set(value As Single)
            _xOreSap = value
        End Set
    End Property

    Public Property XOreDisegno As Single
        Get
            Return _xOreDisegno
        End Get
        Set(value As Single)
            _xOreDisegno = value
        End Set
    End Property

    Public Property XCostoFatturato As Decimal
        Get
            Return _xCostoFatturato
        End Get
        Set(value As Decimal)
            _xCostoFatturato = value
        End Set
    End Property

    Public Property XCostoPreventivato As Single
        Get
            Return _xCostoPreventivato
        End Get
        Set(value As Single)
            _xCostoPreventivato = value
        End Set
    End Property

    Public Property XScostamento As Single
        Get
            Return _xScostamento
        End Get
        Set(value As Single)
            _xScostamento = value
        End Set
    End Property

    Public Property XNoteAgg As String
        Get
            Return _xNoteAgg
        End Get
        Set(value As String)
            _xNoteAgg = value
        End Set
    End Property

    Public Property XIsAtm As Boolean
        Get
            Return _xIsAtm
        End Get
        Set(value As Boolean)
            _xIsAtm = value
        End Set
    End Property

    Public Property XAtmString As String
        Get
            Return _xAtmString
        End Get
        Set(value As String)
            _xAtmString = value
        End Set
    End Property

    Public Property XIsStringBefore As Boolean
        Get
            Return _xIsStringBefore
        End Get
        Set(value As Boolean)
            _xIsStringBefore = value
        End Set
    End Property
End Class
