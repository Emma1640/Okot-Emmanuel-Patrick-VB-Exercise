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
        lblName = New Label()
        lblAge = New Label()
        lblFavoriteColor = New Label()
        txtName = New TextBox()
        txtAge = New TextBox()
        txtFavoriteColor = New TextBox()
        btnShowInformation = New Button()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 12F)
        lblName.Location = New Point(209, 91)
        lblName.Name = "lblName"
        lblName.Size = New Size(52, 21)
        lblName.TabIndex = 0
        lblName.Text = "Name"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Font = New Font("Segoe UI", 12F)
        lblAge.Location = New Point(209, 139)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(37, 21)
        lblAge.TabIndex = 1
        lblAge.Text = "Age"
        ' 
        ' lblFavoriteColor
        ' 
        lblFavoriteColor.AutoSize = True
        lblFavoriteColor.Font = New Font("Segoe UI", 12F)
        lblFavoriteColor.Location = New Point(209, 187)
        lblFavoriteColor.Name = "lblFavoriteColor"
        lblFavoriteColor.Size = New Size(107, 21)
        lblFavoriteColor.TabIndex = 2
        lblFavoriteColor.Text = "Favorite Color"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(350, 89)
        txtName.Name = "txtName"
        txtName.Size = New Size(234, 23)
        txtName.TabIndex = 3
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(350, 137)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(234, 23)
        txtAge.TabIndex = 4
        ' 
        ' txtFavoriteColor
        ' 
        txtFavoriteColor.Location = New Point(350, 185)
        txtFavoriteColor.Name = "txtFavoriteColor"
        txtFavoriteColor.Size = New Size(234, 23)
        txtFavoriteColor.TabIndex = 5
        ' 
        ' btnShowInformation
        ' 
        btnShowInformation.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnShowInformation.Location = New Point(350, 246)
        btnShowInformation.Name = "btnShowInformation"
        btnShowInformation.Size = New Size(177, 32)
        btnShowInformation.TabIndex = 6
        btnShowInformation.Text = "Show Information"
        btnShowInformation.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnShowInformation)
        Controls.Add(txtFavoriteColor)
        Controls.Add(txtAge)
        Controls.Add(txtName)
        Controls.Add(lblFavoriteColor)
        Controls.Add(lblAge)
        Controls.Add(lblName)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblFavoriteColor As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtFavoriteColor As TextBox
    Friend WithEvents btnShowInformation As Button

End Class
