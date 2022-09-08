/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class QuestCodexExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15307
{
	// Fields
	protected SimpleSafeUInt32 IdRawNum; // 0x10
	protected SimpleSafeUInt32 parentQuestIdRawNum; // 0x14
	protected SimpleSafeUInt32 chapterIdRawNum; // 0x18
	protected SimpleSafeUInt32 SortOrderRawNum; // 0x1C
	protected bool _isDisuse; // 0x20

	// Properties
	public uint Id { /* [XID] */ /* 0x0000000189A17A30-0x0000000189A17A50 */ get => default; /* [XID] */ /* 0x0000000189A1F130-0x0000000189A1F150 */ protected set {} } // 0x00000001827C7E80-0x00000001827C7F50 0x00000001827C8640-0x00000001827C8720
	public uint parentQuestId { /* [XID] */ /* 0x0000000189A26720-0x0000000189A26740 */ get => default; /* [XID] */ /* 0x0000000189A2DA70-0x0000000189A2DA90 */ protected set {} } // 0x00000001827C8570-0x00000001827C8640 0x00000001827C71F0-0x00000001827C72D0
	public uint chapterId { /* [XID] */ /* 0x0000000189A35690-0x0000000189A356B0 */ get => default; /* [XID] */ /* 0x0000000189A3CAC0-0x0000000189A3CAE0 */ protected set {} } // 0x00000001827C7DB0-0x00000001827C7E80 0x00000001827C7480-0x00000001827C7560
	public uint SortOrder { /* [XID] */ /* 0x0000000189A444D0-0x0000000189A444F0 */ get => default; /* [XID] */ /* 0x0000000189A4BAA0-0x0000000189A4BAC0 */ protected set {} } // 0x00000001827C7F50-0x00000001827C8020 0x00000001827C7CD0-0x00000001827C7DB0
	public bool isDisuse { /* [XID] */ /* 0x0000000189A53180-0x0000000189A531A0 */ get => default; /* [XID] */ /* 0x0000000189A5A930-0x0000000189A5A950 */ protected set {} } // 0x00000001827C8720-0x00000001827C87C0 0x00000001827C87C0-0x00000001827C8870

	// Constructors
	public QuestCodexExcelConfig() {} // 0x00000001827C8A50-0x00000001827C8AB0

	// Methods
	// [IDTag] // 0x0000000189A62110-0x0000000189A62150
	// [XID] // 0x0000000189A62110-0x0000000189A62150
	public virtual bool ParseFromLine(string line) => default; // 0x00000001827C7900-0x00000001827C7CD0
	// [IDTag] // 0x0000000189A6CCA0-0x0000000189A6CCE0
	// [XID] // 0x0000000189A6CCA0-0x0000000189A6CCE0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001827C7560-0x00000001827C7900
	// [XID] // 0x0000000189A774D0-0x0000000189A774F0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0713 */, bool useObjectPool = false /* Metadata: 0x00AF0717 */) => default; // 0x00000001827C8020-0x00000001827C8570
	[BlackList] // 0x0000000189A7ED60-0x0000000189A7EDA0
	// [XID] // 0x0000000189A7ED60-0x0000000189A7EDA0
	public virtual void AutoAllocTypeFields() {} // 0x00000001827C72D0-0x00000001827C7370
	[BlackList] // 0x0000000189A89970-0x0000000189A899B0
	// [XID] // 0x0000000189A89970-0x0000000189A899B0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001827C7370-0x00000001827C7480
	[BlackList] // 0x0000000189A93D10-0x0000000189A93D50
	// [XID] // 0x0000000189A93D10-0x0000000189A93D50
	public virtual void ReturnToObjectPool() {} // 0x00000001827C89B0-0x00000001827C8A50
	[BlackList] // 0x0000000189A9E370-0x0000000189A9E3B0
	// [XID] // 0x0000000189A9E370-0x0000000189A9E3B0
	public virtual void OnPoolAllocated() {} // 0x00000001827C8910-0x00000001827C89B0
	[BlackList] // 0x0000000189AA8A00-0x0000000189AA8A40
	// [XID] // 0x0000000189AA8A00-0x0000000189AA8A40
	public virtual void OnBeforePoolRecycled() {} // 0x00000001827C8870-0x00000001827C8910
}

