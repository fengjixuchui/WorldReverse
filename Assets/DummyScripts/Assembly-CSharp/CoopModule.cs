/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CoopModule : BaseModule // TypeDefIndex: 21443
{
	// Constructors
	public CoopModule() {} // 0x000000018364D040-0x000000018364D0C0

	// Methods
	// [XID] // 0x00000001897CEE10-0x00000001897CEE30
	public override void ClearOnLevelDestroy() {} // 0x000000018364AB60-0x000000018364AC00
	// [XID] // 0x00000001897D65E0-0x00000001897D6600
	public override void ClearOnDisconnect() {} // 0x000000018364CB90-0x000000018364CC30
	// [XID] // 0x00000001897DDDF0-0x00000001897DDE10
	public override bool OnPacket(Packet packet) => default; // 0x000000018364A7A0-0x000000018364AB60
	// [XID] // 0x00000001897E5880-0x00000001897E58A0
	private void OnAllCoopInfoNotify(AllCoopInfoNotify ntf) {} // 0x000000018364C710-0x000000018364C7E0
	// [XID] // 0x00000001897ED370-0x00000001897ED390
	private void OnMainCoopUpdateNotify(MainCoopUpdateNotify ntf) {} // 0x000000018364BDD0-0x000000018364BEA0
	// [XID] // 0x00000001897F4AD0-0x00000001897F4AF0
	private void UpdateMainCoopData(RepeatedMessageField<MainCoop> coopList) {} // 0x000000018364BEA0-0x000000018364BFF0
	// [XID] // 0x00000001897FC5C0-0x00000001897FC5E0
	public void RequestSaveMainCoop(MainCoopTask mainCoop, uint savePointId) {} // 0x000000018364B960-0x000000018364BDD0
	// [XID] // 0x0000000189803AD0-0x0000000189803AF0
	private void OnSaveMainCoopRsp(SaveMainCoopRsp rsp) {} // 0x000000018364ADF0-0x000000018364AF50
	// [XID] // 0x000000018980AF90-0x000000018980AFB0
	public void RequestFinishMainCoop(uint mainCoopId, uint savePointId) {} // 0x000000018364CE20-0x000000018364CF40
	// [XID] // 0x0000000189812620-0x0000000189812640
	private void OnFinishMainCoopRsp(FinishMainCoopRsp rsp) {} // 0x000000018364BFF0-0x000000018364C150
	// [XID] // 0x000000018981A260-0x000000018981A280
	private void OnCoopDataNotify(CoopDataNotify ntf) {} // 0x000000018364B210-0x000000018364B540
	// [XID] // 0x00000001898219B0-0x00000001898219D0
	private void OnCoopChapterUpdateNotify(CoopChapterUpdateNotify ntf) {} // 0x000000018364B540-0x000000018364B650
	// [XID] // 0x0000000189828F40-0x0000000189828F60
	private void OnCoopCgUpdateNotify(CoopCgUpdateNotify ntf) {} // 0x000000018364C860-0x000000018364C970
	// [XID] // 0x0000000189830430-0x0000000189830450
	private void OnCoopRewardUpdateNotify(CoopRewardUpdateNotify ntf) {} // 0x000000018364AF50-0x000000018364B060
	// [XID] // 0x0000000189837B30-0x0000000189837B50
	private void OnCoopPointUpdateNotify(CoopPointUpdateNotify ntf) {} // 0x000000018364B650-0x000000018364B760
	// [XID] // 0x000000018983F290-0x000000018983F2B0
	private void OnCoopProgressUpdateNotify(CoopProgressUpdateNotify ntf) {} // 0x000000018364C970-0x000000018364CA90
	// [XID] // 0x0000000189846890-0x00000001898468B0
	private void OnCoopCgShowNotify(CoopCgShowNotify ntf) {} // 0x000000018364C490-0x000000018364C710
	// [XID] // 0x000000018984DE40-0x000000018984DE60
	public void RequestCancelCoopTask(uint chapterID) {} // 0x000000018364C150-0x000000018364C250
	// [XID] // 0x0000000189854ED0-0x0000000189854EF0
	public void RequestUnlockCoopChapter(uint chapterID) {} // 0x000000018364CA90-0x000000018364CB90
	// [XID] // 0x000000018985C6B0-0x000000018985C6D0
	public void RequestStartCoopPoint(uint pointId) {} // 0x000000018364B760-0x000000018364B860
	// [XID] // 0x0000000189864030-0x0000000189864050
	public void RequestTakeCoopReward(uint configId) {} // 0x000000018364B860-0x000000018364B960
	// [XID] // 0x000000018986B420-0x000000018986B440
	public void RequestSetCoopChapterViewed(uint chapterID) {} // 0x000000018364CF40-0x000000018364D040
	// [XID] // 0x0000000189872750-0x0000000189872770
	private void OnCancelCoopTaskRsp(CancelCoopTaskRsp rsp) {} // 0x000000018364C250-0x000000018364C490
	// [XID] // 0x000000018987A370-0x000000018987A390
	private void OnUnlockCoopChapterRsp(UnlockCoopChapterRsp rsp) {} // 0x000000018364A300-0x000000018364A4B0
	// [XID] // 0x0000000189881500-0x0000000189881520
	private void OnStartCoopPointRsp(StartCoopPointRsp rsp) {} // 0x000000018364CC30-0x000000018364CE20
	// [XID] // 0x0000000189888A60-0x0000000189888A80
	private void OnTakeCoopRewardRsp(TakeCoopRewardRsp rsp) {} // 0x000000018364B060-0x000000018364B210
	// [XID] // 0x000000018988FE40-0x000000018988FE60
	private void OnSetCoopChapterViewedRsp(SetCoopChapterViewedRsp rsp) {} // 0x000000018364A530-0x000000018364A7A0
	// [XID] // 0x0000000189897380-0x00000001898973A0
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x000000018364AC00-0x000000018364ADF0
}

