namespace CorporateResources.Communication.Responses
{
    public class GenericResponse<T>
    {
        public T? Entity { get; set; }
        
        public string Message {  get; set; } = string.Empty;

        public bool Status { get; set; } = true;
    }
}
