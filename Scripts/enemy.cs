using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    private Transform hedef;
    public float hiz;
    public float durmaMesafesi;
    private Rigidbody2D rbody2d;
    void Start()
    {
        rbody2d = GetComponent<Rigidbody2D>();
        hedef = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void EnemyFollow()
    {
        if (Vector2.Distance(transform.position, hedef.position) > durmaMesafesi)
        {
            transform.position = Vector2.MoveTowards(transform.position, hedef.position, hiz * Time.deltaTime);
        }
    }
    
    void Update()
    {
        EnemyFollow();
    }
}
