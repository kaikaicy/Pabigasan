<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dboard_txt = New System.Windows.Forms.Label()
        Me.stock_txt = New System.Windows.Forms.Label()
        Me.supplier_txt = New System.Windows.Forms.Label()
        Me.sndo_txt = New System.Windows.Forms.Label()
        Me.purchases_txt = New System.Windows.Forms.Label()
        Me.profile_txt = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.logout_txt = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.current_user_txt = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.logout_txt, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.profile_txt, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.purchases_txt, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.sndo_txt, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.supplier_txt, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.stock_txt, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.dboard_txt, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.04407!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.42228!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.42228!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.42228!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.42228!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.42228!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.42228!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.42228!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(310, 787)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1264, 793)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'dboard_txt
        '
        Me.dboard_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dboard_txt.AutoSize = True
        Me.dboard_txt.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dboard_txt.Location = New System.Drawing.Point(75, 184)
        Me.dboard_txt.Name = "dboard_txt"
        Me.dboard_txt.Size = New System.Drawing.Size(159, 35)
        Me.dboard_txt.TabIndex = 1
        Me.dboard_txt.Text = "DASHBOARD"
        '
        'stock_txt
        '
        Me.stock_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.stock_txt.AutoSize = True
        Me.stock_txt.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stock_txt.Location = New System.Drawing.Point(107, 273)
        Me.stock_txt.Name = "stock_txt"
        Me.stock_txt.Size = New System.Drawing.Size(95, 35)
        Me.stock_txt.TabIndex = 2
        Me.stock_txt.Text = "STOCK"
        '
        'supplier_txt
        '
        Me.supplier_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.supplier_txt.AutoSize = True
        Me.supplier_txt.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supplier_txt.Location = New System.Drawing.Point(83, 362)
        Me.supplier_txt.Name = "supplier_txt"
        Me.supplier_txt.Size = New System.Drawing.Size(143, 35)
        Me.supplier_txt.TabIndex = 3
        Me.supplier_txt.Text = "SUPPLIER"
        '
        'sndo_txt
        '
        Me.sndo_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.sndo_txt.AutoSize = True
        Me.sndo_txt.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sndo_txt.Location = New System.Drawing.Point(91, 451)
        Me.sndo_txt.Name = "sndo_txt"
        Me.sndo_txt.Size = New System.Drawing.Size(127, 35)
        Me.sndo_txt.TabIndex = 4
        Me.sndo_txt.Text = "REPORTS"
        '
        'purchases_txt
        '
        Me.purchases_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.purchases_txt.AutoSize = True
        Me.purchases_txt.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchases_txt.Location = New System.Drawing.Point(75, 540)
        Me.purchases_txt.Name = "purchases_txt"
        Me.purchases_txt.Size = New System.Drawing.Size(159, 35)
        Me.purchases_txt.TabIndex = 5
        Me.purchases_txt.Text = "PURCHASES"
        '
        'profile_txt
        '
        Me.profile_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.profile_txt.AutoSize = True
        Me.profile_txt.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profile_txt.Location = New System.Drawing.Point(91, 629)
        Me.profile_txt.Name = "profile_txt"
        Me.profile_txt.Size = New System.Drawing.Size(127, 35)
        Me.profile_txt.TabIndex = 6
        Me.profile_txt.Text = "PROFILE"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(597, 206)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(386, 380)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'logout_txt
        '
        Me.logout_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.logout_txt.AutoSize = True
        Me.logout_txt.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout_txt.Location = New System.Drawing.Point(99, 721)
        Me.logout_txt.Name = "logout_txt"
        Me.logout_txt.Size = New System.Drawing.Size(111, 35)
        Me.logout_txt.TabIndex = 7
        Me.logout_txt.Text = "LOGOUT"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.current_user_txt, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(304, 151)
        Me.TableLayoutPanel3.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(104, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 95)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'current_user_txt
        '
        Me.current_user_txt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.current_user_txt.AutoSize = True
        Me.current_user_txt.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.current_user_txt.Location = New System.Drawing.Point(134, 113)
        Me.current_user_txt.Name = "current_user_txt"
        Me.current_user_txt.Size = New System.Drawing.Size(35, 16)
        Me.current_user_txt.TabIndex = 1
        Me.current_user_txt.Text = "user"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 793)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dboard_txt As Label
    Friend WithEvents profile_txt As Label
    Friend WithEvents purchases_txt As Label
    Friend WithEvents sndo_txt As Label
    Friend WithEvents supplier_txt As Label
    Friend WithEvents stock_txt As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents logout_txt As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents current_user_txt As Label
End Class
