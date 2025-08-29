<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPatient
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
        Ward = New Label()
        Panel2 = New Panel()
        Button9 = New Button()
        Label11 = New Label()
        TextBox8 = New TextBox()
        Button8 = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        ComboBox4 = New ComboBox()
        ComboBox3 = New ComboBox()
        ComboBox2 = New ComboBox()
        TextBox7 = New TextBox()
        TextBox4 = New TextBox()
        ComboBox1 = New ComboBox()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label13 = New Label()
        Label12 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button7 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button10 = New Button()
        Panel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Ward
        ' 
        Ward.BackColor = SystemColors.ButtonHighlight
        Ward.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Ward.Location = New Point(44, 28)
        Ward.Margin = New Padding(4, 0, 4, 0)
        Ward.Name = "Ward"
        Ward.Size = New Size(167, 48)
        Ward.TabIndex = 1
        Ward.Text = "Patient"
        Ward.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonHighlight
        Panel2.Controls.Add(Button9)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(TextBox8)
        Panel2.Controls.Add(Button8)
        Panel2.Controls.Add(TableLayoutPanel1)
        Panel2.Controls.Add(ComboBox4)
        Panel2.Controls.Add(ComboBox3)
        Panel2.Controls.Add(ComboBox2)
        Panel2.Controls.Add(TextBox7)
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(TextBox6)
        Panel2.Controls.Add(TextBox5)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(44, 92)
        Panel2.Margin = New Padding(4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1370, 516)
        Panel2.TabIndex = 2
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.PaleVioletRed
        Button9.ForeColor = SystemColors.ControlLightLight
        Button9.Location = New Point(1121, 182)
        Button9.Margin = New Padding(4)
        Button9.Name = "Button9"
        Button9.Size = New Size(55, 36)
        Button9.TabIndex = 45
        Button9.Text = "..."
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Label11.Location = New Point(641, 282)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(67, 24)
        Label11.TabIndex = 33
        Label11.Text = "Status:"
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(858, 182)
        TextBox8.Margin = New Padding(4)
        TextBox8.Multiline = True
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(255, 36)
        TextBox8.TabIndex = 32
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.HotPink
        Button8.Location = New Point(1067, 369)
        Button8.Margin = New Padding(4)
        Button8.Name = "Button8"
        Button8.Size = New Size(132, 47)
        Button8.TabIndex = 27
        Button8.Text = "Search"
        Button8.UseVisualStyleBackColor = False
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
        TableLayoutPanel1.Location = New Point(638, 365)
        TableLayoutPanel1.Margin = New Padding(4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 55F))
        TableLayoutPanel1.Size = New Size(409, 55)
        TableLayoutPanel1.TabIndex = 26
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
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(285, 235)
        ComboBox4.Margin = New Padding(4)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(255, 33)
        ComboBox4.TabIndex = 25
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(858, 228)
        ComboBox3.Margin = New Padding(4)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(255, 33)
        ComboBox3.TabIndex = 24
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(858, 273)
        ComboBox2.Margin = New Padding(4)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(255, 33)
        ComboBox2.TabIndex = 23
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(857, 131)
        TextBox7.Margin = New Padding(4)
        TextBox7.Multiline = True
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(255, 36)
        TextBox7.TabIndex = 22
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(857, 86)
        TextBox4.Margin = New Padding(4)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(255, 36)
        TextBox4.TabIndex = 21
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(285, 187)
        ComboBox1.Margin = New Padding(4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(255, 33)
        ComboBox1.TabIndex = 20
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(285, 276)
        TextBox6.Margin = New Padding(4)
        TextBox6.Multiline = True
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(255, 36)
        TextBox6.TabIndex = 19
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(857, 41)
        TextBox5.Margin = New Padding(4)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(255, 36)
        TextBox5.TabIndex = 18
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(285, 325)
        TextBox3.Margin = New Padding(4)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(255, 36)
        TextBox3.TabIndex = 16
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(285, 90)
        TextBox2.Margin = New Padding(4)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(255, 36)
        TextBox2.TabIndex = 15
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(285, 41)
        TextBox1.Margin = New Padding(4)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(255, 36)
        TextBox1.TabIndex = 14
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Label13.Location = New Point(638, 186)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(145, 24)
        Label13.TabIndex = 13
        Label13.Text = "Local Doctor ID:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Label12.Location = New Point(638, 237)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(146, 24)
        Label12.TabIndex = 12
        Label12.Text = "Type Of Patient:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(285, 140)
        DateTimePicker1.Margin = New Padding(4)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(255, 31)
        DateTimePicker1.TabIndex = 10
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Label10.Location = New Point(638, 138)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(38, 24)
        Label10.TabIndex = 9
        Label10.Text = "Tel:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Label9.Location = New Point(641, 46)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(161, 24)
        Label9.TabIndex = 8
        Label9.Text = "Logical Doctor ID:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Label8.Location = New Point(105, 288)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(128, 24)
        Label8.TabIndex = 7
        Label8.Text = "Date Register:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Label7.Location = New Point(638, 93)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(82, 24)
        Label7.TabIndex = 6
        Label7.Text = "Address:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Label6.Location = New Point(105, 244)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(133, 24)
        Label6.TabIndex = 5
        Label6.Text = "Marital Status:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Label5.Location = New Point(105, 196)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 24)
        Label5.TabIndex = 4
        Label5.Text = "Sex:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Label4.Location = New Point(102, 140)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 24)
        Label4.TabIndex = 3
        Label4.Text = "Date Of Birth:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Label3.Location = New Point(105, 329)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 24)
        Label3.TabIndex = 2
        Label3.Text = "Insurance ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Label2.Location = New Point(102, 90)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 24)
        Label2.TabIndex = 1
        Label2.Text = "Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Label1.Location = New Point(102, 41)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 24)
        Label1.TabIndex = 0
        Label1.Text = "Patient ID:"
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Pink
        Button7.Location = New Point(1174, 24)
        Button7.Margin = New Padding(4)
        Button7.Name = "Button7"
        Button7.Size = New Size(189, 52)
        Button7.TabIndex = 31
        Button7.Text = "LocalDoctor"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Pink
        Button6.Location = New Point(948, 24)
        Button6.Margin = New Padding(4)
        Button6.Name = "Button6"
        Button6.Size = New Size(201, 52)
        Button6.TabIndex = 30
        Button6.Text = "Next of Kin"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Pink
        Button5.Location = New Point(755, 24)
        Button5.Margin = New Padding(4)
        Button5.Name = "Button5"
        Button5.Size = New Size(162, 52)
        Button5.TabIndex = 29
        Button5.Text = "Add Kin"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Pink
        Button4.Location = New Point(546, 24)
        Button4.Margin = New Padding(4)
        Button4.Name = "Button4"
        Button4.Size = New Size(185, 52)
        Button4.TabIndex = 28
        Button4.Text = "OutPatient"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.Pink
        Button10.Location = New Point(342, 24)
        Button10.Name = "Button10"
        Button10.Size = New Size(176, 52)
        Button10.TabIndex = 32
        Button10.Text = "Patient Insurance"
        Button10.UseVisualStyleBackColor = False
        ' 
        ' FormPatient
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightBlue
        ClientSize = New Size(1499, 1175)
        Controls.Add(Button10)
        Controls.Add(Panel2)
        Controls.Add(Ward)
        Controls.Add(Button4)
        Controls.Add(Button7)
        Controls.Add(Button5)
        Controls.Add(Button6)
        Margin = New Padding(4)
        Name = "FormPatient"
        Text = "FormPatient"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Ward As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
End Class
