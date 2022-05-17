using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using NativeWebSocket;

public class Connection : MonoBehaviour
{
  WebSocket websocket;
    public string path="";
    // Start is called before the first frame update
    public delegate void onMsgReceive(string s);
    public static  onMsgReceive onMsg;
    public delegate void onOpenWebsocekt();
    public static onOpenWebsocekt onOpenWS;
    async void Start()
  {
    websocket = new WebSocket("ws://140.124.80.31:12345");

    websocket.OnOpen += () =>
    {
      Debug.Log("Connection open!");
        onOpenWS();
    };

    websocket.OnError += (e) =>
    {
      Debug.Log("Error! " + e);
    };

    websocket.OnClose += (e) =>
    {
      Debug.Log("Connection closed!"+e);
    };

    websocket.OnMessage += (bytes) =>
    {
      // Reading a plain text message
      var message = System.Text.Encoding.UTF8.GetString(bytes);
      Debug.Log("OnMessage! " + message);
        onMsg(message);
    };

    // Keep sending messages at every 0.3s
    //InvokeRepeating("SendWebSocketMessage", 0.0f, 0.3f);

    await websocket.Connect();
  }

  void Update()
  {
    #if !UNITY_WEBGL || UNITY_EDITOR
      websocket.DispatchMessageQueue();
    #endif
  }

  async void SendWebSocketMessage()
  {
    if (websocket.State == WebSocketState.Open)
    {
      // Sending bytes
     // await websocket.Send(new byte[] { 10, 20, 30 });

      // Sending plain text
      await websocket.SendText("plain text message");
    }
  }
   public  void SendMsg(String msg)
  {
    if (websocket.State == WebSocketState.Open)
    {
      // Sending bytes
      // await websocket.Send(new byte[] { 10, 20, 30 });

      // Sending plain text
       websocket.SendText(msg);
    }
  }
  private async void OnApplicationQuit()
  {
    await websocket.Close();
  }
}
