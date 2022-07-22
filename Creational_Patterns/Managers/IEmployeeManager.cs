using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Patterns.Managers
{
    public interface IEmployeeManager
    {
        decimal GetBonus();
        decimal GetPay();
    }
}
