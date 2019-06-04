namespace PingDong.Http
{
    /// <summary>
    /// Response
    /// </summary>
    public class JsonErrorResponse : JsonResponseBase
    {
        /// <summary>
        /// Error
        /// </summary>
        public JsonError Error { get; set; }

        public override bool Success
        {
            get => IsSuccess;
            set { }
        }
        private const bool IsSuccess = false;
    }
}
