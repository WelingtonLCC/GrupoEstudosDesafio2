namespace BlazorImc.Service
{
    public class SharedService
    {
        public List<string> ListResult { get; private set; } = new();

        public void AdicionarResult(string result)
        {
            ListResult.Add(result);
        }
    }
}
