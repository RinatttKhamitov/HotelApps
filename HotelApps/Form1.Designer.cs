namespace HotelApps
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label = new System.Windows.Forms.Label();
            this.radioBtnRserved = new System.Windows.Forms.RadioButton();
            this.radioBtnFree = new System.Windows.Forms.RadioButton();
            this.radioBtnBusy = new System.Windows.Forms.RadioButton();
            this.radioBtnDischarged = new System.Windows.Forms.RadioButton();
            this.radioBtnAll = new System.Windows.Forms.RadioButton();
            this.groupBoxNumber = new System.Windows.Forms.GroupBox();
            this.lableId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelFIO = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelDateArrival = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelDateDeparture = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumberRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdResident = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBoxNumber.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxNumber, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewRooms, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(915, 367);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.radioBtnRserved, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.radioBtnFree, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.radioBtnBusy, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.radioBtnDischarged, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.radioBtnAll, 0, 5);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.37615F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.62385F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(296, 284);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label
            // 
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.Font = new System.Drawing.Font("Arial", 20F);
            this.label.Location = new System.Drawing.Point(3, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(290, 56);
            this.label.TabIndex = 4;
            this.label.Text = "Статус";
            // 
            // radioBtnRserved
            // 
            this.radioBtnRserved.AutoSize = true;
            this.radioBtnRserved.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtnRserved.Location = new System.Drawing.Point(3, 59);
            this.radioBtnRserved.Name = "radioBtnRserved";
            this.radioBtnRserved.Size = new System.Drawing.Size(146, 21);
            this.radioBtnRserved.TabIndex = 0;
            this.radioBtnRserved.Text = "Зарезервировано";
            this.radioBtnRserved.UseVisualStyleBackColor = true;
            this.radioBtnRserved.CheckedChanged += new System.EventHandler(this.radioBtnRserved_CheckedChanged);
            // 
            // radioBtnFree
            // 
            this.radioBtnFree.AutoSize = true;
            this.radioBtnFree.Font = new System.Drawing.Font("Arial", 11.25F);
            this.radioBtnFree.Location = new System.Drawing.Point(3, 112);
            this.radioBtnFree.Name = "radioBtnFree";
            this.radioBtnFree.Size = new System.Drawing.Size(106, 21);
            this.radioBtnFree.TabIndex = 1;
            this.radioBtnFree.Text = "Свободные";
            this.radioBtnFree.UseVisualStyleBackColor = true;
            this.radioBtnFree.CheckedChanged += new System.EventHandler(this.radioBtnFree_CheckedChanged);
            // 
            // radioBtnBusy
            // 
            this.radioBtnBusy.AutoSize = true;
            this.radioBtnBusy.Font = new System.Drawing.Font("Arial", 11.25F);
            this.radioBtnBusy.Location = new System.Drawing.Point(3, 158);
            this.radioBtnBusy.Name = "radioBtnBusy";
            this.radioBtnBusy.Size = new System.Drawing.Size(77, 21);
            this.radioBtnBusy.TabIndex = 2;
            this.radioBtnBusy.Text = "Заняты";
            this.radioBtnBusy.UseVisualStyleBackColor = true;
            this.radioBtnBusy.CheckedChanged += new System.EventHandler(this.radioBtnBusy_CheckedChanged);
            // 
            // radioBtnDischarged
            // 
            this.radioBtnDischarged.AutoSize = true;
            this.radioBtnDischarged.Font = new System.Drawing.Font("Arial", 11.25F);
            this.radioBtnDischarged.Location = new System.Drawing.Point(3, 203);
            this.radioBtnDischarged.Name = "radioBtnDischarged";
            this.radioBtnDischarged.Size = new System.Drawing.Size(132, 21);
            this.radioBtnDischarged.TabIndex = 3;
            this.radioBtnDischarged.Text = "Выписываются";
            this.radioBtnDischarged.UseVisualStyleBackColor = true;
            this.radioBtnDischarged.CheckedChanged += new System.EventHandler(this.radioBtnDischarged_CheckedChanged);
            // 
            // radioBtnAll
            // 
            this.radioBtnAll.AutoSize = true;
            this.radioBtnAll.Font = new System.Drawing.Font("Arial", 11.25F);
            this.radioBtnAll.Location = new System.Drawing.Point(3, 246);
            this.radioBtnAll.Name = "radioBtnAll";
            this.radioBtnAll.Size = new System.Drawing.Size(52, 21);
            this.radioBtnAll.TabIndex = 5;
            this.radioBtnAll.Text = "Все";
            this.radioBtnAll.UseVisualStyleBackColor = true;
            this.radioBtnAll.CheckedChanged += new System.EventHandler(this.radioBtnAll_CheckedChanged);
            // 
            // groupBoxNumber
            // 
            this.groupBoxNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxNumber.Controls.Add(this.lableId);
            this.groupBoxNumber.Controls.Add(this.panel1);
            this.groupBoxNumber.Controls.Add(this.pictureBox1);
            this.groupBoxNumber.Location = new System.Drawing.Point(613, 5);
            this.groupBoxNumber.Name = "groupBoxNumber";
            this.groupBoxNumber.Size = new System.Drawing.Size(297, 357);
            this.groupBoxNumber.TabIndex = 2;
            this.groupBoxNumber.TabStop = false;
            this.groupBoxNumber.Text = "Номер: ";
            // 
            // lableId
            // 
            this.lableId.AutoSize = true;
            this.lableId.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lableId.Location = new System.Drawing.Point(113, 20);
            this.lableId.Name = "lableId";
            this.lableId.Size = new System.Drawing.Size(19, 17);
            this.lableId.TabIndex = 2;
            this.lableId.Text = "Id";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(0, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 265);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F);
            this.button1.Location = new System.Drawing.Point(77, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "Просмотр карточки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label4.Location = new System.Drawing.Point(3, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Дата выезда";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label3.Location = new System.Drawing.Point(3, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата заезда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Статус";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            this.label1.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelFIO);
            this.panel2.Location = new System.Drawing.Point(6, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 25);
            this.panel2.TabIndex = 0;
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Font = new System.Drawing.Font("Arial", 11.25F);
            this.labelFIO.Location = new System.Drawing.Point(42, 7);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(0, 17);
            this.labelFIO.TabIndex = 0;
            this.labelFIO.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.labelStatus);
            this.panel3.Location = new System.Drawing.Point(6, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 25);
            this.panel3.TabIndex = 5;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Arial", 11.25F);
            this.labelStatus.Location = new System.Drawing.Point(52, 4);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 17);
            this.labelStatus.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.labelDateArrival);
            this.panel4.Location = new System.Drawing.Point(6, 85);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(282, 25);
            this.panel4.TabIndex = 6;
            // 
            // labelDateArrival
            // 
            this.labelDateArrival.AutoSize = true;
            this.labelDateArrival.Font = new System.Drawing.Font("Arial", 11.25F);
            this.labelDateArrival.Location = new System.Drawing.Point(88, 6);
            this.labelDateArrival.Name = "labelDateArrival";
            this.labelDateArrival.Size = new System.Drawing.Size(0, 17);
            this.labelDateArrival.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.labelDateDeparture);
            this.panel5.Location = new System.Drawing.Point(6, 120);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(282, 25);
            this.panel5.TabIndex = 7;
            // 
            // labelDateDeparture
            // 
            this.labelDateDeparture.AutoSize = true;
            this.labelDateDeparture.Font = new System.Drawing.Font("Arial", 11.25F);
            this.labelDateDeparture.Location = new System.Drawing.Point(88, 6);
            this.labelDateDeparture.Name = "labelDateDeparture";
            this.labelDateDeparture.Size = new System.Drawing.Size(0, 17);
            this.labelDateDeparture.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelApps.Properties.Resources.no_avatar;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNumberRoom,
            this.ColumnStatus,
            this.ColumnIdResident});
            this.dataGridViewRooms.Location = new System.Drawing.Point(309, 5);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.ReadOnly = true;
            this.dataGridViewRooms.Size = new System.Drawing.Size(296, 357);
            this.dataGridViewRooms.TabIndex = 3;
            this.dataGridViewRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRooms_CellClick);
            // 
            // ColumnID
            // 
            this.ColumnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnID.HeaderText = "IdRoom";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnNumberRoom
            // 
            this.ColumnNumberRoom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNumberRoom.HeaderText = "numberRoom";
            this.ColumnNumberRoom.Name = "ColumnNumberRoom";
            this.ColumnNumberRoom.ReadOnly = true;
            this.ColumnNumberRoom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnStatus.HeaderText = "status";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            this.ColumnStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnIdResident
            // 
            this.ColumnIdResident.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnIdResident.HeaderText = "IdResident";
            this.ColumnIdResident.Name = "ColumnIdResident";
            this.ColumnIdResident.ReadOnly = true;
            this.ColumnIdResident.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.16564F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.83436F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TimeLbl, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(915, 68);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.41731F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.582689F));
            this.tableLayoutPanel3.Controls.Add(this.textBoxSearch, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button3, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(200, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(709, 56);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxSearch.Location = new System.Drawing.Point(3, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(635, 30);
            this.textBoxSearch.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button3.Location = new System.Drawing.Point(644, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 49);
            this.button3.TabIndex = 1;
            this.button3.Text = "🔍";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TimeLbl
            // 
            this.TimeLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLbl.Location = new System.Drawing.Point(60, 15);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(76, 37);
            this.TimeLbl.TabIndex = 0;
            this.TimeLbl.Tag = "";
            this.TimeLbl.Text = "0:0:0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 436);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBoxNumber.ResumeLayout(false);
            this.groupBoxNumber.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RadioButton radioBtnDischarged;
        private System.Windows.Forms.RadioButton radioBtnBusy;
        private System.Windows.Forms.RadioButton radioBtnFree;
        private System.Windows.Forms.RadioButton radioBtnRserved;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox groupBoxNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumberRoom;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdResident;
        private System.Windows.Forms.RadioButton radioBtnAll;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelDateArrival;
        private System.Windows.Forms.Label labelDateDeparture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lableId;
    }
}

