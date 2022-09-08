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

public class LCRockGadgetCollisionCheckerGroupNode : IGroupNode // TypeDefIndex: 26604
{
	// Fields
	private int _dataType; // 0x14
	private int _cnt; // 0x18
	private Queue<int> _freeIndexs; // 0x20
	private static IGroup _group; // 0x00
	private LCRockGadgetCollisionCheckerData[] _innerDatas; // 0x28
	private LCRockGadgetCollisionCheckerTask _task; // 0x30

	// Properties
	public int index { /* [XID] */ /* 0x00000001895F4BB0-0x00000001895F4BF0 */ get; set; } // 0x00000001848A0FE0-0x00000001848A1040 0x00000001848A1100-0x00000001848A1160
	public int dataType { /* [XID] */ /* 0x0000000189606AD0-0x0000000189606AF0 */ get => default; } // 0x00000001848A0F40-0x00000001848A0FE0 
	public int dataCnt { /* [XID] */ /* 0x000000018960E450-0x000000018960E470 */ get => default; } // 0x00000001848A0EA0-0x00000001848A0F40 
	public LCRockGadgetCollisionCheckerData[] innerDatas { /* [XID] */ /* 0x0000000189633A30-0x0000000189633A50 */ get => default; } // 0x00000001848A0D00-0x00000001848A0DA0 
	public INode node { /* [XID] */ /* 0x000000018963B310-0x000000018963B330 */ get => default; } // 0x00000001848A1040-0x00000001848A1100 

	// Constructors
	public LCRockGadgetCollisionCheckerGroupNode() {} // 0x00000001848A0E00-0x00000001848A0EA0
	static LCRockGadgetCollisionCheckerGroupNode() {} // 0x00000001848A0DA0-0x00000001848A0E00

	// Methods
	// [XID] // 0x0000000189615AC0-0x0000000189615AE0
	private int GetFreeIndex() => default; // 0x00000001848A0520-0x00000001848A0660
	// [XID] // 0x000000018961D300-0x000000018961D320
	private void AddFreeIndex(int index) {} // 0x00000001848A0C30-0x00000001848A0D00
	// [XID] // 0x0000000189624750-0x0000000189624770
	public static void Add(ref LCRockGadgetCollisionCheckerData data) {} // 0x00000001848A0960-0x00000001848A0B50
	// [XID] // 0x000000018962BED0-0x000000018962BEF0
	public static void Remove(ref LCRockGadgetCollisionCheckerData data) {} // 0x00000001848A01A0-0x00000001848A0380
	// [XID] // 0x0000000189642A80-0x0000000189642AA0
	public void Init(int maxNum, IGroup group, IGraph graph, IRunnerPool runnerPool, int groupId) {} // 0x00000001848A0380-0x00000001848A0520
	// [XID] // 0x000000018964A170-0x000000018964A190
	public void InitGroup(IGroup group) {} // 0x00000001848A0B50-0x00000001848A0C30
	// [XID] // 0x0000000189651830-0x0000000189651850
	public void AddData(LCRockGadgetCollisionCheckerData data) {} // 0x00000001848A0660-0x00000001848A0960
	// [XID] // 0x0000000189659070-0x0000000189659090
	public void RemoveData(LCRockGadgetCollisionCheckerData data) {} // 0x000000018489FE70-0x00000001848A01A0
	// [XID] // 0x00000001896607A0-0x00000001896607C0
	public void Destroy() {} // 0x000000018489FD70-0x000000018489FE70
}

