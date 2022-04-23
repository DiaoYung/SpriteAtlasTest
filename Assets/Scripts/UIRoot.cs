using System;
using System.Collections;
using System.Collections.Generic;
using QAssetBundle;
using QFramework;
using UnityEngine;
using UnityEngine.UI;

public class UIRoot : MonoBehaviour
{
    [SerializeField] private Image Game1;
    [SerializeField] private Image Game2;
    [SerializeField] private Image Game3;
    [SerializeField] private Image Game4;
    [SerializeField] private Image Send1;
    [SerializeField] private Image Send2;
    private ResLoader mResLoader;

    private void Awake()
    {
        mResLoader = ResLoader.Allocate();
    }

    // Start is called before the first frame update
    void Start()
    {
        Game1.sprite = mResLoader.LoadSprite("scene_Enter_01");
        Game2.sprite = mResLoader.LoadSprite("scene_Enter_02");
        Game3.sprite = mResLoader.LoadSprite("scene_Enter_03");
        Game4.sprite = mResLoader.LoadSprite("scene_Enter_04");

        Send1.sprite = mResLoader.LoadSprite("send","ui_send_scene_01");
    }
}
