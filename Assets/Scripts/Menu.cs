/**
 * @Author: nfrazee
 * @Date:   2020-09-01T08:21:19-04:00
 * @Last modified by:   nfrazee
 * @Last modified time: 2020-09-01T08:22:38-04:00
 */



﻿
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
     public void StartGame ()
     {
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
     }
}
