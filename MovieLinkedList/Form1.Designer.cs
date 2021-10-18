namespace MovieLinkedList
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
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnViewMovies = new System.Windows.Forms.Button();
            this.txbOutput = new System.Windows.Forms.TextBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbYear = new System.Windows.Forms.TextBox();
            this.txbIMDB = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(242, 53);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(75, 23);
            this.btnAddMovie.TabIndex = 0;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnViewMovies
            // 
            this.btnViewMovies.Location = new System.Drawing.Point(38, 159);
            this.btnViewMovies.Name = "btnViewMovies";
            this.btnViewMovies.Size = new System.Drawing.Size(75, 23);
            this.btnViewMovies.TabIndex = 2;
            this.btnViewMovies.Text = "View Movies";
            this.btnViewMovies.UseVisualStyleBackColor = true;
            this.btnViewMovies.Click += new System.EventHandler(this.btnViewMovies_Click);
            // 
            // txbOutput
            // 
            this.txbOutput.Location = new System.Drawing.Point(38, 12);
            this.txbOutput.Multiline = true;
            this.txbOutput.Name = "txbOutput";
            this.txbOutput.Size = new System.Drawing.Size(143, 109);
            this.txbOutput.TabIndex = 3;
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(231, 108);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(100, 20);
            this.txbId.TabIndex = 4;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(231, 12);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 20);
            this.txbName.TabIndex = 5;
            // 
            // txbYear
            // 
            this.txbYear.Location = new System.Drawing.Point(231, 162);
            this.txbYear.Name = "txbYear";
            this.txbYear.Size = new System.Drawing.Size(100, 20);
            this.txbYear.TabIndex = 6;
            // 
            // txbIMDB
            // 
            this.txbIMDB.Location = new System.Drawing.Point(231, 215);
            this.txbIMDB.Name = "txbIMDB";
            this.txbIMDB.Size = new System.Drawing.Size(100, 20);
            this.txbIMDB.TabIndex = 7;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(38, 220);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(106, 23);
            this.btnCount.TabIndex = 8;
            this.btnCount.Text = "Show Node Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(38, 191);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(92, 23);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Text = "Show Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 287);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txbIMDB);
            this.Controls.Add(this.txbYear);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.txbOutput);
            this.Controls.Add(this.btnViewMovies);
            this.Controls.Add(this.btnAddMovie);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnViewMovies;
        private System.Windows.Forms.TextBox txbOutput;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbYear;
        private System.Windows.Forms.TextBox txbIMDB;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnPrevious;
    }
}

