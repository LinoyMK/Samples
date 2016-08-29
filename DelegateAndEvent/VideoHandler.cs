using System.Threading;

namespace DelegateAndEvent
{

    // 1. Declare a delegate (Contract b/w publisher and Subscriber, common signature)
    // 2. Declare an event based on delegate
    // 3. Raise the event if any subscriber exist.
    //  Now the VideoHandler dont know who are going to listen ( Loosly coupled)

    public class VideoHandler
    {
        public delegate void VideoEncodedHandlerSample(); // Legacy
        public event VideoEncodedHandlerSample VideoEncodedSample;


        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        public event VideoEncodedEventHandler VideoEncoded; // Standard(naming convension)


        public void Encode(Video data)
        {
            // Encoding logic
            Thread.Sleep(3000);

            OnVideoEncodedSample(); // Publisher
            OnVideoEncoded(data); // Publisher

        }

        private void OnVideoEncodedSample()
        {
            VideoEncodedSample?.Invoke(); // If any subscriber then invoke the event
            // OR

            // if (VideoEncoded != null)
            // {
            //    VideoEncoded();
            // }

        }

        protected virtual void OnVideoEncoded(Video video)
        {
            System.Console.WriteLine("Publisher : Video encoded event published, Dont know who and all listening!!");
            VideoEncoded?.Invoke(this, new VideoEventArgs() { video = video });
        }
    }
}
