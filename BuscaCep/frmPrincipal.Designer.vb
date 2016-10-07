<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtCep = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblStreet = New System.Windows.Forms.Label()
        Me.lblNeighborhood = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblStateInitials = New System.Windows.Forms.Label()
        Me.lblStateName = New System.Windows.Forms.Label()
        Me.lblCep = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblUnique = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(165, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(112, 23)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.Text = "Search Async"
        Me.btnBuscar.UseVisualStyleBackColor = true
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(59, 12)
        Me.txtCep.Mask = "99999-999"
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(100, 23)
        Me.txtCep.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CEP:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Street:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Neighborhood:"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(84, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "City:"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "State Initials:"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "State Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.Location = New System.Drawing.Point(85, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "CEP:"
        '
        'lblStreet
        '
        Me.lblStreet.AutoSize = true
        Me.lblStreet.Location = New System.Drawing.Point(132, 64)
        Me.lblStreet.Name = "lblStreet"
        Me.lblStreet.Size = New System.Drawing.Size(92, 16)
        Me.lblStreet.TabIndex = 9
        Me.lblStreet.Text = "Street result"
        '
        'lblNeighborhood
        '
        Me.lblNeighborhood.AutoSize = true
        Me.lblNeighborhood.Location = New System.Drawing.Point(132, 80)
        Me.lblNeighborhood.Name = "lblNeighborhood"
        Me.lblNeighborhood.Size = New System.Drawing.Size(139, 16)
        Me.lblNeighborhood.TabIndex = 10
        Me.lblNeighborhood.Text = "Neighborhood result"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = true
        Me.lblCity.Location = New System.Drawing.Point(132, 96)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(76, 16)
        Me.lblCity.TabIndex = 11
        Me.lblCity.Text = "City result"
        '
        'lblStateInitials
        '
        Me.lblStateInitials.AutoSize = true
        Me.lblStateInitials.Location = New System.Drawing.Point(132, 112)
        Me.lblStateInitials.Name = "lblStateInitials"
        Me.lblStateInitials.Size = New System.Drawing.Size(133, 16)
        Me.lblStateInitials.TabIndex = 12
        Me.lblStateInitials.Text = "State initials result"
        '
        'lblStateName
        '
        Me.lblStateName.AutoSize = true
        Me.lblStateName.Location = New System.Drawing.Point(132, 128)
        Me.lblStateName.Name = "lblStateName"
        Me.lblStateName.Size = New System.Drawing.Size(127, 16)
        Me.lblStateName.TabIndex = 13
        Me.lblStateName.Text = "State name result"
        '
        'lblCep
        '
        Me.lblCep.AutoSize = true
        Me.lblCep.Location = New System.Drawing.Point(132, 144)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(75, 16)
        Me.lblCep.TabIndex = 14
        Me.lblCep.Text = "CEP result"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.Location = New System.Drawing.Point(63, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Unique:"
        '
        'lblUnique
        '
        Me.lblUnique.AutoSize = true
        Me.lblUnique.Location = New System.Drawing.Point(132, 160)
        Me.lblUnique.Name = "lblUnique"
        Me.lblUnique.Size = New System.Drawing.Size(232, 16)
        Me.lblUnique.TabIndex = 16
        Me.lblUnique.Text = "Unique result (CEP for whole city)"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(283, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Search Sync"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 209)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblUnique)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblCep)
        Me.Controls.Add(Me.lblStateName)
        Me.Controls.Add(Me.lblStateInitials)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblNeighborhood)
        Me.Controls.Add(Me.lblStreet)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCep)
        Me.Controls.Add(Me.btnBuscar)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrincipal"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtCep As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblStreet As Label
    Friend WithEvents lblNeighborhood As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblStateInitials As Label
    Friend WithEvents lblStateName As Label
    Friend WithEvents lblCep As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblUnique As Label
    Friend WithEvents Button1 As Button
End Class
