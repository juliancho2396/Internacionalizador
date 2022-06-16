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
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Procesar = New System.Windows.Forms.Button()
        Me.Seleccionar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Directorio"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(84, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(388, 23)
        Me.TextBox1.TabIndex = 1
        '
        'Procesar
        '
        Me.Procesar.Enabled = False
        Me.Procesar.Location = New System.Drawing.Point(564, 12)
        Me.Procesar.Name = "Procesar"
        Me.Procesar.Size = New System.Drawing.Size(75, 23)
        Me.Procesar.TabIndex = 2
        Me.Procesar.Text = "Procesar"
        Me.Procesar.UseVisualStyleBackColor = True
        '
        'Seleccionar
        '
        Me.Seleccionar.Location = New System.Drawing.Point(481, 12)
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.Size = New System.Drawing.Size(75, 23)
        Me.Seleccionar.TabIndex = 3
        Me.Seleccionar.Text = "Seleccionar"
        Me.Seleccionar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 49)
        Me.Controls.Add(Me.Seleccionar)
        Me.Controls.Add(Me.Procesar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Internacionalizador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Procesar As Button
    Friend WithEvents Seleccionar As Button
End Class
