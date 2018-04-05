using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {

     Animator animator;

  	void Start () {
        //getting the Animator component
        animator = GetComponent<Animator>();
    }
    	
    //Setting the parameter of the controller
	public void SetHoverTrue () {
        animator.SetBool("HoverEnter", true);
    }
    public void SetHoverFalse()
    {
        animator.SetBool("HoverEnter", false);
    }
}
