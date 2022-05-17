using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
public class CanvasContorl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] canvas;
    public Animator[] anim_m;
    public GameObject[] BG;
    public GameObject[] Trigger;
    Wall w;
    public AudioSource[] audi;

    public AudioClip[] sounds;
    public GameObject videoPlayer;
    public GameObject fishChair;
    public GameObject ThridMachine;
    TriggeronL triggeronL;
    void Start()
    {
        fishChair.SetActive(false);
        videoPlayer.GetComponent<VideoPlayer>().Stop();
        w = FindObjectOfType<Wall>();
        foreach (GameObject a in canvas) {
            a.SetActive(false);
        }
        foreach (GameObject a in BG)
        {
            a.SetActive(false);
        }
        foreach (GameObject a in Trigger)
        {
            a.SetActive(false);
        }
        canvas[0].SetActive(true);
        canvas[1].SetActive(true);
        BG[0].SetActive(true);
        Trigger[0].SetActive(true);
        videoPlayer.GetComponent<VideoPlayer>().Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) {
            AtoB();
            //triggeronL.TriggerArea[0].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            CtoD();
            //triggeronL.TriggerArea[1].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.E)) {
            //走路事件
            Walk_EtoF();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            GtoH();
           // triggeronL.TriggerArea[2].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            Walk_HtoI();
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            JtoK();
            //triggeronL.TriggerArea[3].SetActive(false);
        }
        
        if (Input.GetKeyDown(KeyCode.P))
        {
            w.SendMsgReLoad();
            SceneManager.LoadScene(1);
        }
    }



    //動畫插入事件
    public void moveFirstmachine() {
        anim_m[0].SetBool("Move", true);

    }
    public void moveSecondmachine() {
        BG[2].SetActive(true);
        canvas[0].GetComponent<Animator>().SetBool("F_move", true);
        EtoF();
    }
    public void dragonDoor_MoveIn() {
        anim_m[1].SetBool("MoveIn", true);

    }
    public void hand_MoveIn()
    {
        anim_m[2].SetBool("Move", true);
       // anim_m[3].SetBool("Move", true);

    }
    public void D_StartCollect() {

        canvas[4].GetComponent<Animator>().SetBool("IsCollect", true);

    }
    public void H_StartCollect() {
        canvas[7].GetComponent<Animator>().SetBool("IsCollect", true);
    }
    public void K_StartEnd()
    {
        canvas[10].GetComponent<Animator>().SetBool("IsEnd", true);
    }
    //Canvas切換事件
    public void AtoB() {
        canvas[2].SetActive(true);
        canvas[1].SetActive(false);
        BG[1].SetActive(true);
        canvas[2].GetComponent<Animator>().SetBool("IsTrigger", true);
        canvas[0].GetComponent<Animator>().SetBool("B_move", true);
    }
    public void BtoC() {
        canvas[3].SetActive(true);
        canvas[2].SetActive(false);


        Trigger[1].SetActive(true);
       
    }
    public void CtoD()
    {
        BG[0].SetActive(false);
        canvas[4].SetActive(true);
        canvas[3].SetActive(false);
        anim_m[0].SetBool("Play", true);
        closeAllTrigger();
    }
    public void DtoE()
    {
        canvas[5].SetActive(true);
        canvas[4].SetActive(false);
        openWalkTrigger();
    }
    public void EtoF()
    {
        w.SendMsgTimetoDefault();
        canvas[6].SetActive(true);
        canvas[5].SetActive(false);
        Trigger[2].SetActive(true);
       
    }
    public void GtoH()
    {
        BG[1].SetActive(false);
        canvas[7].SetActive(true);
        canvas[6].SetActive(false);
        anim_m[1].SetBool("Play", true);
        closeAllTrigger();
    }
    public void HtoI()
    {
        BG[3].SetActive(true);
        canvas[8].SetActive(true);
        canvas[7].SetActive(false);
        openWalk2Trigger();
    }
    public void ItoJ()
    {
        canvas[9].SetActive(true);
        canvas[8].SetActive(false);
        Trigger[3].SetActive(true);
        
    }
    public void JtoK()
    {
        anim_m[2].SetBool("Play", true);
        //anim_m[3].SetBool("Play", true);
        canvas[10].SetActive(true);
        canvas[9].SetActive(false);
        closeAllTrigger();
    }
    public void KtoR() {
        ThridMachine.SetActive(false);
        canvas[11].SetActive(true);
        canvas[10].SetActive(false);
        fishChair.SetActive(true);
        audi[0].clip = sounds[5];
        audi[0].Play();
        audi[1].clip = sounds[6];
        audi[1].Play();
        videoPlayer.GetComponent<VideoPlayer>().Play();
        TimetoRain();
    }
    //送給地面
    public void openWalkTrigger() {
        w.SendMsgTimetoWalk1();
    }
    public void openWalk2Trigger()
    {
        w.SendMsgTimetoWalk2();
    }
    public void openRotateTrigger()
    {
        w.SendMsgTimetoRotate();
    }
    public void closeAllTrigger() {
        w.SendMsgTimetoDefault();
    }
    public void TimetoRain()
    {
        w.SendMsgTimetoRain();
    }
   
    //地面Trigger事件
    public void Walk_EtoF() {
        canvas[0].GetComponent<Animator>().SetBool("E_move",true);
        canvas[5].GetComponent<Animator>().SetBool("IsWalking",true);
        anim_m[0].SetBool("Move_2",true);
    }
    public void Walk_HtoI() {
        canvas[0].GetComponent<Animator>().SetBool("I_move", true);
        canvas[8].GetComponent<Animator>().SetBool("IsWalking", true);
        anim_m[1].SetBool("Move_2", true);
    }

}
