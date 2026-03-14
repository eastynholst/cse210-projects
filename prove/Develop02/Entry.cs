using System;

public class Entry 
{
    public string Date;
    public string Prompt;
    public string Response;
/// <summary>
/// save the string to put it in the prompt
/// </summary>
/// <param name="date"></param>
/// <param name="prompt"></param>
/// <param name="response"></param>
    public Entry (string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }
/// <summary>
/// format of how the entry looks
/// </summary>
/// <returns></returns>
    public string GetDisplayString()
    {
        return 
        $" Date: {Date} |" +
        $" Prompt: {Prompt} |" +
        $" Response: {Response}" ;

    }
}