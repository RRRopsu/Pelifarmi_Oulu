using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugLogExamples : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("A simple log");
        Debug.LogWarning("A simple warning log");
        Debug.LogError("A simple error log");

        int someRandomVariable = 123;

        Debug.LogFormat("Variable contains a value of {0}", someRandomVariable);
        Debug.LogFormat("Hello, I am {0} and I am telling {1} to use Debug.Log to output value of {2}",
            "Mikko",
            "you",
            someRandomVariable);

        Debug.Log($"Variable contains a value if {someRandomVariable}");

        Debug.Log("A simple log for outputting value " + someRandomVariable + " to console");

        Debug.Log("<b>Rich text</b>  <i>also</i>  <color=red>works</color>   <size=30>Size</size>");

    }
}
