namespace DelegateAndEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Before Encode");

            Video video = new Video() { Id = 1, Name = "Narasimham" };
            VideoHandler handler = new VideoHandler();
            MailService mail = new MailService();
            MessageService message = new MessageService();

            handler.VideoEncodedSample += mail.VideoEncodedEventSubScriber; // Legacy

            handler.VideoEncoded += mail.VideoEncoded;
            handler.VideoEncoded += message.VideoEncoded;


            handler.Encode(video);

            System.Console.WriteLine("After Encode");

            System.Console.ReadKey();
        }
    }

    public class MailService
    {
        public void VideoEncodedEventSubScriber()
        {
            System.Console.WriteLine("Sample mail service - Not a standard approach");
        }

        public void VideoEncoded(object source, VideoEventArgs args)
        {
            System.Console.WriteLine($"Subscriber : Mail Service : Video Name {args.video.Name}");
        }
    }

    public class MessageService
    {
        public void VideoEncoded(object source, VideoEventArgs args)
        {
            System.Console.WriteLine($"Subscriber : Message Service : Video Name {args.video.Name}");
        }
    }
}
