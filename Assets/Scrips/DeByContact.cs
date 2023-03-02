using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeByContact : MonoBehaviour
{
    public GameObject asteroidsExplosion;
    public GameObject playerExplosion;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Boundary")
        {
            return;
        }
        Destroy(other.gameObject);
        Instantiate(asteroidsExplosion, other.transform.position,other.transform.rotation);

        Destroy(this.gameObject);
        if (this.gameObject.tag == "Player")
        {
            Instantiate(playerExplosion,this.transform.position,this.transform.rotation);
        }

    }
}
