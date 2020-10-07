using System;
using System.Collections.Generic;
using System.Text;

namespace LocalChat
{
    public class UserLogin<T>
    {
        public T Password { get; set; }
        public T Email { get; set; }

        public UserLogin(T password, T email)
        {
            Password = password;
            Email = email;
        }
    }
}
