using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaiteringSystem.Business;
using WaiteringSystem.Data;

namespace WaiteringSystem.Presentation

{
    // Enum for different form states
    public enum FormStates
    {
        View = 0,
        Add = 1,
        Edit = 2,
        Delete = 3
    }
    public partial class EmployeeListingForm : Form
    {

        #region Variables
        public bool listFormClosed;//= true;
        private Collection<Employee> employees;
        private Role.RoleType roleValue;
        private EmployeeController employeeController;
        // Form-level state variable
        private FormStates state;

        // Employee object for current operations
        private Employee employee;

        
        #endregion

        #region property methods

        public Role.RoleType RoleValue
        {

            set { roleValue = value; }

        }

        #endregion

        #region Constructor
        public EmployeeListingForm()
        {
            InitializeComponent();
            this.Load += EmployeeListingForm_Load;
            this.Activated += EmployeeListingForm_Activated;
            // Initialize state to View
            state = FormStates.View;
            employeeController = new EmployeeController();
        }



        public EmployeeListingForm(EmployeeController empController)
        {

            InitializeComponent();
            employeeController = empController;
            this.Load += EmployeeListingForm_Load;
            this.Activated += EmployeeListingForm_Activated;
            this.FormClosed += EmployeeListingForm_FormClosed;
            state = FormStates.View;
        }


        #endregion

        #region Utility Methods
        private void ShowAll(bool show, Role.RoleType roleValue)
        {
            // Show/Hide Submit and Edit buttons based on state
            submitButton.Visible = !(state == FormStates.View);
            editButton.Visible = !(state == FormStates.View);

            // Show specific labels and textboxes depending on the role
            shiftsLabel.Visible = roleValue == Role.RoleType.Waiter || roleValue == Role.RoleType.Runner;
            shiftsTextBox.Visible = roleValue == Role.RoleType.Waiter || roleValue == Role.RoleType.Runner;
        }

        private void ClearAll()
        {
            // Clear all textboxes on the form
            idTextBox.Clear();
            empIdTextBox.Clear();
            nameTextBox.Clear();
            phoneTextBox.Clear();
            paymentTextBox.Clear();
            shiftsTextBox.Clear();
            // Clear other textboxes as necessary
        }

        private void EnableEntries(bool value)
        {
            if (state == FormStates.Edit && value)
            {
                // Disable primary key textboxes
                idTextBox.Enabled = !value;
                empIdTextBox.Enabled = !value;
            }
            else
            {
                // Enable primary key textboxes
                idTextBox.Enabled = value;
                empIdTextBox.Enabled = value;
            }

            // Enable other controls
            nameTextBox.Enabled = value;
            phoneTextBox.Enabled = value;
            paymentTextBox.Enabled = value;
            shiftsTextBox.Enabled = value;

            // If in delete state, hide cancel and submit buttons
            if (state == FormStates.Delete)
            {
                cancelButton.Visible = false;
                submitButton.Visible = false;
            }
            else
            {
                // Show cancel and submit buttons in other states
                cancelButton.Visible = true;
                submitButton.Visible = true;
            }
        }
        #endregion

        #region Events
        private void EmployeeListingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            listFormClosed = true;
        }
        
        private void EmployeeListingForm_Load(object sender, EventArgs e)
        {
            employeeListView.View = View.Details;
        }

        private void EmployeeListingForm_Activated(object sender, EventArgs e)
        {
            employeeListView.View = View.Details;
        }
        #endregion

