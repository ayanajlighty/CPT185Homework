<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FallMarathon
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
        Me.Header = New System.Windows.Forms.Label()
        Me.Greeting = New System.Windows.Forms.Label()
        Me.picMarathon = New System.Windows.Forms.PictureBox()
        Me.btnDate = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.dateInfo = New System.Windows.Forms.Label()
        Me.StartInfo = New System.Windows.Forms.Label()
        Me.detailInfo = New System.Windows.Forms.Label()
        CType(Me.picMarathon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Header
        '
        Me.Header.AutoSize = True
        Me.Header.Font = New System.Drawing.Font("Lucida Sans", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Header.Location = New System.Drawing.Point(86, 9)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(261, 39)
        Me.Header.TabIndex = 0
        Me.Header.Text = "Fall Marathon"
        '
        'Greeting
        '
        Me.Greeting.AutoSize = True
        Me.Greeting.Location = New System.Drawing.Point(71, 216)
        Me.Greeting.Name = "Greeting"
        Me.Greeting.Size = New System.Drawing.Size(291, 17)
        Me.Greeting.TabIndex = 1
        Me.Greeting.Text = "full- and half-marathon runners are welcome."
        '
        'picMarathon
        '
        Me.picMarathon.Location = New System.Drawing.Point(85, 74)
        Me.picMarathon.Name = "picMarathon"
        Me.picMarathon.Size = New System.Drawing.Size(263, 118)
        Me.picMarathon.TabIndex = 2
        Me.picMarathon.TabStop = False
        '
        'btnDate
        '
        Me.btnDate.Location = New System.Drawing.Point(85, 252)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(75, 23)
        Me.btnDate.TabIndex = 3
        Me.btnDate.Text = "Date"
        Me.btnDate.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(272, 252)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "Start location"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnDetails
        '
        Me.btnDetails.Location = New System.Drawing.Point(167, 322)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(75, 23)
        Me.btnDetails.TabIndex = 5
        Me.btnDetails.Text = "Details"
        Me.btnDetails.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(345, 368)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'dateInfo
        '
        Me.dateInfo.AutoSize = True
        Me.dateInfo.Location = New System.Drawing.Point(71, 278)
        Me.dateInfo.Name = "dateInfo"
        Me.dateInfo.Size = New System.Drawing.Size(94, 17)
        Me.dateInfo.TabIndex = 7
        Me.dateInfo.Text = "May 30, 2017"
        '
        'StartInfo
        '
        Me.StartInfo.AutoSize = True
        Me.StartInfo.Location = New System.Drawing.Point(198, 278)
        Me.StartInfo.Name = "StartInfo"
        Me.StartInfo.Size = New System.Drawing.Size(202, 17)
        Me.StartInfo.TabIndex = 8
        Me.StartInfo.Text = "Ryan park Start Time: 8:00 AM"
        '
        'detailInfo
        '
        Me.detailInfo.AutoSize = True
        Me.detailInfo.Location = New System.Drawing.Point(26, 348)
        Me.detailInfo.Name = "detailInfo"
        Me.detailInfo.Size = New System.Drawing.Size(394, 17)
        Me.detailInfo.TabIndex = 9
        Me.detailInfo.Text = "For more information, view the Fall Marathon Facebook page."
        '
        'FallMarathon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 403)
        Me.Controls.Add(Me.detailInfo)
        Me.Controls.Add(Me.StartInfo)
        Me.Controls.Add(Me.dateInfo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDetails)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnDate)
        Me.Controls.Add(Me.picMarathon)
        Me.Controls.Add(Me.Greeting)
        Me.Controls.Add(Me.Header)
        Me.Name = "FallMarathon"
        Me.Text = "Fall Marathon"
        CType(Me.picMarathon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Header As Label
    Friend WithEvents Greeting As Label
    Friend WithEvents picMarathon As PictureBox
    Friend WithEvents btnDate As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnDetails As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents dateInfo As Label
    Friend WithEvents StartInfo As Label
    Friend WithEvents detailInfo As Label
End Class
