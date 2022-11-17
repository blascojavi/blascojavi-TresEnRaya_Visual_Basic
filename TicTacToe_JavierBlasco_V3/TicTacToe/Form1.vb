Public Class Form1

    Dim random As New Random
    Dim player1Tag As String = "X"
    Dim player2Tag As String = "O"
    Dim player1DefaultName As String = "Player 1"
    Dim player2DefaultName As String = "Player 2"
    Dim player1Name As String = player1DefaultName
    Dim player2Name As String = player2DefaultName
    Public player1DefaultImage As Image = My.Resources.cruz
    Public player2DefaultImage As Image = My.Resources.circulo
    Dim player1Image As Image = player1DefaultImage
    Dim player2Image As Image = player2DefaultImage
    Dim empty As String = ""
    Dim player1Turn As Boolean
    Dim numberOfRowsAndColumns As Integer = 3
    Public player As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        'startNewGame()
    End Sub
    Public Function startNewGame() 
        restartGame()

        ' Se elige aleatoriamente el jugador que empieza el juego
        Dim playerWhoStartGame As Integer
        playerWhoStartGame = random.Next(1, 3)

        If playerWhoStartGame = 1 Then
            player1Turn = True
        Else
            player1Turn = False
        End If


        startGame(playerWhoStartGame)

    End Function

    Public Sub StartNewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartNewGameToolStripMenuItem.Click
        'restartGame()
        startNewGame()

    End Sub

    Private Sub restartGame()

        disposeButtons()
        createRowsAndColumns(numberOfRowsAndColumns)

        Dim button As Button

        For i = 0 To panelMain.Controls.Count - 1
            button = panelMain.Controls(i)
            button.Tag = empty
            button.BackgroundImage = Nothing
            button.Enabled = False
        Next

        lbltxtTurn.Visible = False
        labelPlayerTurn.Visible = False
        GamePropertiesToolStripMenuItem.Enabled = True

    End Sub

    Public Sub startGame(player)

        ' Se imprime un mensaje comunicando quien empieza el juego
        If player1Turn Then
            MessageBox.Show(player1Name & " starts the game!", "Information")
            labelPlayerTurn.Text = player1Name
        Else
            MessageBox.Show(player2Name & " starts the game!", "Information")
            labelPlayerTurn.Text = player2Name
            If formGameProperties.checkBoxComputer.Checked Then
                computerMakeMove()
            End If
        End If

        lbltxtTurn.Visible = True
        labelPlayerTurn.Visible = True
        enableButtons()
        GamePropertiesToolStripMenuItem.Enabled = False

    End Sub

    Private Sub createRowsAndColumns(numberOfRowsAndColumns As Integer)

        ' Con este bucle generamos las casillas de la siguiente manera:
        ' (Posiciones en el array controls del panel)
        '  3x3 
        ' 0 1 2
        ' 3 5 6
        ' 7 8 9
        '   4x4 
        ' 0  1  2  3
        ' 4  5  6  7
        ' 8  9  10 11
        ' 12 13 14 15
        '      5x5 
        ' 0  1  2  3  4
        ' 5  6  7  8  9
        ' 10 11 12 13 14
        ' 15 16 17 18 19
        ' ============
        Dim left As Integer = 20
        Dim top As Integer = 0
        For i = 1 To numberOfRowsAndColumns
            For j = 1 To numberOfRowsAndColumns
                Dim button As New Button
                button.Tag = empty
                button.Enabled = False
                button.Top = top
                button.Left = left
                button.Width = 110
                button.Height = 105
                button.BackgroundImageLayout = ImageLayout.Zoom
                AddHandler button.Click, AddressOf handleClick
                panelMain.Controls.Add(button)
                left = left + 110
            Next j
            left = 20
            top = top + 105
        Next i

    End Sub



    Private Sub handleClick(sender As Object, e As EventArgs)

        Dim result As String

        ' Aqui se controla el ritmo de la partida
        ' Solo se realizan las operaciones cuando el boton pulsado tiene el tag vacio
        ' Cuando se juega jugador contra jugador la logica es la siguiente
        ' primero se recoge que jugador ha pulsado el botón, esto se controla con el booleano player1Turn
        ' A continuacion ponemos el tag y la imagen que le corresponde al botón que se ha pulsado
        ' y cambiamos el valor booleano del turno
        If sender.Tag = "" Then
            If player1Turn Then
                sender.Tag = player1Tag
                sender.BackgroundImage = player1Image
                labelPlayerTurn.Text = player2Name
                player1Turn = False
            Else
                sender.Tag = player2Tag
                sender.BackgroundImage = player2Image
                labelPlayerTurn.Text = player1Name
                player1Turn = True
            End If
            If formGameProperties.checkBoxComputer.Checked Then
                result = checkWin()
                If result IsNot empty Then
                    showWinMessage(result)
                    Exit Sub
                End If
                If isTie() Then
                    MessageBox.Show("It's a Tie!", "Information")
                    restartGame()
                    Exit Sub
                End If
                computerMakeMove()
            End If
            If isTie() Then
                MessageBox.Show("It's a Tie!", "Information")
                restartGame()
                Exit Sub
            End If
            result = checkWin()
            If result IsNot empty Then
                showWinMessage(result)
                Exit Sub
            End If
        End If

    End Sub

    Private Sub computerMakeMove()

        Dim moveResult As Integer
        Dim bestMove As Integer = -1
        Dim bestMoveIndex As Integer

        ' Con este algoritmo se intenta calcular el mejor movimiento para la computadora
        ' El algoritmo va eligiendo todas las casillas vacias, a continuacion prueba el resultado
        ' de que el jugador 1 haga el movimiento en esa casilla y después hace lo mismo con el jugador 2

        For i = 0 To panelMain.Controls.Count - 1
            If panelMain.Controls(i).Tag = empty Then
                panelMain.Controls(i).Tag = player2Tag
                moveResult = makeMove()
                If moveResult > bestMove Then
                    bestMove = moveResult
                    bestMoveIndex = i
                End If
                panelMain.Controls(i).Tag = player1Tag
                moveResult = makeMove()
                If moveResult > bestMove Then
                    bestMove = moveResult
                    bestMoveIndex = i
                End If
                panelMain.Controls(i).Tag = empty
            End If
        Next

        ' Se genera el movimiento elegido automaticamente
        panelMain.Controls(bestMoveIndex).Tag = player2Tag
        panelMain.Controls(bestMoveIndex).BackgroundImage = player2Image
        labelPlayerTurn.Text = player1Name
        player1Turn = Not player1Turn


    End Sub

    Private Function makeMove()

        ' Si el ordenador gana, devolvemos un 2
        ' Si el jugador 1 gana, devolvemos un 1
        ' Si existe un empate, devolvemos un 0

        If checkWin() = player2Tag Then
            Return 2
        ElseIf checkWin() = player1Tag Then
            Return 1
        ElseIf checkWin() = empty Then
            Return 0
        Else
            Return -1
        End If

    End Function


    Private Function checkWin()


        Dim posibilities3 = {({0, 1, 2}), ({3, 4, 5}), ({6, 7, 8}), ({0, 3, 6}), ({1, 4, 7}), ({2, 5, 8}), ({0, 4, 8}), ({6, 4, 2})}
        Dim posibilities4 = {({0, 1, 2, 3}), ({4, 5, 6, 7}), ({8, 9, 10, 11}), ({12, 13, 14, 15}), ({0, 4, 8, 12}), ({1, 5, 9, 13}), ({2, 6, 10, 14}), ({3, 7, 11, 15}), ({0, 5, 10, 15}), ({12, 9, 6, 3})}
        Dim posibilities5 = {({0, 1, 2, 3, 4}), ({5, 6, 7, 8, 9}), ({10, 11, 12, 13, 14}), ({15, 16, 17, 18, 19}), ({20, 21, 22, 23, 24}), ({0, 5, 10, 15, 20}), ({1, 6, 11, 16, 21}), ({2, 7, 12, 17, 22}), ({3, 8, 13, 18, 23}), ({4, 9, 14, 19, 24}), ({0, 6, 12, 18, 24}), ({20, 16, 12, 8, 4})}
        Dim checkResult As String = empty

        ' Para comprobar si se ha ganado se ha generado un array con todas las posibilidades
        ' Con este bucle se llama a una funcion para comprobar si en esa posibilidad todos los tags coinciden,
        ' si coinciden se devuelve el string con el simbolo que ha ganado

        If numberOfRowsAndColumns = 3 Then
            For i = 0 To posibilities3.Length - 1
                checkResult = checkRow3(panelMain.Controls, posibilities3(i))
                If checkResult <> empty Then
                    Return checkResult
                End If
            Next i
        ElseIf numberOfRowsAndColumns = 4 Then
            For i = 0 To posibilities4.Length - 1
                checkResult = checkRow4(panelMain.Controls, posibilities4(i))
                If checkResult <> empty Then
                    Return checkResult
                End If
            Next i
        Else
            For i = 0 To posibilities5.Length - 1
                checkResult = checkRow5(panelMain.Controls, posibilities5(i))
                If checkResult <> empty Then
                    Return checkResult
                End If
            Next i
        End If


        Return checkResult

    End Function


    Private Function checkRow3(controls As Object, numbersToCheck() As Integer)

        ' Si coninciden todas las casillas devuelvo el string del signo, si no, se devuelve un string vacio
        If controls(numbersToCheck(0)).Tag = controls(numbersToCheck(1)).Tag And
            controls(numbersToCheck(0)).Tag = controls(numbersToCheck(2)).Tag Then

            Return controls(numbersToCheck(0)).Tag
        Else
            Return empty
        End If

    End Function

    Private Function checkRow4(controls As Object, numbersToCheck() As Integer)

        ' Si coninciden todas las casillas se devuelve el string del signo si no, se devuelve un string vacio
        If controls(numbersToCheck(0)).Tag = controls(numbersToCheck(1)).Tag AndAlso
            controls(numbersToCheck(0)).Tag = controls(numbersToCheck(2)).Tag AndAlso
            controls(numbersToCheck(0)).Tag = controls(numbersToCheck(3)).Tag Then

            Return controls(numbersToCheck(0)).Tag
        Else
            Return empty
        End If

    End Function

    Private Function checkRow5(controls As Object, numbersToCheck() As Integer)

        ' Si coinciden todas las casillas se devuelve el string del signo si no, se devuelve un string vacio
        If controls(numbersToCheck(0)).Tag = controls(numbersToCheck(1)).Tag AndAlso
            controls(numbersToCheck(0)).Tag = controls(numbersToCheck(2)).Tag AndAlso
            controls(numbersToCheck(0)).Tag = controls(numbersToCheck(3)).Tag AndAlso
            controls(numbersToCheck(0)).Tag = controls(numbersToCheck(4)).Tag Then

            Return controls(numbersToCheck(0)).Tag
        Else
            Return empty
        End If

    End Function


    Private Sub showWinMessage(result As String)

        Dim resultMsgBox As DialogResult
        Dim msgBoxText As String = " wins the game!" & vbCrLf & "Do you want to play again?"

        If result = player1Tag Then
            resultMsgBox = MessageBox.Show(player1Name & msgBoxText, "Information", MessageBoxButtons.YesNo)
            If resultMsgBox = DialogResult.No Then
                Close()
            Else
                restartGame()
            End If
        Else
            resultMsgBox = MessageBox.Show(player2Name & msgBoxText, "Information", MessageBoxButtons.YesNo)
            If resultMsgBox = DialogResult.No Then
                Close()
            Else
                restartGame()
            End If
        End If
    End Sub


    Private Function isTie()

        ' Se recorren todos los botones, si alguno tiene el tag vacio simpelemente devuelve false
        ' si despues de recorrer todos continua, siginifica que estan todos ocupados por lo tanto se devuelve un true

        Dim button As Button

        For i = 0 To panelMain.Controls.Count - 1
            button = panelMain.Controls(i)
            If button.Tag = empty Then
                Return False
            End If
        Next

        Return True

    End Function

    Public Sub enableButtons()

        Dim button As Button

        For i = 0 To panelMain.Controls.Count - 1
            button = panelMain.Controls(i)
            button.Enabled = True
        Next

    End Sub

    Private Sub disposeButtons()

        panelMain.Controls.Clear()

    End Sub

    Private Sub ExitGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitGameToolStripMenuItem.Click

        Close()

    End Sub



    Private Sub ShowHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowHelpToolStripMenuItem.Click

        FormHelp.Show()

    End Sub

    Private Sub GamePropertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GamePropertiesToolStripMenuItem.Click

        formGameProperties.ShowDialog()

        If formGameProperties.player1Name <> empty Then
            player1Name = formGameProperties.player1Name
        Else
            player1Name = player1DefaultName
        End If
        If formGameProperties.player2Name <> empty Then
            player2Name = formGameProperties.player2Name
        Else
            player2Name = player2DefaultName
        End If


        If formGameProperties.imagePlayer1 IsNot Nothing Then
            player1Image = formGameProperties.imagePlayer1
        End If

        If formGameProperties.imagePlayer2 IsNot Nothing Then
            player2Image = formGameProperties.imagePlayer2
        End If

        If formGameProperties.checkBoxPlayer1.Checked Then
            player1Image = player1DefaultImage
        End If

        If formGameProperties.checkBoxPlayer2.Checked Then
            player2Image = player2DefaultImage
        End If

        numberOfRowsAndColumns = formGameProperties.radioButtonChecked.Tag
        setFormAndPanelSize()
        disposeButtons()

    End Sub

    Public Sub setFormAndPanelSize()

        If numberOfRowsAndColumns = 3 Then
            Me.Width = 411
            Me.Height = 425
            panelMain.Width = 371
            panelMain.Height = 314
            lbltxtTurn.Left = 90
            labelPlayerTurn.Left = 214
        ElseIf numberOfRowsAndColumns = 4 Then
            Me.Width = 521
            Me.Height = 530
            panelMain.Width = 481
            panelMain.Height = 419
            lbltxtTurn.Left = 145
            labelPlayerTurn.Left = 270
        Else
            Me.Width = 631
            Me.Height = 635
            panelMain.Width = 591
            panelMain.Height = 524
            lbltxtTurn.Left = 200
            labelPlayerTurn.Left = 325
        End If

    End Sub


End Class
