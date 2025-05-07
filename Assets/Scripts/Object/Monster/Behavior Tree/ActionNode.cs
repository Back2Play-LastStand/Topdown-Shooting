using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionNode : INode
{
    public Func<INode.STATE> action;

    public ActionNode(Func<INode.STATE> action)
    {
        this.action = action;
    }

    public INode.STATE Evaluate()
    {
        // �븮�ڰ� null �� �ƴ� �� ȣ��, null �� ��� Failed ��ȯ
        return action?.Invoke() ?? INode.STATE.FAILED;
    }
}
