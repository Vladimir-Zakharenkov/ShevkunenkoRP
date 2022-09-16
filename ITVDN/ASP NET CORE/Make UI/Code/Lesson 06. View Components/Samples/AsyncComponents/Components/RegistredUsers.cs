using AsyncComponents.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncComponents.Components
{
    public class RegistredUsers : ViewComponent
    {
        private readonly UserService service;

        public RegistredUsers(UserService service)
        {
            this.service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<User> users = await service.GetUsersAsync();
            return View(users);
        }
    }
}
