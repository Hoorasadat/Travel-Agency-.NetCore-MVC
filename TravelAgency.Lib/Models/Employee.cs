using System;
using System.Collections.Generic;

namespace TravelAgency.Lib.Models;

public partial class Employee
{
    public string EmpFirstName { get; set; } = null!;

    public string? EmpMiddleInitial { get; set; }

    public string EmpLastName { get; set; } = null!;

    public string EmpBusPhone { get; set; } = null!;

    public string EmpEmail { get; set; } = null!;

    public string EmpPosition { get; set; } = null!;
}
