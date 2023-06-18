using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarBand     : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Правые " + GlobalVariables.RightCount);
        Debug.Log("Левые " + GlobalVariables.LeftCount);
    }

 }
