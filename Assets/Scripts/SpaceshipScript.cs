using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipScript : MonoBehaviour
{
    public float speed;
    
    public Sprite leftSprite;
    public Sprite rightSprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveH, moveV);
        GetComponent<Rigidbody2D>().velocity = movement * speed;

        Vector3 currPos = GetComponent<Rigidbody2D>().transform.position;

        if (currPos.x >= 0) {
            if (GetComponent<SpriteRenderer>().sprite != rightSprite) {
                GetComponent<SpriteRenderer>().sprite = rightSprite;
            }
        }
        else {
            if (GetComponent<SpriteRenderer>().sprite != leftSprite) {
                GetComponent<SpriteRenderer>().sprite = leftSprite;
            }
        }
    }
}
