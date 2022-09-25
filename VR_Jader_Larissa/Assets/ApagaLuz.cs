using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApagaLuz : MonoBehaviour
{
    [SerializeField] private Transform light;
    [SerializeField] private Material material;
    [SerializeField] private bool isReady;
    [SerializeField] private LockAndLoad lockAndLoad;

    public bool IsReady { get => isReady; set => isReady = value; }

    public void TurnOffLights()
    {
        if (!isReady)
            return;

        light.rotation = Quaternion.Euler(-90, 50, 0);
        material.color = Color.black;
        gameObject.SetActive(false);
        lockAndLoad.IsReady = true;
    }
}
