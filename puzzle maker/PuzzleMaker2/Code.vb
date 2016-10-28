Imports System.Data.SQLite
Public Class Code
    Inherits Line
    Private id As String
    Private ownerCode As String
    Private originalOwnerCode As String
    Private location As String
    Private zone As String
    Private pos As String
    Public Sub New(ByVal info As String())
        id = info(0)
        ownerCode = info(1)
        originalOwnerCode = info(2)
        location = info(3)
        zone = info(4)
        pos = info(5)
    End Sub
    Function toEnglish() As English
        Dim english As String()
        ReDim english(5)
        english(0) = getCardName(id)
        If ownerCode = 0 Then
            english(1) = " to Player"
        Else
            english(1) = " to Opponent"
        End If
        If originalOwnerCode = 0 Then
            english(2) = " owned by Player "
        Else
            english(2) = " owned by Opponent "
        End If
        Select Case location
            Case "LOCATION_MZONE"
                english(3) = "Monster Zone"
            Case "LOCATION_SZONE"
                english(3) = "Spell/Trap Zone"
            Case "LOCATION_HAND"
                english(3) = "Hand"
            Case "LOCATION_GRAVE"
                english(3) = "Graveyard"
            Case "LOCATION_DECK"
                english(3) = "Deck"
            Case "LOCATION_EXTRA"
                english(3) = "Extra Deck"
            Case "LOCATION_REMOVED"
                english(3) = "Banished Zone"
            Case Else
                location = "null"
        End Select
        english(4) = zone
        Select Case pos
            Case "POS_FACEUP"
                english(5) = "Face-Up"
            Case "POS_FACEDOWN"
                english(5) = "Face-Down"
            Case "POS_FACEDOWN_DEFENCE"
                english(5) = "Face-Down Defense"
            Case "POS_FACEUP_ATTACK"
                english(5) = "Face-Up Attack"
            Case Else
                english(5) = "null"
        End Select
        Return New English(english)
    End Function
    Public Overrides Function toString() As String
        Return "Debug.AddCard(" + id + "," + ownerCode + "," + originalOwnerCode + "," + location + "," + zone + "," + pos + ")"
    End Function
    Public Function getCardName(id As String) As String
        Dim connectionString As String = "Data Source=cards.cdb"
        Dim dt2 As DataTable = Nothing
        Dim ds As New DataSet
        Dim cRow As DataRow = Nothing
        Dim mSQL2 = "SELECT * from texts WHERE id = '" & id & "';"

        Dim name As String = ""
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
                name = Form1.getValue(dt2.Rows(0)("name"))
            End If

        Catch ex As Exception

        End Try
        Return name
    End Function
End Class
