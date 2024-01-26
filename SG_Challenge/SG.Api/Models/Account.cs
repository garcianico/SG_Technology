using System.ComponentModel.DataAnnotations;
using SG.Api.Models.Interfaces;

namespace SG.Api.Models
{
    public class Account : IAccount
    {

        [Key]
        public int account_id { get; set; }

        [Required(ErrorMessage = "El campo es requerido.")]
        public string user_name { get; set; }

        public string password { get; set; }


    }
}
