using Speedcoding.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rep = Speedcoding.MVC.Repository;

namespace Speedcoding.MVC.Helpers
{
    /// <summary>
    /// This class makes the call to the API.
    /// Currently, in the absence of API, it is making a call to the
    /// Repository class which is a mock API.
    /// Ideally, this single call is broken into multiple calls and the data is assembled
    /// and processed in this class.
    /// </summary>
    public class ApiHelper
    {
        public Person Get()
        {
            Rep.Repository rep = new Repository.Repository();
            Person person = rep.GetPerson();
            return person;
        }
    }
}