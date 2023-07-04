using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");
        List<Video> _videos = new List<Video>();

        // making video number 1
        Video video1 = new Video();
        video1._title = "Nunca Pensé";
        video1._author = "David Archuleta";
        video1._lenght = 243;

        // Comments for video1
        Comment comment1 = new Comment();
        comment1._name = "Francisco Alvara";
        comment1._textComment = "This song inspires so much that I can't stop listening.";

        Comment comment2 = new Comment();
        comment2._name = "Mayra Estrella";
        comment2._textComment = "Sings beautiful! I hope he makes more songs in Spanish.";

        Comment comment3 = new Comment();
        comment3._name = "Edith Maya";
        comment3._textComment = "Wow what a beautiful song... encourages us to work for our ancestors.";

        video1._comments.Add(comment1); //adding the comments
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);

        _videos.Add(video1);
        // video1.Display();
        
        // Video number 1 (end)

        // making video number 2
        Video video2 = new Video();
        video2._title = "Come Thou Fount of Every Blessing / If You Could Hie to Kolob";
        video2._author = "Elenyi & Sarah Young";
        video2._lenght = 389;

        // Comments for video2
        Comment comment1_v2 = new Comment();
        comment1_v2._name = "Joanes Orlando";
        comment1_v2._textComment = "I know that this was posted 7 years ago but I really want to thank to you guys for singing this song. Tears start to fell as I listen to this song I was happy but crying at the same time.";

        Comment comment2_v2 = new Comment();
        comment2_v2._name = "Estrella Rode";
        comment2_v2._textComment = "These two songs my son used to play on the piano, he passed away from cancer, but while he was going through chemo, and if he had some strength to play the piano,  he played it and sounded heavenly! Thank you for posting this video.";

        Comment comment3_v2 = new Comment();
        comment3_v2._name = "Angelica Right";
        comment3_v2._textComment = "So beautiful and inspiring!";

        Comment comment4_v2 = new Comment();
        comment4_v2._name = "Richard Zeitschel";
        comment4_v2._textComment = "Draw near while you are able. The time is near for our Savior Jesus's return. Prepare yourself to meet the One who loves you.";

        video2._comments.Add(comment1_v2); //adding the comments
        video2._comments.Add(comment2_v2);
        video2._comments.Add(comment3_v2);
        video2._comments.Add(comment4_v2);

        _videos.Add(video2);
        // video2.Display();
        // Video number 2 (end)

        // making video number 3
        Video video3 = new Video();
        video3._title = "¿Qué Piensa Él?";
        video3._author = "Álbum de los Jóvenes 2020 by Ysaac Martínez & Yossandy Abreu";
        video3._lenght = 188;

        // Comments for video3
        Comment comment1_v3 = new Comment();
        comment1_v3._name = "Carolina Andrea Ortiz";
        comment1_v3._textComment = "Es triste estar solo en una iglesia tan grande uno aveces quiere consuelo amor pero no es todo tan individualista pero esta canción es respuesta a esa soledad.";

        Comment comment2_v3 = new Comment();
        comment2_v3._name = "Alee Lib";
        comment2_v3._textComment = "Mi favorita de este album, la ame!";

        Comment comment3_v3 = new Comment();
        comment3_v3._name = "Daniel Cossio";
        comment3_v3._textComment = "Lindas voces de estos jóvenes.";

        Comment comment4_v3 = new Comment();
        comment4_v3._name = "Filemon Guzman";
        comment4_v3._textComment = "Tremenda interpretación y reflexión a la vez. Qué talentos Dios le bendiga siempre.";

        video3._comments.Add(comment1_v3); //adding the comments
        video3._comments.Add(comment2_v3);
        video3._comments.Add(comment3_v3);
        video3._comments.Add(comment4_v3);

        _videos.Add(video3);
        // video3.Display();


        //Display all the videos
        foreach (Video v in _videos)
        {
            Console.WriteLine();
            v.Display();
        }
    }
}
