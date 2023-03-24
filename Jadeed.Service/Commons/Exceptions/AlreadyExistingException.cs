namespace Jadeed.Service.Commons.Exceptions
{
    public class AlreadyExistingException : Exception
    {
        public string Point { get; set; } = string.Empty;
        public AlreadyExistingException(string point,string message)
            :base(message) 
        {
            this.Point = point;
        }
    }
}
