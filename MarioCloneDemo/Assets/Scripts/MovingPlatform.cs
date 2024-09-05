using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    bool moveRight = true;
    [SerializeField]float moveTime;
    float curTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveRight)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
            curTime += Time.deltaTime;
        }
        else
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
            curTime -= Time.deltaTime;
        }

        if (curTime > moveTime || curTime < 0)
        {
            moveRight = !moveRight;
        }
    }
}
