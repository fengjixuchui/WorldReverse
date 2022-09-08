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
public class ProductPS4PackageDetailConfig : ProductDetailConfig, IAutoAllocRecycle // TypeDefIndex: 16145
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected PackageContentConfig[] _contentVec; // 0x28
	protected SimpleSafeUInt32 mailConfigIdRawNum; // 0x30

	// Properties
	public PackageContentConfig[] contentVec { /* [XID] */ /* 0x0000000189ACFE90-0x0000000189ACFEB0 */ get => default; /* [XID] */ /* 0x0000000189AD7CE0-0x0000000189AD7D00 */ protected set {} } // 0x0000000183FC9C60-0x0000000183FC9D00 0x0000000183FCA2B0-0x0000000183FCA360
	public uint mailConfigId { /* [XID] */ /* 0x0000000189ADF7D0-0x0000000189ADF7F0 */ get => default; /* [XID] */ /* 0x0000000189AE6F90-0x0000000189AE6FB0 */ protected set {} } // 0x0000000183FC90B0-0x0000000183FC9180 0x0000000183FC8DA0-0x0000000183FC8E80

	// Constructors
	public ProductPS4PackageDetailConfig() {} // 0x0000000183FCA400-0x0000000183FCA460

	// Methods
	// [IDTag] // 0x0000000189AEEAA0-0x0000000189AEEAE0
	// [XID] // 0x0000000189AEEAA0-0x0000000189AEEAE0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183FC9650-0x0000000183FC9B70
	// [IDTag] // 0x0000000189AF9190-0x0000000189AF91D0
	// [XID] // 0x0000000189AF9190-0x0000000189AF91D0
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183FC91E0-0x0000000183FC9650
	// [XID] // 0x0000000189B03490-0x0000000189B034B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3268 */, bool useObjectPool = false /* Metadata: 0x00AF326C */) => default; // 0x0000000183FC9D00-0x0000000183FCA250
	[BlackList] // 0x0000000189B0ACA0-0x0000000189B0ACE0
	// [XID] // 0x0000000189B0ACA0-0x0000000189B0ACE0
	public override void AutoAllocTypeFields() {} // 0x0000000183FC8E80-0x0000000183FC8F20
	[BlackList] // 0x0000000189B15110-0x0000000189B15150
	// [XID] // 0x0000000189B15110-0x0000000189B15150
	public override void AutoRecycleTypeFields() {} // 0x0000000183FC8F20-0x0000000183FC9010
	[BlackList] // 0x0000000189B1F860-0x0000000189B1F8A0
	// [XID] // 0x0000000189B1F860-0x0000000189B1F8A0
	public override void ReturnToObjectPool() {} // 0x0000000183FCA360-0x0000000183FCA400
}

