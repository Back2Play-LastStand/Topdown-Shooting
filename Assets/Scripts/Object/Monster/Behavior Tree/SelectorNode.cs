using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorNode : INode
{
    List<INode> children;

    public SelectorNode() { children = new List<INode>(); }

    public void Add(INode node) { children.Add(node); }

    public INode.STATE Evaluate()
    {
        foreach (INode child in children)
        {
            INode.STATE state = child.Evaluate();
            switch (state) // chlid�� state�� �ϳ��� success�� ��� ������ ��ȯ
            {
                case INode.STATE.SUCCESS:
                    return INode.STATE.SUCCESS;
                case INode.STATE.RUN:
                    return INode.STATE.RUN;
            }
        }

        return INode.STATE.FAILED;
    }
}