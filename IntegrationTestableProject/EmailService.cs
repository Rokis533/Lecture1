using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTestableProject
{
    public interface IEmailService
    {
        public bool SendEmail(string msg);
    }

    public class EmailService : IEmailService
    {
        public bool SendEmail(string msg)
        {
            if (string.IsNullOrEmpty(msg))
            {
                // emailProvider.SendEmail(msg)
                Console.WriteLine("Failed to send");
                return false;
            }
            else
            {
                Console.WriteLine("Succesfully sended");
                return true;
            }

        }
    }
}
