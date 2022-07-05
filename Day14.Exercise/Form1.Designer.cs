
namespace Day14.Exercise
{
    partial class FrmStudentMaster
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
            this.lblStudCode = new System.Windows.Forms.Label();
            this.TxtStudCode = new System.Windows.Forms.TextBox();
            this.TxtStudName = new System.Windows.Forms.TextBox();
            this.lblStudName = new System.Windows.Forms.Label();
            this.TxtDeptCode = new System.Windows.Forms.TextBox();
            this.lblDeptCode = new System.Windows.Forms.Label();
            this.TxtStudDob = new System.Windows.Forms.TextBox();
            this.lblStudDob = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudCode
            // 
            this.lblStudCode.AutoSize = true;
            this.lblStudCode.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudCode.Location = new System.Drawing.Point(56, 23);
            this.lblStudCode.Name = "lblStudCode";
            this.lblStudCode.Size = new System.Drawing.Size(76, 18);
            this.lblStudCode.TabIndex = 0;
            this.lblStudCode.Text = "Stud_Code";
            // 
            // TxtStudCode
            // 
            this.TxtStudCode.Location = new System.Drawing.Point(138, 23);
            this.TxtStudCode.Name = "TxtStudCode";
            this.TxtStudCode.Size = new System.Drawing.Size(100, 20);
            this.TxtStudCode.TabIndex = 1;
            // 
            // TxtStudName
            // 
            this.TxtStudName.Location = new System.Drawing.Point(138, 58);
            this.TxtStudName.Name = "TxtStudName";
            this.TxtStudName.Size = new System.Drawing.Size(100, 20);
            this.TxtStudName.TabIndex = 3;
            // 
            // lblStudName
            // 
            this.lblStudName.AutoSize = true;
            this.lblStudName.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudName.Location = new System.Drawing.Point(50, 60);
            this.lblStudName.Name = "lblStudName";
            this.lblStudName.Size = new System.Drawing.Size(82, 18);
            this.lblStudName.TabIndex = 2;
            this.lblStudName.Text = "Stud_Name";
            // 
            // TxtDeptCode
            // 
            this.TxtDeptCode.Location = new System.Drawing.Point(138, 104);
            this.TxtDeptCode.Name = "TxtDeptCode";
            this.TxtDeptCode.Size = new System.Drawing.Size(100, 20);
            this.TxtDeptCode.TabIndex = 5;
            // 
            // lblDeptCode
            // 
            this.lblDeptCode.AutoSize = true;
            this.lblDeptCode.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptCode.Location = new System.Drawing.Point(50, 104);
            this.lblDeptCode.Name = "lblDeptCode";
            this.lblDeptCode.Size = new System.Drawing.Size(77, 18);
            this.lblDeptCode.TabIndex = 4;
            this.lblDeptCode.Text = "Dept_Code";
            // 
            // TxtStudDob
            // 
            this.TxtStudDob.Location = new System.Drawing.Point(138, 143);
            this.TxtStudDob.Name = "TxtStudDob";
            this.TxtStudDob.Size = new System.Drawing.Size(100, 20);
            this.TxtStudDob.TabIndex = 7;
            // 
            // lblStudDob
            // 
            this.lblStudDob.AutoSize = true;
            this.lblStudDob.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudDob.Location = new System.Drawing.Point(56, 145);
            this.lblStudDob.Name = "lblStudDob";
            this.lblStudDob.Size = new System.Drawing.Size(72, 18);
            this.lblStudDob.TabIndex = 6;
            this.lblStudDob.Text = "Stud_Dob";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(138, 189);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(100, 20);
            this.TxtAddress.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(56, 191);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(59, 18);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(259, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 28);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(29, 237);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 28);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(138, 237);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 28);
            this.btnAddNew.TabIndex = 12;
            this.btnAddNew.Text = "Add";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(236, 235);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 28);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmStudentMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 277);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.TxtStudDob);
            this.Controls.Add(this.lblStudDob);
            this.Controls.Add(this.TxtDeptCode);
            this.Controls.Add(this.lblDeptCode);
            this.Controls.Add(this.TxtStudName);
            this.Controls.Add(this.lblStudName);
            this.Controls.Add(this.TxtStudCode);
            this.Controls.Add(this.lblStudCode);
            this.Name = "FrmStudentMaster";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmStudentMaster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudCode;
        private System.Windows.Forms.TextBox TxtStudCode;
        private System.Windows.Forms.TextBox TxtStudName;
        private System.Windows.Forms.Label lblStudName;
        private System.Windows.Forms.TextBox TxtDeptCode;
        private System.Windows.Forms.Label lblDeptCode;
        private System.Windows.Forms.TextBox TxtStudDob;
        private System.Windows.Forms.Label lblStudDob;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnUpdate;
    }
}

