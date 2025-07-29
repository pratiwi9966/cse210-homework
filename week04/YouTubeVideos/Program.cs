using System;

class Program
{
    static void Main(string[] args)
    {
        // Creat a list to hold videos;
        List<Video> videos = new List<Video>();

        // Creat Video 1
        Video video1 = new Video("Inis Oírr (Inisheer) - Tin Whistle and Guitar","Romain DAUGNY",169);
        video1.AddComment(new Comment("@fernanmas1779","I love that guitar arrangements. Bravo"));
        video1.AddComment(new Comment("@nabeelhakim4773","Such a good song and performance "));
        video1.AddComment(new Comment("@KezumiCreative","Which whistle are you playing? It has such a lovely warm tone."));
        videos.Add(video1);


        // Creat Video 2
        Video video2 = new Video("Titanic (Irish low whistle)","Paul Harvey Flute guy",119);
        video2.AddComment(new Comment("@DanielDossey","That was epic, the acoustics in there are unreal!!"));
        video2.AddComment(new Comment("@abain5747", "What a legend "));
        video2.AddComment(new Comment("@alexmerz5367","Bravissimo"));
        videos.Add(video2);

        // Creat Video 3
        Video video3 = new Video("Wild Mountain Thyme","TinWhistler",189);
        video3.AddComment(new Comment("@Neo-mw1pp","He sings! Great voice fella!"));
        video3.AddComment(new Comment("@kipanshi", "Beautiful song and very nice singing."));
        video3.AddComment(new Comment("@organman77","This is so beautiful, wow!"));
        videos.Add(video3);

        // Creat Video 4
        Video video4 = new Video("Ímar - l'Air Mignonne (Canadian Sunshine)","Imar",288);
        video4.AddComment(new Comment("@riktich","only listened to it 45 times today"));
        video4.AddComment(new Comment("@thisisaurell1323","this....is....breathtaking..."));
        video4.AddComment(new Comment("@yakityyob","Wow!  Outstanding!"));
        videos.Add(video4);

        // Loop through each video in the list and display its details and comments
        foreach (Video video in videos)
        {
            // Call the method from the Video class to print video info and its comments
            video.DisplayVideoInfo();
        }
      
    }
}