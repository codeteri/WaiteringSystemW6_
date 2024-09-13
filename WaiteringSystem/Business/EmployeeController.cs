using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaiteringSystem.Data;

namespace WaiteringSystem.Business
{

    public class EmployeeController
    {
        #region Data Members
        EmployeeDB employeeDB;
        Collection<Employee> employees;
        #endregion

        #region Properties
        public Collection<Employee> AllEmployees
        {
            get
            {
                return employees;
            }
        }
        #endregion

        #region Constructor
        public EmployeeController()
        {
            //***instantiate the EmployeeDB object to communicate with the database
            employeeDB = new EmployeeDB();
            employees = employeeDB.AllEmployees;
        }
        #endregion

        #region Database Communication.
        // Method to handle maintenance operations on the employee list
        public void DataMaintenance(Employee anEmp, DB.DBOperation operation)
        {
            int index = 0;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    employees.Add(anEmp);
                    break;

                case DB.DBOperation.Edit:
                    index = FindIndex(anEmp);
                    if (index >= 0)
                    {
                        employees[index] = anEmp;
                    }
                    break;

                case DB.DBOperation.Delete:
                    index = FindIndex(anEmp);
                    if (index >= 0)
                    {
                        employees.RemoveAt(index);
                    }
                    break;
            }

            // Update the dataset accordingly
            employeeDB.DataSetChange(anEmp, "HeadWaiter", "Waiter", "Runner", operation);
        }

        //***Commit the changes to the database
        public bool FinalizeChanges(Employee employee)
        {
            //***call the EmployeeDB method that will commit the changes to the database
            return employeeDB.UpdateDataSource(employee);
        }
        #endregion

        #region Search

        public Collection<Employee> FindByRole(Collection<Employee> emps, Role.RoleType roleVal)
        {
            Collection<Employee> matches = new Collection<Employee>();
            foreach (Employee emp in emps)
            {
                if (emp.role.getRoleValue == roleVal)
                {
                    matches.Add(emp);
                }
            }
            return matches;
        }

        // Finds the employee based on ID in EmployeeController
        public Employee Find(string ID)
        {
            // Declare and initialize required variables
            int index = 0;
            bool found = (employees[index].ID == ID);
            int count = employees.Count;

            // Loop through the collection until the employee is found
            while ((!(found) && (index < employees.Count - 1)))
            {
                index++;
                found = (employees[index].ID == ID);
            }

            // Return the found employee or null if not found
            return found ? employees[index] : null;
        }

        // 3.1.1 Method header for FindIndex
        private int FindIndex(Employee anEmp)
        {
            int counter = 0;
            bool found = (anEmp.ID == employees[counter].ID);

            // 3.1.2 Loop until the employee is found or the end of the collection is reached
            while (!found && counter < employees.Count - 1)
            {
                // 3.1.3 Increment counter
                counter++;
                found = (anEmp.ID == employees[counter].ID);
            }

            // Return the index if found; otherwise, -1
            return found ? counter : -1;
        }


        #endregion

    }
}
