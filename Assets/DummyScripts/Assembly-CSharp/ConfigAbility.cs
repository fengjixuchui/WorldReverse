/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigAbility : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14946
{
	// Fields
	private string _abilityName; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityMixin[] _abilityMixins; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, DynamicArgument> _abilitySpecials; // 0x20
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigAbilityModifier> _modifiers; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAbilityModifier _defaultModifier; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onAdded; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onRemoved; // 0x40
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onAbilityStart; // 0x48
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onKill; // 0x50
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onFieldEnter; // 0x58
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onFieldExit; // 0x60
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onAttach; // 0x68
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onDetach; // 0x70
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onAvatarIn; // 0x78
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onAvatarOut; // 0x80
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onTriggerAvatarRay; // 0x88
	private bool _isDynamicAbility; // 0x90
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigAbilityPropertyEntry> _abilityDefinedProperties; // 0x98
	private const string DEFAULT_MODIFIER_NAME = "__DEFAULT_MODIFIER"; // Metadata: 0x00AEFB52
	[NonSerialized]
	public Dictionary<uint, BaseActionContainer> invokeSites; // 0xA0
	[NonSerialized]
	public List<ConfigAbilityModifier> modifierIDMap; // 0xA8
	[NonSerialized]
	public string overrideName; // 0xB0
	[NonSerialized]
	public int fullNameHashCode; // 0xB8
	private static StringBuilder _stringBuilder; // 0x00
	public bool fromPool; // 0xBC
	private static Action<object, ConfigAbilityAction> _resolveSubActionMPBehavior; // 0x08
	private static Action<object, ConfigAbilityMixin> _resolveSubMixinMPBehavior; // 0x10

	// Properties
	public string abilityName { /* [XID] */ /* 0x00000001898E1DD0-0x00000001898E1DF0 */ get => default; /* [XID] */ /* 0x0000000189ABFD50-0x0000000189ABFD70 */ private set {} } // 0x000000018367A170-0x000000018367A210 0x000000018367C5C0-0x000000018367C670
	public ConfigAbilityMixin[] abilityMixins { /* [XID] */ /* 0x0000000189B24300-0x0000000189B24320 */ get => default; /* [XID] */ /* 0x0000000189B2B690-0x0000000189B2B6B0 */ private set {} } // 0x000000018367CBC0-0x000000018367CC60 0x00000001836783D0-0x0000000183678480
	public Dictionary<string, DynamicArgument> abilitySpecials { /* [XID] */ /* 0x0000000189AD6D30-0x0000000189AD6D50 */ get => default; /* [XID] */ /* 0x0000000189B3A490-0x0000000189B3A4B0 */ private set {} } // 0x0000000183676DB0-0x0000000183676E50 0x000000018367A210-0x000000018367A2C0
	public Dictionary<string, ConfigAbilityModifier> modifiers { /* [XID] */ /* 0x0000000189B41F10-0x0000000189B41F30 */ get => default; /* [XID] */ /* 0x0000000189B49900-0x0000000189B49920 */ private set {} } // 0x0000000183676A40-0x0000000183676AE0 0x000000018367D7D0-0x000000018367D880
	public ConfigAbilityModifier defaultModifier { /* [XID] */ /* 0x0000000189B50F80-0x0000000189B50FA0 */ get => default; /* [XID] */ /* 0x0000000189B58770-0x0000000189B58790 */ private set {} } // 0x000000018367A7A0-0x000000018367A840 0x0000000183676BB0-0x0000000183676C60
	public ConfigAbilityAction[] onAdded { /* [XID] */ /* 0x0000000189B60160-0x0000000189B60180 */ get => default; /* [XID] */ /* 0x0000000189B678C0-0x0000000189B678E0 */ private set {} } // 0x000000018367A450-0x000000018367A4F0 0x0000000183677EF0-0x0000000183677FA0
	public ConfigAbilityAction[] onRemoved { /* [XID] */ /* 0x0000000189B6EB00-0x0000000189B6EB20 */ get => default; /* [XID] */ /* 0x0000000189B76290-0x0000000189B762B0 */ private set {} } // 0x000000018367D280-0x000000018367D320 0x000000018367CB10-0x000000018367CBC0
	public ConfigAbilityAction[] onAbilityStart { /* [XID] */ /* 0x0000000189BBBEB0-0x0000000189BBBED0 */ get => default; /* [XID] */ /* 0x0000000189B855B0-0x0000000189B855D0 */ private set {} } // 0x0000000183678D70-0x0000000183678E10 0x0000000183676F00-0x0000000183676FB0
	public ConfigAbilityAction[] onKill { /* [XID] */ /* 0x0000000189B8C320-0x0000000189B8C340 */ get => default; /* [XID] */ /* 0x0000000189B93BF0-0x0000000189B93C10 */ private set {} } // 0x000000018367CA70-0x000000018367CB10 0x00000001836766A0-0x0000000183676750
	public ConfigAbilityAction[] onFieldEnter { /* [XID] */ /* 0x0000000189B9B200-0x0000000189B9B220 */ get => default; /* [XID] */ /* 0x0000000189BA2990-0x0000000189BA29B0 */ private set {} } // 0x000000018367B180-0x000000018367B220 0x000000018367A6F0-0x000000018367A7A0
	public ConfigAbilityAction[] onFieldExit { /* [XID] */ /* 0x0000000189BA9DC0-0x0000000189BA9DE0 */ get => default; /* [XID] */ /* 0x0000000189BB1670-0x0000000189BB1690 */ private set {} } // 0x000000018367B2D0-0x000000018367B370 0x0000000183676E50-0x0000000183676F00
	public ConfigAbilityAction[] onAttach { /* [XID] */ /* 0x0000000189BB85C0-0x0000000189BB85E0 */ get => default; /* [XID] */ /* 0x0000000189BBFF50-0x0000000189BBFF70 */ private set {} } // 0x000000018367A8F0-0x000000018367A990 0x0000000183678E10-0x0000000183678EC0
	public ConfigAbilityAction[] onDetach { /* [XID] */ /* 0x0000000189BC7AA0-0x0000000189BC7AC0 */ get => default; /* [XID] */ /* 0x0000000189BCF550-0x0000000189BCF570 */ private set {} } // 0x0000000183679A30-0x0000000183679AD0 0x000000018367B220-0x000000018367B2D0
	public ConfigAbilityAction[] onAvatarIn { /* [XID] */ /* 0x0000000189BD68E0-0x0000000189BD6900 */ get => default; /* [XID] */ /* 0x0000000189BDE6A0-0x0000000189BDE6C0 */ private set {} } // 0x0000000183678EC0-0x0000000183678F60 0x000000018367A3A0-0x000000018367A450
	public ConfigAbilityAction[] onAvatarOut { /* [XID] */ /* 0x00000001895EB130-0x00000001895EB150 */ get => default; /* [XID] */ /* 0x00000001895F25B0-0x00000001895F25D0 */ private set {} } // 0x0000000183678BA0-0x0000000183678C50 0x000000018367A840-0x000000018367A8F0
	public ConfigAbilityAction[] onTriggerAvatarRay { /* [XID] */ /* 0x00000001895FA040-0x00000001895FA060 */ get => default; /* [XID] */ /* 0x00000001896017A0-0x00000001896017C0 */ private set {} } // 0x000000018367CC60-0x000000018367CD10 0x0000000183677E40-0x0000000183677EF0
	public bool isDynamicAbility { /* [XID] */ /* 0x000000018974A210-0x000000018974A230 */ get => default; /* [XID] */ /* 0x00000001896108D0-0x00000001896108F0 */ private set {} } // 0x0000000183677D90-0x0000000183677E40 0x0000000183677FA0-0x0000000183678050
	public Dictionary<string, ConfigAbilityPropertyEntry> abilityDefinedProperties { /* [XID] */ /* 0x0000000189617B70-0x0000000189617B90 */ get => default; /* [XID] */ /* 0x000000018961F820-0x000000018961F840 */ private set {} } // 0x0000000183676C60-0x0000000183676D10 0x0000000183679160-0x0000000183679210

	// Constructors
	public ConfigAbility(ConfigAbilityAction[] onAdded) {} // 0x000000018367DAF0-0x000000018367DB80
	public ConfigAbility() {} // 0x000000018367DA80-0x000000018367DAF0
	static ConfigAbility() {} // 0x000000018367D920-0x000000018367DA80

	// Methods
	// [XID] // 0x0000000189626BA0-0x0000000189626BC0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018367C670-0x000000018367C930
	// [XID] // 0x000000018962E490-0x000000018962E4B0
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018367A990-0x000000018367AC30
	// [XID] // 0x0000000189636110-0x0000000189636130
	public virtual ConfigAbility Clone(bool useObjectPool = false /* Metadata: 0x00AEFB42 */) => default; // 0x000000018367A2C0-0x000000018367A3A0
	// [XID] // 0x000000018963D7B0-0x000000018963D7D0
	public virtual int GetHashNum() => default; // 0x0000000183676AE0-0x0000000183676BB0
	// [XID] // 0x0000000189644CF0-0x0000000189644D10
	public virtual void InitEmpty() {} // 0x0000000183678F60-0x0000000183679160
	[BlackList] // 0x000000018964C750-0x000000018964C790
	// [XID] // 0x000000018964C750-0x000000018964C790
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000183678050-0x00000001836783D0
	// [XID] // 0x0000000189656CF0-0x0000000189656D10
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001836750D0-0x0000000183676140
	[BlackList] // 0x000000018965E3F0-0x000000018965E430
	// [XID] // 0x000000018965E3F0-0x000000018965E430
	public static ConfigAbility ParseFromJson(JSONNode node) => default; // 0x000000018367A4F0-0x000000018367A6F0
	// [XID] // 0x0000000189668D60-0x0000000189668D80
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFB43 */, bool useObjectPool = false /* Metadata: 0x00AEFB47 */) => default; // 0x0000000183679E70-0x000000018367A170
	// [XID] // 0x00000001896708B0-0x00000001896708D0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFB48 */, bool useObjectPool = false /* Metadata: 0x00AEFB4C */) => default; // 0x0000000183677020-0x0000000183677D90
	// [XID] // 0x0000000189678090-0x00000001896780B0
	public static ConfigAbility ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFB4D */, bool useObjectPool = false /* Metadata: 0x00AEFB51 */) => default; // 0x00000001836785E0-0x00000001836787B0
	[BlackList] // 0x000000018967F880-0x000000018967F8C0
	// [XID] // 0x000000018967F880-0x000000018967F8C0
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x00000001836763D0-0x00000001836766A0
	// [XID] // 0x000000018968A290-0x000000018968A2B0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018367B830-0x000000018367C5C0
	[BlackList] // 0x0000000189691FF0-0x0000000189692030
	// [XID] // 0x0000000189691FF0-0x0000000189692030
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183679550-0x0000000183679640
	// [XID] // 0x000000018969C400-0x000000018969C420
	public void OnBakeLoaded(string abilityName, string overrideName) {} // 0x0000000183673FB0-0x00000001836750D0
	// [XID] // 0x00000001896A38A0-0x00000001896A38C0
	private void HotFixOnlineAbilityData() {} // 0x0000000183676D10-0x0000000183676DB0
	// [XID] // 0x00000001896AAD30-0x00000001896AAD50
	public override int GetHashCode() => default; // 0x00000001836787B0-0x0000000183678BA0
	// [XID] // 0x00000001896B1D70-0x00000001896B1D90
	private void CheckActionValid(ConfigAbilityAction action) {} // 0x0000000183679210-0x00000001836792C0
	// [XID] // 0x00000001896B9810-0x00000001896B9830
	private void SetActionsDoOffStage(object owner, ConfigAbilityAction action) {} // 0x0000000183679640-0x0000000183679A30
	// [IDTag] // 0x00000001896C0B20-0x00000001896C0B60
	// [XID] // 0x00000001896C0B20-0x00000001896C0B60
	private void _IterateActionsSubActions(object owner, ConfigAbilityAction[] actions, Action<object, ConfigAbilityAction> callback) {} // 0x000000018367D320-0x000000018367D4B0
	// [XID] // 0x0000000189829DB0-0x0000000189829DD0
	private void _IterateMixinsSubActions(object owner, ConfigAbilityMixin[] mixins, Action<object, ConfigAbilityAction> callback) {} // 0x0000000183678480-0x00000001836785E0
	// [IDTag] // 0x00000001896D2640-0x00000001896D2680
	// [XID] // 0x00000001896D2640-0x00000001896D2680
	private void _IterateSubActions(object owner, BaseActionContainer actionContainer, Action<object, ConfigAbilityAction> callback) {} // 0x000000018367AE20-0x000000018367B050
	// [IDTag] // 0x00000001896DCC80-0x00000001896DCCC0
	// [XID] // 0x00000001896DCC80-0x00000001896DCCC0
	private void IterateAbilitySubActions(ConfigAbility ability, Action<object, ConfigAbilityAction> callback) {} // 0x000000018367CFE0-0x000000018367D280
	// [IDTag] // 0x00000001896E72E0-0x00000001896E7320
	// [XID] // 0x00000001896E72E0-0x00000001896E7320
	private void IterateAbilitySubActions(ConfigAbility ability) {} // 0x000000018367CD10-0x000000018367CFE0
	// [IDTag] // 0x00000001896F13A0-0x00000001896F13E0
	// [XID] // 0x00000001896F13A0-0x00000001896F13E0
	private void _IterateActionsSubActions(ConfigAbilityAction[] actions, AbilityCommonLocalID common_id) {} // 0x000000018367D4B0-0x000000018367D7D0
	// [IDTag] // 0x00000001896FC0F0-0x00000001896FC130
	// [XID] // 0x00000001896FC0F0-0x00000001896FC130
	private void _IterateSubActions(BaseActionContainer actionContainer, AbilityCommonLocalID common_id) {} // 0x000000018367AC30-0x000000018367AE20
	// [IDTag] // 0x0000000189706520-0x0000000189706560
	// [XID] // 0x0000000189706520-0x0000000189706560
	private void IterateAbilitySubMixins(ConfigAbility ability) {} // 0x0000000183676140-0x0000000183676240
	// [XID] // 0x00000001896AB2D0-0x00000001896AB2F0
	private void _IterateSubMixins(ConfigAbilityMixin[] mixins, AbilityCommonLocalID common_id) {} // 0x0000000183679AD0-0x0000000183679E70
	// [IDTag] // 0x0000000189718410-0x0000000189718450
	// [XID] // 0x0000000189718410-0x0000000189718450
	private void IterateModifierSubActions(ConfigAbilityModifier modifier, AbilityCommonLocalID common_id) {} // 0x000000018367B5B0-0x000000018367B830
	// [IDTag] // 0x00000001897229E0-0x0000000189722A20
	// [XID] // 0x00000001897229E0-0x0000000189722A20
	private void IterateModifierSubMixins(ConfigAbilityModifier modifier, AbilityCommonLocalID common_id) {} // 0x0000000183679450-0x0000000183679550
	// [IDTag] // 0x000000018972D0C0-0x000000018972D100
	// [XID] // 0x000000018972D0C0-0x000000018972D100
	private void IterateAbilitySubMixins(ConfigAbility ability, Action<object, ConfigAbilityMixin> callback) {} // 0x0000000183676240-0x00000001836763D0
	// [IDTag] // 0x0000000189737B40-0x0000000189737B80
	// [XID] // 0x0000000189737B40-0x0000000189737B80
	private void IterateModifierSubActions(ConfigAbilityModifier modifier, Action<object, ConfigAbilityAction> callback) {} // 0x000000018367B370-0x000000018367B5B0
	// [IDTag] // 0x0000000189742100-0x0000000189742140
	// [XID] // 0x0000000189742100-0x0000000189742140
	private void IterateModifierSubMixins(ConfigAbilityModifier modifier, Action<object, ConfigAbilityMixin> callback) {} // 0x00000001836792C0-0x0000000183679450
	// [XID] // 0x00000001897F8BB0-0x00000001897F8BD0
	private void ResolveModifierMPBehavior(ConfigAbilityModifier modifier) {} // 0x0000000183673D80-0x0000000183673FB0
	// [XID] // 0x00000001897540A0-0x00000001897540C0
	private static void ResolveSubActionMPBehavior(object owner, ConfigAbilityAction action) {} // 0x0000000183678C50-0x0000000183678D70
	// [XID] // 0x000000018975B4E0-0x000000018975B500
	private static void ResolveSubMixinMPBehavior(object owner, ConfigAbilityMixin mixin) {} // 0x000000018367B050-0x000000018367B180
	[BlackList] // 0x0000000189762F50-0x0000000189762F90
	// [XID] // 0x0000000189762F50-0x0000000189762F90
	public virtual void AutoAllocTypeFields() {} // 0x0000000183676750-0x00000001836767F0
	[BlackList] // 0x000000018976D560-0x000000018976D5A0
	// [XID] // 0x000000018976D560-0x000000018976D5A0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001836767F0-0x0000000183676A40
	[BlackList] // 0x0000000189777AB0-0x0000000189777AF0
	// [XID] // 0x0000000189777AB0-0x0000000189777AF0
	public virtual void ReturnToObjectPool() {} // 0x000000018367D880-0x000000018367D920
	[BlackList] // 0x0000000189782600-0x0000000189782640
	// [XID] // 0x0000000189782600-0x0000000189782640
	public virtual void OnPoolAllocated() {} // 0x000000018367C9D0-0x000000018367CA70
	[BlackList] // 0x000000018978C8B0-0x000000018978C8F0
	// [XID] // 0x000000018978C8B0-0x000000018978C8F0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018367C930-0x000000018367C9D0
}

