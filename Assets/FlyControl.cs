using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FlyControl : MonoBehaviour {

    public float shipSpeed = 5.0f;
    private Vector3 shipPos;
    private Vector3 endPos;
    float shipH;
    float shipV;
    public float life = 100f;
    //public float speed = 20f;
    GenerateInfinite life_text;
    public static int weapon_qty = 1;
    public int weapon_lvl = 1;
    public GameObject weapon;

    
    // Update a cada frame
    void Update () {

        if (life <= 0){
            this.gameObject.SetActive(false);
        }
        //Show weapons
        weapon.transform.GetChild(0).gameObject.SetActive(weapon_qty != 2);
        weapon.transform.GetChild(1).gameObject.SetActive(weapon_qty != 1);
        weapon.transform.GetChild(2).gameObject.SetActive(weapon_qty != 1);
        
        shipH = Input.GetAxis("Horizontal");
        shipV = Input.GetAxis("Vertical");

        if (shipH > 0 && transform.position.x > 10){
            shipH = 0;
        } else if (shipH < 0 && transform.position.x < -10){
            shipH = 0;
        }
        
        if (shipV > 0 && transform.position.y > 15){
            shipV = 0;
        } else if (shipV < 0 && transform.position.y < 7){
            shipV = 0;
        }


        shipPos = new Vector3(shipH, shipV);
        
        if (transform.rotation.z < 0.2 && shipH < 0 ||
            transform.rotation.z > -0.2 && shipH > 0){
                transform.Rotate(0, 0, shipH * -5);
                Debug.Log(transform.rotation.z);
        }

        if (transform.rotation.z > 0.01 && shipH == 0f){
            transform.Rotate(0,0,-1);
        } else if (transform.rotation.z < -0.01 && shipH == 0f){
            transform.Rotate(0,0,1);
        }
        
        transform.position += (shipPos * shipSpeed * Time.deltaTime);
        //transform.position += transform.forward * speed * (Time.deltaTime);

        

        //transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(endPos), Mathf.Deg2Rad * (100.0f));
        
	}

    
        
        
    }
    

