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
public class AttachElementTypeResistance : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16759
{
	// Fields
	private ElementType _elementType; // 0x68
	private SimpleSafeFloat durationRatioRawNum; // 0x6C

	// Properties
	public ElementType elementType { /* [XID] */ /* 0x0000000189B94F10-0x0000000189B94F30 */ get => default; /* [XID] */ /* 0x0000000189B9C660-0x0000000189B9C680 */ private set {} } // 0x0000000181F55B70-0x0000000181F55C10 0x0000000181F56B90-0x0000000181F56C40
	public float durationRatio { /* [XID] */ /* 0x0000000189BA3C90-0x0000000189BA3CB0 */ get => default; /* [XID] */ /* 0x0000000189BAB140-0x0000000189BAB160 */ private set {} } // 0x0000000181F56090-0x0000000181F56170 0x0000000181F574C0-0x0000000181F575A0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189634410-0x0000000189634430 */ get => default; } // 0x0000000181F56E90-0x0000000181F56F30 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018963BBA0-0x000000018963BBC0 */ get => default; } // 0x0000000181F56400-0x0000000181F564A0 

	// Constructors
	public AttachElementTypeResistance() {} // 0x0000000181F57640-0x0000000181F576A0

	// Methods
	// [XID] // 0x0000000189BB26F0-0x0000000189BB2710
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181F573B0-0x0000000181F574C0
	// [XID] // 0x0000000189BB9B40-0x0000000189BB9B60
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181F56F90-0x0000000181F57040
	// [XID] // 0x0000000189BC1B10-0x0000000189BC1B30
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF455E */) => default; // 0x0000000181F56A50-0x0000000181F56B30
	// [XID] // 0x0000000189BC9120-0x0000000189BC9140
	public override int GetHashNum() => default; // 0x0000000181F55510-0x0000000181F555E0
	// [XID] // 0x0000000189BD09F0-0x0000000189BD0A10
	public override void InitEmpty() {} // 0x0000000181F564A0-0x0000000181F56570
	[BlackList] // 0x0000000189BD7EF0-0x0000000189BD7F30
	// [XID] // 0x0000000189BD7EF0-0x0000000189BD7F30
	public override bool FromJson(JSONNode node) => default; // 0x0000000181F55D10-0x0000000181F56090
	// [XID] // 0x00000001895E7B50-0x00000001895E7B70
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181F54BD0-0x0000000181F54F30
	[BlackList] // 0x00000001895EF4A0-0x00000001895EF4E0
	// [XID] // 0x00000001895EF4A0-0x00000001895EF4E0
	public static new AttachElementTypeResistance ParseFromJson(JSONNode node) => default; // 0x0000000181F56C40-0x0000000181F56E90
	// [XID] // 0x00000001895F9C60-0x00000001895F9C80
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF455F */, bool useObjectPool = false /* Metadata: 0x00AF4563 */) => default; // 0x0000000181F56750-0x0000000181F56A50
	// [XID] // 0x0000000189601440-0x0000000189601460
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4564 */, bool useObjectPool = false /* Metadata: 0x00AF4568 */) => default; // 0x0000000181F55730-0x0000000181F55A10
	// [XID] // 0x0000000189608DD0-0x0000000189608DF0
	public static new AttachElementTypeResistance ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4569 */, bool useObjectPool = false /* Metadata: 0x00AF456D */) => default; // 0x0000000181F56170-0x0000000181F56390
	[BlackList] // 0x0000000189610550-0x0000000189610590
	// [XID] // 0x0000000189610550-0x0000000189610590
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181F54F30-0x0000000181F55200
	// [XID] // 0x000000018961AB20-0x000000018961AB40
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181F57120-0x0000000181F573B0
	[BlackList] // 0x00000001896220E0-0x0000000189622120
	// [XID] // 0x00000001896220E0-0x0000000189622120
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181F56650-0x0000000181F56750
	// [XID] // 0x000000018962C750-0x000000018962C770
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000181F55A10-0x0000000181F55B70
	[BlackList] // 0x0000000189643220-0x0000000189643260
	// [XID] // 0x0000000189643220-0x0000000189643260
	public override void AutoAllocTypeFields() {} // 0x0000000181F55200-0x0000000181F552A0
	[BlackList] // 0x000000018964D960-0x000000018964D9A0
	// [XID] // 0x000000018964D960-0x000000018964D9A0
	public override void AutoRecycleTypeFields() {} // 0x0000000181F552A0-0x0000000181F55380
	[BlackList] // 0x0000000189658190-0x00000001896581D0
	// [XID] // 0x0000000189658190-0x00000001896581D0
	public override void ReturnToObjectPool() {} // 0x0000000181F575A0-0x0000000181F57640
}

