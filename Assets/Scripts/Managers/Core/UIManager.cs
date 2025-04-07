using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager
{
    int m_order = 0;

    Stack<UI_Popup> m_popupStack = new();

    public T ShowPopupUI<T>(string name = null) where T : UI_Popup
    {
        if (string.IsNullOrEmpty(name))
            name = typeof(T).Name;

        GameObject go = Managers.Resource.Instantiate($"UI/Popup/{name}");
        T popup = Util.GetOrAddComponent<T>(go);
        m_popupStack.Push(popup);
        return popup;
    }

    public void ClosePopupUI(UI_Popup popup)
    {
        if (m_popupStack.Count == 0)
            return;

        if (m_popupStack.Peek() != popup)
        {
            Debug.Log("Close Popup Failed");
            return;
        }

        ClosePopupUI();
    }

    public void ClosePopupUI()
    {
        if (m_popupStack.Count == 0)
            return;

        UI_Popup popup = m_popupStack.Pop();
        Managers.Resource.Destroy(popup.gameObject);
        popup = null;
        m_order--;
    }

    public void CloseAllPopupUI()
    {
        while (m_popupStack.Count > 0)
            ClosePopupUI();
    }
}
