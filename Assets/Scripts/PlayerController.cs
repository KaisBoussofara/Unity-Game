using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class PlayerController : MonoBehaviour
{

    [SerializeField] float Speed = 15f; // spped 
    [SerializeField] float xRange = 7f;
    [SerializeField] float posPit = -5f;
    [SerializeField] float ControlPit = -30f;
    [SerializeField] float posYaw = 5f;
    [SerializeField] float ControlRow = -20f;
    float yThrow, xThrow;
   public bool Controller = true; 
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Controller) // when U can controll ure SpaceShip for indicate it
        {
            Change_Cords(); // manipulate  postion 
           ChangeRot(); //manipulate rotation
        }
     }
    void OnDeath()
    {
        Controller = false; // on death when you r SpaceShip die disable the controll on it 
    }
void Change_Cords()
    {
         xThrow = CrossPlatformInputManager.GetAxis("Horizontal"); // get axe Horizantle by press W or D 
         yThrow = CrossPlatformInputManager.GetAxis("Vertical"); //get axe verticale by press Z or S

        float xoffset = Speed * xThrow * Time.deltaTime; // multiplie this var with speed  (en ft de time )
        float yoffset = Speed * yThrow * Time.deltaTime;

        float xRaw = transform.localPosition.x + xoffset; // add it the local postion 
        float yRaw = transform.localPosition.y + yoffset;

        float xClamp = Mathf.Clamp(xRaw, -xRange, xRange); // l'intervalle de direction horizantale que vous ne pouvez pas le dépasser 
        float yClamp = Mathf.Clamp(yRaw, -4f, 4f);// l'intervalle de direction verticale que vous ne pouvez pas le dépasser



        transform.localPosition = new Vector3(xClamp, yClamp, transform.localPosition.z); // cree la nouvelle pos qui va etre changé en ft du temps et l'affecter au pos du SpaceShip
     
        
     

    }
    void ChangeRot()
    {
        float pitchPos = transform.localPosition.y * posPit;
        float pitchControl = yThrow * ControlPit;
        float pitch = pitchControl + pitchPos;
        float yaw = transform.localPosition.x * posYaw; // same for Rotation
        float raw = xThrow * ControlRow;

        transform.localRotation = Quaternion.Euler(pitch, yaw, raw); 
    }
}

