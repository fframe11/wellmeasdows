<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Panel1 = New Panel()
        Panel2 = New Panel()
        btnLogout = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        PictureBox1 = New PictureBox()
        btnWord = New Button()
        btnPatient = New Button()
        btnpatient1 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        Button1 = New Button()
        pnlMain = New Panel()
        pnlWard = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightBlue
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(212, 1175)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnLogout)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 1106)
        Panel2.Margin = New Padding(4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(212, 69)
        Panel2.TabIndex = 1
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnLogout.Dock = DockStyle.Fill
        btnLogout.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = SystemColors.ButtonHighlight
        btnLogout.Location = New Point(0, 0)
        btnLogout.Margin = New Padding(4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(212, 69)
        btnLogout.TabIndex = 0
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel1.Controls.Add(btnWord, 0, 1)
        TableLayoutPanel1.Controls.Add(btnPatient, 0, 2)
        TableLayoutPanel1.Controls.Add(btnpatient1, 0, 3)
        TableLayoutPanel1.Controls.Add(Button3, 0, 4)
        TableLayoutPanel1.Controls.Add(Button4, 0, 5)
        TableLayoutPanel1.Controls.Add(Button5, 0, 6)
        TableLayoutPanel1.Controls.Add(Button6, 0, 7)
        TableLayoutPanel1.Controls.Add(Button7, 0, 8)
        TableLayoutPanel1.Controls.Add(Button8, 0, 9)
        TableLayoutPanel1.Controls.Add(Button9, 0, 10)
        TableLayoutPanel1.Controls.Add(Button1, 0, 11)
        TableLayoutPanel1.Dock = DockStyle.Top
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 12
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.39076F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.360926F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.360926F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.360926F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.360926F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.360926F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.360926F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.360926F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.360926F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.360926F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.360926F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.Size = New Size(212, 825)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._78
        PictureBox1.Location = New Point(4, 4)
        PictureBox1.Margin = New Padding(4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(204, 116)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnWord
        ' 
        btnWord.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        btnWord.Location = New Point(4, 128)
        btnWord.Margin = New Padding(4)
        btnWord.Name = "btnWord"
        btnWord.Size = New Size(204, 55)
        btnWord.TabIndex = 1
        btnWord.Text = "Home"
        btnWord.UseVisualStyleBackColor = True
        ' 
        ' btnPatient
        ' 
        btnPatient.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        btnPatient.Location = New Point(4, 191)
        btnPatient.Margin = New Padding(4)
        btnPatient.Name = "btnPatient"
        btnPatient.Size = New Size(204, 55)
        btnPatient.TabIndex = 2
        btnPatient.Text = "Ward"
        btnPatient.UseVisualStyleBackColor = True
        ' 
        ' btnpatient1
        ' 
        btnpatient1.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        btnpatient1.Location = New Point(4, 254)
        btnpatient1.Margin = New Padding(4)
        btnpatient1.Name = "btnpatient1"
        btnpatient1.Size = New Size(204, 55)
        btnpatient1.TabIndex = 3
        btnpatient1.Text = "Patient"
        btnpatient1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Button3.Location = New Point(4, 317)
        Button3.Margin = New Padding(4)
        Button3.Name = "Button3"
        Button3.Size = New Size(204, 55)
        Button3.TabIndex = 4
        Button3.Text = "Treatment"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Button4.Location = New Point(4, 380)
        Button4.Margin = New Padding(4)
        Button4.Name = "Button4"
        Button4.Size = New Size(204, 55)
        Button4.TabIndex = 5
        Button4.Text = "Payment"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Button5.Location = New Point(4, 443)
        Button5.Margin = New Padding(4)
        Button5.Name = "Button5"
        Button5.Size = New Size(204, 55)
        Button5.TabIndex = 6
        Button5.Text = "Staff"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Button6.Location = New Point(4, 506)
        Button6.Margin = New Padding(4)
        Button6.Name = "Button6"
        Button6.Size = New Size(204, 55)
        Button6.TabIndex = 7
        Button6.Text = "Medecine"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Button7.Location = New Point(4, 569)
        Button7.Margin = New Padding(4)
        Button7.Name = "Button7"
        Button7.Size = New Size(204, 55)
        Button7.TabIndex = 8
        Button7.Text = "Shifting"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Button8.Location = New Point(4, 632)
        Button8.Margin = New Padding(4)
        Button8.Name = "Button8"
        Button8.Size = New Size(204, 55)
        Button8.TabIndex = 9
        Button8.Text = "Item Stock"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Button9.Location = New Point(4, 695)
        Button9.Margin = New Padding(4)
        Button9.Name = "Button9"
        Button9.Size = New Size(204, 55)
        Button9.TabIndex = 10
        Button9.Text = "Product"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(4, 758)
        Button1.Margin = New Padding(4)
        Button1.Name = "Button1"
        Button1.Size = New Size(204, 55)
        Button1.TabIndex = 11
        Button1.Text = "Supplier"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.Azure
        pnlMain.Controls.Add(pnlWard)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(212, 0)
        pnlMain.Margin = New Padding(4)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1298, 1175)
        pnlMain.TabIndex = 1
        ' 
        ' pnlWard
        ' 
        pnlWard.Dock = DockStyle.Fill
        pnlWard.Location = New Point(0, 0)
        pnlWard.Margin = New Padding(4)
        pnlWard.Name = "pnlWard"
        pnlWard.Size = New Size(1298, 1175)
        pnlWard.TabIndex = 0
        ' 
        ' FormHome
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1510, 1175)
        Controls.Add(pnlMain)
        Controls.Add(Panel1)
        Margin = New Padding(4)
        Name = "FormHome"
        Text = "FormMain"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlMain.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnWord As Button
    Friend WithEvents btnPatient As Button
    Friend WithEvents btnpatient1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents pnlWard As Panel

End Class
