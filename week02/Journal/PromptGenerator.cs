
using System;
using System.Collections.Generic;
using System.IO;
public class PromptGenerator()
{
    public List<string> _prompts = new List<string>();
    private int maxNum =13;// max number of questions or prompts in list


    public void SaveQuestion(string question) // adding questions by user
    {
       string filename = "question.txt";
        using (StreamWriter holdfile = File.AppendText(filename))
        {
            holdfile.WriteLine(question);
       }
             
       
    }

   
    public string GetRandomPrompt() // gets and returns a random question
    {
        int randNum;
        string question;
        Random randomNumber = new Random();
        randNum = randomNumber.Next(1,maxNum);
        question = _prompts[randNum];
        return question;
        
    }

    public void GetFile()// load questions into list
    {
        string filename = "question.txt";
        string[] prompts = System.IO.File.ReadAllLines(filename);
        
        maxNum = prompts.Count();
       
        
        Console.WriteLine(prompts[1]);
        // hold = _myList.Count();
       
                        
    }  


}



 