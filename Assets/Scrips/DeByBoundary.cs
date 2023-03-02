using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeByBoundary : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
