using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AllExpirience.Models
{
    public class Help
    {
        public int HelpId { get; set; }

        [StringLength(50, MinimumLength =1, ErrorMessage ="Недопустимое количество символов для имени.")]
        [Required(ErrorMessage = "Укажите ваше имя — мы будем рады с вами познакомиться.")]
        [Display(Name="Имя")]
        public string Name { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Недопустимое количество символов для фамилии.")]
        [Required(ErrorMessage = "Укажите вашу фамилию — мы вас ни с кем не перепутаем.")]
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Укажите номер вашего телефона — мы сможем вам перезвонить.")]
        [Display(Name = "Телефон")]
        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Укажите ваш email — мы сможем вам написать.")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [StringLength(255, MinimumLength = 1, ErrorMessage = "Недопустимое количество символов для сопроводительного письма.")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Укажите причину по который вы обращаетесь.")]
        [Display(Name = "Письмо")]
        public string Message { get; set; }

        [Required(ErrorMessage = "Укажите вашу страну в который проживаете.")]
        [Display(Name = "Страна")]
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}