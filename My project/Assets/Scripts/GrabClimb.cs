using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabClimb : MonoBehaviour
{
    private XRSimpleInteractable interactable;
    private ClimbController climbController;
    private bool isGrabbing;
    private Vector3 handPosition;

    // Start is called before the first frame update
    void Start()
    {
        interactable = GetComponent<XRSimpleInteractable>();
        climbController = GetComponentInParent<ClimbController>();
        isGrabbing = false;
    }
    public void Grab()
    {

        isGrabbing = true;
        handPosition = InteractorPosition();
        climbController.Grab();
        Debug.Log("Grabbing");
    }

    private Vector3 InteractorPosition()
    {
        List<XRBaseInteractor> interactors = interactable.hoveringInteractors;
        if (interactors.Count > 0)
            return interactors[0].transform.position;
        else
            return handPosition;
    }
    // Update is called once per frame
    void Update()
    {
        if (isGrabbing)
        {
            Vector3 delta = handPosition - InteractorPosition();
            climbController.Pull(delta);
            handPosition = InteractorPosition();
           

        }
    }
    public void Release()
    {
        isGrabbing = false;
        climbController.Release();
        Debug.Log("Release");
    }
}
