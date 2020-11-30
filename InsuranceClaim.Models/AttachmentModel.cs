using System.IO;

namespace InsuranceClaim.Models
{
    public class AttachmentModel
    {
        public Stream Attachment { get; set; }
        public string Name { get; set; }
    }
}
