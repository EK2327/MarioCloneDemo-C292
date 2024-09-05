using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnTouch : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float distance;
    private Vector3 direction = Vector3.right;
    private float startingLocation;
    private float endingLocation;
    private bool hasTouched = false;
    // Start is called before the first frame update
    void Start()
    {
        startingLocation = transform.position.x;
        endingLocation = startingLocation + distance;
    }

    // Update is called once per frame
    void Update()
    {
        if (hasTouched)
        {
            transform.Translate(speed * direction * Time.deltaTime);
            if(transform.position.x > endingLocation)
            {
                direction = Vector3.left;
                
            }
            if(transform.position.x < startingLocation)
            {
                direction = Vector3.right;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            hasTouched = true;
        }
    }
}
