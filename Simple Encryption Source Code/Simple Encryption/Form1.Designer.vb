<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEncryption
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEncryption))
        Me.txtMessage = New System.Windows.Forms.TextBox
        Me.txtEncoded = New System.Windows.Forms.TextBox
        Me.cmdCreate = New System.Windows.Forms.Button
        Me.cmdLoad = New System.Windows.Forms.Button
        Me.cmdEncrypt = New System.Windows.Forms.Button
        Me.cmdDecrypt = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.sfdEncFile = New System.Windows.Forms.SaveFileDialog
        Me.ofdEncFile = New System.Windows.Forms.OpenFileDialog
        Me.SuspendLayout()
        '
        'txtMessage
        '
        Me.txtMessage.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtMessage.Location = New System.Drawing.Point(10, 10)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(600, 200)
        Me.txtMessage.TabIndex = 0
        '
        'txtEncoded
        '
        Me.txtEncoded.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEncoded.Location = New System.Drawing.Point(10, 240)
        Me.txtEncoded.Multiline = True
        Me.txtEncoded.Name = "txtEncoded"
        Me.txtEncoded.Size = New System.Drawing.Size(600, 200)
        Me.txtEncoded.TabIndex = 1
        '
        'cmdCreate
        '
        Me.cmdCreate.Location = New System.Drawing.Point(10, 450)
        Me.cmdCreate.Name = "cmdCreate"
        Me.cmdCreate.Size = New System.Drawing.Size(100, 23)
        Me.cmdCreate.TabIndex = 2
        Me.cmdCreate.Text = "Create Message"
        Me.cmdCreate.UseVisualStyleBackColor = True
        '
        'cmdLoad
        '
        Me.cmdLoad.Location = New System.Drawing.Point(133, 450)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(100, 23)
        Me.cmdLoad.TabIndex = 3
        Me.cmdLoad.Text = "Load File"
        Me.cmdLoad.UseVisualStyleBackColor = True
        '
        'cmdEncrypt
        '
        Me.cmdEncrypt.Location = New System.Drawing.Point(10, 479)
        Me.cmdEncrypt.Name = "cmdEncrypt"
        Me.cmdEncrypt.Size = New System.Drawing.Size(100, 23)
        Me.cmdEncrypt.TabIndex = 4
        Me.cmdEncrypt.Text = "Encrypt"
        Me.cmdEncrypt.UseVisualStyleBackColor = True
        '
        'cmdDecrypt
        '
        Me.cmdDecrypt.Location = New System.Drawing.Point(133, 479)
        Me.cmdDecrypt.Name = "cmdDecrypt"
        Me.cmdDecrypt.Size = New System.Drawing.Size(100, 23)
        Me.cmdDecrypt.TabIndex = 5
        Me.cmdDecrypt.Text = "Decrypt"
        Me.cmdDecrypt.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(10, 508)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(100, 23)
        Me.cmdSave.TabIndex = 6
        Me.cmdSave.Text = "Save to File"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(133, 508)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(100, 23)
        Me.cmdCancel.TabIndex = 7
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.ForeColor = System.Drawing.Color.Red
        Me.cmdExit.Location = New System.Drawing.Point(535, 508)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 8
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'ofdEncFile
        '
        Me.ofdEncFile.FileName = "OpenFileDialog1"
        '
        'frmEncryption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(624, 542)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdDecrypt)
        Me.Controls.Add(Me.cmdEncrypt)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.cmdCreate)
        Me.Controls.Add(Me.txtEncoded)
        Me.Controls.Add(Me.txtMessage)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEncryption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simple Encryptor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents txtEncoded As System.Windows.Forms.TextBox
    Friend WithEvents cmdCreate As System.Windows.Forms.Button
    Friend WithEvents cmdLoad As System.Windows.Forms.Button
    Friend WithEvents cmdEncrypt As System.Windows.Forms.Button
    Friend WithEvents cmdDecrypt As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents sfdEncFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ofdEncFile As System.Windows.Forms.OpenFileDialog

End Class
