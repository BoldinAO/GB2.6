using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;

namespace Company
{
    class DepartmentViewModel
    {
        private readonly CollectionView departments;
        private string department;
        ObservableCollection<DepartmentDTO> list;

        public DepartmentViewModel()
        {
            list = new ObservableCollection<DepartmentDTO>();
            list.Add(new DepartmentDTO() { DepartName = "first" });
            list.Add(new DepartmentDTO() { DepartName = "second" });
            departments = new CollectionView(list);
        }

        public string Department
        {
            get { return department; }
            set
            {
                if (department == value) return;
                department = value;
            }
        }

        public CollectionView Departments
        {
            get { return departments; }
        }

        public void AddDepart(string name)
        {
            list.Add(new DepartmentDTO() { DepartName = name });
        }

        public void DelDepart(object department)
        {
            list.Remove((DepartmentDTO)department);
            department = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
