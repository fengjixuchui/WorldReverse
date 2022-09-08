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
public class ShowUICombatBar : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16663
{
	// Fields
	private bool _show; // 0x68
	private bool _fore; // 0x69

	// Properties
	public bool show { /* [XID] */ /* 0x000000018979D9D0-0x000000018979D9F0 */ get => default; /* [XID] */ /* 0x00000001897A4CD0-0x00000001897A4CF0 */ private set {} } // 0x0000000182485770-0x0000000182485810 0x0000000182486500-0x00000001824865B0
	public bool fore { /* [XID] */ /* 0x00000001897AC240-0x00000001897AC260 */ get => default; /* [XID] */ /* 0x00000001897B4210-0x00000001897B4230 */ private set {} } // 0x0000000182486AD0-0x0000000182486B70 0x0000000182486450-0x0000000182486500
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018983F8B0-0x000000018983F8D0 */ get => default; } // 0x00000001824862A0-0x0000000182486340 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189846F30-0x0000000189846F50 */ get => default; } // 0x00000001824858F0-0x0000000182485990 

	// Constructors
	public ShowUICombatBar() {} // 0x0000000182486C10-0x0000000182486C80

	// Methods
	// [XID] // 0x00000001897BBEB0-0x00000001897BBED0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182486920-0x0000000182486A30
	// [XID] // 0x00000001897C3670-0x00000001897C3690
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001824863A0-0x0000000182486450
	// [XID] // 0x00000001897CAE90-0x00000001897CAEB0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF426A */) => default; // 0x0000000182485F10-0x0000000182485FF0
	// [XID] // 0x00000001897D2550-0x00000001897D2570
	public override int GetHashNum() => default; // 0x0000000182484AB0-0x0000000182484B80
	// [XID] // 0x00000001897DA250-0x00000001897DA270
	public override void InitEmpty() {} // 0x0000000182485990-0x0000000182485A30
	[BlackList] // 0x00000001897E16C0-0x00000001897E1700
	// [XID] // 0x00000001897E16C0-0x00000001897E1700
	public override bool FromJson(JSONNode node) => default; // 0x00000001824851D0-0x0000000182485550
	// [XID] // 0x00000001897EC160-0x00000001897EC180
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182484230-0x0000000182484500
	[BlackList] // 0x00000001897F3B30-0x00000001897F3B70
	// [XID] // 0x00000001897F3B30-0x00000001897F3B70
	public static new ShowUICombatBar ParseFromJson(JSONNode node) => default; // 0x0000000182486050-0x00000001824862A0
	// [XID] // 0x00000001897FDE40-0x00000001897FDE60
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF426B */, bool useObjectPool = false /* Metadata: 0x00AF426F */) => default; // 0x0000000182485C10-0x0000000182485F10
	// [XID] // 0x0000000189805650-0x0000000189805670
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4270 */, bool useObjectPool = false /* Metadata: 0x00AF4274 */) => default; // 0x0000000182484CD0-0x0000000182484F70
	// [XID] // 0x000000018980CBF0-0x000000018980CC10
	public static new ShowUICombatBar ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4275 */, bool useObjectPool = false /* Metadata: 0x00AF4279 */) => default; // 0x0000000182485550-0x0000000182485770
	[BlackList] // 0x00000001898144D0-0x0000000189814510
	// [XID] // 0x00000001898144D0-0x0000000189814510
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182484500-0x00000001824847D0
	// [XID] // 0x000000018981EFE0-0x000000018981F000
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182486690-0x0000000182486920
	[BlackList] // 0x0000000189826550-0x0000000189826590
	// [XID] // 0x0000000189826550-0x0000000189826590
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182485B10-0x0000000182485C10
	// [XID] // 0x0000000189830BA0-0x0000000189830BC0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000182486A30-0x0000000182486AD0
	// [XID] // 0x0000000189838220-0x0000000189838240
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182484F70-0x00000001824850D0
	[BlackList] // 0x000000018984E520-0x000000018984E560
	// [XID] // 0x000000018984E520-0x000000018984E560
	public override void AutoAllocTypeFields() {} // 0x00000001824847D0-0x0000000182484870
	[BlackList] // 0x00000001898588A0-0x00000001898588E0
	// [XID] // 0x00000001898588A0-0x00000001898588E0
	public override void AutoRecycleTypeFields() {} // 0x0000000182484870-0x0000000182484920
	[BlackList] // 0x0000000189862DF0-0x0000000189862E30
	// [XID] // 0x0000000189862DF0-0x0000000189862E30
	public override void ReturnToObjectPool() {} // 0x0000000182486B70-0x0000000182486C10
}

