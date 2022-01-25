namespace Vidly.Models
{
    public class NotFoundResult
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}