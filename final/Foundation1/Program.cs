using System;

class Program
{
    static void Main(string[] args)
    {
        var comments1 = new List<(string, string)>
        {
            ("JohnDoe42", "I wish I could have one of those doughnuts!"),
            ("SallyBaker", "This is why I love MrYeast!"),
            ("DonutLover99", "How do you come up with these ideas? Amazing!")
        };
        Video video1 = new Video("I Gave Away a Million Doughnuts!", "MrYeast", 600, comments1);

        var comments2 = new List<(string, string)>
        {
            ("BakingFanatic", "The dedication of these contestants is unreal!"),
            ("OvenMaster", "I would definitely win this challenge!"),
            ("CookieMonster", "Such a fun challenge! Who knew watching people bake could be so entertaining?")
        };
        Video video2 = new Video("Last To Leave The Oven Wins $10,000", "MrYeast", 900, comments2);

        var comments3 = new List<(string, string)>
        {
            ("TechieTom", "I can't believe you actually did this!"),
            ("SarahGeek", "Imagine if this worked... Linus never ceases to amaze!"),
            ("NerdyNate", "I love these creative builds! Keep them coming, Linus!")
        };
        Video video3 = new Video("Building a PC Out of Marshmallows!", "LinusTechTricks", 1200, comments3);

        var comments4 = new List<(string, string)>
        {
            ("GPUguy", "Wow, I didn't even know they made GPUs this small!"),
            ("PixelPete", "Great review as always, Linus! I love the humor you add."),
            ("GraphicGamer", "I wonder how this would handle modern games. Awesome video!")
        };
        Video video4 = new Video("Reviewing the World's Smallest GPU", "LinusTechTricks", 800, comments4);

        List<Video> videos = new List<Video> {video1, video2, video3, video4};

        foreach (Video video in videos) {
            video.DisplayVideoInfo();
        }
    }
}