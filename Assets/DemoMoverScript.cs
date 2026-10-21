using UnityEngine;

public class DemoMoverScript : MonoBehaviour
{
    public bool isMovingLeft = true;

    public int boundX = 0; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float moveX = transform.position.x;

        if (isMovingLeft)
        {
            moveX -= 1 * Time.deltaTime; 
        } else //otherwise
        {
            //move right.
            moveX += 1 * Time.deltaTime; 
        }

        if (moveX <= -boundX)
        {
            isMovingLeft = false; 

        } else if (moveX >= boundX)
        {
            isMovingLeft = true;
        }

        transform.position = new Vector2(moveX, 0);

    }
}
