namespace CodeSystem.Forms
{
    partial class AccountsForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountsForm));
            this.reportViewsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewsDataSet = new CodeSystem.ReportViewsDataSet();
            this.accountsTitleLabel = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.accountTypeLabel = new System.Windows.Forms.Label();
            this.accountTypeComboBox = new System.Windows.Forms.ComboBox();
            this.tblAccountTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportDataSet = new CodeSystem.ReportDataSet();
            this.paymentAccountTypeLabel = new System.Windows.Forms.Label();
            this.accountIDLabel = new System.Windows.Forms.Label();
            this.nameArLabel = new System.Windows.Forms.Label();
            this.accountIDTextBox = new System.Windows.Forms.TextBox();
            this.nameArabicTextBox = new System.Windows.Forms.TextBox();
            this.nameEnLabel = new System.Windows.Forms.Label();
            this.nameEnglishTextBox = new System.Windows.Forms.TextBox();
            this.nationalityLabel = new System.Windows.Forms.Label();
            this.branchTextBox = new System.Windows.Forms.TextBox();
            this.branchLabel = new System.Windows.Forms.Label();
            this.accountNotesLabel = new System.Windows.Forms.Label();
            this.accountNoteTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.vatNumberTextBox = new System.Windows.Forms.TextBox();
            this.vatNumberLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.nationalityComboBox = new System.Windows.Forms.ComboBox();
            this.paymentAccountComboBox = new System.Windows.Forms.ComboBox();
            this.tblAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.documentTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentExpDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentNoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentImagePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblAccountDocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAccountDocumentTableAdapter = new CodeSystem.ReportDataSetTableAdapters.tblAccountDocumentTableAdapter();
            this.tblAccountTypeTableAdapter = new CodeSystem.ReportDataSetTableAdapters.tblAccountTypeTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.undoButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.tblAccountTableAdapter = new CodeSystem.ReportDataSetTableAdapters.tblAccountTableAdapter();
            this.tblMoneyAccountTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblMoneyAccountTypeTableAdapter = new CodeSystem.ReportDataSetTableAdapters.tblMoneyAccountTypeTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.reportViewsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportViewsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountDocumentBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMoneyAccountTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewsDataSetBindingSource
            // 
            this.reportViewsDataSetBindingSource.DataSource = this.reportViewsDataSet;
            this.reportViewsDataSetBindingSource.Position = 0;
            // 
            // reportViewsDataSet
            // 
            this.reportViewsDataSet.DataSetName = "ReportViewsDataSet";
            this.reportViewsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountsTitleLabel
            // 
            this.accountsTitleLabel.AutoSize = true;
            this.accountsTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsTitleLabel.Location = new System.Drawing.Point(1289, 27);
            this.accountsTitleLabel.Name = "accountsTitleLabel";
            this.accountsTitleLabel.Size = new System.Drawing.Size(121, 38);
            this.accountsTitleLabel.TabIndex = 1;
            this.accountsTitleLabel.Text = "الحسابات";
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(12, 102);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(88, 33);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "بحث";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // accountTypeLabel
            // 
            this.accountTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountTypeLabel.AutoSize = true;
            this.accountTypeLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTypeLabel.Location = new System.Drawing.Point(1003, 27);
            this.accountTypeLabel.Name = "accountTypeLabel";
            this.accountTypeLabel.Size = new System.Drawing.Size(108, 23);
            this.accountTypeLabel.TabIndex = 4;
            this.accountTypeLabel.Text = "AccountType";
            this.accountTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accountTypeComboBox
            // 
            this.accountTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountTypeComboBox.DataSource = this.tblAccountTypeBindingSource;
            this.accountTypeComboBox.DisplayMember = "NameAr";
            this.accountTypeComboBox.FormattingEnabled = true;
            this.accountTypeComboBox.Location = new System.Drawing.Point(972, 53);
            this.accountTypeComboBox.Name = "accountTypeComboBox";
            this.accountTypeComboBox.Size = new System.Drawing.Size(192, 24);
            this.accountTypeComboBox.TabIndex = 5;
            this.accountTypeComboBox.ValueMember = "ID";
            this.accountTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.accountTypeComboBox_SelectedIndexChanged);
            // 
            // tblAccountTypeBindingSource
            // 
            this.tblAccountTypeBindingSource.DataMember = "tblAccountType";
            this.tblAccountTypeBindingSource.DataSource = this.reportDataSet;
            // 
            // reportDataSet
            // 
            this.reportDataSet.DataSetName = "ReportDataSet";
            this.reportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentAccountTypeLabel
            // 
            this.paymentAccountTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentAccountTypeLabel.AutoSize = true;
            this.paymentAccountTypeLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentAccountTypeLabel.Location = new System.Drawing.Point(692, 27);
            this.paymentAccountTypeLabel.Name = "paymentAccountTypeLabel";
            this.paymentAccountTypeLabel.Size = new System.Drawing.Size(144, 23);
            this.paymentAccountTypeLabel.TabIndex = 6;
            this.paymentAccountTypeLabel.Text = "Payment Account";
            this.paymentAccountTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accountIDLabel
            // 
            this.accountIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountIDLabel.AutoSize = true;
            this.accountIDLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountIDLabel.Location = new System.Drawing.Point(360, 0);
            this.accountIDLabel.Name = "accountIDLabel";
            this.accountIDLabel.Size = new System.Drawing.Size(248, 23);
            this.accountIDLabel.TabIndex = 8;
            this.accountIDLabel.Text = "AccountID";
            this.accountIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameArLabel
            // 
            this.nameArLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameArLabel.AutoSize = true;
            this.nameArLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameArLabel.Location = new System.Drawing.Point(360, 62);
            this.nameArLabel.Name = "nameArLabel";
            this.nameArLabel.Size = new System.Drawing.Size(248, 23);
            this.nameArLabel.TabIndex = 9;
            this.nameArLabel.Text = "Arabic Name";
            this.nameArLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accountIDTextBox
            // 
            this.accountIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountIDTextBox.Location = new System.Drawing.Point(3, 3);
            this.accountIDTextBox.Name = "accountIDTextBox";
            this.accountIDTextBox.Size = new System.Drawing.Size(351, 24);
            this.accountIDTextBox.TabIndex = 10;
            // 
            // nameArabicTextBox
            // 
            this.nameArabicTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameArabicTextBox.Location = new System.Drawing.Point(3, 65);
            this.nameArabicTextBox.Name = "nameArabicTextBox";
            this.nameArabicTextBox.Size = new System.Drawing.Size(351, 24);
            this.nameArabicTextBox.TabIndex = 11;
            // 
            // nameEnLabel
            // 
            this.nameEnLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameEnLabel.AutoSize = true;
            this.nameEnLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameEnLabel.Location = new System.Drawing.Point(360, 31);
            this.nameEnLabel.Name = "nameEnLabel";
            this.nameEnLabel.Size = new System.Drawing.Size(248, 23);
            this.nameEnLabel.TabIndex = 12;
            this.nameEnLabel.Text = "English Name";
            this.nameEnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameEnglishTextBox
            // 
            this.nameEnglishTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameEnglishTextBox.Location = new System.Drawing.Point(3, 34);
            this.nameEnglishTextBox.Name = "nameEnglishTextBox";
            this.nameEnglishTextBox.Size = new System.Drawing.Size(351, 24);
            this.nameEnglishTextBox.TabIndex = 13;
            // 
            // nationalityLabel
            // 
            this.nationalityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nationalityLabel.AutoSize = true;
            this.nationalityLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nationalityLabel.Location = new System.Drawing.Point(360, 166);
            this.nationalityLabel.Name = "nationalityLabel";
            this.nationalityLabel.Size = new System.Drawing.Size(248, 23);
            this.nationalityLabel.TabIndex = 14;
            this.nationalityLabel.Text = "Nationality";
            this.nationalityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // branchTextBox
            // 
            this.branchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.branchTextBox.Location = new System.Drawing.Point(3, 205);
            this.branchTextBox.Name = "branchTextBox";
            this.branchTextBox.Size = new System.Drawing.Size(351, 24);
            this.branchTextBox.TabIndex = 17;
            // 
            // branchLabel
            // 
            this.branchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.branchLabel.AutoSize = true;
            this.branchLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchLabel.Location = new System.Drawing.Point(360, 202);
            this.branchLabel.Name = "branchLabel";
            this.branchLabel.Size = new System.Drawing.Size(248, 23);
            this.branchLabel.TabIndex = 16;
            this.branchLabel.Text = "Branch";
            this.branchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accountNotesLabel
            // 
            this.accountNotesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountNotesLabel.AutoSize = true;
            this.accountNotesLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNotesLabel.Location = new System.Drawing.Point(360, 275);
            this.accountNotesLabel.Name = "accountNotesLabel";
            this.accountNotesLabel.Size = new System.Drawing.Size(248, 23);
            this.accountNotesLabel.TabIndex = 18;
            this.accountNotesLabel.Text = "Account Notes";
            this.accountNotesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accountNoteTextBox
            // 
            this.accountNoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountNoteTextBox.Location = new System.Drawing.Point(3, 278);
            this.accountNoteTextBox.Multiline = true;
            this.accountNoteTextBox.Name = "accountNoteTextBox";
            this.accountNoteTextBox.Size = new System.Drawing.Size(351, 68);
            this.accountNoteTextBox.TabIndex = 19;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTextBox.Location = new System.Drawing.Point(3, 133);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(351, 24);
            this.phoneTextBox.TabIndex = 21;
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(360, 130);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(248, 23);
            this.phoneLabel.TabIndex = 20;
            this.phoneLabel.Text = "Phone";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // vatNumberTextBox
            // 
            this.vatNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vatNumberTextBox.Location = new System.Drawing.Point(3, 99);
            this.vatNumberTextBox.Name = "vatNumberTextBox";
            this.vatNumberTextBox.Size = new System.Drawing.Size(351, 24);
            this.vatNumberTextBox.TabIndex = 23;
            // 
            // vatNumberLabel
            // 
            this.vatNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vatNumberLabel.AutoSize = true;
            this.vatNumberLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vatNumberLabel.Location = new System.Drawing.Point(360, 96);
            this.vatNumberLabel.Name = "vatNumberLabel";
            this.vatNumberLabel.Size = new System.Drawing.Size(248, 23);
            this.vatNumberLabel.TabIndex = 22;
            this.vatNumberLabel.Text = "VAT Number";
            this.vatNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextBox.Location = new System.Drawing.Point(3, 239);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(351, 24);
            this.addressTextBox.TabIndex = 25;
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(360, 236);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(248, 23);
            this.addressLabel.TabIndex = 24;
            this.addressLabel.Text = "Address";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nationalityComboBox
            // 
            this.nationalityComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nationalityComboBox.FormattingEnabled = true;
            this.nationalityComboBox.Location = new System.Drawing.Point(3, 169);
            this.nationalityComboBox.Name = "nationalityComboBox";
            this.nationalityComboBox.Size = new System.Drawing.Size(351, 24);
            this.nationalityComboBox.TabIndex = 26;
            // 
            // paymentAccountComboBox
            // 
            this.paymentAccountComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentAccountComboBox.DataSource = this.tblAccountBindingSource;
            this.paymentAccountComboBox.DisplayMember = "NameAr";
            this.paymentAccountComboBox.FormattingEnabled = true;
            this.paymentAccountComboBox.Location = new System.Drawing.Point(696, 53);
            this.paymentAccountComboBox.Name = "paymentAccountComboBox";
            this.paymentAccountComboBox.Size = new System.Drawing.Size(148, 24);
            this.paymentAccountComboBox.TabIndex = 27;
            this.paymentAccountComboBox.ValueMember = "ID";
            this.paymentAccountComboBox.SelectedIndexChanged += new System.EventHandler(this.paymentAccountComboBox_SelectedIndexChanged);
            // 
            // tblAccountBindingSource
            // 
            this.tblAccountBindingSource.DataMember = "tblAccount";
            this.tblAccountBindingSource.DataSource = this.reportDataSet;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 102);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(377, 33);
            this.textBox1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.57418F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.42582F));
            this.tableLayoutPanel2.Controls.Add(this.accountNoteTextBox, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.accountNotesLabel, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.addressLabel, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.addressTextBox, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.accountIDTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.nameEnglishTextBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.accountIDLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.vatNumberTextBox, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.nameEnLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.nationalityComboBox, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.nameArabicTextBox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.vatNumberLabel, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.branchLabel, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.nameArLabel, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.phoneTextBox, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.branchTextBox, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.phoneLabel, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.nationalityLabel, 1, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(608, 102);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.78261F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.21739F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(611, 349);
            this.tableLayoutPanel2.TabIndex = 28;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentTypeIDDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.accountIDDataGridViewTextBoxColumn,
            this.documentIDDataGridViewTextBoxColumn,
            this.documentDateDataGridViewTextBoxColumn,
            this.documentExpDateDataGridViewTextBoxColumn,
            this.documentSourceDataGridViewTextBoxColumn,
            this.documentNoteDataGridViewTextBoxColumn,
            this.documentImagePathDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblAccountDocumentBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(608, 474);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 26;
            this.dataGridView2.Size = new System.Drawing.Size(611, 150);
            this.dataGridView2.TabIndex = 29;
            // 
            // documentTypeIDDataGridViewTextBoxColumn
            // 
            this.documentTypeIDDataGridViewTextBoxColumn.DataPropertyName = "DocumentTypeID";
            this.documentTypeIDDataGridViewTextBoxColumn.DataSource = this.tblAccountTypeBindingSource;
            this.documentTypeIDDataGridViewTextBoxColumn.DisplayMember = "NameAr";
            this.documentTypeIDDataGridViewTextBoxColumn.HeaderText = "DocumentTypeID";
            this.documentTypeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentTypeIDDataGridViewTextBoxColumn.Name = "documentTypeIDDataGridViewTextBoxColumn";
            this.documentTypeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.documentTypeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.documentTypeIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.documentTypeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // accountIDDataGridViewTextBoxColumn
            // 
            this.accountIDDataGridViewTextBoxColumn.DataPropertyName = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.HeaderText = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accountIDDataGridViewTextBoxColumn.Name = "accountIDDataGridViewTextBoxColumn";
            this.accountIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // documentIDDataGridViewTextBoxColumn
            // 
            this.documentIDDataGridViewTextBoxColumn.DataPropertyName = "DocumentID";
            this.documentIDDataGridViewTextBoxColumn.HeaderText = "DocumentID";
            this.documentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentIDDataGridViewTextBoxColumn.Name = "documentIDDataGridViewTextBoxColumn";
            this.documentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // documentDateDataGridViewTextBoxColumn
            // 
            this.documentDateDataGridViewTextBoxColumn.DataPropertyName = "DocumentDate";
            this.documentDateDataGridViewTextBoxColumn.HeaderText = "DocumentDate";
            this.documentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentDateDataGridViewTextBoxColumn.Name = "documentDateDataGridViewTextBoxColumn";
            this.documentDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // documentExpDateDataGridViewTextBoxColumn
            // 
            this.documentExpDateDataGridViewTextBoxColumn.DataPropertyName = "DocumentExpDate";
            this.documentExpDateDataGridViewTextBoxColumn.HeaderText = "DocumentExpDate";
            this.documentExpDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentExpDateDataGridViewTextBoxColumn.Name = "documentExpDateDataGridViewTextBoxColumn";
            this.documentExpDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // documentSourceDataGridViewTextBoxColumn
            // 
            this.documentSourceDataGridViewTextBoxColumn.DataPropertyName = "DocumentSource";
            this.documentSourceDataGridViewTextBoxColumn.HeaderText = "DocumentSource";
            this.documentSourceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentSourceDataGridViewTextBoxColumn.Name = "documentSourceDataGridViewTextBoxColumn";
            this.documentSourceDataGridViewTextBoxColumn.Width = 125;
            // 
            // documentNoteDataGridViewTextBoxColumn
            // 
            this.documentNoteDataGridViewTextBoxColumn.DataPropertyName = "DocumentNote";
            this.documentNoteDataGridViewTextBoxColumn.HeaderText = "DocumentNote";
            this.documentNoteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentNoteDataGridViewTextBoxColumn.Name = "documentNoteDataGridViewTextBoxColumn";
            this.documentNoteDataGridViewTextBoxColumn.Width = 125;
            // 
            // documentImagePathDataGridViewTextBoxColumn
            // 
            this.documentImagePathDataGridViewTextBoxColumn.DataPropertyName = "DocumentImagePath";
            this.documentImagePathDataGridViewTextBoxColumn.HeaderText = "DocumentImagePath";
            this.documentImagePathDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentImagePathDataGridViewTextBoxColumn.Name = "documentImagePathDataGridViewTextBoxColumn";
            this.documentImagePathDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblAccountDocumentBindingSource
            // 
            this.tblAccountDocumentBindingSource.DataMember = "tblAccountDocument";
            this.tblAccountDocumentBindingSource.DataSource = this.reportDataSet;
            // 
            // tblAccountDocumentTableAdapter
            // 
            this.tblAccountDocumentTableAdapter.ClearBeforeFill = true;
            // 
            // tblAccountTypeTableAdapter
            // 
            this.tblAccountTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.undoButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.deleteButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.exitButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.saveButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.editButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.newButton, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(475, 92);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // undoButton
            // 
            this.undoButton.BackColor = System.Drawing.Color.Silver;
            this.undoButton.Enabled = false;
            this.undoButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undoButton.Image = ((System.Drawing.Image)(resources.GetObject("undoButton.Image")));
            this.undoButton.Location = new System.Drawing.Point(240, 3);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(73, 86);
            this.undoButton.TabIndex = 3;
            this.undoButton.Text = "Undo";
            this.undoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.undoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.undoButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Brown;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deleteButton.Location = new System.Drawing.Point(82, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(73, 86);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(3, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(73, 86);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.White;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(319, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(73, 86);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.White;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
            this.editButton.Location = new System.Drawing.Point(161, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(73, 86);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit";
            this.editButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.editButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Image = ((System.Drawing.Image)(resources.GetObject("newButton.Image")));
            this.newButton.Location = new System.Drawing.Point(398, 3);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(73, 86);
            this.newButton.TabIndex = 2;
            this.newButton.Text = "New";
            this.newButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.newButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.newButton.UseVisualStyleBackColor = true;
            // 
            // tblAccountTableAdapter
            // 
            this.tblAccountTableAdapter.ClearBeforeFill = true;
            // 
            // tblMoneyAccountTypeBindingSource
            // 
            this.tblMoneyAccountTypeBindingSource.DataMember = "tblMoneyAccountType";
            this.tblMoneyAccountTypeBindingSource.DataSource = this.reportDataSet;
            // 
            // tblMoneyAccountTypeTableAdapter
            // 
            this.tblMoneyAccountTypeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.reportViewsDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(475, 483);
            this.dataGridView1.TabIndex = 0;
            // 
            // AccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.paymentAccountComboBox);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.paymentAccountTypeLabel);
            this.Controls.Add(this.accountTypeComboBox);
            this.Controls.Add(this.accountTypeLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.accountsTitleLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AccountsForm";
            this.Size = new System.Drawing.Size(1436, 693);
            this.Load += new System.EventHandler(this.AccountsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportViewsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportViewsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountDocumentBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblMoneyAccountTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label accountsTitleLabel;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label accountTypeLabel;
        private System.Windows.Forms.ComboBox accountTypeComboBox;
        private System.Windows.Forms.Label paymentAccountTypeLabel;
        private System.Windows.Forms.Label accountIDLabel;
        private System.Windows.Forms.Label nameArLabel;
        private System.Windows.Forms.TextBox accountIDTextBox;
        private System.Windows.Forms.TextBox nameArabicTextBox;
        private System.Windows.Forms.TextBox nameEnglishTextBox;
        private System.Windows.Forms.Label nationalityLabel;
        private System.Windows.Forms.TextBox branchTextBox;
        private System.Windows.Forms.Label branchLabel;
        private System.Windows.Forms.Label accountNotesLabel;
        private System.Windows.Forms.TextBox accountNoteTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox vatNumberTextBox;
        private System.Windows.Forms.Label vatNumberLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.ComboBox nationalityComboBox;
        private System.Windows.Forms.ComboBox paymentAccountComboBox;
        private System.Windows.Forms.Label nameEnLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource tblAccountDocumentBindingSource;
        private ReportDataSet reportDataSet;
        private ReportDataSetTableAdapters.tblAccountDocumentTableAdapter tblAccountDocumentTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn documentTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblAccountTypeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentExpDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentSourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentNoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentImagePathDataGridViewTextBoxColumn;
        private ReportDataSetTableAdapters.tblAccountTypeTableAdapter tblAccountTypeTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.BindingSource reportViewsDataSetBindingSource;
        private ReportViewsDataSet reportViewsDataSet;
        private System.Windows.Forms.BindingSource tblAccountBindingSource;
        private ReportDataSetTableAdapters.tblAccountTableAdapter tblAccountTableAdapter;
        private System.Windows.Forms.BindingSource tblMoneyAccountTypeBindingSource;
        private ReportDataSetTableAdapters.tblMoneyAccountTypeTableAdapter tblMoneyAccountTypeTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
