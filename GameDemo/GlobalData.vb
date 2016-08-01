Module GlobalData
    Private Declare Function ReleaseCapture Lib "user32" () As Integer
    Private Declare Function SendMessageA Lib "user32" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, lParam As VariantType) As Integer

    Public LevelIndex As Char = "3"

    Public Sub MoveWindow(ByVal Handle As IntPtr)
        ReleaseCapture()
        SendMessageA(Handle, &HA1, 2, 0&)
    End Sub
End Module
