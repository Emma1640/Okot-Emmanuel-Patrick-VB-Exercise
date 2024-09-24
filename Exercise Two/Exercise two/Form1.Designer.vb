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
        lblEnterANumnber = New Label()
        txtNumber = New TextBox()
        btnEvaluate = New Button()
        SuspendLayout()
        ' 
        ' lblEnterANumnber
        ' 
        lblEnterANumnber.AutoSize = True
        lblEnterANumnber.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEnterANumnber.Location = New Point(78, 73)
        lblEnterANumnber.Name = "lblEnterANumnber"
        lblEnterANumnber.Size = New Size(121, 21)
        lblEnterANumnber.TabIndex = 0
        lblEnterANumnber.Text = "Enter a number"
        ' 
        ' txtNumber
        ' 
        txtNumber.Location = New Point(104, 114)
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(69, 23)
        txtNumber.TabIndex = 1
        ' 
        ' btnEvaluate
        ' 
        btnEvaluate.Location = New Point(84, 157)
        btnEvaluate.Name = "btnEvaluate"
        btnEvaluate.Size = New Size(108, 39)
        btnEvaluate.TabIndex = 2
        btnEvaluate.Text = "Evaluate"
        btnEvaluate.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(302, 286)
        Controls.Add(btnEvaluate)
        Controls.Add(txtNumber)
        Controls.Add(lblEnterANumnber)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblEnterANumnber As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents btnEvaluate As Button

End Class
