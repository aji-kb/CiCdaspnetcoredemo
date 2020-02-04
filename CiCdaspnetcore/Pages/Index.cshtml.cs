using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cicdaspnetcoredemo.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CiCdaspnetcore.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IUserService userService;

        public List<User> Users { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IUserService userService)
        {
            _logger = logger;
            this.userService = userService;
        }

        public void OnGet()
        {
            Users = this.userService.GetUsers();
        }
    }
}
