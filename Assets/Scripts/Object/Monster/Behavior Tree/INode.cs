using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface INode
{ 
    public enum STATE
    { RUNNING, SUCCESS, FAILURE } // ���� ��, ����, ����

    public INode.STATE Evaluate(); // �Ǵ��Ͽ� ���� ����
}
