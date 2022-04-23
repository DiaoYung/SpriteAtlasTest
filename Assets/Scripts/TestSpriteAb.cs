using System;
using System.Collections;
using System.Collections.Generic;
using QAssetBundle;
using QFramework;
using UnityEngine;

public class TestSpriteAb : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        ResKit.Init();
    }

    void Start()
    {
        var resLoader = ResLoader.Allocate();
        var prefab = resLoader.LoadSync<GameObject>("UIRoot");
        var uiRoot = GameObject.Instantiate(prefab, transform,false);
        uiRoot.transform.localPosition = Vector3.one;
        uiRoot.transform.localScale = Vector3.one;
        
        // resLoader.Recycle2Cache();
        // resLoader = null;
    }
}
