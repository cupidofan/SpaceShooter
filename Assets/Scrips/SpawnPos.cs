using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPos : MonoBehaviour
{
    public GameObject bolt;
    float firerate = 0.15f;//����ʱ����
    float firetime;//�´η���ʱ��
    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time>firetime)
        {
            firetime = Time.time + firerate;
            Instantiate(bolt, transform.position, transform.rotation);
        }
    }
}
