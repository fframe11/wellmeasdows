<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPayment
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
        Label10 = New Label()
        Label9 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        Button2 = New Button()
        Button3 = New Button()
        Button9 = New Button()
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
        Ward = New Label()
        Button1 = New Button()
        Panel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Controls.Add(TextBox9)
        Panel1.Controls.Add(TextBox8)
        Panel1.Controls.Add(TextBox7)
        Panel1.Controls.Add(TextBox6)
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(wardID)
        Panel1.Location = New Point(48, 120)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1287, 415)
        Panel1.TabIndex = 0
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Label10.Location = New Point(960, 195)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(109, 25)
        Label10.TabIndex = 44
        Label10.Text = "Last Name  "
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Label9.Location = New Point(798, 195)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(112, 25)
        Label9.TabIndex = 43
        Label9.Text = "First Name  "
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Controls.Add(Button2, 0, 0)
        TableLayoutPanel1.Controls.Add(Button3, 1, 0)
        TableLayoutPanel1.Controls.Add(Button9, 2, 0)
        TableLayoutPanel1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TableLayoutPanel1.Location = New Point(649, 323)
        TableLayoutPanel1.Margin = New Padding(4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 55F))
        TableLayoutPanel1.Size = New Size(409, 55)
        TableLayoutPanel1.TabIndex = 42
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Button2.Dock = DockStyle.Fill
        Button2.Font = New Font("Segoe UI", 10.2F)
        Button2.Location = New Point(4, 4)
        Button2.Margin = New Padding(4)
        Button2.Name = "Button2"
        Button2.Size = New Size(128, 47)
        Button2.TabIndex = 0
        Button2.Text = "Add"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Yellow
        Button3.Dock = DockStyle.Fill
        Button3.Font = New Font("Segoe UI", 10.2F)
        Button3.Location = New Point(140, 4)
        Button3.Margin = New Padding(4)
        Button3.Name = "Button3"
        Button3.Size = New Size(128, 47)
        Button3.TabIndex = 1
        Button3.Text = "Edit"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.Red
        Button9.Dock = DockStyle.Fill
        Button9.Font = New Font("Segoe UI", 10.2F)
        Button9.ForeColor = SystemColors.ButtonHighlight
        Button9.Location = New Point(276, 4)
        Button9.Margin = New Padding(4)
        Button9.Name = "Button9"
        Button9.Size = New Size(129, 47)
        Button9.TabIndex = 2
        Button9.Text = "Delete"
        Button9.UseVisualStyleBackColor = False
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(798, 144)
        TextBox9.Margin = New Padding(4)
        TextBox9.Multiline = True
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(274, 42)
        TextBox9.TabIndex = 41
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(798, 86)
        TextBox8.Margin = New Padding(4)
        TextBox8.Multiline = True
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(274, 42)
        TextBox8.TabIndex = 40
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(798, 33)
        TextBox7.Margin = New Padding(4)
        TextBox7.Multiline = True
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(274, 42)
        TextBox7.TabIndex = 39
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(798, 228)
        TextBox6.Margin = New Padding(4)
        TextBox6.Multiline = True
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(274, 42)
        TextBox6.TabIndex = 38
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(276, 244)
        TextBox5.Margin = New Padding(4)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(274, 42)
        TextBox5.TabIndex = 37
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(276, 194)
        TextBox4.Margin = New Padding(4)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(274, 42)
        TextBox4.TabIndex = 36
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(276, 144)
        TextBox3.Margin = New Padding(4)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(274, 42)
        TextBox3.TabIndex = 35
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(276, 86)
        TextBox2.Margin = New Padding(4)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(274, 42)
        TextBox2.TabIndex = 34
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(276, 33)
        TextBox1.Margin = New Padding(4)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(274, 42)
        TextBox1.TabIndex = 33
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Label8.Location = New Point(638, 158)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(98, 25)
        Label8.TabIndex = 32
        Label8.Text = "Patient ID:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Label7.Location = New Point(638, 103)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(159, 25)
        Label7.TabIndex = 31
        Label7.Text = "PaymentMethod :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Label6.Location = New Point(638, 45)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(152, 25)
        Label6.TabIndex = 30
        Label6.Text = "Pay_amountpaid:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Label5.Location = New Point(638, 242)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(139, 25)
        Label5.TabIndex = 29
        Label5.Text = " Insurance ID:   "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Label4.Location = New Point(110, 258)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 25)
        Label4.TabIndex = 28
        Label4.Text = "Reference No:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Label3.Location = New Point(107, 211)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(164, 25)
        Label3.TabIndex = 27
        Label3.Text = "Payment Location:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Label2.Location = New Point(107, 158)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(153, 25)
        Label2.TabIndex = 26
        Label2.Text = "Receipt Number:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Label1.Location = New Point(107, 103)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 25)
        Label1.TabIndex = 25
        Label1.Text = "Payment Date:"
        ' 
        ' wardID
        ' 
        wardID.AutoSize = True
        wardID.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        wardID.Location = New Point(107, 50)
        wardID.Margin = New Padding(4, 0, 4, 0)
        wardID.Name = "wardID"
        wardID.Size = New Size(111, 25)
        wardID.TabIndex = 24
        wardID.Text = "Payment ID:"
        ' 
        ' Ward
        ' 
        Ward.BackColor = SystemColors.ButtonHighlight
        Ward.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Ward.Location = New Point(578, 47)
        Ward.Margin = New Padding(4, 0, 4, 0)
        Ward.Name = "Ward"
        Ward.Size = New Size(204, 48)
        Ward.TabIndex = 1
        Ward.Text = "Payment"
        Ward.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Pink
        Button1.Location = New Point(1218, 47)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 48)
        Button1.TabIndex = 2
        Button1.Text = "Bill"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' FormPayment
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightBlue
        ClientSize = New Size(1386, 824)
        Controls.Add(Button1)
        Controls.Add(Ward)
        Controls.Add(Panel1)
        Name = "FormPayment"
        Text = "FormPayment"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Ward As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents wardID As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
End Class
