using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace FormValidation.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public string? RecaptchaToken {  get; set; }
        [BindProperty]
        [Required(ErrorMessage ="naam chaihiye bhai !")]
        public string FirstName { get; set; } = "";
        [BindProperty]
        [Required(ErrorMessage = "naam chaihiye bhai !")]
        public string LastName { get; set; } = "";
        [BindProperty]
        [Required(ErrorMessage = "Enter Email")]
        public string Email { get; set; } = "";
        [BindProperty]
        public string? Phone { get; set; } = "";
        [BindProperty]
        [Required(ErrorMessage = "Subject req")]
        public string Subject { get; set; } = "";
        [BindProperty]
        [Required(ErrorMessage = "MAsg req")]
        public string Message { get; set; } = "";


        public string successMessage = "";
        public string errorMessage = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                errorMessage = " Data validation failed";
                return;

            }

            if(RecaptchaToken == null)
            {
                errorMessage = "RecaptchaToken missing";
                return;
            }
            Console.WriteLine("We got the token:" +  RecaptchaToken);

            successMessage = " Data received successfully!";

            FirstName = "";
            LastName = "";
            Email = "";
            Phone = "";
            Subject = "";
            Message = "";

            ModelState.Clear();
        }
    }
}
