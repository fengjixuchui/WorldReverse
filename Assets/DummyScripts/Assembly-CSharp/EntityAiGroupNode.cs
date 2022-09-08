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

public class EntityAiGroupNode : IGroupNode // TypeDefIndex: 26594
{
	// Fields
	private int _dataType; // 0x14
	private int _cnt; // 0x18
	private Queue<int> _freeIndexs; // 0x20
	private static IGroup _group; // 0x00
	private EntityAiData[] _innerDatas; // 0x28
	private EntityAiTask _task; // 0x30

	// Properties
	public int index { /* [XID] */ /* 0x00000001898319F0-0x0000000189831A30 */ get; set; } // 0x00000001834680A0-0x0000000183468100 0x00000001834681C0-0x0000000183468220
	public int dataType { /* [XID] */ /* 0x0000000189843740-0x0000000189843760 */ get => default; } // 0x0000000183468000-0x00000001834680A0 
	public int dataCnt { /* [XID] */ /* 0x000000018984ACE0-0x000000018984AD00 */ get => default; } // 0x0000000183467F60-0x0000000183468000 
	public EntityAiData[] innerDatas { /* [XID] */ /* 0x0000000189876D40-0x0000000189876D60 */ get => default; } // 0x0000000183467DC0-0x0000000183467E60 
	public INode node { /* [XID] */ /* 0x000000018987E830-0x000000018987E850 */ get => default; } // 0x0000000183468100-0x00000001834681C0 

	// Constructors
	public EntityAiGroupNode() {} // 0x0000000183467EC0-0x0000000183467F60
	static EntityAiGroupNode() {} // 0x0000000183467E60-0x0000000183467EC0

	// Methods
	// [XID] // 0x0000000189851FE0-0x0000000189852000
	private int GetFreeIndex() => default; // 0x00000001834676C0-0x0000000183467800
	// [XID] // 0x00000001898599A0-0x00000001898599C0
	private int GetFreeIndexOnly() => default; // 0x0000000183467C60-0x0000000183467DC0
	// [XID] // 0x0000000189A1F7B0-0x0000000189A1F7D0
	private void AddFreeIndex(int index) {} // 0x0000000183467B90-0x0000000183467C60
	// [XID] // 0x0000000189868250-0x0000000189868270
	public static EntityAiData GetAndAdd(Func<float> onGetDeltaTime, Func<bool> onShouldPause) => default; // 0x00000001834679A0-0x0000000183467B90
	// [XID] // 0x00000001899D5280-0x00000001899D52A0
	public static void Remove(EntityAiData data) {} // 0x00000001834673B0-0x0000000183467510
	// [XID] // 0x0000000189885C50-0x0000000189885C70
	public void Init(int maxNum, IGroup group, IGraph graph, IRunnerPool runnerPool, int groupId) {} // 0x0000000183467510-0x00000001834676C0
	// [XID] // 0x000000018988CFA0-0x000000018988CFC0
	private void InitDataPool(int maxNum) {} // 0x0000000183466FC0-0x0000000183467120
	// [XID] // 0x0000000189894610-0x0000000189894630
	public EntityAiData GetData() => default; // 0x0000000183466EA0-0x0000000183466FC0
	// [XID] // 0x000000018989BC10-0x000000018989BC30
	public void AddData(EntityAiData data) {} // 0x0000000183467800-0x00000001834679A0
	// [XID] // 0x00000001898A3150-0x00000001898A3170
	public void RemoveData(EntityAiData data) {} // 0x0000000183467220-0x00000001834673B0
	// [XID] // 0x00000001898AA570-0x00000001898AA590
	public void Destroy() {} // 0x0000000183467120-0x0000000183467220
}

