using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceNode : INode
{
    List<INode> children;

    public SequenceNode() { children = new List<INode>(); }

    public void Add(INode node) { children.Add(node); }


    public INode.STATE Evaluate()
    {
        if (children.Count <= 0)
            return INode.STATE.FAILED;

        foreach (INode child in children)
        {
            INode.STATE state = child.Evaluate();
            switch(state) // child의 state가 모두 success면 성공을 반환
            {
                case INode.STATE.SUCCESS:
                    continue;
                case INode.STATE.RUN:
                    return INode.STATE.RUN;
                case INode.STATE.FAILED:
                    return INode.STATE.FAILED;
            }
        }

        return INode.STATE.SUCCESS;
    }
}