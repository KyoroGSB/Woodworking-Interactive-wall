using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerTest : MonoBehaviour
{
    public enum Pos { T0,T1,T2,T3,T4,T5};
    public Pos posType = Pos.T1;
    public Collider[] triggerBox;
    //public Button[] btn;
    public Animator anim;
    public Animator[] btn_anim;

    public Text t;
    CanvasAnimState cas;
    // Start is called before the first frame update
    void Start()
    {
        cas = FindObjectOfType<CanvasAnimState>();
    }

    // Update is called once per frame
    void Update()
    {
    }
   
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject != null) {
            if (this.posType == Pos.T0)
            {

                print("a");
                anim.SetBool("Anim0", true);
                btn_anim[0].SetBool("IsTouch", true);
                triggerBox[0].enabled = false;
                cas.PlayAnim_SE(0);
                //btn_anim[0].SetBool("IsTouch", true);
                //t.text = "T0";

            }
            if (this.posType == Pos.T1)
            {
                anim.SetBool("Anim1", true);
                btn_anim[1].SetBool("IsTouch", true);
                triggerBox[1].enabled = false;
                cas.PlayAnim_SE(1);
                //anim.SetBool("Anim1", true);
                // btn_anim[1].SetBool("IsTouch", true);
                //t.text = "T1";

            }
            if (this.posType == Pos.T2)
            {
                anim.SetBool("Anim2", true);
                btn_anim[2].SetBool("IsTouch", true);
                triggerBox[2].enabled = false;
                cas.PlayAnim_SE(2);
                //anim.SetBool("Anim1", true);
                //btn_anim[2].SetBool("IsTouch", true);
                //t.text = "T2";

            }
            if (this.posType == Pos.T3)
            {
                anim.SetBool("Anim3", true);
                btn_anim[3].SetBool("IsTouch", true);
                triggerBox[3].enabled = false;
                cas.PlayAnim_SE(3);
                //anim.SetBool("Anim1", true);
                //btn_anim[3].SetBool("IsTouch", true);
                //t.text = "T3";

            }
            if (this.posType == Pos.T4)
            {
                anim.SetBool("Anim4", true); 
                btn_anim[4].SetBool("IsTouch", true);
                triggerBox[4].enabled = false;
                cas.PlayAnim_SE(4);
                //anim.SetBool("Anim1", true);
                //btn_anim[4].SetBool("IsTouch", true);
                //t.text = "T4";

            }
            if (this.posType == Pos.T5)
            {
                anim.SetBool("Anim5", true);
                btn_anim[5].SetBool("IsTouch", true);
                triggerBox[5].enabled = false;
                cas.PlayAnim_SE(5);
                //anim.SetBool("Anim1", true);
                //btn_anim[5].SetBool("IsTouch", true);
                //ColorBlock cb = btn[3].colors;
                //cb.normalColor = Color.red;
                //btn[3].colors = cb;
                //t.text = "T5";

            }
        }
    }
   
    
}
