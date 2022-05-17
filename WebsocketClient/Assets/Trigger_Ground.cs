using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Ground : MonoBehaviour
{
    public enum Ground_Event { T1, T2, T_L, T_R};
    public Ground_Event EventNum = Ground_Event.T1;
    public GameObject[] trigger_area;
    Ground g;
    
    
   // public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        g = FindObjectOfType<Ground>();
        for (int i = 0; i < trigger_area.Length; i++) {
            trigger_area[i].SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject != null)
        {
            //print("a");
            if (this.EventNum == Ground_Event.T1)
            {
                g.Walking1();
                trigger_area[0].SetActive(false);

            }
            if (this.EventNum == Ground_Event.T2)
            {
                g.Walking2();
                trigger_area[1].SetActive(false);

            }
            if (this.EventNum == Ground_Event.T_L)
            {
                //g.Rotate_L();

            }
            if (this.EventNum == Ground_Event.T_R)
            {
               // g.Rotate_R();

            }
           
        }
    }
}
