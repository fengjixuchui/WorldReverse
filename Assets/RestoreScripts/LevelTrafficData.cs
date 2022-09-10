/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500
/// <summary>
/// 已完成-玩家导航相关?
/// 2022/09/11
/// </summary>
namespace MoleMole
{
    public class LevelTrafficData : ScriptableObject, ISerializationCallbackReceiver // TypeDefIndex: 19538
    {
        // Fields
        [SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
        private List<TrafficNodeData> _nodes = new List<TrafficNodeData>(); // 0x18
        private Dictionary<ulong, TrafficRoadData> _roads = new Dictionary<ulong, TrafficRoadData>(); // 0x20
        [SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
        private List<ulong> _roadKeys = new List<ulong>(); // 0x28
        [SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
        private List<TrafficRoadData> _roadValues = new List<TrafficRoadData>(); // 0x30

        // Properties
        public List<TrafficNodeData> nodes { /* [XID] */ /* 0x000000018970BCB0-0x000000018970BCD0 */ get => _nodes; /* [XID] */ /* 0x0000000189713640-0x0000000189713660 */ set { _nodes = value; } } // 0x0000000183A38500-0x0000000183A385A0 0x0000000183A38640-0x0000000183A386F0
        public Dictionary<ulong, TrafficRoadData> roads { /* [XID] */ /* 0x000000018971AE20-0x000000018971AE40 */ get => _roads; /* [XID] */ /* 0x0000000189722160-0x0000000189722180 */ set { _roads = value; } } // 0x0000000183A385A0-0x0000000183A38640 0x0000000183A386F0-0x0000000183A387A0

        // Nested types
        [Serializable]
        public struct TrafficNodeData // TypeDefIndex: 19539
        {
            // Fields
            public int id; // 0x00
            public Vector3 pos; // 0x04
            public List<int> connections; // 0x10
            public List<int> actionPointIDs; // 0x18
        }

        [Serializable]
        public struct TrafficRoadData // TypeDefIndex: 19540
        {
            // Fields
            public bool walkable; // 0x00
            public List<Vector3> auxiliaryPoints; // 0x08
        }

        // Methods
        // [XID] // 0x00000001897298C0-0x00000001897298E0
        public static ulong GetRoadID(int node1ID, int node2ID)
        {
            if (node1ID < node2ID)
            {
                return (ulong)(node2ID | (node1ID << 32));
            }
            else
            {
                return (ulong)(node1ID | (node2ID << 32));
            }
        } // 0x0000000183A37ED0-0x0000000183A37FA0
          // [XID] // 0x0000000189731060-0x0000000189731080
        public void OnBeforeSerialize()
        {
            _roadKeys.Clear();
            _roadValues.Clear();
            foreach (var road in _roads)
            {
                _roadKeys.Add(road.Key);
                _roadValues.Add(road.Value);
            }
            _roads.GetEnumerator().Dispose();
        } // 0x0000000183A38180-0x0000000183A38400
          // [XID] // 0x0000000189738930-0x0000000189738950
        public void OnAfterDeserialize()
        {
            _roads.Clear();
            if (_roadKeys.Count == _roadValues.Count)
            {
                for (int i = 0; i < _roadKeys.Count; i++)
                {
                    _roads[_roadKeys[i]] = _roadValues[i];
                }
            }
        } // 0x0000000183A37FA0-0x0000000183A38180
    }
}
