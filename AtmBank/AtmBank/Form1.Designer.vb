<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.lblInterface = New System.Windows.Forms.Label()
        Me.btnWithdraw = New System.Windows.Forms.Button()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.btnChq = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtAmt = New System.Windows.Forms.TextBox()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Myanmar Text", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(257, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(282, 62)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Bank of Bleh"
        '
        'btnInsert
        '
        Me.btnInsert.AutoSize = True
        Me.btnInsert.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.Location = New System.Drawing.Point(622, 433)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(177, 61)
        Me.btnInsert.TabIndex = 1
        Me.btnInsert.Text = "Press Button to Insert Card"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'lblInterface
        '
        Me.lblInterface.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblInterface.Font = New System.Drawing.Font("Microsoft New Tai Lue", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterface.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblInterface.Location = New System.Drawing.Point(100, 71)
        Me.lblInterface.Name = "lblInterface"
        Me.lblInterface.Size = New System.Drawing.Size(577, 320)
        Me.lblInterface.TabIndex = 2
        Me.lblInterface.Text = "ATM"
        Me.lblInterface.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnWithdraw
        '
        Me.btnWithdraw.Location = New System.Drawing.Point(538, 320)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(117, 49)
        Me.btnWithdraw.TabIndex = 3
        Me.btnWithdraw.Text = "Withdraw"
        Me.btnWithdraw.UseVisualStyleBackColor = True
        Me.btnWithdraw.Visible = False
        '
        'btnDeposit
        '
        Me.btnDeposit.Location = New System.Drawing.Point(134, 320)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(117, 49)
        Me.btnDeposit.TabIndex = 4
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = True
        Me.btnDeposit.Visible = False
        '
        'btnChq
        '
        Me.btnChq.Font = New System.Drawing.Font("Myanmar Text", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChq.Location = New System.Drawing.Point(122, 293)
        Me.btnChq.Name = "btnChq"
        Me.btnChq.Size = New System.Drawing.Size(144, 55)
        Me.btnChq.TabIndex = 5
        Me.btnChq.Text = "Chequing"
        Me.btnChq.UseVisualStyleBackColor = True
        Me.btnChq.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Myanmar Text", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(523, 293)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(144, 55)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Savings"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'txtAmt
        '
        Me.txtAmt.Location = New System.Drawing.Point(314, 349)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.Size = New System.Drawing.Size(135, 20)
        Me.txtAmt.TabIndex = 7
        Me.txtAmt.Visible = False
        '
        'btnNo
        '
        Me.btnNo.Location = New System.Drawing.Point(538, 301)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(104, 47)
        Me.btnNo.TabIndex = 9
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = True
        Me.btnNo.Visible = False
        '
        'btnYes
        '
        Me.btnYes.Location = New System.Drawing.Point(134, 295)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(104, 47)
        Me.btnYes.TabIndex = 10
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        Me.btnYes.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 594)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.txtAmt)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnChq)
        Me.Controls.Add(Me.btnDeposit)
        Me.Controls.Add(Me.btnWithdraw)
        Me.Controls.Add(Me.lblInterface)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents lblInterface As System.Windows.Forms.Label
    Friend WithEvents btnWithdraw As System.Windows.Forms.Button
    Friend WithEvents btnDeposit As System.Windows.Forms.Button
    Friend WithEvents btnChq As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtAmt As System.Windows.Forms.TextBox
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents btnYes As System.Windows.Forms.Button

End Class
