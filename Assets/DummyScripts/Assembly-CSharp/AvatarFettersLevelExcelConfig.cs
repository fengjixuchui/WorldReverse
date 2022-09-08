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
public class AvatarFettersLevelExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15212
{
	// Fields
	protected SimpleSafeUInt32 fetter_levelRawNum; // 0x10
	protected SimpleSafeUInt32 need_expRawNum; // 0x14

	// Properties
	public uint fetter_level { /* [XID] */ /* 0x000000018984B7D0-0x000000018984B7F0 */ get => default; /* [XID] */ /* 0x0000000189852860-0x0000000189852880 */ protected set {} } // 0x0000000182D6B490-0x0000000182D6B560 0x0000000182D6B630-0x0000000182D6B710
	public uint need_exp { /* [XID] */ /* 0x000000018985A330-0x000000018985A350 */ get => default; /* [XID] */ /* 0x00000001898614F0-0x0000000189861510 */ protected set {} } // 0x0000000182D6B560-0x0000000182D6B630 0x0000000182D6B050-0x0000000182D6B130

	// Constructors
	public AvatarFettersLevelExcelConfig() {} // 0x0000000182D6B8F0-0x0000000182D6B950

	// Methods
	// [IDTag] // 0x0000000189868C90-0x0000000189868CD0
	// [XID] // 0x0000000189868C90-0x0000000189868CD0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182D6ABC0-0x0000000182D6AE30
	// [IDTag] // 0x0000000189873030-0x0000000189873070
	// [XID] // 0x0000000189873030-0x0000000189873070
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182D6AE30-0x0000000182D6B050
	// [XID] // 0x000000018987DCA0-0x000000018987DCC0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF03F8 */, bool useObjectPool = false /* Metadata: 0x00AF03FC */) => default; // 0x0000000182D6B130-0x0000000182D6B490
	[BlackList] // 0x0000000189884C30-0x0000000189884C70
	// [XID] // 0x0000000189884C30-0x0000000189884C70
	public virtual void AutoAllocTypeFields() {} // 0x0000000182D6AA40-0x0000000182D6AAE0
	[BlackList] // 0x000000018988F100-0x000000018988F140
	// [XID] // 0x000000018988F100-0x000000018988F140
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182D6AAE0-0x0000000182D6ABC0
	[BlackList] // 0x0000000189899890-0x00000001898998D0
	// [XID] // 0x0000000189899890-0x00000001898998D0
	public virtual void ReturnToObjectPool() {} // 0x0000000182D6B850-0x0000000182D6B8F0
	[BlackList] // 0x00000001898A3D00-0x00000001898A3D40
	// [XID] // 0x00000001898A3D00-0x00000001898A3D40
	public virtual void OnPoolAllocated() {} // 0x0000000182D6B7B0-0x0000000182D6B850
	[BlackList] // 0x00000001898AE4B0-0x00000001898AE4F0
	// [XID] // 0x00000001898AE4B0-0x00000001898AE4F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182D6B710-0x0000000182D6B7B0
}

