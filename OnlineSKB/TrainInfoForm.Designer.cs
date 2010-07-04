namespace OnlineSKB
{
    partial class TrainInfoForm
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
            this.lblTrainCode = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.Text = "车次";
            // 
            // lblTrainCode
            // 
            this.lblTrainCode.Location = new System.Drawing.Point(54, 4);
            this.lblTrainCode.Name = "lblTrainCode";
            this.lblTrainCode.Size = new System.Drawing.Size(44, 20);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(164, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 20);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "返回";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.Text = "区间历时";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(63, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(119, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.Text = "全程历时";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(180, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid.Location = new System.Drawing.Point(4, 49);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(232, 242);
            this.dataGrid.TabIndex = 10;
            this.dataGrid.TableStyles.Add(this.dataGridTableStyle);
            // 
            // dataGridTableStyle
            // 
            this.dataGridTableStyle.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle.MappingName = "StationInfo[]";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "车站";
            this.dataGridTextBoxColumn1.MappingName = "Name";
            this.dataGridTextBoxColumn1.NullText = "";
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "HH:mm";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "到时";
            this.dataGridTextBoxColumn2.MappingName = "ArrivalTime";
            this.dataGridTextBoxColumn2.NullText = "--";
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "HH:mm";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "发时";
            this.dataGridTextBoxColumn3.MappingName = "DepartureTime";
            this.dataGridTextBoxColumn3.NullText = "--";
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "历时";
            this.dataGridTextBoxColumn4.MappingName = "Duration";
            // 
            // TrainInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTrainCode);
            this.Controls.Add(this.label1);
            this.Name = "TrainInfoForm";
            this.Load += new System.EventHandler(this.TrainInfoForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTrainCode;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGrid dataGrid;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
    }
}