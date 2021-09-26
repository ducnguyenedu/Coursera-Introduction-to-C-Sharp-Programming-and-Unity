using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Vector3 newScale = transform.localScale;
        newScale.x -= 4;


        newScale.y -= 4;
        transform.localScale = newScale;
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
        print("Hello");
    }

    // Update is called once per frame

}
