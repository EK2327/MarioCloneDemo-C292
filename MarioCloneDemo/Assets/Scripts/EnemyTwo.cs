using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwo : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    bool moveUp = true;
    float moveTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveUp)
        {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
            moveTime += Time.deltaTime;
        }
        else
        {
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
                moveTime -= Time.deltaTime;
        }
        
        if (moveTime > 1 || moveTime < 0)
        {
            moveUp = !moveUp;
        }
    }
}
