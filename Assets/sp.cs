using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sp : MonoBehaviour
{

    //테스트용 코드

    Rigidbody2D body;
    public fly fly;
    public GameObject Box1;
    public GameObject Box2;
    public GameObject bird;

    //fly fly;

    // Start is called before the first frame update
    void Awake()
    {
        fly = GameObject.Find("Bird").GetComponent<fly>();
    }
    public void Start()
    {
        body = GetComponent<Rigidbody2D>();
        Time.timeScale = 0;

        
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    public void Tap()
    {
        
        Time.timeScale = 1;
        gameObject.SetActive(false);
        fly.score = 0;
        Box1.transform.position = new Vector3(6, 2.02f, -1);
        Box2.transform.position = new Vector3(5, 0, -1);
        bird.transform.position = new Vector3(-0.09f, -2.35f, -3);
    }


}
