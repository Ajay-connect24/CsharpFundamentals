namespace Lesson26_Asynchronous
{
    internal class Program
    {
        async static Task Main(string[] args)
        {
            var task = DownloadData();
            Console.WriteLine("MAin method");
            Console.WriteLine(await task);  //waits until task is over
        }

        async static Task<string> DownloadData() // if returning null use Task instead of Task<string>
        {
            Console.WriteLine("Download started");

            //logic for downloading
            await Task.Delay(8000);
            return "Download  Complete";
        }
    }
}

//task auto allocates thread
//task is similar to return type null
//if main ends prgrm rnds...so await used to make main wait
//async keyword needed to work
//Task allocates thread
