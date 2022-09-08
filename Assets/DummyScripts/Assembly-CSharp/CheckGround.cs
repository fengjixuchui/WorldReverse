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
public class CheckGround : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 16495
{
	// Fields
	private bool _enable; // 0x10
	private SimpleSafeFloat raycastUpHeightRawNum; // 0x14
	private SimpleSafeFloat raycastDownHeightRawNum; // 0x18
	private bool _stickToGroundIfValid; // 0x1C
	private bool _dontCreateIfInvalid; // 0x1D

	// Properties
	public bool enable { /* [XID] */ /* 0x00000001898F3740-0x00000001898F3760 */ get => default; /* [XID] */ /* 0x00000001898FADA0-0x00000001898FADC0 */ private set {} } // 0x00000001840592B0-0x0000000184059350 0x0000000184059960-0x0000000184059A10
	public float raycastUpHeight { /* [XID] */ /* 0x0000000189AED4F0-0x0000000189AED510 */ get => default; /* [XID] */ /* 0x0000000189909EC0-0x0000000189909EE0 */ private set {} } // 0x00000001840593F0-0x00000001840594D0 0x0000000184058E50-0x0000000184058F30
	public float raycastDownHeight { /* [XID] */ /* 0x0000000189911760-0x0000000189911780 */ get => default; /* [XID] */ /* 0x00000001899192E0-0x0000000189919300 */ private set {} } // 0x0000000184059AC0-0x0000000184059BA0 0x00000001840589A0-0x0000000184058A80
	public bool stickToGroundIfValid { /* [XID] */ /* 0x0000000189920870-0x0000000189920890 */ get => default; /* [XID] */ /* 0x00000001899281F0-0x0000000189928210 */ private set {} } // 0x0000000184058900-0x00000001840589A0 0x00000001840598B0-0x0000000184059960
	public bool dontCreateIfInvalid { /* [XID] */ /* 0x000000018992F780-0x000000018992F7A0 */ get => default; /* [XID] */ /* 0x0000000189936C10-0x0000000189936C30 */ private set {} } // 0x0000000184059350-0x00000001840593F0 0x0000000184059A10-0x0000000184059AC0

	// Constructors
	public CheckGround() {} // 0x000000018405A2C0-0x000000018405A380

	// Methods
	// [XID] // 0x000000018993E7F0-0x000000018993E810
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184059F80-0x000000018405A0E0
	// [XID] // 0x0000000189945DE0-0x0000000189945E00
	public void InitEmpty() {} // 0x00000001840594D0-0x00000001840595B0
	[BlackList] // 0x000000018994D2B0-0x000000018994D2F0
	// [XID] // 0x000000018994D2B0-0x000000018994D2F0
	public bool FromJson(JSONNode node) => default; // 0x0000000184058F30-0x00000001840592B0
	// [XID] // 0x0000000189957BE0-0x0000000189957C00
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184057F60-0x00000001840584A0
	// [XID] // 0x000000018995F490-0x000000018995F4B0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3D40 */, bool useObjectPool = false /* Metadata: 0x00AF3D44 */) => default; // 0x00000001840595B0-0x00000001840598B0
	// [XID] // 0x0000000189966D70-0x0000000189966D90
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3D45 */, bool useObjectPool = false /* Metadata: 0x00AF3D49 */) => default; // 0x0000000184058A80-0x0000000184058E50
	[BlackList] // 0x000000018996E060-0x000000018996E0A0
	// [XID] // 0x000000018996E060-0x000000018996E0A0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001840584A0-0x0000000184058770
	// [XID] // 0x0000000189979190-0x00000001899791B0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184059BA0-0x0000000184059F80
	[BlackList] // 0x0000000189980220-0x0000000189980260
	// [XID] // 0x0000000189980220-0x0000000189980260
	public virtual void AutoAllocTypeFields() {} // 0x0000000184058770-0x0000000184058810
	[BlackList] // 0x000000018998AE80-0x000000018998AEC0
	// [XID] // 0x000000018998AE80-0x000000018998AEC0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184058810-0x0000000184058900
	[BlackList] // 0x0000000189995970-0x00000001899959B0
	// [XID] // 0x0000000189995970-0x00000001899959B0
	public virtual void ReturnToObjectPool() {} // 0x000000018405A220-0x000000018405A2C0
	[BlackList] // 0x00000001899A03D0-0x00000001899A0410
	// [XID] // 0x00000001899A03D0-0x00000001899A0410
	public virtual void OnPoolAllocated() {} // 0x000000018405A180-0x000000018405A220
	[BlackList] // 0x00000001899AADC0-0x00000001899AAE00
	// [XID] // 0x00000001899AADC0-0x00000001899AAE00
	public virtual void OnBeforePoolRecycled() {} // 0x000000018405A0E0-0x000000018405A180
}

