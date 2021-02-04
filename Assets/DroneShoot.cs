using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneShoot : MonoBehaviour {

    public Rigidbody laserBeam;
    float laserSpeed = 200.0f;
    float laserLife = 1.0f;
    public GameObject shotOrigin;

    // Use this for initialization
    void Start() {
        InvokeRepeating("ShootRep", 0.0f, 0.5f);
    }


    void ShootRep() {

        //Quaternion rot = new Quaternion(transform.rotation.x+90.0f, transform.rotation.y, transform.rotation.z, transform.rotation.w);
        Rigidbody clone_laserBeam = Instantiate(laserBeam, shotOrigin.transform.position, shotOrigin.transform.rotation) as Rigidbody; //transform.position ou rotation  OU deve ser laserBeam.position ou rotation
        clone_laserBeam.AddForce(shotOrigin.transform.right * laserSpeed * Time.deltaTime*50, ForceMode.VelocityChange);
        Destroy(clone_laserBeam.gameObject, laserLife);
    }
}
