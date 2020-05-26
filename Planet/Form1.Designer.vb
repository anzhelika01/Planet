<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Grid1 = New System.Windows.Forms.DataGridView()
        Me.КодDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ПланетыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDPlanetDataSet = New Planet.BDPlanetDataSet()
        Me.ПланетыTableAdapter = New Planet.BDPlanetDataSetTableAdapters.ПланетыTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПланетыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDPlanetDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.AutoGenerateColumns = False
        Me.Grid1.BackgroundColor = System.Drawing.Color.AntiqueWhite
        Me.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.MDataGridViewTextBoxColumn, Me.RDataGridViewTextBoxColumn})
        Me.Grid1.DataSource = Me.ПланетыBindingSource
        Me.Grid1.Location = New System.Drawing.Point(13, 24)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RowHeadersWidth = 51
        Me.Grid1.RowTemplate.Height = 24
        Me.Grid1.Size = New System.Drawing.Size(616, 101)
        Me.Grid1.TabIndex = 0
        '
        'КодDataGridViewTextBoxColumn
        '
        Me.КодDataGridViewTextBoxColumn.DataPropertyName = "Код"
        Me.КодDataGridViewTextBoxColumn.HeaderText = "Код"
        Me.КодDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.КодDataGridViewTextBoxColumn.Name = "КодDataGridViewTextBoxColumn"
        Me.КодDataGridViewTextBoxColumn.Width = 125
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.Width = 125
        '
        'MDataGridViewTextBoxColumn
        '
        Me.MDataGridViewTextBoxColumn.DataPropertyName = "M"
        Me.MDataGridViewTextBoxColumn.HeaderText = "M"
        Me.MDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MDataGridViewTextBoxColumn.Name = "MDataGridViewTextBoxColumn"
        Me.MDataGridViewTextBoxColumn.Width = 125
        '
        'RDataGridViewTextBoxColumn
        '
        Me.RDataGridViewTextBoxColumn.DataPropertyName = "R"
        Me.RDataGridViewTextBoxColumn.HeaderText = "R"
        Me.RDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RDataGridViewTextBoxColumn.Name = "RDataGridViewTextBoxColumn"
        Me.RDataGridViewTextBoxColumn.Width = 125
        '
        'ПланетыBindingSource
        '
        Me.ПланетыBindingSource.DataMember = "Планеты"
        Me.ПланетыBindingSource.DataSource = Me.BDPlanetDataSet
        '
        'BDPlanetDataSet
        '
        Me.BDPlanetDataSet.DataSetName = "BDPlanetDataSet"
        Me.BDPlanetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ПланетыTableAdapter
        '
        Me.ПланетыTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Chocolate
        Me.GroupBox1.Location = New System.Drawing.Point(38, 165)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 346)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Расчёт 1 и 2 космических скоростей"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(181, 195)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(134, 36)
        Me.TextBox3.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(181, 137)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(134, 36)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(181, 82)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(134, 36)
        Me.TextBox1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Aqua
        Me.Button2.Location = New System.Drawing.Point(21, 137)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 36)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "v2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Aqua
        Me.Button1.Location = New System.Drawing.Point(21, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "v1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(181, 259)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(134, 36)
        Me.ComboBox1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 28)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Высота"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 28)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Планета"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Aqua
        Me.Button3.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.Location = New System.Drawing.Point(514, 165)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(177, 48)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Добавить"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Aqua
        Me.Button4.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.Location = New System.Drawing.Point(514, 247)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(177, 49)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Удалить"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Aqua
        Me.Button5.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button5.Location = New System.Drawing.Point(514, 331)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(177, 50)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Редактировать"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Aqua
        Me.Button6.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button6.Location = New System.Drawing.Point(514, 410)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(177, 50)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Обновить"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 569)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Grid1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПланетыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDPlanetDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Grid1 As DataGridView
    Friend WithEvents BDPlanetDataSet As BDPlanetDataSet
    Friend WithEvents ПланетыBindingSource As BindingSource
    Friend WithEvents ПланетыTableAdapter As BDPlanetDataSetTableAdapters.ПланетыTableAdapter
    Friend WithEvents КодDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
