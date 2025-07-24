namespace EfMvcDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        
        public string Name { get; set; } = string.Empty; // избегаем nullable warning
        public int Age { get; set; }
    }
}
