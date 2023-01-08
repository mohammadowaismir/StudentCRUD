using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentCRUD.Web.Models;
using StudentCRUD.Web.StudentDBContext;

namespace StudentCRUD.Web.Pages.Students
{
    [BindProperties]
    public class UpdateModel : PageModel
    {
        private readonly StudentDbContext db;

        public Student Student { get; set; }

        public UpdateModel(StudentDbContext db)
        {
            this.db = db;
        }
        public void OnGet(Guid id)
        {
            Student = db.Students.Where(x => x.Id == id).FirstOrDefault();
        }

        public IActionResult OnPost() 
        { 
            db.Update(Student);
            db.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}
