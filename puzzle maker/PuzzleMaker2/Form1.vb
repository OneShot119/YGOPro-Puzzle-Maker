Imports System.Data.SQLite
Public Class Form1
    Dim codeList As New ArrayList()
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim info() As String
        Dim id As String
        Dim Location As String
        Dim posCode As String
        Dim ownerCode As String
        Dim originalOwnerCode As String
        Dim zone As Integer = nUDZone.Value
        ReDim info(5)
        id = getCardID(lstCards.SelectedItem)
        If currentPlayer.Checked Then
            ownerCode = "0"
        Else
            ownerCode = "1"
        End If
        If originalPlayer.Checked Then
            originalOwnerCode = "0"
        Else
            originalOwnerCode = "1"
        End If
        Select Case cmbLocation.SelectedIndex
            Case 0
                Location = "LOCATION_MZONE"
            Case 1
                Location = "LOCATION_SZONE"
            Case 2
                Location = "LOCATION_HAND"
            Case 3
                Location = "LOCATION_DECK"
            Case 4
                Location = "LOCATION_GRAVEYARD"
            Case 5
                Location = "LOCATION_REMOVED"
            Case 6
                Location = "LOCATION_EXTRA"
            Case Else
                Location = ""
        End Select
        If cmbMPos.SelectedIndex = -1 Then
            If cmbSTPos.SelectedIndex = 0 Then
                posCode = "POS_FACEUP"
            Else
                posCode = "POS_FACEDOWN"
            End If
        Else
            If cmbMPos.SelectedIndex = 0 Then
                posCode = "POS_FACEUP_ATTACK"
            Else
                posCode = "POS_FACEDOWN_DEFENCE"
            End If
        End If
        info(0) = id
        info(1) = ownerCode
        info(2) = originalOwnerCode
        info(3) = Location
        info(4) = zone
        info(5) = posCode
        Dim card As New Code(info)
        codeList.Add(card)
        lstEnglish.Items.Clear()

        For i = 0 To codeList.Count - 1
            If Not codeList(i).Equals("") Then
                lstEnglish.Items.Add((i + 1).ToString & " - " & codeList(i).toEnglish().ToString & vbCrLf)
            End If
        Next
        nUDCardSelector.Maximum = codeList.Count
        btnRemove.Enabled = True
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            DisplayCardName(txtSearch.Text)

        Catch ex As Exception

        End Try
    End Sub

    Public Sub DisplayCardName(name As String)
        Dim connectionString As String = "Data Source=cards.cdb"
        Dim dt As DataTable = Nothing
        Dim ds As New DataSet
        Dim cRow As DataRow = Nothing
        Dim mSQL As String = "SELECT * from texts WHERE name like '%" & name & "%';"
        Try
            Using con As New SQLiteConnection(connectionString)
                Using cmd As New SQLiteCommand(mSQL, con)
                    con.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        da.Fill(ds)
                        dt = ds.Tables(0)

                    End Using
                End Using
            End Using
            If dt.Rows IsNot Nothing Then
                lstCards.Items.Clear()
                For Each line In dt.Rows
                    lstCards.Items.Add(getValue(line("name")))
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub
    Public Function getCardID(name As String) As String
        Dim connectionString As String = "Data Source=cards.cdb"
        Dim dt2 As DataTable = Nothing
        Dim ds As New DataSet
        Dim cRow As DataRow = Nothing
        Dim mSQL2 = "SELECT * from texts WHERE name = '" & name & "';"

        Dim id As String = ""
        Try
            Using con As New SQLiteConnection(connectionString)
                Using cmd As New SQLiteCommand(mSQL2, con)
                    con.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        da.Fill(ds)
                        dt2 = ds.Tables(0)

                    End Using
                End Using
            End Using
            If dt2.Rows IsNot Nothing Then
                id = getValue(dt2.Rows(0)("id"))
            End If

        Catch ex As Exception

        End Try
        Return id
    End Function
    Public Function getValue(ByVal dbValue As Object) As Object
        If IsDBNull(dbValue) Then
            Return ""
        Else
            Return dbValue
        End If
    End Function

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub cmbLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLocation.SelectedIndexChanged
        Select Case cmbLocation.SelectedIndex
            Case 0
                nUDZone.Maximum = 5
                cmbSTPos.Enabled = False
                cmbMPos.Enabled = True
                chkSpecialSummon.Enabled = True
            Case 1
                nUDZone.Maximum = 8
                cmbMPos.Enabled = False
                cmbSTPos.Enabled = True
                chkSpecialSummon.Enabled = False
            Case 2
                nUDZone.Maximum = 1
                cmbMPos.Enabled = False
                cmbSTPos.Enabled = True
                chkSpecialSummon.Enabled = False
            Case 3
                nUDZone.Maximum = 1
                cmbMPos.Enabled = False
                cmbSTPos.Enabled = True
                chkSpecialSummon.Enabled = False
            Case 4
                nUDZone.Maximum = 1
                cmbMPos.Enabled = False
                cmbSTPos.Enabled = True
                chkSpecialSummon.Enabled = True
            Case 5
                nUDZone.Maximum = 1
                cmbMPos.Enabled = False
                cmbSTPos.Enabled = True
                chkSpecialSummon.Enabled = False
            Case 6
                nUDZone.Maximum = 1
                cmbMPos.Enabled = False
                cmbSTPos.Enabled = True
                chkSpecialSummon.Enabled = False
            Case Else
                nUDZone.Maximum = 1
                cmbMPos.Enabled = False
                cmbSTPos.Enabled = True
                chkSpecialSummon.Enabled = False
        End Select
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        OpenFileDialog1.ShowDialog()
        If Not OpenFileDialog1.FileName.ToString.Equals("OpenFileDialog1") Then
            ReadPuzzle(OpenFileDialog1.FileName.ToString())
        End If


    End Sub
    Private Sub ReadPuzzle(path As String)
        codeList.Clear()
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader(path)
        Dim stringReader As String
        stringReader = fileReader.ReadLine()
        While stringReader IsNot ""
            If stringReader.Contains("AddCard") Then
                stringReader = stringReader.Substring(stringReader.IndexOf("(") + 1)
                stringReader = stringReader.Remove(stringReader.Length - 1, 1)
                codeList.Add(New Code(stringReader.Split(",")))
            End If
            stringReader = fileReader.ReadLine()
        End While

        For i = 0 To codeList.Count - 1
            If Not codeList(i).Equals("") Then
                lstEnglish.Items.Add((i + 1).ToString & " - " & codeList(i).toEnglish().ToString & vbCrLf)
            End If
        Next
        nUDCardSelector.Maximum = codeList.Count
        btnRemove.Enabled = True
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        codeList.RemoveAt(nUDCardSelector.Value - 1)
        lstEnglish.Items.Clear()
        For i = 0 To codeList.Count - 1
            If Not codeList(i).Equals("") Then
                lstEnglish.Items.Add((i + 1).ToString & " - " & codeList(i).toEnglish().ToString & vbCrLf)
            End If
        Next
        nUDCardSelector.Maximum = codeList.Count
        If codeList.Count = 0 Then
            btnRemove.Enabled = False
        End If
    End Sub
End Class
