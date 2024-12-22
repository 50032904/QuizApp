using ComputingProjectBlazorIdentity.Models;
using Microsoft.AspNetCore.Identity;

namespace ComputingProjectBlazorIdentity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<QuizResult> QuizResults { get; set; }
    }

}
