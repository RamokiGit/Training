using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShow
{
    void PrintMessageOnce(string message);
    IEnumerator PrintMessageWithFrequency(string message, int frequencyInSeconds);
}
