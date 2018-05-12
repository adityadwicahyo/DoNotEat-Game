using UnityEngine;
using System.Collections;

public class MenuAction : MonoBehaviour {

    public void MENU_ACTION_GotoPage(string sceneName){
        Application.LoadLevel(sceneName);
    }

}
