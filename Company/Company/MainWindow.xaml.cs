using System.Windows;

namespace Company
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DepartmentViewModel depart = new DepartmentViewModel();
        EmployeeViewModel emoloyee = new EmployeeViewModel();
        public MainWindow()
        {
            InitializeComponent();
            departCB.DataContext = depart;
            listView.DataContext = emoloyee;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            depart.AddDepart(DepartNameTB.Text);
            DepartNameTB.Clear();
        }

        private void DelDepartBtn_Click(object sender, RoutedEventArgs e)
        {
            depart.DelDepart(departCB.SelectedItem);
        }

        private void ChangeDataEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            emoloyee.ChangeEmployeeData(listView.SelectedItem, "test", "testt", "testtt");
            
        }
    }
}
