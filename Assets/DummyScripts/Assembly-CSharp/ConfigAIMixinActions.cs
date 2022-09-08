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
public class ConfigAIMixinActions : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17511
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAIMixinSetBool[] _setPoseBool; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAIMixinSetInt[] _setPoseInt; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAIMixinSetFloat[] _setPoseFloat; // 0x20
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAIMixinSetAnimatorTrigger[] _setAnimatorTrigger; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAIMixinSetBool[] _setAnimatorBool; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAIMixinSetInt[] _setAnimatorInt; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAIMixinSetFloat[] _setAnimatorFloat; // 0x40

	// Properties
	public ConfigAIMixinSetBool[] setPoseBool { /* [XID] */ /* 0x0000000189AEF3B0-0x0000000189AEF3D0 */ get => default; /* [XID] */ /* 0x0000000189643140-0x0000000189643160 */ private set {} } // 0x0000000181A1C760-0x0000000181A1C800 0x0000000181A1BC90-0x0000000181A1BD40
	public ConfigAIMixinSetInt[] setPoseInt { /* [XID] */ /* 0x0000000189B99CC0-0x0000000189B99CE0 */ get => default; /* [XID] */ /* 0x0000000189652060-0x0000000189652080 */ private set {} } // 0x0000000181A1C800-0x0000000181A1C8A0 0x0000000181A1BBE0-0x0000000181A1BC90
	public ConfigAIMixinSetFloat[] setPoseFloat { /* [XID] */ /* 0x000000018974D2B0-0x000000018974D2D0 */ get => default; /* [XID] */ /* 0x0000000189660E50-0x0000000189660E70 */ private set {} } // 0x0000000181A1AFC0-0x0000000181A1B060 0x0000000181A1CE40-0x0000000181A1CEF0
	public ConfigAIMixinSetAnimatorTrigger[] setAnimatorTrigger { /* [XID] */ /* 0x00000001896687C0-0x00000001896687E0 */ get => default; /* [XID] */ /* 0x0000000189670330-0x0000000189670350 */ private set {} } // 0x0000000181A1C340-0x0000000181A1C3E0 0x0000000181A1C8A0-0x0000000181A1C950
	public ConfigAIMixinSetBool[] setAnimatorBool { /* [XID] */ /* 0x0000000189BBEBD0-0x0000000189BBEBF0 */ get => default; /* [XID] */ /* 0x000000018967F180-0x000000018967F1A0 */ private set {} } // 0x0000000181A1D710-0x0000000181A1D7B0 0x0000000181A1CEF0-0x0000000181A1CFA0
	public ConfigAIMixinSetInt[] setAnimatorInt { /* [XID] */ /* 0x00000001895EE690-0x00000001895EE6B0 */ get => default; /* [XID] */ /* 0x000000018968E8F0-0x000000018968E910 */ private set {} } // 0x0000000181A1CFA0-0x0000000181A1D040 0x0000000181A1CD90-0x0000000181A1CE40
	public ConfigAIMixinSetFloat[] setAnimatorFloat { /* [XID] */ /* 0x00000001896963B0-0x00000001896963D0 */ get => default; /* [XID] */ /* 0x000000018969D970-0x000000018969D990 */ private set {} } // 0x0000000181A1D040-0x0000000181A1D0E0 0x0000000181A1D7B0-0x0000000181A1D860

	// Constructors
	public ConfigAIMixinActions() {} // 0x0000000181A1DBD0-0x0000000181A1DC30

	// Methods
	// [XID] // 0x00000001896A49A0-0x00000001896A49C0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181A1D860-0x0000000181A1D9F0
	// [XID] // 0x00000001896AC150-0x00000001896AC170
	public void InitEmpty() {} // 0x0000000181A1C950-0x0000000181A1CA90
	[BlackList] // 0x00000001896B3430-0x00000001896B3470
	// [XID] // 0x00000001896B3430-0x00000001896B3470
	public bool FromJson(JSONNode node) => default; // 0x0000000181A1C3E0-0x0000000181A1C760
	// [XID] // 0x00000001896BD7C0-0x00000001896BD7E0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181A1B060-0x0000000181A1B770
	// [XID] // 0x00000001896C4F10-0x00000001896C4F30
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7143 */, bool useObjectPool = false /* Metadata: 0x00AF7147 */) => default; // 0x0000000181A1CA90-0x0000000181A1CD90
	// [XID] // 0x00000001896CC430-0x00000001896CC450
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7148 */, bool useObjectPool = false /* Metadata: 0x00AF714C */) => default; // 0x0000000181A1BD40-0x0000000181A1C340
	[BlackList] // 0x00000001896D3600-0x00000001896D3640
	// [XID] // 0x00000001896D3600-0x00000001896D3640
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181A1B770-0x0000000181A1BA40
	// [XID] // 0x00000001896DE0A0-0x00000001896DE0C0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181A1D0E0-0x0000000181A1D710
	[BlackList] // 0x00000001896E5590-0x00000001896E55D0
	// [XID] // 0x00000001896E5590-0x00000001896E55D0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181A1BA40-0x0000000181A1BAE0
	[BlackList] // 0x00000001896EFA20-0x00000001896EFA60
	// [XID] // 0x00000001896EFA20-0x00000001896EFA60
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181A1BAE0-0x0000000181A1BBE0
	[BlackList] // 0x00000001896FA270-0x00000001896FA2B0
	// [XID] // 0x00000001896FA270-0x00000001896FA2B0
	public virtual void ReturnToObjectPool() {} // 0x0000000181A1DB30-0x0000000181A1DBD0
	[BlackList] // 0x00000001897048F0-0x0000000189704930
	// [XID] // 0x00000001897048F0-0x0000000189704930
	public virtual void OnPoolAllocated() {} // 0x0000000181A1DA90-0x0000000181A1DB30
	[BlackList] // 0x000000018970F240-0x000000018970F280
	// [XID] // 0x000000018970F240-0x000000018970F280
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181A1D9F0-0x0000000181A1DA90
}

