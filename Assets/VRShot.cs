using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class VRShot : MonoBehaviour {

    private SteamVR_TrackedObject _controller;
    

    private PrimitiveType _currentPrimitiveType = PrimitiveType.Sphere;

    public Rigidbody rocketVR;
    public float rocketSpeed = 200.0f;
    public float rocketLife = 1.0f;
    public GameObject rktControl;

    public SteamVR_Action_Boolean grabPinch; //Grab Pinch is the trigger, select from inspecter
    public SteamVR_Input_Sources inputSource = SteamVR_Input_Sources.Any;//which controller
                                                                         // Use this for initialization

    void OnEnable()
    {
        if (grabPinch != null)
        {
            grabPinch.AddOnChangeListener(OnTriggerPressedOrReleased, inputSource);
        }
    }


    private void OnDisable()
    {
        if (grabPinch != null)
        {
            grabPinch.RemoveOnChangeListener(OnTriggerPressedOrReleased, inputSource);
        }
    }


    private void OnTriggerPressedOrReleased(SteamVR_Action_In action_In)
    {

        //Debug.Log("vr trigger foi clickado!!!!");
        SpawnCurrentPrimitiveAtController();

    }


    private void SpawnCurrentPrimitiveAtController()
    {

        //Vector3 playerPosV3 = new Vector3(rktControl.transform.position.x, rktControl.transform.position.y, rktControl.transform.position.z);
        Rigidbody clone_rocketVR = Instantiate(rocketVR, rktControl.transform.position, transform.rotation) as Rigidbody; //transform.position ou rotation  OU deve ser rocketVR.position ou rotation
        clone_rocketVR.AddForce(rktControl.transform.forward * rocketSpeed * Time.deltaTime * 50, ForceMode.VelocityChange);
        Destroy(clone_rocketVR.gameObject, rocketLife);


    }

   


}
