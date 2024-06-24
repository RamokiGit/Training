using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Printer : MonoBehaviour
{
    [SerializeField] private string message = "Hello world";
    void Start()
    {
        PrintingMessageOnConsole(message);
    }

    void PrintingMessageOnConsole(string message)
    {
        print(message);
    }


}
