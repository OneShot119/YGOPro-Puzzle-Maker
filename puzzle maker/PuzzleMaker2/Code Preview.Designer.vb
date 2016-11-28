<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Code_Preview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Code_Preview))
        Me.txtCodePreview = New System.Windows.Forms.TextBox()
        Me.btnClose2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCodePreview
        '
        Me.txtCodePreview.Location = New System.Drawing.Point(13, 13)
        Me.txtCodePreview.Multiline = True
        Me.txtCodePreview.Name = "txtCodePreview"
        Me.txtCodePreview.Size = New System.Drawing.Size(586, 415)
        Me.txtCodePreview.TabIndex = 0
        '
        'btnClose2
        '
        Me.btnClose2.Location = New System.Drawing.Point(267, 434)
        Me.btnClose2.Name = "btnClose2"
        Me.btnClose2.Size = New System.Drawing.Size(75, 23)
        Me.btnClose2.TabIndex = 1
        Me.btnClose2.Text = "Close"
        Me.btnClose2.UseVisualStyleBackColor = True
        '
        'Code_Preview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 464)
        Me.Controls.Add(Me.btnClose2)
        Me.Controls.Add(Me.txtCodePreview)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Code_Preview"
        Me.Text = "Code_Preview"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCodePreview As TextBox
    Friend WithEvents btnClose2 As Button
End Class
