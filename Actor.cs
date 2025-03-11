﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectCinemaCenterOOP
{
    public class Actor
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        private string surname;

        public string Surname
        {
            get { return surname; }
            set { this.surname = value; }
        }

        private int yearwork;

        public int Yearwork
        {
            get { return yearwork; }
            set { this.yearwork = value; }
        }

        private string phone;

        public string Phone
        {
            get { return phone; }
            set { this.phone = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { this.email = value; }
        }

        public Actor(string name, string surname, int yearwork, string phone, string email)
        {
            Name = name;
            Surname = surname;
            Yearwork = yearwork;
            Phone = phone;
            Email = email;
        }
    }
}
