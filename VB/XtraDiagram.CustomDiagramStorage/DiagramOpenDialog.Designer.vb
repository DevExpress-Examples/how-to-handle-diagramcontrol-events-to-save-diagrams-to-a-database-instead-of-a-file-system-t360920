Namespace XtraDiagram.CustomDiagramStorage
    Partial Public Class DiagramOpenDialog
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
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
            Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
            Me.panel1 = New System.Windows.Forms.Panel()
            DirectCast(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.simpleButton1.Location = New System.Drawing.Point(106, 2)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(75, 27)
            Me.simpleButton1.TabIndex = 0
            Me.simpleButton1.Text = "OK"
            ' 
            ' simpleButton2
            ' 
            Me.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.simpleButton2.Location = New System.Drawing.Point(207, 2)
            Me.simpleButton2.Name = "simpleButton2"
            Me.simpleButton2.Size = New System.Drawing.Size(75, 27)
            Me.simpleButton2.TabIndex = 1
            Me.simpleButton2.Text = "Cancel"
            ' 
            ' listBoxControl1
            ' 
            Me.listBoxControl1.Appearance.Options.UseTextOptions = True
            Me.listBoxControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.listBoxControl1.ItemHeight = 30
            Me.listBoxControl1.Location = New System.Drawing.Point(0, 0)
            Me.listBoxControl1.Name = "listBoxControl1"
            Me.listBoxControl1.Size = New System.Drawing.Size(389, 290)
            Me.listBoxControl1.TabIndex = 2
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.simpleButton2)
            Me.panel1.Controls.Add(Me.simpleButton1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 290)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(389, 32)
            Me.panel1.TabIndex = 3
            ' 
            ' DiagramOpenDialog
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(389, 322)
            Me.Controls.Add(Me.listBoxControl1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "DiagramOpenDialog"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "DiagramSelector"
            DirectCast(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
        Private simpleButton2 As DevExpress.XtraEditors.SimpleButton
        Protected WithEvents listBoxControl1 As DevExpress.XtraEditors.ListBoxControl
        Private panel1 As System.Windows.Forms.Panel
    End Class
End Namespace