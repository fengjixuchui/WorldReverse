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

public sealed class BonusActivityModule : BaseModule // TypeDefIndex: 21415
{
	// Fields
	private List<BonusActivityInfo> _curBonusInfoList; // 0x10

	// Properties
	public List<BonusActivityInfo> curBonusInfoList { /* [XID] */ /* 0x00000001898A3200-0x00000001898A3220 */ get => default; } // 0x000000018255ECC0-0x000000018255ED60 

	// Constructors
	public BonusActivityModule() {} // 0x000000018255FCA0-0x000000018255FD50

	// Methods
	// [XID] // 0x00000001898AA620-0x00000001898AA640
	public BonusActivityInfo GetBonusInfo(uint bonusId) => default; // 0x000000018255F2A0-0x000000018255F430
	// [XID] // 0x00000001898B20D0-0x00000001898B20F0
	public override bool OnPacket(Packet packet) => default; // 0x000000018255E8D0-0x000000018255EA30
	// [XID] // 0x00000001898B9E00-0x00000001898B9E20
	private void OnGetBonusActivityRewardRsp(GetBonusActivityRewardRsp ntf) {} // 0x000000018255F6F0-0x000000018255FA50
	// [XID] // 0x00000001898C1120-0x00000001898C1140
	private void OnBonusActivityInfoRsp(BonusActivityInfoRsp ntf) {} // 0x000000018255EDE0-0x000000018255F220
	// [XID] // 0x00000001898C8A40-0x00000001898C8A60
	private void OnBonusActivityUpdateNotify(BonusActivityUpdateNotify bonusActivityUpdateNotify) {} // 0x000000018255F430-0x000000018255F6F0
	// [XID] // 0x00000001898D0400-0x00000001898D0420
	public void RequestBonusActivityInfo() {} // 0x000000018255FBC0-0x000000018255FCA0
	// [XID] // 0x00000001898D7A40-0x00000001898D7A60
	public void GetBonusActivityRewardReq(uint bonus_activity_id) {} // 0x000000018255EBC0-0x000000018255ECC0
	// [XID] // 0x00000001898DF6D0-0x00000001898DF6F0
	public override void ClearOnDisconnect() {} // 0x000000018255FB20-0x000000018255FBC0
	// [XID] // 0x00000001898E7170-0x00000001898E7190
	public override void ClearOnLevelDestroy() {} // 0x000000018255EA30-0x000000018255EAD0
	// [XID] // 0x00000001898EE940-0x00000001898EE960
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x000000018255EAD0-0x000000018255EBC0
	// [XID] // 0x00000001898F60C0-0x00000001898F60E0
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x000000018255FA50-0x000000018255FB20
}

