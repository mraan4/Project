using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove2 : MonoBehaviour
{
    public float Speed;
    public Transform tr;
    public bool b;
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

        if(tr.position.x < -5.15f)
        {
            b = true;
        }

        if(b == false)
        {
            tr.Translate(Vector2.left * Speed * Time.deltaTime);
        }
        if(b == true)
        {
            tr.position = new Vector2(5, 0);
        }
    }
}
