namespace Platform.Service.Dtos
{
    // This class is used to read a platform
    public class PlatformReadDto
    {        
        public int Id { get; set; }

        public string Name { get; set; }
   
        public string Publisher { get; set; }
        
        public string Cost { get; set; }
    }
}