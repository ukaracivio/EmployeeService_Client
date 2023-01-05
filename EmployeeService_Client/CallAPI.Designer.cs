namespace EmployeeService_Client
{
    partial class CallAPI
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
            this.btonGetAll = new System.Windows.Forms.Button();
            this.btonGet = new System.Windows.Forms.Button();
            this.tboxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.tboxPosition = new System.Windows.Forms.TextBox();
            this.btonPost = new System.Windows.Forms.Button();
            this.btonPut = new System.Windows.Forms.Button();
            this.btonDelete = new System.Windows.Forms.Button();
            this.tboxResponse = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btonGetAll
            // 
            this.btonGetAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btonGetAll.Location = new System.Drawing.Point(26, 25);
            this.btonGetAll.Name = "btonGetAll";
            this.btonGetAll.Size = new System.Drawing.Size(75, 70);
            this.btonGetAll.TabIndex = 0;
            this.btonGetAll.Text = "GetAll";
            this.btonGetAll.UseVisualStyleBackColor = true;
            this.btonGetAll.Click += new System.EventHandler(this.btonGetAll_Click);
            // 
            // btonGet
            // 
            this.btonGet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btonGet.Location = new System.Drawing.Point(260, 72);
            this.btonGet.Name = "btonGet";
            this.btonGet.Size = new System.Drawing.Size(91, 35);
            this.btonGet.TabIndex = 1;
            this.btonGet.Text = "Get";
            this.btonGet.UseVisualStyleBackColor = true;
            // 
            // tboxID
            // 
            this.tboxID.Location = new System.Drawing.Point(260, 43);
            this.tboxID.Name = "tboxID";
            this.tboxID.Size = new System.Drawing.Size(91, 23);
            this.tboxID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(211, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // tboxName
            // 
            this.tboxName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxName.Location = new System.Drawing.Point(426, 43);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(132, 29);
            this.tboxName.TabIndex = 4;
            // 
            // tboxPosition
            // 
            this.tboxPosition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxPosition.Location = new System.Drawing.Point(426, 84);
            this.tboxPosition.Name = "tboxPosition";
            this.tboxPosition.Size = new System.Drawing.Size(132, 29);
            this.tboxPosition.TabIndex = 5;
            // 
            // btonPost
            // 
            this.btonPost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btonPost.Location = new System.Drawing.Point(601, 43);
            this.btonPost.Name = "btonPost";
            this.btonPost.Size = new System.Drawing.Size(75, 70);
            this.btonPost.TabIndex = 6;
            this.btonPost.Text = "Post";
            this.btonPost.UseVisualStyleBackColor = true;
            // 
            // btonPut
            // 
            this.btonPut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btonPut.Location = new System.Drawing.Point(696, 43);
            this.btonPut.Name = "btonPut";
            this.btonPut.Size = new System.Drawing.Size(75, 70);
            this.btonPut.TabIndex = 7;
            this.btonPut.Text = "Put";
            this.btonPut.UseVisualStyleBackColor = true;
            // 
            // btonDelete
            // 
            this.btonDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btonDelete.Location = new System.Drawing.Point(788, 45);
            this.btonDelete.Name = "btonDelete";
            this.btonDelete.Size = new System.Drawing.Size(75, 68);
            this.btonDelete.TabIndex = 8;
            this.btonDelete.Text = "Delete";
            this.btonDelete.UseVisualStyleBackColor = true;
            // 
            // tboxResponse
            // 
            this.tboxResponse.Location = new System.Drawing.Point(12, 153);
            this.tboxResponse.Name = "tboxResponse";
            this.tboxResponse.Size = new System.Drawing.Size(919, 373);
            this.tboxResponse.TabIndex = 9;
            this.tboxResponse.Text = "";
            // 
            // CallAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 538);
            this.Controls.Add(this.tboxResponse);
            this.Controls.Add(this.btonDelete);
            this.Controls.Add(this.btonPut);
            this.Controls.Add(this.btonPost);
            this.Controls.Add(this.tboxPosition);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxID);
            this.Controls.Add(this.btonGet);
            this.Controls.Add(this.btonGetAll);
            this.Name = "CallAPI";
            this.Text = "CallAPI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btonGetAll;
        private Button btonGet;
        private TextBox tboxID;
        private Label label1;
        private TextBox tboxName;
        private TextBox tboxPosition;
        private Button btonPost;
        private Button btonPut;
        private Button btonDelete;
        private RichTextBox tboxResponse;
    }
}