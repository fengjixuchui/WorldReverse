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
public class DailyTaskTagType : IAutoAllocRecycle // TypeDefIndex: 15478
{
	// Fields
	protected SimpleSafeUInt32 valueRawNum; // 0x10

	// Properties
	public uint value { /* [XID] */ /* 0x00000001898CD760-0x00000001898CD780 */ get => default; /* [XID] */ /* 0x00000001898D5290-0x00000001898D52B0 */ protected set {} } // 0x0000000181F54460-0x0000000181F54530 0x0000000181F54380-0x0000000181F54460

	// Constructors
	public DailyTaskTagType() {} // 0x0000000181F549D0-0x0000000181F54A30

	// Methods
	// [XID] // 0x00000001898DCB70-0x00000001898DCB90
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181F541D0-0x0000000181F54380
	// [XID] // 0x00000001898E4560-0x00000001898E4580
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1BDC */, bool useObjectPool = false /* Metadata: 0x00AF1BE0 */) => default; // 0x0000000181F54530-0x0000000181F547F0
	[BlackList] // 0x00000001898EBFF0-0x00000001898EC030
	// [XID] // 0x00000001898EBFF0-0x00000001898EC030
	public virtual void AutoAllocTypeFields() {} // 0x0000000181F54060-0x0000000181F54100
	[BlackList] // 0x00000001898F6A40-0x00000001898F6A80
	// [XID] // 0x00000001898F6A40-0x00000001898F6A80
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181F54100-0x0000000181F541D0
	[BlackList] // 0x00000001899012B0-0x00000001899012F0
	// [XID] // 0x00000001899012B0-0x00000001899012F0
	public virtual void ReturnToObjectPool() {} // 0x0000000181F54930-0x0000000181F549D0
	[BlackList] // 0x000000018990B8F0-0x000000018990B930
	// [XID] // 0x000000018990B8F0-0x000000018990B930
	public virtual void OnPoolAllocated() {} // 0x0000000181F54890-0x0000000181F54930
	[BlackList] // 0x00000001899162C0-0x0000000189916300
	// [XID] // 0x00000001899162C0-0x0000000189916300
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181F547F0-0x0000000181F54890
}

