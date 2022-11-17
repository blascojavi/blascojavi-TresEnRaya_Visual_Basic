Public Class formGameProperties

    Public player1Name As String = Nothing
    Public player2Name As String = Nothing
    Public imagePlayer1 As Image = Nothing
    Public imagePlayer2 As Image = Nothing
    Public checkBoxPlayer1 As CheckBox
    Public checkBoxPlayer2 As CheckBox
    Public radioButtonChecked As RadioButton
    Public playerVs As String = Nothing


    Private Sub formGameProperties_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pictureBoxPlayer1.SizeMode = PictureBoxSizeMode.Zoom
        pictureBoxPlayer2.SizeMode = PictureBoxSizeMode.Zoom

        pictureBoxPlayer1.Image = Form1.player1DefaultImage
        pictureBoxPlayer2.Image = Form1.player2DefaultImage

        checkBoxPlayer1 = checkBoxDefaultPlayer1
        checkBoxPlayer2 = checkBoxDefaultPlayer2

    End Sub


    Private Sub formGameProperties_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing 

        player1Name = txtBoxPlayer1.Text
        player2Name = txtBoxPlayer2.Text

        For Each radioBtn In groupBoxRadioButton.Controls
            If radioBtn.checked Then
                radioButtonChecked = radioBtn
            End If
        Next

        Dim player1SettingName As String
        Dim player2SettingName As String
        Dim player1SettingImage As String
        Dim player2SettingImage As String

        If player1Name = "" Then
            player1SettingName = "Default"
        Else
            player1SettingName = txtBoxPlayer1.Text
        End If

        If player2Name = "" Then
            player2SettingName = "Default"
        Else
            player2SettingName = txtBoxPlayer2.Text
        End If

        If pictureBoxPlayer1.Image Is Form1.player1DefaultImage Then
            player1SettingImage = "Default"
        Else
            player1SettingImage = "Custom"
        End If

        If pictureBoxPlayer2.Image Is Form1.player2DefaultImage Then
            player2SettingImage = "Default"
        Else
            player2SettingImage = "Default"
        End If

        If checkBoxComputer.Checked Then
            playerVs = "Computer"
        Else
            playerVs = "Player"
        End If

        Dim settings As String = "Player 1 name: " & player1SettingName & vbCrLf &
                                 "Player 1 Image: " & player1SettingImage & vbCrLf &
                                 "Player 2 name: " & player2SettingName & vbCrLf &
                                 "Player 2 Image: " & player2SettingImage & vbCrLf &
                                 "Player vs: " & playerVs & vbCrLf &
                                 "Table: " & radioButtonChecked.Text



        MessageBox.Show(settings, "Game settings")
        'Form1.startNewGame()
        Form1.enableButtons()
        'Form1.startGame(Form1.player)


    End Sub
    Public Sub buttonAccept_Click(sender As Object, e As EventArgs) Handles buttonAccept.Click



        Me.Close()
        ' Form1.startNewGame()

        'Form1.startGame(Form1.player)

    End Sub




    Private Sub btnChooseImgPlayer1_Click(sender As Object, e As EventArgs) Handles btnChooseImgPlayer1.Click, btnChooseImgPlayer2.Click

        If sender.Tag = 1 Then
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                pictureBoxPlayer1.Load(OpenFileDialog1.FileName)
                imagePlayer1 = pictureBoxPlayer1.Image
                checkBoxDefaultPlayer1.Checked = False
            End If
        Else
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                pictureBoxPlayer2.Load(OpenFileDialog1.FileName)
                imagePlayer2 = pictureBoxPlayer2.Image
                checkBoxDefaultPlayer2.Checked = False
            End If
        End If

    End Sub

    Private Sub checkBoxDefaultPlayer_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoxDefaultPlayer1.CheckedChanged, checkBoxDefaultPlayer2.CheckedChanged

        If sender.checked Then
            If sender.Tag = 1 Then
                pictureBoxPlayer1.Image = Form1.player1DefaultImage
            Else
                pictureBoxPlayer2.Image = Form1.player2DefaultImage
            End If

        End If
    End Sub




End Class