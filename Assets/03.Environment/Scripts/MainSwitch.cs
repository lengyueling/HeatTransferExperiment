﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
public class MainSwitch : MonoBehaviour
{
   
     public void MainSwitchControl()
    {
       // if (Input.GetKeyDown(KeyCode.F))
      //  {

            transform.DOLocalMoveZ(5.354f, 0.5f);
            StartCoroutine(CloseTimer());
      
       // }
    }
    IEnumerator CloseTimer()
    {
        yield return new WaitForSeconds(1f);
        transform.DOLocalMoveZ(5.431487f, 0.5f);
    }

}


