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
        btnCountToZero = New Button()
        Label1 = New Label()
        txtNumberEntered = New TextBox()
        SuspendLayout()
        ' 
        ' btnCountToZero
        ' 
        btnCountToZero.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCountToZero.Location = New Point(90, 245)
        btnCountToZero.Name = "btnCountToZero"
        btnCountToZero.Size = New Size(151, 48)
        btnCountToZero.TabIndex = 0
        btnCountToZero.Text = "Count to zero"
        btnCountToZero.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(105, 135)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 21)
        Label1.TabIndex = 1
        Label1.Text = "Enter Number"
        ' 
        ' txtNumberEntered
        ' 
        txtNumberEntered.Location = New Point(117, 189)
        txtNumberEntered.Name = "txtNumberEntered"
        txtNumberEntered.Size = New Size(97, 23)
        txtNumberEntered.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(385, 450)
        Controls.Add(txtNumberEntered)
        Controls.Add(Label1)
        Controls.Add(btnCountToZero)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCountToZero As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumberEntered As TextBox

End Class
