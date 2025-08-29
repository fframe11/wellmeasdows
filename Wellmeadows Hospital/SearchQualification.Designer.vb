<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchQualification
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
        Button8 = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.PaleVioletRed
        Button8.ForeColor = SystemColors.ControlLightLight
        Button8.Location = New Point(954, 58)
        Button8.Name = "Button8"
        Button8.Size = New Size(129, 46)
        Button8.TabIndex = 31
        Button8.Text = "Search"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(241, 59)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(662, 45)
        TextBox1.TabIndex = 30
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Symbol", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(83, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(152, 46)
        Label1.TabIndex = 29
        Label1.Text = "Staff id :"
        ' 
        ' SearchQualification
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        ClientSize = New Size(1208, 953)
        Controls.Add(Button8)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "SearchQualification"
        Text = "SearchQualification"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button8 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
