
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
public class PromptGenerator()
{
    public List<string> _prompts = new List<string>();
    private int maxNum;// max number of questions or prompts in list


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
        int randNum = 6;
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
        int length;

        length = prompts.Count();
        for (int i = 0; i < length; i++)
        {
             _prompts.Add(prompts[i]);
        }
       
        maxNum = prompts.Count();
       
        
        //Console.WriteLine(prompts[5]); //It works
        // hold = _myList.Count();
       
                        
    }  


}



 