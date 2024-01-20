using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
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
            rb2d.AddTorque(torqueAmount);
        }
        else if (UnityEngine.Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
