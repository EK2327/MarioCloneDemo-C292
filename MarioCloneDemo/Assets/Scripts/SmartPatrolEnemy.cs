using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayingEnemy : MonoBehaviour
{
    [SerializeField] float speed;
    private Vector3 direction = Vector3.left;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "PatrolPoint")
        {
            direction *= -1;
        }
    }
}
