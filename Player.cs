using UnityEngine;


public class Player : MonoBehaviour
{
	public CharacterController2D controller;// controleri
	public float RunSpeed =  40f;// modzraobis sichqare
	public float HorizontalMove = 0f;//horizontaluri modzraoba
	bool jump = false;// true an false
	bool crounch = false;// true an false
    void Update()
    {
        HorizontalMove = Input.GetAxisRaw("Horizontal") * RunSpeed;//igebs informacias gilakebidan da amravlebs modzraobaze
        if (Input.GetButtonDown("Jump"))//tu miigo up gilaki mashi axtoma shesruldes
        {
            jump = true;
        }
        if (Input.GetButtonDown("crouch"))//miige gilaki down tu miigo mashin chaikuzos
        {
            crounch = true;
        }else if (Input.GetButtonUp("crouch"))//da tu es gilaki ar mushaobs mashin ar chaikuzos
        {
            crounch = false;
        }
    }
     void FixedUpdate()
    {
        controller.Move(HorizontalMove * Time.fixedDeltaTime ,crounch,jump);
        jump = false;
    }
}
