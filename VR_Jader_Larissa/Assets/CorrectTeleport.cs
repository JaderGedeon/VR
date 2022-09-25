using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectTeleport : MonoBehaviour
{
    [SerializeField] private GameObject canvas;

    public void TurnOn()
    {
        canvas.SetActive(true);
    }
}
