using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchManager.Models
{
    [Table("User", Schema = "LunchManager")]

    public class User
    {
        [Key]
        [Column("User_Id")]
        public int Id { get; set; }



    }
}
