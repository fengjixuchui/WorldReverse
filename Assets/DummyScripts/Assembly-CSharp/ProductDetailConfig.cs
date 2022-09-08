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
public class ProductDetailConfig : IAutoAllocRecycle // TypeDefIndex: 16135
{
	// Fields
	protected SimpleSafeUInt32 configIdRawNum; // 0x10
	protected string _priceTier; // 0x18
	protected ShopType _shopType; // 0x20

	// Properties
	public uint configId { /* [XID] */ /* 0x00000001899B8290-0x00000001899B82B0 */ get => default; /* [XID] */ /* 0x00000001899BFDB0-0x00000001899BFDD0 */ protected set {} } // 0x00000001820326E0-0x00000001820327B0 0x0000000182032C70-0x0000000182032D50
	public string priceTier { /* [XID] */ /* 0x00000001899C7610-0x00000001899C7630 */ get => default; /* [XID] */ /* 0x00000001899CEC20-0x00000001899CEC40 */ protected set {} } // 0x0000000182032640-0x00000001820326E0 0x00000001820327B0-0x0000000182032860
	public ShopType shopType { /* [XID] */ /* 0x00000001899D6390-0x00000001899D63B0 */ get => default; /* [XID] */ /* 0x00000001899DD820-0x00000001899DD840 */ protected set {} } // 0x00000001820325A0-0x0000000182032640 0x0000000182032230-0x00000001820322E0

	// Constructors
	public ProductDetailConfig() {} // 0x0000000182032F30-0x0000000182032F90

	// Methods
	// [XID] // 0x00000001899E5600-0x00000001899E5620
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001820322E0-0x00000001820325A0
	// [XID] // 0x00000001899EC830-0x00000001899EC850
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3222 */, bool useObjectPool = false /* Metadata: 0x00AF3226 */) => default; // 0x0000000182032860-0x0000000182032C70
	[BlackList] // 0x00000001899F4570-0x00000001899F45B0
	// [XID] // 0x00000001899F4570-0x00000001899F45B0
	public virtual void AutoAllocTypeFields() {} // 0x00000001820320B0-0x0000000182032150
	[BlackList] // 0x00000001899FE810-0x00000001899FE850
	// [XID] // 0x00000001899FE810-0x00000001899FE850
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182032150-0x0000000182032230
	[BlackList] // 0x0000000189A08D10-0x0000000189A08D50
	// [XID] // 0x0000000189A08D10-0x0000000189A08D50
	public virtual void ReturnToObjectPool() {} // 0x0000000182032E90-0x0000000182032F30
	[BlackList] // 0x0000000189A13540-0x0000000189A13580
	// [XID] // 0x0000000189A13540-0x0000000189A13580
	public virtual void OnPoolAllocated() {} // 0x0000000182032DF0-0x0000000182032E90
	[BlackList] // 0x0000000189A1D8C0-0x0000000189A1D900
	// [XID] // 0x0000000189A1D8C0-0x0000000189A1D900
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182032D50-0x0000000182032DF0
}

