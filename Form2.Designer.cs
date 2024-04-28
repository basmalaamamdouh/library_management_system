namespace file_project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            open = new Button();
            search = new Button();
            add = new Button();
            delete = new Button();
            bookid = new TextBox();
            bookname = new TextBox();
            author = new TextBox();
            price = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // open
            // 
            open.BackgroundImage = (Image)resources.GetObject("open.BackgroundImage");
            open.Font = new Font("Verdana", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            open.Location = new Point(76, 58);
            open.Name = "open";
            open.Size = new Size(332, 239);
            open.TabIndex = 0;
            open.UseVisualStyleBackColor = true;
            open.Click += open_Click;
            // 
            // search
            // 
            search.BackgroundImage = (Image)resources.GetObject("search.BackgroundImage");
            search.Location = new Point(1288, 129);
            search.Name = "search";
            search.Size = new Size(235, 238);
            search.TabIndex = 1;
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // add
            // 
            add.BackColor = SystemColors.ButtonFace;
            add.BackgroundImage = (Image)resources.GetObject("add.BackgroundImage");
            add.Location = new Point(1130, 300);
            add.Name = "add";
            add.Size = new Size(237, 241);
            add.TabIndex = 2;
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // delete
            // 
            delete.BackgroundImage = (Image)resources.GetObject("delete.BackgroundImage");
            delete.Location = new Point(1288, 472);
            delete.Name = "delete";
            delete.Size = new Size(235, 236);
            delete.TabIndex = 3;
            delete.UseVisualStyleBackColor = true;
            delete.Click += button4_Click;
            // 
            // bookid
            // 
            bookid.BackColor = Color.PapayaWhip;
            bookid.Location = new Point(552, 407);
            bookid.Name = "bookid";
            bookid.Size = new Size(414, 27);
            bookid.TabIndex = 15;
            bookid.TextChanged += bookid_TextChanged;
            // 
            // bookname
            // 
            bookname.BackColor = Color.PapayaWhip;
            bookname.Location = new Point(552, 543);
            bookname.Name = "bookname";
            bookname.Size = new Size(414, 27);
            bookname.TabIndex = 16;
            bookname.TextChanged += bookname_TextChanged;
            // 
            // author
            // 
            author.BackColor = Color.PapayaWhip;
            author.Location = new Point(552, 671);
            author.Name = "author";
            author.Size = new Size(414, 27);
            author.TabIndex = 17;
            author.TextChanged += author_TextChanged;
            // 
            // price
            // 
            price.BackColor = Color.PapayaWhip;
            price.Location = new Point(552, 798);
            price.Name = "price";
            price.Size = new Size(414, 27);
            price.TabIndex = 18;
            price.TextChanged += price_TextChanged;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Location = new Point(1175, 671);
            button1.Name = "button1";
            button1.Size = new Size(245, 235);
            button1.TabIndex = 19;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1579, 1055);
            Controls.Add(button1);
            Controls.Add(price);
            Controls.Add(author);
            Controls.Add(bookname);
            Controls.Add(bookid);
            Controls.Add(delete);
            Controls.Add(add);
            Controls.Add(search);
            Controls.Add(open);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button open;
        private Button search;
        private Button add;
        private Button delete;
        private TextBox bookid;
        private TextBox bookname;
        private TextBox author;
        private TextBox price;
        private Button button1;
    }
}