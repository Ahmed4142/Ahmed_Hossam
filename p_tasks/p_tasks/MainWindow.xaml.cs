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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace p_tasks
{
   
    public partial class MainWindow : Window
    {
        taskEntities1 taskEntities = new taskEntities1();
        user useres = new user();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void login_button_click(object sender, RoutedEventArgs e)
        {
            var user = taskEntities.users.FirstOrDefault(u => u.username == usernametxt.Text && u.pass == passordtxt.Password && u.roles == "manger");
            var user1 = taskEntities.users.FirstOrDefault(u => u.username == usernametxt.Text && u.pass == passordtxt.Password && u.roles == "empolyee");
            if (user != null)
            {
                MessageBox.Show("welcome manger");
                user_management u = new user_management();
                u.Show();
                this.Close();
                return;
            }

            if (user1 != null)
            {
                MessageBox.Show("welcome empolyee");
                view_tasks view = new view_tasks(usernametxt.Text);
                view.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("invalied username or password");
            }
        }
    }
}
