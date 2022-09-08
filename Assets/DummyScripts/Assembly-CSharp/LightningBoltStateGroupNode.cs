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

public class LightningBoltStateGroupNode : IGroupNode // TypeDefIndex: 26613
{
	// Fields
	private int _dataType; // 0x14
	private int _cnt; // 0x18
	private Queue<int> _freeIndexs; // 0x20
	private static IGroup _group; // 0x00
	private LightningBoltStateData[] _innerDatas; // 0x28
	private LightningBoltStateTask _task; // 0x30

	// Properties
	public int index { /* [XID] */ /* 0x00000001898333C0-0x0000000189833400 */ get; set; } // 0x00000001841EE390-0x00000001841EE3F0 0x00000001841EE4B0-0x00000001841EE510
	public int dataType { /* [XID] */ /* 0x0000000189845070-0x0000000189845090 */ get => default; } // 0x00000001841EE2F0-0x00000001841EE390 
	public int dataCnt { /* [XID] */ /* 0x000000018984C4C0-0x000000018984C4E0 */ get => default; } // 0x00000001841EE250-0x00000001841EE2F0 
	public LightningBoltStateData[] innerDatas { /* [XID] */ /* 0x00000001898786A0-0x00000001898786C0 */ get => default; } // 0x00000001841EE0B0-0x00000001841EE150 
	public INode node { /* [XID] */ /* 0x000000018987FBD0-0x000000018987FBF0 */ get => default; } // 0x00000001841EE3F0-0x00000001841EE4B0 

	// Constructors
	public LightningBoltStateGroupNode() {} // 0x00000001841EE1B0-0x00000001841EE250
	static LightningBoltStateGroupNode() {} // 0x00000001841EE150-0x00000001841EE1B0

	// Methods
	// [XID] // 0x0000000189853590-0x00000001898535B0
	private int GetFreeIndex() => default; // 0x00000001841ED9F0-0x00000001841EDB30
	// [XID] // 0x000000018985B060-0x000000018985B080
	private int GetFreeIndexOnly() => default; // 0x00000001841EDF50-0x00000001841EE0B0
	// [XID] // 0x00000001898624E0-0x0000000189862500
	private void AddFreeIndex(int index) {} // 0x00000001841EDE80-0x00000001841EDF50
	// [XID] // 0x0000000189869970-0x0000000189869990
	public static LightningBoltStateData GetAndAdd() => default; // 0x00000001841EDCD0-0x00000001841EDE80
	// [XID] // 0x0000000189870C10-0x0000000189870C30
	public static void Remove(LightningBoltStateData data) {} // 0x00000001841ED6E0-0x00000001841ED840
	// [XID] // 0x0000000189887220-0x0000000189887240
	public void Init(int maxNum, IGroup group, IGraph graph, IRunnerPool runnerPool, int groupId) {} // 0x00000001841ED840-0x00000001841ED9F0
	// [XID] // 0x000000018988E390-0x000000018988E3B0
	private void InitDataPool(int maxNum, bool needPool) {} // 0x00000001841ED2D0-0x00000001841ED450
	// [XID] // 0x00000001898959E0-0x0000000189895A00
	public LightningBoltStateData GetData() => default; // 0x00000001841ED1B0-0x00000001841ED2D0
	// [XID] // 0x000000018989D080-0x000000018989D0A0
	public void AddData(LightningBoltStateData data) {} // 0x00000001841EDB30-0x00000001841EDCD0
	// [XID] // 0x00000001898A4920-0x00000001898A4940
	public void RemoveData(LightningBoltStateData data) {} // 0x00000001841ED550-0x00000001841ED6E0
	// [XID] // 0x00000001898ABE80-0x00000001898ABEA0
	public void Destroy() {} // 0x00000001841ED450-0x00000001841ED550
}

