Module MyFunctions
    Function ScriviDb(ByRef tSit, ByRef tSitu, ByRef xls) As Boolean

        '******* Scrittura dati nel DB SQL ************

        'tSitu.Log = Console.Out

        'Se bIsAList è TRUE allora devo ripetere la stessa riga per ogni elemento della lista


        tSit.Anno = xls.xAnno
        tSit.Produttore = xls.xProduttore
        tSit.Equipment = xls.xEquipment
        tSit.SettoreCommerciale = xls.xSettoreCommerciale
        tSit.CanaleDistributivo = xls.xCanaleDistributivo
        tSit.OdV = xls.xOdV
        tSit.CodiceCliente = xls.xCodiceCliente
        tSit.AnagraficaCliente = xls.xAnagraficaCliente
        tSit.Nazione = xls.xNazione
        tSit.Posizione = xls.xPosizione
        tSit.CodiceMateriale = xls.xCodiceMateriale
        tSit.AnagraficaMateriale = xls.xAnagraficaMateriale
        tSit.SituazioneSpedizione = xls.xSituazioneSpedizione
        tSit.DataSpedizione = xls.xDataSpedizione
        tSit.DtSped1 = xls.xDtSped1
        tSit.DtSped2 = xls.xDtSped2
        tSit.Autore = xls.xAutore
        tSit.Note = xls.xNote
        tSit.RifProgramma = xls.xRiferimentoProgramma
        tSit.DataUscita = xls.xDataUscita
        tSit.DataConsegnaPrevista = xls.xDataConsegnaPrevista
        tSit.Studio = xls.xStudio
        tSit.CentroDiCosto = xls.xCdC
        tSit.OdA = xls.xOdA
        tSit.PosizioneOdA = xls.xPosizioneOdA
        tSit.Catalogo = xls.xCatalogo
        tSit.DataArchiviazione = xls.xDataArchiviazione
        tSit.NumeroArchiviazione = xls.xNumeroArchiviazione
        tSit.NumeroArchiviazioneTavole = xls.xNumeroArchiviazioneTavole
        tSit.OreSAP = xls.xOreSap
        tSit.OreDisegno = xls.xOreDisegno
        tSit.CostoFatturato = xls.xCostoFatturato
        tSit.CostoPrevisto = xls.xCostoPreventivato
        tSit.Scostamento = xls.xScostamento
        tSit.NoteAgg = xls.xNoteAgg
        tSit.IsAtm = xls.xIsAtm
        tSit.AtmString = xls.xAtmString
        tSit.IsStringBefore = xls.xIsStringBefore

        tSitu.tSituazione.InsertOnSubmit(tSit)

        Try
            tSitu.SubmitChanges()
        Catch ex As Exception
            MsgBox("CAZZO UNA ECCEZZIONE !!! LINQ->SQL" + vbCrLf + "matricola: " + tSit.Equipment + vbCrLf + vbCrLf + ex.Message)
            Console.WriteLine("********* EXCEPTION ***********" + vbCrLf + ex.Message + vbCrLf + "********* EXCEPTION ***********")
        End Try
        Return 0

    End Function

End Module
