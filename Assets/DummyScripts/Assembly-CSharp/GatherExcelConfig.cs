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
public class GatherExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15661
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 area_idRawNum; // 0x14
	protected SimpleSafeUInt32 pointTypeRawNum; // 0x18
	protected SimpleSafeUInt32 gadgetIdRawNum; // 0x1C
	protected SimpleSafeUInt32 itemIdRawNum; // 0x20
	protected SimpleSafeUInt32[] _extraItemIdVec; // 0x28
	protected PointLocation _pointLocation; // 0x30
	protected SimpleSafeUInt32 cdRawNum; // 0x34
	protected SimpleSafeUInt32 priorityRawNum; // 0x38
	protected SimpleSafeUInt32 refreshIdRawNum; // 0x3C
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected BlockLimit[] _blockLimits; // 0x40
	protected bool _init_disable_interact; // 0x48
	protected bool _isForbidGuest; // 0x49

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189A11EC0-0x0000000189A11EE0 */ get => default; /* [XID] */ /* 0x0000000189A191B0-0x0000000189A191D0 */ protected set {} } // 0x0000000182932900-0x00000001829329D0 0x0000000182931570-0x0000000182931650
	public uint area_id { /* [XID] */ /* 0x0000000189A20950-0x0000000189A20970 */ get => default; /* [XID] */ /* 0x0000000189A27D60-0x0000000189A27D80 */ protected set {} } // 0x00000001829326F0-0x00000001829327C0 0x00000001829323E0-0x00000001829324C0
	public uint pointType { /* [XID] */ /* 0x0000000189A2F430-0x0000000189A2F450 */ get => default; /* [XID] */ /* 0x0000000189A36E70-0x0000000189A36E90 */ protected set {} } // 0x0000000182932240-0x0000000182932310 0x0000000182931650-0x0000000182931730
	public uint gadgetId { /* [XID] */ /* 0x0000000189A3E4D0-0x0000000189A3E4F0 */ get => default; /* [XID] */ /* 0x0000000189A45B20-0x0000000189A45B40 */ protected set {} } // 0x00000001829313F0-0x00000001829314C0 0x0000000182931190-0x0000000182931270
	public uint itemId { /* [XID] */ /* 0x0000000189A4D2E0-0x0000000189A4D300 */ get => default; /* [XID] */ /* 0x0000000189A54A30-0x0000000189A54A50 */ protected set {} } // 0x000000018292F600-0x000000018292F6D0 0x0000000182930CE0-0x0000000182930DC0
	public SimpleSafeUInt32[] extraItemIdVec { /* [XID] */ /* 0x0000000189A5C4A0-0x0000000189A5C4C0 */ get => default; /* [XID] */ /* 0x0000000189A63E10-0x0000000189A63E30 */ protected set {} } // 0x0000000182930F40-0x0000000182930FE0 0x00000001829314C0-0x0000000182931570
	public PointLocation pointLocation { /* [XID] */ /* 0x0000000189A6B6D0-0x0000000189A6B6F0 */ get => default; /* [XID] */ /* 0x0000000189A72E20-0x0000000189A72E40 */ protected set {} } // 0x0000000182931350-0x00000001829313F0 0x000000018292F550-0x000000018292F600
	public uint cd { /* [XID] */ /* 0x0000000189A7A9F0-0x0000000189A7AA10 */ get => default; /* [XID] */ /* 0x0000000189A81EB0-0x0000000189A81ED0 */ protected set {} } // 0x00000001829324C0-0x0000000182932590 0x0000000182931270-0x0000000182931350
	public uint priority { /* [XID] */ /* 0x0000000189A89930-0x0000000189A89950 */ get => default; /* [XID] */ /* 0x0000000189A91050-0x0000000189A91070 */ protected set {} } // 0x0000000182932310-0x00000001829323E0 0x0000000182930DC0-0x0000000182930EA0
	public uint refreshId { /* [XID] */ /* 0x0000000189A98960-0x0000000189A98980 */ get => default; /* [XID] */ /* 0x0000000189A9FD10-0x0000000189A9FD30 */ protected set {} } // 0x00000001829310C0-0x0000000182931190 0x0000000182930FE0-0x00000001829310C0
	public BlockLimit[] blockLimits { /* [XID] */ /* 0x0000000189AA74C0-0x0000000189AA74E0 */ get => default; /* [XID] */ /* 0x0000000189AAEBA0-0x0000000189AAEBC0 */ protected set {} } // 0x0000000182931730-0x00000001829317D0 0x00000001829329D0-0x0000000182932A80
	public bool init_disable_interact { /* [XID] */ /* 0x0000000189AB6520-0x0000000189AB6540 */ get => default; /* [XID] */ /* 0x0000000189ABDFF0-0x0000000189ABE010 */ protected set {} } // 0x0000000182930EA0-0x0000000182930F40 0x0000000182932640-0x00000001829326F0
	public bool isForbidGuest { /* [XID] */ /* 0x0000000189AC5B10-0x0000000189AC5B30 */ get => default; /* [XID] */ /* 0x0000000189ACD0A0-0x0000000189ACD0C0 */ protected set {} } // 0x000000018292F6D0-0x000000018292F770 0x0000000182932590-0x0000000182932640

	// Constructors
	public GatherExcelConfig() {} // 0x0000000182932B20-0x0000000182932B80

	// Methods
	// [IDTag] // 0x0000000189AD4E00-0x0000000189AD4E40
	// [XID] // 0x0000000189AD4E00-0x0000000189AD4E40
	public virtual bool ParseFromLine(string line) => default; // 0x000000018292F770-0x00000001829302A0
	// [IDTag] // 0x0000000189ADF890-0x0000000189ADF8D0
	// [XID] // 0x0000000189ADF890-0x0000000189ADF8D0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001829302A0-0x0000000182930CE0
	// [XID] // 0x0000000189AE9D30-0x0000000189AE9D50
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2224 */, bool useObjectPool = false /* Metadata: 0x00AF2228 */) => default; // 0x00000001829317D0-0x0000000182932240
	[BlackList] // 0x0000000189AF1AD0-0x0000000189AF1B10
	// [XID] // 0x0000000189AF1AD0-0x0000000189AF1B10
	public virtual void AutoAllocTypeFields() {} // 0x000000018292F340-0x000000018292F3E0
	[BlackList] // 0x0000000189AFBD80-0x0000000189AFBDC0
	// [XID] // 0x0000000189AFBD80-0x0000000189AFBDC0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018292F3E0-0x000000018292F550
	[BlackList] // 0x0000000189B06760-0x0000000189B067A0
	// [XID] // 0x0000000189B06760-0x0000000189B067A0
	public virtual void ReturnToObjectPool() {} // 0x0000000182932A80-0x0000000182932B20
	[BlackList] // 0x0000000189B10FF0-0x0000000189B11030
	// [XID] // 0x0000000189B10FF0-0x0000000189B11030
	public virtual void OnPoolAllocated() {} // 0x0000000182932860-0x0000000182932900
	[BlackList] // 0x0000000189B1B200-0x0000000189B1B240
	// [XID] // 0x0000000189B1B200-0x0000000189B1B240
	public virtual void OnBeforePoolRecycled() {} // 0x00000001829327C0-0x0000000182932860
}

