using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadSc : MonoBehaviour
{
    Wall w;
    // Start is called before the first frame update
    void Start()
    {
        w = FindObjectOfType<Wall>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other != null) {
            w.SendMsgReLoad();
            SceneManager.LoadScene(1);
        }
    }
}
