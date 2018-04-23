Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication4
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.checkButton1 = New DevExpress.XtraEditors.CheckButton()
			Me.checkButton2 = New DevExpress.XtraEditors.CheckButton()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.checkButton3 = New DevExpress.XtraEditors.CheckButton()
			Me.checkButton4 = New DevExpress.XtraEditors.CheckButton()
			Me.checkButton5 = New DevExpress.XtraEditors.CheckButton()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' checkButton1
			' 
			Me.checkButton1.GroupIndex = 0
			Me.checkButton1.Location = New System.Drawing.Point(19, 146)
			Me.checkButton1.Name = "checkButton1"
			Me.checkButton1.Size = New System.Drawing.Size(75, 23)
			Me.checkButton1.TabIndex = 2
			Me.checkButton1.Text = "checkButton1"
			' 
			' checkButton2
			' 
			Me.checkButton2.GroupIndex = 0
			Me.checkButton2.Location = New System.Drawing.Point(19, 117)
			Me.checkButton2.Name = "checkButton2"
			Me.checkButton2.Size = New System.Drawing.Size(75, 23)
			Me.checkButton2.TabIndex = 3
			Me.checkButton2.Text = "checkButton2"
			' 
			' groupControl1
			' 
			Me.groupControl1.Controls.Add(Me.checkButton5)
			Me.groupControl1.Controls.Add(Me.checkButton4)
			Me.groupControl1.Controls.Add(Me.checkButton3)
			Me.groupControl1.Controls.Add(Me.checkButton1)
			Me.groupControl1.Controls.Add(Me.checkButton2)
			Me.groupControl1.Location = New System.Drawing.Point(130, 12)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(111, 190)
			Me.groupControl1.TabIndex = 4
			Me.groupControl1.Text = "groupControl1"
			' 
			' checkButton3
			' 
			Me.checkButton3.GroupIndex = 0
			Me.checkButton3.Location = New System.Drawing.Point(19, 30)
			Me.checkButton3.Name = "checkButton3"
			Me.checkButton3.Size = New System.Drawing.Size(75, 23)
			Me.checkButton3.TabIndex = 4
			Me.checkButton3.TabStop = False
			Me.checkButton3.Text = "checkButton3"
			' 
			' checkButton4
			' 
			Me.checkButton4.GroupIndex = 0
			Me.checkButton4.Location = New System.Drawing.Point(19, 59)
			Me.checkButton4.Name = "checkButton4"
			Me.checkButton4.Size = New System.Drawing.Size(75, 23)
			Me.checkButton4.TabIndex = 5
			Me.checkButton4.TabStop = False
			Me.checkButton4.Text = "checkButton4"
			' 
			' checkButton5
			' 
			Me.checkButton5.GroupIndex = 0
			Me.checkButton5.Location = New System.Drawing.Point(19, 88)
			Me.checkButton5.Name = "checkButton5"
			Me.checkButton5.Size = New System.Drawing.Size(75, 23)
			Me.checkButton5.TabIndex = 6
			Me.checkButton5.TabStop = False
			Me.checkButton5.Text = "checkButton5"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(792, 379)
			Me.Controls.Add(Me.groupControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private checkButton1 As DevExpress.XtraEditors.CheckButton
		Private checkButton2 As DevExpress.XtraEditors.CheckButton
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private checkButton5 As DevExpress.XtraEditors.CheckButton
		Private checkButton4 As DevExpress.XtraEditors.CheckButton
		Private checkButton3 As DevExpress.XtraEditors.CheckButton

	End Class
End Namespace

