using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caballeroPlayer : MonoBehaviour
{
    Rigidbody2D caballeroRB;
    public float maxVelocidad;
    Animator caballeroAnimate;
    // Start is called before the first frame update

    //rotarCaballero
    bool  voltearCaballero = true;
    SpriteRenderer caballeroRender;

    void Start()
    {
        caballeroRB = GetComponent<Rigidbody2D> ();
        caballeroRender = GetComponent<SpriteRenderer> ();
        caballeroAnimate = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float mover = Input.GetAxis ("Horizontal");

        if (mover > 0 && !voltearCaballero){
            Voltear();

        }else if(mover < 0 && voltearCaballero)
        {
            Voltear();
        }
        caballeroRB.velocity = new Vector2 (mover * maxVelocidad, caballeroRB.velocity.y);
        //correr caballero
        caballeroAnimate.SetFloat("VelMovimiento",Mathf.Abs(mover));
    }

    void Voltear(){
        voltearCaballero =!voltearCaballero;
        caballeroRender.flipX = !caballeroRender.flipX;
    }
}
