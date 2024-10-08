using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwo : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    bool moveUp = true;
    [SerializeField] float moveTime;
    float curTime = 0;

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
            curTime += Time.deltaTime;
        }
        else
        {
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
                curTime -= Time.deltaTime;
        }
        
        if (curTime > moveTime || curTime < 0)
        {
            moveUp = !moveUp;
        }
    }
}
