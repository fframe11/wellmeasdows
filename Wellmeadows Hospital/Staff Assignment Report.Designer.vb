<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff_Assignment_Report
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
        Label1 = New Label()
        Ward = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Symbol", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(390, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 60)
        Label1.TabIndex = 1
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Ward
        ' 
        Ward.BackColor = SystemColors.ButtonHighlight
        Ward.Font = New Font("Segoe UI Symbol", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Ward.Location = New Point(-209, 41)
        Ward.Name = "Ward"
        Ward.Size = New Size(1661, 97)
        Ward.TabIndex = 7
        Ward.Text = "Employee Assignment Report by Department"
        Ward.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Staff_Assignment_Report
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1208, 953)
        Controls.Add(Ward)
        Controls.Add(Label1)
        Name = "Staff_Assignment_Report"
        Text = "Staff_Assignment_Report"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Ward As Label
End Class
