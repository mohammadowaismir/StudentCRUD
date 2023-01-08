using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentCRUD.Web.Models;
using StudentCRUD.Web.StudentDBContext;

namespace StudentCRUD.Web.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly StudentDbContext db;

        public CreateModel(StudentDbContext db)
        {
            this.db = db;
        }

        [BindProperty]
        public Student Student { get; set; }
        public void OnGet()
        {
        }

        public PageResult OnPost() 
        {
            db.Students.Add(Student);
            db.SaveChanges();

            return Page("Index");
        }
    }
}
