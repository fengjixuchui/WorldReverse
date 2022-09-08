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
public class WidgetGeneralExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16284
{
	// Fields
	protected SimpleSafeUInt32 materialIDRawNum; // 0x10
	protected bool _canUseInOtherWorld; // 0x14
	protected bool _canUseInRoom; // 0x15
	protected bool _canUseWhenCurrentAvatarDead; // 0x16
	protected bool _canUseInLimitRegion; // 0x17
	protected bool _canUseWhenFight; // 0x18
	protected bool _canUseInUnNormalMoveState; // 0x19
	protected bool _canUseInAvatarFocus; // 0x1A
	protected bool _canUseInDungeon; // 0x1B
	protected bool _canUseInTower; // 0x1C
	protected bool _canUseInHomeworld; // 0x1D
	protected SimpleSafeUInt32[] _forbiddenDungeonList; // 0x20

	// Properties
	public uint materialID { /* [XID] */ /* 0x0000000189932860-0x0000000189932880 */ get => default; /* [XID] */ /* 0x000000018993A270-0x000000018993A290 */ protected set {} } // 0x0000000184BF84B0-0x0000000184BF8580 0x0000000184BF6E80-0x0000000184BF6F60
	public bool canUseInOtherWorld { /* [XID] */ /* 0x0000000189941360-0x0000000189941380 */ get => default; /* [XID] */ /* 0x0000000189948F20-0x0000000189948F40 */ protected set {} } // 0x0000000184BF6D40-0x0000000184BF6DE0 0x0000000184BF6BF0-0x0000000184BF6CA0
	public bool canUseInRoom { /* [XID] */ /* 0x00000001899506D0-0x00000001899506F0 */ get => default; /* [XID] */ /* 0x0000000189957CE0-0x0000000189957D00 */ protected set {} } // 0x0000000184BF9340-0x0000000184BF93E0 0x0000000184BF69E0-0x0000000184BF6A90
	public bool canUseWhenCurrentAvatarDead { /* [XID] */ /* 0x000000018995F5D0-0x000000018995F5F0 */ get => default; /* [XID] */ /* 0x0000000189966DD0-0x0000000189966DF0 */ protected set {} } // 0x0000000184BF6DE0-0x0000000184BF6E80 0x0000000184BF8360-0x0000000184BF8410
	public bool canUseInLimitRegion { /* [XID] */ /* 0x000000018996E100-0x000000018996E120 */ get => default; /* [XID] */ /* 0x0000000189975CF0-0x0000000189975D10 */ protected set {} } // 0x0000000184BF8FF0-0x0000000184BF9090 0x0000000184BF6F60-0x0000000184BF7010
	public bool canUseWhenFight { /* [XID] */ /* 0x000000018997CDF0-0x000000018997CE10 */ get => default; /* [XID] */ /* 0x0000000189984A70-0x0000000189984A90 */ protected set {} } // 0x0000000184BF8410-0x0000000184BF84B0 0x0000000184BF91E0-0x0000000184BF9290
	public bool canUseInUnNormalMoveState { /* [XID] */ /* 0x000000018998C650-0x000000018998C670 */ get => default; /* [XID] */ /* 0x0000000189994350-0x0000000189994370 */ protected set {} } // 0x0000000184BF9090-0x0000000184BF9130 0x0000000184BF6A90-0x0000000184BF6B40
	public bool canUseInAvatarFocus { /* [XID] */ /* 0x000000018999BB60-0x000000018999BB80 */ get => default; /* [XID] */ /* 0x00000001899A3330-0x00000001899A3350 */ protected set {} } // 0x0000000184BF82C0-0x0000000184BF8360 0x0000000184BF9290-0x0000000184BF9340
	public bool canUseInDungeon { /* [XID] */ /* 0x00000001899AAEA0-0x00000001899AAEC0 */ get => default; /* [XID] */ /* 0x00000001899B28F0-0x00000001899B2910 */ protected set {} } // 0x0000000184BF8580-0x0000000184BF8620 0x0000000184BF9130-0x0000000184BF91E0
	public bool canUseInTower { /* [XID] */ /* 0x00000001899B9B10-0x00000001899B9B30 */ get => default; /* [XID] */ /* 0x00000001899C1630-0x00000001899C1650 */ protected set {} } // 0x0000000184BF8220-0x0000000184BF82C0 0x0000000184BF6B40-0x0000000184BF6BF0
	public bool canUseInHomeworld { /* [XID] */ /* 0x00000001899C8BE0-0x00000001899C8C00 */ get => default; /* [XID] */ /* 0x00000001899D0570-0x00000001899D0590 */ protected set {} } // 0x0000000184BF7010-0x0000000184BF70B0 0x0000000184BF66F0-0x0000000184BF67A0
	public SimpleSafeUInt32[] forbiddenDungeonList { /* [XID] */ /* 0x00000001899D7A30-0x00000001899D7A50 */ get => default; /* [XID] */ /* 0x00000001899DEEF0-0x00000001899DEF10 */ protected set {} } // 0x0000000184BF6CA0-0x0000000184BF6D40 0x0000000184BF67A0-0x0000000184BF6850

	// Constructors
	public WidgetGeneralExcelConfig() {} // 0x0000000184BF95C0-0x0000000184BF9620

	// Methods
	// [IDTag] // 0x00000001899E6AF0-0x00000001899E6B30
	// [XID] // 0x00000001899E6AF0-0x00000001899E6B30
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184BF7970-0x0000000184BF8220
	// [IDTag] // 0x00000001899F0F90-0x00000001899F0FD0
	// [XID] // 0x00000001899F0F90-0x00000001899F0FD0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184BF70B0-0x0000000184BF7970
	// [XID] // 0x00000001899FBB70-0x00000001899FBB90
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF366C */, bool useObjectPool = false /* Metadata: 0x00AF3670 */) => default; // 0x0000000184BF8620-0x0000000184BF8FF0
	[BlackList] // 0x0000000189A02F30-0x0000000189A02F70
	// [XID] // 0x0000000189A02F30-0x0000000189A02F70
	public virtual void AutoAllocTypeFields() {} // 0x0000000184BF6850-0x0000000184BF68F0
	[BlackList] // 0x0000000189A0D560-0x0000000189A0D5A0
	// [XID] // 0x0000000189A0D560-0x0000000189A0D5A0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184BF68F0-0x0000000184BF69E0
	[BlackList] // 0x0000000189A17870-0x0000000189A178B0
	// [XID] // 0x0000000189A17870-0x0000000189A178B0
	public virtual void ReturnToObjectPool() {} // 0x0000000184BF9520-0x0000000184BF95C0
	[BlackList] // 0x0000000189A21F70-0x0000000189A21FB0
	// [XID] // 0x0000000189A21F70-0x0000000189A21FB0
	public virtual void OnPoolAllocated() {} // 0x0000000184BF9480-0x0000000184BF9520
	[BlackList] // 0x0000000189A2C290-0x0000000189A2C2D0
	// [XID] // 0x0000000189A2C290-0x0000000189A2C2D0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184BF93E0-0x0000000184BF9480
}