        #region ListView set up
        public void setUpEmployeeListView()
        {
            ListViewItem employeeDetails;
            HeadWaiter headW;
            Waiter waiter;
            Runner runner;
            employeeListView.Clear();

            employeeListView.Columns.Insert(0, "ID", 120, HorizontalAlignment.Left);
            employeeListView.Columns.Insert(1, "EMPID", 120, HorizontalAlignment.Left);
            employeeListView.Columns.Insert(2, "Name", 120, HorizontalAlignment.Left);
            employeeListView.Columns.Insert(3, "Phone", 120, HorizontalAlignment.Left);


            switch (roleValue)
            {
                case Role.RoleType.NoRole:
                    employees = employeeController.AllEmployees; listLabel.Text = "Listing of all employees";
                    employeeListView.Columns.Insert(4, "Payment", 100, HorizontalAlignment.Center);
                    break;
                case Role.RoleType.Headwaiter:
                    //Add a FindByRole method to the EmployeeController
                    employees = employeeController.FindByRole(employeeController.AllEmployees, Role.RoleType.Headwaiter);
                    listLabel.Text = "Listing of all Headwaiters";
                    //Set Up Columns of List View
                    employeeListView.Columns.Insert(4, "Salary", 100, HorizontalAlignment.Center);
                    break;
                case Role.RoleType.Waiter:
                    //Add a FindByRole method to the EmployeeController
                    employees = employeeController.FindByRole(employeeController.AllEmployees, Role.RoleType.Waiter);
                    listLabel.Text = "Listing of all Waiters";
                    //Set Up Columns of List View
                    employeeListView.Columns.Insert(4, "DayRate", 100, HorizontalAlignment.Center);
                    employeeListView.Columns.Insert(5, "NoOfShifts", 100, HorizontalAlignment.Center);
                    employeeListView.Columns.Insert(6, "Tips", 100, HorizontalAlignment.Center);
                    break;

                case Role.RoleType.Runner:
                    //Add a FindByRole method to the EmployeeController
                    employees = employeeController.FindByRole(employeeController.AllEmployees, Role.RoleType.Runner);
                    listLabel.Text = "Listing of all Runners";
                    //Set Up Columns of List View
                    employeeListView.Columns.Insert(4, "DayRate", 100, HorizontalAlignment.Center);
                    employeeListView.Columns.Insert(5, "NoOfShifts", 100, HorizontalAlignment.Center);
                    employeeListView.Columns.Insert(6, "Tips", 100, HorizontalAlignment.Center);
                    break;
            }




            foreach (Employee employee in employees)
            {
                employeeDetails = new ListViewItem();
                employeeDetails.Text = employee.ID.ToString();
                employeeDetails.SubItems.Add(employee.EmployeeID.ToString());
                employeeDetails.SubItems.Add(employee.Name.ToString());
                employeeDetails.SubItems.Add(employee.Telephone.ToString());
                // Do the same for EmpID, Name and Phone
                switch (employee.role.getRoleValue)
                {
                    case Role.RoleType.Headwaiter:
                        headW = (HeadWaiter)employee.role;
                        employeeDetails.SubItems.Add(headW.SalaryAmount.ToString());
                        break;
                    case Role.RoleType.Waiter:
                        waiter = (Waiter)employee.role;
                        employeeDetails.SubItems.Add(waiter.getRate.ToString());
                        employeeDetails.SubItems.Add(waiter.getShifts.ToString());
                        employeeDetails.SubItems.Add(waiter.getTips.ToString());
                        break;
                    case Role.RoleType.Runner:
                        runner = (Runner)employee.role;
                        employeeDetails.SubItems.Add(runner.getRate.ToString());
                        employeeDetails.SubItems.Add(runner.getShifts.ToString());
                        employeeDetails.SubItems.Add(runner.getTips.ToString());
                        break;

                }

                employeeListView.Items.Add(employeeDetails);


            }

            employeeListView.Refresh();
            employeeListView.GridLines = true;
        }
        #endregion

        #region Search Method
        // Populates textboxes with employee details
        private void PopulateTextBoxes(Employee employee)
        {
            // Populate general fields
            idTextBox.Text = employee.ID;
            empIdTextBox.Text = employee.EmployeeID;
            nameTextBox.Text = employee.Name;
            phoneTextBox.Text = employee.Telephone;

            // Role-specific fields
            switch (employee.role.getRoleValue)
            {
                case Role.RoleType.Headwaiter:
                    HeadWaiter headW = (HeadWaiter)employee.role;
                    paymentTextBox.Text = headW.SalaryAmount.ToString();
                    break;
                case Role.RoleType.Waiter:
                    Waiter waiter = (Waiter)employee.role;
                    paymentTextBox.Text = (waiter.getRate).ToString();
                    shiftsTextBox.Text = waiter.getShifts.ToString();
                    break;
                case Role.RoleType.Runner:
                    Runner runner = (Runner)employee.role;
                    paymentTextBox.Text = runner.getRate.ToString();
                    shiftsTextBox.Text = runner.getShifts.ToString();
                    break;
            }
        }
        #endregion

        #region Event Handler
        private void employeeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (employeeListView.SelectedItems.Count > 0)
            {
                // Show all controls for the selected role
                ShowAll(true, Role.RoleType.Headwaiter);

                // Set form state to View
                state = FormStates.View;

                // Disable entries to prevent editing
                EnableEntries(false);

                // Find the selected employee
                employee = employeeController.Find(employeeListView.SelectedItems[0].Text);

                // Populate textboxes with employee data
                PopulateTextBoxes(employee);
            }
        }
        #endregion

        private void listLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void empIdlabel_Click(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            state = FormStates.Edit; // Set the form state to Edit
            EnableEntries(true); // Enable form controls for editing
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            PopulateTextBoxes(employee); // Populate the current employee object from form inputs

            if (state == FormStates.Edit)
            {
                employeeController.DataMaintenance(employee, DB.DBOperation.Edit);
            }
            else if (state == FormStates.Add)
            {
                employeeController.DataMaintenance(employee, DB.DBOperation.Add);
            }
            
            // FinalizeChanges(); // Finalize and apply changes
            ClearAll(); // Clear all form input fields
            state = FormStates.View; // Set form state back to View
            EnableEntries(false); // Disable form controls for editing
        }
    }
}
