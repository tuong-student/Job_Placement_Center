﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Windows.Forms;
using final_oosee.Global;
using final_oosee.Business;
using final_oosee.Bridge;


namespace final_oosee.EmployerInterface
{
    public partial class Employer_EventManager : Form
    {
        List<JOB> jobList;

        AbstractManager manager;
        BLJob blJob;

        //This form use to see and add the job of this company.
        public Employer_EventManager()
        {

            InitializeComponent();
            blJob = new BLJob();
            manager = new AbstractManager(blJob);
            LoadData();

            //Set all input disable
            txtJobName.Enabled = false;
            txtAddress.Enabled = false;
            txtDescription.Enabled = false;
            txtWagePerHour.Enabled = false;
            btnAdd.Enabled = false;
            btnCancel.Enabled = false;
        }

        void LoadData()
        {
            //Get emID -> Geted when login
            //Get List of Job base on emID
            jobList = util.GetJobList(util.employerID);

            //Show List on UI
            dgvJobEvent.DataSource = jobList;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Set all input enable
            txtJobName.Enabled = true;
            txtAddress.Enabled = true;
            txtDescription.Enabled = true;
            txtWagePerHour.Enabled = true;
            btnAdd.Enabled = true;
            btnCancel.Enabled = true;

            txtJobName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSearch.Focus();
            //Set all input disable
            txtJobName.Enabled = false;
            txtAddress.Enabled = false;
            txtDescription.Enabled = false;
            txtWagePerHour.Enabled = false;
            btnAdd.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int jobID = Convert.ToInt32(dgvJobEvent.CurrentRow.Cells[0].Value.ToString());
            util.DeleteAppliedBasedOnJobID(jobID);
            manager.Delete();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            util.jobName = txtJobName.Text;
            util.wagePerHours = Convert.ToInt32(txtWagePerHour.Text);
            util.address = txtAddress.Text;
            util.jobDescription = txtDescription.Text;

            manager.Insert();
            LoadData();
        }

        private void dgvJobEvent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = Convert.ToInt32(dgvJobEvent.CurrentCell.RowIndex);
            int jobID = Convert.ToInt32(dgvJobEvent.Rows[r].Cells[0].Value.ToString());

            util.jobID = jobID;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<JOB> oldData = jobList;
            List<JOB> resutl = new List<JOB>();

            var result = util.SearchJobBaseOnKeyWord(txtSearch.Text, util.employerID);
            dgvJobEvent.DataSource = result.ToList();
        }
    }
}
