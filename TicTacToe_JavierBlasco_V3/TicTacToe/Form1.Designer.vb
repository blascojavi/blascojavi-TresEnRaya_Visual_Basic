<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartNewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GamePropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbltxtTurn = New System.Windows.Forms.Label()
        Me.labelPlayerTurn = New System.Windows.Forms.Label()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(395, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartNewGameToolStripMenuItem, Me.GamePropertiesToolStripMenuItem, Me.ExitGameToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'StartNewGameToolStripMenuItem
        '
        Me.StartNewGameToolStripMenuItem.Name = "StartNewGameToolStripMenuItem"
        Me.StartNewGameToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.StartNewGameToolStripMenuItem.Text = "Start New Game"
        '
        'GamePropertiesToolStripMenuItem
        '
        Me.GamePropertiesToolStripMenuItem.Name = "GamePropertiesToolStripMenuItem"
        Me.GamePropertiesToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.GamePropertiesToolStripMenuItem.Text = "Game properties"
        '
        'ExitGameToolStripMenuItem
        '
        Me.ExitGameToolStripMenuItem.Name = "ExitGameToolStripMenuItem"
        Me.ExitGameToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ExitGameToolStripMenuItem.Text = "Exit Game"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowHelpToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ShowHelpToolStripMenuItem
        '
        Me.ShowHelpToolStripMenuItem.Name = "ShowHelpToolStripMenuItem"
        Me.ShowHelpToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.ShowHelpToolStripMenuItem.Text = "Show help"
        '
        'lbltxtTurn
        '
        Me.lbltxtTurn.AutoSize = True
        Me.lbltxtTurn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltxtTurn.Location = New System.Drawing.Point(67, 24)
        Me.lbltxtTurn.Margin = New System.Windows.Forms.Padding(0)
        Me.lbltxtTurn.Name = "lbltxtTurn"
        Me.lbltxtTurn.Size = New System.Drawing.Size(133, 26)
        Me.lbltxtTurn.TabIndex = 0
        Me.lbltxtTurn.Text = "Current turn:"
        Me.lbltxtTurn.Visible = False
        '
        'labelPlayerTurn
        '
        Me.labelPlayerTurn.AutoSize = True
        Me.labelPlayerTurn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPlayerTurn.Location = New System.Drawing.Point(193, 24)
        Me.labelPlayerTurn.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.labelPlayerTurn.Name = "labelPlayerTurn"
        Me.labelPlayerTurn.Size = New System.Drawing.Size(0, 26)
        Me.labelPlayerTurn.TabIndex = 1
        '
        'panelMain
        '
        Me.panelMain.Location = New System.Drawing.Point(12, 60)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(371, 314)
        Me.panelMain.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 386)
        Me.Controls.Add(Me.labelPlayerTurn)
        Me.Controls.Add(Me.lbltxtTurn)
        Me.Controls.Add(Me.panelMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "TicTacToe"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartNewGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbltxtTurn As Label
    Friend WithEvents labelPlayerTurn As Label
    Friend WithEvents panelMain As Panel
    Friend WithEvents GamePropertiesToolStripMenuItem As ToolStripMenuItem
End Class
