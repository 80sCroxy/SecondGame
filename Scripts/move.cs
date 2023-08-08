using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    Rigidbody2D rb2D;
    private float yatayhareket;
    public int harekethizi;
    public int ziplamahizi;

    public bool karakteryerde;
    public bool faceright = true;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        yatayhareket = Input.GetAxis("Horizontal");
        rb2D.velocity = new Vector2(yatayhareket * harekethizi * 100 * Time.deltaTime, rb2D.velocity.y);
        if (Input.GetKeyDown(KeyCode.W) && karakteryerde==true)
        {
            rb2D.velocity=Vector2.up*ziplamahizi*250*  Time.deltaTime;
            karakteryerde = false;
        }
        if (yatayhareket > 0 && faceright == false)
        {
            turn();
        }
        if (yatayhareket < 0 && faceright == true)
        {
            turn();
        }
    }
    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag=="zemin")
            {
                karakteryerde = true;
            }
    }
    void turn()
    {
        faceright = !faceright;
        Vector2 yeniscale = transform.localScale;
        yeniscale.x *=-1;
        transform.localScale = yeniscale;
    }
}
