namespace HW3_3
{
    /// <summary>
    /// Класс персона для записи имени и Email Адреса из файла
    /// </summary>
    class Person
    {
        private string _name;
        private string _email;
        public string Name { get { return _name; } set { _name = value; } }
        public string Email { get { return _email; } set { _email = value; } }

        public Person(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
