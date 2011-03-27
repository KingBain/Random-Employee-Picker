<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPicker
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
        Me.clbPeople = New System.Windows.Forms.CheckedListBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.numBox = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnRandom = New System.Windows.Forms.Button()
        CType(Me.numBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'clbPeople
        '
        Me.clbPeople.FormattingEnabled = True
        Me.clbPeople.Location = New System.Drawing.Point(11, 109)
        Me.clbPeople.Name = "clbPeople"
        Me.clbPeople.Size = New System.Drawing.Size(176, 199)
        Me.clbPeople.TabIndex = 0
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(13, 13)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "Load People"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'numBox
        '
        Me.numBox.Enabled = False
        Me.numBox.Location = New System.Drawing.Point(125, 42)
        Me.numBox.Name = "numBox"
        Me.numBox.Size = New System.Drawing.Size(47, 20)
        Me.numBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "# of People needed"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(112, 13)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnRandom
        '
        Me.btnRandom.Enabled = False
        Me.btnRandom.Location = New System.Drawing.Point(13, 69)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(173, 28)
        Me.btnRandom.TabIndex = 5
        Me.btnRandom.Text = "Generate"
        Me.btnRandom.UseVisualStyleBackColor = True
        '
        'frmPicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(199, 310)
        Me.Controls.Add(Me.btnRandom)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numBox)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.clbPeople)
        Me.Name = "frmPicker"
        Me.Text = "OverTime Generator"
        CType(Me.numBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents clbPeople As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents numBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnRandom As System.Windows.Forms.Button

End Class
