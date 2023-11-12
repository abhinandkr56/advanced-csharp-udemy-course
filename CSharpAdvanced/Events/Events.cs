namespace CSharpAdvanced.Events;

public class Events
{
    public void EncodeVideo()
    {
        var video = new Video() { Type = "MP3" };
        VideoEncoder videoEncoder = new VideoEncoder();
        
        // subscribe to the publishers
        var mailService = new MailService();
        var textService = new TextService();
        videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
        videoEncoder.VideoEncoded += textService.OnVideoEncoded;
        videoEncoder.Encode(video);
    }
}

class MailService
{
    public void OnVideoEncoded(object source, VideoEventArgs e)
    {
        Console.WriteLine("Mail Service: Sending mail" + e.Type);
    }
}

class TextService
{
    public void OnVideoEncoded(object source, VideoEventArgs e)
    {
        Console.WriteLine("Text Service: Sending text");
    }
}