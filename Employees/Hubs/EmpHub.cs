using Employees.Models;
using Microsoft.AspNetCore.SignalR;

namespace Employees.Hubs
{
    public class EmpHub : Hub
    {
        SignalREmployeesContext db;

        public EmpHub( SignalREmployeesContext _db)
        {
            this.db = _db;
        }
        public void DisplayEmpData(Models.Employees emp)
        {
            Clients.All.SendAsync("NewEmpAdded",emp);

            db.Employees.Add(emp);
            db.SaveChanges();
            
        }
    }
}
