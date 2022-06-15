using System.Linq;
using YoutubeExplode.Videos.Streams;
using YoutubeExplode;

namespace Module18_Task
{
    class CommandDownoadVideo : Command
    {
        Reciever reciever;

        public CommandDownoadVideo(Reciever _reciever)
        {
            reciever = _reciever;
        }

        public override async void Run()
        {
            reciever.Operation();

            YoutubeClient f = new YoutubeClient();

            var stream = await f.Videos.Streams.GetManifestAsync("https://youtu.be/yCb5VnI6Bdo");
            var streamInfo = stream
                .GetVideoOnlyStreams()
                .Where(s => s.Container == Container.Mp4)
                .GetWithHighestVideoQuality();

            await f.Videos.Streams.DownloadAsync(streamInfo, "video.{streamInfo.Container}");            
        }
    }
}
