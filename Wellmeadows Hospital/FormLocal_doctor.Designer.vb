<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLocal_doctor
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
        Panel1 = New Panel()
        TextBox5 = New TextBox()
        TextBox2 = New TextBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label5 = New Label()
        TextBox4 = New TextBox()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Ward = New Label()
        Panel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.HighlightText
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Ward)
        Panel1.Location = New Point(2, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(743, 974)
        Panel1.TabIndex = 0
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(375, 318)
        TextBox5.Margin = New Padding(4)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(255, 36)
        TextBox5.TabIndex = 78
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(375, 481)
        TextBox2.Margin = New Padding(4)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(255, 36)
        TextBox2.TabIndex = 77
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Controls.Add(Button1, 0, 0)
        TableLayoutPanel1.Controls.Add(Button2, 1, 0)
        TableLayoutPanel1.Controls.Add(Button3, 2, 0)
        TableLayoutPanel1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TableLayoutPanel1.Location = New Point(183, 561)
        TableLayoutPanel1.Margin = New Padding(4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 55F))
        TableLayoutPanel1.Size = New Size(409, 55)
        TableLayoutPanel1.TabIndex = 74
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Button1.Dock = DockStyle.Fill
        Button1.Font = New Font("Segoe UI", 10.2F)
        Button1.Location = New Point(4, 4)
        Button1.Margin = New Padding(4)
        Button1.Name = "Button1"
        Button1.Size = New Size(128, 47)
        Button1.TabIndex = 0
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Yellow
        Button2.Dock = DockStyle.Fill
        Button2.Font = New Font("Segoe UI", 10.2F)
        Button2.Location = New Point(140, 4)
        Button2.Margin = New Padding(4)
        Button2.Name = "Button2"
        Button2.Size = New Size(128, 47)
        Button2.TabIndex = 1
        Button2.Text = "Edit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Red
        Button3.Dock = DockStyle.Fill
        Button3.Font = New Font("Segoe UI", 10.2F)
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Location = New Point(276, 4)
        Button3.Margin = New Padding(4)
        Button3.Name = "Button3"
        Button3.Size = New Size(129, 47)
        Button3.TabIndex = 2
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Label5.Location = New Point(125, 485)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(38, 24)
        Label5.TabIndex = 72
        Label5.Text = "Tel:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(375, 426)
        TextBox4.Margin = New Padding(4)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(255, 36)
        TextBox4.TabIndex = 71
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Label4.Location = New Point(125, 430)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 24)
        Label4.TabIndex = 70
        Label4.Text = "Address: "
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(375, 378)
        TextBox3.Margin = New Padding(4)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(255, 36)
        TextBox3.TabIndex = 69
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Label3.Location = New Point(125, 378)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 24)
        Label3.TabIndex = 68
        Label3.Text = "Clinic number:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Label2.Location = New Point(125, 322)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 24)
        Label2.TabIndex = 67
        Label2.Text = "Name:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(375, 267)
        TextBox1.Margin = New Padding(4)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(255, 36)
        TextBox1.TabIndex = 66
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Label1.Location = New Point(125, 267)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 24)
        Label1.TabIndex = 65
        Label1.Text = "Local Doctor id:"
        ' 
        ' Ward
        ' 
        Ward.BackColor = SystemColors.ButtonHighlight
        Ward.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Ward.Location = New Point(213, 180)
        Ward.Margin = New Padding(4, 0, 4, 0)
        Ward.Name = "Ward"
        Ward.Size = New Size(330, 48)
        Ward.TabIndex = 64
        Ward.Text = "Local Doctor"
        Ward.TextAlign = ContentAlignment.TopCenter
        ' 
        ' FormLocal_doctor
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        ClientSize = New Size(1394, 901)
        Controls.Add(Panel1)
        Name = "FormLocal_doctor"
        Text = "Local Doctor"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Ward As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
