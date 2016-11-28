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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkSpecialSummon = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbSTPos = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.originalOpponent = New System.Windows.Forms.RadioButton()
        Me.originalPlayer = New System.Windows.Forms.RadioButton()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.nUDCardSelector = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnPublish = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cmbMPos = New System.Windows.Forms.ComboBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nUDZone = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbLocation = New System.Windows.Forms.ComboBox()
        Me.currentOpponent = New System.Windows.Forms.RadioButton()
        Me.currentPlayer = New System.Windows.Forms.RadioButton()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstCards = New System.Windows.Forms.ListBox()
        Me.lstEnglish = New System.Windows.Forms.ListBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.nUDCardSelector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nUDZone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkSpecialSummon)
        Me.GroupBox3.Location = New System.Drawing.Point(536, 275)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(121, 41)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Special"
        '
        'chkSpecialSummon
        '
        Me.chkSpecialSummon.AutoSize = True
        Me.chkSpecialSummon.Enabled = False
        Me.chkSpecialSummon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkSpecialSummon.Location = New System.Drawing.Point(7, 20)
        Me.chkSpecialSummon.Name = "chkSpecialSummon"
        Me.chkSpecialSummon.Size = New System.Drawing.Size(117, 17)
        Me.chkSpecialSummon.TabIndex = 0
        Me.chkSpecialSummon.Text = "Special Summoned"
        Me.chkSpecialSummon.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(6, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Monster"
        '
        'cmbSTPos
        '
        Me.cmbSTPos.FormattingEnabled = True
        Me.cmbSTPos.Items.AddRange(New Object() {"Face-Up", "Face-Down"})
        Me.cmbSTPos.Location = New System.Drawing.Point(156, 34)
        Me.cmbSTPos.Name = "cmbSTPos"
        Me.cmbSTPos.Size = New System.Drawing.Size(121, 21)
        Me.cmbSTPos.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.originalOpponent)
        Me.GroupBox4.Controls.Add(Me.originalPlayer)
        Me.GroupBox4.Location = New System.Drawing.Point(705, 202)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(108, 73)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Original Owner"
        '
        'originalOpponent
        '
        Me.originalOpponent.AutoSize = True
        Me.originalOpponent.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.originalOpponent.Location = New System.Drawing.Point(8, 44)
        Me.originalOpponent.Name = "originalOpponent"
        Me.originalOpponent.Size = New System.Drawing.Size(72, 17)
        Me.originalOpponent.TabIndex = 1
        Me.originalOpponent.TabStop = True
        Me.originalOpponent.Text = "Opponent"
        Me.originalOpponent.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.originalOpponent.UseVisualStyleBackColor = True
        '
        'originalPlayer
        '
        Me.originalPlayer.AutoSize = True
        Me.originalPlayer.Checked = True
        Me.originalPlayer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.originalPlayer.Location = New System.Drawing.Point(8, 20)
        Me.originalPlayer.Name = "originalPlayer"
        Me.originalPlayer.Size = New System.Drawing.Size(54, 17)
        Me.originalPlayer.TabIndex = 0
        Me.originalPlayer.TabStop = True
        Me.originalPlayer.Text = "Player"
        Me.originalPlayer.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Enabled = False
        Me.btnRemove.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRemove.Location = New System.Drawing.Point(199, 470)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(120, 23)
        Me.btnRemove.TabIndex = 42
        Me.btnRemove.Text = "Remove Card"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'nUDCardSelector
        '
        Me.nUDCardSelector.Location = New System.Drawing.Point(199, 441)
        Me.nUDCardSelector.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nUDCardSelector.Name = "nUDCardSelector"
        Me.nUDCardSelector.Size = New System.Drawing.Size(120, 20)
        Me.nUDCardSelector.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(163, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Spell/Trap"
        '
        'btnQuit
        '
        Me.btnQuit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnQuit.Location = New System.Drawing.Point(738, 442)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 38
        Me.btnQuit.Text = "Exit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnView.Location = New System.Drawing.Point(4, 443)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 23)
        Me.btnView.TabIndex = 37
        Me.btnView.Text = "View Code"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnReset.Location = New System.Drawing.Point(85, 472)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 36
        Me.btnReset.Text = "Clear Puzzle"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnPublish
        '
        Me.btnPublish.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPublish.Location = New System.Drawing.Point(4, 472)
        Me.btnPublish.Name = "btnPublish"
        Me.btnPublish.Size = New System.Drawing.Size(75, 23)
        Me.btnPublish.TabIndex = 35
        Me.btnPublish.Text = "Publish"
        Me.btnPublish.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClear.Location = New System.Drawing.Point(649, 442)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 34
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'cmbMPos
        '
        Me.cmbMPos.FormattingEnabled = True
        Me.cmbMPos.Items.AddRange(New Object() {"Face-Up Attack", "Face-Down Defense"})
        Me.cmbMPos.Location = New System.Drawing.Point(0, 34)
        Me.cmbMPos.Name = "cmbMPos"
        Me.cmbMPos.Size = New System.Drawing.Size(121, 21)
        Me.cmbMPos.TabIndex = 0
        '
        'btnLoad
        '
        Me.btnLoad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLoad.Location = New System.Drawing.Point(86, 442)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 43
        Me.btnLoad.Text = "Load Puzzle"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmbSTPos)
        Me.GroupBox2.Controls.Add(Me.cmbMPos)
        Me.GroupBox2.Location = New System.Drawing.Point(536, 369)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(277, 58)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Position"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(699, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Zone Number"
        '
        'nUDZone
        '
        Me.nUDZone.Location = New System.Drawing.Point(693, 335)
        Me.nUDZone.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nUDZone.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nUDZone.Name = "nUDZone"
        Me.nUDZone.Size = New System.Drawing.Size(120, 20)
        Me.nUDZone.TabIndex = 30
        Me.nUDZone.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(539, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Location"
        '
        'cmbLocation
        '
        Me.cmbLocation.FormattingEnabled = True
        Me.cmbLocation.Items.AddRange(New Object() {"Monster Zone", "Spell/Trap Zone", "Hand", "Deck", "Graveyard", "Banished", "Extra Deck"})
        Me.cmbLocation.Location = New System.Drawing.Point(536, 335)
        Me.cmbLocation.Name = "cmbLocation"
        Me.cmbLocation.Size = New System.Drawing.Size(121, 21)
        Me.cmbLocation.TabIndex = 28
        '
        'currentOpponent
        '
        Me.currentOpponent.AutoSize = True
        Me.currentOpponent.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.currentOpponent.Location = New System.Drawing.Point(8, 44)
        Me.currentOpponent.Name = "currentOpponent"
        Me.currentOpponent.Size = New System.Drawing.Size(72, 17)
        Me.currentOpponent.TabIndex = 1
        Me.currentOpponent.TabStop = True
        Me.currentOpponent.Text = "Opponent"
        Me.currentOpponent.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.currentOpponent.UseVisualStyleBackColor = True
        '
        'currentPlayer
        '
        Me.currentPlayer.AutoSize = True
        Me.currentPlayer.Checked = True
        Me.currentPlayer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.currentPlayer.Location = New System.Drawing.Point(8, 20)
        Me.currentPlayer.Name = "currentPlayer"
        Me.currentPlayer.Size = New System.Drawing.Size(54, 17)
        Me.currentPlayer.TabIndex = 0
        Me.currentPlayer.TabStop = True
        Me.currentPlayer.Text = "Player"
        Me.currentPlayer.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAdd.Location = New System.Drawing.Point(536, 442)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(98, 23)
        Me.btnAdd.TabIndex = 33
        Me.btnAdd.Text = "Add to Puzzle"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.currentOpponent)
        Me.GroupBox1.Controls.Add(Me.currentPlayer)
        Me.GroupBox1.Location = New System.Drawing.Point(536, 202)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(108, 73)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Current Owner"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(536, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Card"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(536, 38)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(142, 20)
        Me.txtSearch.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(224, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Current Puzzle"
        '
        'lstCards
        '
        Me.lstCards.FormattingEnabled = True
        Me.lstCards.Location = New System.Drawing.Point(536, 56)
        Me.lstCards.Name = "lstCards"
        Me.lstCards.Size = New System.Drawing.Size(277, 134)
        Me.lstCards.TabIndex = 44
        '
        'lstEnglish
        '
        Me.lstEnglish.FormattingEnabled = True
        Me.lstEnglish.Location = New System.Drawing.Point(4, 24)
        Me.lstEnglish.Name = "lstEnglish"
        Me.lstEnglish.Size = New System.Drawing.Size(526, 407)
        Me.lstEnglish.TabIndex = 45
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 502)
        Me.Controls.Add(Me.lstEnglish)
        Me.Controls.Add(Me.lstCards)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.nUDCardSelector)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnPublish)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nUDZone)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbLocation)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Puzzle Maker"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.nUDCardSelector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nUDZone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkSpecialSummon As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbSTPos As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents originalOpponent As RadioButton
    Friend WithEvents originalPlayer As RadioButton
    Friend WithEvents btnRemove As Button
    Friend WithEvents nUDCardSelector As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnPublish As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents cmbMPos As ComboBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents nUDZone As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbLocation As ComboBox
    Friend WithEvents currentOpponent As RadioButton
    Friend WithEvents currentPlayer As RadioButton
    Friend WithEvents btnAdd As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lstCards As ListBox
    Friend WithEvents lstEnglish As ListBox
End Class
