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
public class IconAdsorbEffectExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15200
{
	// Fields
	protected SimpleSafeUInt32 effectIdRawNum; // 0x10
	protected SimpleSafeUInt32[] _iconIdList; // 0x18

	// Properties
	public uint effectId { /* [XID] */ /* 0x00000001899E0A60-0x00000001899E0A80 */ get => default; /* [XID] */ /* 0x00000001899E85C0-0x00000001899E85E0 */ protected set {} } // 0x0000000181870550-0x0000000181870620 0x0000000181871260-0x0000000181871340
	public SimpleSafeUInt32[] iconIdList { /* [XID] */ /* 0x00000001899EFBF0-0x00000001899EFC10 */ get => default; /* [XID] */ /* 0x00000001899F72D0-0x00000001899F72F0 */ protected set {} } // 0x0000000181871340-0x00000001818713E0 0x0000000181870E40-0x0000000181870EF0

	// Constructors
	public IconAdsorbEffectExcelConfig() {} // 0x00000001818715C0-0x0000000181871620

	// Methods
	// [IDTag] // 0x00000001899FEA30-0x00000001899FEA70
	// [XID] // 0x00000001899FEA30-0x00000001899FEA70
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181870A10-0x0000000181870E40
	// [IDTag] // 0x0000000189A08FB0-0x0000000189A08FF0
	// [XID] // 0x0000000189A08FB0-0x0000000189A08FF0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181870620-0x0000000181870A10
	// [XID] // 0x0000000189A137E0-0x0000000189A13800
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF03A4 */, bool useObjectPool = false /* Metadata: 0x00AF03A8 */) => default; // 0x0000000181870EF0-0x0000000181871260
	[BlackList] // 0x0000000189A1A8F0-0x0000000189A1A930
	// [XID] // 0x0000000189A1A8F0-0x0000000189A1A930
	public virtual void AutoAllocTypeFields() {} // 0x00000001818703D0-0x0000000181870470
	[BlackList] // 0x0000000189A24ED0-0x0000000189A24F10
	// [XID] // 0x0000000189A24ED0-0x0000000189A24F10
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181870470-0x0000000181870550
	[BlackList] // 0x0000000189A2F4D0-0x0000000189A2F510
	// [XID] // 0x0000000189A2F4D0-0x0000000189A2F510
	public virtual void ReturnToObjectPool() {} // 0x0000000181871520-0x00000001818715C0
	[BlackList] // 0x0000000189A39C10-0x0000000189A39C50
	// [XID] // 0x0000000189A39C10-0x0000000189A39C50
	public virtual void OnPoolAllocated() {} // 0x0000000181871480-0x0000000181871520
	[BlackList] // 0x0000000189A44530-0x0000000189A44570
	// [XID] // 0x0000000189A44530-0x0000000189A44570
	public virtual void OnBeforePoolRecycled() {} // 0x00000001818713E0-0x0000000181871480
}

