using System;

class Program
{
    
    static void Main(string[] args)
    {
        string theScripture = "3 Wherefore, I write unto my people, unto all those that shall receive hereafter these things which I write, that they may know the judgments of God, that they come upon all nations, according to the word which he hath spoken. 4 Wherefore, hearken, O my people, which are of the house of Israel, and give ear unto my words; for because the words of Isaiah are not plain unto you, nevertheless they are plain unto all those that are filled with the spirit of prophecy. But I give unto you a prophecy, according to the spirit which is in me; wherefore I shall prophesy according to the plainness which hath been with me from the time that I came out from Jerusalem with my father; for behold, my soul delighteth in plainness unto my people, that they may learn. 5 Yea, and my soul delighteth in the words of Isaiah, for I came out from Jerusalem, and mine eyes hath beheld the things of the Jews, and I know that the Jews do understand the things of the prophets, and there is none other people that understand the things which were spoken unto the Jews like unto them, save it be that they are taught after the manner of the things of the Jews.";
        Reference theRef = new Reference();
        theRef.SetBook("2nd Nephi");
        theRef.SetChapter(25);
        theRef.SetVerse(3);
        theRef.SetEndVerse(5);
        


       
        Scripture aScripture = new Scripture(theRef, theScripture);
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
    }
}