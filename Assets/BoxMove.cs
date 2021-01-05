using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour
{
    public float Speed;
    public bool b;
    public Transform tr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tr.position.x >= 5)
        {
            b = false;
        }

        if (tr.position.x < -5.15f)
        {
            b = true;
        }

        if (b == false)
        {
            tr.Translate(Vector2.left * Speed * Time.deltaTime);
        }
        if (b == true)
        {
            tr.position = new Vector2(6, 2.02f);
        }
    }
}
