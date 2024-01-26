namespace SG.Api.Models.Interfaces
{
    public interface IAccount_Transaction
    {

        int transaction_id { get; set; }
        int account_id { get; set; }
        int trans_type { get; set; }
        DateTime trans_date { get; set; }
        decimal amount { get; set; }


    }
}
