<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.UploadHex = New System.ComponentModel.BackgroundWorker()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SketchLocation = New System.Windows.Forms.OpenFileDialog()
        Me.OpenButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.SelectedFile = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.Leonardo = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Mega1284 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Mega2560 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Micro = New MaterialSkin.Controls.MaterialRadioButton()
        Me.NanoR2 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.NanoR3 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Uno = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.comPorts = New System.Windows.Forms.ComboBox()
        Me.RefreshList = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'UploadHex
        '
        Me.UploadHex.WorkerReportsProgress = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 465)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(476, 23)
        Me.ProgressBar1.TabIndex = 0
        '
        'SketchLocation
        '
        Me.SketchLocation.DefaultExt = "hex"
        Me.SketchLocation.Filter = "Binary Files|*.hex;*.bin|All Files|*.*"
        Me.SketchLocation.SupportMultiDottedExtensions = True
        Me.SketchLocation.Title = "Select your binary file:"
        '
        'OpenButton
        '
        Me.OpenButton.Depth = 0
        Me.OpenButton.Location = New System.Drawing.Point(394, 103)
        Me.OpenButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.OpenButton.MaximumSize = New System.Drawing.Size(94, 23)
        Me.OpenButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.OpenButton.Name = "OpenButton"
        Me.OpenButton.Primary = False
        Me.OpenButton.Size = New System.Drawing.Size(94, 23)
        Me.OpenButton.TabIndex = 1
        Me.OpenButton.Text = "Select File"
        Me.OpenButton.UseVisualStyleBackColor = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(12, 75)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(323, 19)
        Me.MaterialLabel1.TabIndex = 3
        Me.MaterialLabel1.Text = "Step 1: Select your hex or bin sketch to upload."
        '
        'SelectedFile
        '
        Me.SelectedFile.Depth = 0
        Me.SelectedFile.Hint = ""
        Me.SelectedFile.Location = New System.Drawing.Point(16, 103)
        Me.SelectedFile.MouseState = MaterialSkin.MouseState.HOVER
        Me.SelectedFile.Name = "SelectedFile"
        Me.SelectedFile.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SelectedFile.SelectedText = ""
        Me.SelectedFile.SelectionLength = 0
        Me.SelectedFile.SelectionStart = 0
        Me.SelectedFile.Size = New System.Drawing.Size(371, 23)
        Me.SelectedFile.TabIndex = 4
        Me.SelectedFile.UseSystemPasswordChar = False
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(12, 131)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(346, 19)
        Me.MaterialLabel2.TabIndex = 5
        Me.MaterialLabel2.Text = "Step 2: Select the type of Arduino device you have."
        '
        'Leonardo
        '
        Me.Leonardo.AutoSize = True
        Me.Leonardo.Depth = 0
        Me.Leonardo.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Leonardo.Location = New System.Drawing.Point(16, 153)
        Me.Leonardo.Margin = New System.Windows.Forms.Padding(0)
        Me.Leonardo.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Leonardo.MouseState = MaterialSkin.MouseState.HOVER
        Me.Leonardo.Name = "Leonardo"
        Me.Leonardo.Ripple = True
        Me.Leonardo.Size = New System.Drawing.Size(87, 30)
        Me.Leonardo.TabIndex = 6
        Me.Leonardo.Text = "Leonardo"
        Me.Leonardo.UseVisualStyleBackColor = True
        '
        'Mega1284
        '
        Me.Mega1284.AutoSize = True
        Me.Mega1284.Depth = 0
        Me.Mega1284.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Mega1284.Location = New System.Drawing.Point(16, 183)
        Me.Mega1284.Margin = New System.Windows.Forms.Padding(0)
        Me.Mega1284.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Mega1284.MouseState = MaterialSkin.MouseState.HOVER
        Me.Mega1284.Name = "Mega1284"
        Me.Mega1284.Ripple = True
        Me.Mega1284.Size = New System.Drawing.Size(98, 30)
        Me.Mega1284.TabIndex = 7
        Me.Mega1284.Text = "Mega 1284"
        Me.Mega1284.UseVisualStyleBackColor = True
        '
        'Mega2560
        '
        Me.Mega2560.AutoSize = True
        Me.Mega2560.Depth = 0
        Me.Mega2560.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Mega2560.Location = New System.Drawing.Point(16, 213)
        Me.Mega2560.Margin = New System.Windows.Forms.Padding(0)
        Me.Mega2560.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Mega2560.MouseState = MaterialSkin.MouseState.HOVER
        Me.Mega2560.Name = "Mega2560"
        Me.Mega2560.Ripple = True
        Me.Mega2560.Size = New System.Drawing.Size(98, 30)
        Me.Mega2560.TabIndex = 8
        Me.Mega2560.Text = "Mega 2560"
        Me.Mega2560.UseVisualStyleBackColor = True
        '
        'Micro
        '
        Me.Micro.AutoSize = True
        Me.Micro.Depth = 0
        Me.Micro.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Micro.Location = New System.Drawing.Point(16, 243)
        Me.Micro.Margin = New System.Windows.Forms.Padding(0)
        Me.Micro.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Micro.MouseState = MaterialSkin.MouseState.HOVER
        Me.Micro.Name = "Micro"
        Me.Micro.Ripple = True
        Me.Micro.Size = New System.Drawing.Size(64, 30)
        Me.Micro.TabIndex = 9
        Me.Micro.Text = "Micro"
        Me.Micro.UseVisualStyleBackColor = True
        '
        'NanoR2
        '
        Me.NanoR2.AutoSize = True
        Me.NanoR2.Depth = 0
        Me.NanoR2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NanoR2.Location = New System.Drawing.Point(16, 273)
        Me.NanoR2.Margin = New System.Windows.Forms.Padding(0)
        Me.NanoR2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.NanoR2.MouseState = MaterialSkin.MouseState.HOVER
        Me.NanoR2.Name = "NanoR2"
        Me.NanoR2.Ripple = True
        Me.NanoR2.Size = New System.Drawing.Size(91, 30)
        Me.NanoR2.TabIndex = 10
        Me.NanoR2.Text = "Nano (R2)"
        Me.NanoR2.UseVisualStyleBackColor = True
        '
        'NanoR3
        '
        Me.NanoR3.AutoSize = True
        Me.NanoR3.Depth = 0
        Me.NanoR3.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.NanoR3.Location = New System.Drawing.Point(16, 303)
        Me.NanoR3.Margin = New System.Windows.Forms.Padding(0)
        Me.NanoR3.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.NanoR3.MouseState = MaterialSkin.MouseState.HOVER
        Me.NanoR3.Name = "NanoR3"
        Me.NanoR3.Ripple = True
        Me.NanoR3.Size = New System.Drawing.Size(91, 30)
        Me.NanoR3.TabIndex = 11
        Me.NanoR3.Text = "Nano (R3)"
        Me.NanoR3.UseVisualStyleBackColor = True
        '
        'Uno
        '
        Me.Uno.AutoSize = True
        Me.Uno.Checked = True
        Me.Uno.Depth = 0
        Me.Uno.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Uno.Location = New System.Drawing.Point(16, 333)
        Me.Uno.Margin = New System.Windows.Forms.Padding(0)
        Me.Uno.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Uno.MouseState = MaterialSkin.MouseState.HOVER
        Me.Uno.Name = "Uno"
        Me.Uno.Ripple = True
        Me.Uno.Size = New System.Drawing.Size(83, 30)
        Me.Uno.TabIndex = 12
        Me.Uno.TabStop = True
        Me.Uno.Text = "Uno (R3)"
        Me.Uno.UseVisualStyleBackColor = True
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(290, 183)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(198, 19)
        Me.MaterialLabel3.TabIndex = 13
        Me.MaterialLabel3.Text = "Step 3: Select the COM port."
        '
        'comPorts
        '
        Me.comPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comPorts.FormattingEnabled = True
        Me.comPorts.Location = New System.Drawing.Point(294, 207)
        Me.comPorts.Name = "comPorts"
        Me.comPorts.Size = New System.Drawing.Size(117, 21)
        Me.comPorts.TabIndex = 14
        '
        'RefreshList
        '
        Me.RefreshList.Depth = 0
        Me.RefreshList.Location = New System.Drawing.Point(418, 206)
        Me.RefreshList.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.RefreshList.MaximumSize = New System.Drawing.Size(94, 23)
        Me.RefreshList.MouseState = MaterialSkin.MouseState.HOVER
        Me.RefreshList.Name = "RefreshList"
        Me.RefreshList.Primary = False
        Me.RefreshList.Size = New System.Drawing.Size(70, 23)
        Me.RefreshList.TabIndex = 15
        Me.RefreshList.Text = "Refresh"
        Me.RefreshList.UseVisualStyleBackColor = True
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(16, 403)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(472, 19)
        Me.MaterialLabel4.TabIndex = 16
        Me.MaterialLabel4.Text = "Step 4: Press go!"
        Me.MaterialLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(16, 425)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(472, 34)
        Me.MaterialRaisedButton1.TabIndex = 17
        Me.MaterialRaisedButton1.Text = "Go!"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.RefreshList)
        Me.Controls.Add(Me.comPorts)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.Uno)
        Me.Controls.Add(Me.NanoR3)
        Me.Controls.Add(Me.NanoR2)
        Me.Controls.Add(Me.Micro)
        Me.Controls.Add(Me.Mega2560)
        Me.Controls.Add(Me.Mega1284)
        Me.Controls.Add(Me.Leonardo)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.SelectedFile)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.OpenButton)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "Form1"
        Me.Text = "Arduino Hex Uploader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UploadHex As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents SketchLocation As OpenFileDialog
    Friend WithEvents OpenButton As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents SelectedFile As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Leonardo As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Mega1284 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Mega2560 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Micro As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents NanoR2 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents NanoR3 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Uno As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents comPorts As ComboBox
    Friend WithEvents RefreshList As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
End Class
