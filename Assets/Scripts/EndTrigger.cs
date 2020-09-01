/**
 * @Author: nfrazee
 * @Date:   2020-08-31T19:24:23-04:00
 * @Last modified by:   nfrazee
 * @Last modified time: 2020-08-31T19:35:58-04:00
 */



﻿using UnityEngine;

public class EndTrigger : MonoBehaviour
{
     public GameManager gameManager;
     void OnTriggerEnter ()
     {
          gameManager.CompleteLevel();
     }
}
