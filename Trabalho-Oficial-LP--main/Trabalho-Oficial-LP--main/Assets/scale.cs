using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scale : MonoBehaviour
{
    private Vector3 m;
    private float scale1 = 0.01f;
    void Update()
    {
        if (transform.localScale.x <= 2.5f && Input.GetMouseButton(0))
            {
                m.x = scale1;
                m.y = scale1;
                m.z = scale1;
                Escala(m);                         
            }

            if (transform.localScale.x >= 0.1f && Input.GetMouseButton(1))
            {
                m.x = -scale1;
                m.y = -scale1;
                m.z = -scale1;
                Escala(m);
            }
            
    }
    void Escala(Vector3 m)
            {
                transform.localScale += m;

            }
}
