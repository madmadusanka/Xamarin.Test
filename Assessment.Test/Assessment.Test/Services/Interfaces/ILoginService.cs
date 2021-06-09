using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Test.Services.Interfaces
{
    public interface ILoginService
    {
        bool login(string userName, string password);
    }
}
