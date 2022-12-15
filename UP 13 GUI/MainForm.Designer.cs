namespace UP_13_GUI
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.NValueBox = new System.Windows.Forms.TextBox();
            this.EdidtionComboBox = new System.Windows.Forms.ComboBox();
            this.CreateListButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BookGroupBox = new System.Windows.Forms.GroupBox();
            this.BookEditionBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BookYearBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BookAuthorBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BookNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ArticleGroupBox = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MagazineNumberBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MagazineNameBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ArticleNameBox = new System.Windows.Forms.TextBox();
            this.ArticleYearBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ArticleAuthorBox = new System.Windows.Forms.TextBox();
            this.EResourceGroupBox = new System.Windows.Forms.GroupBox();
            this.ERAnnotationBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ERUrlBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ERNameBox = new System.Windows.Forms.TextBox();
            this.ERAuthorBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.AddEditionButton = new System.Windows.Forms.Button();
            this.InfoBox = new System.Windows.Forms.RichTextBox();
            this.PrintListButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.AuthorBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SearchByAuthorButton = new System.Windows.Forms.Button();
            this.BookGroupBox.SuspendLayout();
            this.ArticleGroupBox.SuspendLayout();
            this.EResourceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите количество элементов каталога";
            // 
            // NValueBox
            // 
            this.NValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.NValueBox.Location = new System.Drawing.Point(301, 6);
            this.NValueBox.Margin = new System.Windows.Forms.Padding(4);
            this.NValueBox.Name = "NValueBox";
            this.NValueBox.Size = new System.Drawing.Size(181, 23);
            this.NValueBox.TabIndex = 1;
            // 
            // EdidtionComboBox
            // 
            this.EdidtionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EdidtionComboBox.Enabled = false;
            this.EdidtionComboBox.FormattingEnabled = true;
            this.EdidtionComboBox.Items.AddRange(new object[] {
            "Книга",
            "Статья",
            "Электронный ресурс"});
            this.EdidtionComboBox.Location = new System.Drawing.Point(153, 36);
            this.EdidtionComboBox.Name = "EdidtionComboBox";
            this.EdidtionComboBox.Size = new System.Drawing.Size(236, 25);
            this.EdidtionComboBox.TabIndex = 2;
            // 
            // CreateListButton
            // 
            this.CreateListButton.Location = new System.Drawing.Point(489, 6);
            this.CreateListButton.Name = "CreateListButton";
            this.CreateListButton.Size = new System.Drawing.Size(154, 24);
            this.CreateListButton.TabIndex = 3;
            this.CreateListButton.Text = "Создать каталог";
            this.CreateListButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выберите издание";
            // 
            // BookGroupBox
            // 
            this.BookGroupBox.Controls.Add(this.BookEditionBox);
            this.BookGroupBox.Controls.Add(this.label6);
            this.BookGroupBox.Controls.Add(this.BookYearBox);
            this.BookGroupBox.Controls.Add(this.label5);
            this.BookGroupBox.Controls.Add(this.BookAuthorBox);
            this.BookGroupBox.Controls.Add(this.label4);
            this.BookGroupBox.Controls.Add(this.BookNameBox);
            this.BookGroupBox.Controls.Add(this.label3);
            this.BookGroupBox.Enabled = false;
            this.BookGroupBox.Location = new System.Drawing.Point(16, 67);
            this.BookGroupBox.Name = "BookGroupBox";
            this.BookGroupBox.Size = new System.Drawing.Size(258, 173);
            this.BookGroupBox.TabIndex = 5;
            this.BookGroupBox.TabStop = false;
            this.BookGroupBox.Text = "Книга";
            // 
            // BookEditionBox
            // 
            this.BookEditionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BookEditionBox.Location = new System.Drawing.Point(106, 109);
            this.BookEditionBox.Margin = new System.Windows.Forms.Padding(4);
            this.BookEditionBox.Name = "BookEditionBox";
            this.BookEditionBox.Size = new System.Drawing.Size(145, 23);
            this.BookEditionBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(7, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Издательство";
            // 
            // BookYearBox
            // 
            this.BookYearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BookYearBox.Location = new System.Drawing.Point(106, 78);
            this.BookYearBox.Margin = new System.Windows.Forms.Padding(4);
            this.BookYearBox.Name = "BookYearBox";
            this.BookYearBox.Size = new System.Drawing.Size(145, 23);
            this.BookYearBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(7, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Год издания";
            // 
            // BookAuthorBox
            // 
            this.BookAuthorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BookAuthorBox.Location = new System.Drawing.Point(78, 47);
            this.BookAuthorBox.Margin = new System.Windows.Forms.Padding(4);
            this.BookAuthorBox.Name = "BookAuthorBox";
            this.BookAuthorBox.Size = new System.Drawing.Size(173, 23);
            this.BookAuthorBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(7, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Автор";
            // 
            // BookNameBox
            // 
            this.BookNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BookNameBox.Location = new System.Drawing.Point(78, 16);
            this.BookNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.BookNameBox.Name = "BookNameBox";
            this.BookNameBox.Size = new System.Drawing.Size(173, 23);
            this.BookNameBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(7, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Название";
            // 
            // ArticleGroupBox
            // 
            this.ArticleGroupBox.Controls.Add(this.label11);
            this.ArticleGroupBox.Controls.Add(this.MagazineNumberBox);
            this.ArticleGroupBox.Controls.Add(this.label10);
            this.ArticleGroupBox.Controls.Add(this.MagazineNameBox);
            this.ArticleGroupBox.Controls.Add(this.label7);
            this.ArticleGroupBox.Controls.Add(this.ArticleNameBox);
            this.ArticleGroupBox.Controls.Add(this.ArticleYearBox);
            this.ArticleGroupBox.Controls.Add(this.label8);
            this.ArticleGroupBox.Controls.Add(this.label9);
            this.ArticleGroupBox.Controls.Add(this.ArticleAuthorBox);
            this.ArticleGroupBox.Location = new System.Drawing.Point(301, 67);
            this.ArticleGroupBox.Name = "ArticleGroupBox";
            this.ArticleGroupBox.Size = new System.Drawing.Size(258, 173);
            this.ArticleGroupBox.TabIndex = 6;
            this.ArticleGroupBox.TabStop = false;
            this.ArticleGroupBox.Text = "Статья";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label11.Location = new System.Drawing.Point(7, 109);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Номер журнала";
            // 
            // MagazineNumberBox
            // 
            this.MagazineNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.MagazineNumberBox.Location = new System.Drawing.Point(147, 106);
            this.MagazineNumberBox.Margin = new System.Windows.Forms.Padding(4);
            this.MagazineNumberBox.Name = "MagazineNumberBox";
            this.MagazineNumberBox.Size = new System.Drawing.Size(104, 23);
            this.MagazineNumberBox.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label10.Location = new System.Drawing.Point(7, 81);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Название журнала";
            // 
            // MagazineNameBox
            // 
            this.MagazineNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.MagazineNameBox.Location = new System.Drawing.Point(147, 78);
            this.MagazineNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.MagazineNameBox.Name = "MagazineNameBox";
            this.MagazineNameBox.Size = new System.Drawing.Size(104, 23);
            this.MagazineNameBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(7, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Название";
            // 
            // ArticleNameBox
            // 
            this.ArticleNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ArticleNameBox.Location = new System.Drawing.Point(87, 19);
            this.ArticleNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.ArticleNameBox.Name = "ArticleNameBox";
            this.ArticleNameBox.Size = new System.Drawing.Size(164, 23);
            this.ArticleNameBox.TabIndex = 9;
            // 
            // ArticleYearBox
            // 
            this.ArticleYearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ArticleYearBox.Location = new System.Drawing.Point(106, 134);
            this.ArticleYearBox.Margin = new System.Windows.Forms.Padding(4);
            this.ArticleYearBox.Name = "ArticleYearBox";
            this.ArticleYearBox.Size = new System.Drawing.Size(145, 23);
            this.ArticleYearBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(7, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Автор";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(7, 137);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Год издания";
            // 
            // ArticleAuthorBox
            // 
            this.ArticleAuthorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ArticleAuthorBox.Location = new System.Drawing.Point(87, 47);
            this.ArticleAuthorBox.Margin = new System.Windows.Forms.Padding(4);
            this.ArticleAuthorBox.Name = "ArticleAuthorBox";
            this.ArticleAuthorBox.Size = new System.Drawing.Size(164, 23);
            this.ArticleAuthorBox.TabIndex = 11;
            // 
            // EResourceGroupBox
            // 
            this.EResourceGroupBox.Controls.Add(this.ERAnnotationBox);
            this.EResourceGroupBox.Controls.Add(this.label15);
            this.EResourceGroupBox.Controls.Add(this.ERUrlBox);
            this.EResourceGroupBox.Controls.Add(this.label14);
            this.EResourceGroupBox.Controls.Add(this.label12);
            this.EResourceGroupBox.Controls.Add(this.ERNameBox);
            this.EResourceGroupBox.Controls.Add(this.ERAuthorBox);
            this.EResourceGroupBox.Controls.Add(this.label13);
            this.EResourceGroupBox.Location = new System.Drawing.Point(581, 67);
            this.EResourceGroupBox.Name = "EResourceGroupBox";
            this.EResourceGroupBox.Size = new System.Drawing.Size(258, 173);
            this.EResourceGroupBox.TabIndex = 6;
            this.EResourceGroupBox.TabStop = false;
            this.EResourceGroupBox.Text = "Электронный ресурс";
            // 
            // ERAnnotationBox
            // 
            this.ERAnnotationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ERAnnotationBox.Location = new System.Drawing.Point(87, 103);
            this.ERAnnotationBox.Margin = new System.Windows.Forms.Padding(4);
            this.ERAnnotationBox.Name = "ERAnnotationBox";
            this.ERAnnotationBox.Size = new System.Drawing.Size(164, 23);
            this.ERAnnotationBox.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label15.Location = new System.Drawing.Point(7, 106);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 17);
            this.label15.TabIndex = 24;
            this.label15.Text = "Аннотация";
            // 
            // ERUrlBox
            // 
            this.ERUrlBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ERUrlBox.Location = new System.Drawing.Point(87, 75);
            this.ERUrlBox.Margin = new System.Windows.Forms.Padding(4);
            this.ERUrlBox.Name = "ERUrlBox";
            this.ERUrlBox.Size = new System.Drawing.Size(164, 23);
            this.ERUrlBox.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label14.Location = new System.Drawing.Point(7, 78);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 17);
            this.label14.TabIndex = 22;
            this.label14.Text = "Ссылка";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label12.Location = new System.Drawing.Point(7, 25);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "Название";
            // 
            // ERNameBox
            // 
            this.ERNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ERNameBox.Location = new System.Drawing.Point(87, 22);
            this.ERNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.ERNameBox.Name = "ERNameBox";
            this.ERNameBox.Size = new System.Drawing.Size(164, 23);
            this.ERNameBox.TabIndex = 19;
            // 
            // ERAuthorBox
            // 
            this.ERAuthorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ERAuthorBox.Location = new System.Drawing.Point(87, 50);
            this.ERAuthorBox.Margin = new System.Windows.Forms.Padding(4);
            this.ERAuthorBox.Name = "ERAuthorBox";
            this.ERAuthorBox.Size = new System.Drawing.Size(164, 23);
            this.ERAuthorBox.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label13.Location = new System.Drawing.Point(7, 53);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "Автор";
            // 
            // AddEditionButton
            // 
            this.AddEditionButton.Enabled = false;
            this.AddEditionButton.Location = new System.Drawing.Point(395, 36);
            this.AddEditionButton.Name = "AddEditionButton";
            this.AddEditionButton.Size = new System.Drawing.Size(248, 25);
            this.AddEditionButton.TabIndex = 7;
            this.AddEditionButton.Text = "Добавить издание в каталог";
            this.AddEditionButton.UseVisualStyleBackColor = true;
            // 
            // InfoBox
            // 
            this.InfoBox.Location = new System.Drawing.Point(407, 246);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.ReadOnly = true;
            this.InfoBox.Size = new System.Drawing.Size(432, 217);
            this.InfoBox.TabIndex = 8;
            this.InfoBox.Text = "";
            // 
            // PrintListButton
            // 
            this.PrintListButton.Enabled = false;
            this.PrintListButton.Location = new System.Drawing.Point(18, 246);
            this.PrintListButton.Name = "PrintListButton";
            this.PrintListButton.Size = new System.Drawing.Size(383, 25);
            this.PrintListButton.TabIndex = 9;
            this.PrintListButton.Text = "Полная информация по изданиям в каталоге";
            this.PrintListButton.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label16.Location = new System.Drawing.Point(177, 276);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 17);
            this.label16.TabIndex = 10;
            this.label16.Text = "ИЛИ";
            // 
            // AuthorBox
            // 
            this.AuthorBox.Enabled = false;
            this.AuthorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.AuthorBox.Location = new System.Drawing.Point(202, 297);
            this.AuthorBox.Margin = new System.Windows.Forms.Padding(4);
            this.AuthorBox.Name = "AuthorBox";
            this.AuthorBox.Size = new System.Drawing.Size(199, 23);
            this.AuthorBox.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label17.Location = new System.Drawing.Point(15, 301);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(179, 17);
            this.label17.TabIndex = 11;
            this.label17.Text = "Введите фамилию автора";
            // 
            // SearchByAuthorButton
            // 
            this.SearchByAuthorButton.Enabled = false;
            this.SearchByAuthorButton.Location = new System.Drawing.Point(18, 330);
            this.SearchByAuthorButton.Name = "SearchByAuthorButton";
            this.SearchByAuthorButton.Size = new System.Drawing.Size(383, 25);
            this.SearchByAuthorButton.TabIndex = 13;
            this.SearchByAuthorButton.Text = "Издания по автору";
            this.SearchByAuthorButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 475);
            this.Controls.Add(this.SearchByAuthorButton);
            this.Controls.Add(this.AuthorBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.PrintListButton);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.AddEditionButton);
            this.Controls.Add(this.EResourceGroupBox);
            this.Controls.Add(this.ArticleGroupBox);
            this.Controls.Add(this.BookGroupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CreateListButton);
            this.Controls.Add(this.EdidtionComboBox);
            this.Controls.Add(this.NValueBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.BookGroupBox.ResumeLayout(false);
            this.BookGroupBox.PerformLayout();
            this.ArticleGroupBox.ResumeLayout(false);
            this.ArticleGroupBox.PerformLayout();
            this.EResourceGroupBox.ResumeLayout(false);
            this.EResourceGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NValueBox;
        private System.Windows.Forms.ComboBox EdidtionComboBox;
        private System.Windows.Forms.Button CreateListButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox BookGroupBox;
        private System.Windows.Forms.TextBox BookEditionBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BookYearBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BookAuthorBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BookNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox ArticleGroupBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MagazineNameBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ArticleNameBox;
        private System.Windows.Forms.TextBox ArticleYearBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ArticleAuthorBox;
        private System.Windows.Forms.GroupBox EResourceGroupBox;
        private System.Windows.Forms.Button AddEditionButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox MagazineNumberBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ERNameBox;
        private System.Windows.Forms.TextBox ERAuthorBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ERAnnotationBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ERUrlBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox InfoBox;
        private System.Windows.Forms.Button PrintListButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox AuthorBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button SearchByAuthorButton;
    }
}

