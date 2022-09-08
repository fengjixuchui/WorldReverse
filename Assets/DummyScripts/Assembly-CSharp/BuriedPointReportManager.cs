/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BuriedPointReportManager : GlobalManager // TypeDefIndex: 20677
{
	// Fields
	private static bool _hasReportedBuriedPointInfo; // 0x00

	// Constructors
	public BuriedPointReportManager() {} // 0x000000018424E610-0x000000018424E670
	static BuriedPointReportManager() {} // 0x000000018424E5B0-0x000000018424E610

	// Methods
	// [XID] // 0x0000000189A22A60-0x0000000189A22A80
	public void SDKReportBuriedPointInfo() {} // 0x000000018424CB30-0x000000018424CEC0
	// [XID] // 0x0000000189B84C90-0x0000000189B84CB0
	public void SDKReportFunnelPassActionInfo(BuriedPointState state, string serverName = "" /* Metadata: 0x00AFE014 */, long hasDownloadSize = 0 /* Metadata: 0x00AFE018 */) {} // 0x000000018424BC10-0x000000018424BE90
	// [XID] // 0x0000000189B8BA40-0x0000000189B8BA60
	public void SDKReportDownloadInfo(BuriedPointState state, float deltaTime, long totalSize, long deltaSize, long hasDownloadSize) {} // 0x000000018424A6F0-0x000000018424A950
	// [IDTag] // 0x0000000189B93230-0x0000000189B93270
	// [XID] // 0x0000000189B93230-0x0000000189B93270
	public void SDKReportShopMallActionInfo(int firstId, uint secondId, uint thirdId = 0 /* Metadata: 0x00AFE020 */) {} // 0x000000018424D1E0-0x000000018424D490
	// [IDTag] // 0x0000000189B9D500-0x0000000189B9D540
	// [XID] // 0x0000000189B9D500-0x0000000189B9D540
	public void SDKReportShopMallActionInfo(ShopType shopType, uint secondId, uint thirdId = 0 /* Metadata: 0x00AFE024 */) {} // 0x000000018424D490-0x000000018424D5D0
	// [XID] // 0x0000000189BA7C30-0x0000000189BA7C50
	public void SDKReportBattlePassActionInfo(uint firstId, uint secondId) {} // 0x000000018424AF00-0x000000018424B150
	// [XID] // 0x0000000189BAF060-0x0000000189BAF080
	public void SDKReportBulletinActionInfo(uint firstId, uint type = 0 /* Metadata: 0x00AFE028 */) {} // 0x000000018424C6C0-0x000000018424C910
	// [XID] // 0x0000000189BB6730-0x0000000189BB6750
	public void SDKReportUniwebviewGameGotoActionInfo(string param) {} // 0x000000018424E320-0x000000018424E510
	// [XID] // 0x0000000189BBDDC0-0x0000000189BBDDE0
	public void SDKReportReunionActionInfo(uint buttonId, uint additionalInfo) {} // 0x000000018424C2E0-0x000000018424C6C0
	// [IDTag] // 0x0000000189BC5A80-0x0000000189BC5AC0
	// [XID] // 0x0000000189BC5A80-0x0000000189BC5AC0
	public void SDKReportActivityActionInfo(uint activityId, uint scheduleId, uint buttonId, uint additionInfo) {} // 0x000000018424B3C0-0x000000018424B4F0
	// [IDTag] // 0x0000000189BD0330-0x0000000189BD0370
	// [XID] // 0x0000000189BD0330-0x0000000189BD0370
	public void SDKReportActivityActionInfo(uint activityId, uint scheduleId, uint buttonId, string additionInfo) {} // 0x000000018424B4F0-0x000000018424B7F0
	// [IDTag] // 0x0000000189BDAB50-0x0000000189BDAB90
	// [XID] // 0x0000000189BDAB50-0x0000000189BDAB90
	public void SDKReportActivityActionInfo(NormalActivityInfo activityInfo, uint buttonId) {} // 0x000000018424B7F0-0x000000018424BA10
	// [IDTag] // 0x00000001895EA8E0-0x00000001895EA920
	// [XID] // 0x00000001895EA8E0-0x00000001895EA920
	public void SDKReportActivityActionInfo(NewActivityType activityType, uint buttonId, string additionalInfo) {} // 0x000000018424B260-0x000000018424B3C0
	// [IDTag] // 0x00000001895F4E40-0x00000001895F4E80
	// [XID] // 0x00000001895F4E40-0x00000001895F4E80
	public void SDKReportActivityActionInfo(NewActivityType activityType, uint buttonId, uint additionalInfo) {} // 0x000000018424B150-0x000000018424B260
	// [XID] // 0x00000001895FF4B0-0x00000001895FF4D0
	public void SDKReportWidgetCreateBonfire(float x, float y, float z) {} // 0x000000018424D5D0-0x000000018424D860
	// [XID] // 0x0000000189606CE0-0x0000000189606D00
	public void SDKReportWidgetQuickUse(uint materialId) {} // 0x000000018424DCE0-0x000000018424DEE0
	// [XID] // 0x000000018960E600-0x000000018960E620
	public void SDKReportTextLanguageChanged(int before, int after) {} // 0x000000018424DA90-0x000000018424DCE0
	// [XID] // 0x0000000189615C80-0x0000000189615CA0
	public void SDKReportVoiceLanguageChanged(int before, int after) {} // 0x000000018424CF90-0x000000018424D1E0
	// [XID] // 0x000000018961D4D0-0x000000018961D4F0
	public void SDKReportPreDownloadDialogConfirm(bool isConfirm, string downloadSize) {} // 0x000000018424A480-0x000000018424A6F0
	// [XID] // 0x00000001896249D0-0x00000001896249F0
	public void SDKReportPreDownloadEnter(int enterId) {} // 0x000000018424C910-0x000000018424CB30
	// [XID] // 0x000000018962C170-0x000000018962C190
	public void SDKReportPreDownloadPause(bool isConfirm, string leftSize, string totalSize) {} // 0x0000000184249F60-0x000000018424A200
	// [XID] // 0x0000000189633CD0-0x0000000189633CF0
	public void SDKReportPreDownloadFinish() {} // 0x000000018424E140-0x000000018424E320
	// [XID] // 0x000000018963B4D0-0x000000018963B4F0
	public void SDKReportMTRReport(MTRData report) {} // 0x000000018424A2D0-0x000000018424A480
	// [XID] // 0x0000000189642CE0-0x0000000189642D00
	private void GetActivityIdAndScheduleId(NewActivityType activityType, out uint activityId, out uint scheduleId) {
		activityId = default;
		scheduleId = default;
	} // 0x000000018424BFF0-0x000000018424C2E0
	// [XID] // 0x000000018964A330-0x000000018964A350
	private string GetActivityAdditionInfo(NewActivityType type) => default; // 0x000000018424A200-0x000000018424A2D0
	// [XID] // 0x0000000189651A40-0x0000000189651A60
	private int ShopTypeToFirstPageId(ShopType shopType) => default; // 0x000000018424D860-0x000000018424D9D0
	// [XID] // 0x0000000189775070-0x0000000189775090
	private AccountDataItem GetAccountData() => default; // 0x000000018424BE90-0x000000018424BFF0
	// [XID] // 0x00000001896609F0-0x0000000189660A10
	private uint GetUID() => default; // 0x000000018424AE50-0x000000018424AF00
	// [XID] // 0x000000018977C920-0x000000018977C940
	private uint GetPlayerLevel() => default; // 0x000000018424D9D0-0x000000018424DA90
	// [XID] // 0x000000018966FEB0-0x000000018966FED0
	private ulong GetSerialNumber() => default; // 0x000000018424BA10-0x000000018424BC10
	// [XID] // 0x00000001896776E0-0x0000000189677700
	private string GetBuriedPointFunnelPassCBody(BuriedPointState state, string serverName, long hasDownloadSize) => default; // 0x000000018424DEE0-0x000000018424E140
	// [XID] // 0x000000018967EC80-0x000000018967ECA0
	private string GetBuriedPointDownloadResCBody(BuriedPointState state, float deltaTime, long totalSize, long deltaSize, long hasDownloadSize) => default; // 0x000000018424A9F0-0x000000018424ADB0
	// [XID] // 0x0000000189686570-0x0000000189686590
	public override void ClearOnLevelDestroy() {} // 0x000000018424A950-0x000000018424A9F0
	// [XID] // 0x000000018968E3D0-0x000000018968E3F0
	public override void Destroy() {} // 0x000000018424ADB0-0x000000018424AE50
	// [XID] // 0x0000000189695C70-0x0000000189695C90
	public override void Init() {} // 0x000000018424CEC0-0x000000018424CF90
	// [XID] // 0x000000018969D3E0-0x000000018969D400
	public override void ReloadRes() {} // 0x000000018424E510-0x000000018424E5B0
}

