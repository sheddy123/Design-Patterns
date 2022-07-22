using Creational_Patterns.Singleton_Pattern.Models;
using Logger;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace Creational_Patterns.Singleton_Pattern
{
    /*
     * SINGLETON PATTERN
     * Singleton Pattern belongs to Creational Type pattern.
     * 
     * This pattern is used when we need to ensure that only one object of a particular class need
     * to be created. All further refrences to the objects are referred to the same underlying
     * instance created.
     * 
     * ClientObj A              ClientObj B             ClientObj C
     *  \                           |                       /
     *                          Singleton Object
     *                              |
     *                            Task
     */


    /*
     * ADVANTAGES OF SINGLETON
     * - Singleton controls concurrent access to the resource
     * - It ensures there is only one object available across the application in a controlled state.
     * 
     * IMPLEMENTATION GUIDELINES
     * - Ensure that only one instance of the class exists
     * - Provide global access to that instance by
     *      -   Declaring all constructors of the class to be private
     *      -   Providing static method that returns a reference to the instance
     *      -   The instance is stored as a private static variable
     */
    public class EmployeeController : Controller
    {
        private ILog _logger;
        private static List<Employee> addEmployees = new List<Employee>();
        public EmployeeController()
        {
            this._logger = Log.GetInstance;
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            this._logger.LogException(filterContext.Exception.ToString());
            filterContext.ExceptionHandled = true;
            this.View("Error").ExecuteResult(this.ControllerContext);
        }

        public void AddEmployee(Employee _employee)
        {
            addEmployees.Add(_employee);
            Console.WriteLine("Employee with ID: {0} added", _employee.Id);

            ExceptionContext exc = new ExceptionContext();
            exc.Exception = new Exception("An error occured");
            OnException(exc);
        }
    }
}
