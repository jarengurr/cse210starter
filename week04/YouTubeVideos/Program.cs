using System;
using System.IO.Compression;
using System.Runtime.InteropServices.Marshalling;

class Program
{
     public List<Video> _mylist = new List<Video>();
    static void Main(string[] args)
    {

        List<Video> holdVideo;
        holdVideo = new List<Video>();



        string videoName = "the Best";
        string vAuthor = "Bob waybe";
        int theLength = 23; // in seconds
        string comOne = "this was a great movie";
        string person1 = "albert crocker";
        string comTwo = "Movie was too long";
        string person2 = "John silister";
        string comThree = "movie was too short";
        string person3 = "Bill Conner";

        string videoName2 = "Attack of the Ants";
        string vAuthor2 = "Tom Sugar";
        int theLength2 = 3060; // in seconds
        string comOne2 = "the movie was great";
        string person4 = "Cathy foneburg";
        string comTwo2 = "There were too many ants";
        string person5 = "June solize";
        string comThree2 = "the movie was too slow";
        string person6 = "Mike filster";

        string videoName3 = "When Worlds Collide";
        string vAuthor3 = "Edwin Balmer";
        int theLength3 = 4980; // in seconds
        string comOne3 = "The movie was great";
        string person7 = "Henry Boxton";
        string comTwo3 = "Needed more action";
        string person8 = "Jenny Lear";
        string comThree3 = "The movie was too slow";
        string person9 = "Bill westen";
        string comFour = "It was a fast movie";
        string person10 =  "Slow Poke";

        Comments aComment = new Comments(person1, comOne);
        Comments aComment2 = new Comments(person2, comTwo);
        Comments aComment3 = new Comments(person3, comThree);
        Video myVideo = new Video(videoName, vAuthor, theLength);
        myVideo.addComments(aComment);
        myVideo.addComments(aComment2);
        myVideo.addComments(aComment3);

        Comments theComment = new Comments(person4, comOne2);
        Comments theComment2 = new Comments(person5, comTwo2);
        Comments theComment3 = new Comments(person6, comThree2);
        Video myVideo2 = new Video(videoName2, vAuthor2, theLength2);
        myVideo2.addComments(theComment);
        myVideo2.addComments(theComment2);
        myVideo2.addComments(theComment3);


        Comments myComment = new Comments(person7, comOne3);
        Comments myComment2 = new Comments(person8, comTwo3);
        Comments myComment3 = new Comments(person9, comThree3);
        Comments myComment4 = new Comments(person10, comFour);
        Video myVideo3 = new Video(videoName3, vAuthor3, theLength3);
        myVideo3.addComments(myComment);
        myVideo3.addComments(myComment2);
        myVideo3.addComments(myComment3);
        myVideo3.addComments(myComment4);


        Console.WriteLine();

        holdVideo.Add(myVideo);
        holdVideo.Add(myVideo2);
        holdVideo.Add(myVideo3);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        for (int i = 0; i < holdVideo.Count; i++)
        {
            Console.WriteLine(holdVideo[i].GetVideoInfo());



            Console.Write("     ");
            Console.WriteLine(holdVideo[i].GetComments());
            Console.WriteLine();
               

        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
    }
}