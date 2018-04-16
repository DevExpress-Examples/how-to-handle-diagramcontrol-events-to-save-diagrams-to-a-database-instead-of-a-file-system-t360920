Namespace XtraDiagram.CustomDiagramStorage
    Partial Public Class DiagramSaveDialog
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
            Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
            DirectCast(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' listBoxControl1
            ' 
            Me.listBoxControl1.Appearance.Options.UseTextOptions = True
            Me.listBoxControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.listBoxControl1.Size = New System.Drawing.Size(388, 329)
            ' 
            ' textEdit1
            ' 
            Me.textEdit1.Dock = System.Windows.Forms.DockStyle.Top
            Me.textEdit1.Location = New System.Drawing.Point(0, 0)
            Me.textEdit1.Name = "textEdit1"
            Me.textEdit1.Properties.AutoHeight = False
            Me.textEdit1.Size = New System.Drawing.Size(388, 30)
            Me.textEdit1.TabIndex = 4
            ' 
            ' DiagramSaveDialog
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(388, 361)
            Me.Controls.Add(Me.textEdit1)
            Me.Name = "DiagramSaveDialog"
            Me.Text = "DiagramSaveDialog"
            Me.Controls.SetChildIndex(Me.listBoxControl1, 0)
            Me.Controls.SetChildIndex(Me.textEdit1, 0)
            DirectCast(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private textEdit1 As DevExpress.XtraEditors.TextEdit
    End Class
End Namespace