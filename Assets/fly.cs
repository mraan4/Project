using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class fly : MonoBehaviour
{
    Rigidbody2D body;
    public float speed;
    public int score;
    public Text text;
    public GameObject go;
    
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        text.text = score.ToString();
    }
    // Update is called once per frame
    public void Tap()
    {
       body.velocity = Vector2.up * speed;
       
    }

    void OnCollisionEnter2D(Collision2D coll2d)
    {
        
        if(coll2d.gameObject.tag == "Box")
        {
            string name_ = coll2d.gameObject.name;
            Debug.Log("tag :" + coll2d.gameObject.name);
            Time.timeScale = 0;
            go.SetActive(true);
        }


    }
    void OnTriggerExit2D(Collider2D co2)
    {
        if(co2.gameObject.tag == "Scora")
        {
            score = score + 1;
            Debug.Log("Score :" + score);
        }
    }


}
