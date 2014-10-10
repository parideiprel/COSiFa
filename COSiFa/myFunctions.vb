Imports System.IO
Imports System.Text

Module MyFunctions
    Function ScriviDb(ByRef tSitu, ByRef xls, ByRef currentIndex, ByRef count) As Boolean

        '******* Scrittura dati nel DB SQL ************
        Dim tw As StreamWriter = New StreamWriter("c:\temp\LinQLOG.txt", True)
        'tSitu.Log = Console.Out
        tSitu.Log = tw  'redireziono il log del DataContext verso uno stream su file


        'Se bIsAList è TRUE allora devo ripetere la stessa riga per ogni elemento della lista


        tSitu.tSituazione.InsertOnSubmit(ImpostaDati(xls))

        Try
            tSitu.SubmitChanges()

        Catch ex As Exception
            WriteToLog("c:\temp\Exception.txt", "CAZZO UNA ECCEZZIONE !!! LINQ->SQL" + vbCrLf + "matricola: " + ImpostaDati(xls).Equipment + vbCrLf + vbCrLf + ex.Message + vbCrLf + "********************************************************************************************************")
            'MsgBox("CAZZO UNA ECCEZZIONE !!! LINQ->SQL" + vbCrLf + "matricola: " + ImpostaDati(xls).Equipment + vbCrLf + vbCrLf + ex.Message)
            'Console.WriteLine("********* EXCEPTION ***********" + vbCrLf + ex.Message + vbCrLf + "********* EXCEPTION ***********")
        End Try
        tw.Flush()
        tw.Close()
        tw = Nothing

        Return 0

    End Function

    Private Function ImpostaDati(ByRef xls) As tSituazione

        Dim tSit = New tSituazione()

        Try
            tSit.Anno = xls.xAnno
            'If Len(tSit.Anno) <> Len(xls.xAnno) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [Anno] - tSit=" + Len(tSit.Anno).ToString() + " / xls=" + Len(xls.xAnno).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [Anno] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.Anno.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.Produttore = xls.xProduttore
            'If Len(tSit.Produttore) <> Len(xls.xProduttore) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [Produttore] - tSit=" + Len(tSit.Produttore).ToString() + " / xls=" + Len(xls.xProduttore).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [Produttore] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.Produttore)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.Equipment = xls.xEquipment
            'If Len(tSit.Equipment) <> Len(xls.xEquipment) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [Equipment] - tSit=" + Len(tSit.Equipment).ToString() + " / xls=" + Len(xls.xEquipment).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [Equipment] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.Equipment)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.SettoreCommerciale = xls.xSettoreCommerciale
            'If Len(tSit.SettoreCommerciale) <> Len(xls.xSettoreCommerciale) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [SettoreCommerciale] - tSit=" + Len(tSit.SettoreCommerciale).ToString() + " / xls=" + Len(xls.xSettoreCommerciale).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [SettoreCommerciale] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.SettoreCommerciale)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.CanaleDistributivo = xls.xCanaleDistributivo
            'If Len(tSit.CanaleDistributivo) <> Len(xls.xCanaleDistributivo) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [CanaleDistributivo] - tSit=" + Len(tSit.CanaleDistributivo).ToString() + " / xls=" + Len(xls.xCanaleDistributivo).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [CanaleDistributivo] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.CanaleDistributivo)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.OdV = xls.xOdV
            'If Len(tSit.OdV) <> Len(xls.xAnno) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [OdV] - tSit=" + Len(tSit.OdV).ToString() + " / xls=" + Len(xls.xAnno).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [OdV] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.OdV)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.CodiceCliente = xls.xCodiceCliente
            'If Len(tSit.CodiceCliente) <> Len(xls.xCodiceCliente) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [CodiceCliente] - tSit=" + Len(tSit.CodiceCliente).ToString() + " / xls=" + Len(xls.xCodiceCliente).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [CodiceCliente] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.CodiceCliente)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.AnagraficaCliente = xls.xAnagraficaCliente
            'If Len(tSit.AnagraficaCliente) <> Len(xls.xAnagraficaCliente) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [AnagraficaCliente] - tSit=" + Len(tSit.AnagraficaCliente).ToString() + " / xls=" + Len(xls.xAnagraficaCliente).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [AnagraficaCliente] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.AnagraficaCliente)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.Nazione = xls.xNazione
            'If Len(tSit.Nazione) <> Len(xls.xNazione) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [Nazione] - tSit=" + Len(tSit.Nazione).ToString() + " / xls=" + Len(xls.xNazione).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [Nazione] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.Nazione)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.Posizione = xls.xPosizione
            'If Len(tSit.Posizione) <> Len(xls.xPosizione) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [Posizione] - tSit=" + Len(tSit.Posizione).ToString() + " / xls=" + Len(xls.xPosizione).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [Posizione] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.Posizione.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.CodiceMateriale = xls.xCodiceMateriale
            'If Len(tSit.CodiceMateriale) <> Len(xls.xCodiceMateriale) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [CodiceMateriale] - tSit=" + Len(tSit.CodiceMateriale).ToString() + " / xls=" + Len(xls.xCodiceMateriale).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [CodiceMateriale] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.CodiceMateriale)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.AnagraficaMateriale = xls.xAnagraficaMateriale
            'If Len(tSit.AnagraficaMateriale) <> Len(xls.xAnagraficaMateriale) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [AnagraficaMateriale] - tSit=" + Len(tSit.AnagraficaMateriale).ToString() + " / xls=" + Len(xls.xAnagraficaMateriale).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [AnagraficaMateriale] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.AnagraficaMateriale)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.SituazioneSpedizione = xls.xSituazioneSpedizione
            'If Len(tSit.SituazioneSpedizione) <> Len(xls.xSituazioneSpedizione) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [SituazioneSpedizione] - tSit=" + Len(tSit.SituazioneSpedizione).ToString() + " / xls=" + Len(xls.xSituazioneSpedizione).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [SituazioneSpedizione] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.SituazioneSpedizione)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.DataSpedizione = xls.xDataSpedizione
            'If Len(tSit.DataSpedizione) <> Len(xls.xDataSpedizione) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [DataSpedizione] - tSit=" + Len(tSit.DataSpedizione).ToString() + " / xls=" + Len(xls.xDataSpedizione).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [DataSpedizione] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.DataSpedizione.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.DtSped1 = xls.xDtSped1
            'If Len(tSit.DtSped1) <> Len(xls.xDtSped1) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [DtSped1] - tSit=" + Len(tSit.DtSped1).ToString() + " / xls=" + Len(xls.xDtSped1).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [DtSped1] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.DtSped1.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.DtSped2 = xls.xDtSped2
            'If Len(tSit.DtSped2) <> Len(xls.xDtSped2) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [DtSped2] - tSit=" + Len(tSit.DtSped2).ToString() + " / xls=" + Len(xls.xDtSped2).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [DtSped2] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.DtSped2.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.Autore = xls.xAutore
            'If Len(tSit.Autore) <> Len(xls.xAutore) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [Autore] - tSit=" + Len(tSit.Autore).ToString() + " / xls=" + Len(xls.xAutore).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [Autore] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.Autore)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.Note = xls.xNote
            'If Len(tSit.Note) <> Len(xls.xNote) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [Note] - tSit=" + Len(tSit.Note).ToString() + " / xls=" + Len(xls.xNote).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [Note] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.Note)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.RifProgramma = xls.xRiferimentoProgramma
            'If Len(tSit.RifProgramma) <> Len(xls.xRiferimentoProgramma) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [RifProgramma] - tSit=" + Len(tSit.RifProgramma).ToString() + " / xls=" + Len(xls.xRiferimentoProgramma).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [RifProgramma] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.RifProgramma)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.DataUscita = xls.xDataUscita
            'If Len(tSit.DataUscita) <> Len(xls.xDataUscita) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [DataUscita] - tSit=" + Len(tSit.DataUscita).ToString() + " / xls=" + Len(xls.xDataUscita).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [DataUscita] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.DataUscita.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.DataConsegnaPrevista = xls.xDataConsegnaPrevista
            'If Len(tSit.DataConsegnaPrevista) <> Len(xls.xDataConsegnaPrevista) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [DataConsegnaPrevista] - tSit=" + Len(tSit.DataConsegnaPrevista).ToString() + " / xls=" + Len(xls.xDataConsegnaPrevista).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [DataConsegnaPrevista] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.DataConsegnaPrevista.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.Studio = xls.xStudio
            'If Len(tSit.Studio) <> Len(xls.xStudio) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [Studio] - tSit=" + Len(tSit.Studio).ToString() + " / xls=" + Len(xls.xStudio).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [Studio] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.Studio)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.CentroDiCosto = xls.xCdC
            'If Len(tSit.CentroDiCosto) <> Len(xls.xCdC) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [CentroDiCosto] - tSit=" + Len(tSit.CentroDiCosto).ToString() + " / xls=" + Len(xls.xCdC).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [CentroDiCosto] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.CentroDiCosto)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.OdA = xls.xOdA
            'If Len(tSit.OdA) <> Len(xls.xOdA) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [OdA] - tSit=" + Len(tSit.OdA).ToString() + " / xls=" + Len(xls.xOdA).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [OdA] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.OdA)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.PosizioneOdA = xls.xPosizioneOdA
            'If Len(tSit.PosizioneOdA) <> Len(xls.xPosizioneOdA) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [PosizioneOdA] - tSit=" + Len(tSit.PosizioneOdA).ToString() + " / xls=" + Len(xls.xPosizioneOdA).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [PosizioneOdA] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.PosizioneOdA)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.Catalogo = xls.xCatalogo
            'If Len(tSit.Catalogo) <> Len(xls.xCatalogo) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [Catalogo] - tSit=" + Len(tSit.Catalogo).ToString() + " / xls=" + Len(xls.xCatalogo).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [Catalogo] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.Catalogo)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.DataArchiviazione = xls.xDataArchiviazione
            'If Len(tSit.DataArchiviazione) <> Len(xls.xDataArchiviazione) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [DataArchiviazione] - tSit=" + Len(tSit.DataArchiviazione).ToString() + " / xls=" + Len(xls.xDataArchiviazione).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [DataArchiviazione] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.DataArchiviazione.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.NumeroArchiviazione = xls.xNumeroArchiviazione
            'If Len(tSit.NumeroArchiviazione) <> Len(xls.xNumeroArchiviazione) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [NumeroArchiviazione] - tSit=" + Len(tSit.NumeroArchiviazione).ToString() + " / xls=" + Len(xls.xNumeroArchiviazione).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [NumeroArchiviazione] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.NumeroArchiviazione)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.NumeroArchiviazioneTavole = xls.xNumeroArchiviazioneTavole
            'If Len(tSit.NumeroArchiviazioneTavole) <> Len(xls.xNumeroArchiviazioneTavole) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [NumeroArchiviazioneTavole] - tSit=" + Len(tSit.NumeroArchiviazioneTavole).ToString() + " / xls=" + Len(xls.xNumeroArchiviazioneTavole).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [NumeroArchiviazioneTavole] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.NumeroArchiviazioneTavole)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            If xls.xOreSap = 0 Then
                tSit.OreSAP = 0
            Else
                tSit.OreSAP = xls.xOreSap
                'If Len(tSit.OreSAP) <> Len(xls.xOreSap) Then
                '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [OreSAP] - tSit=" + Len(tSit.OreSAP).ToString() + " / xls=" + Len(xls.xOreSap).ToString())
                'End If
            End If

        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [OreSAP] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.OreSAP.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            If xls.xOreDisegno = 0 Then
                tSit.OreDisegno = 0
            Else
                tSit.OreDisegno = xls.xOreDisegno
                'If Len(tSit.OreDisegno) <> Len(xls.xOreDisegno) Then
                '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [OreDisegno] - tSit=" + Len(tSit.OreDisegno).ToString() + " / xls=" + Len(xls.xOreDisegno).ToString())
                'End If
            End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [OreDisegno] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.OreDisegno.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            If xls.xCostoFatturato = 0 Then
                tSit.CostoFatturato = 0
            Else
                tSit.CostoFatturato = xls.xCostoFatturato
                'If Len(tSit.CostoFatturato) <> Len(xls.xCostoFatturato) Then
                '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [CostoFatturato] - tSit=" + Len(tSit.CostoFatturato).ToString() + " / xls=" + Len(xls.xCostoFatturato).ToString())
                'End If
            End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [CostoFatturato] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.CostoFatturato.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            If xls.xCostoPreventivato = 0 Then
                tSit.CostoPrevisto = 0
            Else
                tSit.CostoPrevisto = xls.xCostoPreventivato
                'If Len(tSit.CostoPrevisto) <> Len(xls.xCostoPreventivato) Then
                '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [CostoPrevisto] - tSit=" + Len(tSit.CostoPrevisto).ToString() + " / xls=" + Len(xls.xCostoPreventivato).ToString())
                'End If
            End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [CostoPrevisto] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.CostoPrevisto.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            If xls.xScostamento = 0 Then
                tSit.Scostamento = 0
            Else
                tSit.Scostamento = xls.xScostamento
                'If Len(tSit.Scostamento) <> Len(xls.xScostamento) Then
                '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [Scostamento] - tSit=" + Len(tSit.Scostamento).ToString() + " / xls=" + Len(xls.xScostamento).ToString())
                'End If
            End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [Scostamento] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.Scostamento.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.NoteAgg = xls.xNoteAgg
            'If Len(tSit.NoteAgg) <> Len(xls.xNoteAgg) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [NoteAgg] - tSit=" + Len(tSit.NoteAgg).ToString() + " / xls=" + Len(xls.xNoteAgg).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [NoteAgg] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.NoteAgg)
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.IsAtm = xls.xIsAtm
            'If Len(tSit.IsAtm) <> Len(xls.xIsAtm) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [IsAtm] - tSit=" + Len(tSit.IsAtm).ToString() + " / xls=" + Len(xls.xIsAtm).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [IsAtm] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.IsAtm.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.AtmString = xls.xAtmString
            'If Len(tSit.AtmString) <> Len(xls.xAtmString) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [AtmString] - tSit=" + Len(tSit.AtmString).ToString() + " / xls=" + Len(xls.xAtmString).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [AtmString] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.AtmString.ToString())
            tSit.HasException = True
        End Try
        '-----------------------------------------------------------------
        Try
            tSit.IsStringBefore = xls.xIsStringBefore
            'If Len(tSit.IsStringBefore) <> Len(xls.xIsStringBefore) Then
            '    WriteToLog("c:\temp\import.txt", "ERRORE Dimensione [IsStringBefore] - tSit=" + Len(tSit.IsStringBefore).ToString() + " / xls=" + Len(xls.xIsStringBefore).ToString())
            'End If
        Catch ex As Exception
            WriteToLog("c:\temp\import.txt", "ERRORE Import [IsStringBefore] - " + ex.Message + vbCrLf + "Valore campo: " + tSit.IsStringBefore.ToString())
            tSit.HasException = True
        End Try

        Return tSit
    End Function

    Private Function WriteToLog(filePath As String, message As String) As Boolean
        'funzione di scrittura su LogFile
        Dim fs As FileStream
        Dim text As Byte() = New UTF8Encoding(True).GetBytes(message + vbCrLf)

        Try
            fs = System.IO.File.Open(filePath, FileMode.Append, FileAccess.Write, FileShare.Read)
        Catch ex As Exception
            MsgBox("ERRORE - Impossibile aprire file di Log" + vbCrLf + vbCrLf + "-----------------------------" + vbCrLf + ex.Message, vbOKOnly + vbExclamation)
            Return False
        End Try

        fs.Write(text, 0, text.Length)
        fs.Close()
        fs = Nothing

        Return True
    End Function

    Function ControllaData(ByRef xlRange, ByRef riga, ByRef colonna) As DateTime
        Dim ciccio As DateTime
        Dim paperino As String
        Dim gma(3) As String
        Dim conta1 As Integer = 0

        paperino = xlRange.Cells(riga, colonna).value
        'xls.XDataSpedizione = xlRange.Cells(riga, 14).value
        Try
            ciccio = Convert.ToDateTime(paperino)
        Catch ex As Exception
            For Each p As String In paperino.ToList()
                Select Case Asc(p)
                    Case 65 To 90, 97 To 122
                        'è una lettera quindi aumento contatore
                        conta1 += 1
                End Select
            Next
            If conta1 <= Len(paperino) Then
                'è tutto stringa, imposto il default ed esco
                ciccio = Convert.ToDateTime("31/12/9999")
                Return ciccio

            End If
            If paperino IsNot Nothing Then


                If InStr(paperino, ".", CompareMethod.Text) > 0 Then
                    paperino = Replace(xlRange.Cells(riga, colonna).value, ".", "/", , , CompareMethod.Text)
                Else
                    If InStr(paperino, "-", CompareMethod.Text) > 0 Then
                        paperino = Replace(xlRange.Cells(riga, 14).value, "-", "/", , , CompareMethod.Text)
                    End If
                End If

                gma = Split(paperino, "/")


                Select Case Val(gma(1))
                    Case 11, 4, 6, 9
                        If Val(gma(0)) > 30 Then
                            gma(0) = InputBox("Un mese con più di 30gg non esiste... Dammi il giorno corretto per la data: " + paperino, "ERRORE Valori data", "30").Trim()
                        End If

                    Case 2
                        If Val(gma(0)) > 28 Then
                            'se ha più di 28gg verifico se è bisestile
                            If DateTime.IsLeapYear(Val(gma(2))) = False Then
                                gma(0) = InputBox("Febbraio " + gma(2) + " NON E' bisestile... Dammi il giorno corretto per la data: " + paperino, "ERRORE Valori data", "28").Trim()
                            Else
                                If Val(gma(0)) > 29 Then
                                    gma(0) = InputBox("Un mese BISESTILE più di 29gg non esiste... Dammi il giorno corretto per la data: " + paperino, "ERRORE Valori data", "29").Trim()
                                End If
                            End If
                        End If

                    Case 1, 3, 5, 7, 8, 10, 12
                        If Val(gma(0)) > 31 Then
                            gma(0) = InputBox("Un mese con più di 31gg non esiste... Dammi il giorno corretto per la data: " + paperino, "ERRORE Valori data", "31")
                        End If

                End Select

                paperino = Join(gma, "/")
            End If
            Try
                ciccio = Convert.ToDateTime(paperino)
            Catch ex3 As Exception
                WriteToLog("c:\temp\Import.txt", "Errore dati cella:" + vbCrLf + vbCrLf + "Valore cella = " + xlRange.Cells(riga, colonna).value.ToString() + vbCrLf + "Riga = " + riga + 1)
                'MsgBox("Errore dati cella:" + vbCrLf + vbCrLf + "Valore cella = " + xlRange.Cells(riga, colonna).value.ToString() + vbCrLf + "Riga = " + riga + 1)
                ciccio = Convert.ToDateTime("31/12/9999")
            End Try

            Return ciccio
        End Try
        Return ciccio
    End Function

End Module
