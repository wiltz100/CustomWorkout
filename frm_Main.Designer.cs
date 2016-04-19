namespace CustomWorkout
{
    partial class frm_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.lb_ExList = new System.Windows.Forms.CheckedListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btn_OpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel12 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.btn_Start = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btn_Pause = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.btn_Stop = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btn_end = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel13 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.f_DfltExTime = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel11 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel10 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.f_DfltRestTime = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.l_Timer = new System.Windows.Forms.Label();
            this.l_CurrExercise = new System.Windows.Forms.Label();
            this.l_NextExercise = new System.Windows.Forms.Label();
            this.l_Paused = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_ExList
            // 
            this.lb_ExList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_ExList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ExList.FormattingEnabled = true;
            this.lb_ExList.Location = new System.Drawing.Point(751, 38);
            this.lb_ExList.Name = "lb_ExList";
            this.lb_ExList.Size = new System.Drawing.Size(269, 556);
            this.lb_ExList.TabIndex = 1;
            this.lb_ExList.DoubleClick += new System.EventHandler(this.lb_ExList_DoubleClick);
            this.lb_ExList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lb_ExList_KeyPress);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.btn_OpenFile,
            this.toolStripLabel12,
            this.toolStripSeparator2,
            this.toolStripLabel5,
            this.btn_Start,
            this.toolStripLabel3,
            this.btn_Pause,
            this.toolStripLabel4,
            this.btn_Stop,
            this.toolStripLabel7,
            this.toolStripSeparator1,
            this.toolStripLabel6,
            this.btn_end,
            this.toolStripLabel1,
            this.toolStripLabel13,
            this.toolStripLabel8,
            this.f_DfltExTime,
            this.toolStripLabel11,
            this.toolStripLabel10,
            this.toolStripLabel9,
            this.f_DfltRestTime,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1020, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(13, 36);
            this.toolStripLabel2.Text = "  ";
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_OpenFile.Image = global::CustomWorkout.Properties.Resources.folderopened_yellow_32;
            this.btn_OpenFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_OpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(36, 36);
            this.btn_OpenFile.Text = "toolStripButton1";
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // toolStripLabel12
            // 
            this.toolStripLabel12.Name = "toolStripLabel12";
            this.toolStripLabel12.Size = new System.Drawing.Size(13, 36);
            this.toolStripLabel12.Text = "  ";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(13, 36);
            this.toolStripLabel5.Text = "  ";
            // 
            // btn_Start
            // 
            this.btn_Start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Start.Image = global::CustomWorkout.Properties.Resources.media_playback_start_32;
            this.btn_Start.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(36, 36);
            this.btn_Start.Text = "toolStripButton1";
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(13, 36);
            this.toolStripLabel3.Text = "  ";
            // 
            // btn_Pause
            // 
            this.btn_Pause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Pause.Enabled = false;
            this.btn_Pause.Image = global::CustomWorkout.Properties.Resources.media_playback_pause_32;
            this.btn_Pause.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Pause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(36, 36);
            this.btn_Pause.Text = "toolStripButton1";
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Enabled = false;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(13, 36);
            this.toolStripLabel4.Text = "  ";
            // 
            // btn_Stop
            // 
            this.btn_Stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Stop.Enabled = false;
            this.btn_Stop.Image = global::CustomWorkout.Properties.Resources.media_playback_stop_32;
            this.btn_Stop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(36, 36);
            this.btn_Stop.Text = "toolStripButton1";
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(13, 36);
            this.toolStripLabel7.Text = "  ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(13, 36);
            this.toolStripLabel6.Text = "  ";
            // 
            // btn_end
            // 
            this.btn_end.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_end.Image = global::CustomWorkout.Properties.Resources.close_32;
            this.btn_end.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_end.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(36, 36);
            this.btn_end.Text = "toolStripButton1";
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(13, 36);
            this.toolStripLabel1.Text = "  ";
            // 
            // toolStripLabel13
            // 
            this.toolStripLabel13.Name = "toolStripLabel13";
            this.toolStripLabel13.Size = new System.Drawing.Size(13, 36);
            this.toolStripLabel13.Text = "  ";
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripLabel8.ForeColor = System.Drawing.Color.DarkBlue;
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(95, 36);
            this.toolStripLabel8.Text = "Dflt Ex Time:";
            // 
            // f_DfltExTime
            // 
            this.f_DfltExTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.f_DfltExTime.Name = "f_DfltExTime";
            this.f_DfltExTime.Size = new System.Drawing.Size(40, 39);
            this.f_DfltExTime.Text = "30";
            this.f_DfltExTime.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.f_DfltExTime.Validated += new System.EventHandler(this.f_DfltExTime_Validated);
            // 
            // toolStripLabel11
            // 
            this.toolStripLabel11.Enabled = false;
            this.toolStripLabel11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripLabel11.Name = "toolStripLabel11";
            this.toolStripLabel11.Size = new System.Drawing.Size(18, 36);
            this.toolStripLabel11.Text = "  ";
            // 
            // toolStripLabel10
            // 
            this.toolStripLabel10.Enabled = false;
            this.toolStripLabel10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripLabel10.Name = "toolStripLabel10";
            this.toolStripLabel10.Size = new System.Drawing.Size(18, 36);
            this.toolStripLabel10.Text = "  ";
            // 
            // toolStripLabel9
            // 
            this.toolStripLabel9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripLabel9.ForeColor = System.Drawing.Color.DarkBlue;
            this.toolStripLabel9.Name = "toolStripLabel9";
            this.toolStripLabel9.Size = new System.Drawing.Size(110, 36);
            this.toolStripLabel9.Text = "Dflt Rest Time:";
            // 
            // f_DfltRestTime
            // 
            this.f_DfltRestTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.f_DfltRestTime.Name = "f_DfltRestTime";
            this.f_DfltRestTime.Size = new System.Drawing.Size(40, 39);
            this.f_DfltRestTime.Text = "15";
            this.f_DfltRestTime.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.f_DfltRestTime.Validated += new System.EventHandler(this.f_DfltRestTime_Validated);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 36);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // l_Timer
            // 
            this.l_Timer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 160F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Timer.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.l_Timer.Location = new System.Drawing.Point(13, 217);
            this.l_Timer.Name = "l_Timer";
            this.l_Timer.Size = new System.Drawing.Size(724, 217);
            this.l_Timer.TabIndex = 3;
            this.l_Timer.Text = "30";
            this.l_Timer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // l_CurrExercise
            // 
            this.l_CurrExercise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_CurrExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_CurrExercise.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.l_CurrExercise.Location = new System.Drawing.Point(12, 88);
            this.l_CurrExercise.Name = "l_CurrExercise";
            this.l_CurrExercise.Size = new System.Drawing.Size(724, 80);
            this.l_CurrExercise.TabIndex = 4;
            this.l_CurrExercise.Text = "Squat Switch Pickups";
            this.l_CurrExercise.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // l_NextExercise
            // 
            this.l_NextExercise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_NextExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_NextExercise.ForeColor = System.Drawing.Color.SaddleBrown;
            this.l_NextExercise.Location = new System.Drawing.Point(12, 526);
            this.l_NextExercise.Name = "l_NextExercise";
            this.l_NextExercise.Size = new System.Drawing.Size(724, 53);
            this.l_NextExercise.TabIndex = 5;
            this.l_NextExercise.Text = "Next: Squat Switch Pickups";
            this.l_NextExercise.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // l_Paused
            // 
            this.l_Paused.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_Paused.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Paused.ForeColor = System.Drawing.Color.Maroon;
            this.l_Paused.Location = new System.Drawing.Point(278, 177);
            this.l_Paused.Name = "l_Paused";
            this.l_Paused.Size = new System.Drawing.Size(161, 40);
            this.l_Paused.TabIndex = 6;
            this.l_Paused.Text = "Paused";
            this.l_Paused.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_Paused.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 600);
            this.Controls.Add(this.l_Paused);
            this.Controls.Add(this.l_NextExercise);
            this.Controls.Add(this.l_CurrExercise);
            this.Controls.Add(this.l_Timer);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lb_ExList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Main_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lb_ExList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Start;
        private System.Windows.Forms.ToolStripButton btn_Stop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label l_Timer;
        private System.Windows.Forms.ToolStripButton btn_Pause;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label l_CurrExercise;
        private System.Windows.Forms.Label l_NextExercise;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.ToolStripTextBox f_DfltExTime;
        private System.Windows.Forms.ToolStripLabel toolStripLabel11;
        private System.Windows.Forms.ToolStripLabel toolStripLabel10;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private System.Windows.Forms.ToolStripTextBox f_DfltRestTime;
        private System.Windows.Forms.Label l_Paused;
        private System.Windows.Forms.ToolStripButton btn_OpenFile;
        private System.Windows.Forms.ToolStripLabel toolStripLabel12;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_end;
        private System.Windows.Forms.ToolStripLabel toolStripLabel13;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

