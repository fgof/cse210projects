using System;

class Program
{
    static void Main(string[] args)
    {
        Videos video1 = new Videos();
        video1._title = "My New Kitten";
        video1._author = "Ur Moms BFF";
        video1._length = 60;
        Comments v1comments = new Comments();
        v1comments._user = "Luv2h8";
        v1comments._comment = "Dogs are better than cats";
        Comments v1comments2 = new Comments();
        v1comments2._user = "Nicki Manja";
        v1comments2._comment = "So cute!";
        Comments v1comments3 = new Comments();
        v1comments3._user = "I smell good";
        v1comments3._comment = "Tell the kitten I said 'meow meow meow'";

        video1._comments.Add(v1comments);
        video1._comments.Add(v1comments2);
        video1._comments.Add(v1comments3);
        
        Videos video2 = new Videos();
        video2._title = "One more Time";
        video2._author = "Daft Punk";
        video2._length = 160;
        Comments v2comments = new Comments();
        v2comments._user = "BiggFeet";
        v2comments._comment = "Absolute Banger";
        Comments v2comments2 = new Comments();
        v2comments2._user = "Call me Guido";
        v2comments2._comment = "I wake up to this song";
        Comments v2comments3 = new Comments();
        v2comments3._user = "Electric Celery";
        v2comments3._comment = "Like if youre here because of Drake";
        
        video2._comments.Add(v2comments);
        video2._comments.Add(v2comments2);
        video2._comments.Add(v2comments3);

        Videos video3 = new Videos();
        video3._title = "Guy Falls Down";
        video3._author = "Guy Farting";
        video3._length = 76;
        Comments v3comments = new Comments();
        v3comments._user = "IDillyIDally";
        v3comments._comment = "I can smell this video";
        Comments v3comments2 = new Comments();
        v3comments2._user = "PiratesBooty";
        v3comments2._comment = "Ouch! Id hate to be that guy";
        Comments v3comments3 = new Comments();
        v3comments3._user = "Yall Seeing This?";
        v3comments3._comment = "Yall Seeing This?";
        Comments v3comments4 = new Comments();
        v3comments4._user = "Gregg Germany";
        v3comments4._comment = "I hope he didnt break anything";
        
        video3._comments.Add(v3comments);
        video3._comments.Add(v3comments2);
        video3._comments.Add(v3comments3);
        video3._comments.Add(v3comments4);


        video1.DiplayVideo();
        video2.DiplayVideo();
        video3.DiplayVideo();

    }
}