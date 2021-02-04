using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Drone_VR : MonoBehaviour {

    public bool enterDrone = false;
    Color32 colorOn;
    Color32 colorOff;
    DroneMode dm;
    public GameObject cameraRig;
    public GameObject camVR;

    // Use this for initialization
    void Start () {
        colorOn = new Color32(0, 255, 0, 255);
        colorOff = new Color32(255, 0, 0, 255);
    }
	
	// Update is called once per frame
	void Update () {
        if (enterDrone)
        {

            this.GetComponent<Renderer>().material.color = colorOn;
        }

        else
        {
            this.GetComponent<Renderer>().material.color = colorOff;
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "VR_Button")
        {
            enterDrone = true;
            enterDroneMode();
        }
    }

    public void enterDroneMode()
    {
        Vector3 offsetVRmais = new Vector3(cameraRig.transform.position.x, cameraRig.transform.position.y, cameraRig.transform.position.z + 5.0f);
        Vector3 offsetVRmenos = new Vector3(cameraRig.transform.position.x, cameraRig.transform.position.y, cameraRig.transform.position.z - 5.0f);

        if (enterDrone)
        {
            cameraRig.transform.position = offsetVRmais;
            camVR.transform.GetChild(0).gameObject.SetActive(true);
            Debug.Log("Child entrou!!!!");
        }

        else
        {
            cameraRig.transform.position = offsetVRmenos;
            camVR.transform.GetChild(0).gameObject.SetActive(false);
            Debug.Log("Child saiu!!!!");
        }
    }
}
