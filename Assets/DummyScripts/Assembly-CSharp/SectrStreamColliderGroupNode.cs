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

public class SectrStreamColliderGroupNode : IGroupNode // TypeDefIndex: 26630
{
	// Fields
	private int _dataType; // 0x14
	private int _cnt; // 0x18
	private Queue<int> _freeIndexs; // 0x20
	private static IGroup _group; // 0x00
	private SectrStreamColliderData[] _innerDatas; // 0x28
	private SectrStreamColliderTask _task; // 0x30

	// Properties
	public int index { /* [XID] */ /* 0x0000000189602430-0x0000000189602470 */ get; set; } // 0x000000018546B3F0-0x000000018546B450 0x000000018546B510-0x000000018546B570
	public int dataType { /* [XID] */ /* 0x00000001896140E0-0x0000000189614100 */ get => default; } // 0x000000018546B350-0x000000018546B3F0 
	public int dataCnt { /* [XID] */ /* 0x000000018961BA80-0x000000018961BAA0 */ get => default; } // 0x000000018546B2B0-0x000000018546B350 
	public SectrStreamColliderData[] innerDatas { /* [XID] */ /* 0x0000000189663810-0x0000000189663830 */ get => default; } // 0x000000018546B110-0x000000018546B1B0 
	public INode node { /* [XID] */ /* 0x000000018966B190-0x000000018966B1B0 */ get => default; } // 0x000000018546B450-0x000000018546B510 

	// Constructors
	public SectrStreamColliderGroupNode() {} // 0x000000018546B210-0x000000018546B2B0
	static SectrStreamColliderGroupNode() {} // 0x000000018546B1B0-0x000000018546B210

	// Methods
	// [XID] // 0x00000001896230A0-0x00000001896230C0
	private int GetFreeIndex() => default; // 0x000000018546A8E0-0x000000018546AA20
	// [XID] // 0x000000018962A890-0x000000018962A8B0
	private int GetFreeIndexOnly() => default; // 0x000000018546AFB0-0x000000018546B110
	// [XID] // 0x0000000189631FD0-0x0000000189631FF0
	private void AddFreeIndex(int index) {} // 0x000000018546AEE0-0x000000018546AFB0
	// [IDTag] // 0x0000000189639AD0-0x0000000189639B10
	// [XID] // 0x0000000189639AD0-0x0000000189639B10
	public static SectrStreamColliderData GetAndAdd() => default; // 0x000000018546AD30-0x000000018546AEE0
	// [IDTag] // 0x0000000189644280-0x00000001896442C0
	// [XID] // 0x0000000189644280-0x00000001896442C0
	public static void Remove(SectrStreamColliderData data) {} // 0x000000018546A4B0-0x000000018546A610
	// [IDTag] // 0x000000018964E8B0-0x000000018964E8F0
	// [XID] // 0x000000018964E8B0-0x000000018964E8F0
	public static SectrStreamColliderData GetAndAdd(IGroup group) => default; // 0x000000018546AB90-0x000000018546AD30
	// [IDTag] // 0x0000000189659030-0x0000000189659070
	// [XID] // 0x0000000189659030-0x0000000189659070
	public static void Remove(IGroup group, SectrStreamColliderData data) {} // 0x000000018546A610-0x000000018546A750
	// [XID] // 0x0000000189672D90-0x0000000189672DB0
	public void Init(int maxNum, IGroup group, IGraph graph, IRunnerPool runnerPool, int groupId) {} // 0x000000018546A750-0x000000018546A8E0
	// [XID] // 0x000000018967A450-0x000000018967A470
	private void InitDataPool(int maxNum, bool needPool) {} // 0x000000018546A0D0-0x000000018546A250
	// [XID] // 0x0000000189681CA0-0x0000000189681CC0
	public SectrStreamColliderData GetData() => default; // 0x0000000185469FB0-0x000000018546A0D0
	// [XID] // 0x0000000189689710-0x0000000189689730
	public void AddData(SectrStreamColliderData data) {} // 0x000000018546AA20-0x000000018546AB90
	// [XID] // 0x00000001896913F0-0x0000000189691410
	public void RemoveData(SectrStreamColliderData data) {} // 0x000000018546A350-0x000000018546A4B0
	// [XID] // 0x0000000189698B60-0x0000000189698B80
	public void Destroy() {} // 0x000000018546A250-0x000000018546A350
}

