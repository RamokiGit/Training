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

    void Start()
    {
        
    }

    


}
