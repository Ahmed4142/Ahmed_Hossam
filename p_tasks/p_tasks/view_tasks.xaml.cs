using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace p_tasks
{
    
    public partial class view_tasks : Window
    {
        taskEntities1 taskEntities = new taskEntities1();
        task selected = new task();
        public string name;
        public view_tasks(string name1)
        {
            name = name1;
            InitializeComponent();
            nameemp.Content = $"{name}";
            load1();
            load2();
            loadcmbstatus();
        }

        private void dgtasksfrist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgtasksfrist.SelectedItem is task t)
            {
                selected = t;
                taskidtxt.Text = t.task_id.ToString();
            }

        }


        private void load1()
        {
            dgtasksfrist.ItemsSource = taskEntities.tasks.Where(s => s.statues == "Pending" || s.statues == "In Progress").ToList();
        }
        private void load2()
        {
            dgtasksend.ItemsSource = taskEntities.tasks.Where(s => s.statues == "Completed").ToList();
        }

        private void loadcmbstatus()
        {
            cmbstatus.ItemsSource = taskEntities.tasks.Where(s => s.statues == "Completed").ToList();
        }



        private void save_update_Click(object sender, RoutedEventArgs e)
        {
            selected.task_id = int.Parse(taskidtxt.Text);
            selected.statues = cmbstatus.Text;
            taskEntities.SaveChanges();
            load1();
            load2();
        }
    }
}
