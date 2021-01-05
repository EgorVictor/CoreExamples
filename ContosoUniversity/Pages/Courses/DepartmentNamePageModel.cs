using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Pages.Courses
{
    public class DepartmentNamePageModel : PageModel
    {
        public SelectList DepartmentNameSL { get; set; }

        public void PopulateDepartmentsDropDownList(SchoolContext context, object selectedDepartment = null)
        {
            var orderedQueryable = from d in context.Departments
                                   orderby d.Name
                                   select d;
            //创建 SelectList 以包含系名称列表
            DepartmentNameSL =
                new SelectList(orderedQueryable.AsNoTracking(), "DepartmentID", "Name", selectedDepartment);
        }
    }
}
