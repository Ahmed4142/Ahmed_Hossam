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
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace p_tasks
{
  
    public partial class user_management : Window
    {
        taskEntities1 taskEntities = new taskEntities1();
        task selected = new task();
        user user = new user();
        public user_management()
        {
            InitializeComponent();
            loadcmbstatuss();
            load();
        }

        private void loadcmbstatuss()
        {
            cmbstatus.ItemsSource = taskEntities.tasks.ToList();
        }
        private void load()
        {
            dgmange.ItemsSource = taskEntities.tasks.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            task task = new task
            {
                task_id = int.Parse(taskidtxt.Text),
                users_id = int.Parse(empnametxt.Text),
                title = title.Text,
                descriptions = destxt.Text,
                statues = cmbstatus.Text,
                duedate = DateTime.Now
            };
            taskEntities.tasks.Add(task);
            taskEntities.SaveChanges();
            load();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            selected.task_id = int.Parse(taskidtxt.Text);
            selected.users_id = int.Parse(empnametxt.Text);
            selected.title = title.Text;
            selected.descriptions = destxt.Text;
            selected.statues = cmbstatus.Text;
            selected.duedate = DateTime.Now;
            load();
        }

        private void dgmange_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgmange.SelectedItem is task t)
            {
                selected = t;
                taskidtxt.Text = selected.task_id.ToString();
                empnametxt.Text = selected.users_id.ToString();
                title.Text = selected.title;
                destxt.Text = selected.descriptions;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            taskEntities.tasks.Remove(selected);
            taskEntities.SaveChanges();
            load();
        }
    }
}
