using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporting : MonoBehaviour
{
    [SerializeField] private GameObject[] telepods;

    public void TurnOnTelepods()
    {
        foreach (var telepod in telepods)
        {
            telepod.SetActive(true);
        }
    }
}
