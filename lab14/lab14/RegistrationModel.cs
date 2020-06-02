﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14
{
    public class RegistrationModel : INotifyPropertyChanged
    {
        private string _email;

        public string Email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Email)));
                }
            }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Password)));
                }
            }
        }

        private bool _accept;

        public bool Accept
        {
            get { return _accept; }
            set
            {
                if (_accept != value)
                {
                    _accept = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Accept)));
                }
            }
        }

        private string _errors;

        public string Errors
        {
            get { return _errors; }
            set
            {
                if (_errors != value)
                {
                    _errors = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Errors)));
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
