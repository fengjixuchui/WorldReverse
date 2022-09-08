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
public class ConfigAbilityMixin : BaseActionContainer, IAutoAllocRecycle // TypeDefIndex: 16869
{
	// Fields
	private bool _isUnique; // 0x20
	private Action<object> _getSubActions; // 0x28

	// Properties
	public bool isUnique { /* [XID] */ /* 0x0000000189856E00-0x0000000189856E20 */ get => default; /* [XID] */ /* 0x000000018985DF30-0x000000018985DF50 */ private set {} } // 0x0000000183E120F0-0x0000000183E12190 0x0000000183E11420-0x0000000183E114D0
	public virtual MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001898E1490-0x00000001898E14B0 */ get => default; } // 0x0000000183E11A50-0x0000000183E11AF0 
	public virtual bool IsAuthorityOnly { /* [XID] */ /* 0x000000018990E8D0-0x000000018990E8F0 */ get => default; } // 0x0000000183E12AE0-0x0000000183E12BA0 

	// Nested types
	public enum MixinMPBehaviorType // TypeDefIndex: 16870
	{
		Mute = 0,
		AuthorityOnly = 1,
		Verbatim = 2,
		Custom = 3
	}

	// Constructors
	public ConfigAbilityMixin() {} // 0x0000000183E132C0-0x0000000183E13320

	// Methods
	// [XID] // 0x0000000189865970-0x0000000189865990
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183E12EE0-0x0000000183E12FD0
	// [XID] // 0x000000018986CE50-0x000000018986CE70
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183E12A30-0x0000000183E12AE0
	// [XID] // 0x00000001898DA130-0x00000001898DA150
	public virtual ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5BE9 */) => default; // 0x0000000183E126F0-0x0000000183E127D0
	// [XID] // 0x000000018987BE20-0x000000018987BE40
	public virtual int GetHashNum() => default; // 0x0000000183E11350-0x0000000183E11420
	// [XID] // 0x0000000189882F70-0x0000000189882F90
	public override void InitEmpty() {} // 0x0000000183E12190-0x0000000183E12230
	[BlackList] // 0x000000018988A770-0x000000018988A7B0
	// [XID] // 0x000000018988A770-0x000000018988A7B0
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000183E11AF0-0x0000000183E11E70
	// [XID] // 0x0000000189894C50-0x0000000189894C70
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183E10C80-0x0000000183E10E40
	[BlackList] // 0x000000018989C240-0x000000018989C280
	// [XID] // 0x000000018989C240-0x000000018989C280
	public static ConfigAbilityMixin ParseFromJson(JSONNode node) => default; // 0x0000000183E12830-0x0000000183E12A30
	// [XID] // 0x00000001898E9AF0-0x00000001898E9B10
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5BEA */, bool useObjectPool = false /* Metadata: 0x00AF5BEE */) => default; // 0x0000000183E12320-0x0000000183E12620
	// [XID] // 0x0000000189968B90-0x0000000189968BB0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5BEF */, bool useObjectPool = false /* Metadata: 0x00AF5BF3 */) => default; // 0x0000000183E11800-0x0000000183E119D0
	// [XID] // 0x00000001898B5650-0x00000001898B5670
	public static ConfigAbilityMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5BF4 */, bool useObjectPool = false /* Metadata: 0x00AF5BF8 */) => default; // 0x0000000183E11E70-0x0000000183E12040
	[BlackList] // 0x00000001898BD060-0x00000001898BD0A0
	// [XID] // 0x00000001898BD060-0x00000001898BD0A0
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000183E10E40-0x0000000183E11110
	// [XID] // 0x00000001898C77C0-0x00000001898C77E0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183E12BA0-0x0000000183E12D50
	[BlackList] // 0x00000001898CEE30-0x00000001898CEE70
	// [XID] // 0x00000001898CEE30-0x00000001898CEE70
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183E12230-0x0000000183E12320
	// [XID] // 0x0000000189B738F0-0x0000000189B73910
	public virtual BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000183E12620-0x0000000183E126F0
	// [XID] // 0x00000001898E8EA0-0x00000001898E8EC0
	public virtual BaseAbilityMixin MPCreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000183E12D50-0x0000000183E12EE0
	// [XID] // 0x00000001898F0620-0x00000001898F0640
	public sealed override void GetAllSubActions() {} // 0x0000000183E11250-0x0000000183E11350
	// [XID] // 0x00000001898F8030-0x00000001898F8050
	protected virtual void GetSubActions(object member) {} // 0x0000000183E11540-0x0000000183E11800
	// [XID] // 0x00000001898FF6B0-0x00000001898FF6D0
	public override int GetHashCode() => default; // 0x0000000183E12040-0x0000000183E120F0
	// [XID] // 0x0000000189906EB0-0x0000000189906ED0
	protected bool IsAuthority(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000183E13110-0x0000000183E13220
	[BlackList] // 0x0000000189915F00-0x0000000189915F40
	// [XID] // 0x0000000189915F00-0x0000000189915F40
	public virtual void AutoAllocTypeFields() {} // 0x0000000183E11110-0x0000000183E111B0
	[BlackList] // 0x00000001899207B0-0x00000001899207F0
	// [XID] // 0x00000001899207B0-0x00000001899207F0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183E111B0-0x0000000183E11250
	[BlackList] // 0x000000018992B0A0-0x000000018992B0E0
	// [XID] // 0x000000018992B0A0-0x000000018992B0E0
	public virtual void ReturnToObjectPool() {} // 0x0000000183E13220-0x0000000183E132C0
	[BlackList] // 0x00000001899353D0-0x0000000189935410
	// [XID] // 0x00000001899353D0-0x0000000189935410
	public virtual void OnPoolAllocated() {} // 0x0000000183E13070-0x0000000183E13110
	[BlackList] // 0x000000018993FD60-0x000000018993FDA0
	// [XID] // 0x000000018993FD60-0x000000018993FDA0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183E12FD0-0x0000000183E13070
}

