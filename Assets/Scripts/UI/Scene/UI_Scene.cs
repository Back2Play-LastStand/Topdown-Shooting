using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Scene : UI_Base
{
    void Start()
    {
        Managers.UI.SetCanvas(gameObject, false);
    }
}
