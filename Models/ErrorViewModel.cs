namespace pursify.Models
{
    public class ErrorViewModel
    {
        public decimal? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
