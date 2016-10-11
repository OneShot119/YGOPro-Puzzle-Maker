<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PuzzleMaker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PuzzleMaker))
        Me.txtEnglish = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.currentOpponent = New System.Windows.Forms.RadioButton()
        Me.currentPlayer = New System.Windows.Forms.RadioButton()
        Me.cmbLocation = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nUDZone = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbSTPos = New System.Windows.Forms.ComboBox()
        Me.cmbMPos = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnPublish = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkSpecialSummon = New System.Windows.Forms.CheckBox()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.nUDCardSelector = New System.Windows.Forms.NumericUpDown()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.originalOpponent = New System.Windows.Forms.RadioButton()
        Me.originalPlayer = New System.Windows.Forms.RadioButton()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nUDZone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.nUDCardSelector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtEnglish
        '
        resources.ApplyResources(Me.txtEnglish, "txtEnglish")
        Me.txtEnglish.Name = "txtEnglish"
        Me.txtEnglish.ReadOnly = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'txtSearch
        '
        resources.ApplyResources(Me.txtSearch, "txtSearch")
        Me.txtSearch.Name = "txtSearch"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.currentOpponent)
        Me.GroupBox1.Controls.Add(Me.currentPlayer)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'currentOpponent
        '
        resources.ApplyResources(Me.currentOpponent, "currentOpponent")
        Me.currentOpponent.Name = "currentOpponent"
        Me.currentOpponent.TabStop = True
        Me.currentOpponent.UseVisualStyleBackColor = True
        '
        'currentPlayer
        '
        resources.ApplyResources(Me.currentPlayer, "currentPlayer")
        Me.currentPlayer.Checked = True
        Me.currentPlayer.Name = "currentPlayer"
        Me.currentPlayer.TabStop = True
        Me.currentPlayer.UseVisualStyleBackColor = True
        '
        'cmbLocation
        '
        Me.cmbLocation.FormattingEnabled = True
        Me.cmbLocation.Items.AddRange(New Object() {resources.GetString("cmbLocation.Items"), resources.GetString("cmbLocation.Items1"), resources.GetString("cmbLocation.Items2"), resources.GetString("cmbLocation.Items3"), resources.GetString("cmbLocation.Items4"), resources.GetString("cmbLocation.Items5"), resources.GetString("cmbLocation.Items6")})
        resources.ApplyResources(Me.cmbLocation, "cmbLocation")
        Me.cmbLocation.Name = "cmbLocation"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'nUDZone
        '
        resources.ApplyResources(Me.nUDZone, "nUDZone")
        Me.nUDZone.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nUDZone.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nUDZone.Name = "nUDZone"
        Me.nUDZone.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmbSTPos)
        Me.GroupBox2.Controls.Add(Me.cmbMPos)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'cmbSTPos
        '
        Me.cmbSTPos.FormattingEnabled = True
        Me.cmbSTPos.Items.AddRange(New Object() {resources.GetString("cmbSTPos.Items"), resources.GetString("cmbSTPos.Items1")})
        resources.ApplyResources(Me.cmbSTPos, "cmbSTPos")
        Me.cmbSTPos.Name = "cmbSTPos"
        '
        'cmbMPos
        '
        Me.cmbMPos.FormattingEnabled = True
        Me.cmbMPos.Items.AddRange(New Object() {resources.GetString("cmbMPos.Items"), resources.GetString("cmbMPos.Items1")})
        resources.ApplyResources(Me.cmbMPos, "cmbMPos")
        Me.cmbMPos.Name = "cmbMPos"
        '
        'btnAdd
        '
        resources.ApplyResources(Me.btnAdd, "btnAdd")
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        resources.ApplyResources(Me.btnClear, "btnClear")
        Me.btnClear.Name = "btnClear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnPublish
        '
        resources.ApplyResources(Me.btnPublish, "btnPublish")
        Me.btnPublish.Name = "btnPublish"
        Me.btnPublish.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        resources.ApplyResources(Me.btnReset, "btnReset")
        Me.btnReset.Name = "btnReset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnView
        '
        resources.ApplyResources(Me.btnView, "btnView")
        Me.btnView.Name = "btnView"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        resources.ApplyResources(Me.btnQuit, "btnQuit")
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkSpecialSummon)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'chkSpecialSummon
        '
        resources.ApplyResources(Me.chkSpecialSummon, "chkSpecialSummon")
        Me.chkSpecialSummon.Name = "chkSpecialSummon"
        Me.chkSpecialSummon.UseVisualStyleBackColor = True
        '
        'txtResults
        '
        resources.ApplyResources(Me.txtResults, "txtResults")
        Me.txtResults.Name = "txtResults"
        '
        'nUDCardSelector
        '
        resources.ApplyResources(Me.nUDCardSelector, "nUDCardSelector")
        Me.nUDCardSelector.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nUDCardSelector.Name = "nUDCardSelector"
        '
        'btnRemove
        '
        resources.ApplyResources(Me.btnRemove, "btnRemove")
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.originalOpponent)
        Me.GroupBox4.Controls.Add(Me.originalPlayer)
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        '
        'originalOpponent
        '
        resources.ApplyResources(Me.originalOpponent, "originalOpponent")
        Me.originalOpponent.Name = "originalOpponent"
        Me.originalOpponent.TabStop = True
        Me.originalOpponent.UseVisualStyleBackColor = True
        '
        'originalPlayer
        '
        resources.ApplyResources(Me.originalPlayer, "originalPlayer")
        Me.originalPlayer.Checked = True
        Me.originalPlayer.Name = "originalPlayer"
        Me.originalPlayer.TabStop = True
        Me.originalPlayer.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        resources.ApplyResources(Me.btnLoad, "btnLoad")
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PuzzleMaker
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.nUDCardSelector)
        Me.Controls.Add(Me.txtResults)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnPublish)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nUDZone)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbLocation)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEnglish)
        Me.Name = "PuzzleMaker"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nUDZone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.nUDCardSelector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEnglish As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents currentOpponent As System.Windows.Forms.RadioButton
    Friend WithEvents currentPlayer As System.Windows.Forms.RadioButton
    Friend WithEvents cmbLocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nUDZone As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbSTPos As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMPos As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnPublish As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkSpecialSummon As System.Windows.Forms.CheckBox
    Friend WithEvents txtResults As System.Windows.Forms.TextBox
    Friend WithEvents nUDCardSelector As NumericUpDown
    Friend WithEvents btnRemove As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents originalOpponent As RadioButton
    Friend WithEvents originalPlayer As RadioButton
    Friend WithEvents btnLoad As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
