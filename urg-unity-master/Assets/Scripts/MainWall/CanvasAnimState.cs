using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CanvasAnimState : MonoBehaviour
{

    public Animator[] btn_anim;
    public Animator[] anim;
    public AudioSource audi;
    public AudioSource audi_a;
    public AudioClip[] SE;
    public Collider[] triggerBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            
            if (!(btn_anim[0].GetBool("IsTouch"))) { 
                PlaySE();
                audi_a.PlayOneShot(SE[1]);
            }
           
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
            if (!(btn_anim[1].GetBool("IsTouch")))
            {
                PlaySE();
                audi_a.PlayOneShot(SE[2]);
            }
            
            anim[0].SetBool("Anim1", true);
            btn_anim[1].SetBool("IsTouch", true);
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            if (!(btn_anim[2].GetBool("IsTouch")))
            {
                PlaySE();
                audi_a.PlayOneShot(SE[3]);
            }
            
            anim[0].SetBool("Anim2", true);
            btn_anim[2].SetBool("IsTouch", true);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (!(btn_anim[3].GetBool("IsTouch")))
            {
                PlaySE();
                audi_a.PlayOneShot(SE[4]);
            }
            
            anim[0].SetBool("Anim3", true);
            btn_anim[3].SetBool("IsTouch", true);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            if (!(btn_anim[4].GetBool("IsTouch")))
            {
                PlaySE();
                audi_a.PlayOneShot(SE[5]);
            }
            
            anim[0].SetBool("Anim4", true);
            btn_anim[4].SetBool("IsTouch", true);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!(btn_anim[5].GetBool("IsTouch")))
            {
                PlaySE();
                audi_a.PlayOneShot(SE[6]);
            }
            
            anim[0].SetBool("Anim5", true);
            btn_anim[5].SetBool("IsTouch", true);
        }
    }
    public void RecoverAnim0()
    {
        btn_anim[0].SetBool("IsTouch", false);
        triggerBox[0].enabled = true;
        anim[0].SetBool("Anim0", false);
        
    }
    public void RecoverAnim1()
    {
        btn_anim[1].SetBool("IsTouch", false);
        triggerBox[1].enabled = true;
        anim[0].SetBool("Anim1", false);
    }
    public void RecoverAnim2()
    {
        btn_anim[2].SetBool("IsTouch", false);
        triggerBox[2].enabled = true;
        anim[0].SetBool("Anim2", false);
    }
    public void RecoverAnim3()
    {
        btn_anim[3].SetBool("IsTouch", false);
        triggerBox[3].enabled = true;
        anim[0].SetBool("Anim3", false);
    }
    public void RecoverAnim4()
    {
        btn_anim[4].SetBool("IsTouch", false);
        triggerBox[4].enabled = true;
        anim[0].SetBool("Anim4", false);
    }
    public void RecoverAnim5()
    {
        btn_anim[5].SetBool("IsTouch", false);
        triggerBox[5].enabled = true;
        anim[0].SetBool("Anim5", false);
    }


    public void PlaySE()
    {
       
        audi.PlayOneShot(SE[0]);
        
    }

    public void PlayAnim_SE(int index)
    {
        if (index == 0) 
        {
            print("!!!");
                PlaySE();
                audi_a.PlayOneShot(SE[1]);
            
           
        }
        else if (index == 1) 
        {
           
                PlaySE();
                audi_a.PlayOneShot(SE[2]);
            
        }
        else if (index == 2)
        {
            
                PlaySE();
                audi_a.PlayOneShot(SE[3]);
            

        }
        else if (index == 3)
        {
           

                PlaySE();
                audi_a.PlayOneShot(SE[4]);
          
        }
        else if (index == 4)
        {
            
                PlaySE();
                audi_a.PlayOneShot(SE[5]);

             
        }
        else if (index == 5)
        {
            
                PlaySE();
                audi_a.PlayOneShot(SE[6]);


        }
       
    }
   
}
