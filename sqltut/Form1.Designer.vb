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
        Me.components = New System.ComponentModel.Container()
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.miinventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ManageUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiNewUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiDeleteUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiEditUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.msMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMain
        '
        Me.msMain.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miinventory, Me.ManageUsersToolStripMenuItem})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(1331, 33)
        Me.msMain.TabIndex = 1
        Me.msMain.Text = "MenuStrip1"
        '
        'miinventory
        '
        Me.miinventory.Name = "miinventory"
        Me.miinventory.Size = New System.Drawing.Size(99, 29)
        Me.miinventory.Text = "Inventory"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ManageUsersToolStripMenuItem
        '
        Me.ManageUsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msiNewUser, Me.msiDeleteUser, Me.msiEditUser})
        Me.ManageUsersToolStripMenuItem.Name = "ManageUsersToolStripMenuItem"
        Me.ManageUsersToolStripMenuItem.Size = New System.Drawing.Size(136, 29)
        Me.ManageUsersToolStripMenuItem.Text = "Manage Users"
        '
        'msiNewUser
        '
        Me.msiNewUser.Name = "msiNewUser"
        Me.msiNewUser.Size = New System.Drawing.Size(252, 30)
        Me.msiNewUser.Text = "New User"
        '
        'msiDeleteUser
        '
        Me.msiDeleteUser.Name = "msiDeleteUser"
        Me.msiDeleteUser.Size = New System.Drawing.Size(252, 30)
        Me.msiDeleteUser.Text = "Delete User"
        '
        'msiEditUser
        '
        Me.msiEditUser.Name = "msiEditUser"
        Me.msiEditUser.Size = New System.Drawing.Size(252, 30)
        Me.msiEditUser.Text = "Edit User"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1331, 512)
        Me.Controls.Add(Me.msMain)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.msMain
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msMain As MenuStrip
    Friend WithEvents miinventory As ToolStripMenuItem
    Friend WithEvents ManageUsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents msiNewUser As ToolStripMenuItem
    Friend WithEvents msiDeleteUser As ToolStripMenuItem
    Friend WithEvents msiEditUser As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
