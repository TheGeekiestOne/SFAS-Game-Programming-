using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Created by : Ayran Olckers
 * 01/2020
 */
public class ButtonClickController : MonoBehaviour {

    public void OnPauseClick() {
        GameObject.Find("WorldManager").GetComponent<UImanager>().TogglePause();
    }
}
