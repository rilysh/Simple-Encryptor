

Public Class frmEncryption

    Dim intMaxLength As Integer = 1024
    Dim chrCodeKeyArray(255) As Char
    Dim strKeyFileName As String
    Dim boolMsgFlag As Boolean = False

    Private Sub frmEncryption_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MaximizeBox = False
        txtMessage.MaxLength = intMaxLength
        cmdCreate.Focus()
    End Sub

    Private Sub cmdCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreate.Click
        txtMessage.ReadOnly = False
        txtMessage.BackColor = Color.White
        txtMessage.Clear()
        txtEncoded.Clear()
        txtMessage.Focus()
        cmdLoad.Enabled = False
        cmdCreate.Enabled = False
        cmdCancel.Enabled = True

    End Sub

    Private Sub txtMessage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMessage.TextChanged
        If Len(txtMessage.Text) > 0 And txtMessage.ReadOnly = False Then
            If boolMsgFlag = True Then
                cmdEncrypt.Enabled = True
            End If

        Else
            boolMsgFlag = False
            cmdEncrypt.Enabled = False
        End If

    End Sub

    Private Sub Clear()
        txtMessage.Clear()
        txtEncoded.Clear()
        For i = 0 To Len(chrCodeKeyArray) - 1
            chrCodeKeyArray(i) = ""
        Next
        cmdDecrypt.Enabled = False
        cmdCancel.Enabled = False
        txtMessage.ReadOnly = True
        txtMessage.BackColor = SystemColors.ControlLight
        cmdSave.Enabled = False
        cmdCreate.Enabled = True
        cmdLoad.Enabled = True
        cmdCreate.Focus()
    End Sub


    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Clear()

    End Sub
    Private Function Encode(ByVal InputChar As Char) As Char
        Dim EncodedChar As Char

        If chrCodeKeyArray(Asc(InputChar)) = Nothing Then
            Randomize()
            Do
                EncodedChar = Chr(CInt(255 * Rnd()))
            Loop Until InStr(CStr(chrCodeKeyArray), EncodedChar) = 0
            chrCodeKeyArray(Asc(InputChar)) = EncodedChar
            Return EncodedChar
        Else
            Return chrCodeKeyArray(Asc(InputChar))
        End If
    End Function

    Private Sub cmdEncrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEncrypt.Click
        Dim strTemp As String = ""

        For i = 0 To Len(txtMessage.Text) - 1
            If Asc(txtMessage.Text(i)) > 126 Or Asc(txtMessage.Text(i)) < 32 Then
                strTemp &= Encode(" ")
            Else
                strTemp &= Encode(txtMessage.Text(i))
            End If
        Next
        txtEncoded.Text = strTemp
        cmdEncrypt.Enabled = False
        txtMessage.ReadOnly = True
        txtMessage.BackColor = SystemColors.ControlLight
        cmdSave.Enabled = True
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        sfdEncFile.Filter = "Encrypted Files|*.enc"
        If sfdEncFile.ShowDialog = DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(sfdEncFile.FileName, txtEncoded.Text, False)
            strKeyFileName = Mid(sfdEncFile.FileName, 1, Len(sfdEncFile.FileName) - 4) & ".key"
            My.Computer.FileSystem.WriteAllText(strKeyFileName, chrCodeKeyArray, False)
            Clear()
        End If
    End Sub

    Private Sub cmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoad.Click
        ofdEncFile.Filter = "Encrypted Files|*.enc"
        If ofdEncFile.ShowDialog = DialogResult.OK Then
            txtEncoded.Text = My.Computer.FileSystem.ReadAllText(ofdEncFile.FileName)
            txtMessage.Clear()
            strKeyFileName = Mid(ofdEncFile.FileName, 1, _
              Len(ofdEncFile.FileName) - 4) & ".key"
            chrCodeKeyArray = My.Computer.FileSystem.ReadAllText(strKeyFileName)
            cmdCancel.Enabled = True
            cmdDecrypt.Enabled = True
            cmdCreate.Enabled = False
            cmdLoad.Enabled = False
        End If
    End Sub

    Private Sub cmdDecrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDecrypt.Click
        For i = 0 To Len(txtEncoded.Text) - 1
            txtMessage.Text &= Chr(InStr(chrCodeKeyArray, txtEncoded.Text(i)) - 1)
        Next
        cmdCancel.Enabled = False
        cmdDecrypt.Enabled = False
        cmdCreate.Enabled = True
        cmdLoad.Enabled = True
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        End
    End Sub
End Class
