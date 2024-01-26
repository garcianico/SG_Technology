using System.ComponentModel.DataAnnotations;

namespace Account_Management.Models.ViewModels
{
    public class Account_TransactionViewModel
    {


        public int transaction_id { get; set; }
        public int account_id { get; set; }
        public int trans_type { get; set; }
        public DateTime trans_date { get; set; }
        public decimal amount { get; set; }


    }
}
