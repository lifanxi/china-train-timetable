using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OnlineSKB
{
    public partial class TrainInfoForm : Form
    {
        public TrainInfoForm()
        {
            InitializeComponent();
        }

        //public TrainInfoForm(TrainInfo trainInfo)
        //{
        //    InitializeComponent();
        //    TrainInfo = trainInfo;
        //    dataGrid.DataSource = TrainInfo.StationInfo;
        //    //       dataGrid.TableStyles.Clear();
        //    //       dataGrid.TableStyles.Add(this.dataGridTableStyle);

        //    lblTrainCode.Text = TrainInfo.Code;
        //}

        public TrainInfo TrainInfo
        {
            set 
            {
                dataGrid.DataSource = value.StationInfo;
                lblTrainCode.Text = value.Code;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TrainInfoForm_Load(object sender, EventArgs e)
        {

        }
    }
}