using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display : IShow
{
    public void PrintMessageOnce(string message)
    {
        Debug.Log(message);
    }

    public IEnumerator PrintMessageWithFrequency(string message, int frequencyInSeconds)
    {
        while (true)
        {
            PrintMessageOnce(message);
            yield return new WaitForSeconds(frequencyInSeconds);
        }
    }
}
