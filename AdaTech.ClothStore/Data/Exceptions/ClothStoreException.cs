namespace AdaTech.ClothStore.Data.Exceptions
{
    public class ClothStoreException : Exception
    {
        public ClothStoreException(string? message, int statusCode) : base(message)
        {
            StatusCode = statusCode;
        }

        public int StatusCode { get; }
    }
}
