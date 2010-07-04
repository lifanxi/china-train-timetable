namespace OnlineSKB
{
    partial class OnlineSKB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu;

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
            this.mainMenu = new System.Windows.Forms.MainMenu();
            this.menuQuery = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuStationStationQuery = new System.Windows.Forms.MenuItem();
            this.menuTrainCodeQuery = new System.Windows.Forms.MenuItem();
            this.menuStationQuery = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuExit = new System.Windows.Forms.MenuItem();
            this.dataGrid = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.lblOne = new System.Windows.Forms.Label();
            this.lblTwo = new System.Windows.Forms.Label();
            this.cbDepart = new System.Windows.Forms.ComboBox();
            this.cbDest = new System.Windows.Forms.ComboBox();
            this.queryTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTrainCode = new System.Windows.Forms.TextBox();
            this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.menuQuery);
            this.mainMenu.MenuItems.Add(this.menuItem2);
            // 
            // menuQuery
            // 
            this.menuQuery.Text = "查询";
            this.menuQuery.Click += new System.EventHandler(this.menuQuery_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.MenuItems.Add(this.menuStationStationQuery);
            this.menuItem2.MenuItems.Add(this.menuTrainCodeQuery);
            this.menuItem2.MenuItems.Add(this.menuStationQuery);
            this.menuItem2.MenuItems.Add(this.menuItem5);
            this.menuItem2.MenuItems.Add(this.menuExit);
            this.menuItem2.Text = "菜单";
            // 
            // menuStationStationQuery
            // 
            this.menuStationStationQuery.Text = "站站查询";
            this.menuStationStationQuery.Click += new System.EventHandler(this.ToggleUI);
            // 
            // menuTrainCodeQuery
            // 
            this.menuTrainCodeQuery.Text = "车次查询";
            this.menuTrainCodeQuery.Click += new System.EventHandler(this.ToggleUI);
            // 
            // menuStationQuery
            // 
            this.menuStationQuery.Text = "车站查询";
            this.menuStationQuery.Click += new System.EventHandler(this.ToggleUI);
            // 
            // menuItem5
            // 
            this.menuItem5.Text = "-";
            // 
            // menuExit
            // 
            this.menuExit.Text = "退出";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid.Location = new System.Drawing.Point(3, 52);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(234, 213);
            this.dataGrid.TabIndex = 1;
            this.dataGrid.TableStyles.Add(this.dataGridTableStyle);
            this.dataGrid.CurrentCellChanged += new System.EventHandler(this.dataGrid_CurrentCellChanged);
            this.dataGrid.Click += new System.EventHandler(this.dataGrid_Click);
            // 
            // dataGridTableStyle
            // 
            this.dataGridTableStyle.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
            this.dataGridTableStyle.GridColumnStyles.Add(this.dataGridTextBoxColumn6);
            this.dataGridTableStyle.GridColumnStyles.Add(this.dataGridTextBoxColumn7);
            this.dataGridTableStyle.GridColumnStyles.Add(this.dataGridTextBoxColumn8);
            this.dataGridTableStyle.GridColumnStyles.Add(this.dataGridTextBoxColumn9);
            this.dataGridTableStyle.MappingName = "TrainInfo[]";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "车次";
            this.dataGridTextBoxColumn1.MappingName = "Code";
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "发站";
            this.dataGridTextBoxColumn2.MappingName = "RangeDeparture";
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "到站";
            this.dataGridTextBoxColumn3.MappingName = "RangeDestination";
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "HH:mm";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "发时";
            this.dataGridTextBoxColumn4.MappingName = "RangeDepartTime";
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.Format = "HH:mm";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            this.dataGridTextBoxColumn5.HeaderText = "到时";
            this.dataGridTextBoxColumn5.MappingName = "RangeDestTime";
            // 
            // lblOne
            // 
            this.lblOne.Location = new System.Drawing.Point(7, 29);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(37, 20);
            this.lblOne.Text = "发站";
            // 
            // lblTwo
            // 
            this.lblTwo.Location = new System.Drawing.Point(126, 31);
            this.lblTwo.Name = "lblTwo";
            this.lblTwo.Size = new System.Drawing.Size(38, 20);
            this.lblTwo.Text = "到站";
            // 
            // cbDepart
            // 
            this.cbDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbDepart.Location = new System.Drawing.Point(48, 27);
            this.cbDepart.Name = "cbDepart";
            this.cbDepart.Size = new System.Drawing.Size(66, 22);
            this.cbDepart.TabIndex = 4;
            this.cbDepart.Text = "南京";
            this.cbDepart.TextChanged += new System.EventHandler(this.comboBoxTextChanged);
            // 
            // cbDest
            // 
            this.cbDest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbDest.Location = new System.Drawing.Point(161, 27);
            this.cbDest.Name = "cbDest";
            this.cbDest.Size = new System.Drawing.Size(72, 22);
            this.cbDest.TabIndex = 4;
            this.cbDest.Text = "上海";
            this.cbDest.TextChanged += new System.EventHandler(this.comboBoxTextChanged);
            // 
            // queryTime
            // 
            this.queryTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.queryTime.Location = new System.Drawing.Point(48, 3);
            this.queryTime.Name = "queryTime";
            this.queryTime.Size = new System.Drawing.Size(185, 22);
            this.queryTime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.Text = "日期";
            // 
            // tbTrainCode
            // 
            this.tbTrainCode.Location = new System.Drawing.Point(48, 28);
            this.tbTrainCode.Name = "tbTrainCode";
            this.tbTrainCode.Size = new System.Drawing.Size(72, 21);
            this.tbTrainCode.TabIndex = 9;
            this.tbTrainCode.Visible = false;
            // 
            // dataGridTextBoxColumn6
            // 
            this.dataGridTextBoxColumn6.Format = "";
            this.dataGridTextBoxColumn6.FormatInfo = null;
            this.dataGridTextBoxColumn6.HeaderText = "始发站";
            this.dataGridTextBoxColumn6.MappingName = "TrainDeparture";
            // 
            // dataGridTextBoxColumn7
            // 
            this.dataGridTextBoxColumn7.Format = "";
            this.dataGridTextBoxColumn7.FormatInfo = null;
            this.dataGridTextBoxColumn7.HeaderText = "终点站";
            this.dataGridTextBoxColumn7.MappingName = "TrainDestination";
            // 
            // dataGridTextBoxColumn8
            // 
            this.dataGridTextBoxColumn8.Format = "";
            this.dataGridTextBoxColumn8.FormatInfo = null;
            this.dataGridTextBoxColumn8.HeaderText = "等级";
            this.dataGridTextBoxColumn8.MappingName = "TrainClass";
            // 
            // dataGridTextBoxColumn9
            // 
            this.dataGridTextBoxColumn9.Format = "";
            this.dataGridTextBoxColumn9.FormatInfo = null;
            this.dataGridTextBoxColumn9.HeaderText = "历时";
            this.dataGridTextBoxColumn9.MappingName = "RangeDuration";
            // 
            // OnlineSKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.tbTrainCode);
            this.Controls.Add(this.queryTime);
            this.Controls.Add(this.cbDest);
            this.Controls.Add(this.cbDepart);
            this.Controls.Add(this.lblTwo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOne);
            this.Controls.Add(this.dataGrid);
            this.Menu = this.mainMenu;
            this.Name = "OnlineSKB";
            this.Text = "手机时刻表";
            this.Load += new System.EventHandler(this.OnlineSKB_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuQuery;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuExit;
        private System.Windows.Forms.DataGrid dataGrid;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Label lblTwo;
        private System.Windows.Forms.ComboBox cbDepart;
        private System.Windows.Forms.ComboBox cbDest;
        private System.Windows.Forms.DateTimePicker queryTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
        private System.Windows.Forms.MenuItem menuStationStationQuery;
        private System.Windows.Forms.MenuItem menuTrainCodeQuery;
        private System.Windows.Forms.MenuItem menuStationQuery;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.TextBox tbTrainCode;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn9;
    }
}

