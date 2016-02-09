namespace CentennialCollegeStudentTracker
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
            this.btn_add_student = new System.Windows.Forms.Button();
            this.btn_delete_record = new System.Windows.Forms.Button();
            this.btn_delete_all_record = new System.Windows.Forms.Button();
            this.btn_search_with_id = new System.Windows.Forms.Button();
            this.btn_clear_display_screen = new System.Windows.Forms.Button();
            this.btn_display_all = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.tb_student_id = new System.Windows.Forms.TextBox();
            this.tb_student_name = new System.Windows.Forms.TextBox();
            this.label_student_id = new System.Windows.Forms.Label();
            this.label_student_name = new System.Windows.Forms.Label();
            this.tb_system_window = new System.Windows.Forms.TextBox();
            this.lb_result_window = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lv_result_window = new System.Windows.Forms.ListView();
            this.StudentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_add_student
            // 
            this.btn_add_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_student.Location = new System.Drawing.Point(23, 119);
            this.btn_add_student.Name = "btn_add_student";
            this.btn_add_student.Size = new System.Drawing.Size(105, 46);
            this.btn_add_student.TabIndex = 0;
            this.btn_add_student.Text = "ADD STUDENT ID and Name";
            this.btn_add_student.UseVisualStyleBackColor = true;
            this.btn_add_student.Click += new System.EventHandler(this.btn_add_student_Click);
            // 
            // btn_delete_record
            // 
            this.btn_delete_record.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_record.Location = new System.Drawing.Point(195, 119);
            this.btn_delete_record.Name = "btn_delete_record";
            this.btn_delete_record.Size = new System.Drawing.Size(115, 46);
            this.btn_delete_record.TabIndex = 1;
            this.btn_delete_record.Text = "DELETE RECORD";
            this.btn_delete_record.UseVisualStyleBackColor = true;
            this.btn_delete_record.Click += new System.EventHandler(this.btn_delete_record_Click);
            // 
            // btn_delete_all_record
            // 
            this.btn_delete_all_record.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_all_record.Location = new System.Drawing.Point(23, 188);
            this.btn_delete_all_record.Name = "btn_delete_all_record";
            this.btn_delete_all_record.Size = new System.Drawing.Size(105, 39);
            this.btn_delete_all_record.TabIndex = 2;
            this.btn_delete_all_record.Text = "DELETE ALL RECORD";
            this.btn_delete_all_record.UseVisualStyleBackColor = true;
            this.btn_delete_all_record.Click += new System.EventHandler(this.btn_delete_all_record_Click);
            // 
            // btn_search_with_id
            // 
            this.btn_search_with_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_with_id.Location = new System.Drawing.Point(195, 188);
            this.btn_search_with_id.Name = "btn_search_with_id";
            this.btn_search_with_id.Size = new System.Drawing.Size(115, 39);
            this.btn_search_with_id.TabIndex = 3;
            this.btn_search_with_id.Text = "SEARCH with STUDENT ID";
            this.btn_search_with_id.UseVisualStyleBackColor = true;
            this.btn_search_with_id.Click += new System.EventHandler(this.btn_search_with_id_Click);
            // 
            // btn_clear_display_screen
            // 
            this.btn_clear_display_screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_display_screen.Location = new System.Drawing.Point(23, 247);
            this.btn_clear_display_screen.Name = "btn_clear_display_screen";
            this.btn_clear_display_screen.Size = new System.Drawing.Size(287, 26);
            this.btn_clear_display_screen.TabIndex = 4;
            this.btn_clear_display_screen.Text = "CLEAR DISPLAY SCREEN";
            this.btn_clear_display_screen.UseVisualStyleBackColor = true;
            this.btn_clear_display_screen.Click += new System.EventHandler(this.btn_clear_display_screen_Click);
            // 
            // btn_display_all
            // 
            this.btn_display_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_display_all.Location = new System.Drawing.Point(23, 289);
            this.btn_display_all.Name = "btn_display_all";
            this.btn_display_all.Size = new System.Drawing.Size(287, 25);
            this.btn_display_all.TabIndex = 5;
            this.btn_display_all.Text = "DISPLAY ALL";
            this.btn_display_all.UseVisualStyleBackColor = true;
            this.btn_display_all.Click += new System.EventHandler(this.btn_display_all_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit.Location = new System.Drawing.Point(125, 327);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(75, 29);
            this.btn_quit.TabIndex = 6;
            this.btn_quit.Text = "QUIT";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // tb_student_id
            // 
            this.tb_student_id.Location = new System.Drawing.Point(146, 28);
            this.tb_student_id.Name = "tb_student_id";
            this.tb_student_id.Size = new System.Drawing.Size(164, 20);
            this.tb_student_id.TabIndex = 7;
            this.tb_student_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_student_id_KeyPress);
            // 
            // tb_student_name
            // 
            this.tb_student_name.Location = new System.Drawing.Point(146, 71);
            this.tb_student_name.Name = "tb_student_name";
            this.tb_student_name.Size = new System.Drawing.Size(164, 20);
            this.tb_student_name.TabIndex = 8;
            // 
            // label_student_id
            // 
            this.label_student_id.AutoSize = true;
            this.label_student_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_student_id.Location = new System.Drawing.Point(20, 31);
            this.label_student_id.Name = "label_student_id";
            this.label_student_id.Size = new System.Drawing.Size(87, 13);
            this.label_student_id.TabIndex = 10;
            this.label_student_id.Text = "STUDENT ID:";
            // 
            // label_student_name
            // 
            this.label_student_name.AutoSize = true;
            this.label_student_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_student_name.Location = new System.Drawing.Point(20, 74);
            this.label_student_name.Name = "label_student_name";
            this.label_student_name.Size = new System.Drawing.Size(109, 13);
            this.label_student_name.TabIndex = 11;
            this.label_student_name.Text = "STUDENT NAME:";
            // 
            // tb_system_window
            // 
            this.tb_system_window.Location = new System.Drawing.Point(362, 261);
            this.tb_system_window.Multiline = true;
            this.tb_system_window.Name = "tb_system_window";
            this.tb_system_window.ReadOnly = true;
            this.tb_system_window.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_system_window.Size = new System.Drawing.Size(319, 94);
            this.tb_system_window.TabIndex = 13;
            // 
            // lb_result_window
            // 
            this.lb_result_window.FormattingEnabled = true;
            this.lb_result_window.Location = new System.Drawing.Point(362, 43);
            this.lb_result_window.Name = "lb_result_window";
            this.lb_result_window.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lb_result_window.Size = new System.Drawing.Size(319, 56);
            this.lb_result_window.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "- Student Data Window -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(425, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "- System Message Window - ";
            // 
            // lv_result_window
            // 
            this.lv_result_window.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StudentID,
            this.StudentName});
            this.lv_result_window.FullRowSelect = true;
            this.lv_result_window.GridLines = true;
            this.lv_result_window.Location = new System.Drawing.Point(362, 105);
            this.lv_result_window.Name = "lv_result_window";
            this.lv_result_window.Size = new System.Drawing.Size(319, 122);
            this.lv_result_window.TabIndex = 17;
            this.lv_result_window.UseCompatibleStateImageBehavior = false;
            this.lv_result_window.View = System.Windows.Forms.View.Details;
            // 
            // StudentID
            // 
            this.StudentID.Text = "StudentID";
            this.StudentID.Width = 70;
            // 
            // StudentName
            // 
            this.StudentName.Text = "StudentName";
            this.StudentName.Width = 240;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 376);
            this.Controls.Add(this.lv_result_window);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_result_window);
            this.Controls.Add(this.tb_system_window);
            this.Controls.Add(this.label_student_name);
            this.Controls.Add(this.label_student_id);
            this.Controls.Add(this.tb_student_name);
            this.Controls.Add(this.tb_student_id);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_display_all);
            this.Controls.Add(this.btn_clear_display_screen);
            this.Controls.Add(this.btn_search_with_id);
            this.Controls.Add(this.btn_delete_all_record);
            this.Controls.Add(this.btn_delete_record);
            this.Controls.Add(this.btn_add_student);
            this.Name = "Form1";
            this.Text = "`";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_student;
        private System.Windows.Forms.Button btn_delete_record;
        private System.Windows.Forms.Button btn_delete_all_record;
        private System.Windows.Forms.Button btn_search_with_id;
        private System.Windows.Forms.Button btn_clear_display_screen;
        private System.Windows.Forms.Button btn_display_all;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.TextBox tb_student_id;
        private System.Windows.Forms.TextBox tb_student_name;
        private System.Windows.Forms.Label label_student_id;
        private System.Windows.Forms.Label label_student_name;
        private System.Windows.Forms.TextBox tb_system_window;
        private System.Windows.Forms.ListBox lb_result_window;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lv_result_window;
        private System.Windows.Forms.ColumnHeader StudentID;
        private System.Windows.Forms.ColumnHeader StudentName;
    }
}

