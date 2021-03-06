using System.Collections.Generic;

namespace API.DTOs
{
    public class ReturnUserDTO
    {
        public string Token { get; set; }
        public UserInfoDTO UserInfo { get; set; }
        public List<ReturnPrivateNoteDTO> PrivateNotes { get; set; }
        public List<ReturnFamilyDTO> Families { get; set; }
    }
}