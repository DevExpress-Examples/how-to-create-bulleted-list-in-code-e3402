﻿Namespace BulletedListExample
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
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.btnSimpleBullet = New System.Windows.Forms.Button()
            Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            DirectCast(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' richEditControl1
            ' 
            Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Left
            Me.richEditControl1.Location = New System.Drawing.Point(0, 0)
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Options.Fields.UseCurrentCultureDateTimeFormat = False
            Me.richEditControl1.Options.MailMerge.KeepLastParagraph = False
            Me.richEditControl1.Size = New System.Drawing.Size(532, 562)
            Me.richEditControl1.TabIndex = 0
            Me.richEditControl1.Text = "richEditControl1"
            ' 
            ' btnSimpleBullet
            ' 
            Me.btnSimpleBullet.Location = New System.Drawing.Point(550, 12)
            Me.btnSimpleBullet.Name = "btnSimpleBullet"
            Me.btnSimpleBullet.Size = New System.Drawing.Size(102, 23)
            Me.btnSimpleBullet.TabIndex = 1
            Me.btnSimpleBullet.Text = "Create bulleted list"
            Me.btnSimpleBullet.UseVisualStyleBackColor = True
            ' 
            ' comboBoxEdit1
            ' 
            Me.comboBoxEdit1.EditValue = (CShort(0))
            Me.comboBoxEdit1.Location = New System.Drawing.Point(620, 75)
            Me.comboBoxEdit1.Name = "comboBoxEdit1"
            Me.comboBoxEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False
            Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEdit1.Properties.Items.AddRange(New Object() { "0", "1", "2"})
            Me.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
            Me.comboBoxEdit1.Size = New System.Drawing.Size(30, 18)
            Me.comboBoxEdit1.TabIndex = 2
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(550, 80)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(67, 13)
            Me.labelControl1.TabIndex = 3
            Me.labelControl1.Text = "Set List Level:"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(664, 562)
            Me.Controls.Add(Me.labelControl1)
            Me.Controls.Add(Me.comboBoxEdit1)
            Me.Controls.Add(Me.btnSimpleBullet)
            Me.Controls.Add(Me.richEditControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
        Private WithEvents btnSimpleBullet As System.Windows.Forms.Button
        Private WithEvents comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace

