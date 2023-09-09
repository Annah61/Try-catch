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
        Label1 = New Label()
        txtInput = New TextBox()
        btnNumeric = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(96, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 25)
        Label1.TabIndex = 0
        Label1.Text = "Enter a Number"
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(260, 79)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(214, 31)
        txtInput.TabIndex = 1
        ' 
        ' btnNumeric
        ' 
        btnNumeric.Location = New Point(240, 193)
        btnNumeric.Name = "btnNumeric"
        btnNumeric.Size = New Size(201, 34)
        btnNumeric.TabIndex = 2
        btnNumeric.Text = "Show Number"
        btnNumeric.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnNumeric)
        Controls.Add(txtInput)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnNumeric As Button
End Class
