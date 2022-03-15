<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RollOfTheDiceForm
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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileTopTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseInnerTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpTopTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsInnerTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.RollDisplayListBox = New System.Windows.Forms.ListBox()
        Me.RollButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(152, 42)
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(151, 38)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileTopTool, Me.HelpTopTool})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1079, 40)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileTopTool
        '
        Me.FileTopTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseInnerTool})
        Me.FileTopTool.Name = "FileTopTool"
        Me.FileTopTool.Size = New System.Drawing.Size(71, 44)
        Me.FileTopTool.Text = "File"
        '
        'CloseInnerTool
        '
        Me.CloseInnerTool.Name = "CloseInnerTool"
        Me.CloseInnerTool.Size = New System.Drawing.Size(359, 44)
        Me.CloseInnerTool.Text = "Close"
        '
        'HelpTopTool
        '
        Me.HelpTopTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstructionsInnerTool})
        Me.HelpTopTool.Name = "HelpTopTool"
        Me.HelpTopTool.Size = New System.Drawing.Size(84, 36)
        Me.HelpTopTool.Text = "Help"
        '
        'InstructionsInnerTool
        '
        Me.InstructionsInnerTool.Name = "InstructionsInnerTool"
        Me.InstructionsInnerTool.Size = New System.Drawing.Size(359, 44)
        Me.InstructionsInnerTool.Text = "Instructions"
        '
        'RollDisplayListBox
        '
        Me.RollDisplayListBox.Font = New System.Drawing.Font("Lucida Console", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RollDisplayListBox.FormattingEnabled = True
        Me.RollDisplayListBox.ItemHeight = 21
        Me.RollDisplayListBox.Location = New System.Drawing.Point(25, 59)
        Me.RollDisplayListBox.Name = "RollDisplayListBox"
        Me.RollDisplayListBox.Size = New System.Drawing.Size(1021, 403)
        Me.RollDisplayListBox.TabIndex = 2
        Me.RollDisplayListBox.TabStop = False
        '
        'RollButton
        '
        Me.RollButton.Location = New System.Drawing.Point(322, 494)
        Me.RollButton.Name = "RollButton"
        Me.RollButton.Size = New System.Drawing.Size(227, 93)
        Me.RollButton.TabIndex = 1
        Me.RollButton.Text = "&Roll"
        Me.RollButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(571, 494)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(227, 93)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(819, 494)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(227, 93)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'RollOfTheDiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1079, 599)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.RollButton)
        Me.Controls.Add(Me.RollDisplayListBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RollOfTheDiceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Roll of the Dice"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents FileTopTool As Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseInnerTool As Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpTopTool As Windows.Forms.ToolStripMenuItem
    Friend WithEvents RollDisplayListBox As Windows.Forms.ListBox
    Friend WithEvents RollButton As Windows.Forms.Button
    Friend WithEvents ClearButton As Windows.Forms.Button
    Friend WithEvents ExitButton As Windows.Forms.Button
    Friend WithEvents InstructionsInnerTool As Windows.Forms.ToolStripMenuItem
End Class
