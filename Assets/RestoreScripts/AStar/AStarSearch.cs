/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AStarSearch<Node> // TypeDefIndex: 31372
    where Node : AStarNode
{
    // Fields
    private static int MAX_SEARCH_ITERATION = 1000;
    private AStarRequest _request = new AStarRequest();
    private List<Node> _openList = new List<Node>();
    private List<Node> _closeList = new List<Node>();
    private Dictionary<Node, Node> _cameFrom = new Dictionary<Node, Node>();

    // Nested types
    public class AStarRequest // TypeDefIndex: 31373
    {
        // Fields
        public Node start;
        public Node goal;
        public AStarStatus status;
        public List<Node> result = new List<Node>();
    }

    public abstract class EdgeValidator // TypeDefIndex: 31374
    {
        // Constructors
        protected EdgeValidator() { }//0x18775A550

        // Methods
        public abstract bool Check(Node node1, Node node2);
    }

    // Methods
    public AStarStatus Search(Node start, Node goal, EdgeValidator edgeCond, List<Node> resultPath)
    {
        CleanSearch();
        _request.start = start;
        _request.goal = goal;
        _request.status = AStarStatus.Searching;
        _request.result = resultPath;
        _request.result.Clear();
        start.gScore = 0f;
        var startPos = start.position;
        var goalPos = goal.position;
        start.fScore = AIMath.DistanceManhattan(startPos, goalPos);
        _cameFrom[start] = null;
        InsertToOpen(start);

        for (int i = 0; i < MAX_SEARCH_ITERATION; i++)
        {
            if (_request.status != AStarStatus.Searching) break;
            if (_openList.Count == 0)
            {
                SetResult(AStarStatus.Empty, null, resultPath);
                break;
            }
            Node firstNode = _openList[0];
            if (firstNode == _request.goal)
            {
                SetResult(AStarStatus.Complete, firstNode, resultPath);
                break;
            }
            _openList.Remove(firstNode);
            _closeList.Add(firstNode);
            foreach (Node neighbour in firstNode.neighbours)
            {
                if (edgeCond.Check(firstNode, neighbour))
                {
                    if (!_closeList.Contains(neighbour))
                    {
                        float dist = AIMath.Distance(neighbour.position, firstNode.position) + firstNode.gScore;
                        if (!_openList.Contains(neighbour) || neighbour.gScore > dist)
                        {
                            neighbour.gScore = dist;
                            neighbour.fScore = AIMath.DistanceManhattan(neighbour.position, _request.goal.position);
                            _cameFrom[neighbour] = firstNode;
                            InsertToOpen(neighbour);
                        }
                    }
                }
            }
            if (_openList.Count == 0)
            {
                SetResult(AStarStatus.Partial, firstNode, resultPath);
                break;
            }
        }
        return _request.status;
    }//0x187758610
    private void InsertToOpen(Node node)
    {
        for (int i = 0; i < _openList.Count; i++)
        {
            if (_openList[i].fScore > node.fScore)
            {
                _openList.Insert(i, node);
                return;
            }
        }
        _openList.Add(node);
    }//0x1877584C0
    private void SetResult(AStarStatus resultStatus, Node finishNode, List<Node> resultPath)
    {
        _request.status = resultStatus;
        if (finishNode != null && resultPath != null && (resultStatus == AStarStatus.Complete || resultStatus == AStarStatus.Partial))
        {
            do
            {
                _request.result.Insert(0, finishNode);
                finishNode = _cameFrom[finishNode];
            }
            while (finishNode != null);
            foreach (var result in _request.result)
            {
                resultPath.Add(_request.result[0]);
            }
        }
    }//0x187758F80
    private void CleanSearch()
    {
        foreach (var node in _openList)
        {
            node.ResetSearch();
        }
        foreach (var node in _closeList)
        {
            node.ResetSearch();
        }
        foreach (var node in _request.result)
        {
            node.ResetSearch();
        }
        _openList.Clear();
        _closeList.Clear();
        _cameFrom.Clear();
    }//0x187757E80
}

