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

public sealed class AbilityShieldBarMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14568
{
	// Fields
	private ShieldBarMixin _config; // 0x70
	private BaseEntity _entity; // 0x78
	private LCAbilityElement _lcElement; // 0x80
	private float _maxShield; // 0x88
	private float _shield; // 0x8C
	private VCBillboard _vcBillboard; // 0x90
	private int _addedTimes; // 0x98
	private bool _needSyncToRemote; // 0x9C
	private float _lastSyncTime; // 0xA0
	private const float SYNC_INTERNAL = 0.2f; // Metadata: 0x00AEB7EF
	private EntityMultiPlayerExcelConfig _multiConfig; // 0xA8
	private float _multiRatio; // 0xB0
	private float _lastMultiRatio; // 0xB4
	private int _lastOtherPlayerNum; // 0xB8
	private InitReason initReason; // 0xBC

	// Properties
	private bool isReady { /* [XID] */ /* 0x00000001899A8340-0x00000001899A8360 */ get => default; } // 0x0000000183FF3370-0x0000000183FF3420 

	// Nested types
	private enum InitReason // TypeDefIndex: 14569
	{
		init = 0,
		reInit = 1,
		finish = 2
	}

	private enum RefreshReason // TypeDefIndex: 14570
	{
		playerNumChange = 0,
		init = 1,
		reinit = 2
	}

	// Constructors
	public AbilityShieldBarMixin() {} // 0x0000000183FF4CB0-0x0000000183FF4D40

	// Methods
	// [XID] // 0x00000001899AFB10-0x00000001899AFB30
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000183FF34D0-0x0000000183FF36B0
	// [XID] // 0x00000001899B6FE0-0x00000001899B7000
	private void InitMultiConfig() {} // 0x0000000183FF4590-0x0000000183FF46B0
	// [XID] // 0x00000001899BEA60-0x00000001899BEA80
	private bool UpdateMultiRatio() => default; // 0x0000000183FF2840-0x0000000183FF2A60
	// [XID] // 0x00000001899C64C0-0x00000001899C64E0
	private void OnLocalAvatarChange() {} // 0x0000000183FF2AC0-0x0000000183FF2B70
	// [XID] // 0x00000001899CDA20-0x00000001899CDA40
	private void RefreshModifier(RefreshReason reason) {} // 0x0000000183FF3C60-0x0000000183FF3F30
	// [XID] // 0x00000001899D4FE0-0x00000001899D5000
	public override void Clear() {} // 0x0000000183FF3980-0x0000000183FF3B20
	// [XID] // 0x00000001899DC560-0x00000001899DC580
	public override void OnAdded(bool syncToServer) {} // 0x0000000183FF1F30-0x0000000183FF2000
	// [XID] // 0x00000001899E3DE0-0x00000001899E3E00
	public override void LazySetInstancedAbility(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000183FF2B70-0x0000000183FF2C70
	// [XID] // 0x00000001899EB350-0x00000001899EB370
	private void CheckReady() {} // 0x0000000183FF36B0-0x0000000183FF3890
	// [XID] // 0x00000001899F2FE0-0x00000001899F3000
	private void OnModifierDurabilityEmpty(float? deltaValue) {} // 0x0000000183FF4160-0x0000000183FF4220
	// [XID] // 0x00000001899FA650-0x00000001899FA670
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000183FF3110-0x0000000183FF3370
	// [XID] // 0x0000000189A01860-0x0000000189A01880
	private void ShowElementShield(VCCombatBillboardPlugin combatPlugin) {} // 0x0000000183FF2430-0x0000000183FF2580
	// [XID] // 0x0000000189A09350-0x0000000189A09370
	public override void Tick(float inDeltaTime) {} // 0x0000000183FF47D0-0x0000000183FF4CB0
	// [XID] // 0x0000000189A107E0-0x0000000189A10800
	private void TickSyncToServer() {} // 0x0000000183FF4090-0x0000000183FF4160
	// [XID] // 0x0000000189A17E70-0x0000000189A17E90
	private void OnShieldBroken() {} // 0x0000000183FF2F10-0x0000000183FF3090
	// [XID] // 0x0000000189A1F3F0-0x0000000189A1F410
	protected override void AddEventListener() {} // 0x0000000183FF2740-0x0000000183FF2840
	// [XID] // 0x0000000189A26990-0x0000000189A269B0
	protected override void RemoveEventListener() {} // 0x0000000183FF3F30-0x0000000183FF4030
	// [XID] // 0x0000000189A2DEC0-0x0000000189A2DEE0
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x0000000183FF3B20-0x0000000183FF3C00
	// [XID] // 0x0000000189A358E0-0x0000000189A35900
	public override bool ListenEvent(BaseEvent evt) => default; // 0x0000000183FF4220-0x0000000183FF42F0
	// [XID] // 0x0000000189A3CE90-0x0000000189A3CEB0
	private void TrySyncToServer() {} // 0x0000000183FF2090-0x0000000183FF2290
	// [XID] // 0x0000000189A44790-0x0000000189A447B0
	private void DoShowElementShiled(VCCombatBillboardPlugin _combatBillboardPlugin, AbilityMixinShieldBar abilityMessage) {} // 0x0000000183FF2580-0x0000000183FF2740
	// [XID] // 0x0000000189A4BE70-0x0000000189A4BE90
	public override void HandleMixinInvokeEntry(UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000183FF2C70-0x0000000183FF2F10
	[BlackList] // 0x0000000189A53510-0x0000000189A53550
	// [XID] // 0x0000000189A53510-0x0000000189A53550
	public override void AutoAllocTypeFields() {} // 0x0000000183FF2290-0x0000000183FF2330
	[BlackList] // 0x0000000189A5E0F0-0x0000000189A5E130
	// [XID] // 0x0000000189A5E0F0-0x0000000189A5E130
	public override void AutoRecycleTypeFields() {} // 0x0000000183FF2330-0x0000000183FF2430
	[BlackList] // 0x0000000189A68D50-0x0000000189A68D90
	// [XID] // 0x0000000189A68D50-0x0000000189A68D90
	public override void ReturnToObjectPool() {} // 0x0000000183FF4730-0x0000000183FF47D0
}

