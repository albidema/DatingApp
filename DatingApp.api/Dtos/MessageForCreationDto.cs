using System;

namespace DatingApp.api.Dtos
{
    public class MessageForCreationDto
    {
        public int SenderId { get; set; }
        public int RecipientId { get; set; }
        public DateTime MessageSendDate { get; set; }
        public string Content { get; set; }

        public MessageForCreationDto()
        {
            MessageSendDate = DateTime.Now;
        }
    }
}