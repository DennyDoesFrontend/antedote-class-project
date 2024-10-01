Imports FontAwesome.Sharp

Public Class Form1
    'Fields
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentFormChild As Form

    'Constructor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)

    End Sub
    'methods
    Private Sub ActiveButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(49, 55, 73)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

            'Left Border
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()

            'current Form Icon
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor

        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(36, 39, 50)
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        'Open Only Form
        If currentFormChild IsNot Nothing Then
            currentFormChild.Close()
        End If
        currentFormChild = childForm
        'end
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle.Text = childForm.Text
    End Sub

    'ButtonClickEvents
    Private Sub btnHomeScreen_Click(sender As Object, e As EventArgs) Handles btnHomeScreen.Click
        ActiveButton(sender, RGBColors.color1)
        OpenChildForm(New FormHomeScreen)
    End Sub
    Private Sub btnMakeNewNotes_Click(sender As Object, e As EventArgs) Handles btnMakeNewNotes.Click
        ActiveButton(sender, RGBColors.color1)
        OpenChildForm(New FormMakeNewNote)
    End Sub

    Private Sub btnFocusMode_Click(sender As Object, e As EventArgs) Handles btnFocusMode.Click
        ActiveButton(sender, RGBColors.color1)
        OpenChildForm(New FormFocusMode)
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        ActiveButton(sender, RGBColors.color1)
        OpenChildForm(New FormFocusMode)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If currentFormChild IsNot Nothing Then
            currentFormChild.Close()
        End If
        Reset()
    End Sub

    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.House
        IconCurrentForm.IconColor = Color.FromArgb(90, 150, 223)
        lblFormTitle.Text = "Home"
    End Sub
End Class