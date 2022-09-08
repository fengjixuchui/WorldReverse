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
public class SpawnAttach : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16373
{
	// Fields
	private bool _enable; // 0x68
	private string _attachName; // 0x70

	// Properties
	public bool enable { /* [XID] */ /* 0x0000000189974570-0x0000000189974590 */ get => default; /* [XID] */ /* 0x000000018997BB80-0x000000018997BBA0 */ private set {} } // 0x000000018476F610-0x000000018476F6B0 0x0000000184770420-0x00000001847704D0
	public string attachName { /* [XID] */ /* 0x00000001899836F0-0x0000000189983710 */ get => default; /* [XID] */ /* 0x000000018998AF20-0x000000018998AF40 */ private set {} } // 0x000000018476FA50-0x000000018476FAF0 0x000000018476EA80-0x000000018476EB30
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189A162C0-0x0000000189A162E0 */ get => default; } // 0x00000001847704D0-0x0000000184770570 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189A1D820-0x0000000189A1D840 */ get => default; } // 0x000000018476F9B0-0x000000018476FA50 

	// Constructors
	public SpawnAttach() {} // 0x0000000184770C70-0x0000000184770CE0

	// Methods
	// [XID] // 0x0000000189992830-0x0000000189992850
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184770A20-0x0000000184770B30
	// [XID] // 0x000000018999A5B0-0x000000018999A5D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001847705D0-0x00000001847706B0
	// [XID] // 0x00000001899A1C90-0x00000001899A1CB0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3968 */) => default; // 0x0000000184770090-0x0000000184770170
	// [XID] // 0x00000001899A9520-0x00000001899A9540
	public override int GetHashNum() => default; // 0x000000018476EB30-0x000000018476EC00
	// [XID] // 0x00000001899B1030-0x00000001899B1050
	public override void InitEmpty() {} // 0x000000018476FAF0-0x000000018476FBC0
	[BlackList] // 0x00000001899B81F0-0x00000001899B8230
	// [XID] // 0x00000001899B81F0-0x00000001899B8230
	public override bool FromJson(JSONNode node) => default; // 0x000000018476F290-0x000000018476F610
	// [XID] // 0x00000001899C2F80-0x00000001899C2FA0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018476E1E0-0x000000018476E4D0
	[BlackList] // 0x00000001899CA300-0x00000001899CA340
	// [XID] // 0x00000001899CA300-0x00000001899CA340
	public static new SpawnAttach ParseFromJson(JSONNode node) => default; // 0x00000001847701D0-0x0000000184770420
	// [XID] // 0x00000001899D4A90-0x00000001899D4AB0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3969 */, bool useObjectPool = false /* Metadata: 0x00AF396D */) => default; // 0x000000018476FD90-0x0000000184770090
	// [XID] // 0x00000001899DC0B0-0x00000001899DC0D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF396E */, bool useObjectPool = false /* Metadata: 0x00AF3972 */) => default; // 0x000000018476ED50-0x000000018476F030
	// [XID] // 0x00000001899E39F0-0x00000001899E3A10
	public static new SpawnAttach ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3973 */, bool useObjectPool = false /* Metadata: 0x00AF3977 */) => default; // 0x000000018476F6B0-0x000000018476F8D0
	[BlackList] // 0x00000001899EAE20-0x00000001899EAE60
	// [XID] // 0x00000001899EAE20-0x00000001899EAE60
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018476E4D0-0x000000018476E7A0
	// [XID] // 0x00000001899F58B0-0x00000001899F58D0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184770790-0x0000000184770A20
	[BlackList] // 0x00000001899FD090-0x00000001899FD0D0
	// [XID] // 0x00000001899FD090-0x00000001899FD0D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018476FCA0-0x000000018476FD90
	// [XID] // 0x0000000189A07690-0x0000000189A076B0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000184770B30-0x0000000184770BD0
	// [XID] // 0x0000000189A0EB10-0x0000000189A0EB30
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018476F030-0x000000018476F190
	[BlackList] // 0x0000000189A24BD0-0x0000000189A24C10
	// [XID] // 0x0000000189A24BD0-0x0000000189A24C10
	public override void AutoAllocTypeFields() {} // 0x000000018476E7A0-0x000000018476E840
	[BlackList] // 0x0000000189A2F290-0x0000000189A2F2D0
	// [XID] // 0x0000000189A2F290-0x0000000189A2F2D0
	public override void AutoRecycleTypeFields() {} // 0x000000018476E840-0x000000018476E8F0
	[BlackList] // 0x0000000189A39A30-0x0000000189A39A70
	// [XID] // 0x0000000189A39A30-0x0000000189A39A70
	public override void ReturnToObjectPool() {} // 0x0000000184770BD0-0x0000000184770C70
}

