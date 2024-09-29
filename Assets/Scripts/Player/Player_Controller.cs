using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// this class is Responsable for Movement of Player Character using touch and drag finger.
/// </summary>
public class Player_Controller : MonoBehaviour
{
    private void Start()
    {
        //  Get_MovementLimitation();
    }
    void Update()
    {
        //Movement();
        NewMovement();
    }



    float FirstTouch;
    float SecondTouch;
    float difference;
    float clicked;
    [SerializeField] float MoveSpeed;
    void Movement()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FirstTouch = Input.mousePosition.x;
            clicked = transform.position.x;
        }
        else
        {
            if (Input.GetMouseButton(0))
            {
                SecondTouch = Input.mousePosition.x;
                difference = SecondTouch - FirstTouch;
                difference *= MoveSpeed * Time.deltaTime;
                difference = clicked + difference;
                transform.position = new Vector3(difference, transform.position.y, transform.position.z);
                //Set_MovementLimitation();
                // print(difference);
            }
        }
    }


    void NewMovement()
    {
        difference = Input.GetAxis("Mouse X");
        transform.Translate(difference, 0, 0); // = new Vector3(difference, transform.position.y, transform.position.z);
    }
    //[SerializeField] float Left_Limit;
    // [SerializeField] float Right_Limit;

    // float Left_Limit_Redution;
    // float Right_Limit_Redution;
    // void Get_MovementLimitation()
    // {
    //     Right_Limit = Screen.width - Right_Limit;
    // }
    // float Limit;
    // void Set_MovementLimitation()
    // {
    //     Limit = Mathf.Clamp(Limit, Left_Limit, Right_Limit);
    //     print(Limit);
    //     transform.position = new Vector3(Limit, transform.position.y, transform.position.z);
    // }
}
