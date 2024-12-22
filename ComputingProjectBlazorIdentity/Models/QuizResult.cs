using ComputingProjectBlazorIdentity.Data;

namespace ComputingProjectBlazorIdentity.Models
{
    public class QuizResult
    {
        public int Id { get; set; } // Primary key
        public string UserId { get; set; } // Foreign key
        public DateTime Date { get; set; }
        public int Score { get; set; }
    }
}
