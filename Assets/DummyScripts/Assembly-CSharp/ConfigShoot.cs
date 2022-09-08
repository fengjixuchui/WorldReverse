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
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigShoot : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18012
{
	// Fields
	private string _bulletBornAttachPoint; // 0x10
	private SimpleSafeFloat detectRangeFromViewportRawNum; // 0x18
	private SimpleSafeFloat detectRadiusFromViewportRawNum; // 0x1C
	private SimpleSafeFloat autoFocusMinRangeRawNum; // 0x20
	private SimpleSafeFloat autoFocusMaxRangeRawNum; // 0x24

	// Properties
	public string bulletBornAttachPoint { /* [XID] */ /* 0x00000001897F38B0-0x00000001897F38D0 */ get => default; /* [XID] */ /* 0x00000001897FB230-0x00000001897FB250 */ private set {} } // 0x00000001834F2120-0x00000001834F21C0 0x00000001834F3F30-0x00000001834F3FE0
	public float detectRangeFromViewport { /* [XID] */ /* 0x0000000189802680-0x00000001898026A0 */ get => default; /* [XID] */ /* 0x0000000189809C10-0x0000000189809C30 */ private set {} } // 0x00000001834F2CC0-0x00000001834F2DA0 0x00000001834F3400-0x00000001834F34E0
	public float detectRadiusFromViewport { /* [XID] */ /* 0x00000001898113A0-0x00000001898113C0 */ get => default; /* [XID] */ /* 0x0000000189818E50-0x0000000189818E70 */ private set {} } // 0x00000001834F3FE0-0x00000001834F40C0 0x00000001834F3860-0x00000001834F3940
	public float autoFocusMinRange { /* [XID] */ /* 0x0000000189820690-0x00000001898206B0 */ get => default; /* [XID] */ /* 0x0000000189827D00-0x0000000189827D20 */ private set {} } // 0x00000001834F3320-0x00000001834F3400 0x00000001834F2DA0-0x00000001834F2E80
	public float autoFocusMaxRange { /* [XID] */ /* 0x000000018982F0A0-0x000000018982F0C0 */ get => default; /* [XID] */ /* 0x0000000189836930-0x0000000189836950 */ private set {} } // 0x00000001834F3A20-0x00000001834F3B00 0x00000001834F3940-0x00000001834F3A20

	// Constructors
	public ConfigShoot() {} // 0x00000001834F47E0-0x00000001834F4840

	// Methods
	// [XID] // 0x000000018983DCC0-0x000000018983DCE0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001834F44A0-0x00000001834F4600
	// [XID] // 0x0000000189845530-0x0000000189845550
	public void InitEmpty() {} // 0x00000001834F3B00-0x00000001834F3C30
	[BlackList] // 0x000000018984C9C0-0x000000018984CA00
	// [XID] // 0x000000018984C9C0-0x000000018984CA00
	public bool FromJson(JSONNode node) => default; // 0x00000001834F34E0-0x00000001834F3860
	// [XID] // 0x0000000189856B40-0x0000000189856B60
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001834F21C0-0x00000001834F2840
	// [XID] // 0x000000018985DCD0-0x000000018985DCF0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF868D */, bool useObjectPool = false /* Metadata: 0x00AF8691 */) => default; // 0x00000001834F3C30-0x00000001834F3F30
	// [XID] // 0x0000000189865770-0x0000000189865790
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8692 */, bool useObjectPool = false /* Metadata: 0x00AF8696 */) => default; // 0x00000001834F2E80-0x00000001834F3320
	[BlackList] // 0x000000018986CBD0-0x000000018986CC10
	// [XID] // 0x000000018986CBD0-0x000000018986CC10
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001834F2840-0x00000001834F2B10
	// [XID] // 0x0000000189877310-0x0000000189877330
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001834F40C0-0x00000001834F44A0
	[BlackList] // 0x000000018987EC20-0x000000018987EC60
	// [XID] // 0x000000018987EC20-0x000000018987EC60
	public virtual void AutoAllocTypeFields() {} // 0x00000001834F2B10-0x00000001834F2BB0
	[BlackList] // 0x0000000189888FA0-0x0000000189888FE0
	// [XID] // 0x0000000189888FA0-0x0000000189888FE0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001834F2BB0-0x00000001834F2CC0
	[BlackList] // 0x0000000189893410-0x0000000189893450
	// [XID] // 0x0000000189893410-0x0000000189893450
	public virtual void ReturnToObjectPool() {} // 0x00000001834F4740-0x00000001834F47E0
	[BlackList] // 0x000000018989D620-0x000000018989D660
	// [XID] // 0x000000018989D620-0x000000018989D660
	public virtual void OnPoolAllocated() {} // 0x00000001834F46A0-0x00000001834F4740
	[BlackList] // 0x00000001898A7C30-0x00000001898A7C70
	// [XID] // 0x00000001898A7C30-0x00000001898A7C70
	public virtual void OnBeforePoolRecycled() {} // 0x00000001834F4600-0x00000001834F46A0
}

