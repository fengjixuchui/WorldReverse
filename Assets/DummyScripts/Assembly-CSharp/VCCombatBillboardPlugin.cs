/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCCombatBillboardPlugin : VCBaseBillboardPlugin // TypeDefIndex: 12159
{
	// Fields
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private ConfigCombatBillboard _config; // 0x88
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private Config _finalConfig; // 0x90
	private float _showForHittedLimit; // 0xA0
	public bool _hideForDead; // 0xA4
	private MonoCombatBillboard _combatBillboard; // 0xA8
	private bool _showSuppressLevel; // 0xB0
	private LCBaseCombat _lcCombat; // 0xB8
	private bool _showMonsterLevel; // 0xC0
	private int _level; // 0xC4
	private uint _entityRuntimeId; // 0xC8
	private bool _hasElementShield; // 0xCC
	private Action<EvtEntityReadyPost> _onEntityReadyPost; // 0xD0
	private bool _showForDistance; // 0xD8
	private bool _forceShow; // 0xD9
	private bool _haveHP; // 0xDA
	private float _hpRatio; // 0xDC
	private bool _haveShield; // 0xE0
	private float _shieldRatio; // 0xE4
	private bool _haveElementShield; // 0xE8
	private float _shieldValue; // 0xEC
	private float _elementShieldRatio; // 0xF0
	private const float _tickInterval = 0.5f; // Metadata: 0x00AEB58B
	private float _nextTickTime; // 0xF8
	private LevelSuppressExcelConfig _levelSuppressExcelConfig; // 0x100
	private float _checkTickTime; // 0x108
	private bool _inElementView; // 0x10C
	public bool hasUICombatBar; // 0x10D
	private float showUIBarDistance; // 0x110
	private float hideUIBarDistance; // 0x114
	private bool uiBarNeedEnterCombat; // 0x118
	public HpBarStyle hpBarStyle; // 0x11C
	private float _nextTickUIBarTime; // 0x120
	private bool _aiInCombat; // 0x124
	private bool _levelInfoNeedInit; // 0x125
	public float[] chargeSteps; // 0x128
	public float chargeCurrValue; // 0x130
	public int chargeCurrStep; // 0x134
	public ElementType elementType; // 0x138
	private bool _registered; // 0x13C

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189B95480-0x0000000189B954A0 */ get => default; } // 0x0000000182CE90F0-0x0000000182CE9190 
	public bool ResReady { /* [XID] */ /* 0x0000000189B9CAF0-0x0000000189B9CB10 */ get => default; } // 0x0000000182CE7DD0-0x0000000182CE7EA0 
	public int Level { /* [XID] */ /* 0x0000000189BA41A0-0x0000000189BA41C0 */ get => default; /* [XID] */ /* 0x0000000189BAB7D0-0x0000000189BAB7F0 */ set {} } // 0x0000000182CE2F70-0x0000000182CE3010 0x0000000182CE4D00-0x0000000182CE4DB0
	private bool showForDamaged { /* [XID] */ /* 0x0000000189626E10-0x0000000189626E30 */ get => default; } // 0x0000000182CE89B0-0x0000000182CE8A80 
	private bool showForHitted { /* [XID] */ /* 0x0000000189636420-0x0000000189636440 */ get => default; } // 0x0000000182CE2AC0-0x0000000182CE2B70 
	public bool hideForDead { /* [XID] */ /* 0x000000018963DA30-0x000000018963DA50 */ get => default; /* [XID] */ /* 0x00000001896F35B0-0x00000001896F35D0 */ set {} } // 0x0000000182CE2A10-0x0000000182CE2AC0 0x0000000182CE6F40-0x0000000182CE7000
	public override bool isActive { /* [XID] */ /* 0x000000018964CAA0-0x000000018964CAC0 */ get => default; } // 0x0000000182CE8350-0x0000000182CE8410 
	private bool shouldShow { /* [XID] */ /* 0x0000000189653ED0-0x0000000189653EF0 */ get => default; } // 0x0000000182CE6E50-0x0000000182CE6F40 
	public bool haveHP { /* [XID] */ /* 0x000000018966A7D0-0x000000018966A7F0 */ get => default; } // 0x0000000182CE63A0-0x0000000182CE6450 
	public float hpRatio { /* [XID] */ /* 0x00000001896724B0-0x00000001896724D0 */ get => default; } // 0x0000000182CE2960-0x0000000182CE2A10 
	public bool fullHP { /* [XID] */ /* 0x0000000189679D20-0x0000000189679D40 */ get => default; } // 0x0000000182CE4A50-0x0000000182CE4B00 
	public bool haveShield { /* [XID] */ /* 0x0000000189690A00-0x0000000189690A20 */ get => default; } // 0x0000000182CE6450-0x0000000182CE6500 
	public float shieldRatio { /* [XID] */ /* 0x0000000189698260-0x0000000189698280 */ get => default; } // 0x0000000182CE7CB0-0x0000000182CE7D60 
	private bool fullShield { /* [XID] */ /* 0x000000018969F4E0-0x000000018969F500 */ get => default; } // 0x0000000182CE6560-0x0000000182CE6610 
	public bool haveElementShield { /* [XID] */ /* 0x00000001896A6880-0x00000001896A68A0 */ get => default; } // 0x0000000182CE49A0-0x0000000182CE4A50 
	public float elementShieldRatio { /* [XID] */ /* 0x00000001896ADF70-0x00000001896ADF90 */ get => default; } // 0x0000000182CE8410-0x0000000182CE84C0 
	public bool fullElementShield { /* [XID] */ /* 0x00000001896B5600-0x00000001896B5620 */ get => default; } // 0x0000000182CE6DA0-0x0000000182CE6E50 
	public ElementType elementShieldElementType { /* [XID] */ /* 0x00000001896BC840-0x00000001896BC880 */ get; /* [XID] */ /* 0x00000001896C6F30-0x00000001896C6F70 */ private set; } // 0x0000000182CE69F0-0x0000000182CE6A50 0x0000000182CE82E0-0x0000000182CE8350
	public bool Registered { /* [XID] */ /* 0x000000018975EB70-0x000000018975EB90 */ set {} } // 0x0000000182CE39C0-0x0000000182CE3A70

	// Nested types
	private struct Config // TypeDefIndex: 12160
	{
		// Fields
		public CombatBillboardSize size; // 0x00
		public bool showHPBar; // 0x04
		public bool showName; // 0x05
		public bool showElementShieldBar; // 0x06
		public ElementType elementType; // 0x08
		public float forceShowDistance; // 0x0C

		// Constructors
		public Config(ConfigCombatBillboard config) {
			size = default;
			showHPBar = default;
			showName = default;
			showElementShieldBar = default;
			elementType = default;
			forceShowDistance = default;
		} // 0x0000000182CF3D60-0x0000000182CF3DD0
	}

	// Constructors
	public VCCombatBillboardPlugin() {} // 0x0000000182CE8FC0-0x0000000182CE90F0

	// Methods
	// [XID] // 0x0000000189BB2D50-0x0000000189BB2D70
	private void CheckShowElementShield() {} // 0x0000000182CE72E0-0x0000000182CE73C0
	// [XID] // 0x0000000189BBA100-0x0000000189BBA120
	public override void Init() {} // 0x0000000182CE5F20-0x0000000182CE63A0
	// [XID] // 0x0000000189BC2240-0x0000000189BC2260
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000182CE8BC0-0x0000000182CE8D20
	// [XID] // 0x0000000189BC9790-0x0000000189BC97B0
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000182CE3160-0x0000000182CE3230
	// [XID] // 0x0000000189BD0F70-0x0000000189BD0F90
	private void InitCombatBillBoardCallBack() {} // 0x0000000182CE2B70-0x0000000182CE2EF0
	// [IDTag] // 0x0000000189BD8560-0x0000000189BD85A0
	// [XID] // 0x0000000189BD8560-0x0000000189BD85A0
	private void InitCombatUI() {} // 0x0000000182CE4730-0x0000000182CE48D0
	// [XID] // 0x00000001895E82B0-0x00000001895E82D0
	private void OnEntityReadyPost(EvtEntityReadyPost evt) {} // 0x0000000182CE6C90-0x0000000182CE6DA0
	// [XID] // 0x00000001895EFB80-0x00000001895EFBA0
	private void ClearCombatUI() {} // 0x0000000182CE7000-0x0000000182CE7110
	// [IDTag] // 0x00000001895F7570-0x00000001895F75B0
	// [XID] // 0x00000001895F7570-0x00000001895F75B0
	public void InitCombatUI(BaseEntity entity) {} // 0x0000000182CE3A70-0x0000000182CE4730
	// [XID] // 0x0000000189601BD0-0x0000000189601BF0
	private void InitShowArrowBoard() {} // 0x0000000182CE2820-0x0000000182CE28F0
	// [XID] // 0x0000000189609400-0x0000000189609420
	public override void Tick(float deltaTime) {} // 0x0000000182CE8D20-0x0000000182CE8FC0
	// [XID] // 0x0000000189610B80-0x0000000189610BA0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000182CE4DB0-0x0000000182CE4E80
	// [XID] // 0x0000000189617E50-0x0000000189617E70
	public override bool OnEvent(BaseEvent e) => default; // 0x0000000182CE84C0-0x0000000182CE8680
	// [XID] // 0x000000018961FB30-0x000000018961FB50
	public override bool OnRemoteEvtBeingHit(BaseEvent e) => default; // 0x0000000182CE8680-0x0000000182CE8840
	// [XID] // 0x000000018962E780-0x000000018962E7A0
	private void UpdateShowByDistance(Vector3 cameraPosition) {} // 0x0000000182CE3010-0x0000000182CE3160
	// [XID] // 0x000000018965B890-0x000000018965B8B0
	public void ChangeLevel(int level) {} // 0x0000000182CE3230-0x0000000182CE33A0
	// [XID] // 0x0000000189662C70-0x0000000189662C90
	public void RefreshLang() {} // 0x0000000182CE7710-0x0000000182CE7840
	// [XID] // 0x00000001896813E0-0x0000000189681400
	public void InitHP(float HP, float maxHP) {} // 0x0000000182CE7840-0x0000000182CE79B0
	// [XID] // 0x0000000189688EE0-0x0000000189688F00
	public void ChangeHP(float HP, float maxHP) {} // 0x0000000182CE8A80-0x0000000182CE8BC0
	// [XID] // 0x00000001896D1320-0x00000001896D1340
	private void RefreshShield() {} // 0x0000000182CE73C0-0x0000000182CE7620
	// [XID] // 0x00000001896D8A00-0x00000001896D8A20
	public Color GetColorByType(ElementType type, bool transition) => default; // 0x0000000182CE51E0-0x0000000182CE5560
	// [XID] // 0x00000001896E0250-0x00000001896E0270
	public void ShowElementShiled(ElementType elementType, float shield, float maxShield) {} // 0x0000000182CE5DE0-0x0000000182CE5F20
	// [XID] // 0x00000001896E75A0-0x00000001896E75C0
	public void ChangeElementShield(float shield, float maxShield) {} // 0x0000000182CE5C40-0x0000000182CE5DE0
	// [XID] // 0x00000001896EEBA0-0x00000001896EEBC0
	public void RemoveElementShield() {} // 0x0000000182CE33A0-0x0000000182CE34A0
	// [XID] // 0x00000001896F6560-0x00000001896F6580
	public void CheckLevelSuppress(BaseEntity entity = null) {} // 0x0000000182CE5560-0x0000000182CE5850
	// [XID] // 0x00000001896FDC90-0x00000001896FDCB0
	public void CheckShowLevel() {} // 0x0000000182CE5850-0x0000000182CE5C40
	// [XID] // 0x00000001897050F0-0x0000000189705110
	public void CheckAttackTarget() {} // 0x0000000182CE4B80-0x0000000182CE4D00
	// [XID] // 0x000000018970C7A0-0x000000018970C7C0
	private bool CheckShowArrow() => default; // 0x0000000182CE7B80-0x0000000182CE7CB0
	// [XID] // 0x0000000189714070-0x0000000189714090
	public override void LateUpdateView(Vector3 cameraPosition, Vector3 billboardPosition) {} // 0x0000000182CE4E80-0x0000000182CE51E0
	// [XID] // 0x000000018971B9F0-0x000000018971BA10
	public void OnEnterElementView() {} // 0x0000000182CE79B0-0x0000000182CE7B80
	// [XID] // 0x0000000189B2D1D0-0x0000000189B2D1F0
	private string getMonsterDescribeName(uint id) => default; // 0x0000000182CE48D0-0x0000000182CE49A0
	// [XID] // 0x000000018972A3A0-0x000000018972A3C0
	public string GetAffixIcon() => default; // 0x0000000182CE7110-0x0000000182CE72E0
	// [XID] // 0x0000000189731C40-0x0000000189731C60
	public void OnExitElementView() {} // 0x0000000182CE81A0-0x0000000182CE82E0
	// [XID] // 0x00000001897391C0-0x00000001897391E0
	private void InitLevelEntityData() {} // 0x0000000182CE6610-0x0000000182CE69F0
	// [XID] // 0x0000000189740F80-0x0000000189740FA0
	private void CheckUICombatBar() {} // 0x0000000182CE7EA0-0x0000000182CE81A0
	// [XID] // 0x00000001897487B0-0x00000001897487D0
	public bool NeedUnregister() => default; // 0x0000000182CE6A50-0x0000000182CE6C90
	// [XID] // 0x000000018974FD50-0x000000018974FD70
	private void OnAIChangeThreatLevel(ThreatLevel fromLevel, ThreatLevel toLevel) {} // 0x0000000182CE38E0-0x0000000182CE39C0
	// [XID] // 0x0000000189757420-0x0000000189757440
	public override void Destroy() {} // 0x0000000182CE34A0-0x0000000182CE36A0
	// [XID] // 0x0000000189766050-0x0000000189766070
	public void RegisterUICombatBar(bool force = false /* Metadata: 0x00AEB589 */) {} // 0x0000000182CE36A0-0x0000000182CE38E0
	// [XID] // 0x000000018976D8A0-0x000000018976D8C0
	public void UnregisterUICombatBar(bool force = false /* Metadata: 0x00AEB58A */) {} // 0x0000000182CE8840-0x0000000182CE89B0
}

