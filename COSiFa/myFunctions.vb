Imports System.IO
Imports System.Text

Module MyFunctions
    Function ScriviDb(ByRef tSitu, ByRef xls, ByRef currentIndex, ByRef count) As Boolean

        '******* Scrittura dati nel DB SQL ************

        'tSitu.Log = Console.Out

        'Se bIsAList è TRUE allora devo ripetere la stessa riga per ogni elemento della lista


        tSitu.tSituazione.InsertOnSubmit(ImpostaDati(xls))

        Try
            tSitu.SubmitChanges()

        Catch ex As Exception
            MsgBox("CAZZO UNA ECCEZZIONE !!! LINQ->SQL" + vbCrLf + "matricola: " + ImpostaDati(xls).Equipment + vbCrLf + vbCrLf + ex.Message)
            Console.WriteLine("********* EXCEPTION ***********" + vbCrLf + ex.Message + vbCrLf + "********* EXCEPTION ***********")
        End Try
        Return 0

    End Function

    Private Function ImpostaDati(ByRef xls) As tSituazione

        Dim tSit = New tSituazione()

        Try
            tSit.Anno = xls.xAnno
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [Anno] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.Anno.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.Produttore = xls.xProduttore
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [Produttore] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.Produttore)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.Equipment = xls.xEquipment
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [Equipment] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.Equipment)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.SettoreCommerciale = xls.xSettoreCommerciale
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [SettoreCommerciale] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.SettoreCommerciale)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.CanaleDistributivo = xls.xCanaleDistributivo
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [CanaleDistributivo] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.CanaleDistributivo)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.OdV = xls.xOdV
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [OdV] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.OdV)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.CodiceCliente = xls.xCodiceCliente
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [CodiceCliente] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.CodiceCliente)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.AnagraficaCliente = xls.xAnagraficaCliente
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [AnagraficaCliente] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.AnagraficaCliente)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.Nazione = xls.xNazione
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [Nazione] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.Nazione)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.Posizione = xls.xPosizione
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [Posizione] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.Posizione.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.CodiceMateriale = xls.xCodiceMateriale
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [CodiceMateriale] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.CodiceMateriale)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.AnagraficaMateriale = xls.xAnagraficaMateriale
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [AnagraficaMateriale] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.AnagraficaMateriale)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.SituazioneSpedizione = xls.xSituazioneSpedizione
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [SituazioneSpedizione] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.SituazioneSpedizione)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.DataSpedizione = xls.xDataSpedizione
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [DataSpedizione] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.DataSpedizione.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.DtSped1 = xls.xDtSped1
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [DtSped1] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.DtSped1.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.DtSped2 = xls.xDtSped2
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [DtSped2] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.DtSped2.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.Autore = xls.xAutore
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [Autore] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.Autore)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.Note = xls.xNote
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [Note] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.Note)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.RifProgramma = xls.xRiferimentoProgramma
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [RifProgramma] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.RifProgramma)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.DataUscita = xls.xDataUscita
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [DataUscita] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.DataUscita.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.DataConsegnaPrevista = xls.xDataConsegnaPrevista
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [DataConsegnaPrevista] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.DataConsegnaPrevista.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.Studio = xls.xStudio
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [Studio] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.Studio)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.CentroDiCosto = xls.xCdC
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [CentroDiCosto] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.CentroDiCosto)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.OdA = xls.xOdA
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [OdA] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.OdA)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.PosizioneOdA = xls.xPosizioneOdA
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [PosizioneOdA] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.PosizioneOdA)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.Catalogo = xls.xCatalogo
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [Catalogo] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.Catalogo)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.DataArchiviazione = xls.xDataArchiviazione
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [DataArchiviazione] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.DataArchiviazione.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.NumeroArchiviazione = xls.xNumeroArchiviazione
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [NumeroArchiviazione] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.NumeroArchiviazione)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.NumeroArchiviazioneTavole = xls.xNumeroArchiviazioneTavole
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [NumeroArchiviazioneTavole] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.NumeroArchiviazioneTavole)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.OreSAP = xls.xOreSap
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [OreSAP] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.OreSAP.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.OreDisegno = xls.xOreDisegno
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [OreDisegno] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.OreDisegno.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.CostoFatturato = xls.xCostoFatturato
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [CostoFatturato] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.CostoFatturato.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.CostoPrevisto = xls.xCostoPreventivato
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [CostoPrevisto] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.CostoPrevisto.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.Scostamento = xls.xScostamento
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [Scostamento] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.Scostamento.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.NoteAgg = xls.xNoteAgg
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [NoteAgg] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.NoteAgg)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.IsAtm = xls.xIsAtm
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [IsAtm] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.IsAtm.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.AtmString = xls.xAtmString
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [AtmString] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.AtmString.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.IsStringBefore = xls.xIsStringBefore
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [StringBefore] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.IsStringBefore.ToString())
            tSit.HasException = True
        End Try

        Return tSit
    End Function

    Private Function WriteToLog(filePath As String, message As String) As Boolean
        'funzione di scrittura su LogFile
        Dim fs As FileStream
        Dim text As Byte() = New UTF8Encoding(True).GetBytes(message)

        Try
            fs = System.IO.File.OpenWrite(filePath)
        Catch ex As Exception
            MsgBox("ERRORE - Impossibiler aprire file di Log", vbOKOnly + vbExclamation)
            Return False
        End Try

        fs.Write(text, 0, text.Length)
        fs.Close()
        fs = Nothing
        
        Return True
    End Function

End Module
