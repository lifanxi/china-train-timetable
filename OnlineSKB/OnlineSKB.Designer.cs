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
            System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn21;
            System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn22;
            System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn24;
            System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn23;
            System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn25;
            System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn29;
            System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn26;
            System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn27;
            System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn28;
            System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn11;
            System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn14;
            System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn15;
            System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn19;
            System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn16;
            System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn17;
            System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
            System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
            System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
            System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
            System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
            System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn9;
            System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
            System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
            System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;
            this.dataGridTableStyleStation = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTableStyleCode = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTableStyleStationStation = new System.Windows.Forms.DataGridTableStyle();
            this.mainMenu = new System.Windows.Forms.MainMenu();
            this.menuQuery = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuStationStationQuery = new System.Windows.Forms.MenuItem();
            this.menuTrainCodeQuery = new System.Windows.Forms.MenuItem();
            this.menuStationQuery = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuExit = new System.Windows.Forms.MenuItem();
            this.lblOne = new System.Windows.Forms.Label();
            this.lblTwo = new System.Windows.Forms.Label();
            this.cbDepart = new System.Windows.Forms.ComboBox();
            this.cbDest = new System.Windows.Forms.ComboBox();
            this.queryTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTrainCode = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGrid();
            dataGridTextBoxColumn21 = new System.Windows.Forms.DataGridTextBoxColumn();
            dataGridTextBoxColumn22 = new System.Windows.Forms.DataGridTextBoxColumn();
            dataGridTextBoxColumn24 = new System.Windows.Forms.DataGridTextBoxColumn();
            dataGridTextBoxColumn23 = new System.Windows.Forms.DataGridTextBoxColumn();
            dataGridTextBoxColumn25 = new System.Windows.Forms.DataGridTextBoxColumn();
            dataGridTextBoxColumn29 = new System.Windows.Forms.DataGridTextBoxColumn();
            dataGridTextBoxColumn26 = new System.Windows.Forms.DataGridTextBoxColumn();
            dataGridTextBoxColumn27 = new System.Windows.Forms.DataGridTextBoxColumn();
            dataGridTextBoxColumn28 = new System.Windows.Forms.DataGridTextBoxColumn();
            dataGridTextBoxColumn11 = new System.Windows.Forms.DataGridTextBoxColumn();
            dataGridTextBoxColumn14 = new System.Windows.Forms.DataGridTextBoxColumn();
            dataGridTextBoxColumn15 = new System.Windows.Forms.DataGridTextBoxColumn();
            dataGridTextBoxColumn19 = new System.Windows.Forms.DataGridTextBoxColumn();
            dataGridTextBoxColumn16 = new System.Windows.Forms.DataGridTextBoxColumn();
            dataGridTextBoxColumn17 = new System.Windows.Forms.DataGridTextBoxColumn();
            dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            dataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
            dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.SuspendLayout();
            // 
            // dataGridTableStyleStation
            // 
            this.dataGridTableStyleStation.GridColumnStyles.Add(dataGridTextBoxColumn21);
            this.dataGridTableStyleStation.GridColumnStyles.Add(dataGridTextBoxColumn22);
            this.dataGridTableStyleStation.GridColumnStyles.Add(dataGridTextBoxColumn24);
            this.dataGridTableStyleStation.GridColumnStyles.Add(dataGridTextBoxColumn23);
            this.dataGridTableStyleStation.GridColumnStyles.Add(dataGridTextBoxColumn25);
            this.dataGridTableStyleStation.GridColumnStyles.Add(dataGridTextBoxColumn29);
            this.dataGridTableStyleStation.GridColumnStyles.Add(dataGridTextBoxColumn26);
            this.dataGridTableStyleStation.GridColumnStyles.Add(dataGridTextBoxColumn27);
            this.dataGridTableStyleStation.GridColumnStyles.Add(dataGridTextBoxColumn28);
            // 
            // dataGridTextBoxColumn21
            // 
            dataGridTextBoxColumn21.Format = "";
            dataGridTextBoxColumn21.FormatInfo = null;
            dataGridTextBoxColumn21.HeaderText = "车次";
            dataGridTextBoxColumn21.MappingName = "Code";
            // 
            // dataGridTextBoxColumn22
            // 
            dataGridTextBoxColumn22.Format = "";
            dataGridTextBoxColumn22.FormatInfo = null;
            dataGridTextBoxColumn22.HeaderText = "发站";
            dataGridTextBoxColumn22.MappingName = "RangeDeparture";
            // 
            // dataGridTextBoxColumn24
            // 
            dataGridTextBoxColumn24.Format = "HH:mm";
            dataGridTextBoxColumn24.FormatInfo = null;
            dataGridTextBoxColumn24.HeaderText = "发时";
            dataGridTextBoxColumn24.MappingName = "RangeDepartTime";
            // 
            // dataGridTextBoxColumn23
            // 
            dataGridTextBoxColumn23.Format = "";
            dataGridTextBoxColumn23.FormatInfo = null;
            dataGridTextBoxColumn23.HeaderText = "到站";
            dataGridTextBoxColumn23.MappingName = "RangeDestination";
            // 
            // dataGridTextBoxColumn25
            // 
            dataGridTextBoxColumn25.Format = "HH:mm";
            dataGridTextBoxColumn25.FormatInfo = null;
            dataGridTextBoxColumn25.HeaderText = "到时";
            dataGridTextBoxColumn25.MappingName = "RangeDestTime";
            // 
            // dataGridTextBoxColumn29
            // 
            dataGridTextBoxColumn29.Format = "";
            dataGridTextBoxColumn29.FormatInfo = null;
            dataGridTextBoxColumn29.HeaderText = "历时";
            dataGridTextBoxColumn29.MappingName = "RangeDuration";
            // 
            // dataGridTextBoxColumn26
            // 
            dataGridTextBoxColumn26.Format = "";
            dataGridTextBoxColumn26.FormatInfo = null;
            dataGridTextBoxColumn26.HeaderText = "始发站";
            dataGridTextBoxColumn26.MappingName = "TrainDeparture";
            // 
            // dataGridTextBoxColumn27
            // 
            dataGridTextBoxColumn27.Format = "";
            dataGridTextBoxColumn27.FormatInfo = null;
            dataGridTextBoxColumn27.HeaderText = "终点站";
            dataGridTextBoxColumn27.MappingName = "TrainDestination";
            // 
            // dataGridTextBoxColumn28
            // 
            dataGridTextBoxColumn28.Format = "";
            dataGridTextBoxColumn28.FormatInfo = null;
            dataGridTextBoxColumn28.HeaderText = "等级";
            dataGridTextBoxColumn28.MappingName = "TrainClass";
            // 
            // dataGridTableStyleCode
            // 
            this.dataGridTableStyleCode.GridColumnStyles.Add(dataGridTextBoxColumn11);
            this.dataGridTableStyleCode.GridColumnStyles.Add(dataGridTextBoxColumn16);
            this.dataGridTableStyleCode.GridColumnStyles.Add(dataGridTextBoxColumn14);
            this.dataGridTableStyleCode.GridColumnStyles.Add(dataGridTextBoxColumn17);
            this.dataGridTableStyleCode.GridColumnStyles.Add(dataGridTextBoxColumn15);
            this.dataGridTableStyleCode.GridColumnStyles.Add(dataGridTextBoxColumn19);
            // 
            // dataGridTextBoxColumn11
            // 
            dataGridTextBoxColumn11.Format = "";
            dataGridTextBoxColumn11.FormatInfo = null;
            dataGridTextBoxColumn11.HeaderText = "车次";
            dataGridTextBoxColumn11.MappingName = "Code";
            // 
            // dataGridTextBoxColumn14
            // 
            dataGridTextBoxColumn14.Format = "HH:mm";
            dataGridTextBoxColumn14.FormatInfo = null;
            dataGridTextBoxColumn14.HeaderText = "发时";
            dataGridTextBoxColumn14.MappingName = "TrainDepartTime";
            // 
            // dataGridTextBoxColumn15
            // 
            dataGridTextBoxColumn15.Format = "HH:mm";
            dataGridTextBoxColumn15.FormatInfo = null;
            dataGridTextBoxColumn15.HeaderText = "到时";
            dataGridTextBoxColumn15.MappingName = "TrainDestTime";
            // 
            // dataGridTextBoxColumn19
            // 
            dataGridTextBoxColumn19.Format = "";
            dataGridTextBoxColumn19.FormatInfo = null;
            dataGridTextBoxColumn19.HeaderText = "历时";
            dataGridTextBoxColumn19.MappingName = "TrainDuration";
            // 
            // dataGridTextBoxColumn16
            // 
            dataGridTextBoxColumn16.Format = "";
            dataGridTextBoxColumn16.FormatInfo = null;
            dataGridTextBoxColumn16.HeaderText = "始发站";
            dataGridTextBoxColumn16.MappingName = "TrainDeparture";
            // 
            // dataGridTextBoxColumn17
            // 
            dataGridTextBoxColumn17.Format = "";
            dataGridTextBoxColumn17.FormatInfo = null;
            dataGridTextBoxColumn17.HeaderText = "终点站";
            dataGridTextBoxColumn17.MappingName = "TrainDestination";
            // 
            // dataGridTableStyleStationStation
            // 
            this.dataGridTableStyleStationStation.GridColumnStyles.Add(dataGridTextBoxColumn1);
            this.dataGridTableStyleStationStation.GridColumnStyles.Add(dataGridTextBoxColumn2);
            this.dataGridTableStyleStationStation.GridColumnStyles.Add(dataGridTextBoxColumn4);
            this.dataGridTableStyleStationStation.GridColumnStyles.Add(dataGridTextBoxColumn3);
            this.dataGridTableStyleStationStation.GridColumnStyles.Add(dataGridTextBoxColumn5);
            this.dataGridTableStyleStationStation.GridColumnStyles.Add(dataGridTextBoxColumn9);
            this.dataGridTableStyleStationStation.GridColumnStyles.Add(dataGridTextBoxColumn6);
            this.dataGridTableStyleStationStation.GridColumnStyles.Add(dataGridTextBoxColumn7);
            this.dataGridTableStyleStationStation.GridColumnStyles.Add(dataGridTextBoxColumn8);
            // 
            // dataGridTextBoxColumn1
            // 
            dataGridTextBoxColumn1.Format = "";
            dataGridTextBoxColumn1.FormatInfo = null;
            dataGridTextBoxColumn1.HeaderText = "车次";
            dataGridTextBoxColumn1.MappingName = "Code";
            // 
            // dataGridTextBoxColumn2
            // 
            dataGridTextBoxColumn2.Format = "";
            dataGridTextBoxColumn2.FormatInfo = null;
            dataGridTextBoxColumn2.HeaderText = "发站";
            dataGridTextBoxColumn2.MappingName = "RangeDeparture";
            // 
            // dataGridTextBoxColumn4
            // 
            dataGridTextBoxColumn4.Format = "HH:mm";
            dataGridTextBoxColumn4.FormatInfo = null;
            dataGridTextBoxColumn4.HeaderText = "发时";
            dataGridTextBoxColumn4.MappingName = "RangeDepartTime";
            // 
            // dataGridTextBoxColumn3
            // 
            dataGridTextBoxColumn3.Format = "";
            dataGridTextBoxColumn3.FormatInfo = null;
            dataGridTextBoxColumn3.HeaderText = "到站";
            dataGridTextBoxColumn3.MappingName = "RangeDestination";
            // 
            // dataGridTextBoxColumn5
            // 
            dataGridTextBoxColumn5.Format = "HH:mm";
            dataGridTextBoxColumn5.FormatInfo = null;
            dataGridTextBoxColumn5.HeaderText = "到时";
            dataGridTextBoxColumn5.MappingName = "RangeDestTime";
            // 
            // dataGridTextBoxColumn9
            // 
            dataGridTextBoxColumn9.Format = "";
            dataGridTextBoxColumn9.FormatInfo = null;
            dataGridTextBoxColumn9.HeaderText = "历时";
            dataGridTextBoxColumn9.MappingName = "RangeDuration";
            // 
            // dataGridTextBoxColumn6
            // 
            dataGridTextBoxColumn6.Format = "";
            dataGridTextBoxColumn6.FormatInfo = null;
            dataGridTextBoxColumn6.HeaderText = "始发站";
            dataGridTextBoxColumn6.MappingName = "TrainDeparture";
            // 
            // dataGridTextBoxColumn7
            // 
            dataGridTextBoxColumn7.Format = "";
            dataGridTextBoxColumn7.FormatInfo = null;
            dataGridTextBoxColumn7.HeaderText = "终点站";
            dataGridTextBoxColumn7.MappingName = "TrainDestination";
            // 
            // dataGridTextBoxColumn8
            // 
            dataGridTextBoxColumn8.Format = "";
            dataGridTextBoxColumn8.FormatInfo = null;
            dataGridTextBoxColumn8.HeaderText = "等级";
            dataGridTextBoxColumn8.MappingName = "TrainClass";
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
            this.dataGrid.TableStyles.Add(this.dataGridTableStyleStationStation);
            this.dataGrid.TableStyles.Add(this.dataGridTableStyleCode);
            this.dataGrid.TableStyles.Add(this.dataGridTableStyleStation);
            this.dataGrid.CurrentCellChanged += new System.EventHandler(this.dataGrid_CurrentCellChanged);
            this.dataGrid.Click += new System.EventHandler(this.dataGrid_Click);
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
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Label lblTwo;
        private System.Windows.Forms.ComboBox cbDepart;
        private System.Windows.Forms.ComboBox cbDest;
        private System.Windows.Forms.DateTimePicker queryTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuItem menuStationStationQuery;
        private System.Windows.Forms.MenuItem menuTrainCodeQuery;
        private System.Windows.Forms.MenuItem menuStationQuery;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.TextBox tbTrainCode;
        private System.Windows.Forms.DataGrid dataGrid;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyleStation;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyleCode;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyleStationStation;
    }
}

