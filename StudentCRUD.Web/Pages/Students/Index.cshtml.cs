using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentCRUD.Web.Models;
using StudentCRUD.Web.StudentDBContext;

namespace StudentCRUD.Web.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly StudentDbContext db;
        public IndexModel(StudentDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Student> Students { get; set; }

        public void OnGet()
        {
            Students = db.Students;
        }
    }
}
