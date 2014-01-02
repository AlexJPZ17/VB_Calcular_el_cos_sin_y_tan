<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox_Angulo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_Run = New System.Windows.Forms.Button()
        Me.ComboBox_Funciones = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'TextBox_Angulo
        '
        Me.TextBox_Angulo.Location = New System.Drawing.Point(26, 60)
        Me.TextBox_Angulo.Name = "TextBox_Angulo"
        Me.TextBox_Angulo.Size = New System.Drawing.Size(75, 20)
        Me.TextBox_Angulo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese Angulo"
        '
        'Button_Run
        '
        Me.Button_Run.Location = New System.Drawing.Point(82, 142)
        Me.Button_Run.Name = "Button_Run"
        Me.Button_Run.Size = New System.Drawing.Size(75, 23)
        Me.Button_Run.TabIndex = 3
        Me.Button_Run.Text = "Run"
        Me.Button_Run.UseVisualStyleBackColor = True
        '
        'ComboBox_Funciones
        '
        Me.ComboBox_Funciones.FormattingEnabled = True
        Me.ComboBox_Funciones.Items.AddRange(New Object() {"Cos", "Sin", "Tan"})
        Me.ComboBox_Funciones.Location = New System.Drawing.Point(138, 60)
        Me.ComboBox_Funciones.Name = "ComboBox_Funciones"
        Me.ComboBox_Funciones.Size = New System.Drawing.Size(89, 21)
        Me.ComboBox_Funciones.TabIndex = 4
        Me.ComboBox_Funciones.Text = "Funciones"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 258)
        Me.Controls.Add(Me.ComboBox_Funciones)
        Me.Controls.Add(Me.Button_Run)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_Angulo)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_Angulo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button_Run As System.Windows.Forms.Button
    Friend WithEvents ComboBox_Funciones As System.Windows.Forms.ComboBox

End Class
