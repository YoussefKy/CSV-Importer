namespace YK.XrmToolBox.CSVImporter
{
    partial class CSVImporterControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose ( );
            }
            base.Dispose ( disposing );
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSVImporterControl));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLoadEntities = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBrowse = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbImport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbReset = new System.Windows.Forms.ToolStripButton();
            this.tlpGlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.gbGeneralConfiguration = new System.Windows.Forms.GroupBox();
            this.tlpGeneralConfiguration = new System.Windows.Forms.TableLayoutPanel();
            this.gbEntityDefinition = new System.Windows.Forms.GroupBox();
            this.tlpEntityDefinition = new System.Windows.Forms.TableLayoutPanel();
            this.lblEntity = new System.Windows.Forms.Label();
            this.cmbSelectedEntity = new System.Windows.Forms.ComboBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.cmbKey = new System.Windows.Forms.ComboBox();
            this.gbQueryOptions = new System.Windows.Forms.GroupBox();
            this.tlpQueryOptions = new System.Windows.Forms.TableLayoutPanel();
            this.lblUnicity = new System.Windows.Forms.Label();
            this.cmbUnicity = new System.Windows.Forms.ComboBox();
            this.gbProcessingOptions = new System.Windows.Forms.GroupBox();
            this.tlpProcessingOptions = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaxParallelism = new System.Windows.Forms.Label();
            this.lblBatchSize = new System.Windows.Forms.Label();
            this.nudMaxParallelism = new System.Windows.Forms.NumericUpDown();
            this.nudBatchSize = new System.Windows.Forms.NumericUpDown();
            this.gbTemplate = new System.Windows.Forms.GroupBox();
            this.tlpTemplate = new System.Windows.Forms.TableLayoutPanel();
            this.gbAttributeSelector = new System.Windows.Forms.GroupBox();
            this.tlpAttributeSelector = new System.Windows.Forms.TableLayoutPanel();
            this.gbAddQueryExpression = new System.Windows.Forms.GroupBox();
            this.tlpAddAttributeFroQuery = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddQueryAttribute = new System.Windows.Forms.Button();
            this.cmbAttributeForQuery = new System.Windows.Forms.ComboBox();
            this.lblAttributeForQuery = new System.Windows.Forms.Label();
            this.lblConditionOperator = new System.Windows.Forms.Label();
            this.cmbConditionOperator = new System.Windows.Forms.ComboBox();
            this.gbAddAttributeToUpdate = new System.Windows.Forms.GroupBox();
            this.tlpAttributeUpdate = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddAttributeToUpdate = new System.Windows.Forms.Button();
            this.cmbAttributeToUpdate = new System.Windows.Forms.ComboBox();
            this.lblAttributeToUpdate = new System.Windows.Forms.Label();
            this.gridTemplateColumns = new System.Windows.Forms.DataGridView();
            this.gbInformation = new System.Windows.Forms.GroupBox();
            this.tlpInformation = new System.Windows.Forms.TableLayoutPanel();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.lblFileTemplate = new System.Windows.Forms.Label();
            this.tsbAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenu.SuspendLayout();
            this.tlpGlobalContainer.SuspendLayout();
            this.gbGeneralConfiguration.SuspendLayout();
            this.tlpGeneralConfiguration.SuspendLayout();
            this.gbEntityDefinition.SuspendLayout();
            this.tlpEntityDefinition.SuspendLayout();
            this.gbQueryOptions.SuspendLayout();
            this.tlpQueryOptions.SuspendLayout();
            this.gbProcessingOptions.SuspendLayout();
            this.tlpProcessingOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxParallelism)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBatchSize)).BeginInit();
            this.gbTemplate.SuspendLayout();
            this.tlpTemplate.SuspendLayout();
            this.gbAttributeSelector.SuspendLayout();
            this.tlpAttributeSelector.SuspendLayout();
            this.gbAddQueryExpression.SuspendLayout();
            this.tlpAddAttributeFroQuery.SuspendLayout();
            this.gbAddAttributeToUpdate.SuspendLayout();
            this.tlpAttributeUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTemplateColumns)).BeginInit();
            this.gbInformation.SuspendLayout();
            this.tlpInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1,
            this.tsbLoadEntities,
            this.toolStripSeparator1,
            this.tsbBrowse,
            this.toolStripSeparator2,
            this.tsbImport,
            this.toolStripSeparator3,
            this.tsbReset,
            this.tsbAbout});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1354, 25);
            this.toolStripMenu.TabIndex = 4;
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(40, 22);
            this.tsbClose.Text = "Close";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbLoadEntities
            // 
            this.tsbLoadEntities.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbLoadEntities.Name = "tsbLoadEntities";
            this.tsbLoadEntities.Size = new System.Drawing.Size(78, 22);
            this.tsbLoadEntities.Text = "Load Entities";
            this.tsbLoadEntities.Click += new System.EventHandler(this.tsbLoadEntities_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbBrowse
            // 
            this.tsbBrowse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBrowse.Image = ((System.Drawing.Image)(resources.GetObject("tsbBrowse.Image")));
            this.tsbBrowse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBrowse.Name = "tsbBrowse";
            this.tsbBrowse.Size = new System.Drawing.Size(49, 22);
            this.tsbBrowse.Text = "Browse";
            this.tsbBrowse.Click += new System.EventHandler(this.tsbBrowse_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbImport
            // 
            this.tsbImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbImport.Image = ((System.Drawing.Image)(resources.GetObject("tsbImport.Image")));
            this.tsbImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImport.Name = "tsbImport";
            this.tsbImport.Size = new System.Drawing.Size(47, 22);
            this.tsbImport.Text = "Import";
            this.tsbImport.Click += new System.EventHandler(this.tsbImport_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbReset
            // 
            this.tsbReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbReset.Image = ((System.Drawing.Image)(resources.GetObject("tsbReset.Image")));
            this.tsbReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReset.Name = "tsbReset";
            this.tsbReset.Size = new System.Drawing.Size(39, 22);
            this.tsbReset.Text = "Reset";
            this.tsbReset.Click += new System.EventHandler(this.tsbReset_Click);
            // 
            // tlpGlobalContainer
            // 
            this.tlpGlobalContainer.ColumnCount = 1;
            this.tlpGlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpGlobalContainer.Controls.Add(this.gbGeneralConfiguration, 0, 0);
            this.tlpGlobalContainer.Controls.Add(this.gbTemplate, 0, 1);
            this.tlpGlobalContainer.Controls.Add(this.gbInformation, 0, 2);
            this.tlpGlobalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGlobalContainer.Location = new System.Drawing.Point(0, 25);
            this.tlpGlobalContainer.Name = "tlpGlobalContainer";
            this.tlpGlobalContainer.RowCount = 3;
            this.tlpGlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpGlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tlpGlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobalContainer.Size = new System.Drawing.Size(1354, 641);
            this.tlpGlobalContainer.TabIndex = 5;
            // 
            // gbGeneralConfiguration
            // 
            this.gbGeneralConfiguration.Controls.Add(this.tlpGeneralConfiguration);
            this.gbGeneralConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGeneralConfiguration.Location = new System.Drawing.Point(3, 3);
            this.gbGeneralConfiguration.Name = "gbGeneralConfiguration";
            this.gbGeneralConfiguration.Size = new System.Drawing.Size(1348, 94);
            this.gbGeneralConfiguration.TabIndex = 0;
            this.gbGeneralConfiguration.TabStop = false;
            this.gbGeneralConfiguration.Text = "General Configuration";
            // 
            // tlpGeneralConfiguration
            // 
            this.tlpGeneralConfiguration.ColumnCount = 3;
            this.tlpGeneralConfiguration.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpGeneralConfiguration.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpGeneralConfiguration.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpGeneralConfiguration.Controls.Add(this.gbEntityDefinition, 0, 0);
            this.tlpGeneralConfiguration.Controls.Add(this.gbQueryOptions, 1, 0);
            this.tlpGeneralConfiguration.Controls.Add(this.gbProcessingOptions, 2, 0);
            this.tlpGeneralConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGeneralConfiguration.Location = new System.Drawing.Point(3, 16);
            this.tlpGeneralConfiguration.Name = "tlpGeneralConfiguration";
            this.tlpGeneralConfiguration.RowCount = 1;
            this.tlpGeneralConfiguration.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGeneralConfiguration.Size = new System.Drawing.Size(1342, 75);
            this.tlpGeneralConfiguration.TabIndex = 0;
            // 
            // gbEntityDefinition
            // 
            this.gbEntityDefinition.Controls.Add(this.tlpEntityDefinition);
            this.gbEntityDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEntityDefinition.Location = new System.Drawing.Point(3, 3);
            this.gbEntityDefinition.Name = "gbEntityDefinition";
            this.gbEntityDefinition.Size = new System.Drawing.Size(441, 69);
            this.gbEntityDefinition.TabIndex = 0;
            this.gbEntityDefinition.TabStop = false;
            this.gbEntityDefinition.Text = "Entity Definition";
            // 
            // tlpEntityDefinition
            // 
            this.tlpEntityDefinition.ColumnCount = 2;
            this.tlpEntityDefinition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEntityDefinition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEntityDefinition.Controls.Add(this.lblEntity, 0, 0);
            this.tlpEntityDefinition.Controls.Add(this.cmbSelectedEntity, 1, 0);
            this.tlpEntityDefinition.Controls.Add(this.lblKey, 0, 1);
            this.tlpEntityDefinition.Controls.Add(this.cmbKey, 1, 1);
            this.tlpEntityDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEntityDefinition.Location = new System.Drawing.Point(3, 16);
            this.tlpEntityDefinition.Name = "tlpEntityDefinition";
            this.tlpEntityDefinition.RowCount = 2;
            this.tlpEntityDefinition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEntityDefinition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEntityDefinition.Size = new System.Drawing.Size(435, 50);
            this.tlpEntityDefinition.TabIndex = 0;
            // 
            // lblEntity
            // 
            this.lblEntity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEntity.AutoSize = true;
            this.lblEntity.Location = new System.Drawing.Point(3, 6);
            this.lblEntity.Name = "lblEntity";
            this.lblEntity.Size = new System.Drawing.Size(33, 13);
            this.lblEntity.TabIndex = 0;
            this.lblEntity.Text = "Entity";
            // 
            // cmbSelectedEntity
            // 
            this.cmbSelectedEntity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSelectedEntity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectedEntity.Enabled = false;
            this.cmbSelectedEntity.FormattingEnabled = true;
            this.cmbSelectedEntity.Location = new System.Drawing.Point(220, 3);
            this.cmbSelectedEntity.Name = "cmbSelectedEntity";
            this.cmbSelectedEntity.Size = new System.Drawing.Size(212, 21);
            this.cmbSelectedEntity.Sorted = true;
            this.cmbSelectedEntity.TabIndex = 1;
            this.cmbSelectedEntity.SelectedIndexChanged += new System.EventHandler(this.cmbSelectedEntity_SelectedIndexChanged);
            // 
            // lblKey
            // 
            this.lblKey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(3, 31);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(56, 13);
            this.lblKey.TabIndex = 2;
            this.lblKey.Text = "Use a Key";
            // 
            // cmbKey
            // 
            this.cmbKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKey.Enabled = false;
            this.cmbKey.FormattingEnabled = true;
            this.cmbKey.Location = new System.Drawing.Point(220, 28);
            this.cmbKey.Name = "cmbKey";
            this.cmbKey.Size = new System.Drawing.Size(212, 21);
            this.cmbKey.TabIndex = 3;
            this.cmbKey.SelectedIndexChanged += new System.EventHandler(this.cmbKey_SelectedIndexChanged);
            // 
            // gbQueryOptions
            // 
            this.gbQueryOptions.Controls.Add(this.tlpQueryOptions);
            this.gbQueryOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbQueryOptions.Location = new System.Drawing.Point(450, 3);
            this.gbQueryOptions.Name = "gbQueryOptions";
            this.gbQueryOptions.Size = new System.Drawing.Size(441, 69);
            this.gbQueryOptions.TabIndex = 1;
            this.gbQueryOptions.TabStop = false;
            this.gbQueryOptions.Text = "Query Options";
            // 
            // tlpQueryOptions
            // 
            this.tlpQueryOptions.ColumnCount = 2;
            this.tlpQueryOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpQueryOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpQueryOptions.Controls.Add(this.lblUnicity, 0, 0);
            this.tlpQueryOptions.Controls.Add(this.cmbUnicity, 1, 0);
            this.tlpQueryOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpQueryOptions.Location = new System.Drawing.Point(3, 16);
            this.tlpQueryOptions.Name = "tlpQueryOptions";
            this.tlpQueryOptions.RowCount = 2;
            this.tlpQueryOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpQueryOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpQueryOptions.Size = new System.Drawing.Size(435, 50);
            this.tlpQueryOptions.TabIndex = 0;
            // 
            // lblUnicity
            // 
            this.lblUnicity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUnicity.AutoSize = true;
            this.lblUnicity.Location = new System.Drawing.Point(3, 6);
            this.lblUnicity.Name = "lblUnicity";
            this.lblUnicity.Size = new System.Drawing.Size(39, 13);
            this.lblUnicity.TabIndex = 0;
            this.lblUnicity.Text = "Unicity";
            // 
            // cmbUnicity
            // 
            this.cmbUnicity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbUnicity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnicity.FormattingEnabled = true;
            this.cmbUnicity.Items.AddRange(new object[] {
            "First Found",
            "Unique Values"});
            this.cmbUnicity.Location = new System.Drawing.Point(220, 3);
            this.cmbUnicity.Name = "cmbUnicity";
            this.cmbUnicity.Size = new System.Drawing.Size(212, 21);
            this.cmbUnicity.TabIndex = 1;
            // 
            // gbProcessingOptions
            // 
            this.gbProcessingOptions.Controls.Add(this.tlpProcessingOptions);
            this.gbProcessingOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProcessingOptions.Location = new System.Drawing.Point(897, 3);
            this.gbProcessingOptions.Name = "gbProcessingOptions";
            this.gbProcessingOptions.Size = new System.Drawing.Size(442, 69);
            this.gbProcessingOptions.TabIndex = 2;
            this.gbProcessingOptions.TabStop = false;
            this.gbProcessingOptions.Text = "Processing Options";
            // 
            // tlpProcessingOptions
            // 
            this.tlpProcessingOptions.ColumnCount = 2;
            this.tlpProcessingOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProcessingOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProcessingOptions.Controls.Add(this.lblMaxParallelism, 0, 0);
            this.tlpProcessingOptions.Controls.Add(this.lblBatchSize, 0, 1);
            this.tlpProcessingOptions.Controls.Add(this.nudMaxParallelism, 1, 0);
            this.tlpProcessingOptions.Controls.Add(this.nudBatchSize, 1, 1);
            this.tlpProcessingOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProcessingOptions.Location = new System.Drawing.Point(3, 16);
            this.tlpProcessingOptions.Name = "tlpProcessingOptions";
            this.tlpProcessingOptions.RowCount = 2;
            this.tlpProcessingOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProcessingOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProcessingOptions.Size = new System.Drawing.Size(436, 50);
            this.tlpProcessingOptions.TabIndex = 0;
            // 
            // lblMaxParallelism
            // 
            this.lblMaxParallelism.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMaxParallelism.AutoSize = true;
            this.lblMaxParallelism.Location = new System.Drawing.Point(3, 6);
            this.lblMaxParallelism.Name = "lblMaxParallelism";
            this.lblMaxParallelism.Size = new System.Drawing.Size(79, 13);
            this.lblMaxParallelism.TabIndex = 0;
            this.lblMaxParallelism.Text = "Max Parallelism";
            // 
            // lblBatchSize
            // 
            this.lblBatchSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBatchSize.AutoSize = true;
            this.lblBatchSize.Location = new System.Drawing.Point(3, 31);
            this.lblBatchSize.Name = "lblBatchSize";
            this.lblBatchSize.Size = new System.Drawing.Size(58, 13);
            this.lblBatchSize.TabIndex = 1;
            this.lblBatchSize.Text = "Batch Size";
            // 
            // nudMaxParallelism
            // 
            this.nudMaxParallelism.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudMaxParallelism.Location = new System.Drawing.Point(221, 3);
            this.nudMaxParallelism.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxParallelism.Name = "nudMaxParallelism";
            this.nudMaxParallelism.Size = new System.Drawing.Size(212, 20);
            this.nudMaxParallelism.TabIndex = 2;
            this.nudMaxParallelism.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudBatchSize
            // 
            this.nudBatchSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudBatchSize.Location = new System.Drawing.Point(221, 28);
            this.nudBatchSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudBatchSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBatchSize.Name = "nudBatchSize";
            this.nudBatchSize.Size = new System.Drawing.Size(212, 20);
            this.nudBatchSize.TabIndex = 3;
            this.nudBatchSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gbTemplate
            // 
            this.gbTemplate.Controls.Add(this.tlpTemplate);
            this.gbTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTemplate.Location = new System.Drawing.Point(3, 103);
            this.gbTemplate.Name = "gbTemplate";
            this.gbTemplate.Size = new System.Drawing.Size(1348, 344);
            this.gbTemplate.TabIndex = 1;
            this.gbTemplate.TabStop = false;
            this.gbTemplate.Text = "Template";
            // 
            // tlpTemplate
            // 
            this.tlpTemplate.ColumnCount = 2;
            this.tlpTemplate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tlpTemplate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTemplate.Controls.Add(this.gbAttributeSelector, 0, 0);
            this.tlpTemplate.Controls.Add(this.gridTemplateColumns, 1, 0);
            this.tlpTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTemplate.Location = new System.Drawing.Point(3, 16);
            this.tlpTemplate.Name = "tlpTemplate";
            this.tlpTemplate.RowCount = 1;
            this.tlpTemplate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTemplate.Size = new System.Drawing.Size(1342, 325);
            this.tlpTemplate.TabIndex = 0;
            // 
            // gbAttributeSelector
            // 
            this.gbAttributeSelector.Controls.Add(this.tlpAttributeSelector);
            this.gbAttributeSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAttributeSelector.Location = new System.Drawing.Point(3, 3);
            this.gbAttributeSelector.Name = "gbAttributeSelector";
            this.gbAttributeSelector.Size = new System.Drawing.Size(344, 319);
            this.gbAttributeSelector.TabIndex = 0;
            this.gbAttributeSelector.TabStop = false;
            // 
            // tlpAttributeSelector
            // 
            this.tlpAttributeSelector.ColumnCount = 1;
            this.tlpAttributeSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAttributeSelector.Controls.Add(this.gbAddQueryExpression, 0, 0);
            this.tlpAttributeSelector.Controls.Add(this.gbAddAttributeToUpdate, 0, 1);
            this.tlpAttributeSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAttributeSelector.Location = new System.Drawing.Point(3, 16);
            this.tlpAttributeSelector.Name = "tlpAttributeSelector";
            this.tlpAttributeSelector.RowCount = 2;
            this.tlpAttributeSelector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tlpAttributeSelector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tlpAttributeSelector.Size = new System.Drawing.Size(338, 300);
            this.tlpAttributeSelector.TabIndex = 0;
            // 
            // gbAddQueryExpression
            // 
            this.gbAddQueryExpression.Controls.Add(this.tlpAddAttributeFroQuery);
            this.gbAddQueryExpression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAddQueryExpression.Location = new System.Drawing.Point(3, 3);
            this.gbAddQueryExpression.Name = "gbAddQueryExpression";
            this.gbAddQueryExpression.Size = new System.Drawing.Size(332, 149);
            this.gbAddQueryExpression.TabIndex = 0;
            this.gbAddQueryExpression.TabStop = false;
            this.gbAddQueryExpression.Text = "Add query expression";
            // 
            // tlpAddAttributeFroQuery
            // 
            this.tlpAddAttributeFroQuery.ColumnCount = 2;
            this.tlpAddAttributeFroQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpAddAttributeFroQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpAddAttributeFroQuery.Controls.Add(this.btnAddQueryAttribute, 0, 2);
            this.tlpAddAttributeFroQuery.Controls.Add(this.cmbAttributeForQuery, 1, 0);
            this.tlpAddAttributeFroQuery.Controls.Add(this.lblAttributeForQuery, 0, 0);
            this.tlpAddAttributeFroQuery.Controls.Add(this.lblConditionOperator, 0, 1);
            this.tlpAddAttributeFroQuery.Controls.Add(this.cmbConditionOperator, 1, 1);
            this.tlpAddAttributeFroQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddAttributeFroQuery.Location = new System.Drawing.Point(3, 16);
            this.tlpAddAttributeFroQuery.Name = "tlpAddAttributeFroQuery";
            this.tlpAddAttributeFroQuery.RowCount = 3;
            this.tlpAddAttributeFroQuery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAddAttributeFroQuery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAddAttributeFroQuery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAddAttributeFroQuery.Size = new System.Drawing.Size(326, 130);
            this.tlpAddAttributeFroQuery.TabIndex = 0;
            // 
            // btnAddQueryAttribute
            // 
            this.btnAddQueryAttribute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddQueryAttribute.Enabled = false;
            this.btnAddQueryAttribute.Location = new System.Drawing.Point(3, 89);
            this.btnAddQueryAttribute.Name = "btnAddQueryAttribute";
            this.btnAddQueryAttribute.Size = new System.Drawing.Size(64, 23);
            this.btnAddQueryAttribute.TabIndex = 0;
            this.btnAddQueryAttribute.Text = "Add";
            this.btnAddQueryAttribute.UseVisualStyleBackColor = true;
            this.btnAddQueryAttribute.Click += new System.EventHandler(this.btnAddQueryAttribute_Click);
            // 
            // cmbAttributeForQuery
            // 
            this.cmbAttributeForQuery.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbAttributeForQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAttributeForQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAttributeForQuery.Enabled = false;
            this.cmbAttributeForQuery.FormattingEnabled = true;
            this.cmbAttributeForQuery.Location = new System.Drawing.Point(73, 11);
            this.cmbAttributeForQuery.Name = "cmbAttributeForQuery";
            this.cmbAttributeForQuery.Size = new System.Drawing.Size(250, 21);
            this.cmbAttributeForQuery.Sorted = true;
            this.cmbAttributeForQuery.TabIndex = 0;
            // 
            // lblAttributeForQuery
            // 
            this.lblAttributeForQuery.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAttributeForQuery.AutoSize = true;
            this.lblAttributeForQuery.Location = new System.Drawing.Point(3, 15);
            this.lblAttributeForQuery.Name = "lblAttributeForQuery";
            this.lblAttributeForQuery.Size = new System.Drawing.Size(46, 13);
            this.lblAttributeForQuery.TabIndex = 2;
            this.lblAttributeForQuery.Text = "Attribute";
            // 
            // lblConditionOperator
            // 
            this.lblConditionOperator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblConditionOperator.AutoSize = true;
            this.lblConditionOperator.Location = new System.Drawing.Point(3, 58);
            this.lblConditionOperator.Name = "lblConditionOperator";
            this.lblConditionOperator.Size = new System.Drawing.Size(48, 13);
            this.lblConditionOperator.TabIndex = 3;
            this.lblConditionOperator.Text = "Operator";
            // 
            // cmbConditionOperator
            // 
            this.cmbConditionOperator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbConditionOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConditionOperator.Enabled = false;
            this.cmbConditionOperator.FormattingEnabled = true;
            this.cmbConditionOperator.Items.AddRange(new object[] {
            "Equal"});
            this.cmbConditionOperator.Location = new System.Drawing.Point(73, 54);
            this.cmbConditionOperator.Name = "cmbConditionOperator";
            this.cmbConditionOperator.Size = new System.Drawing.Size(250, 21);
            this.cmbConditionOperator.Sorted = true;
            this.cmbConditionOperator.TabIndex = 1;
            // 
            // gbAddAttributeToUpdate
            // 
            this.gbAddAttributeToUpdate.Controls.Add(this.tlpAttributeUpdate);
            this.gbAddAttributeToUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAddAttributeToUpdate.Location = new System.Drawing.Point(3, 158);
            this.gbAddAttributeToUpdate.Name = "gbAddAttributeToUpdate";
            this.gbAddAttributeToUpdate.Size = new System.Drawing.Size(332, 139);
            this.gbAddAttributeToUpdate.TabIndex = 1;
            this.gbAddAttributeToUpdate.TabStop = false;
            this.gbAddAttributeToUpdate.Text = "Add attribute to update";
            // 
            // tlpAttributeUpdate
            // 
            this.tlpAttributeUpdate.ColumnCount = 2;
            this.tlpAttributeUpdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpAttributeUpdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpAttributeUpdate.Controls.Add(this.btnAddAttributeToUpdate, 0, 1);
            this.tlpAttributeUpdate.Controls.Add(this.cmbAttributeToUpdate, 1, 0);
            this.tlpAttributeUpdate.Controls.Add(this.lblAttributeToUpdate, 0, 0);
            this.tlpAttributeUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAttributeUpdate.Location = new System.Drawing.Point(3, 16);
            this.tlpAttributeUpdate.Name = "tlpAttributeUpdate";
            this.tlpAttributeUpdate.RowCount = 2;
            this.tlpAttributeUpdate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAttributeUpdate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAttributeUpdate.Size = new System.Drawing.Size(326, 120);
            this.tlpAttributeUpdate.TabIndex = 2;
            // 
            // btnAddAttributeToUpdate
            // 
            this.btnAddAttributeToUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAttributeToUpdate.Enabled = false;
            this.btnAddAttributeToUpdate.Location = new System.Drawing.Point(3, 63);
            this.btnAddAttributeToUpdate.Name = "btnAddAttributeToUpdate";
            this.btnAddAttributeToUpdate.Size = new System.Drawing.Size(64, 23);
            this.btnAddAttributeToUpdate.TabIndex = 1;
            this.btnAddAttributeToUpdate.Text = "Add";
            this.btnAddAttributeToUpdate.UseVisualStyleBackColor = true;
            this.btnAddAttributeToUpdate.Click += new System.EventHandler(this.btnAddAttributeToUpdate_Click);
            // 
            // cmbAttributeToUpdate
            // 
            this.cmbAttributeToUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbAttributeToUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAttributeToUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAttributeToUpdate.Enabled = false;
            this.cmbAttributeToUpdate.FormattingEnabled = true;
            this.cmbAttributeToUpdate.Location = new System.Drawing.Point(73, 19);
            this.cmbAttributeToUpdate.Name = "cmbAttributeToUpdate";
            this.cmbAttributeToUpdate.Size = new System.Drawing.Size(250, 21);
            this.cmbAttributeToUpdate.Sorted = true;
            this.cmbAttributeToUpdate.TabIndex = 0;
            // 
            // lblAttributeToUpdate
            // 
            this.lblAttributeToUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAttributeToUpdate.AutoSize = true;
            this.lblAttributeToUpdate.Location = new System.Drawing.Point(3, 23);
            this.lblAttributeToUpdate.Name = "lblAttributeToUpdate";
            this.lblAttributeToUpdate.Size = new System.Drawing.Size(46, 13);
            this.lblAttributeToUpdate.TabIndex = 2;
            this.lblAttributeToUpdate.Text = "Attribute";
            // 
            // gridTemplateColumns
            // 
            this.gridTemplateColumns.AllowUserToOrderColumns = true;
            this.gridTemplateColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTemplateColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTemplateColumns.Location = new System.Drawing.Point(353, 3);
            this.gridTemplateColumns.MultiSelect = false;
            this.gridTemplateColumns.Name = "gridTemplateColumns";
            this.gridTemplateColumns.ReadOnly = true;
            this.gridTemplateColumns.Size = new System.Drawing.Size(986, 319);
            this.gridTemplateColumns.TabIndex = 1;
            // 
            // gbInformation
            // 
            this.gbInformation.Controls.Add(this.tlpInformation);
            this.gbInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbInformation.Location = new System.Drawing.Point(3, 453);
            this.gbInformation.Name = "gbInformation";
            this.gbInformation.Size = new System.Drawing.Size(1348, 185);
            this.gbInformation.TabIndex = 2;
            this.gbInformation.TabStop = false;
            this.gbInformation.Text = "Information";
            // 
            // tlpInformation
            // 
            this.tlpInformation.ColumnCount = 1;
            this.tlpInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInformation.Controls.Add(this.lblFilePath, 0, 0);
            this.tlpInformation.Controls.Add(this.lblFileTemplate, 0, 1);
            this.tlpInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInformation.Location = new System.Drawing.Point(3, 16);
            this.tlpInformation.Name = "tlpInformation";
            this.tlpInformation.RowCount = 2;
            this.tlpInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInformation.Size = new System.Drawing.Size(1342, 166);
            this.tlpInformation.TabIndex = 2;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFilePath.Location = new System.Drawing.Point(3, 0);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(1336, 83);
            this.lblFilePath.TabIndex = 0;
            this.lblFilePath.Text = "Choose a CSV file with the given format";
            // 
            // lblFileTemplate
            // 
            this.lblFileTemplate.AutoSize = true;
            this.lblFileTemplate.Location = new System.Drawing.Point(3, 83);
            this.lblFileTemplate.Name = "lblFileTemplate";
            this.lblFileTemplate.Size = new System.Drawing.Size(76, 13);
            this.lblFileTemplate.TabIndex = 1;
            this.lblFileTemplate.Text = "File Template :";
            // 
            // tsbAbout
            // 
            this.tsbAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAbout.Image = ((System.Drawing.Image)(resources.GetObject("tsbAbout.Image")));
            this.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbout.Name = "tsbAbout";
            this.tsbAbout.Size = new System.Drawing.Size(44, 22);
            this.tsbAbout.Text = "About";
            this.tsbAbout.Click += new System.EventHandler(this.tsbAbout_Click);
            // 
            // CSVImporterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpGlobalContainer);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "CSVImporterControl";
            this.Size = new System.Drawing.Size(1354, 666);
            this.Load += new System.EventHandler(this.CSVImporterControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.tlpGlobalContainer.ResumeLayout(false);
            this.gbGeneralConfiguration.ResumeLayout(false);
            this.tlpGeneralConfiguration.ResumeLayout(false);
            this.gbEntityDefinition.ResumeLayout(false);
            this.tlpEntityDefinition.ResumeLayout(false);
            this.tlpEntityDefinition.PerformLayout();
            this.gbQueryOptions.ResumeLayout(false);
            this.tlpQueryOptions.ResumeLayout(false);
            this.tlpQueryOptions.PerformLayout();
            this.gbProcessingOptions.ResumeLayout(false);
            this.tlpProcessingOptions.ResumeLayout(false);
            this.tlpProcessingOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxParallelism)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBatchSize)).EndInit();
            this.gbTemplate.ResumeLayout(false);
            this.tlpTemplate.ResumeLayout(false);
            this.gbAttributeSelector.ResumeLayout(false);
            this.tlpAttributeSelector.ResumeLayout(false);
            this.gbAddQueryExpression.ResumeLayout(false);
            this.tlpAddAttributeFroQuery.ResumeLayout(false);
            this.tlpAddAttributeFroQuery.PerformLayout();
            this.gbAddAttributeToUpdate.ResumeLayout(false);
            this.tlpAttributeUpdate.ResumeLayout(false);
            this.tlpAttributeUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTemplateColumns)).EndInit();
            this.gbInformation.ResumeLayout(false);
            this.tlpInformation.ResumeLayout(false);
            this.tlpInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbLoadEntities;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.TableLayoutPanel tlpGlobalContainer;
        private System.Windows.Forms.GroupBox gbGeneralConfiguration;
        private System.Windows.Forms.GroupBox gbTemplate;
        private System.Windows.Forms.GroupBox gbInformation;
        private System.Windows.Forms.TableLayoutPanel tlpTemplate;
        private System.Windows.Forms.GroupBox gbAttributeSelector;
        private System.Windows.Forms.TableLayoutPanel tlpAttributeSelector;
        private System.Windows.Forms.GroupBox gbAddQueryExpression;
        private System.Windows.Forms.GroupBox gbAddAttributeToUpdate;
        private System.Windows.Forms.ComboBox cmbAttributeForQuery;
        private System.Windows.Forms.TableLayoutPanel tlpAddAttributeFroQuery;
        private System.Windows.Forms.Button btnAddQueryAttribute;
        private System.Windows.Forms.Label lblAttributeForQuery;
        private System.Windows.Forms.Label lblConditionOperator;
        private System.Windows.Forms.ComboBox cmbConditionOperator;
        private System.Windows.Forms.Button btnAddAttributeToUpdate;
        private System.Windows.Forms.TableLayoutPanel tlpAttributeUpdate;
        private System.Windows.Forms.ComboBox cmbAttributeToUpdate;
        private System.Windows.Forms.Label lblAttributeToUpdate;
        private System.Windows.Forms.TableLayoutPanel tlpGeneralConfiguration;
        private System.Windows.Forms.GroupBox gbEntityDefinition;
        private System.Windows.Forms.TableLayoutPanel tlpEntityDefinition;
        private System.Windows.Forms.GroupBox gbQueryOptions;
        private System.Windows.Forms.TableLayoutPanel tlpQueryOptions;
        private System.Windows.Forms.GroupBox gbProcessingOptions;
        private System.Windows.Forms.TableLayoutPanel tlpProcessingOptions;
        private System.Windows.Forms.Label lblEntity;
        private System.Windows.Forms.ComboBox cmbSelectedEntity;
        private System.Windows.Forms.Label lblUnicity;
        private System.Windows.Forms.ComboBox cmbUnicity;
        private System.Windows.Forms.Label lblMaxParallelism;
        private System.Windows.Forms.Label lblBatchSize;
        private System.Windows.Forms.NumericUpDown nudMaxParallelism;
        private System.Windows.Forms.NumericUpDown nudBatchSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbBrowse;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbImport;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.ComboBox cmbKey;
        private System.Windows.Forms.DataGridView gridTemplateColumns;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbReset;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.TableLayoutPanel tlpInformation;
        private System.Windows.Forms.Label lblFileTemplate;
        private System.Windows.Forms.ToolStripButton tsbAbout;
    }
}
