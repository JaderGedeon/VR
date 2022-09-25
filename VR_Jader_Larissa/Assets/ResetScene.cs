using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScene : MonoBehaviour
{
    [SerializeField] private Material material;

    // Start is called before the first frame update
    void Start()
    {
        material.color = Color.white;
    }
}
