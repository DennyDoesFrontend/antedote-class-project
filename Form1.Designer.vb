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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        IconDropDownButton1 = New FontAwesome.Sharp.IconDropDownButton()
        PanelMenu = New Panel()
        btnSettings = New FontAwesome.Sharp.IconButton()
        btnFocusMode = New FontAwesome.Sharp.IconButton()
        btnMakeNewNotes = New FontAwesome.Sharp.IconButton()
        btnHomeScreen = New FontAwesome.Sharp.IconButton()
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        lblFormTitle = New Label()
        IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        PanelDesktop = New Panel()
        TextBox1 = New TextBox()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        PanelMenu.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(IconCurrentForm, ComponentModel.ISupportInitialize).BeginInit()
        PanelDesktop.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' IconDropDownButton1
        ' 
        IconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None
        IconDropDownButton1.IconColor = Color.Black
        IconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconDropDownButton1.Name = "IconDropDownButton1"
        IconDropDownButton1.Size = New Size(23, 23)
        IconDropDownButton1.Text = "IconDropDownButton1"
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.FromArgb(CByte(36), CByte(39), CByte(50))
        PanelMenu.Controls.Add(btnSettings)
        PanelMenu.Controls.Add(btnFocusMode)
        PanelMenu.Controls.Add(btnMakeNewNotes)
        PanelMenu.Controls.Add(btnHomeScreen)
        PanelMenu.Controls.Add(Panel1)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 0)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(224, 509)
        PanelMenu.TabIndex = 0
        ' 
        ' btnSettings
        ' 
        btnSettings.Dock = DockStyle.Top
        btnSettings.FlatAppearance.BorderSize = 0
        btnSettings.FlatStyle = FlatStyle.Popup
        btnSettings.ForeColor = Color.White
        btnSettings.IconChar = FontAwesome.Sharp.IconChar.Cog
        btnSettings.IconColor = Color.White
        btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSettings.ImageAlign = ContentAlignment.MiddleLeft
        btnSettings.Location = New Point(0, 280)
        btnSettings.Name = "btnSettings"
        btnSettings.Padding = New Padding(10, 0, 20, 0)
        btnSettings.Size = New Size(224, 60)
        btnSettings.TabIndex = 4
        btnSettings.Text = "Settings"
        btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSettings.UseVisualStyleBackColor = True
        ' 
        ' btnFocusMode
        ' 
        btnFocusMode.Dock = DockStyle.Top
        btnFocusMode.FlatAppearance.BorderColor = Color.FromArgb(CByte(36), CByte(39), CByte(50))
        btnFocusMode.FlatStyle = FlatStyle.Popup
        btnFocusMode.ForeColor = Color.White
        btnFocusMode.IconChar = FontAwesome.Sharp.IconChar.ClockFour
        btnFocusMode.IconColor = Color.White
        btnFocusMode.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnFocusMode.ImageAlign = ContentAlignment.MiddleLeft
        btnFocusMode.Location = New Point(0, 220)
        btnFocusMode.Name = "btnFocusMode"
        btnFocusMode.Padding = New Padding(10, 0, 20, 0)
        btnFocusMode.Size = New Size(224, 60)
        btnFocusMode.TabIndex = 3
        btnFocusMode.Text = "Focus Mode"
        btnFocusMode.TextImageRelation = TextImageRelation.ImageBeforeText
        btnFocusMode.UseVisualStyleBackColor = True
        ' 
        ' btnMakeNewNotes
        ' 
        btnMakeNewNotes.BackgroundImageLayout = ImageLayout.None
        btnMakeNewNotes.Dock = DockStyle.Top
        btnMakeNewNotes.FlatAppearance.BorderColor = Color.FromArgb(CByte(36), CByte(39), CByte(50))
        btnMakeNewNotes.FlatAppearance.BorderSize = 0
        btnMakeNewNotes.FlatStyle = FlatStyle.Popup
        btnMakeNewNotes.ForeColor = Color.White
        btnMakeNewNotes.IconChar = FontAwesome.Sharp.IconChar.NotesMedical
        btnMakeNewNotes.IconColor = Color.White
        btnMakeNewNotes.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnMakeNewNotes.ImageAlign = ContentAlignment.MiddleLeft
        btnMakeNewNotes.Location = New Point(0, 160)
        btnMakeNewNotes.Margin = New Padding(0)
        btnMakeNewNotes.Name = "btnMakeNewNotes"
        btnMakeNewNotes.Padding = New Padding(10, 0, 20, 0)
        btnMakeNewNotes.Size = New Size(224, 60)
        btnMakeNewNotes.TabIndex = 2
        btnMakeNewNotes.Text = "Make New Note"
        btnMakeNewNotes.TextImageRelation = TextImageRelation.ImageBeforeText
        btnMakeNewNotes.UseVisualStyleBackColor = True
        ' 
        ' btnHomeScreen
        ' 
        btnHomeScreen.BackgroundImageLayout = ImageLayout.None
        btnHomeScreen.Dock = DockStyle.Top
        btnHomeScreen.FlatAppearance.BorderColor = Color.FromArgb(CByte(36), CByte(39), CByte(50))
        btnHomeScreen.FlatAppearance.BorderSize = 0
        btnHomeScreen.FlatStyle = FlatStyle.Flat
        btnHomeScreen.ForeColor = Color.White
        btnHomeScreen.IconChar = FontAwesome.Sharp.IconChar.House
        btnHomeScreen.IconColor = Color.White
        btnHomeScreen.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnHomeScreen.ImageAlign = ContentAlignment.MiddleLeft
        btnHomeScreen.Location = New Point(0, 100)
        btnHomeScreen.Name = "btnHomeScreen"
        btnHomeScreen.Padding = New Padding(10, 0, 20, 0)
        btnHomeScreen.Size = New Size(224, 60)
        btnHomeScreen.TabIndex = 1
        btnHomeScreen.Text = "Home Screen"
        btnHomeScreen.TextImageRelation = TextImageRelation.ImageBeforeText
        btnHomeScreen.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(224, 100)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(66, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 30)
        Label1.TabIndex = 1
        Label1.Text = "Antedote"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(15, 27)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(45, 49)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(36), CByte(39), CByte(50))
        Panel2.Controls.Add(lblFormTitle)
        Panel2.Controls.Add(IconCurrentForm)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(224, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(701, 100)
        Panel2.TabIndex = 1
        ' 
        ' lblFormTitle
        ' 
        lblFormTitle.AutoSize = True
        lblFormTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFormTitle.Location = New Point(72, 27)
        lblFormTitle.Name = "lblFormTitle"
        lblFormTitle.Size = New Size(62, 25)
        lblFormTitle.TabIndex = 1
        lblFormTitle.Text = "Home"
        ' 
        ' IconCurrentForm
        ' 
        IconCurrentForm.BackColor = Color.FromArgb(CByte(36), CByte(39), CByte(50))
        IconCurrentForm.ForeColor = Color.FromArgb(CByte(90), CByte(150), CByte(223))
        IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.House
        IconCurrentForm.IconColor = Color.FromArgb(CByte(90), CByte(150), CByte(223))
        IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconCurrentForm.Location = New Point(34, 22)
        IconCurrentForm.Name = "IconCurrentForm"
        IconCurrentForm.Size = New Size(32, 32)
        IconCurrentForm.TabIndex = 0
        IconCurrentForm.TabStop = False
        ' 
        ' PanelDesktop
        ' 
        PanelDesktop.BackColor = Color.FromArgb(CByte(32), CByte(33), CByte(40))
        PanelDesktop.Controls.Add(TextBox1)
        PanelDesktop.Controls.Add(Label2)
        PanelDesktop.Controls.Add(PictureBox2)
        PanelDesktop.Dock = DockStyle.Fill
        PanelDesktop.Location = New Point(224, 100)
        PanelDesktop.Name = "PanelDesktop"
        PanelDesktop.Size = New Size(701, 409)
        PanelDesktop.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.None
        TextBox1.BackColor = Color.FromArgb(CByte(32), CByte(33), CByte(40))
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.White
        TextBox1.Location = New Point(166, 172)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(357, 138)
        TextBox1.TabIndex = 3
        TextBox1.Text = "Welcome to Antedote, your all-in-one study management tool designed to enhance your learning experience!"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(191, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(286, 37)
        Label2.TabIndex = 2
        Label2.Text = "Welcome To Antedote"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(319, 60)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(45, 49)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(925, 509)
        Controls.Add(PanelDesktop)
        Controls.Add(Panel2)
        Controls.Add(PanelMenu)
        ForeColor = SystemColors.ButtonFace
        Name = "Form1"
        Text = " "
        PanelMenu.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(IconCurrentForm, ComponentModel.ISupportInitialize).EndInit()
        PanelDesktop.ResumeLayout(False)
        PanelDesktop.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Private Sub ButtonContinue_Click(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents IconDropDownButton1 As FontAwesome.Sharp.IconDropDownButton
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnHomeScreen As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnFocusMode As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMakeNewNotes As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSettings As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
