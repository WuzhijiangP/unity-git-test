using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonController : MonoBehaviour, IPointerClickHandler
{
    VideoPlayerController videoPlayerController;

    void Start()
    {
        videoPlayerController = GameObject.Find("GameManager").GetComponent<VideoPlayerController>();
    }

    public void OnButtonClick()
    {
        // string fileName = GameObject.FindGameObjectWithTag("Sprite").GetComponent<Image>().sprite.name + ".mp4";
        // Debug.Log(fileName + ".mp4");
        // videoPlayerController.PlayVideo(fileName); // 更改为你的视频文件名
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject clickedButton = eventData.pointerPress;

        if (clickedButton != null)
        {
            // 在这里你可以对点击到的按钮游戏对象进行操作
            Debug.Log("你点击了按钮：" + clickedButton.name);

            string fileName = clickedButton.GetComponentInChildren<Image>().sprite.name + ".mp4";
            Debug.Log(fileName);
            videoPlayerController.PlayVideo(fileName); // 更改为你的视频文件名
        }
    }
}
