using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzAcende : MonoBehaviour
{
 
    public void ligadesligaLuz()
    {
        GetComponent<Light>().range = 10;
    }
}
