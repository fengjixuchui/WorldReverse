/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityElementShieldMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14527
{
	// Fields
	private ElementShieldMixin _config; // 0x70
	private BaseEntity _entity; // 0x78
	private LCAbilityElement _lcElement; // 0x80
	private float _subShield; // 0x88
	private float _maxShield; // 0x8C
	private float _shield; // 0x90
	private AbsorbType _absorbType; // 0x94
	private bool _isShieldBroken; // 0x98
	private SimpleSafeFloat[] elementDamageRatios; // 0xA0
	private SimpleSafeInt32[] elemantRestraint; // 0xA8
	private float _eleRatio; // 0xB0
	private float _damageRatio; // 0xB4
	private float _lastDurability; // 0xB8
	private float _deltaShieldOverTick; // 0xBC
	private VCBillboard _vcBillboard; // 0xC0
	private int _addedTimes; // 0xC8
	private const float SYNC_CD = 1f; // Metadata: 0x00AEB7B2
	private float _syncToServerTimer; // 0xCC
	private EntityMultiPlayerExcelConfig _multiConfig; // 0xD0
	private float _multiRatio; // 0xD8
	private float _lastMultiRatio; // 0xDC
	private int _lastOtherPlayerNum; // 0xE0
	private InitReason initReason; // 0xE4

	// Properties
	public float shield { /* [XID] */ /* 0x0000000189858ED0-0x0000000189858EF0 */ get => default; } // 0x00000001816194D0-0x0000000181619580 
	private bool isReady { /* [XID] */ /* 0x00000001898600D0-0x00000001898600F0 */ get => default; } // 0x0000000181617DE0-0x0000000181617E90 

	// Nested types
	public enum AbsorbType // TypeDefIndex: 14528
	{
		Normal = 1,
		Element = 2
	}

	private enum InitReason // TypeDefIndex: 14529
	{
		init = 0,
		reInit = 1,
		finish = 2
	}

	private enum RefreshReason // TypeDefIndex: 14530
	{
		playerNumChange = 0,
		init = 1,
		reinit = 2
	}

	// Constructors
	public AbilityElementShieldMixin() {} // 0x000000018161A6C0-0x000000018161A770

	// Methods
	// [XID] // 0x0000000189867790-0x00000001898677B0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000181617E90-0x00000001816181D0
	// [XID] // 0x000000018986EE40-0x000000018986EE60
	private void InitMultiConfig() {} // 0x0000000181619A60-0x0000000181619B80
	// [XID] // 0x00000001898763B0-0x00000001898763D0
	private bool UpdateMultiRatio() => default; // 0x0000000181617420-0x0000000181617640
	// [XID] // 0x000000018987DF50-0x000000018987DF70
	private void OnLocalAvatarChange() {} // 0x00000001816176A0-0x0000000181617750
	// [XID] // 0x0000000189884FE0-0x0000000189885000
	private void RefreshModifier(RefreshReason reason) {} // 0x0000000181618EA0-0x0000000181619210
	// [XID] // 0x000000018988C5C0-0x000000018988C5E0
	public override void Clear() {} // 0x0000000181618670-0x00000001816187A0
	// [XID] // 0x0000000189893B10-0x0000000189893B30
	public override void OnAdded(bool syncToServer) {} // 0x0000000181616C20-0x0000000181616CF0
	// [XID] // 0x000000018989B210-0x000000018989B230
	public override void LazySetInstancedAbility(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000181617750-0x0000000181617850
	// [XID] // 0x00000001898A2630-0x00000001898A2650
	private void CheckReady() {} // 0x00000001816181D0-0x0000000181618580
	// [XID] // 0x00000001898A9BE0-0x00000001898A9C00
	private void OnShowElementShield(VCCombatBillboardPlugin plugin) {} // 0x0000000181619580-0x0000000181619670
	// [XID] // 0x00000001898B1690-0x00000001898B16B0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000181617C80-0x0000000181617DE0
	// [XID] // 0x00000001898B9000-0x00000001898B9020
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001816188A0-0x0000000181618980
	// [XID] // 0x00000001898C0560-0x00000001898C0580
	public override bool OnEvent(BaseEvent evt) => default; // 0x0000000181619CA0-0x0000000181619DC0
	// [XID] // 0x00000001898C7D80-0x00000001898C7DA0
	private static new EventID[] GetSelfOnEventRemoteIDsExcludingBase() => default; // 0x0000000181618980-0x0000000181618A60
	// [XID] // 0x00000001898CF5A0-0x00000001898CF5C0
	public override bool OnEventRemote(BaseEvent evt) => default; // 0x0000000181619B80-0x0000000181619CA0
	// [XID] // 0x00000001898D6DD0-0x00000001898D6DF0
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x00000001816187A0-0x00000001816188A0
	// [XID] // 0x00000001898DEBD0-0x00000001898DEBF0
	public override bool ListenEvent(BaseEvent evt) => default; // 0x00000001816196E0-0x00000001816197B0
	// [XID] // 0x00000001898E6290-0x00000001898E62B0
	private void TrySyncToServer() {} // 0x0000000181616E10-0x0000000181617000
	// [XID] // 0x00000001898EDB60-0x00000001898EDB80
	private bool OnBeingHit(EvtBeingHit evt) => default; // 0x0000000181618AC0-0x0000000181618EA0
	// [XID] // 0x00000001898F5470-0x00000001898F5490
	public override void Tick(float inDeltaTime) {} // 0x000000018161A330-0x000000018161A6C0
	// [XID] // 0x00000001898FCBC0-0x00000001898FCBE0
	private float CalDeltaShied(EvtBeingHit evt) => default; // 0x0000000181619E40-0x000000018161A290
	// [XID] // 0x00000001899045A0-0x00000001899045C0
	private void OnShieldBroken() {} // 0x0000000181617A80-0x0000000181617C00
	// [XID] // 0x000000018990BD60-0x000000018990BD80
	protected override void AddEventListener() {} // 0x0000000181617250-0x0000000181617390
	// [XID] // 0x0000000189913740-0x0000000189913760
	protected override void RemoveEventListener() {} // 0x00000001816192A0-0x00000001816193E0
	// [XID] // 0x000000018991B080-0x000000018991B0A0
	public override void HandleMixinInvokeEntry(UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000181617850-0x0000000181617A80
	[BlackList] // 0x00000001899226B0-0x00000001899226F0
	// [XID] // 0x00000001899226B0-0x00000001899226F0
	public override void AutoAllocTypeFields() {} // 0x0000000181617000-0x00000001816170A0
	[BlackList] // 0x000000018992CC90-0x000000018992CCD0
	// [XID] // 0x000000018992CC90-0x000000018992CCD0
	public override void AutoRecycleTypeFields() {} // 0x00000001816170A0-0x00000001816171D0
	[BlackList] // 0x0000000189937150-0x0000000189937190
	// [XID] // 0x0000000189937150-0x0000000189937190
	public override void ReturnToObjectPool() {} // 0x000000018161A290-0x000000018161A330
}

