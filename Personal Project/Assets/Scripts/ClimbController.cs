using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClimbController : MonoBehaviour
{
    public static ClimbController instance;
    public GameObject xrRig;
    private int grabCount;
    private Rigidbody rigidbody;
    private float groundLevel;
    // Start is called before the first frame update
    void Start()
    {
        if (xrRig == null)
            xrRig = GameObject.Find("XR Origin");
        grabCount = 0;
        rigidbody = xrRig.GetComponent<Rigidbody>();
        groundLevel = xrRig.transform.position.y;

    }
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        } else
        {
            Destroy(this);
        }
    }
    public void Grab()
    {
        grabCount++;
        rigidbody.isKinematic = true;
        Debug.Log("Climbcontoller Grab");

    }

    public void Pull(Vector3 distance)
    {
        xrRig.transform.Translate(distance);
    }
    public void Release()
    {
        grabCount--;
        if (grabCount == 0)
        {
            rigidbody.isKinematic = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (xrRig.transform.position.y <= groundLevel)
        {
            Vector3 pos = xrRig.transform.position;
            pos.y = groundLevel;
            xrRig.transform.position = pos;
            rigidbody.isKinematic = true;
        }
    }
}
