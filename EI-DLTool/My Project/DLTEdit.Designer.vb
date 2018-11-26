<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DLTEdit
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
        Me.MachineModelTextBox = New System.Windows.Forms.TextBox()
        Me.HyperthermTypeTextBox = New System.Windows.Forms.TextBox()
        Me.TkNameTextBox = New System.Windows.Forms.TextBox()
        Me.URLTextBox = New System.Windows.Forms.TextBox()
        Me.BuildTextBox = New System.Windows.Forms.TextBox()
        Me.MachineConfigLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Commit = New System.Windows.Forms.Button()
        Me.CancelSaveButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MachineModelTextBox
        '
        Me.MachineModelTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.MachineModelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MachineModelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MachineModelTextBox.Location = New System.Drawing.Point(10, 82)
        Me.MachineModelTextBox.Name = "MachineModelTextBox"
        Me.MachineModelTextBox.Size = New System.Drawing.Size(74, 26)
        Me.MachineModelTextBox.TabIndex = 0
        Me.MachineModelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HyperthermTypeTextBox
        '
        Me.HyperthermTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HyperthermTypeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HyperthermTypeTextBox.Location = New System.Drawing.Point(115, 82)
        Me.HyperthermTypeTextBox.Name = "HyperthermTypeTextBox"
        Me.HyperthermTypeTextBox.Size = New System.Drawing.Size(74, 26)
        Me.HyperthermTypeTextBox.TabIndex = 1
        Me.HyperthermTypeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TkNameTextBox
        '
        Me.TkNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TkNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TkNameTextBox.Location = New System.Drawing.Point(10, 148)
        Me.TkNameTextBox.Name = "TkNameTextBox"
        Me.TkNameTextBox.Size = New System.Drawing.Size(106, 26)
        Me.TkNameTextBox.TabIndex = 2
        Me.TkNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'URLTextBox
        '
        Me.URLTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.URLTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.URLTextBox.Location = New System.Drawing.Point(10, 216)
        Me.URLTextBox.Name = "URLTextBox"
        Me.URLTextBox.Size = New System.Drawing.Size(489, 26)
        Me.URLTextBox.TabIndex = 3
        '
        'BuildTextBox
        '
        Me.BuildTextBox.AccessibleName = "BuildTextBox"
        Me.BuildTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BuildTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuildTextBox.Location = New System.Drawing.Point(10, 285)
        Me.BuildTextBox.Name = "BuildTextBox"
        Me.BuildTextBox.Size = New System.Drawing.Size(34, 26)
        Me.BuildTextBox.TabIndex = 4
        Me.BuildTextBox.Tag = ""
        Me.BuildTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MachineConfigLabel
        '
        Me.MachineConfigLabel.AutoSize = True
        Me.MachineConfigLabel.BackColor = System.Drawing.Color.Transparent
        Me.MachineConfigLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MachineConfigLabel.ForeColor = System.Drawing.Color.OldLace
        Me.MachineConfigLabel.Location = New System.Drawing.Point(3, 59)
        Me.MachineConfigLabel.Name = "MachineConfigLabel"
        Me.MachineConfigLabel.Size = New System.Drawing.Size(218, 20)
        Me.MachineConfigLabel.TabIndex = 5
        Me.MachineConfigLabel.Text = "Machine Configuration Name "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.OldLace
        Me.Label1.Location = New System.Drawing.Point(90, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "+"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.OldLace
        Me.Label2.Location = New System.Drawing.Point(6, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(329, 29)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Machine Profile Configuration"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.OldLace
        Me.Label3.Location = New System.Drawing.Point(3, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Installer Title (e.g. 600XPR)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.OldLace
        Me.Label4.Location = New System.Drawing.Point(3, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "DokuWiki Table URL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.OldLace
        Me.Label5.Location = New System.Drawing.Point(3, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Installer Build Number"
        '
        'Commit
        '
        Me.Commit.BackColor = System.Drawing.Color.Transparent
        Me.Commit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Commit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Commit.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Commit.Location = New System.Drawing.Point(13, 349)
        Me.Commit.Name = "Commit"
        Me.Commit.Size = New System.Drawing.Size(109, 32)
        Me.Commit.TabIndex = 11
        Me.Commit.Text = "Save Changes"
        Me.Commit.UseVisualStyleBackColor = False
        '
        'CancelSaveButton
        '
        Me.CancelSaveButton.BackColor = System.Drawing.Color.Transparent
        Me.CancelSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CancelSaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelSaveButton.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.CancelSaveButton.Location = New System.Drawing.Point(393, 349)
        Me.CancelSaveButton.Name = "CancelSaveButton"
        Me.CancelSaveButton.Size = New System.Drawing.Size(109, 32)
        Me.CancelSaveButton.TabIndex = 12
        Me.CancelSaveButton.Text = "Cancel"
        Me.CancelSaveButton.UseVisualStyleBackColor = False
        '
        'DLTEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EI_DLTool.My.Resources.Resources.beautiful_color_gradients_backgrounds_100_vicious_stance
        Me.ClientSize = New System.Drawing.Size(514, 389)
        Me.Controls.Add(Me.CancelSaveButton)
        Me.Controls.Add(Me.Commit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MachineConfigLabel)
        Me.Controls.Add(Me.BuildTextBox)
        Me.Controls.Add(Me.URLTextBox)
        Me.Controls.Add(Me.TkNameTextBox)
        Me.Controls.Add(Me.HyperthermTypeTextBox)
        Me.Controls.Add(Me.MachineModelTextBox)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Name = "DLTEdit"
        Me.Text = "Edit Configuration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MachineModelTextBox As TextBox
    Friend WithEvents HyperthermTypeTextBox As TextBox
    Friend WithEvents TkNameTextBox As TextBox
    Friend WithEvents URLTextBox As TextBox
    Friend WithEvents BuildTextBox As TextBox
    Friend WithEvents MachineConfigLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Commit As Button
    Friend WithEvents CancelSaveButton As Button
End Class
