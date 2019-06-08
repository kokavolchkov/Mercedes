using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.PageObjects
{
    /// <summary>
    /// UserCredentials class
    /// Describes data that user sends to the Support Page field
    /// </summary>
    public class UserCredentials
    {
        public String EmailAddress { get; set; }
        public String Subject { get; set; }
        public String Description { get; set; }
        public String AccountType { get; set; }
        public String Platform { get; set; }
        public String WindowsVersion { get; set; }
        public String WireForWindows { get; set; }
        public String BrowserName { get; set; }

    }
}
