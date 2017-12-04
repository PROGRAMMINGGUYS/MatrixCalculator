namespace MatrixCalculator
{
    partial class LinearSystemOpsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.masterTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logGroupBox = new System.Windows.Forms.GroupBox();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.setupTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.operationGroupBox = new System.Windows.Forms.GroupBox();
            this.operationTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.calculateButton = new System.Windows.Forms.Button();
            this.alogorithmLabel = new System.Windows.Forms.Label();
            this.algorithmComboBox = new System.Windows.Forms.ComboBox();
            this.setupGroupBox = new System.Windows.Forms.GroupBox();
            this.dimensionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dimensionLabel = new System.Windows.Forms.Label();
            this.dimensionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.setButton = new System.Windows.Forms.Button();
            this.systemTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.solutionGroupBox = new System.Windows.Forms.GroupBox();
            this.solutionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.copyVectorButton = new System.Windows.Forms.Button();
            this.solutionDataGridView = new System.Windows.Forms.DataGridView();
            this.systemGroupBox = new System.Windows.Forms.GroupBox();
            this.systemDataTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.constVectorDataGridView = new System.Windows.Forms.DataGridView();
            this.systemButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pasteSystemButton = new System.Windows.Forms.Button();
            this.copySystemButton = new System.Windows.Forms.Button();
            this.clearSystemButton = new System.Windows.Forms.Button();
            this.systemMatrixDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.closeButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.systemOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.systemSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.masterTableLayoutPanel.SuspendLayout();
            this.logGroupBox.SuspendLayout();
            this.setupTableLayoutPanel.SuspendLayout();
            this.operationGroupBox.SuspendLayout();
            this.operationTableLayoutPanel.SuspendLayout();
            this.setupGroupBox.SuspendLayout();
            this.dimensionTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionNumericUpDown)).BeginInit();
            this.systemTableLayoutPanel.SuspendLayout();
            this.solutionGroupBox.SuspendLayout();
            this.solutionTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.solutionDataGridView)).BeginInit();
            this.systemGroupBox.SuspendLayout();
            this.systemDataTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.constVectorDataGridView)).BeginInit();
            this.systemButtonsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.systemMatrixDataGridView)).BeginInit();
            this.buttonTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // masterTableLayoutPanel
            // 
            this.masterTableLayoutPanel.ColumnCount = 1;
            this.masterTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.masterTableLayoutPanel.Controls.Add(this.logGroupBox, 0, 2);
            this.masterTableLayoutPanel.Controls.Add(this.setupTableLayoutPanel, 0, 0);
            this.masterTableLayoutPanel.Controls.Add(this.systemTableLayoutPanel, 0, 1);
            this.masterTableLayoutPanel.Controls.Add(this.buttonTableLayoutPanel, 0, 3);
            this.masterTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.masterTableLayoutPanel.Name = "masterTableLayoutPanel";
            this.masterTableLayoutPanel.RowCount = 4;
            this.masterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.masterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.masterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.masterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.masterTableLayoutPanel.Size = new System.Drawing.Size(1259, 847);
            this.masterTableLayoutPanel.TabIndex = 0;
            // 
            // logGroupBox
            // 
            this.logGroupBox.Controls.Add(this.logTextBox);
            this.logGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logGroupBox.Location = new System.Drawing.Point(12, 595);
            this.logGroupBox.Margin = new System.Windows.Forms.Padding(12);
            this.logGroupBox.Name = "logGroupBox";
            this.logGroupBox.Padding = new System.Windows.Forms.Padding(10);
            this.logGroupBox.Size = new System.Drawing.Size(1235, 187);
            this.logGroupBox.TabIndex = 6;
            this.logGroupBox.TabStop = false;
            this.logGroupBox.Text = "Log";
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logTextBox.Location = new System.Drawing.Point(10, 30);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logTextBox.Size = new System.Drawing.Size(1215, 147);
            this.logTextBox.TabIndex = 0;
            // 
            // setupTableLayoutPanel
            // 
            this.setupTableLayoutPanel.ColumnCount = 2;
            this.setupTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 310F));
            this.setupTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.setupTableLayoutPanel.Controls.Add(this.operationGroupBox, 0, 0);
            this.setupTableLayoutPanel.Controls.Add(this.setupGroupBox, 0, 0);
            this.setupTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setupTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.setupTableLayoutPanel.Name = "setupTableLayoutPanel";
            this.setupTableLayoutPanel.RowCount = 1;
            this.setupTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.setupTableLayoutPanel.Size = new System.Drawing.Size(1253, 137);
            this.setupTableLayoutPanel.TabIndex = 0;
            // 
            // operationGroupBox
            // 
            this.operationGroupBox.Controls.Add(this.operationTableLayoutPanel);
            this.operationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operationGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.operationGroupBox.Location = new System.Drawing.Point(322, 12);
            this.operationGroupBox.Margin = new System.Windows.Forms.Padding(12);
            this.operationGroupBox.Name = "operationGroupBox";
            this.operationGroupBox.Size = new System.Drawing.Size(919, 113);
            this.operationGroupBox.TabIndex = 3;
            this.operationGroupBox.TabStop = false;
            this.operationGroupBox.Text = "Operation";
            // 
            // operationTableLayoutPanel
            // 
            this.operationTableLayoutPanel.ColumnCount = 3;
            this.operationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.operationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.operationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.operationTableLayoutPanel.Controls.Add(this.calculateButton, 2, 0);
            this.operationTableLayoutPanel.Controls.Add(this.alogorithmLabel, 0, 0);
            this.operationTableLayoutPanel.Controls.Add(this.algorithmComboBox, 1, 0);
            this.operationTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operationTableLayoutPanel.Location = new System.Drawing.Point(3, 23);
            this.operationTableLayoutPanel.Name = "operationTableLayoutPanel";
            this.operationTableLayoutPanel.RowCount = 1;
            this.operationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.operationTableLayoutPanel.Size = new System.Drawing.Size(913, 87);
            this.operationTableLayoutPanel.TabIndex = 0;
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calculateButton.AutoSize = true;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Location = new System.Drawing.Point(822, 27);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(82, 32);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // alogorithmLabel
            // 
            this.alogorithmLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.alogorithmLabel.AutoSize = true;
            this.alogorithmLabel.Location = new System.Drawing.Point(3, 33);
            this.alogorithmLabel.Name = "alogorithmLabel";
            this.alogorithmLabel.Size = new System.Drawing.Size(79, 20);
            this.alogorithmLabel.TabIndex = 1;
            this.alogorithmLabel.Text = "Algorithm:";
            // 
            // algorithmComboBox
            // 
            this.algorithmComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.algorithmComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.algorithmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algorithmComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.algorithmComboBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.algorithmComboBox.FormattingEnabled = true;
            this.algorithmComboBox.Items.AddRange(new object[] {
            "Gaussian elimination",
            "LU decomposition"});
            this.algorithmComboBox.Location = new System.Drawing.Point(88, 29);
            this.algorithmComboBox.Name = "algorithmComboBox";
            this.algorithmComboBox.Size = new System.Drawing.Size(722, 28);
            this.algorithmComboBox.TabIndex = 2;
            // 
            // setupGroupBox
            // 
            this.setupGroupBox.Controls.Add(this.dimensionTableLayoutPanel);
            this.setupGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setupGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.setupGroupBox.Location = new System.Drawing.Point(12, 12);
            this.setupGroupBox.Margin = new System.Windows.Forms.Padding(12);
            this.setupGroupBox.Name = "setupGroupBox";
            this.setupGroupBox.Size = new System.Drawing.Size(286, 113);
            this.setupGroupBox.TabIndex = 2;
            this.setupGroupBox.TabStop = false;
            this.setupGroupBox.Text = "Setup";
            // 
            // dimensionTableLayoutPanel
            // 
            this.dimensionTableLayoutPanel.ColumnCount = 3;
            this.dimensionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.dimensionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dimensionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.dimensionTableLayoutPanel.Controls.Add(this.dimensionLabel, 0, 0);
            this.dimensionTableLayoutPanel.Controls.Add(this.dimensionNumericUpDown, 1, 0);
            this.dimensionTableLayoutPanel.Controls.Add(this.setButton, 2, 0);
            this.dimensionTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dimensionTableLayoutPanel.Location = new System.Drawing.Point(3, 23);
            this.dimensionTableLayoutPanel.Name = "dimensionTableLayoutPanel";
            this.dimensionTableLayoutPanel.RowCount = 1;
            this.dimensionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dimensionTableLayoutPanel.Size = new System.Drawing.Size(280, 87);
            this.dimensionTableLayoutPanel.TabIndex = 0;
            // 
            // dimensionLabel
            // 
            this.dimensionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dimensionLabel.AutoSize = true;
            this.dimensionLabel.Location = new System.Drawing.Point(3, 33);
            this.dimensionLabel.Name = "dimensionLabel";
            this.dimensionLabel.Size = new System.Drawing.Size(83, 20);
            this.dimensionLabel.TabIndex = 0;
            this.dimensionLabel.Text = "Dimension:";
            // 
            // dimensionNumericUpDown
            // 
            this.dimensionNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dimensionNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dimensionNumericUpDown.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dimensionNumericUpDown.Location = new System.Drawing.Point(93, 30);
            this.dimensionNumericUpDown.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.dimensionNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.dimensionNumericUpDown.Name = "dimensionNumericUpDown";
            this.dimensionNumericUpDown.Size = new System.Drawing.Size(85, 27);
            this.dimensionNumericUpDown.TabIndex = 1;
            this.dimensionNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // setButton
            // 
            this.setButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setButton.AutoSize = true;
            this.setButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setButton.Location = new System.Drawing.Point(193, 27);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 32);
            this.setButton.TabIndex = 2;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // systemTableLayoutPanel
            // 
            this.systemTableLayoutPanel.ColumnCount = 2;
            this.systemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.systemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.systemTableLayoutPanel.Controls.Add(this.solutionGroupBox, 0, 0);
            this.systemTableLayoutPanel.Controls.Add(this.systemGroupBox, 0, 0);
            this.systemTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.systemTableLayoutPanel.Location = new System.Drawing.Point(3, 146);
            this.systemTableLayoutPanel.Name = "systemTableLayoutPanel";
            this.systemTableLayoutPanel.RowCount = 1;
            this.systemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.systemTableLayoutPanel.Size = new System.Drawing.Size(1253, 434);
            this.systemTableLayoutPanel.TabIndex = 1;
            // 
            // solutionGroupBox
            // 
            this.solutionGroupBox.Controls.Add(this.solutionTableLayoutPanel);
            this.solutionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solutionGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.solutionGroupBox.Location = new System.Drawing.Point(1115, 12);
            this.solutionGroupBox.Margin = new System.Windows.Forms.Padding(12);
            this.solutionGroupBox.Name = "solutionGroupBox";
            this.solutionGroupBox.Size = new System.Drawing.Size(126, 410);
            this.solutionGroupBox.TabIndex = 5;
            this.solutionGroupBox.TabStop = false;
            this.solutionGroupBox.Text = "Solution";
            // 
            // solutionTableLayoutPanel
            // 
            this.solutionTableLayoutPanel.ColumnCount = 1;
            this.solutionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.solutionTableLayoutPanel.Controls.Add(this.copyVectorButton, 0, 1);
            this.solutionTableLayoutPanel.Controls.Add(this.solutionDataGridView, 0, 0);
            this.solutionTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solutionTableLayoutPanel.Location = new System.Drawing.Point(3, 23);
            this.solutionTableLayoutPanel.Name = "solutionTableLayoutPanel";
            this.solutionTableLayoutPanel.RowCount = 2;
            this.solutionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.49198F));
            this.solutionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.50802F));
            this.solutionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.solutionTableLayoutPanel.Size = new System.Drawing.Size(120, 384);
            this.solutionTableLayoutPanel.TabIndex = 0;
            // 
            // copyVectorButton
            // 
            this.copyVectorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.copyVectorButton.AutoSize = true;
            this.copyVectorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyVectorButton.Location = new System.Drawing.Point(10, 338);
            this.copyVectorButton.Name = "copyVectorButton";
            this.copyVectorButton.Size = new System.Drawing.Size(100, 32);
            this.copyVectorButton.TabIndex = 5;
            this.copyVectorButton.Text = "Copy";
            this.copyVectorButton.UseVisualStyleBackColor = true;
            this.copyVectorButton.Click += new System.EventHandler(this.copyVectorButton_Click);
            // 
            // solutionDataGridView
            // 
            this.solutionDataGridView.AllowUserToAddRows = false;
            this.solutionDataGridView.AllowUserToDeleteRows = false;
            this.solutionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.solutionDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.solutionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.solutionDataGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Format = "N6";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.solutionDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.solutionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solutionDataGridView.Location = new System.Drawing.Point(10, 10);
            this.solutionDataGridView.Margin = new System.Windows.Forms.Padding(10);
            this.solutionDataGridView.Name = "solutionDataGridView";
            this.solutionDataGridView.ReadOnly = true;
            this.solutionDataGridView.RowHeadersVisible = false;
            this.solutionDataGridView.RowTemplate.Height = 24;
            this.solutionDataGridView.Size = new System.Drawing.Size(100, 304);
            this.solutionDataGridView.TabIndex = 3;
            // 
            // systemGroupBox
            // 
            this.systemGroupBox.Controls.Add(this.systemDataTableLayoutPanel);
            this.systemGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.systemGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.systemGroupBox.Location = new System.Drawing.Point(12, 12);
            this.systemGroupBox.Margin = new System.Windows.Forms.Padding(12);
            this.systemGroupBox.Name = "systemGroupBox";
            this.systemGroupBox.Size = new System.Drawing.Size(1079, 410);
            this.systemGroupBox.TabIndex = 4;
            this.systemGroupBox.TabStop = false;
            this.systemGroupBox.Text = "System";
            // 
            // systemDataTableLayoutPanel
            // 
            this.systemDataTableLayoutPanel.ColumnCount = 2;
            this.systemDataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.systemDataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.systemDataTableLayoutPanel.Controls.Add(this.constVectorDataGridView, 1, 0);
            this.systemDataTableLayoutPanel.Controls.Add(this.systemButtonsTableLayoutPanel, 0, 1);
            this.systemDataTableLayoutPanel.Controls.Add(this.systemMatrixDataGridView, 0, 0);
            this.systemDataTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.systemDataTableLayoutPanel.Location = new System.Drawing.Point(3, 23);
            this.systemDataTableLayoutPanel.Name = "systemDataTableLayoutPanel";
            this.systemDataTableLayoutPanel.RowCount = 2;
            this.systemDataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.49198F));
            this.systemDataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.50802F));
            this.systemDataTableLayoutPanel.Size = new System.Drawing.Size(1073, 384);
            this.systemDataTableLayoutPanel.TabIndex = 0;
            // 
            // constVectorDataGridView
            // 
            this.constVectorDataGridView.AllowUserToAddRows = false;
            this.constVectorDataGridView.AllowUserToDeleteRows = false;
            this.constVectorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.constVectorDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.constVectorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.constVectorDataGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Format = "N6";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.constVectorDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.constVectorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.constVectorDataGridView.Location = new System.Drawing.Point(963, 10);
            this.constVectorDataGridView.Margin = new System.Windows.Forms.Padding(10);
            this.constVectorDataGridView.Name = "constVectorDataGridView";
            this.constVectorDataGridView.RowHeadersVisible = false;
            this.constVectorDataGridView.RowTemplate.Height = 24;
            this.constVectorDataGridView.Size = new System.Drawing.Size(100, 304);
            this.constVectorDataGridView.TabIndex = 2;
            this.constVectorDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.systemDataGridViews_CellValueChanged);
            // 
            // systemButtonsTableLayoutPanel
            // 
            this.systemButtonsTableLayoutPanel.ColumnCount = 4;
            this.systemDataTableLayoutPanel.SetColumnSpan(this.systemButtonsTableLayoutPanel, 2);
            this.systemButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.systemButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.systemButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.systemButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.systemButtonsTableLayoutPanel.Controls.Add(this.pasteSystemButton, 2, 0);
            this.systemButtonsTableLayoutPanel.Controls.Add(this.copySystemButton, 1, 0);
            this.systemButtonsTableLayoutPanel.Controls.Add(this.clearSystemButton, 3, 0);
            this.systemButtonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.systemButtonsTableLayoutPanel.Location = new System.Drawing.Point(3, 327);
            this.systemButtonsTableLayoutPanel.Name = "systemButtonsTableLayoutPanel";
            this.systemButtonsTableLayoutPanel.RowCount = 1;
            this.systemButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.systemButtonsTableLayoutPanel.Size = new System.Drawing.Size(1067, 54);
            this.systemButtonsTableLayoutPanel.TabIndex = 0;
            // 
            // pasteSystemButton
            // 
            this.pasteSystemButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pasteSystemButton.AutoSize = true;
            this.pasteSystemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pasteSystemButton.Location = new System.Drawing.Point(835, 11);
            this.pasteSystemButton.Name = "pasteSystemButton";
            this.pasteSystemButton.Size = new System.Drawing.Size(104, 32);
            this.pasteSystemButton.TabIndex = 6;
            this.pasteSystemButton.Text = "Paste system";
            this.pasteSystemButton.UseVisualStyleBackColor = true;
            this.pasteSystemButton.Click += new System.EventHandler(this.pasteSystemButton_Click);
            // 
            // copySystemButton
            // 
            this.copySystemButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.copySystemButton.AutoSize = true;
            this.copySystemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copySystemButton.Location = new System.Drawing.Point(714, 11);
            this.copySystemButton.Name = "copySystemButton";
            this.copySystemButton.Size = new System.Drawing.Size(105, 32);
            this.copySystemButton.TabIndex = 5;
            this.copySystemButton.Text = "Copy system";
            this.copySystemButton.UseVisualStyleBackColor = true;
            this.copySystemButton.Click += new System.EventHandler(this.copySystemButton_Click);
            // 
            // clearSystemButton
            // 
            this.clearSystemButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearSystemButton.AutoSize = true;
            this.clearSystemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSystemButton.Location = new System.Drawing.Point(955, 11);
            this.clearSystemButton.Name = "clearSystemButton";
            this.clearSystemButton.Size = new System.Drawing.Size(104, 32);
            this.clearSystemButton.TabIndex = 4;
            this.clearSystemButton.Text = "Clear";
            this.clearSystemButton.UseVisualStyleBackColor = true;
            this.clearSystemButton.Click += new System.EventHandler(this.clearSystemButton_Click);
            // 
            // systemMatrixDataGridView
            // 
            this.systemMatrixDataGridView.AllowUserToAddRows = false;
            this.systemMatrixDataGridView.AllowUserToDeleteRows = false;
            this.systemMatrixDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.systemMatrixDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.systemMatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.systemMatrixDataGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.Format = "N6";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.systemMatrixDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.systemMatrixDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.systemMatrixDataGridView.Location = new System.Drawing.Point(10, 10);
            this.systemMatrixDataGridView.Margin = new System.Windows.Forms.Padding(10);
            this.systemMatrixDataGridView.Name = "systemMatrixDataGridView";
            this.systemMatrixDataGridView.RowHeadersVisible = false;
            this.systemMatrixDataGridView.RowTemplate.Height = 24;
            this.systemMatrixDataGridView.Size = new System.Drawing.Size(933, 304);
            this.systemMatrixDataGridView.TabIndex = 1;
            this.systemMatrixDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.systemDataGridViews_CellValueChanged);
            // 
            // buttonTableLayoutPanel
            // 
            this.buttonTableLayoutPanel.ColumnCount = 6;
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.buttonTableLayoutPanel.Controls.Add(this.closeButton, 5, 0);
            this.buttonTableLayoutPanel.Controls.Add(this.clearAllButton, 4, 0);
            this.buttonTableLayoutPanel.Controls.Add(this.saveButton, 3, 0);
            this.buttonTableLayoutPanel.Controls.Add(this.importButton, 2, 0);
            this.buttonTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTableLayoutPanel.Location = new System.Drawing.Point(3, 797);
            this.buttonTableLayoutPanel.Name = "buttonTableLayoutPanel";
            this.buttonTableLayoutPanel.RowCount = 1;
            this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.buttonTableLayoutPanel.Size = new System.Drawing.Size(1253, 47);
            this.buttonTableLayoutPanel.TabIndex = 7;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeButton.AutoSize = true;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(1146, 4);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(93, 32);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearAllButton.AutoSize = true;
            this.clearAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAllButton.Location = new System.Drawing.Point(1026, 4);
            this.clearAllButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(93, 32);
            this.clearAllButton.TabIndex = 7;
            this.clearAllButton.Text = "Clear all";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveButton.AutoSize = true;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(906, 4);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 32);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // importButton
            // 
            this.importButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.importButton.AutoSize = true;
            this.importButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importButton.Location = new System.Drawing.Point(786, 4);
            this.importButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(93, 32);
            this.importButton.TabIndex = 9;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // systemOpenFileDialog
            // 
            this.systemOpenFileDialog.DefaultExt = "mcs";
            this.systemOpenFileDialog.Filter = "System file|*.mcs|All files|*.*";
            // 
            // systemSaveFileDialog
            // 
            this.systemSaveFileDialog.DefaultExt = "mcs";
            this.systemSaveFileDialog.FileName = "NewSystem";
            this.systemSaveFileDialog.Filter = "System file|*.mcs|All files|*.*";
            // 
            // LinearSystemOpsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1259, 847);
            this.Controls.Add(this.masterTableLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MinimumSize = new System.Drawing.Size(720, 800);
            this.Name = "LinearSystemOpsWindow";
            this.Text = "Linear system operations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LinearSystemOpsWindow_FormClosing);
            this.masterTableLayoutPanel.ResumeLayout(false);
            this.logGroupBox.ResumeLayout(false);
            this.logGroupBox.PerformLayout();
            this.setupTableLayoutPanel.ResumeLayout(false);
            this.operationGroupBox.ResumeLayout(false);
            this.operationTableLayoutPanel.ResumeLayout(false);
            this.operationTableLayoutPanel.PerformLayout();
            this.setupGroupBox.ResumeLayout(false);
            this.dimensionTableLayoutPanel.ResumeLayout(false);
            this.dimensionTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionNumericUpDown)).EndInit();
            this.systemTableLayoutPanel.ResumeLayout(false);
            this.solutionGroupBox.ResumeLayout(false);
            this.solutionTableLayoutPanel.ResumeLayout(false);
            this.solutionTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.solutionDataGridView)).EndInit();
            this.systemGroupBox.ResumeLayout(false);
            this.systemDataTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.constVectorDataGridView)).EndInit();
            this.systemButtonsTableLayoutPanel.ResumeLayout(false);
            this.systemButtonsTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.systemMatrixDataGridView)).EndInit();
            this.buttonTableLayoutPanel.ResumeLayout(false);
            this.buttonTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel masterTableLayoutPanel;
        private System.Windows.Forms.GroupBox logGroupBox;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.TableLayoutPanel setupTableLayoutPanel;
        private System.Windows.Forms.GroupBox operationGroupBox;
        private System.Windows.Forms.GroupBox setupGroupBox;
        private System.Windows.Forms.TableLayoutPanel dimensionTableLayoutPanel;
        private System.Windows.Forms.Label dimensionLabel;
        private System.Windows.Forms.NumericUpDown dimensionNumericUpDown;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.TableLayoutPanel buttonTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel operationTableLayoutPanel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label alogorithmLabel;
        private System.Windows.Forms.ComboBox algorithmComboBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.TableLayoutPanel systemTableLayoutPanel;
        private System.Windows.Forms.GroupBox solutionGroupBox;
        private System.Windows.Forms.TableLayoutPanel solutionTableLayoutPanel;
        private System.Windows.Forms.Button copyVectorButton;
        private System.Windows.Forms.DataGridView solutionDataGridView;
        private System.Windows.Forms.GroupBox systemGroupBox;
        private System.Windows.Forms.TableLayoutPanel systemDataTableLayoutPanel;
        private System.Windows.Forms.DataGridView constVectorDataGridView;
        private System.Windows.Forms.TableLayoutPanel systemButtonsTableLayoutPanel;
        private System.Windows.Forms.Button pasteSystemButton;
        private System.Windows.Forms.Button copySystemButton;
        private System.Windows.Forms.Button clearSystemButton;
        private System.Windows.Forms.DataGridView systemMatrixDataGridView;
        private System.Windows.Forms.OpenFileDialog systemOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog systemSaveFileDialog;
    }
}