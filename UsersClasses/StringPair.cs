﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.UsersClasses
{
    public class StringPair
    {
        private string _emailAdress;
        private string _name;
        
        public string EmailAdress
        {
            get { return _emailAdress; }
            set 
            {
                _emailAdress = String.IsNullOrWhiteSpace(value) ?
                    throw new ArgumentException(nameof(_emailAdress)) :
                    value;
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = String.IsNullOrWhiteSpace(value) ?
                    throw new ArgumentException(nameof(_name)) :
                    value;
            }
        }
        public StringPair(string emailAdress, string name)
        {
            EmailAdress = emailAdress;
            Name = name;
        }        
    }
}
