using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaveAbre : MonoBehaviour
{
    [SerializeField] private ApagaLuz apagaLuz;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Porta"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            apagaLuz.IsReady = true;
        }
    }
}
