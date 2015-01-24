namespace _01.Persons
{
    public class Person
    {
        private string name;
        private byte age;
        private string email;

        #region Constructors
        public Person(string name, byte age, string email)
        {
            this.name = name;
            this.age = age;

            this.Email = email;
        }

        public Person(string name, byte age)
            :this(name, age, null)
        { }
        #endregion

        public string Email
        {
            get { return this.email; }

            set
            {
                if (value == null || value.Contains("@"))
                {
                    this.email = value;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("name: {0}\nage: {1}\nemail: {2}",
                this.name, this.age, this.email);
        }
    }
}
