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

public class SectrStreamLodGroupNode : IGroupNode // TypeDefIndex: 26635
{
	// Fields
	private int _dataType; // 0x14
	private int _cnt; // 0x18
	private Queue<int> _freeIndexs; // 0x20
	private static IGroup _group; // 0x00
	private SectrStreamLodData[] _innerDatas; // 0x28
	private SectrStreamLodTask _task; // 0x30

	// Properties
	public int index { /* [XID] */ /* 0x00000001897C1570-0x00000001897C15B0 */ get; set; } // 0x0000000182328CE0-0x0000000182328D40 0x0000000182328E00-0x0000000182328E60
	public int dataType { /* [XID] */ /* 0x00000001897D3570-0x00000001897D3590 */ get => default; } // 0x0000000182328C40-0x0000000182328CE0 
	public int dataCnt { /* [XID] */ /* 0x00000001897DB0B0-0x00000001897DB0D0 */ get => default; } // 0x0000000182328BA0-0x0000000182328C40 
	public SectrStreamLodData[] innerDatas { /* [XID] */ /* 0x0000000189822D60-0x0000000189822D80 */ get => default; } // 0x0000000182328A00-0x0000000182328AA0 
	public INode node { /* [XID] */ /* 0x000000018982A670-0x000000018982A690 */ get => default; } // 0x0000000182328D40-0x0000000182328E00 

	// Constructors
	public SectrStreamLodGroupNode() {} // 0x0000000182328B00-0x0000000182328BA0
	static SectrStreamLodGroupNode() {} // 0x0000000182328AA0-0x0000000182328B00

	// Methods
	// [XID] // 0x00000001897E2760-0x00000001897E2780
	private int GetFreeIndex() => default; // 0x00000001823281D0-0x0000000182328310
	// [XID] // 0x00000001897E9E70-0x00000001897E9E90
	private int GetFreeIndexOnly() => default; // 0x00000001823288A0-0x0000000182328A00
	// [XID] // 0x00000001897F1AD0-0x00000001897F1AF0
	private void AddFreeIndex(int index) {} // 0x00000001823287D0-0x00000001823288A0
	// [IDTag] // 0x00000001897F9360-0x00000001897F93A0
	// [XID] // 0x00000001897F9360-0x00000001897F93A0
	public static SectrStreamLodData GetAndAdd() => default; // 0x0000000182328480-0x0000000182328630
	// [IDTag] // 0x0000000189803950-0x0000000189803990
	// [XID] // 0x0000000189803950-0x0000000189803990
	public static void Remove(SectrStreamLodData data) {} // 0x0000000182327EE0-0x0000000182328040
	// [IDTag] // 0x000000018980DED0-0x000000018980DF10
	// [XID] // 0x000000018980DED0-0x000000018980DF10
	public static SectrStreamLodData GetAndAdd(IGroup group) => default; // 0x0000000182328630-0x00000001823287D0
	// [IDTag] // 0x0000000189818950-0x0000000189818990
	// [XID] // 0x0000000189818950-0x0000000189818990
	public static void Remove(IGroup group, SectrStreamLodData data) {} // 0x0000000182327DA0-0x0000000182327EE0
	// [XID] // 0x00000001898319D0-0x00000001898319F0
	public void Init(int maxNum, IGroup group, IGraph graph, IRunnerPool runnerPool, int groupId) {} // 0x0000000182328040-0x00000001823281D0
	// [XID] // 0x00000001898390A0-0x00000001898390C0
	private void InitDataPool(int maxNum, bool needPool) {} // 0x00000001823279C0-0x0000000182327B40
	// [XID] // 0x0000000189840740-0x0000000189840760
	public SectrStreamLodData GetData() => default; // 0x00000001823278A0-0x00000001823279C0
	// [XID] // 0x0000000189847C30-0x0000000189847C50
	public void AddData(SectrStreamLodData data) {} // 0x0000000182328310-0x0000000182328480
	// [XID] // 0x000000018984F460-0x000000018984F480
	public void RemoveData(SectrStreamLodData data) {} // 0x0000000182327C40-0x0000000182327DA0
	// [XID] // 0x00000001898565E0-0x0000000189856600
	public void Destroy() {} // 0x0000000182327B40-0x0000000182327C40
}

