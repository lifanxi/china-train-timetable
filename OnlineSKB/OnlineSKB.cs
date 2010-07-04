using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using OnlineSKB.Properties;

namespace OnlineSKB
{
    public enum QueryType
    {
        StationStation, TrainCode, Station, 
    }
    public partial class OnlineSKB : Form
    {
        private QueryType queryType;

        public OnlineSKB()
        {
            InitializeComponent();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void Exit()
        {
            if (MessageBox.Show("要退出在线时刻表吗？", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                Application.Exit();
        }   

        private void menuQuery_Click(object sender, EventArgs e)
        {
            IQuery query = new Web12306();
            TrainInfo [] trainInfo = null;
            switch (queryType)
            {
                case QueryType.StationStation:
                    trainInfo = query.ByStationSataion(cbDepart.Text.Trim(), cbDest.Text.Trim(), queryTime.Value.Date);
                    break;
                case QueryType.TrainCode:
                    trainInfo = query.ByTrainCode(tbTrainCode.Text, queryTime.Value.Date);
                    break;
                case QueryType.Station:
                    trainInfo = query.ByStation(cbDepart.Text.Trim(), queryTime.Value.Date);
                    break;
            }
            dataGrid.DataSource = trainInfo;
        }

        private void dataGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            dataGrid.Select(dataGrid.CurrentCell.RowNumber);
        }

        private void dataGrid_Click(object sender, EventArgs e)
        {
            IQuery query = new Web12306();
            if (dataGrid.DataSource != null)
            {
                TrainInfo trainInfo = query.GetTrainInfo((dataGrid.DataSource as TrainInfo[])[dataGrid.CurrentCell.RowNumber].Code, queryTime.Value.Date);
                TrainInfoForm form = new TrainInfoForm();
                form.TrainInfo = trainInfo;
                form.ShowDialog();
            }
        }

        private void ToggleUI(object sender, EventArgs e)
        {
            if (sender == menuStationStationQuery)
            {
                lblOne.Text = "发站";
                lblTwo.Text = "到站";
                lblOne.Visible = true;
                lblTwo.Visible = true;
                cbDepart.Visible = true;
                cbDest.Visible = true;
                tbTrainCode.Visible = false;
                queryType = QueryType.StationStation;
            }
            else if (sender == menuTrainCodeQuery)
            {
                lblOne.Text = "车次";
                lblOne.Visible = true;
                lblTwo.Visible = false;
                cbDepart.Visible = false;
                cbDest.Visible = false;
                tbTrainCode.Text = "";
                tbTrainCode.Visible = true;
                queryType = QueryType.TrainCode;
            }
            else if (sender == menuStationQuery)
            {
                lblOne.Text = "车站";
                lblOne.Visible = true;
                lblTwo.Visible = false;
                cbDepart.Visible = true;
                cbDest.Visible = false;
                tbTrainCode.Visible = false;
                queryType = QueryType.Station;
            }
            menuStationQuery.Checked = false;
            menuStationStationQuery.Checked = false;
            menuTrainCodeQuery.Checked = false;
            (sender as MenuItem).Checked = true;

        }

        private void OnlineSKB_Load(object sender, EventArgs e)
        {
            ToggleUI(menuStationStationQuery, new EventArgs());
            //System.Resources.ResourceManager resources = new System.Resources.ResourceManager("OnlinkSKB", GetType().Assembly);
            //this.Icon = (System.Drawing.Icon)resources.GetObject("OnlineSKB");
            this.Icon = Properties.Resources.OnlineSKB;
        }

        private void comboBoxTextChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedIndex != -1)
                return;
            string value = cb.Text.Trim();
            if (value != string.Empty)
            {
                IQuery query = new Web12306();
                string[] values = query.StationNameFromAbbr(value, queryTime.Value.Date);
                // string[] values = new string[] { "苏州", "苏州新区" };
                cb.Items.Clear();
                cb.SelectedIndex = -1;
                foreach (string v in values)
                {
                    cb.Items.Add(v);
                }
                ShowComboBoxDropDown(cb);
            }
        }

        #region InterOp Helper Functions

        private const uint CB_SHOWDROPDOWN = 0x014f;
        [DllImport("Coredll.dll", EntryPoint = "SendMessage", SetLastError = true)]
        private static extern int SendMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

        void ShowComboBoxDropDown(ComboBox comboBox)
        {
            SendMessage(comboBox.Handle, CB_SHOWDROPDOWN, 1/*TRUE*/, 0);
        }
        #endregion
    }
}