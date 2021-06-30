using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public Transform groundCheck2;
    private bool movingRight;
    public float moveSpeed;
    public LayerMask groundLayer;


    Vector3 start;
    Vector3 des;
    Vector3 mal;
    public float speed = .5f;
    private float fraction = 0;
    void Start()
    {
        //start = this.transform.position;
        start = new Vector3(19.77f, -1.42f, 0);
        des = new Vector3(28.04f, -1.42f, 0);
        mal = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (fraction<1)
        {
            fraction += Time.deltaTime * speed;
            transform.position = Vector3.Lerp(start, des, fraction);
            //mal = transform.position;
            if (this.transform.position == des)
            {
                if (fraction < 1)
                {
                    fraction += Time.deltaTime * speed;
                    transform.position = Vector3.Lerp(des, start, fraction);
                }
            }
        }






        //if (Physics2D.OverlapCircle(groundCheck2.position, 0.1f, groundLayer))
        //{
        //    FlipPlayer();
        //    movingRight = !movingRight;
        //}
        //if (movingRight)
        //{
        //    transform.Translate(moveSpeed, 0, 0);
        //}
        //else
        //{
        //    transform.Translate(-moveSpeed, 0, 0);
        //}


    }
    void FlipPlayer()
    {
        Vector3 scale = transform.localScale;
        scale.x = -scale.x;
        transform.localScale = scale;
    }
}
