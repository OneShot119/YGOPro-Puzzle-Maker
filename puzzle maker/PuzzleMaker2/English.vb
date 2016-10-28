Public Class English
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
    Public Overrides Function toString() As String
        Return id + ownerCode + originalOwnerCode + "in " + location + " " + zone + " in " + pos + " postion."
    End Function
End Class
