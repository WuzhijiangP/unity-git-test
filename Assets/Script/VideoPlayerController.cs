using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoPlayerController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject videoPlayWindow;
    public RawImage videoWindowIamge;
    public Button CloseBtn;

    string videoFileName;

    public void PlayVideo(string fileName)
    {
        videoFileName = fileName;
        videoPlayWindow.SetActive(true); // 显示视频播放窗口

        string videoPath = System.IO.Path.Combine(Application.streamingAssetsPath, videoFileName);
        videoPlayer.url = videoPath; // 设置播放器的视频路径
        videoPlayer.Play();
    }

    public void CloseVideoPlayer()
    {
        videoPlayer.Stop();
        videoPlayWindow.SetActive(false); // 隐藏视频播放窗口
    }

    private void Update()
    {
        //除了点击关闭按钮，也可以通过Esc键关闭播放
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CloseVideoPlayer();
        }
    }


}
