<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.BtnOpenDialog = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ofdOpenFile
        '
        Me.ofdOpenFile.FileName = "OpenFileDialog1"
        '
        'BtnOpenDialog
        '
        Me.BtnOpenDialog.Location = New System.Drawing.Point(58, 91)
        Me.BtnOpenDialog.Name = "BtnOpenDialog"
        Me.BtnOpenDialog.Size = New System.Drawing.Size(163, 39)
        Me.BtnOpenDialog.TabIndex = 0
        Me.BtnOpenDialog.Text = "Buka Open Dialog"
        Me.BtnOpenDialog.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.BtnOpenDialog)
        Me.Name = "Form1"
        Me.Text = "Demo OpenFileDialog"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ofdOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BtnOpenDialog As Button
End Class
