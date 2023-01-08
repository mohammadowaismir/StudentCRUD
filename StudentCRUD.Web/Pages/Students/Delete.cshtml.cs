using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentCRUD.Web.StudentDBContext;

namespace StudentCRUD.Web.Pages.Students
{
    public class DeleteModel : PageModel
    {
        private readonly StudentDbContext db;

        public DeleteModel(StudentDbContext db)
        {
            this.db = db;
        }
        public IActionResult OnGet(Guid id)
        {
            db.Remove(db.Students.Where(x => x.Id == id).FirstOrDefault());
            db.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}
