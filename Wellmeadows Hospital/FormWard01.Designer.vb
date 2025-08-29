<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormWard01
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
        Ward = New Label()
        Panel2 = New Panel()
        Button8 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        TextBox9 = New TextBox()
        TextBox8 = New TextBox()
        TextBox7 = New TextBox()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        wardID = New Label()
        Panel1 = New Panel()
        Panel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Ward
        ' 
        Ward.BackColor = SystemColors.ButtonHighlight
        Ward.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Ward.Location = New Point(15, 25)
        Ward.Margin = New Padding(4, 0, 4, 0)
        Ward.Name = "Ward"
        Ward.Size = New Size(204, 48)
        Ward.TabIndex = 0
        Ward.Text = "Ward"
        Ward.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonHighlight
        Panel2.Controls.Add(Button8)
        Panel2.Controls.Add(Button7)
        Panel2.Controls.Add(Button6)
        Panel2.Controls.Add(Button5)
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(TableLayoutPanel1)
        Panel2.Controls.Add(TextBox9)
        Panel2.Controls.Add(TextBox8)
        Panel2.Controls.Add(TextBox7)
        Panel2.Controls.Add(TextBox6)
        Panel2.Controls.Add(TextBox5)
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(wardID)
        Panel2.Location = New Point(15, 89)
        Panel2.Margin = New Padding(4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1426, 468)
        Panel2.TabIndex = 2
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.HotPink
        Button8.Location = New Point(896, 364)
        Button8.Margin = New Padding(4)
        Button8.Name = "Button8"
        Button8.Size = New Size(116, 48)
        Button8.TabIndex = 23
        Button8.Text = "Search"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Orange
        Button7.Location = New Point(1102, 204)
        Button7.Margin = New Padding(4)
        Button7.Name = "Button7"
        Button7.Size = New Size(236, 49)
        Button7.TabIndex = 22
        Button7.Text = "Requistion Form"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.LightGreen
        Button6.Location = New Point(1102, 148)
        Button6.Margin = New Padding(4)
        Button6.Name = "Button6"
        Button6.Size = New Size(236, 49)
        Button6.TabIndex = 21
        Button6.Text = "Appointments"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button5.Location = New Point(1102, 91)
        Button5.Margin = New Padding(4)
        Button5.Name = "Button5"
        Button5.Size = New Size(236, 49)
        Button5.TabIndex = 20
        Button5.Text = "Report patient"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.DeepSkyBlue
        Button4.Location = New Point(1102, 35)
        Button4.Margin = New Padding(4)
        Button4.Name = "Button4"
        Button4.Size = New Size(236, 49)
        Button4.TabIndex = 19
        Button4.Text = "Patients on hold"
        Button4.UseVisualStyleBackColor = False
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
        TableLayoutPanel1.Location = New Point(604, 269)
        TableLayoutPanel1.Margin = New Padding(4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 55F))
        TableLayoutPanel1.Size = New Size(409, 55)
        TableLayoutPanel1.TabIndex = 18
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
        ' TextBox9
        ' 
        TextBox9.Location = New Point(738, 166)
        TextBox9.Margin = New Padding(4)
        TextBox9.Multiline = True
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(274, 42)
        TextBox9.TabIndex = 17
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(738, 108)
        TextBox8.Margin = New Padding(4)
        TextBox8.Multiline = True
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(274, 42)
        TextBox8.TabIndex = 16
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(738, 46)
        TextBox7.Margin = New Padding(4)
        TextBox7.Multiline = True
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(274, 42)
        TextBox7.TabIndex = 15
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(204, 369)
        TextBox6.Margin = New Padding(4)
        TextBox6.Multiline = True
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(274, 42)
        TextBox6.TabIndex = 14
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(204, 301)
        TextBox5.Margin = New Padding(4)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(274, 42)
        TextBox5.TabIndex = 13
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(204, 231)
        TextBox4.Margin = New Padding(4)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(274, 42)
        TextBox4.TabIndex = 12
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(204, 166)
        TextBox3.Margin = New Padding(4)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(274, 42)
        TextBox3.TabIndex = 11
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(204, 108)
        TextBox2.Margin = New Padding(4)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(274, 42)
        TextBox2.TabIndex = 10
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(204, 46)
        TextBox1.Margin = New Padding(4)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(274, 42)
        TextBox1.TabIndex = 9
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Label8.Location = New Point(604, 178)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(98, 25)
        Label8.TabIndex = 8
        Label8.Text = "Patient ID:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Label7.Location = New Point(604, 121)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(77, 25)
        Label7.TabIndex = 7
        Label7.Text = "Shift ID:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Label6.Location = New Point(604, 58)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 25)
        Label6.TabIndex = 6
        Label6.Text = "Ward Tel:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Label5.Location = New Point(61, 380)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 25)
        Label5.TabIndex = 5
        Label5.Text = "Staff ID:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Label4.Location = New Point(61, 312)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 25)
        Label4.TabIndex = 4
        Label4.Text = "Bed Total:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Label3.Location = New Point(61, 250)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 25)
        Label3.TabIndex = 3
        Label3.Text = "Location:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Label2.Location = New Point(61, 178)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 25)
        Label2.TabIndex = 2
        Label2.Text = "Last name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Label1.Location = New Point(58, 119)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 25)
        Label1.TabIndex = 1
        Label1.Text = "First name:"
        ' 
        ' wardID
        ' 
        wardID.AutoSize = True
        wardID.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        wardID.Location = New Point(61, 58)
        wardID.Margin = New Padding(4, 0, 4, 0)
        wardID.Name = "wardID"
        wardID.Size = New Size(82, 25)
        wardID.TabIndex = 0
        wardID.Text = "Ward ID:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Location = New Point(-6, 728)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1469, 448)
        Panel1.TabIndex = 3
        ' 
        ' FormWard01
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightBlue
        ClientSize = New Size(1456, 1175)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(Ward)
        Margin = New Padding(4)
        Name = "FormWard01"
        Text = "FormWard01"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Ward As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents wardID As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel1 As Panel
End Class
