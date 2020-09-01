/**
 * @Author: nfrazee
 * @Date:   2020-08-31T23:52:57-04:00
 * @Last modified by:   nfrazee
 * @Last modified time: 2020-08-31T23:57:24-04:00
 */



﻿using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelComplete : MonoBehaviour
{

     public void LoadNextLevel ()
     {
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
     }
}
