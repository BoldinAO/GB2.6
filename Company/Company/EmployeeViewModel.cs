using Company.DTO;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using System.Linq;
using System.Collections.Generic;

namespace Company
{
    class EmployeeViewModel : INotifyPropertyChanged
    {
        private readonly CollectionView workers;
        private string employee;
        ObservableCollection<WorkerDTO> list;

        public EmployeeViewModel()
        {
            list = new ObservableCollection<WorkerDTO>();
            list.Add(new WorkerDTO() { Name = "Имя1", SecondName = "Отчество1", SurName = "Фамилия1" });
            list.Add(new WorkerDTO() { Name = "Имя2", SecondName = "Отчество2", SurName = "Фамилия2" });
            workers = new CollectionView(list);
        }

        public string Department
        {
            get { return employee; }
            set
            {
                if (employee == value) return;
                employee = value;
            }
        }

        public CollectionView Workers
        {
            get { return workers; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void AddWorker(string surname, string name, string secondname)
        {
            list.Add(new WorkerDTO() { Name = name, SecondName = secondname, SurName = surname });
        }

        public void ChangeEmployeeData(object Id, string surname, string name, string secondname)
        {
            var id = (WorkerDTO)Id;
            if(list.Contains(id))

        }
    }
}
