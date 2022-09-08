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

public class DynamicBoneArrayGroupNode : IGroupNode // TypeDefIndex: 26591
{
	// Fields
	private int _dataType; // 0x14
	private int _cnt; // 0x18
	private Queue<int> _freeIndexs; // 0x20
	private static IGroup _group; // 0x00
	private DynamicBoneArrayData[] _innerDatas; // 0x28
	private DynamicBoneArrayTask _task; // 0x30

	// Properties
	public int index { /* [XID] */ /* 0x000000018971C310-0x000000018971C350 */ get; set; } // 0x00000001828B1650-0x00000001828B16B0 0x00000001828B1770-0x00000001828B17D0
	public int dataType { /* [XID] */ /* 0x000000018972DD70-0x000000018972DD90 */ get => default; } // 0x00000001828B15B0-0x00000001828B1650 
	public int dataCnt { /* [XID] */ /* 0x0000000189735410-0x0000000189735430 */ get => default; } // 0x00000001828B1510-0x00000001828B15B0 
	public INode node { /* [XID] */ /* 0x0000000189769AF0-0x0000000189769B10 */ get => default; } // 0x00000001828B16B0-0x00000001828B1770 

	// Constructors
	public DynamicBoneArrayGroupNode() {} // 0x00000001828B1470-0x00000001828B1510
	static DynamicBoneArrayGroupNode() {} // 0x00000001828B1410-0x00000001828B1470

	// Methods
	// [XID] // 0x000000018973CF00-0x000000018973CF20
	private int GetFreeIndex() => default; // 0x00000001828B0D50-0x00000001828B0E90
	// [XID] // 0x00000001897444B0-0x00000001897444D0
	private int GetFreeIndexOnly() => default; // 0x00000001828B12B0-0x00000001828B1410
	// [XID] // 0x000000018974C140-0x000000018974C160
	private void AddFreeIndex(int index) {} // 0x00000001828B11E0-0x00000001828B12B0
	// [XID] // 0x0000000189753430-0x0000000189753450
	public static DynamicBoneArrayData GetAndAdd() => default; // 0x00000001828B1030-0x00000001828B11E0
	// [XID] // 0x000000018975A8D0-0x000000018975A8F0
	public static void Remove(DynamicBoneArrayData data) {} // 0x00000001828B09C0-0x00000001828B0AD0
	// [XID] // 0x0000000189762440-0x0000000189762460
	public static void InternalRemove(DynamicBoneArrayData data) {} // 0x00000001828B05A0-0x00000001828B0700
	// [XID] // 0x0000000189771110-0x0000000189771130
	public void Init(int maxNum, IGroup group, IGraph graph, IRunnerPool runnerPool, int groupId) {} // 0x00000001828B0AD0-0x00000001828B0D50
	// [XID] // 0x0000000189778970-0x0000000189778990
	private void InitDataPool(int maxNum) {} // 0x00000001828B0440-0x00000001828B05A0
	// [XID] // 0x000000018977FF10-0x000000018977FF30
	public DynamicBoneArrayData GetData() => default; // 0x00000001828B0320-0x00000001828B0440
	// [XID] // 0x0000000189787780-0x00000001897877A0
	public void AddData(DynamicBoneArrayData data) {} // 0x00000001828B0E90-0x00000001828B1030
	// [XID] // 0x000000018978EE50-0x000000018978EE70
	public void RemoveData(DynamicBoneArrayData data) {} // 0x00000001828B0830-0x00000001828B09C0
	// [XID] // 0x0000000189796650-0x0000000189796670
	public void Destroy() {} // 0x00000001828B0700-0x00000001828B0830
}

