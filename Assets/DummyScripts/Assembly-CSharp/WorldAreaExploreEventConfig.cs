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
public class WorldAreaExploreEventConfig : IAutoAllocRecycle // TypeDefIndex: 16297
{
	// Fields
	protected SimpleSafeUInt32 EventIDRawNum; // 0x10
	protected SimpleSafeUInt32 SceneIDRawNum; // 0x14
	protected SimpleSafeUInt32 AreaIDRawNum; // 0x18
	protected ExploreEventType _EventType; // 0x1C
	protected string[] _Param; // 0x20
	protected SimpleSafeUInt32 ExploreWeightRawNum; // 0x28
	protected SimpleSafeUInt32 rewardIDRawNum; // 0x2C

	// Properties
	public uint EventID { /* [XID] */ /* 0x0000000189634550-0x0000000189634570 */ get => default; /* [XID] */ /* 0x000000018963BC60-0x000000018963BC80 */ protected set {} } // 0x00000001840B8A40-0x00000001840B8B10 0x00000001840BA6D0-0x00000001840BA7B0
	public uint SceneID { /* [XID] */ /* 0x0000000189643380-0x00000001896433A0 */ get => default; /* [XID] */ /* 0x000000018964A9C0-0x000000018964A9E0 */ protected set {} } // 0x00000001840BA340-0x00000001840BA410 0x00000001840B99A0-0x00000001840B9A80
	public uint AreaID { /* [XID] */ /* 0x0000000189652240-0x0000000189652260 */ get => default; /* [XID] */ /* 0x0000000189659910-0x0000000189659930 */ protected set {} } // 0x00000001840BA410-0x00000001840BA4E0 0x00000001840BA1C0-0x00000001840BA2A0
	public ExploreEventType EventType { /* [XID] */ /* 0x0000000189661090-0x00000001896610B0 */ get => default; /* [XID] */ /* 0x0000000189668AC0-0x0000000189668AE0 */ protected set {} } // 0x00000001840B9830-0x00000001840B98D0 0x00000001840BA110-0x00000001840BA1C0
	public string[] Param { /* [XID] */ /* 0x0000000189670690-0x00000001896706B0 */ get => default; /* [XID] */ /* 0x0000000189677E90-0x0000000189677EB0 */ protected set {} } // 0x00000001840BA2A0-0x00000001840BA340 0x00000001840BA4E0-0x00000001840BA590
	public uint ExploreWeight { /* [XID] */ /* 0x000000018967F460-0x000000018967F480 */ get => default; /* [XID] */ /* 0x0000000189686C90-0x0000000189686CB0 */ protected set {} } // 0x00000001840B8970-0x00000001840B8A40 0x00000001840B8B10-0x00000001840B8BF0
	public uint rewardID { /* [XID] */ /* 0x000000018968EBB0-0x000000018968EBD0 */ get => default; /* [XID] */ /* 0x00000001896965B0-0x00000001896965D0 */ protected set {} } // 0x00000001840B98D0-0x00000001840B99A0 0x00000001840B9750-0x00000001840B9830

	// Constructors
	public WorldAreaExploreEventConfig() {} // 0x00000001840BA850-0x00000001840BA8B0

	// Methods
	// [IDTag] // 0x000000018969DB30-0x000000018969DB70
	// [XID] // 0x000000018969DB30-0x000000018969DB70
	public virtual bool ParseFromLine(string line) => default; // 0x00000001840B9180-0x00000001840B9750
	// [IDTag] // 0x00000001896A7C40-0x00000001896A7C80
	// [XID] // 0x00000001896A7C40-0x00000001896A7C80
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001840B8BF0-0x00000001840B9180
	// [XID] // 0x00000001896B1AD0-0x00000001896B1AF0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF36E8 */, bool useObjectPool = false /* Metadata: 0x00AF36EC */) => default; // 0x00000001840B9A80-0x00000001840BA110
	[BlackList] // 0x00000001896B94B0-0x00000001896B94F0
	// [XID] // 0x00000001896B94B0-0x00000001896B94F0
	public virtual void AutoAllocTypeFields() {} // 0x00000001840B87A0-0x00000001840B8840
	[BlackList] // 0x00000001896C3880-0x00000001896C38C0
	// [XID] // 0x00000001896C3880-0x00000001896C38C0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001840B8840-0x00000001840B8970
	[BlackList] // 0x00000001896CDF90-0x00000001896CDFD0
	// [XID] // 0x00000001896CDF90-0x00000001896CDFD0
	public virtual void ReturnToObjectPool() {} // 0x00000001840BA7B0-0x00000001840BA850
	[BlackList] // 0x00000001896D8310-0x00000001896D8350
	// [XID] // 0x00000001896D8310-0x00000001896D8350
	public virtual void OnPoolAllocated() {} // 0x00000001840BA630-0x00000001840BA6D0
	[BlackList] // 0x00000001896E2B20-0x00000001896E2B60
	// [XID] // 0x00000001896E2B20-0x00000001896E2B60
	public virtual void OnBeforePoolRecycled() {} // 0x00000001840BA590-0x00000001840BA630
}

