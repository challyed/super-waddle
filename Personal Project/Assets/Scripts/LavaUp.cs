using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaUp : MonoBehaviour
{
    //adjust this to change speed
    float speed = .5f;
    //adjust this to change how high it goes
    //float height = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get the objects current position and put it in a variable so we can access it later with less code
        //Vector3 pos = transform.position;
        //calculate what the new Y position will be
        //float newY = Mathf.Sin(Time.time * speed);
        //set the object's Y to the new calculated Y
        //transform.position = new Vector3(pos.x, newY, pos.z) * height;
        //transform.position.y += speed * Time.deltaTime;
        //transform.position = new Vector3(0, 50, 0) * Time.deltaTime;
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}

