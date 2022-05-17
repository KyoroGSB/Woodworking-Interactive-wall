using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public Connection c;
    private string dataTag = "wall";
    // Start is called before the first frame update
    void Start()
    {
        Connection.onOpenWS += onOpenWS;
        Connection.onMsg += onMsgReceive;

    }

    // Update is called once per frame
    void Update()
    {

    }
    //送資料給地板
    public void SendMsgTimetoWalk1() {
        c.SendMsg(dataTag + "&" + "Z_walk1");
    }
    public void SendMsgTimetoWalk2()
    {
        c.SendMsg(dataTag + "&" + "Z_walk2");
    }
    public void SendMsgTimetoRotate() {
        c.SendMsg(dataTag + "&" + "Z_rotate");
    }
    public void SendMsgTimetoDefault()
    {
        c.SendMsg(dataTag + "&" + "Z_default");
    }
    public void SendMsgTimetoRain()
    {
        c.SendMsg(dataTag + "&" + "rain");
    }
    public void SendMsgReLoad()
    {
        c.SendMsg(dataTag + "&" + "restart");
    }
    public void SendMsgToGround() {
        c.SendMsg(dataTag + "&" + "");
    }
   
    public void onClickTestMsg()
    {
        c.SendMsg(dataTag + "&" + "abc");
    }
    void onMsgReceive(string s)
    {
        //Debug.Log("ground receive:" + s);
        if (s == "walk1") {
            CanvasContorl c = FindObjectOfType<CanvasContorl>();
            c.Walk_EtoF();
            c.closeAllTrigger();
        }
        if (s == "walk2")
        {
            CanvasContorl c = FindObjectOfType<CanvasContorl>();
            c.Walk_HtoI();
        }
    }
    void onOpenWS()
    {
        onClickTestMsg();
    }
}
