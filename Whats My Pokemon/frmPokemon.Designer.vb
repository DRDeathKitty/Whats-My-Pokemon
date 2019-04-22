<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPokemon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPokemon))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.picPokemon = New System.Windows.Forms.PictureBox()
        Me.lblMonthBorn = New System.Windows.Forms.Label()
        Me.lblDayBorn = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.lblPokemon = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPokeDex = New System.Windows.Forms.Label()
        Me.btnWeb = New System.Windows.Forms.Button()
        Me.txtDayBorn = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtMonthBorn = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSigniture = New System.Windows.Forms.Label()
        CType(Me.picPokemon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(11, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 25)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(44, 20)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(36, 16)
        Me.lblAge.TabIndex = 1
        Me.lblAge.Text = "Age"
        '
        'picPokemon
        '
        Me.picPokemon.BackColor = System.Drawing.Color.Transparent
        Me.picPokemon.Location = New System.Drawing.Point(12, 32)
        Me.picPokemon.Name = "picPokemon"
        Me.picPokemon.Size = New System.Drawing.Size(210, 210)
        Me.picPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPokemon.TabIndex = 2
        Me.picPokemon.TabStop = False
        '
        'lblMonthBorn
        '
        Me.lblMonthBorn.AutoSize = True
        Me.lblMonthBorn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthBorn.Location = New System.Drawing.Point(0, 70)
        Me.lblMonthBorn.Name = "lblMonthBorn"
        Me.lblMonthBorn.Size = New System.Drawing.Size(85, 16)
        Me.lblMonthBorn.TabIndex = 4
        Me.lblMonthBorn.Text = "Month Born"
        '
        'lblDayBorn
        '
        Me.lblDayBorn.AutoSize = True
        Me.lblDayBorn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDayBorn.Location = New System.Drawing.Point(15, 45)
        Me.lblDayBorn.Name = "lblDayBorn"
        Me.lblDayBorn.Size = New System.Drawing.Size(72, 16)
        Me.lblDayBorn.TabIndex = 3
        Me.lblDayBorn.Text = "Day Born"
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(117, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(105, 25)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnRun
        '
        Me.btnRun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRun.Location = New System.Drawing.Point(12, 281)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(160, 37)
        Me.btnRun.TabIndex = 4
        Me.btnRun.Text = "What's My Pokemon"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'lblPokemon
        '
        Me.lblPokemon.AutoSize = True
        Me.lblPokemon.BackColor = System.Drawing.Color.Transparent
        Me.lblPokemon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPokemon.Location = New System.Drawing.Point(15, 245)
        Me.lblPokemon.Name = "lblPokemon"
        Me.lblPokemon.Size = New System.Drawing.Size(201, 16)
        Me.lblPokemon.TabIndex = 7
        Me.lblPokemon.Text = "Your Pokemon Is XXXXXXXX"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 437)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "My controls are up there. ^"
        '
        'lblPokeDex
        '
        Me.lblPokeDex.AutoSize = True
        Me.lblPokeDex.BackColor = System.Drawing.Color.Transparent
        Me.lblPokeDex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPokeDex.Location = New System.Drawing.Point(37, 262)
        Me.lblPokeDex.Name = "lblPokeDex"
        Me.lblPokeDex.Size = New System.Drawing.Size(160, 16)
        Me.lblPokeDex.TabIndex = 10
        Me.lblPokeDex.Text = "PokeDex Number XXX"
        '
        'btnWeb
        '
        Me.btnWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeb.Location = New System.Drawing.Point(178, 281)
        Me.btnWeb.Name = "btnWeb"
        Me.btnWeb.Size = New System.Drawing.Size(44, 37)
        Me.btnWeb.TabIndex = 5
        Me.btnWeb.Text = "Web"
        Me.btnWeb.UseVisualStyleBackColor = True
        '
        'txtDayBorn
        '
        Me.txtDayBorn.Location = New System.Drawing.Point(86, 44)
        Me.txtDayBorn.Name = "txtDayBorn"
        Me.txtDayBorn.Size = New System.Drawing.Size(118, 20)
        Me.txtDayBorn.TabIndex = 2
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(86, 19)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(117, 20)
        Me.txtAge.TabIndex = 1
        '
        'txtMonthBorn
        '
        Me.txtMonthBorn.Location = New System.Drawing.Point(86, 69)
        Me.txtMonthBorn.Name = "txtMonthBorn"
        Me.txtMonthBorn.Size = New System.Drawing.Size(117, 20)
        Me.txtMonthBorn.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Yellow
        Me.GroupBox1.Controls.Add(Me.txtMonthBorn)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.txtDayBorn)
        Me.GroupBox1.Controls.Add(Me.lblMonthBorn)
        Me.GroupBox1.Controls.Add(Me.lblDayBorn)
        Me.GroupBox1.Controls.Add(Me.lblAge)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 324)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'lblSigniture
        '
        Me.lblSigniture.AutoSize = True
        Me.lblSigniture.BackColor = System.Drawing.Color.Transparent
        Me.lblSigniture.Font = New System.Drawing.Font("Stencil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSigniture.Location = New System.Drawing.Point(21, 41)
        Me.lblSigniture.Name = "lblSigniture"
        Me.lblSigniture.Size = New System.Drawing.Size(192, 18)
        Me.lblSigniture.TabIndex = 11
        Me.lblSigniture.Text = "Made by DR.DeathKitty"
        '
        'frmPokemon
        '
        Me.AcceptButton = Me.btnRun
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Whats_My_Pokemon.My.Resources.Resources.Pokedex
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(234, 436)
        Me.Controls.Add(Me.lblSigniture)
        Me.Controls.Add(Me.btnWeb)
        Me.Controls.Add(Me.lblPokeDex)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPokemon)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.picPokemon)
        Me.Controls.Add(Me.btnExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(265, 513)
        Me.Name = "frmPokemon"
        Me.Text = "WMP"
        CType(Me.picPokemon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents lblAge As Label
    Friend WithEvents picPokemon As PictureBox
    Friend WithEvents lblMonthBorn As Label
    Friend WithEvents lblDayBorn As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnRun As Button
    Friend WithEvents lblPokemon As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPokeDex As Label
    Friend WithEvents btnWeb As Button
    Friend WithEvents txtMonthBorn As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtDayBorn As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblSigniture As Label
End Class
