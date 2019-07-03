using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelogram
{
    /// <summary>
    /// Defines Employees who work in the hotel.
    /// </summary>
    public class Employee : Person
    {
        /// <summary>
        /// Defines reports which are created by <see cref="Employee"/>s for information purposes.
        /// </summary>
        public class Report
        {
            #region Fields
            private static int _currentID = 1;  //Automatic ID assigner counter.
            private Employee _owner;    //The owner employee of the report.
            private int _id;    //The ID of the report.
            private string _report; //The description of the report.
            private static List<Report> _reports = new List<Report>();  //The list that holds all created reports.
            #endregion

            #region Properties
            /// <summary>
            /// Gets the owner employee of the report.
            /// </summary>
            public Employee Owner
            {
                get
                {
                    return _owner;
                }
                private set
                {
                    _owner = value;
                }
            }

            /// <summary>
            /// Gets the list which all reports are hold.
            /// </summary>
            public static List<Report> AllReports
            {
                get
                {
                    return _reports;
                }
            }

            /// <summary>
            /// Gets the report ID.
            /// </summary>
            public int ID
            {
                get
                {
                    return _id;
                }
                private set
                {
                    _id = value;
                }
            }

            /// <summary>
            /// Gets the report details.
            /// </summary>
            public string report
            {
                get
                {
                    return _report;
                }
                private set
                {
                    _report = value;
                }
            }
            #endregion

            #region Constructors

            /// <summary>
            /// Creates a report with the specified owner employee and description.
            /// </summary>
            /// <param name="owner">The owner employee of the report.</param>
            /// <param name="report">The description of the report.</param>
            public Report(Employee owner, string report)
            {
                ID = _currentID;
                Owner = owner;
                this.report = report;
                _currentID++;
                owner.Reports.Add(this);
                AllReports.Add(this);
            }
            #endregion

            #region Methods
            /// <summary>
            /// Searches the reports for the specified ID.
            /// </summary>
            /// <param name="id">The ID to be searched.</param>
            /// <returns>Returns the report if one with the specified ID is found, otherwise returns null.</returns>
            public static Report getReportByID(int id)
            {
                foreach (Report r in _reports)
                {
                    if (r.ID == id) return r;
                }
                return null;
            }
            #endregion
        }

        #region Fields
        private static int currentID = 1;   //Automatic ID assigner counter.
        private int _id;    //The ID of the employee.
        private string _job;    //The job of the employee.
        private List<Day> _workingDays = new List<Day>();   //The working days list of the employee.
        private Time[] _workingHours = new Time[2];  //The working hours array of the employee. [0] means beginning, [1] means end of the working hours.
        private float _salary;  //The salary of the employee.
        private List<Report> _actions = new List<Report>(); //The list which holds all reports of the employee.
        private static List<Employee> _employees = new List<Employee>();    //The list which holds all employees.
        #endregion

        #region Properties
        /// <summary>
        /// Gets the list which holds all employees.
        /// </summary>
        public static List<Employee> AllEmployees
        {
            get
            {
                return _employees;
            }
        }

        /// <summary>
        /// Gets the employee's ID.
        /// </summary>
        public int ID
        {
            get
            {
                return _id;
            }
            private set
            {
                _id = value;
            }
        }

        /// <summary>
        /// Gets or sets the employee's current department.
        /// </summary>
        public string Job
        {
            get
            {
                return _job;
            }
            set
            {
                _job = value;
            }
        }

        /// <summary>
        /// Gets or sets the employee's working days.
        /// </summary>
        public List<Day> WorkingDays
        {
            get
            {
                return _workingDays;
            }
            set
            {
                _workingDays = value;
            }
        }

        /// <summary>
        /// Gets or sets the beginning of the employee's working hours.
        /// </summary>
        public Time WorkingHourStart
        {
            get
            {
                return _workingHours[0];
            }
            set
            {
                _workingHours[0] = value;
            }
        }

        /// <summary>
        /// Gets or sets the end of the employee's working hours.
        /// </summary>
        public Time WorkingHourEnd
        {
            get
            {
                return _workingHours[1];
            }
            set
            {
                _workingHours[1] = value;
            }
        }

        /// <summary>
        /// Gets or sets the salary of the employee.
        /// </summary>
        public float Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value;
            }
        }

        /// <summary>
        /// Gets the list which holds all reports of the employee.
        /// </summary>
        public List<Report> Reports
        {
            get
            {
                return _actions;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Creates an employee.
        /// </summary>
        /// <param name="tcid">The T.C. ID of the employee.</param>
        /// <param name="name">The name of the employee.</param>
        /// <param name="address">The address of the employee.</param>
        /// <param name="gsmNumber">The GSM number of the employee.</param>
        /// <param name="job">The department of the employee.</param>
        /// <param name="workingDays">The working days of the employee.</param>
        /// <param name="workingHourStart">The beginning of the working hours of the employee.</param>
        /// <param name="workingHourEnd">The end of the working hours of the employee.</param>
        /// <param name="salary">The salary of the employee.</param>
        public Employee(long tcid, string name, string address, string gsmNumber, string job, Day[] workingDays, Time workingHourStart, Time workingHourEnd, float salary) : base(tcid, name, address, gsmNumber)
        {
            ID = currentID;
            TCID = tcid;
            Name = name;
            Address = address;
            GSMNumber = gsmNumber;
            Job = job;
            Salary = salary;
            
            foreach(var d in workingDays)
                _workingDays.Add(d);

            _workingHours[0] = workingHourStart;
            _workingHours[1] = workingHourEnd;

            _employees.Add(this);
            currentID++;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Searches the employees list for the specified ID.
        /// </summary>
        /// <param name="id">The ID to be searched.</param>
        /// <returns>Returns the employee if one with the specified ID is found, otherwise returns null.</returns>
        public static Employee getEmployeeByID(int id)
        {
            foreach (Employee e in _employees)
            {
                if (e.ID == id)
                {
                    return e; 
                }
            }
            return null;
        }

        /// <summary>
        /// Adds the specified report to the employee's reports list.
        /// </summary>
        /// <param name="action">The report to be added to the employee's reports list.</param>
        public void addAction(Report action)
        {
            _actions.Add(action);
        }
        #endregion
    }
}
