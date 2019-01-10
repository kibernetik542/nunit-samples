﻿using System.Data.Entity;

namespace UdemyTestProject.Mocking
{
    public class EmployeeController
    {
        private readonly IEmployeeStorage _storage;

        public EmployeeController(IEmployeeStorage storage)
        {
            _storage = storage;
        }

        public ActionResult DeleteEmployee(int id)
        {
            _storage.DeleteEmployee(id);
            return RedirectToAction("Employees");
        }

        private ActionResult RedirectToAction(string employees) => new RedirectResult();

    }
    public class ActionResult { }
    public class RedirectResult : ActionResult { }
    public class EmployeeeContext
    {
        public DbSet<Employee> Employees { get; set; }
        public void SaveChanges() { }
    }
    public class Employee { }
}