namespace BinaryTree
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.slbl1 = new System.Windows.Forms.Label();
            this.slbl2 = new System.Windows.Forms.Label();
            this.slbl3 = new System.Windows.Forms.Label();
            this.slbl4 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.lblSearchInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbox1
            // 
            this.txtbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox1.Location = new System.Drawing.Point(344, 12);
            this.txtbox1.Multiline = true;
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(336, 42);
            this.txtbox1.TabIndex = 0;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(686, 12);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(175, 42);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Generate";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBox2
            // 
            this.txtBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox2.Location = new System.Drawing.Point(269, 62);
            this.txtBox2.Multiline = true;
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(230, 42);
            this.txtBox2.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(505, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(175, 42);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(693, 70);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(147, 25);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search Result";
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(17, 152);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(298, 264);
            this.listBox1.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.AllowDrop = true;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(335, 152);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(298, 264);
            this.listBox2.TabIndex = 8;
            // 
            // slbl1
            // 
            this.slbl1.AutoSize = true;
            this.slbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slbl1.Location = new System.Drawing.Point(12, 21);
            this.slbl1.Name = "slbl1";
            this.slbl1.Size = new System.Drawing.Size(325, 25);
            this.slbl1.TabIndex = 9;
            this.slbl1.Text = "ENTER NUMBER OF VERTICES";
            // 
            // slbl2
            // 
            this.slbl2.AutoSize = true;
            this.slbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slbl2.Location = new System.Drawing.Point(27, 125);
            this.slbl2.Name = "slbl2";
            this.slbl2.Size = new System.Drawing.Size(279, 16);
            this.slbl2.TabIndex = 10;
            this.slbl2.Text = "LIST OF NUMBER ADDED IN BINARY TREE";
            // 
            // slbl3
            // 
            this.slbl3.AutoSize = true;
            this.slbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slbl3.Location = new System.Drawing.Point(360, 125);
            this.slbl3.Name = "slbl3";
            this.slbl3.Size = new System.Drawing.Size(247, 16);
            this.slbl3.TabIndex = 11;
            this.slbl3.Text = "LIST OF NUMBER IN SORTED ORDER";
            // 
            // slbl4
            // 
            this.slbl4.AutoSize = true;
            this.slbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slbl4.Location = new System.Drawing.Point(662, 125);
            this.slbl4.Name = "slbl4";
            this.slbl4.Size = new System.Drawing.Size(188, 16);
            this.slbl4.TabIndex = 12;
            this.slbl4.Text = "SEARCH PATH FROM ROOT";
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(651, 152);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(199, 264);
            this.listBox3.TabIndex = 13;
            // 
            // lblSearchInfo
            // 
            this.lblSearchInfo.AutoSize = true;
            this.lblSearchInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchInfo.Location = new System.Drawing.Point(12, 68);
            this.lblSearchInfo.Name = "lblSearchInfo";
            this.lblSearchInfo.Size = new System.Drawing.Size(251, 25);
            this.lblSearchInfo.TabIndex = 14;
            this.lblSearchInfo.Text = "ENTER SEARCH VALUE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 428);
            this.Controls.Add(this.lblSearchInfo);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.slbl4);
            this.Controls.Add(this.slbl3);
            this.Controls.Add(this.slbl2);
            this.Controls.Add(this.slbl1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtbox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Binary Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label slbl1;
        private System.Windows.Forms.Label slbl2;
        private System.Windows.Forms.Label slbl3;
        private System.Windows.Forms.Label slbl4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label lblSearchInfo;
    }
}

