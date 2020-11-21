
namespace appFolder
{
    partial class inputForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_title = new System.Windows.Forms.TextBox();
            this.txb_url = new System.Windows.Forms.TextBox();
            this.btn_explore = new System.Windows.Forms.Button();
            this.btnAddPath = new System.Windows.Forms.Button();
            this.txb_picture = new System.Windows.Forms.TextBox();
            this.btnExplore1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Picture";
            // 
            // txb_title
            // 
            this.txb_title.Location = new System.Drawing.Point(73, 13);
            this.txb_title.Name = "txb_title";
            this.txb_title.Size = new System.Drawing.Size(295, 22);
            this.txb_title.TabIndex = 3;
            // 
            // txb_url
            // 
            this.txb_url.Location = new System.Drawing.Point(73, 43);
            this.txb_url.Name = "txb_url";
            this.txb_url.Size = new System.Drawing.Size(295, 22);
            this.txb_url.TabIndex = 4;
            // 
            // btn_explore
            // 
            this.btn_explore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_explore.Location = new System.Drawing.Point(374, 13);
            this.btn_explore.Name = "btn_explore";
            this.btn_explore.Size = new System.Drawing.Size(49, 55);
            this.btn_explore.TabIndex = 5;
            this.btn_explore.Text = "...";
            this.btn_explore.UseVisualStyleBackColor = true;
            this.btn_explore.Click += new System.EventHandler(this.btn_explore_Click);
            // 
            // btnAddPath
            // 
            this.btnAddPath.Location = new System.Drawing.Point(73, 106);
            this.btnAddPath.Name = "btnAddPath";
            this.btnAddPath.Size = new System.Drawing.Size(350, 30);
            this.btnAddPath.TabIndex = 6;
            this.btnAddPath.Text = "Add";
            this.btnAddPath.UseVisualStyleBackColor = true;
            this.btnAddPath.Click += new System.EventHandler(this.btnAddPath_Click);
            // 
            // txb_picture
            // 
            this.txb_picture.Location = new System.Drawing.Point(73, 77);
            this.txb_picture.Name = "txb_picture";
            this.txb_picture.Size = new System.Drawing.Size(295, 22);
            this.txb_picture.TabIndex = 7;
            // 
            // btnExplore1
            // 
            this.btnExplore1.Location = new System.Drawing.Point(374, 77);
            this.btnExplore1.Name = "btnExplore1";
            this.btnExplore1.Size = new System.Drawing.Size(49, 23);
            this.btnExplore1.TabIndex = 8;
            this.btnExplore1.Text = "...";
            this.btnExplore1.UseVisualStyleBackColor = true;
            this.btnExplore1.Click += new System.EventHandler(this.btnExplore1_Click);
            // 
            // inputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 144);
            this.Controls.Add(this.btnExplore1);
            this.Controls.Add(this.txb_picture);
            this.Controls.Add(this.btnAddPath);
            this.Controls.Add(this.btn_explore);
            this.Controls.Add(this.txb_url);
            this.Controls.Add(this.txb_title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "inputForm";
            this.Text = "Add Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_title;
        private System.Windows.Forms.TextBox txb_url;
        private System.Windows.Forms.Button btn_explore;
        private System.Windows.Forms.Button btnAddPath;
        private System.Windows.Forms.TextBox txb_picture;
        private System.Windows.Forms.Button btnExplore1;
    }
}