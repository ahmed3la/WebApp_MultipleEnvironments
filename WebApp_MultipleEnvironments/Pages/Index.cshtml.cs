using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_MultipleEnvironments.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IOptions<MyConfig> config;
        private readonly IOptions<Test> Test;

        [BindProperty]
        public string ApplicationName { get; set; }
        [BindProperty]
        public string Test_ApplicationName { get; set; }
        public IndexModel(ILogger<IndexModel> logger, IOptions<MyConfig> config, IOptions<Test> test)
        {
            _logger = logger;
            this.config = config;
            Test = test;
        }

        public IActionResult OnGet()
        {
            ApplicationName= config.Value.ApplicationName;



            Test_ApplicationName = Test.Value.ApplicationName;
            return Page();
        }
    }
}
