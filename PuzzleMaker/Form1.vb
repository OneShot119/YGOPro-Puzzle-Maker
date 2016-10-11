Imports System.Data.SqlClient

Public Class PuzzleMaker
    Dim codeList As New ArrayList()
    Dim cardList As New ArrayList()
    Dim specialCounter As Integer = 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim id As String = txtSearch.Text
        Dim ownerCode As String
        Dim originalOwnerCode As String
        Dim location As String
        Dim zone As Integer = nUDZone.Value
        Dim posCode As String
        Dim pos As String
        Dim code As String

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
                location = "LOCATION_MZONE"
            Case 1
                location = "LOCATION_SZONE"
            Case 2
                location = "LOCATION_HAND"
            Case 3
                location = "LOCATION_DECK"
            Case 4
                location = "LOCATION_GRAVEYARD"
            Case 5
                location = "LOCATION_REMOVED"
            Case 6
                location = "LOCATION_EXTRA"
            Case Else
                location = ""
        End Select

        If cmbMPos.SelectedIndex = -1 Then
            If cmbSTPos.SelectedIndex = 0 Then
                posCode = "POS_FACEUP"
                pos = "Face-Up"
            Else
                posCode = "POS_FACEDOWN"
                pos = "Face-Down"
            End If
        Else
            If cmbMPos.SelectedIndex = 0 Then
                posCode = "POS_FACEUP_ATTACK"
                pos = "Face-Up Attack"
            Else
                posCode = "POS_FACEDOWN_DEFENCE"
                pos = "Face-Down Defense"
            End If
        End If
        If chkSpecialSummon.Checked Then
            code = "g" + specialCounter.ToString + "=Debug.AddCard(" + id + "," + ownerCode + "," + originalOwnerCode + "," + location + "," + (zone - 1).ToString + "," + posCode + ")"
        Else
            code = "Debug.AddCard(" + id + "," + ownerCode + "," + originalOwnerCode + "," + location + "," + (zone - 1).ToString + "," + posCode + ")"

        End If
        codeList.Add(code)
        If Not code.Contains("CompleteProcedure") Then
            cardList.Add(code)
        End If
        txtEnglish.Clear()

        For i = 0 To cardList.Count - 1
            If Not cardList(i).Equals("") Then
                txtEnglish.AppendText((i + 1).ToString & " - " & CodeToEnglish(cardList(i)) & vbCrLf)
            End If
        Next



        If chkSpecialSummon.Checked Then
            codeList.Add("g" + specialCounter.ToString + ":CompleteProcedure()")
            specialCounter += 1
        End If
        nUDCardSelector.Maximum += 1
        If nUDCardSelector.Minimum.Equals(0) Then
            btnRemove.Enabled = True
            nUDCardSelector.Minimum += 1
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLocation.SelectedIndexChanged
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnView.Click
        For Each line As String In codeList
            Form2.TextBox1.AppendText(line & vbCrLf)
        Next
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Text = ""
        currentPlayer.Checked = True
        cmbLocation.ResetText()
        cmbMPos.ResetText()
        cmbSTPos.ResetText()
        nUDZone.Value = 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtEnglish.Text = ""
        codeList.Clear()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnPublish.Click
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\puzzle.txt"
        Dim pLP As Integer
        Dim oLP As Integer
        If My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\puzzle.lua") Then
            If MsgBox("File already exists, overwrite?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                My.Computer.FileSystem.DeleteFile(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\puzzle.lua")
                pLP = InputBox("Player Life Points?", "Life Points", 8000)
                oLP = InputBox("Opponent Life Points?", "Life Points", 8000)
                My.Computer.FileSystem.WriteAllText(path, "Debug.SetAIName(""Ｚ-ＯＮＥ"")" & vbCrLf, True)
                My.Computer.FileSystem.WriteAllText(path, "Debug.ReloadFieldBegin(DUEL_ATTACK_FIRST_TURN+DUEL_SIMPLE_AI)" & vbCrLf, True)
                My.Computer.FileSystem.WriteAllText(path, "Debug.SetPlayerInfo(0," & pLP & ",0,0)" & vbCrLf, True)
                My.Computer.FileSystem.WriteAllText(path, "Debug.SetPlayerInfo(0," & oLP & ",0,0)" & vbCrLf, True)
                For Each line In codeList
                    My.Computer.FileSystem.WriteAllText(path, line & vbCrLf, True)
                Next
                My.Computer.FileSystem.WriteAllText(path, "Debug.ReloadFieldEnd()" & vbCrLf, True)
                My.Computer.FileSystem.WriteAllText(path, "aux.BeginPuzzle()" & vbCrLf, True)
                My.Computer.FileSystem.RenameFile(path, "puzzle.lua")
            End If
        Else
            pLP = InputBox("Player Life Points?", "Life Points", 8000)
            oLP = InputBox("Opponent Life Points?", "Life Points", 8000)
            My.Computer.FileSystem.WriteAllText(path, "Debug.SetAIName(""Ｚ-ＯＮＥ"")" & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText(path, "Debug.ReloadFieldBegin(DUEL_ATTACK_FIRST_TURN+DUEL_SIMPLE_AI)" & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText(path, "Debug.SetPlayerInfo(0," & pLP & ",0,0)" & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText(path, "Debug.SetPlayerInfo(0," & oLP & ",0,0)" & vbCrLf, True)
            For Each line In codeList
                My.Computer.FileSystem.WriteAllText(path, line & vbCrLf, True)
            Next
            My.Computer.FileSystem.WriteAllText(path, "Debug.ReloadFieldEnd()" & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText(path, "aux.BeginPuzzle()" & vbCrLf, True)
            My.Computer.FileSystem.RenameFile(path, "puzzle.lua")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        cardList.RemoveAt(nUDCardSelector.Value - 1)
        txtEnglish.Clear()
        For i = 0 To cardList.Count - 1
            If Not cardList(i).Equals("") Then
                txtEnglish.AppendText((i + 1).ToString & " - " & CodeToEnglish(cardList(i)) & vbCrLf)
            End If
        Next
        nUDCardSelector.Maximum -= 1
    End Sub
    Private Function CodeToEnglish(code As String)
        Dim English As String = ""
        Dim codeBits As String()
        Dim Location As String = "null"
        Dim position As String = "null"
        code = code.Substring(code.IndexOf("(") + 1)
        codeBits = code.Split(",")
        English += codeBits(0)
        If codeBits(1).Equals("0") Then
            English += " to User"
        Else
            English += " to Opponent"
        End If
        If codeBits(2).Equals("0") Then
            English += " owned by User "
        Else
            English += " owned by Opponent "
        End If
        Select Case codeBits(3)
            Case "LOCATION_MZONE"
                Location = "Monster Zone"
            Case "LOCATION_SZONE"
                Location = "Spell/Trap Zone"
            Case "LOCATION_HAND"
                Location = "Hand"
            Case "LOCATION_GRAVE"
                Location = "Graveyard"
            Case "LOCATION_DECK"
                Location = "Deck"
            Case "LOCATION_EXTRA"
                Location = "Extra Deck"
            Case "LOCATION_REMOVED"
                Location = "Banished Zone"
            Case Else
                Location = "null"
        End Select
        English += "in " & Location & " spot " & codeBits(4) & " in "
        Select Case codeBits(5)
            Case "POS_FACEUP)"
                position = "Face-Up"
            Case "POS_FACEDOWN)"
                position = "Face-Down"
            Case "POS_FACEDOWN_DEFENCE)"
                position = "Face-Down Defense"
            Case "POS_FACEUP_ATTACK)"
                position = "Face-Up Attack"
            Case Else
                position = "null"
        End Select
        English += position & " position."
        Return English
    End Function

    Private Sub ReadPuzzle(path As String)
        codeList.Clear()
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader(path)
        Dim stringReader As String
        stringReader = fileReader.ReadLine()
        While stringReader IsNot ""
            If Not (stringReader.StartsWith("--") Or stringReader.StartsWith("Debug.SetAIName") Or stringReader.StartsWith("Debug.ReloadFieldBegin") Or stringReader.StartsWith("Debug.SetPlayerInfo") Or stringReader.StartsWith("Debug.SetPlayerInfo") Or stringReader.StartsWith("Debug.ReloadFieldEnd") Or stringReader.StartsWith("aux.BeginPuzzle")) Then
                codeList.Add(stringReader)
                If Not stringReader.Contains("CompleteProcedure") Then
                    cardList.Add(stringReader)
                End If
            End If
            stringReader = fileReader.ReadLine()
        End While
        For i = 0 To cardList.Count - 1
            If Not cardList(i).Equals("") Then
                txtEnglish.AppendText((i + 1).ToString & " - " & CodeToEnglish(cardList(i)) & vbCrLf)
            End If
        Next
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        codeList.Clear()
        cardList.Clear()
        OpenFileDialog1.ShowDialog()
        If Not OpenFileDialog1.FileName.ToString.Equals("OpenFileDialog1") Then
            ReadPuzzle(OpenFileDialog1.FileName.ToString())
        End If


    End Sub
End Class
