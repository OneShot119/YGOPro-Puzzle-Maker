Imports System.Data.SQLite
Public Class Code
    Inherits Line
    Private id As String
    Private ownerCode As String
    Private originalOwnerCode As String
    Private location As String
    Private zone As String
    Private pos As String
    Private special As Boolean
    Private specialNumber As Integer
    Public Sub New(ByVal info As String())
        id = info(0)
        ownerCode = info(1)
        originalOwnerCode = info(2)
        location = info(3)
        zone = info(4)
        pos = info(5)
        If (info(6).Equals("")) Then
            special = False
        Else
            special = True
            specialNumber = Integer.Parse(info(6))
        End If
    End Sub
    Function toEnglish() As English
        Dim english As String()
        Dim name As String = Form1.getCardName(id)
        ReDim english(6)
        If name = "" Then
            name = "ERROR: Card not found."
        End If
        english(0) = name
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
        If special Then
            english(6) = True
        Else
            english(6) = False
        End If
        Return New English(english)
    End Function
    Public Overrides Function toString() As String
        Dim text As String = ""
        If special Then
            text += "local c" + specialNumber.ToString + " ="
            text += "Debug.AddCard(" + id.ToString + "," + ownerCode.ToString + "," + originalOwnerCode.ToString + "," + location.ToString + "," + zone.ToString + "," + pos.ToString + ")"
            text += vbCrLf + "c" + specialNumber.ToString + ":CompleteProcedure()"
        Else
            text += "Debug.AddCard(" + id.ToString + "," + ownerCode.ToString + "," + originalOwnerCode.ToString + "," + location.ToString + "," + zone.ToString + "," + pos.ToString + ")"
        End If

        Return text
    End Function
End Class
