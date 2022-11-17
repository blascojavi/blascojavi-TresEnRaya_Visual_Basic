<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formGameProperties
    Inherits System.Windows.Forms.Form

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBoxPlayer1 = New System.Windows.Forms.TextBox()
        Me.txtBoxPlayer2 = New System.Windows.Forms.TextBox()
        Me.pictureBoxPlayer1 = New System.Windows.Forms.PictureBox()
        Me.pictureBoxPlayer2 = New System.Windows.Forms.PictureBox()
        Me.btnChooseImgPlayer1 = New System.Windows.Forms.Button()
        Me.btnChooseImgPlayer2 = New System.Windows.Forms.Button()
        Me.checkBoxDefaultPlayer1 = New System.Windows.Forms.CheckBox()
        Me.checkBoxDefaultPlayer2 = New System.Windows.Forms.CheckBox()
        Me.groupBoxRadioButton = New System.Windows.Forms.GroupBox()
        Me.radioBtn5x5 = New System.Windows.Forms.RadioButton()
        Me.radioBtn4x4 = New System.Windows.Forms.RadioButton()
        Me.radioBtn3x3 = New System.Windows.Forms.RadioButton()
        Me.checkBoxComputer = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.buttonAccept = New System.Windows.Forms.Button()
        CType(Me.pictureBoxPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBoxPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxRadioButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Player 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(343, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Player 2:"
        '
        'txtBoxPlayer1
        '
        Me.txtBoxPlayer1.Location = New System.Drawing.Point(135, 43)
        Me.txtBoxPlayer1.Name = "txtBoxPlayer1"
        Me.txtBoxPlayer1.Size = New System.Drawing.Size(130, 20)
        Me.txtBoxPlayer1.TabIndex = 2
        '
        'txtBoxPlayer2
        '
        Me.txtBoxPlayer2.Location = New System.Drawing.Point(394, 43)
        Me.txtBoxPlayer2.Name = "txtBoxPlayer2"
        Me.txtBoxPlayer2.Size = New System.Drawing.Size(130, 20)
        Me.txtBoxPlayer2.TabIndex = 3
        '
        'pictureBoxPlayer1
        '
        Me.pictureBoxPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureBoxPlayer1.Location = New System.Drawing.Point(135, 69)
        Me.pictureBoxPlayer1.Name = "pictureBoxPlayer1"
        Me.pictureBoxPlayer1.Size = New System.Drawing.Size(130, 100)
        Me.pictureBoxPlayer1.TabIndex = 4
        Me.pictureBoxPlayer1.TabStop = False
        '
        'pictureBoxPlayer2
        '
        Me.pictureBoxPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureBoxPlayer2.Location = New System.Drawing.Point(394, 69)
        Me.pictureBoxPlayer2.Name = "pictureBoxPlayer2"
        Me.pictureBoxPlayer2.Size = New System.Drawing.Size(130, 100)
        Me.pictureBoxPlayer2.TabIndex = 5
        Me.pictureBoxPlayer2.TabStop = False
        '
        'btnChooseImgPlayer1
        '
        Me.btnChooseImgPlayer1.Location = New System.Drawing.Point(54, 90)
        Me.btnChooseImgPlayer1.Name = "btnChooseImgPlayer1"
        Me.btnChooseImgPlayer1.Size = New System.Drawing.Size(75, 23)
        Me.btnChooseImgPlayer1.TabIndex = 6
        Me.btnChooseImgPlayer1.Tag = "1"
        Me.btnChooseImgPlayer1.Text = "Image"
        Me.btnChooseImgPlayer1.UseVisualStyleBackColor = True
        '
        'btnChooseImgPlayer2
        '
        Me.btnChooseImgPlayer2.Location = New System.Drawing.Point(313, 90)
        Me.btnChooseImgPlayer2.Name = "btnChooseImgPlayer2"
        Me.btnChooseImgPlayer2.Size = New System.Drawing.Size(75, 23)
        Me.btnChooseImgPlayer2.TabIndex = 7
        Me.btnChooseImgPlayer2.Tag = "2"
        Me.btnChooseImgPlayer2.Text = "Image"
        Me.btnChooseImgPlayer2.UseVisualStyleBackColor = True
        '
        'checkBoxDefaultPlayer1
        '
        Me.checkBoxDefaultPlayer1.AutoSize = True
        Me.checkBoxDefaultPlayer1.Location = New System.Drawing.Point(56, 131)
        Me.checkBoxDefaultPlayer1.Name = "checkBoxDefaultPlayer1"
        Me.checkBoxDefaultPlayer1.Size = New System.Drawing.Size(73, 17)
        Me.checkBoxDefaultPlayer1.TabIndex = 8
        Me.checkBoxDefaultPlayer1.Tag = "1"
        Me.checkBoxDefaultPlayer1.Text = "By default"
        Me.checkBoxDefaultPlayer1.UseVisualStyleBackColor = True
        '
        'checkBoxDefaultPlayer2
        '
        Me.checkBoxDefaultPlayer2.AutoSize = True
        Me.checkBoxDefaultPlayer2.Location = New System.Drawing.Point(315, 131)
        Me.checkBoxDefaultPlayer2.Name = "checkBoxDefaultPlayer2"
        Me.checkBoxDefaultPlayer2.Size = New System.Drawing.Size(73, 17)
        Me.checkBoxDefaultPlayer2.TabIndex = 9
        Me.checkBoxDefaultPlayer2.Tag = "2"
        Me.checkBoxDefaultPlayer2.Text = "By default"
        Me.checkBoxDefaultPlayer2.UseVisualStyleBackColor = True
        '
        'groupBoxRadioButton
        '
        Me.groupBoxRadioButton.Controls.Add(Me.radioBtn5x5)
        Me.groupBoxRadioButton.Controls.Add(Me.radioBtn4x4)
        Me.groupBoxRadioButton.Controls.Add(Me.radioBtn3x3)
        Me.groupBoxRadioButton.Location = New System.Drawing.Point(54, 219)
        Me.groupBoxRadioButton.Name = "groupBoxRadioButton"
        Me.groupBoxRadioButton.Size = New System.Drawing.Size(470, 50)
        Me.groupBoxRadioButton.TabIndex = 10
        Me.groupBoxRadioButton.TabStop = False
        Me.groupBoxRadioButton.Text = "Cuadrícula"
        '
        'radioBtn5x5
        '
        Me.radioBtn5x5.AutoSize = True
        Me.radioBtn5x5.Location = New System.Drawing.Point(384, 20)
        Me.radioBtn5x5.Name = "radioBtn5x5"
        Me.radioBtn5x5.Size = New System.Drawing.Size(48, 17)
        Me.radioBtn5x5.TabIndex = 2
        Me.radioBtn5x5.Tag = "5"
        Me.radioBtn5x5.Text = "5 x 5"
        Me.radioBtn5x5.UseVisualStyleBackColor = True
        '
        'radioBtn4x4
        '
        Me.radioBtn4x4.AutoSize = True
        Me.radioBtn4x4.Location = New System.Drawing.Point(205, 20)
        Me.radioBtn4x4.Name = "radioBtn4x4"
        Me.radioBtn4x4.Size = New System.Drawing.Size(48, 17)
        Me.radioBtn4x4.TabIndex = 1
        Me.radioBtn4x4.Tag = "4"
        Me.radioBtn4x4.Text = "4 x 4"
        Me.radioBtn4x4.UseVisualStyleBackColor = True
        '
        'radioBtn3x3
        '
        Me.radioBtn3x3.AutoSize = True
        Me.radioBtn3x3.Checked = True
        Me.radioBtn3x3.Location = New System.Drawing.Point(33, 20)
        Me.radioBtn3x3.Name = "radioBtn3x3"
        Me.radioBtn3x3.Size = New System.Drawing.Size(48, 17)
        Me.radioBtn3x3.TabIndex = 0
        Me.radioBtn3x3.TabStop = True
        Me.radioBtn3x3.Tag = "3"
        Me.radioBtn3x3.Text = "3 x 3"
        Me.radioBtn3x3.UseVisualStyleBackColor = True
        '
        'checkBoxComputer
        '
        Me.checkBoxComputer.AutoSize = True
        Me.checkBoxComputer.Location = New System.Drawing.Point(424, 187)
        Me.checkBoxComputer.Name = "checkBoxComputer"
        Me.checkBoxComputer.Size = New System.Drawing.Size(71, 17)
        Me.checkBoxComputer.TabIndex = 11
        Me.checkBoxComputer.Text = "Computer"
        Me.checkBoxComputer.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'buttonAccept
        '
        Me.buttonAccept.Location = New System.Drawing.Point(147, 295)
        Me.buttonAccept.Name = "buttonAccept"
        Me.buttonAccept.Size = New System.Drawing.Size(75, 23)
        Me.buttonAccept.TabIndex = 12
        Me.buttonAccept.Text = "Aceptar"
        Me.buttonAccept.UseVisualStyleBackColor = True
        '
        'formGameProperties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 333)
        Me.Controls.Add(Me.buttonAccept)
        Me.Controls.Add(Me.checkBoxComputer)
        Me.Controls.Add(Me.groupBoxRadioButton)
        Me.Controls.Add(Me.checkBoxDefaultPlayer2)
        Me.Controls.Add(Me.checkBoxDefaultPlayer1)
        Me.Controls.Add(Me.btnChooseImgPlayer2)
        Me.Controls.Add(Me.btnChooseImgPlayer1)
        Me.Controls.Add(Me.pictureBoxPlayer2)
        Me.Controls.Add(Me.pictureBoxPlayer1)
        Me.Controls.Add(Me.txtBoxPlayer2)
        Me.Controls.Add(Me.txtBoxPlayer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "formGameProperties"
        Me.Text = "Game properties"
        CType(Me.pictureBoxPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBoxPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxRadioButton.ResumeLayout(False)
        Me.groupBoxRadioButton.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBoxPlayer1 As TextBox
    Friend WithEvents txtBoxPlayer2 As TextBox
    Friend WithEvents pictureBoxPlayer1 As PictureBox
    Friend WithEvents pictureBoxPlayer2 As PictureBox
    Friend WithEvents btnChooseImgPlayer1 As Button
    Friend WithEvents btnChooseImgPlayer2 As Button
    Friend WithEvents checkBoxDefaultPlayer1 As CheckBox
    Friend WithEvents checkBoxDefaultPlayer2 As CheckBox
    Friend WithEvents groupBoxRadioButton As GroupBox
    Friend WithEvents radioBtn5x5 As RadioButton
    Friend WithEvents radioBtn4x4 As RadioButton
    Friend WithEvents radioBtn3x3 As RadioButton
    Friend WithEvents checkBoxComputer As CheckBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents buttonAccept As Button
End Class
