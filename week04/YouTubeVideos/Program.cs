using System;

class Program
{
    static void Main(string[] args)
    {

        string videoName = "the Best";
        string vAuthor = "Bob waybe";
        int theLength = 23; // in minutes
        string comOne = "this was a great movie";
        string person1 = "albert crocker";
        string comTwo = "Movie was too long";
        string person2 = "John silister";
        string comThree = "movie was too short";
        string person3 = "Bill Conner";

        string videoName2 = "Attack of the Ants";
        string vAuthor2 = "Tom Sugar";
        int theLength2 = 51; // in minutes
        string comOne2 = "the movie was great";
        string person4 = "Cathy foneburg";
        string comTwo2 = "There were too many ants";
        string person5 = "June solize";
        string comThree2 = "the movie was too slow";
        string person6 = "Mike filster";



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
        myVideo2.addComments(aComment);
        myVideo2.addComments(aComment2);
        myVideo2.addComments(aComment3);
       
       
       
       
       
       
       
       
       
       
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
    }
}