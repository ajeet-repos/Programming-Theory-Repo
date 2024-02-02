using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildClass : BaseClass
{
    // INHERITANCE
    // Start is called before the first frame update
    
    // POLYMORPHISM
    protected override void fly()
    {
        Debug.Log("Fly with engine.");
        DisplayLog("Hello!");   // ABSTRACTION
    }

    // ENCAPSULATION
    private void DisplayLog(string msg) {
        Debug.Log(msg);
    }
}
