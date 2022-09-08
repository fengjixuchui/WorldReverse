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
public class ConfigRecoverEnergyEffect : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17921
{
	// Fields
	private ElementType _elementType; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigEffectWithThreshold[] _effects; // 0x18

	// Properties
	public ElementType elementType { /* [XID] */ /* 0x0000000189A61CF0-0x0000000189A61D10 */ get => default; /* [XID] */ /* 0x0000000189A69C70-0x0000000189A69C90 */ private set {} } // 0x0000000180E5D870-0x0000000180E5D910 0x0000000180E5E060-0x0000000180E5E110
	public ConfigEffectWithThreshold[] effects { /* [XID] */ /* 0x00000001898AEB90-0x00000001898AEBB0 */ get => default; /* [XID] */ /* 0x0000000189A78B20-0x0000000189A78B40 */ private set {} } // 0x0000000180E5E110-0x0000000180E5E1B0 0x0000000180E5D520-0x0000000180E5D5D0

	// Constructors
	public ConfigRecoverEnergyEffect() {} // 0x0000000180E5E710-0x0000000180E5E770

	// Methods
	// [XID] // 0x0000000189A7FEA0-0x0000000189A7FEC0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000180E5E420-0x0000000180E5E530
	// [XID] // 0x0000000189A87C60-0x0000000189A87C80
	public void InitEmpty() {} // 0x0000000180E5DC90-0x0000000180E5DD60
	[BlackList] // 0x0000000189A8F4D0-0x0000000189A8F510
	// [XID] // 0x0000000189A8F4D0-0x0000000189A8F510
	public bool FromJson(JSONNode node) => default; // 0x0000000180E5D910-0x0000000180E5DC90
	// [XID] // 0x00000001897411C0-0x00000001897411E0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000180E5CE40-0x0000000180E5D100
	// [XID] // 0x000000018994AD30-0x000000018994AD50
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8213 */, bool useObjectPool = false /* Metadata: 0x00AF8217 */) => default; // 0x0000000180E5DD60-0x0000000180E5E060
	// [XID] // 0x0000000189AA83A0-0x0000000189AA83C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8218 */, bool useObjectPool = false /* Metadata: 0x00AF821C */) => default; // 0x0000000180E5D5D0-0x0000000180E5D870
	[BlackList] // 0x0000000189AB00A0-0x0000000189AB00E0
	// [XID] // 0x0000000189AB00A0-0x0000000189AB00E0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000180E5D100-0x0000000180E5D3D0
	// [XID] // 0x0000000189ABACD0-0x0000000189ABACF0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000180E5E1B0-0x0000000180E5E420
	[BlackList] // 0x0000000189AC2560-0x0000000189AC25A0
	// [XID] // 0x0000000189AC2560-0x0000000189AC25A0
	public virtual void AutoAllocTypeFields() {} // 0x0000000180E5D3D0-0x0000000180E5D470
	[BlackList] // 0x0000000189ACCA60-0x0000000189ACCAA0
	// [XID] // 0x0000000189ACCA60-0x0000000189ACCAA0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000180E5D470-0x0000000180E5D520
	[BlackList] // 0x0000000189AD78A0-0x0000000189AD78E0
	// [XID] // 0x0000000189AD78A0-0x0000000189AD78E0
	public virtual void ReturnToObjectPool() {} // 0x0000000180E5E670-0x0000000180E5E710
	[BlackList] // 0x0000000189AE20C0-0x0000000189AE2100
	// [XID] // 0x0000000189AE20C0-0x0000000189AE2100
	public virtual void OnPoolAllocated() {} // 0x0000000180E5E5D0-0x0000000180E5E670
	[BlackList] // 0x0000000189AECA20-0x0000000189AECA60
	// [XID] // 0x0000000189AECA20-0x0000000189AECA60
	public virtual void OnBeforePoolRecycled() {} // 0x0000000180E5E530-0x0000000180E5E5D0
}

