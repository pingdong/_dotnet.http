namespace PingDong.Http
{
    /// <summary>
    /// Response
    /// </summary>
    public class JsonResponseBase
    {
        /// <summary>
        /// If the request processes success
        /// </summary>
        public virtual bool Success { get; set; }
    }
}
