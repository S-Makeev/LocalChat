using System;
using System.Collections.Generic;
using System.Text;

namespace LocalChat
{
    class AdmLogin<T> : UserLogin<T>
    {
        public AdmLogin(T password, T email) : base(password, email)
        {
            //find user, manipulate their password/email information
        }
    }
}
