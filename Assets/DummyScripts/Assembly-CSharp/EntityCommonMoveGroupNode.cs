/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoThread;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class EntityCommonMoveGroupNode : IGroupNode // TypeDefIndex: 26602
{
	// Fields
	private int _dataType; // 0x14
	private int _cnt; // 0x18
	private Queue<int> _freeIndexs; // 0x20
	private static IGroup _group; // 0x00
	private EntityCommonMoveData[] _innerDatas; // 0x28
	private EntityCommonMoveTask _task; // 0x30

	// Properties
	public int index { /* [XID] */ /* 0x0000000189B08B60-0x0000000189B08BA0 */ get; set; } // 0x00000001824F8280-0x00000001824F82E0 0x00000001824F83A0-0x00000001824F8400
	public int dataType { /* [XID] */ /* 0x0000000189B1A850-0x0000000189B1A870 */ get => default; } // 0x00000001824F81E0-0x00000001824F8280 
	public int dataCnt { /* [XID] */ /* 0x0000000189B21E60-0x0000000189B21E80 */ get => default; } // 0x00000001824F8140-0x00000001824F81E0 
	public EntityCommonMoveData[] innerDatas { /* [XID] */ /* 0x0000000189B4EC00-0x0000000189B4EC20 */ get => default; } // 0x00000001824F7FA0-0x00000001824F8040 
	public INode node { /* [XID] */ /* 0x0000000189B56460-0x0000000189B56480 */ get => default; } // 0x00000001824F82E0-0x00000001824F83A0 

	// Constructors
	public EntityCommonMoveGroupNode() {} // 0x00000001824F80A0-0x00000001824F8140
	static EntityCommonMoveGroupNode() {} // 0x00000001824F8040-0x00000001824F80A0

	// Methods
	// [XID] // 0x0000000189B29440-0x0000000189B29460
	private int GetFreeIndex() => default; // 0x00000001824F78A0-0x00000001824F79E0
	// [XID] // 0x0000000189B30900-0x0000000189B30920
	private int GetFreeIndexOnly() => default; // 0x00000001824F7E40-0x00000001824F7FA0
	// [XID] // 0x0000000189BB1A20-0x0000000189BB1A40
	private void AddFreeIndex(int index) {} // 0x00000001824F7D70-0x00000001824F7E40
	// [XID] // 0x0000000189B67CD0-0x0000000189B67CF0
	public static EntityCommonMoveData GetAndAdd(Func<float> onGetDeltaTime, Func<bool> onShouldPause) => default; // 0x00000001824F7B80-0x00000001824F7D70
	// [XID] // 0x0000000189B94100-0x0000000189B94120
	public static void Remove(EntityCommonMoveData data) {} // 0x00000001824F7590-0x00000001824F76F0
	// [XID] // 0x0000000189B5DC10-0x0000000189B5DC30
	public void Init(int maxNum, IGroup group, IGraph graph, IRunnerPool runnerPool, int groupId) {} // 0x00000001824F76F0-0x00000001824F78A0
	// [XID] // 0x0000000189B65260-0x0000000189B65280
	private void InitDataPool(int maxNum) {} // 0x00000001824F71A0-0x00000001824F7300
	// [XID] // 0x0000000189B6C760-0x0000000189B6C780
	public EntityCommonMoveData GetData() => default; // 0x00000001824F7080-0x00000001824F71A0
	// [XID] // 0x00000001895EB610-0x00000001895EB630
	public void AddData(EntityCommonMoveData data) {} // 0x00000001824F79E0-0x00000001824F7B80
	// [XID] // 0x0000000189BA2F50-0x0000000189BA2F70
	public void RemoveData(EntityCommonMoveData data) {} // 0x00000001824F7400-0x00000001824F7590
	// [XID] // 0x0000000189B82EA0-0x0000000189B82EC0
	public void Destroy() {} // 0x00000001824F7300-0x00000001824F7400
}

