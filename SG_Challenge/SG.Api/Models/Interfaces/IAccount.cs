namespace SG.Api.Models.Interfaces
{
    public interface IAccount
    {

        int account_id { get; set; }
        string user_name { get; set; }
        string password { get; set; }
        //decimal balance { get; set; }

    }
}
