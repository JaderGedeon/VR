using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockAndLoad : MonoBehaviour
{
    [SerializeField] private bool isReady;
    public bool IsReady { get => isReady; set => isReady = value; }

    public void Shoot()
    {
        if (!isReady)
            return;

        if (Physics.Raycast(transform.position,
        transform.TransformDirection(Vector3.forward), out RaycastHit hit, Mathf.Infinity))
        {
            var target = hit.transform.gameObject;

            if (target.CompareTag("Alvo"))
            {
                target.GetComponent<TurnOnTeleporter>().TurnOn();
            }
        }
    }
}
