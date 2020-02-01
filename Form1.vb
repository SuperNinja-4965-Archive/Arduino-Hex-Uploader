Imports MaterialSkin
Public Class Form1

    Dim AModel As ArduinoUploader.Hardware.ArduinoModel

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.Purple200, TextShade.WHITE)
        GetCOMPorts()
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub UploadHex_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles UploadHex.DoWork
        Dim uploader As New ArduinoUploader.ArduinoSketchUploader(New ArduinoUploader.ArduinoSketchUploaderOptions() With {
                                                                  .FileName = SelectedFile.Text,
                                                                  .PortName = comPorts.SelectedItem,
                                                                  .ArduinoModel = AModel
                                                                  })
        uploader.UploadSketch()
    End Sub

    Private Sub OpenButton_Click(sender As Object, e As EventArgs) Handles OpenButton.Click
        If SketchLocation.ShowDialog = DialogResult.OK Then
            SelectedFile.Text = SketchLocation.FileName
        End If
    End Sub

    Sub GetCOMPorts()
        comPorts.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            comPorts.Items.Add(sp)
        Next
    End Sub

    Private Sub RefreshList_Click(sender As Object, e As EventArgs) Handles RefreshList.Click
        GetCOMPorts()
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        Dim fail As Boolean = True
        For Each sp As String In My.Computer.Ports.SerialPortNames
            If comPorts.SelectedItem = sp Then
                fail = False
            End If
        Next
        If My.Computer.FileSystem.FileExists(SelectedFile.Text) Then
        Else
            fail = True
            My.Application.Log.WriteEntry("2")
        End If
        If Leonardo.Checked = True Then
            AModel = ArduinoUploader.Hardware.ArduinoModel.Leonardo
        ElseIf Mega1284.Checked = True Then
            AModel = ArduinoUploader.Hardware.ArduinoModel.Mega1284
        ElseIf Mega2560.Checked = True Then
            AModel = ArduinoUploader.Hardware.ArduinoModel.Mega2560
        ElseIf NanoR2.Checked = True Then
            AModel = ArduinoUploader.Hardware.ArduinoModel.NanoR2
        ElseIf NanoR3.Checked = True Then
            AModel = ArduinoUploader.Hardware.ArduinoModel.NanoR3
        ElseIf Uno.Checked = True Then
            AModel = ArduinoUploader.Hardware.ArduinoModel.UnoR3
        Else
            fail = True
            My.Application.Log.WriteEntry("3")
        End If
        If fail = False Then
            Dim result As DialogResult = MessageBox.Show("Please ensure that the hex/binary file you have selected does NOT contain the Arduino Bootloader otherwise verification will fail.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If result = DialogResult.OK Then
                UploadHex.RunWorkerAsync()
            End If
        Else
            MsgBox("Operation failed. Please check your settings")
        End If
    End Sub
End Class
