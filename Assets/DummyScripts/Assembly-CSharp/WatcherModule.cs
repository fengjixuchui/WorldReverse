/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WatcherModule : BaseModule // TypeDefIndex: 21624
{
	// Fields
	private List<uint> _pushTipsList; // 0x10
	private List<uint> _pushTipsFinishedList; // 0x18
	private Dictionary<uint, bool> _watcherDic; // 0x20
	private Dictionary<string, int> _modifierDic; // 0x28
	private Dictionary<uint, int> _watcherTypeDic; // 0x30
	private Dictionary<uint, List<uint>> _findMonsterConfigId2ObserverId; // 0x38
	private Dictionary<uint, List<uint>> _findAffixId2ObserverId; // 0x40

	// Properties
	public List<uint> pushTipsList { /* [XID] */ /* 0x0000000189BD5F80-0x0000000189BD5FA0 */ get => default; } // 0x0000000182575470-0x0000000182575510 
	public List<uint> pushTipsFinishedList { /* [XID] */ /* 0x0000000189BDDBA0-0x0000000189BDDBC0 */ get => default; } // 0x0000000182575970-0x0000000182575A10 
	public bool dontAllowHideBadPushTip { /* [XID] */ /* 0x00000001896BBC00-0x00000001896BBC40 */ get; set; } // 0x0000000182572110-0x0000000182572170 0x00000001825743A0-0x0000000182574400

	// Constructors
	public WatcherModule() {} // 0x00000001825763A0-0x0000000182576520

	// Methods
	// [XID] // 0x0000000189BCEC40-0x0000000189BCEC60
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x0000000182573130-0x0000000182573260
	// [XID] // 0x00000001895EA700-0x00000001895EA720
	public uint GetLatestPustTipId() => default; // 0x0000000182573FA0-0x00000001825740A0
	// [XID] // 0x00000001895F1C90-0x00000001895F1CB0
	public override void ClearOnLevelDestroy() {} // 0x00000001825725C0-0x0000000182572660
	// [XID] // 0x00000001895F9610-0x00000001895F9630
	public override void ClearOnDisconnect() {} // 0x0000000182575F30-0x0000000182575FD0
	// [XID] // 0x0000000189600CE0-0x0000000189600D00
	public override void ClearOnBackHome() {} // 0x0000000182573CD0-0x0000000182573DB0
	// [XID] // 0x0000000189608650-0x0000000189608670
	public override bool OnPacket(Packet packet) => default; // 0x00000001825723C0-0x00000001825725C0
	// [XID] // 0x000000018960FE70-0x000000018960FE90
	private void OnWatcherAllDataNotify(WatcherAllDataNotify ntf) {} // 0x00000001825741F0-0x00000001825743A0
	// [XID] // 0x00000001896171B0-0x00000001896171D0
	private void OnWatcherChangeNotify(WatcherChangeNotify ntf) {} // 0x00000001825737B0-0x0000000182573A20
	// [XID] // 0x000000018961EDA0-0x000000018961EDC0
	private void OnAddWatcher(WatcherConfig config) {} // 0x0000000182572660-0x0000000182572C30
	// [XID] // 0x0000000189626120-0x0000000189626140
	private void OnRemoveWatcher(WatcherConfig config) {} // 0x0000000182572C30-0x0000000182573130
	// [XID] // 0x000000018962DB50-0x000000018962DB70
	private void ClearWatcherData() {} // 0x0000000182573390-0x00000001825734B0
	// [XID] // 0x0000000189635710-0x0000000189635730
	public WatcherConfig GetWatcherConfig(uint watcherId) => default; // 0x00000001825740A0-0x00000001825741F0
	// [XID] // 0x000000018963CDF0-0x000000018963CE10
	private void TryAddLevelModifier(WatcherConfig watcherConfig) {} // 0x0000000182575180-0x0000000182575360
	// [XID] // 0x0000000189644370-0x0000000189644390
	private void TryRemoveLevelModifier(WatcherConfig watcherConfig) {} // 0x00000001825761C0-0x00000001825763A0
	// [XID] // 0x000000018964BBB0-0x000000018964BBD0
	private void AddLevelModifier(string modifierName, string abilityName) {} // 0x0000000182573DB0-0x0000000182573FA0
	// [XID] // 0x0000000189653240-0x0000000189653260
	private void RemoveLevelModifier(string modifierName, string abilityName) {} // 0x00000001825735D0-0x00000001825737B0
	// [XID] // 0x000000018965AAD0-0x000000018965AAF0
	public void TryAddAllWatcherModifier() {} // 0x0000000182574C30-0x0000000182574DE0
	// [XID] // 0x0000000189661F60-0x0000000189661F80
	private bool GetAbilityModifierName(string totalName, out string modifierName, out string abilityName) {
		modifierName = default;
		abilityName = default;
		return default;
	} // 0x0000000182575A10-0x0000000182575C10
	// [XID] // 0x0000000189669B20-0x0000000189669B40
	public void OnLevelReady() {} // 0x0000000182574E40-0x00000001825750C0
	// [XID] // 0x00000001899B72A0-0x00000001899B72C0
	public void FireWatcherSysNewMonster(uint monsterConfigId) {} // 0x0000000182572170-0x0000000182572340
	// [XID] // 0x0000000189678F90-0x0000000189678FB0
	public void FireWatcherSysNewAffix(uint affixConfigId) {} // 0x0000000182574A60-0x0000000182574C30
	// [XID] // 0x0000000189680690-0x00000001896806B0
	private void TryRegisterNotify(uint triggerType) {} // 0x0000000182575510-0x0000000182575640
	// [XID] // 0x0000000189688220-0x0000000189688240
	private void TryUnregisterNotify(uint triggerType) {} // 0x0000000182573260-0x0000000182573390
	// [XID] // 0x000000018968FB00-0x000000018968FB20
	private void FireWatcherSysElementViewNotify() {} // 0x00000001825750C0-0x0000000182575180
	// [XID] // 0x0000000189697520-0x0000000189697540
	public void FireWatcherSysNotify(WatcherTriggerType triggerType, uint progress = 1 /* Metadata: 0x00AFFA8B */, List<uint> paramList = null) {} // 0x0000000182575360-0x0000000182575470
	// [XID] // 0x00000001899BED60-0x00000001899BED80
	public void SendWatcherEventNotify(uint watcherId, uint progress = 1 /* Metadata: 0x00AFFA8F */) {} // 0x00000001825734B0-0x00000001825735D0
	// [XID] // 0x00000001896A5B20-0x00000001896A5B40
	private void SendWatcherEventTypeNotify(WatcherTriggerType watcherTriggerType, uint progress, List<uint> paramList) {} // 0x0000000182575C10-0x0000000182575DB0
	// [XID] // 0x00000001896AD2D0-0x00000001896AD2F0
	private void OnPushTipsAllDataNotify(PushTipsAllDataNotify ntf) {} // 0x0000000182575FD0-0x00000001825761C0
	// [XID] // 0x00000001896B4A30-0x00000001896B4A50
	private void OnPushTipsChangeNotify(PushTipsChangeNotify ntf) {} // 0x0000000182574690-0x00000001825749E0
	// [XID] // 0x00000001896CD7B0-0x00000001896CD7D0
	public void ShowPushTips(uint showPushTipsId, PushTipsState state) {} // 0x0000000182574400-0x0000000182574690
	// [XID] // 0x00000001896D4BE0-0x00000001896D4C00
	private void HidePushTips(uint showPushTipsId) {} // 0x0000000182575740-0x0000000182575970
	// [XID] // 0x00000001896DC260-0x00000001896DC280
	public void RequestPushTipsReadFinish(uint pushTipsId) {} // 0x0000000182575640-0x0000000182575740
	// [XID] // 0x00000001896E3A30-0x00000001896E3A50
	private void OnPushTipsReadFinishRsp(PushTipsReadFinishRsp rsp) {} // 0x0000000182575DB0-0x0000000182575F30
	// [XID] // 0x00000001896EAE20-0x00000001896EAE40
	public void RequestGetPushTipsReward(List<uint> pushTipsIdList) {} // 0x0000000182573B80-0x0000000182573CD0
	// [XID] // 0x00000001896F21F0-0x00000001896F2210
	private void OnGetPushTipsRewardRsp(GetPushTipsRewardRsp rsp) {} // 0x0000000182573A20-0x0000000182573B80
}

