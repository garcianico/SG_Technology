using System.ComponentModel.DataAnnotations;

namespace SG.Web.Models.ViewModels
{
    public class AccountViewModel
    {

        public int account_id { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
        public decimal balance { get; set; }


    }
}
