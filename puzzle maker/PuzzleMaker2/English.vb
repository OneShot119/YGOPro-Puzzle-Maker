Public Class English
    Inherits Line
    Private id As String
    Private ownerCode As String
    Private originalOwnerCode As String
    Private location As String
    Private zone As String
    Private pos As String
    Private special As Boolean
    Public Sub New(ByVal info As String())
        id = info(0)
        ownerCode = info(1)
        originalOwnerCode = info(2)
        location = info(3)
        zone = info(4)
        pos = info(5)
        special = info(6)
    End Sub
    Public Overrides Function toString() As String
        Dim text As String
        If id.Contains("ERROR:") Then
            text = id
        Else
            If special Then
                text = "SPECIAL: " + id + ownerCode + originalOwnerCode + "in " + location + " " + zone + " in " + pos + " postion."
            Else
                text = id + ownerCode + originalOwnerCode + "in " + location + " " + zone + " in " + pos + " postion."
            End If

        End If
        Return text
    End Function
End Class
