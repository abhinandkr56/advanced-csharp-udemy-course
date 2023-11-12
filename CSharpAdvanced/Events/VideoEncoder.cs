namespace CSharpAdvanced.Events;

public class VideoEncoder
{
    // Steps
    // 1. Define delegate
    // 2. Define Event
    // 3. Raise the Event
    
    
    public delegate void VideoEncodedEventHandler(object source, VideoEventArgs e);

    // instead of using delegate and using it as the type of event, we can use the below EventHandler
    public event EventHandler<VideoEventArgs> VideoEncoded;
    public void Encode(Video video)
    {
        Console.WriteLine("Processing");
        Thread.Sleep(TimeSpan.FromSeconds(10));
        OnVideoEncoded(video);
    }
    
    protected virtual void OnVideoEncoded(Video video)
    {
        if(VideoEncoded is not null)
            VideoEncoded(this, new VideoEventArgs(){Type = video.Type});
    }
}

public class VideoEventArgs : EventArgs
{
    public string Type { get; set; }
}

public class Video
{
    public string Type { get; set; }
}