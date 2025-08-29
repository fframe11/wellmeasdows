<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAppointments
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
        ComboBox1 = New ComboBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        TextBox7 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        AppointmentID = New Label()
        Ward = New Label()
        Panel1 = New Panel()
        Panel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonHighlight
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(TableLayoutPanel1)
        Panel2.Controls.Add(TextBox7)
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(AppointmentID)
        Panel2.Location = New Point(67, 103)
        Panel2.Margin = New Padding(4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1094, 425)
        Panel2.TabIndex = 4
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(738, 166)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(275, 31)
        DateTimePicker1.TabIndex = 24
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(738, 113)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(275, 33)
        ComboBox1.TabIndex = 23
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
        TableLayoutPanel1.Location = New Point(608, 250)
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
        ' TextBox7
        ' 
        TextBox7.Location = New Point(738, 46)
        TextBox7.Margin = New Padding(4)
        TextBox7.Multiline = True
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(274, 42)
        TextBox7.TabIndex = 15
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
        Label8.Location = New Point(608, 172)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(55, 25)
        Label8.TabIndex = 8
        Label8.Text = "Date:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Label7.Location = New Point(604, 121)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(119, 25)
        Label7.TabIndex = 7
        Label7.Text = "Type Patient:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Label6.Location = New Point(604, 58)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(123, 25)
        Label6.TabIndex = 6
        Label6.Text = "Bed Number:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Label4.Location = New Point(61, 312)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 25)
        Label4.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Label3.Location = New Point(61, 250)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 25)
        Label3.TabIndex = 3
        Label3.Text = "Ward ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Label2.Location = New Point(61, 178)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 25)
        Label2.TabIndex = 2
        Label2.Text = "Staff ID:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Label1.Location = New Point(58, 119)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 25)
        Label1.TabIndex = 1
        Label1.Text = "Patient ID:"
        ' 
        ' AppointmentID
        ' 
        AppointmentID.AutoSize = True
        AppointmentID.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        AppointmentID.Location = New Point(61, 58)
        AppointmentID.Margin = New Padding(4, 0, 4, 0)
        AppointmentID.Name = "AppointmentID"
        AppointmentID.Size = New Size(151, 25)
        AppointmentID.TabIndex = 0
        AppointmentID.Text = "Appointment ID:"
        ' 
        ' Ward
        ' 
        Ward.BackColor = SystemColors.ButtonHighlight
        Ward.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Ward.Location = New Point(67, 36)
        Ward.Margin = New Padding(4, 0, 4, 0)
        Ward.Name = "Ward"
        Ward.Size = New Size(210, 53)
        Ward.TabIndex = 3
        Ward.Text = "Appointments"
        Ward.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Location = New Point(-4, 599)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1237, 380)
        Panel1.TabIndex = 5
        ' 
        ' FormAppointments
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightBlue
        ClientSize = New Size(1228, 968)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(Ward)
        Name = "FormAppointments"
        Text = "FormAppointments"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AppointmentID As Label
    Friend WithEvents Ward As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Panel1 As Panel
End Class
