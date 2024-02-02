using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseClass : MonoBehaviour
{
    protected string parentClassName = "Base Class";

    protected void virtual fly()
    {
        Debug.Log("fly with wings");
    }
}
