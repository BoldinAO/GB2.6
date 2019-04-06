namespace Company.DTO
{
    class WorkerDTO
    {
        //Id департамента
        public int Id { get; }
        //Имя сотрудника
        public string Name { get; set; }
        //Фамилия сотрудника
        public string SurName { get; set; }
        //Отчество сотрудника
        public string SecondName { get; set; }
    }
}
