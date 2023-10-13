<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
    Inherits RoundedForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game))
        Me.ButtonPSXLaunch = New System.Windows.Forms.Button()
        Me.ButtonEditOperatorNotes = New System.Windows.Forms.Button()
        Me.TabControlGameLists = New System.Windows.Forms.TabControl()
        Me.TabPageGameWinList = New System.Windows.Forms.TabPage()
        Me.ListGamesWin = New System.Windows.Forms.ListBox()
        Me.TabPageGameXboxList = New System.Windows.Forms.TabPage()
        Me.ListGamesXbox = New System.Windows.Forms.ListBox()
        Me.TabPageGamePlaystationList = New System.Windows.Forms.TabPage()
        Me.ListGamesPlaystation = New System.Windows.Forms.ListBox()
        Me.TabPageGameNintendoList = New System.Windows.Forms.TabPage()
        Me.ListGamesNintendo = New System.Windows.Forms.ListBox()
        Me.LblGameDir = New System.Windows.Forms.Label()
        Me.ButtonDebug2 = New System.Windows.Forms.Button()
        Me.ButtonDebug0 = New System.Windows.Forms.Button()
        Me.ButtonOpenGameFolder = New System.Windows.Forms.Button()
        Me.LabelGameTitle = New System.Windows.Forms.Label()
        Me.LblGenre = New System.Windows.Forms.Label()
        Me.ButtonPlayGame = New System.Windows.Forms.Button()
        Me.PanelInfo = New System.Windows.Forms.Panel()
        Me.LabelAppNote = New System.Windows.Forms.Label()
        Me.LabelOperatorNotes = New System.Windows.Forms.Label()
        Me.picGameIcon = New System.Windows.Forms.PictureBox()
        Me.picPoster = New System.Windows.Forms.PictureBox()
        Me.picPlatform = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlGameLists.SuspendLayout()
        Me.TabPageGameWinList.SuspendLayout()
        Me.TabPageGameXboxList.SuspendLayout()
        Me.TabPageGamePlaystationList.SuspendLayout()
        Me.TabPageGameNintendoList.SuspendLayout()
        Me.PanelInfo.SuspendLayout()
        CType(Me.picGameIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPoster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlatform, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.Location = New System.Drawing.Point(1003, 11)
        '
        'PictureBoxMax
        '
        Me.PictureBoxMax.Location = New System.Drawing.Point(1003, 35)
        '
        'PictureBoxMinimize
        '
        Me.PictureBoxMinimize.Location = New System.Drawing.Point(1003, 59)
        '
        'ButtonPSXLaunch
        '
        Me.ButtonPSXLaunch.Location = New System.Drawing.Point(208, 121)
        Me.ButtonPSXLaunch.Name = "ButtonPSXLaunch"
        Me.ButtonPSXLaunch.Size = New System.Drawing.Size(148, 99)
        Me.ButtonPSXLaunch.TabIndex = 0
        Me.ButtonPSXLaunch.Text = "PS1"
        Me.ButtonPSXLaunch.UseVisualStyleBackColor = True
        '
        'ButtonEditOperatorNotes
        '
        Me.ButtonEditOperatorNotes.AccessibleDescription = "Opens dialogue box to edit operators notes"
        Me.ButtonEditOperatorNotes.AccessibleName = "Edit Operator Notes"
        Me.ButtonEditOperatorNotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonEditOperatorNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditOperatorNotes.Location = New System.Drawing.Point(572, 346)
        Me.ButtonEditOperatorNotes.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonEditOperatorNotes.Name = "ButtonEditOperatorNotes"
        Me.ButtonEditOperatorNotes.Size = New System.Drawing.Size(25, 25)
        Me.ButtonEditOperatorNotes.TabIndex = 27
        Me.ButtonEditOperatorNotes.Text = "✏"
        Me.ButtonEditOperatorNotes.UseVisualStyleBackColor = True
        '
        'TabControlGameLists
        '
        Me.TabControlGameLists.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlGameLists.Controls.Add(Me.TabPageGameWinList)
        Me.TabControlGameLists.Controls.Add(Me.TabPageGameXboxList)
        Me.TabControlGameLists.Controls.Add(Me.TabPageGamePlaystationList)
        Me.TabControlGameLists.Controls.Add(Me.TabPageGameNintendoList)
        Me.TabControlGameLists.Location = New System.Drawing.Point(600, 2)
        Me.TabControlGameLists.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.TabControlGameLists.Multiline = True
        Me.TabControlGameLists.Name = "TabControlGameLists"
        Me.TabControlGameLists.SelectedIndex = 0
        Me.TabControlGameLists.Size = New System.Drawing.Size(400, 556)
        Me.TabControlGameLists.TabIndex = 26
        '
        'TabPageGameWinList
        '
        Me.TabPageGameWinList.Controls.Add(Me.ListGamesWin)
        Me.TabPageGameWinList.Location = New System.Drawing.Point(4, 29)
        Me.TabPageGameWinList.Name = "TabPageGameWinList"
        Me.TabPageGameWinList.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageGameWinList.Size = New System.Drawing.Size(392, 523)
        Me.TabPageGameWinList.TabIndex = 0
        Me.TabPageGameWinList.Text = "Win"
        Me.TabPageGameWinList.UseVisualStyleBackColor = True
        '
        'ListGamesWin
        '
        Me.ListGamesWin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListGamesWin.FormattingEnabled = True
        Me.ListGamesWin.ItemHeight = 20
        Me.ListGamesWin.Location = New System.Drawing.Point(3, 3)
        Me.ListGamesWin.Margin = New System.Windows.Forms.Padding(0)
        Me.ListGamesWin.Name = "ListGamesWin"
        Me.ListGamesWin.Size = New System.Drawing.Size(386, 517)
        Me.ListGamesWin.TabIndex = 0
        '
        'TabPageGameXboxList
        '
        Me.TabPageGameXboxList.Controls.Add(Me.ListGamesXbox)
        Me.TabPageGameXboxList.Location = New System.Drawing.Point(4, 29)
        Me.TabPageGameXboxList.Name = "TabPageGameXboxList"
        Me.TabPageGameXboxList.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageGameXboxList.Size = New System.Drawing.Size(392, 523)
        Me.TabPageGameXboxList.TabIndex = 1
        Me.TabPageGameXboxList.Text = "Xbox"
        Me.TabPageGameXboxList.UseVisualStyleBackColor = True
        '
        'ListGamesXbox
        '
        Me.ListGamesXbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListGamesXbox.FormattingEnabled = True
        Me.ListGamesXbox.ItemHeight = 20
        Me.ListGamesXbox.Location = New System.Drawing.Point(3, 3)
        Me.ListGamesXbox.Margin = New System.Windows.Forms.Padding(0)
        Me.ListGamesXbox.Name = "ListGamesXbox"
        Me.ListGamesXbox.Size = New System.Drawing.Size(386, 517)
        Me.ListGamesXbox.TabIndex = 1
        '
        'TabPageGamePlaystationList
        '
        Me.TabPageGamePlaystationList.Controls.Add(Me.ListGamesPlaystation)
        Me.TabPageGamePlaystationList.Location = New System.Drawing.Point(4, 29)
        Me.TabPageGamePlaystationList.Name = "TabPageGamePlaystationList"
        Me.TabPageGamePlaystationList.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageGamePlaystationList.Size = New System.Drawing.Size(392, 523)
        Me.TabPageGamePlaystationList.TabIndex = 2
        Me.TabPageGamePlaystationList.Text = "Playstation"
        Me.TabPageGamePlaystationList.UseVisualStyleBackColor = True
        '
        'ListGamesPlaystation
        '
        Me.ListGamesPlaystation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListGamesPlaystation.FormattingEnabled = True
        Me.ListGamesPlaystation.ItemHeight = 20
        Me.ListGamesPlaystation.Location = New System.Drawing.Point(3, 3)
        Me.ListGamesPlaystation.Margin = New System.Windows.Forms.Padding(0)
        Me.ListGamesPlaystation.Name = "ListGamesPlaystation"
        Me.ListGamesPlaystation.Size = New System.Drawing.Size(386, 517)
        Me.ListGamesPlaystation.TabIndex = 2
        '
        'TabPageGameNintendoList
        '
        Me.TabPageGameNintendoList.Controls.Add(Me.ListGamesNintendo)
        Me.TabPageGameNintendoList.Location = New System.Drawing.Point(4, 29)
        Me.TabPageGameNintendoList.Name = "TabPageGameNintendoList"
        Me.TabPageGameNintendoList.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageGameNintendoList.Size = New System.Drawing.Size(392, 523)
        Me.TabPageGameNintendoList.TabIndex = 3
        Me.TabPageGameNintendoList.Text = "Nintendo"
        Me.TabPageGameNintendoList.UseVisualStyleBackColor = True
        '
        'ListGamesNintendo
        '
        Me.ListGamesNintendo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListGamesNintendo.FormattingEnabled = True
        Me.ListGamesNintendo.ItemHeight = 20
        Me.ListGamesNintendo.Location = New System.Drawing.Point(3, 3)
        Me.ListGamesNintendo.Margin = New System.Windows.Forms.Padding(0)
        Me.ListGamesNintendo.Name = "ListGamesNintendo"
        Me.ListGamesNintendo.Size = New System.Drawing.Size(386, 517)
        Me.ListGamesNintendo.TabIndex = 2
        '
        'LblGameDir
        '
        Me.LblGameDir.AutoSize = True
        Me.LblGameDir.BackColor = System.Drawing.Color.Transparent
        Me.LblGameDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGameDir.Location = New System.Drawing.Point(82, 11)
        Me.LblGameDir.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblGameDir.Name = "LblGameDir"
        Me.LblGameDir.Size = New System.Drawing.Size(94, 13)
        Me.LblGameDir.TabIndex = 22
        Me.LblGameDir.Text = "LABEL GaME DIR"
        '
        'ButtonDebug2
        '
        Me.ButtonDebug2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonDebug2.Location = New System.Drawing.Point(103, 277)
        Me.ButtonDebug2.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonDebug2.Name = "ButtonDebug2"
        Me.ButtonDebug2.Size = New System.Drawing.Size(78, 39)
        Me.ButtonDebug2.TabIndex = 25
        Me.ButtonDebug2.Text = "Debug"
        Me.ButtonDebug2.UseVisualStyleBackColor = True
        '
        'ButtonDebug0
        '
        Me.ButtonDebug0.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonDebug0.Location = New System.Drawing.Point(15, 277)
        Me.ButtonDebug0.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonDebug0.Name = "ButtonDebug0"
        Me.ButtonDebug0.Size = New System.Drawing.Size(78, 39)
        Me.ButtonDebug0.TabIndex = 24
        Me.ButtonDebug0.Text = "Debug"
        Me.ButtonDebug0.UseVisualStyleBackColor = True
        '
        'ButtonOpenGameFolder
        '
        Me.ButtonOpenGameFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonOpenGameFolder.Location = New System.Drawing.Point(85, 326)
        Me.ButtonOpenGameFolder.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonOpenGameFolder.Name = "ButtonOpenGameFolder"
        Me.ButtonOpenGameFolder.Size = New System.Drawing.Size(120, 39)
        Me.ButtonOpenGameFolder.TabIndex = 23
        Me.ButtonOpenGameFolder.Text = "Open Folder"
        Me.ButtonOpenGameFolder.UseVisualStyleBackColor = True
        '
        'LabelGameTitle
        '
        Me.LabelGameTitle.AutoSize = True
        Me.LabelGameTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelGameTitle.Location = New System.Drawing.Point(81, 36)
        Me.LabelGameTitle.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LabelGameTitle.Name = "LabelGameTitle"
        Me.LabelGameTitle.Size = New System.Drawing.Size(86, 20)
        Me.LabelGameTitle.TabIndex = 15
        Me.LabelGameTitle.Text = "Game Title"
        '
        'LblGenre
        '
        Me.LblGenre.AutoSize = True
        Me.LblGenre.BackColor = System.Drawing.Color.Transparent
        Me.LblGenre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGenre.Location = New System.Drawing.Point(82, 66)
        Me.LblGenre.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblGenre.Name = "LblGenre"
        Me.LblGenre.Size = New System.Drawing.Size(48, 17)
        Me.LblGenre.TabIndex = 21
        Me.LblGenre.Text = "Genre"
        '
        'ButtonPlayGame
        '
        Me.ButtonPlayGame.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonPlayGame.Location = New System.Drawing.Point(15, 326)
        Me.ButtonPlayGame.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonPlayGame.Name = "ButtonPlayGame"
        Me.ButtonPlayGame.Size = New System.Drawing.Size(60, 39)
        Me.ButtonPlayGame.TabIndex = 20
        Me.ButtonPlayGame.Text = "Play"
        Me.ButtonPlayGame.UseVisualStyleBackColor = True
        '
        'PanelInfo
        '
        Me.PanelInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelInfo.Controls.Add(Me.LabelAppNote)
        Me.PanelInfo.Controls.Add(Me.LabelOperatorNotes)
        Me.PanelInfo.Location = New System.Drawing.Point(15, 375)
        Me.PanelInfo.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelInfo.Name = "PanelInfo"
        Me.PanelInfo.Size = New System.Drawing.Size(582, 169)
        Me.PanelInfo.TabIndex = 19
        '
        'LabelAppNote
        '
        Me.LabelAppNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelAppNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAppNote.Location = New System.Drawing.Point(3, 3)
        Me.LabelAppNote.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelAppNote.Name = "LabelAppNote"
        Me.LabelAppNote.Padding = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.LabelAppNote.Size = New System.Drawing.Size(285, 163)
        Me.LabelAppNote.TabIndex = 10
        Me.LabelAppNote.Text = "Long description of video game." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Video game is a revolutionary genre game. Desc" &
    "ribed by critics as 'pretty good' and players and 'alright'." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sample Text. SAM" &
    "PLE TEXT! ... SaMpLE TexT ⁉"
        '
        'LabelOperatorNotes
        '
        Me.LabelOperatorNotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelOperatorNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOperatorNotes.Location = New System.Drawing.Point(294, 3)
        Me.LabelOperatorNotes.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelOperatorNotes.Name = "LabelOperatorNotes"
        Me.LabelOperatorNotes.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.LabelOperatorNotes.Size = New System.Drawing.Size(285, 163)
        Me.LabelOperatorNotes.TabIndex = 9
        Me.LabelOperatorNotes.Text = "Notes written by the Operator" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This particular game has issues with Discipline." &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A good bug squashing 😩 from Papa Code Protector 🥺 should help"
        '
        'picGameIcon
        '
        Me.picGameIcon.BackColor = System.Drawing.Color.Transparent
        Me.picGameIcon.Location = New System.Drawing.Point(15, 36)
        Me.picGameIcon.Margin = New System.Windows.Forms.Padding(5)
        Me.picGameIcon.Name = "picGameIcon"
        Me.picGameIcon.Size = New System.Drawing.Size(54, 54)
        Me.picGameIcon.TabIndex = 16
        Me.picGameIcon.TabStop = False
        '
        'picPoster
        '
        Me.picPoster.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picPoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPoster.InitialImage = Nothing
        Me.picPoster.Location = New System.Drawing.Point(396, 36)
        Me.picPoster.Margin = New System.Windows.Forms.Padding(5)
        Me.picPoster.Name = "picPoster"
        Me.picPoster.Size = New System.Drawing.Size(200, 300)
        Me.picPoster.TabIndex = 17
        Me.picPoster.TabStop = False
        '
        'picPlatform
        '
        Me.picPlatform.BackColor = System.Drawing.Color.Transparent
        Me.picPlatform.Location = New System.Drawing.Point(1, 2)
        Me.picPlatform.Margin = New System.Windows.Forms.Padding(5)
        Me.picPlatform.Name = "picPlatform"
        Me.picPlatform.Size = New System.Drawing.Size(85, 84)
        Me.picPlatform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picPlatform.TabIndex = 18
        Me.picPlatform.TabStop = False
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 561)
        Me.Controls.Add(Me.ButtonEditOperatorNotes)
        Me.Controls.Add(Me.TabControlGameLists)
        Me.Controls.Add(Me.LblGameDir)
        Me.Controls.Add(Me.ButtonDebug2)
        Me.Controls.Add(Me.ButtonDebug0)
        Me.Controls.Add(Me.ButtonOpenGameFolder)
        Me.Controls.Add(Me.LabelGameTitle)
        Me.Controls.Add(Me.LblGenre)
        Me.Controls.Add(Me.ButtonPlayGame)
        Me.Controls.Add(Me.PanelInfo)
        Me.Controls.Add(Me.picGameIcon)
        Me.Controls.Add(Me.picPoster)
        Me.Controls.Add(Me.picPlatform)
        Me.Controls.Add(Me.ButtonPSXLaunch)
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Game"
        Me.Text = "Game"
        Me.Controls.SetChildIndex(Me.ButtonPSXLaunch, 0)
        Me.Controls.SetChildIndex(Me.picPlatform, 0)
        Me.Controls.SetChildIndex(Me.picPoster, 0)
        Me.Controls.SetChildIndex(Me.picGameIcon, 0)
        Me.Controls.SetChildIndex(Me.PanelInfo, 0)
        Me.Controls.SetChildIndex(Me.ButtonPlayGame, 0)
        Me.Controls.SetChildIndex(Me.LblGenre, 0)
        Me.Controls.SetChildIndex(Me.LabelGameTitle, 0)
        Me.Controls.SetChildIndex(Me.ButtonOpenGameFolder, 0)
        Me.Controls.SetChildIndex(Me.ButtonDebug0, 0)
        Me.Controls.SetChildIndex(Me.ButtonDebug2, 0)
        Me.Controls.SetChildIndex(Me.LblGameDir, 0)
        Me.Controls.SetChildIndex(Me.TabControlGameLists, 0)
        Me.Controls.SetChildIndex(Me.ButtonEditOperatorNotes, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxClose, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMax, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMinimize, 0)
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlGameLists.ResumeLayout(False)
        Me.TabPageGameWinList.ResumeLayout(False)
        Me.TabPageGameXboxList.ResumeLayout(False)
        Me.TabPageGamePlaystationList.ResumeLayout(False)
        Me.TabPageGameNintendoList.ResumeLayout(False)
        Me.PanelInfo.ResumeLayout(False)
        CType(Me.picGameIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPoster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlatform, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonPSXLaunch As Button
    Friend WithEvents ButtonEditOperatorNotes As Button
    Friend WithEvents TabControlGameLists As TabControl
    Friend WithEvents TabPageGameWinList As TabPage
    Friend WithEvents ListGamesWin As ListBox
    Friend WithEvents TabPageGameXboxList As TabPage
    Friend WithEvents ListGamesXbox As ListBox
    Friend WithEvents TabPageGamePlaystationList As TabPage
    Friend WithEvents ListGamesPlaystation As ListBox
    Friend WithEvents TabPageGameNintendoList As TabPage
    Friend WithEvents ListGamesNintendo As ListBox
    Friend WithEvents LblGameDir As Label
    Friend WithEvents ButtonDebug2 As Button
    Friend WithEvents ButtonDebug0 As Button
    Friend WithEvents ButtonOpenGameFolder As Button
    Friend WithEvents LabelGameTitle As Label
    Friend WithEvents LblGenre As Label
    Friend WithEvents ButtonPlayGame As Button
    Friend WithEvents PanelInfo As Panel
    Friend WithEvents LabelAppNote As Label
    Friend WithEvents LabelOperatorNotes As Label
    Friend WithEvents picGameIcon As PictureBox
    Friend WithEvents picPoster As PictureBox
    Friend WithEvents picPlatform As PictureBox
End Class
