namespace SimpleBookCatalog.WebUI
{
    public class DisposableType : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("DisposableType getting disposed");
        }
    }
}
