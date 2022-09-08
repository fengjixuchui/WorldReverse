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
public class GivingExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15671
{
	// Fields
	protected SimpleSafeUInt32 IdRawNum; // 0x10
	protected SimpleSafeUInt32 talkIdRawNum; // 0x14
	protected SimpleSafeUInt32 mistakeTalkIdRawNum; // 0x18
	protected BagTab _tab; // 0x1C
	protected bool _isRepeatable; // 0x20
	protected GivingMethod _givingMethod; // 0x24
	protected IdCountConfig[] _exactItems; // 0x28
	protected SimpleSafeUInt32 exactFinishTalkIdRawNum; // 0x30
	protected SimpleSafeUInt32[] _givingGroupIds; // 0x38
	protected SimpleSafeUInt32 givingGroupCountRawNum; // 0x40
	protected bool _highlight; // 0x44
	protected string _icon; // 0x48
	protected bool _isRemoveItem; // 0x50

	// Properties
	public uint Id { /* [XID] */ /* 0x0000000189811800-0x0000000189811820 */ get => default; /* [XID] */ /* 0x0000000189819430-0x0000000189819450 */ protected set {} } // 0x0000000184D41650-0x0000000184D41720 0x0000000184D42680-0x0000000184D42760
	public uint talkId { /* [XID] */ /* 0x0000000189820C30-0x0000000189820C50 */ get => default; /* [XID] */ /* 0x0000000189828240-0x0000000189828260 */ protected set {} } // 0x0000000184D42B80-0x0000000184D42C50 0x0000000184D3FAC0-0x0000000184D3FBA0
	public uint mistakeTalkId { /* [XID] */ /* 0x000000018982F4C0-0x000000018982F4E0 */ get => default; /* [XID] */ /* 0x0000000189836D70-0x0000000189836D90 */ protected set {} } // 0x0000000184D41800-0x0000000184D418D0 0x0000000184D3FDB0-0x0000000184D3FE90
	public BagTab tab { /* [XID] */ /* 0x000000018983E200-0x000000018983E220 */ get => default; /* [XID] */ /* 0x00000001898459B0-0x00000001898459D0 */ protected set {} } // 0x0000000184D418D0-0x0000000184D41970 0x0000000184D415A0-0x0000000184D41650
	public bool isRepeatable { /* [XID] */ /* 0x000000018984CF80-0x000000018984CFA0 */ get => default; /* [XID] */ /* 0x0000000189854020-0x0000000189854040 */ protected set {} } // 0x0000000184D41AC0-0x0000000184D41B60 0x0000000184D425D0-0x0000000184D42680
	public GivingMethod givingMethod { /* [XID] */ /* 0x000000018985BA30-0x000000018985BA50 */ get => default; /* [XID] */ /* 0x0000000189863010-0x0000000189863030 */ protected set {} } // 0x0000000184D41A20-0x0000000184D41AC0 0x0000000184D42810-0x0000000184D428C0
	public IdCountConfig[] exactItems { /* [XID] */ /* 0x000000018986A480-0x000000018986A4A0 */ get => default; /* [XID] */ /* 0x00000001898718D0-0x00000001898718F0 */ protected set {} } // 0x0000000184D3FD10-0x0000000184D3FDB0 0x0000000184D3FF30-0x0000000184D3FFE0
	public uint exactFinishTalkId { /* [XID] */ /* 0x0000000189879190-0x00000001898791B0 */ get => default; /* [XID] */ /* 0x0000000189880740-0x0000000189880760 */ protected set {} } // 0x0000000184D3FBA0-0x0000000184D3FC70 0x0000000184D42C50-0x0000000184D42D30
	public SimpleSafeUInt32[] givingGroupIds { /* [XID] */ /* 0x0000000189887CE0-0x0000000189887D00 */ get => default; /* [XID] */ /* 0x000000018988F060-0x000000018988F080 */ protected set {} } // 0x0000000184D3FC70-0x0000000184D3FD10 0x0000000184D41970-0x0000000184D41A20
	public uint givingGroupCount { /* [XID] */ /* 0x00000001898965A0-0x00000001898965C0 */ get => default; /* [XID] */ /* 0x000000018989DB60-0x000000018989DB80 */ protected set {} } // 0x0000000184D428C0-0x0000000184D42990 0x0000000184D41720-0x0000000184D41800
	public bool highlight { /* [XID] */ /* 0x00000001898A5480-0x00000001898A54A0 */ get => default; /* [XID] */ /* 0x00000001898ACA00-0x00000001898ACA20 */ protected set {} } // 0x0000000184D3F7A0-0x0000000184D3F840 0x0000000184D414F0-0x0000000184D415A0
	public string icon { /* [XID] */ /* 0x00000001898B3EC0-0x00000001898B3EE0 */ get => default; /* [XID] */ /* 0x00000001898BBB70-0x00000001898BBB90 */ protected set {} } // 0x0000000184D3F840-0x0000000184D3F8E0 0x0000000184D42760-0x0000000184D42810
	public bool isRemoveItem { /* [XID] */ /* 0x00000001898C30A0-0x00000001898C30C0 */ get => default; /* [XID] */ /* 0x00000001898CAA60-0x00000001898CAA80 */ protected set {} } // 0x0000000184D3FE90-0x0000000184D3FF30 0x0000000184D42990-0x0000000184D42A40

	// Constructors
	public GivingExcelConfig() {} // 0x0000000184D42DD0-0x0000000184D42E30

	// Methods
	// [IDTag] // 0x00000001898D2130-0x00000001898D2170
	// [XID] // 0x00000001898D2130-0x00000001898D2170
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184D3FFE0-0x0000000184D40AE0
	// [IDTag] // 0x00000001898DCB30-0x00000001898DCB70
	// [XID] // 0x00000001898DCB30-0x00000001898DCB70
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184D40AE0-0x0000000184D414F0
	// [XID] // 0x00000001898E7A50-0x00000001898E7A70
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF228D */, bool useObjectPool = false /* Metadata: 0x00AF2291 */) => default; // 0x0000000184D41B60-0x0000000184D425D0
	[BlackList] // 0x00000001898EF0C0-0x00000001898EF100
	// [XID] // 0x00000001898EF0C0-0x00000001898EF100
	public virtual void AutoAllocTypeFields() {} // 0x0000000184D3F8E0-0x0000000184D3F980
	[BlackList] // 0x00000001898F98D0-0x00000001898F9910
	// [XID] // 0x00000001898F98D0-0x00000001898F9910
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184D3F980-0x0000000184D3FAC0
	[BlackList] // 0x00000001899041D0-0x0000000189904210
	// [XID] // 0x00000001899041D0-0x0000000189904210
	public virtual void ReturnToObjectPool() {} // 0x0000000184D42D30-0x0000000184D42DD0
	[BlackList] // 0x000000018990EAD0-0x000000018990EB10
	// [XID] // 0x000000018990EAD0-0x000000018990EB10
	public virtual void OnPoolAllocated() {} // 0x0000000184D42AE0-0x0000000184D42B80
	[BlackList] // 0x0000000189919400-0x0000000189919440
	// [XID] // 0x0000000189919400-0x0000000189919440
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184D42A40-0x0000000184D42AE0
}

