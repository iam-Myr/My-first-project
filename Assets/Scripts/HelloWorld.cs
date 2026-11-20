using System;
using UnityEngine;

public class HelloWorld : MonoBehaviour

// Print "Hello, World!" to the console when the game starts
// Print in C#? Debug.Log    | Console.WriteLine("Hello, World!")
// When does it run? Once when it starts, every frame, on event 

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
    }

    // Update is called once per frame != second FPS = frames per second
    void Update()
    {
        Debug.Log("Hello, World!");
    }
}
