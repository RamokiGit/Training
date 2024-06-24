using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Printer : MonoBehaviour
{
    [SerializeField] private string message = "Hello world";
    private Display _display;

    private void Awake()
    {
        _display = new Display();
    }

    private void Start()
    {
        StartCoroutine(_display.PrintMessageWithFrequency(message,3));
    }
    public void ConsoleMessageOnTap()
    {
        _display.PrintMessageOnce(message);
    }

    


}
