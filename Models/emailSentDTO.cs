namespace ItFoto.Models
{
    public class emailSentDTO
    {
        public string? Name { get; set; }
        public required string Email { get; set; }
        public required string Description { get; set; }
        
        public void viewObject()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Email);
            Console.WriteLine(Description);
        }
    }
}
