using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ClimbInteractable : XRBaseInteractable
{
    protected override void OnSelectEntered(XRBaseInteractor interactor)
    {
        base.OnSelectEntered(interactor);

        if(interactor is XRDirectInteractor)
           // Climber.ClimbingHand = interactor.GetComponent<XRController>();
        Debug.Log("Select Enter");
    }
    protected override void OnSelectExited(XRBaseInteractor interactor)
    {
        base.OnSelectExited(interactor);
       // if (interactor is XRDirectInteractor)
       // {
       //    if(Climber.ClimbingHand && Climber.ClimbingHand.name == interactor.name)
       //     {
       //         Climber.ClimbingHand = null;
       //     }
        //    Climber.ClimbingHand = null;
        //}
            
        Debug.Log("Select Exit");
    }

}
