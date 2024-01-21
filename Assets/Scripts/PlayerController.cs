using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float moveSpeed = 20f;

    Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(UnityEngine.Input.GetKey(KeyCode.LeftArrow))
        {
            if (UnityEngine.Input.GetKey(KeyCode.Space))
            {
                rb2d.AddTorque(torqueAmount);
            }

            if(moveSpeed > 0f) 
            {
                float moveAmount = UnityEngine.Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
                transform.Translate(-moveAmount, 0, 0);
            }

        }
        else if (UnityEngine.Input.GetKey(KeyCode.RightArrow))
        {
            if (UnityEngine.Input.GetKey(KeyCode.Space))
            {
                rb2d.AddTorque(-torqueAmount);
            }
            if(moveSpeed < 40f) 
            {
                float moveAmount = UnityEngine.Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
                transform.Translate(moveAmount, 0, 0);
            }
  
        }
    }
}
