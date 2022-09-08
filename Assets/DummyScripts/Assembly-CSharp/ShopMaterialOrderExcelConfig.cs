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
public class ShopMaterialOrderExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16115
{
	// Fields
	protected SimpleSafeUInt32 IdRawNum; // 0x10
	protected SimpleSafeUInt32 orderRawNum; // 0x14
	protected ShopType _shopType; // 0x18

	// Properties
	public uint Id { /* [XID] */ /* 0x0000000189605CF0-0x0000000189605D10 */ get => default; /* [XID] */ /* 0x000000018960D560-0x000000018960D580 */ protected set {} } // 0x0000000182904AB0-0x0000000182904B80 0x0000000182905070-0x0000000182905150
	public uint order { /* [XID] */ /* 0x0000000189614CC0-0x0000000189614CE0 */ get => default; /* [XID] */ /* 0x000000018961C560-0x000000018961C580 */ protected set {} } // 0x0000000182904380-0x0000000182904450 0x0000000182904B80-0x0000000182904C60
	public ShopType shopType { /* [XID] */ /* 0x0000000189623A20-0x0000000189623A40 */ get => default; /* [XID] */ /* 0x000000018962B240-0x000000018962B260 */ protected set {} } // 0x0000000182904A10-0x0000000182904AB0 0x00000001829042D0-0x0000000182904380

	// Constructors
	public ShopMaterialOrderExcelConfig() {} // 0x0000000182905330-0x0000000182905390

	// Methods
	// [IDTag] // 0x0000000189632A00-0x0000000189632A40
	// [XID] // 0x0000000189632A00-0x0000000189632A40
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182904450-0x0000000182904750
	// [IDTag] // 0x000000018963D550-0x000000018963D590
	// [XID] // 0x000000018963D550-0x000000018963D590
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182904750-0x0000000182904A10
	// [XID] // 0x0000000189647A70-0x0000000189647A90
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF319A */, bool useObjectPool = false /* Metadata: 0x00AF319E */) => default; // 0x0000000182904C60-0x0000000182905070
	[BlackList] // 0x000000018964F100-0x000000018964F140
	// [XID] // 0x000000018964F100-0x000000018964F140
	public virtual void AutoAllocTypeFields() {} // 0x0000000182904140-0x00000001829041E0
	[BlackList] // 0x0000000189659930-0x0000000189659970
	// [XID] // 0x0000000189659930-0x0000000189659970
	public virtual void AutoRecycleTypeFields() {} // 0x00000001829041E0-0x00000001829042D0
	[BlackList] // 0x0000000189664000-0x0000000189664040
	// [XID] // 0x0000000189664000-0x0000000189664040
	public virtual void ReturnToObjectPool() {} // 0x0000000182905290-0x0000000182905330
	[BlackList] // 0x000000018966EAE0-0x000000018966EB20
	// [XID] // 0x000000018966EAE0-0x000000018966EB20
	public virtual void OnPoolAllocated() {} // 0x00000001829051F0-0x0000000182905290
	[BlackList] // 0x0000000189679870-0x00000001896798B0
	// [XID] // 0x0000000189679870-0x00000001896798B0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182905150-0x00000001829051F0
}

