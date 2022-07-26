﻿using Creational_Patterns.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Patterns.Factory_Pattern
{
    /*
     * Define an interface for creating an object, but let subclasses decide which classes
     * to instantiate. The Factory method lets a class defer instantiation it uses
     * to subclasses
     * 
     * 
     * Factory pattern creates object without exposing the creation logic to the client and refer to 
     * newly created object using a common interface
     * 
     * Factory pattern is one of the most used design patterns in real world applications
     * 
     *  Simple/Factory Pattern
     *
     * |Client| --uses-- -------> |Factory| --creates-- --------> |Product|
     */



    /*
     *  CHOOSE FACTORY PATTERN WHEN
     *  - The object needs to be extnded to subclasses
     *  - The Classes doesn't know what exact sub-classes it has to create
     *  - The Product implementation tend to change over time and the client remains unchanged
     */

    /*
     * BUSINESS REQUIREMENT (Example)
     * Differentiate employees as permanent and contract and segregate their pay scales as well as bonus
     * based on their employees types (Achieved using simple factory)
     */

    //Simple Factory Pattern
    /*
     * - SImple factory abstracts the creation details of the product
     * - Simple factory refers to the newly created object through an interface
     * - Any type creation is handed with a change of code in the factory class and not at the client code
     */
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int employeeId)
        {
            IEmployeeManager returnValue = null;
            switch (employeeId)
            {
                case 1:
                    Console.WriteLine("Getting Permanent Employee Manager");
                    returnValue = new PermannentEmployeeManager(); break;
                case 2:
                    Console.WriteLine("Getting Contract Employee Manager");
                    returnValue = new ContractEmployeeManager(); break;
            }
            return returnValue;
        }
    }
}
