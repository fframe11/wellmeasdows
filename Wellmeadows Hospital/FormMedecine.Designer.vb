<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMedecine
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
        Panel2 = New Panel()
        DateTimePicker1 = New DateTimePicker()
        TableLayoutPanel1 = New TableLayoutPanel()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label6 = New Label()
        TextBox5 = New TextBox()
        Label5 = New Label()
        TextBox4 = New TextBox()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Ward = New Label()
        TextBox6 = New TextBox()
        Label7 = New Label()
        TextBox7 = New TextBox()
        Label8 = New Label()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Azure
        Panel2.Location = New Point(607, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(602, 988)
        Panel2.TabIndex = 6
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(249, 387)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(205, 27)
        DateTimePicker1.TabIndex = 43
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
        TableLayoutPanel1.Location = New Point(127, 530)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(327, 44)
        TableLayoutPanel1.TabIndex = 42
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Button1.Dock = DockStyle.Fill
        Button1.Font = New Font("Segoe UI", 10.2F)
        Button1.Location = New Point(3, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 38)
        Button1.TabIndex = 0
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Yellow
        Button2.Dock = DockStyle.Fill
        Button2.Font = New Font("Segoe UI", 10.2F)
        Button2.Location = New Point(112, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(103, 38)
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
        Button3.Location = New Point(221, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(103, 38)
        Button3.TabIndex = 2
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Label6.Location = New Point(73, 387)
        Label6.Name = "Label6"
        Label6.Size = New Size(146, 24)
        Label6.TabIndex = 41
        Label6.Text = "Expiration Data:"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(249, 346)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(205, 30)
        TextBox5.TabIndex = 40
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Label5.Location = New Point(73, 346)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 24)
        Label5.TabIndex = 39
        Label5.Text = "Price:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(249, 310)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(205, 30)
        TextBox4.TabIndex = 38
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Label4.Location = New Point(73, 307)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 24)
        Label4.TabIndex = 37
        Label4.Text = "Unit:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(249, 266)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(205, 30)
        TextBox3.TabIndex = 36
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Label3.Location = New Point(73, 266)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 24)
        Label3.TabIndex = 35
        Label3.Text = "Dosage:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(249, 221)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(205, 30)
        TextBox2.TabIndex = 34
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Label2.Location = New Point(73, 221)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 24)
        Label2.TabIndex = 33
        Label2.Text = "Name:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(249, 177)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(205, 30)
        TextBox1.TabIndex = 32
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Label1.Location = New Point(73, 177)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 24)
        Label1.TabIndex = 31
        Label1.Text = "Medecine id:"
        ' 
        ' Ward
        ' 
        Ward.BackColor = SystemColors.ButtonHighlight
        Ward.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Ward.Location = New Point(154, 59)
        Ward.Name = "Ward"
        Ward.Size = New Size(264, 38)
        Ward.TabIndex = 30
        Ward.Text = "Medecine Stock"
        Ward.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(249, 429)
        TextBox6.Multiline = True
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(205, 30)
        TextBox6.TabIndex = 45
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Label7.Location = New Point(73, 429)
        Label7.Name = "Label7"
        Label7.Size = New Size(128, 24)
        Label7.TabIndex = 44
        Label7.Text = "Drug number:"
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(249, 467)
        TextBox7.Multiline = True
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(205, 30)
        TextBox7.TabIndex = 47
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Label8.Location = New Point(73, 467)
        Label8.Name = "Label8"
        Label8.Size = New Size(97, 24)
        Label8.TabIndex = 46
        Label8.Text = "Stock Qty:"
        ' 
        ' Medecine
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1208, 953)
        Controls.Add(TextBox7)
        Controls.Add(Label8)
        Controls.Add(TextBox6)
        Controls.Add(Label7)
        Controls.Add(DateTimePicker1)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Label6)
        Controls.Add(TextBox5)
        Controls.Add(Label5)
        Controls.Add(TextBox4)
        Controls.Add(Label4)
        Controls.Add(TextBox3)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Ward)
        Controls.Add(Panel2)
        Name = "Medecine"
        Text = "Medecine"
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Ward As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label8 As Label
End Class
