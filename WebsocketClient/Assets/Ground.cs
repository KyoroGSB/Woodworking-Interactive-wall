using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public Connection c;
    public static  string dataTag = "ground";
    public GameObject cube;
    public GameObject[] ground_z;
    Trigger_Ground tg;

    // Start is called before the first frame update
    void Start()
    {
        tg = FindObjectOfType<Trigger_Ground>();
        Connection.onOpenWS += onOpenWS;
        Connection.onMsg += onMsgReceive;
        ground_z[0].SetActive(true);
        ground_z[1].SetActive(false);
        ground_z[2].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //送資料給牆

    public void Walking1() {
        c.SendMsg(dataTag + "&" + "walk1");
    }
    public void Walking2() {
        c.SendMsg(dataTag + "&" + "walk2");
    }
    public void Rotate_R()
    {
        c.SendMsg(dataTag + "&" + "rotate_R");
    }
    public void Rotate_L()
    {
        c.SendMsg(dataTag + "&" + "rotate_L");
    }
    public void SendMsgtoWall()
    {
        c.SendMsg(dataTag + "&" + "abc");
    }
    public void onClickTestMsg()
    {
        c.SendMsg(dataTag+ "&" + "abc");
    }
    void onMsgReceive(string s)
    {
        
        if (IsJsonStart(s))
        {
            DetectionData obj = JsonUtility.FromJson<DetectionData>(s);
            Debug.Log("ground receive:" + s);
            Debug.Log("ground receive obj:" + obj.x);
            Instantiate(cube, new Vector3(obj.x, obj.y, 0), Quaternion.identity);
        }
        else
        {
            Debug.Log("ground receive:" + s);
            if (s == "Z_walk1")
            {
                ground_z[0].SetActive(false);
                ground_z[1].SetActive(true);
                ground_z[2].SetActive(false);
                tg.trigger_area[0].SetActive(true);
            }
            if (s == "Z_walk2")
            {
                ground_z[0].SetActive(false);
                ground_z[1].SetActive(true);
                ground_z[2].SetActive(false);
                tg.trigger_area[1].SetActive(true);
            }
            if (s == "Z_rotate")
            {
                ground_z[0].SetActive(false);
                ground_z[1].SetActive(false);
                ground_z[2].SetActive(true);
                tg.trigger_area[2].SetActive(true);
                tg.trigger_area[3].SetActive(true);
            }
            if (s == "Z_default")
            {
                ground_z[0].SetActive(false);
                ground_z[1].SetActive(false);
                ground_z[2].SetActive(false);
                tg.trigger_area[0].SetActive(false);
            }
        }
    }
    private  bool IsJsonStart( string json)
    {
        if (!string.IsNullOrEmpty(json))
        {
            json = json.Trim('\r', '\n', ' ');
            if (json.Length > 1)
            {
                char s = json[0];
                char e = json[json.Length - 1];
                return (s == '{' && e == '}') || (s == '[' && e == ']');
            }
        }
        return false;
    }

    void onOpenWS()
    {
        onClickTestMsg();
    }
}
