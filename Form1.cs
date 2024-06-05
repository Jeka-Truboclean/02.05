using System.ComponentModel;

namespace _02._05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            employees = new BindingList<Employee>
            {
                new Employee { Id = 1, Name = "Jotaro Kujo", Position = "Scintiest", Salary = 50000 },
                new Employee { Id = 2, Name = "Robert E. O. Speedwagon", Position = "Oil Billioner", Salary = 60000 }
            };
            dataGridViewEmployees.DataSource = employees;
            dataGridViewEmployees.Columns["Id"].ReadOnly = true;
        }

        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Position { get; set; }
            public double Salary { get; set; }
        }
        private BindingList<Employee> employees;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var newEmployee = new Employee { Id = employees.Count + 1, Name = "New employee", Position = "Work", Salary = 0 };
            employees.Add(newEmployee);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.CurrentRow != null)
            {
                employees.RemoveAt(dataGridViewEmployees.CurrentRow.Index);
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.CurrentRow != null)
            {
                dataGridViewEmployees.BeginEdit(true);
            }
        }
    }
}
