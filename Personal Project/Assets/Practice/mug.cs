using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mug : MonoBehaviour
{
    public Gameobject mLiquid;
    public Gameobject mLiquidMesh;

    private int mSloshSpeed = 60;
    private int mRotateSpeed = 15;

    privtae int difference = 25;

    void Update()
    {
        //Motion
        Slosh();

        //Rotation
        mLiquidMesh.transform.Rotate(Vector3.up * mRotateSpeed * time.deltaTime, Space.self);
    }

    private void Slosh()
    {

    }
}
