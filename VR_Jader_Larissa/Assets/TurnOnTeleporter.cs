using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnTeleporter : MonoBehaviour
{
    [SerializeField] private GameObject teleporter;

    public void TurnOn()
    {
        teleporter.SetActive(true);
    }
}
