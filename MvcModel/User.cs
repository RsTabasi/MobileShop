using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MvcModel
{
 
   [Table("User")]

    class User
    {
                [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
                [Key,Column("IDUser",Order = 0)]
        public Guid IDUser { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
                [Column("Lname"), Required(ErrorMessage = "وارد نمودن نام خانوادگی الزامی است")]
        public string Email { get; set; }
                [Column("Email"), Required(ErrorMessage = "وارد نمودن نام خانوادگی الزامی است")]
                [RegularExpression(@"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b")]
        public string Address { get; set; }
                [Column("Address"), Required(ErrorMessage = "وارد نمودن آدرس الزامی است")] 
        public string PostCode { get; set; }
                [Column("PostCode"), Required(ErrorMessage = "وارد نمودن کد پستی الزامی است")] 
        public string Mobile { get; set; }
                [Column("Mobile"), Required(ErrorMessage = "وارد نمودن شماره موبایل الزامی است")] 
        public string Birthdate { get; set; }
        public string Password { get; set; }
                [Column("Password"), Required(ErrorMessage = "وارد نمودن پسورد الزامی است")]
                [MaxLength(50,ErrorMessage="حداکثر طول پسورد 50 کاراکتر می باشد")]
                [MinLength(8,ErrorMessage="حداقل طول پسورد 8 کاراکتر می باشد")]
        public string City { get; set; }
                [Column("Password"), Required(ErrorMessage = "وارد نمودن شهر الزامی است")]
                [RegularExpression(@"^(?=.*[A-Z].*[A-Z])(?=.*[!@#$&*])(?=.*[0-9].*[0-9])(?=.*[a-z].*[a-z].*[a-z]).{8}$")]
        public string IP { get; set; }
        public bool IsActive { get; set; }
        public DateTime RegistrationDate { get; set; }

        public virtual Role roles { get; set; }
        public virtual ICollection<Picture> pictures { get; set; }
        public virtual ICollection<ShopDoc> shopdocs { get; set; }
        public virtual ICollection<Comment> comments { get; set; }

        public override string ToString()
        {
            return FName + " " + LName;
        }
    }
}
