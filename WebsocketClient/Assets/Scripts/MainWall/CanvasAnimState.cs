using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasAnimState : MonoBehaviour
{

    public Animator[] btn_anim;
    public Animator[] anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            anim[0].SetBool("Anim0", true);
            btn_anim[0].SetBool("IsTouch", true);
            //anim[0].SetBool("Anim1", true);
            //anim[0].SetBool("Anim2", true);
            //anim[0].SetBool("Anim3", true);
            //anim[0].SetBool("Anim4", true);
            //anim[0].SetBool("Anim5", true);
            //btn_anim[2].SetBool("IsTouch", true);

        }
        if (Input.GetKeyDown(KeyCode.Y)) {
            anim[0].SetBool("Anim1", true);
            btn_anim[1].SetBool("IsTouch", true);
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            anim[0].SetBool("Anim2", true);
            btn_anim[2].SetBool("IsTouch", true);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            anim[0].SetBool("Anim3", true);
            btn_anim[3].SetBool("IsTouch", true);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            anim[0].SetBool("Anim4", true);
            btn_anim[4].SetBool("IsTouch", true);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            anim[0].SetBool("Anim5", true);
            btn_anim[5].SetBool("IsTouch", true);
        }
    }
    public void RecoverAnim0()
    {
        btn_anim[0].SetBool("IsTouch", false);
        anim[0].SetBool("Anim0", false);
    }
    public void RecoverAnim1()
    {
        btn_anim[1].SetBool("IsTouch", false);
        anim[0].SetBool("Anim1", false);
    }
    public void RecoverAnim2()
    {
        btn_anim[2].SetBool("IsTouch", false);
        anim[0].SetBool("Anim2", false);
    }
    public void RecoverAnim3()
    {
        btn_anim[3].SetBool("IsTouch", false);
        anim[0].SetBool("Anim3", false);
    }
    public void RecoverAnim4()
    {
        btn_anim[4].SetBool("IsTouch", false);
        anim[0].SetBool("Anim4", false);
    }
    public void RecoverAnim5()
    {
        btn_anim[5].SetBool("IsTouch", false);
        anim[0].SetBool("Anim5", false);
    }
   
}
