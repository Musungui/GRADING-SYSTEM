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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TxtSubject1 = New TextBox()
        TxtSubject2 = New TextBox()
        TxtSubject3 = New TextBox()
        LblAverage = New Label()
        LblGrade = New Label()
        Label4 = New Label()
        Label5 = New Label()
        BtnAverage = New Button()
        BtnGrade = New Button()
        BtnClear = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(219, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 20)
        Label1.TabIndex = 0
        Label1.Text = "Subject 1:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(219, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 20)
        Label2.TabIndex = 1
        Label2.Text = "Subject 2:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(219, 170)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 20)
        Label3.TabIndex = 2
        Label3.Text = "Subject 3:"
        ' 
        ' TxtSubject1
        ' 
        TxtSubject1.Location = New Point(307, 62)
        TxtSubject1.Name = "TxtSubject1"
        TxtSubject1.Size = New Size(189, 27)
        TxtSubject1.TabIndex = 3
        ' 
        ' TxtSubject2
        ' 
        TxtSubject2.AcceptsTab = True
        TxtSubject2.Location = New Point(307, 116)
        TxtSubject2.Name = "TxtSubject2"
        TxtSubject2.Size = New Size(189, 27)
        TxtSubject2.TabIndex = 4
        ' 
        ' TxtSubject3
        ' 
        TxtSubject3.Location = New Point(307, 163)
        TxtSubject3.Name = "TxtSubject3"
        TxtSubject3.Size = New Size(189, 27)
        TxtSubject3.TabIndex = 5
        ' 
        ' LblAverage
        ' 
        LblAverage.BorderStyle = BorderStyle.Fixed3D
        LblAverage.Location = New Point(307, 230)
        LblAverage.Name = "LblAverage"
        LblAverage.Size = New Size(189, 34)
        LblAverage.TabIndex = 8
        ' 
        ' LblGrade
        ' 
        LblGrade.BorderStyle = BorderStyle.Fixed3D
        LblGrade.Location = New Point(307, 284)
        LblGrade.Name = "LblGrade"
        LblGrade.Size = New Size(189, 34)
        LblGrade.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(219, 231)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 20)
        Label4.TabIndex = 10
        Label4.Text = "Average:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(219, 298)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 20)
        Label5.TabIndex = 11
        Label5.Text = "Grade:"
        ' 
        ' BtnAverage
        ' 
        BtnAverage.Location = New Point(116, 392)
        BtnAverage.Name = "BtnAverage"
        BtnAverage.Size = New Size(94, 29)
        BtnAverage.TabIndex = 12
        BtnAverage.Text = "Average"
        BtnAverage.UseVisualStyleBackColor = True
        ' 
        ' BtnGrade
        ' 
        BtnGrade.Location = New Point(343, 392)
        BtnGrade.Name = "BtnGrade"
        BtnGrade.Size = New Size(94, 29)
        BtnGrade.TabIndex = 13
        BtnGrade.Text = "Grade"
        BtnGrade.UseVisualStyleBackColor = True
        ' 
        ' BtnClear
        ' 
        BtnClear.Location = New Point(542, 392)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(94, 29)
        BtnClear.TabIndex = 14
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnClear)
        Controls.Add(BtnGrade)
        Controls.Add(BtnAverage)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(LblGrade)
        Controls.Add(LblAverage)
        Controls.Add(TxtSubject3)
        Controls.Add(TxtSubject2)
        Controls.Add(TxtSubject1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "GRADING SYSTEM"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtSubject1 As TextBox
    Friend WithEvents TxtSubject2 As TextBox
    Friend WithEvents TxtSubject3 As TextBox
    Friend WithEvents LblAverage As Label
    Friend WithEvents LblGrade As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnAverage As Button
    Friend WithEvents BtnGrade As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents Label4 As Label
End Class
