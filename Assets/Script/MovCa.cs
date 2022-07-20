using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCa : MonoBehaviour
{

 public bool activeTP;

    public Transform posTP;
    public Transform posPP;

    //Camara TP
    public float rotSpeed;
    public float rotMin, rotMax;
    float mouseX, mouseY;
    public Transform target, player;
    
   /* public float speedH;

    public float speedV;

    float yaw;
    float pitch;*/
     //public float velocidad = 1.0f;

    //public float velAngular = 45.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*transform.Rotate(0,velAngular*Input.GetAxis("Horizontal"),0);
         if(Input.GetKey(KeyCode.W))transform.Translate(0,0,velocidad*Time.deltaTime);
       /* yaw+=speedH*Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch,yaw,0.0f);
       /*  if(Input.GetKey(KeyCode.Space))velocidad=velocidad+0.005f;
        if(Input.GetKey(KeyCode.LeftControl)){
            if(velocidad>=0.005f)velocidad=velocidad-0.005f;
            }
        if(Input.GetKey(KeyCode.D))transform.Rotate(0,velAngular*Time.deltaTime,0);
        if(Input.GetKey(KeyCode.A))transform.Rotate(0,-velAngular*Time.deltaTime,0);
        if(Input.GetKey(KeyCode.W))transform.Translate(0,0,velocidad*Time.deltaTime);
        if(Input.GetKey(KeyCode.S))transform.Translate(0,0,-velocidad*Time.deltaTime);*/
    }
 public void Cam()
    {
        mouseX += rotSpeed * Input.GetAxis("Mouse X");
        mouseY -= rotSpeed * Input.GetAxis("Mouse Y");
        //transform.eulerAngles= new Vector3(mouseY,mouseX,0.0f);
        mouseY = Mathf.Clamp(mouseY, rotMin, rotMax);

       target.rotation = Quaternion.Euler(mouseY, mouseX, 0.0f);
        player.rotation = Quaternion.Euler(0.0f, mouseX, 0.0f);
    }

    void LateUpdate()
    {
        Cam();

        if (activeTP == false && Input.GetKeyDown(KeyCode.Tab))
        {
            activeTP = true;
            transform.position = posPP.position;
        }
        else if(activeTP == true && Input.GetKeyDown(KeyCode.Tab))
        {
            activeTP = false;
            transform.position = posTP.position;
            transform.LookAt(player);
        }
    }   
}
