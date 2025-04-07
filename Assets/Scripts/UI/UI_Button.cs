using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Button : UI_Base
{

    enum Buttons
    {
    }

    enum Texts
    {
    }

    enum GameObjects
    {
    }

    enum Images
    {
    }

    private void Start()
    {
        Bind<Button>(typeof(Buttons));
        Bind<Text>(typeof(Texts));
        Bind<GameObject>(typeof(GameObjects));
        Bind<Image>(typeof(Images));
    }
}
