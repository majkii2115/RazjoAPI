namespace API.DTOs
{
    public class ReturnCalendarNoteDTO
    {
        public string UserId { get; set; }
        public string UserRole { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string Message { get; set; }
    }
}