using System.ComponentModel.DataAnnotations;

namespace TestWeb.Models
{
    public class BmiModel
    {
        [Required]
        [Range(1, 250, ErrorMessage = "Vazn 1 dan 250 kg gacha bo'lishi kerak.")]
        public double Weight { get; set; } // Vazn (kg)

        [Required]
        [Range(1, 250, ErrorMessage = "Bo'y 1 dan 250 sm gacha bo'lishi kerak.")]
        public double Height { get; set; } // Bo'y (sm)

        public double Bmi => CalculateBmi(); // BMI hisoblash uchun xususiyat

        private double CalculateBmi()
        {
            double heightInMeters = Height / 100;
            return Weight / (heightInMeters * heightInMeters);
        }
    }
}
