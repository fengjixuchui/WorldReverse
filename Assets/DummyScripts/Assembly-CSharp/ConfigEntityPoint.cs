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
public class ConfigEntityPoint : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17950
{
	// Fields
	private string _elementAbsorb; // 0x10
	private string _elementPendant; // 0x18
	private string _elementDrop; // 0x20
	private string _bulletAim; // 0x28
	private string[] _hitPoints; // 0x30
	private string[] _selectedPoints; // 0x38

	// Properties
	public string elementAbsorb { /* [XID] */ /* 0x0000000189BDD330-0x0000000189BDD350 */ get => default; /* [XID] */ /* 0x0000000189AB1C20-0x0000000189AB1C40 */ private set {} } // 0x00000001837C12A0-0x00000001837C1340 0x00000001837C11F0-0x00000001837C12A0
	public string elementPendant { /* [XID] */ /* 0x0000000189BC9A10-0x0000000189BC9A30 */ get => default; /* [XID] */ /* 0x0000000189AC0A10-0x0000000189AC0A30 */ private set {} } // 0x00000001837C2390-0x00000001837C2430 0x00000001837C1FE0-0x00000001837C2090
	public string elementDrop { /* [XID] */ /* 0x0000000189AC83F0-0x0000000189AC8410 */ get => default; /* [XID] */ /* 0x0000000189ACFBB0-0x0000000189ACFBD0 */ private set {} } // 0x00000001837C1810-0x00000001837C18B0 0x00000001837C1F30-0x00000001837C1FE0
	public string bulletAim { /* [XID] */ /* 0x0000000189AD7880-0x0000000189AD78A0 */ get => default; /* [XID] */ /* 0x0000000189ADF390-0x0000000189ADF3B0 */ private set {} } // 0x00000001837C24D0-0x00000001837C2570 0x00000001837C1D90-0x00000001837C1E40
	public string[] hitPoints { /* [XID] */ /* 0x00000001898D3F80-0x00000001898D3FA0 */ get => default; /* [XID] */ /* 0x0000000189AEE6E0-0x0000000189AEE700 */ private set {} } // 0x00000001837C2430-0x00000001837C24D0 0x00000001837C1960-0x00000001837C1A10
	public string[] selectedPoints { /* [XID] */ /* 0x0000000189AF5C50-0x0000000189AF5C70 */ get => default; /* [XID] */ /* 0x0000000189AFD1F0-0x0000000189AFD210 */ private set {} } // 0x00000001837C2570-0x00000001837C2610 0x00000001837C18B0-0x00000001837C1960

	// Constructors
	public ConfigEntityPoint() {} // 0x00000001837C2E10-0x00000001837C2EA0

	// Methods
	// [XID] // 0x0000000189B04A00-0x0000000189B04A20
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001837C2AC0-0x00000001837C2C30
	// [XID] // 0x0000000189B0C1D0-0x0000000189B0C1F0
	public void InitEmpty() {} // 0x00000001837C1E40-0x00000001837C1F30
	[BlackList] // 0x0000000189B13770-0x0000000189B137B0
	// [XID] // 0x0000000189B13770-0x0000000189B137B0
	public bool FromJson(JSONNode node) => default; // 0x00000001837C1A10-0x00000001837C1D90
	// [XID] // 0x0000000189B1DBB0-0x0000000189B1DBD0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001837C0810-0x00000001837C0DD0
	// [XID] // 0x0000000189B253E0-0x0000000189B25400
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8483 */, bool useObjectPool = false /* Metadata: 0x00AF8487 */) => default; // 0x00000001837C2090-0x00000001837C2390
	// [XID] // 0x0000000189B2C990-0x0000000189B2C9B0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8488 */, bool useObjectPool = false /* Metadata: 0x00AF848C */) => default; // 0x00000001837C1340-0x00000001837C1810
	[BlackList] // 0x0000000189B33D80-0x0000000189B33DC0
	// [XID] // 0x0000000189B33D80-0x0000000189B33DC0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001837C0DD0-0x00000001837C10A0
	// [XID] // 0x0000000189B3E760-0x0000000189B3E780
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001837C2610-0x00000001837C2AC0
	[BlackList] // 0x0000000189B46200-0x0000000189B46240
	// [XID] // 0x0000000189B46200-0x0000000189B46240
	public virtual void AutoAllocTypeFields() {} // 0x00000001837C10A0-0x00000001837C1140
	[BlackList] // 0x0000000189B509A0-0x0000000189B509E0
	// [XID] // 0x0000000189B509A0-0x0000000189B509E0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001837C1140-0x00000001837C11F0
	[BlackList] // 0x0000000189B5B070-0x0000000189B5B0B0
	// [XID] // 0x0000000189B5B070-0x0000000189B5B0B0
	public virtual void ReturnToObjectPool() {} // 0x00000001837C2D70-0x00000001837C2E10
	[BlackList] // 0x0000000189B657E0-0x0000000189B65820
	// [XID] // 0x0000000189B657E0-0x0000000189B65820
	public virtual void OnPoolAllocated() {} // 0x00000001837C2CD0-0x00000001837C2D70
	[BlackList] // 0x0000000189B6FDE0-0x0000000189B6FE20
	// [XID] // 0x0000000189B6FDE0-0x0000000189B6FE20
	public virtual void OnBeforePoolRecycled() {} // 0x00000001837C2C30-0x00000001837C2CD0
}

