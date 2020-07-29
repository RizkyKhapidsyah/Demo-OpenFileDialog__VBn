Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnOpenDialog_Click(sender As Object, e As EventArgs) Handles BtnOpenDialog.Click
        'mengkonfigurasi kotak dialog Open dan menampilkannya dengan 
        With ofdOpenFile
            .Filter = "File teks (*.txt)|*.txt|Semua file (*.*)|*.*"
            .InitialDirectory = "C:\Data"
            .Title = "Pilih File yang Akan Dibuka"

            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                MessageBox.Show(ofdOpenFile.FileName)
            Else
                MessageBox.Show("Anda tidak memilih file apapun.")

            End If
        End With
    End Sub
End Class
