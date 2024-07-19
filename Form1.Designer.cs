namespace ComponentsDB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            InputSNumber = new TextBox();
            SNumberLBL = new Label();
            FindBtn = new Button();
            SortBtn = new Button();
            SNumberCmpRadioBtn = new RadioButton();
            ProdDateRadioBtn = new RadioButton();
            PNRRadioBtn = new RadioButton();
            SoftVersionRadioBtn = new RadioButton();
            HardVersionRadioBtn = new RadioButton();
            SNumIEMRadioBtn = new RadioButton();
            SerialNumberLbl = new Label();
            SerialNumberTextBox = new TextBox();
            ObjectNameLbl = new Label();
            ObjectNameRadioBtn = new RadioButton();
            ObjectNameTextBox = new TextBox();
            ProdDateLbl = new Label();
            ProdDateTextBox = new TextBox();
            PNRLbl = new Label();
            PNRTextBox = new TextBox();
            SoftVersionLbl = new Label();
            SoftVersionTextBox = new TextBox();
            HardVersionLbl = new Label();
            HardVersionTextBox = new TextBox();
            SNumberIEMLbl = new Label();
            SNumberIEMTextBox = new TextBox();
            NotesLbl = new Label();
            AddDataBtn = new Button();
            Notes = new RichTextBox();
            DataGridView = new DataGridView();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // InputSNumber
            // 
            InputSNumber.Location = new Point(12, 28);
            InputSNumber.Name = "InputSNumber";
            InputSNumber.Size = new Size(229, 27);
            InputSNumber.TabIndex = 1;
            // 
            // SNumberLBL
            // 
            SNumberLBL.AutoSize = true;
            SNumberLBL.Location = new Point(11, 5);
            SNumberLBL.Name = "SNumberLBL";
            SNumberLBL.Size = new Size(221, 20);
            SNumberLBL.TabIndex = 2;
            SNumberLBL.Text = "Серийный номер компонента";
            // 
            // FindBtn
            // 
            FindBtn.Location = new Point(12, 61);
            FindBtn.Name = "FindBtn";
            FindBtn.Size = new Size(229, 55);
            FindBtn.TabIndex = 3;
            FindBtn.Text = "Поиск";
            FindBtn.UseVisualStyleBackColor = true;
            FindBtn.Click += FindBtn_Click;
            // 
            // SortBtn
            // 
            SortBtn.Location = new Point(10, 332);
            SortBtn.Name = "SortBtn";
            SortBtn.Size = new Size(229, 55);
            SortBtn.TabIndex = 4;
            SortBtn.Text = "Сортировать";
            SortBtn.UseVisualStyleBackColor = true;
            SortBtn.Click += SortBtn_Click;
            // 
            // SNumberCmpRadioBtn
            // 
            SNumberCmpRadioBtn.AutoSize = true;
            SNumberCmpRadioBtn.Location = new Point(10, 152);
            SNumberCmpRadioBtn.Name = "SNumberCmpRadioBtn";
            SNumberCmpRadioBtn.Size = new Size(242, 24);
            SNumberCmpRadioBtn.TabIndex = 6;
            SNumberCmpRadioBtn.TabStop = true;
            SNumberCmpRadioBtn.Text = "Серийный номер компонента";
            SNumberCmpRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ProdDateRadioBtn
            // 
            ProdDateRadioBtn.AutoSize = true;
            ProdDateRadioBtn.Location = new Point(10, 182);
            ProdDateRadioBtn.Name = "ProdDateRadioBtn";
            ProdDateRadioBtn.Size = new Size(163, 24);
            ProdDateRadioBtn.TabIndex = 7;
            ProdDateRadioBtn.TabStop = true;
            ProdDateRadioBtn.Text = "Дата производства";
            ProdDateRadioBtn.UseVisualStyleBackColor = true;
            // 
            // PNRRadioBtn
            // 
            PNRRadioBtn.AutoSize = true;
            PNRRadioBtn.Location = new Point(10, 212);
            PNRRadioBtn.Name = "PNRRadioBtn";
            PNRRadioBtn.Size = new Size(58, 24);
            PNRRadioBtn.TabIndex = 8;
            PNRRadioBtn.TabStop = true;
            PNRRadioBtn.Text = "PNR";
            PNRRadioBtn.UseVisualStyleBackColor = true;
            // 
            // SoftVersionRadioBtn
            // 
            SoftVersionRadioBtn.AutoSize = true;
            SoftVersionRadioBtn.Location = new Point(10, 242);
            SoftVersionRadioBtn.Name = "SoftVersionRadioBtn";
            SoftVersionRadioBtn.Size = new Size(106, 24);
            SoftVersionRadioBtn.TabIndex = 9;
            SoftVersionRadioBtn.TabStop = true;
            SoftVersionRadioBtn.Text = "Версия ПО";
            SoftVersionRadioBtn.UseVisualStyleBackColor = true;
            // 
            // HardVersionRadioBtn
            // 
            HardVersionRadioBtn.AutoSize = true;
            HardVersionRadioBtn.Location = new Point(11, 272);
            HardVersionRadioBtn.Name = "HardVersionRadioBtn";
            HardVersionRadioBtn.Size = new Size(105, 24);
            HardVersionRadioBtn.TabIndex = 10;
            HardVersionRadioBtn.TabStop = true;
            HardVersionRadioBtn.Text = "Версия АО";
            HardVersionRadioBtn.UseVisualStyleBackColor = true;
            // 
            // SNumIEMRadioBtn
            // 
            SNumIEMRadioBtn.AutoSize = true;
            SNumIEMRadioBtn.Location = new Point(10, 302);
            SNumIEMRadioBtn.Name = "SNumIEMRadioBtn";
            SNumIEMRadioBtn.Size = new Size(188, 24);
            SNumIEMRadioBtn.TabIndex = 11;
            SNumIEMRadioBtn.TabStop = true;
            SNumIEMRadioBtn.Text = "Серийный номер ВЭМ";
            SNumIEMRadioBtn.UseVisualStyleBackColor = true;
            // 
            // SerialNumberLbl
            // 
            SerialNumberLbl.AutoSize = true;
            SerialNumberLbl.Location = new Point(12, 443);
            SerialNumberLbl.Name = "SerialNumberLbl";
            SerialNumberLbl.Size = new Size(221, 20);
            SerialNumberLbl.TabIndex = 12;
            SerialNumberLbl.Text = "Серийный номер компонента";
            // 
            // SerialNumberTextBox
            // 
            SerialNumberTextBox.Location = new Point(12, 466);
            SerialNumberTextBox.Name = "SerialNumberTextBox";
            SerialNumberTextBox.Size = new Size(242, 27);
            SerialNumberTextBox.TabIndex = 13;
            // 
            // ObjectNameLbl
            // 
            ObjectNameLbl.AutoSize = true;
            ObjectNameLbl.Location = new Point(12, 390);
            ObjectNameLbl.Name = "ObjectNameLbl";
            ObjectNameLbl.Size = new Size(176, 20);
            ObjectNameLbl.TabIndex = 14;
            ObjectNameLbl.Text = "Наименование объекта";
            // 
            // ObjectNameRadioBtn
            // 
            ObjectNameRadioBtn.AutoSize = true;
            ObjectNameRadioBtn.Location = new Point(12, 122);
            ObjectNameRadioBtn.Name = "ObjectNameRadioBtn";
            ObjectNameRadioBtn.Size = new Size(197, 24);
            ObjectNameRadioBtn.TabIndex = 15;
            ObjectNameRadioBtn.TabStop = true;
            ObjectNameRadioBtn.Text = "Наименование объекта";
            ObjectNameRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ObjectNameTextBox
            // 
            ObjectNameTextBox.Location = new Point(12, 413);
            ObjectNameTextBox.Name = "ObjectNameTextBox";
            ObjectNameTextBox.Size = new Size(242, 27);
            ObjectNameTextBox.TabIndex = 16;
            // 
            // ProdDateLbl
            // 
            ProdDateLbl.AutoSize = true;
            ProdDateLbl.Location = new Point(12, 496);
            ProdDateLbl.Name = "ProdDateLbl";
            ProdDateLbl.Size = new Size(142, 20);
            ProdDateLbl.TabIndex = 17;
            ProdDateLbl.Text = "Дата производства";
            // 
            // ProdDateTextBox
            // 
            ProdDateTextBox.Location = new Point(12, 519);
            ProdDateTextBox.Name = "ProdDateTextBox";
            ProdDateTextBox.Size = new Size(242, 27);
            ProdDateTextBox.TabIndex = 18;
            // 
            // PNRLbl
            // 
            PNRLbl.AutoSize = true;
            PNRLbl.Location = new Point(12, 549);
            PNRLbl.Name = "PNRLbl";
            PNRLbl.Size = new Size(37, 20);
            PNRLbl.TabIndex = 19;
            PNRLbl.Text = "PNR";
            // 
            // PNRTextBox
            // 
            PNRTextBox.Location = new Point(12, 572);
            PNRTextBox.Name = "PNRTextBox";
            PNRTextBox.Size = new Size(242, 27);
            PNRTextBox.TabIndex = 20;
            // 
            // SoftVersionLbl
            // 
            SoftVersionLbl.AutoSize = true;
            SoftVersionLbl.Location = new Point(10, 602);
            SoftVersionLbl.Name = "SoftVersionLbl";
            SoftVersionLbl.Size = new Size(85, 20);
            SoftVersionLbl.TabIndex = 21;
            SoftVersionLbl.Text = "Версия ПО";
            // 
            // SoftVersionTextBox
            // 
            SoftVersionTextBox.Location = new Point(12, 625);
            SoftVersionTextBox.Name = "SoftVersionTextBox";
            SoftVersionTextBox.Size = new Size(242, 27);
            SoftVersionTextBox.TabIndex = 22;
            // 
            // HardVersionLbl
            // 
            HardVersionLbl.AutoSize = true;
            HardVersionLbl.Location = new Point(12, 655);
            HardVersionLbl.Name = "HardVersionLbl";
            HardVersionLbl.Size = new Size(84, 20);
            HardVersionLbl.TabIndex = 23;
            HardVersionLbl.Text = "Версия АО";
            // 
            // HardVersionTextBox
            // 
            HardVersionTextBox.Location = new Point(12, 678);
            HardVersionTextBox.Name = "HardVersionTextBox";
            HardVersionTextBox.Size = new Size(242, 27);
            HardVersionTextBox.TabIndex = 24;
            // 
            // SNumberIEMLbl
            // 
            SNumberIEMLbl.AutoSize = true;
            SNumberIEMLbl.Location = new Point(12, 708);
            SNumberIEMLbl.Name = "SNumberIEMLbl";
            SNumberIEMLbl.Size = new Size(167, 20);
            SNumberIEMLbl.TabIndex = 25;
            SNumberIEMLbl.Text = "Серийный номер ВЭМ";
            // 
            // SNumberIEMTextBox
            // 
            SNumberIEMTextBox.Location = new Point(10, 731);
            SNumberIEMTextBox.Name = "SNumberIEMTextBox";
            SNumberIEMTextBox.Size = new Size(242, 27);
            SNumberIEMTextBox.TabIndex = 26;
            // 
            // NotesLbl
            // 
            NotesLbl.AutoSize = true;
            NotesLbl.Location = new Point(260, 752);
            NotesLbl.Name = "NotesLbl";
            NotesLbl.Size = new Size(226, 20);
            NotesLbl.TabIndex = 27;
            NotesLbl.Text = "Особые отметки (примечания)";
            // 
            // AddDataBtn
            // 
            AddDataBtn.Location = new Point(10, 764);
            AddDataBtn.Name = "AddDataBtn";
            AddDataBtn.Size = new Size(244, 37);
            AddDataBtn.TabIndex = 29;
            AddDataBtn.Text = "Добавить в базу";
            AddDataBtn.UseVisualStyleBackColor = true;
            AddDataBtn.Click += AddDataBtn_Click;
            // 
            // Notes
            // 
            Notes.Location = new Point(260, 775);
            Notes.Name = "Notes";
            Notes.Size = new Size(1129, 93);
            Notes.TabIndex = 30;
            Notes.Text = "";
            // 
            // DataGridView
            // 
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(260, 5);
            DataGridView.Name = "DataGridView";
            DataGridView.ReadOnly = true;
            DataGridView.RowHeadersWidth = 51;
            DataGridView.Size = new Size(1049, 744);
            DataGridView.TabIndex = 31;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(12, 807);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(240, 33);
            UpdateBtn.TabIndex = 32;
            UpdateBtn.Text = "Обновить данные";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(10, 846);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(240, 33);
            DeleteBtn.TabIndex = 33;
            DeleteBtn.Text = "Удалить строку";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 880);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(DataGridView);
            Controls.Add(Notes);
            Controls.Add(AddDataBtn);
            Controls.Add(NotesLbl);
            Controls.Add(SNumberIEMTextBox);
            Controls.Add(SNumberIEMLbl);
            Controls.Add(HardVersionTextBox);
            Controls.Add(HardVersionLbl);
            Controls.Add(SoftVersionTextBox);
            Controls.Add(SoftVersionLbl);
            Controls.Add(PNRTextBox);
            Controls.Add(PNRLbl);
            Controls.Add(ProdDateTextBox);
            Controls.Add(ProdDateLbl);
            Controls.Add(ObjectNameTextBox);
            Controls.Add(ObjectNameRadioBtn);
            Controls.Add(ObjectNameLbl);
            Controls.Add(SerialNumberTextBox);
            Controls.Add(SerialNumberLbl);
            Controls.Add(SNumIEMRadioBtn);
            Controls.Add(HardVersionRadioBtn);
            Controls.Add(SoftVersionRadioBtn);
            Controls.Add(PNRRadioBtn);
            Controls.Add(ProdDateRadioBtn);
            Controls.Add(SNumberCmpRadioBtn);
            Controls.Add(SortBtn);
            Controls.Add(FindBtn);
            Controls.Add(SNumberLBL);
            Controls.Add(InputSNumber);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "ComponentsDB";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox InputSNumber;
        private Label SNumberLBL;
        private Button FindBtn;
        private Button SortBtn;
        private RadioButton ObjectNameRadioBtn;
        private RadioButton SNumberCmpRadioBtn;
        private RadioButton ProdDateRadioBtn;
        private RadioButton PNRRadioBtn;
        private RadioButton SoftVersionRadioBtn;
        private RadioButton HardVersionRadioBtn;
        private RadioButton SNumIEMRadioBtn;
        private Label SerialNumberLbl;
        private TextBox SerialNumberTextBox;
        private Label ObjectNameLbl;
        private TextBox ObjectNameTextBox;
        private Label ProdDateLbl;
        private TextBox ProdDateTextBox;
        private Label PNRLbl;
        private TextBox PNRTextBox;
        private Label SoftVersionLbl;
        private TextBox SoftVersionTextBox;
        private Label HardVersionLbl;
        private TextBox HardVersionTextBox;
        private Label SNumberIEMLbl;
        private TextBox SNumberIEMTextBox;
        private Label NotesLbl;
        private Button AddDataBtn;
        private RichTextBox Notes;
        private DataGridView DataGridView;
        private Button UpdateBtn;
        private Button DeleteBtn;
    }
}
