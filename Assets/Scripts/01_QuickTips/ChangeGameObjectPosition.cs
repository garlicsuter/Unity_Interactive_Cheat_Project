using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGameObjectPosition : MonoBehaviour
{
    // Method 1: assign the new position in the Inspector in Unity by making a PUBLIC variable
    // (private ones won't show in the Inspector!)
    public Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        // Method 1: grab the existing position and assign it to the X,Y,Z you set in the Unity Inspector window
        transform.position = startPosition;

        // Method 2: assign at the Start. Grab the existing position and assign (=) it a 
        // new position of zero X, zero Y, and zero Z.
        // THE LINE BELOW IS COMMENTED BECAUSE WE ARE USING METHOD 1 INSTEAD.

        // transform.position = new Vector3(0, 0, 0);




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
