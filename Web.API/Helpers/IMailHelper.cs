

using Common.Models;

namespace Web.API.Helpers
{
    public interface IMailHelper
    {
       
            Response SendMail(string to, string subject, string body);
        }
    }

