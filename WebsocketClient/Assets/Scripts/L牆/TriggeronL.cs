using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeronL : MonoBehaviour
{
    public enum TriggerSpot { T0, T1, T2, T3, T4, T5 };
    public TriggerSpot TSpot = TriggerSpot.T0;
    public GameObject[] TriggerArea;
    CanvasContorl c;
    // Start is called before the first frame update
    void Start()
    {
        c = FindObjectOfType<CanvasContorl>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject != null) {
            CanvasContorl c = FindObjectOfType<CanvasContorl>();
            if (this.TSpot == TriggerSpot.T0) {
                
                c.AtoB();
                TriggerArea[0].SetActive(false);
                
                //print("1111111111111");
            }
            if (this.TSpot == TriggerSpot.T1) {
                c.CtoD();
                TriggerArea[1].SetActive(false);
                //print("2222222222222");
            }
            if (this.TSpot == TriggerSpot.T2)
            {
                c.GtoH();
                TriggerArea[2].SetActive(false);
                //print("333333333333333");
            }
            if (this.TSpot == TriggerSpot.T3)
            {
                c.JtoK();
                TriggerArea[3].SetActive(false);
                //print("4444444444444444");
            }
        }
    }
}
