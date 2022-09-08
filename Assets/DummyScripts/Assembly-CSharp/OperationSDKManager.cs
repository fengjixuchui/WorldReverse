/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MiHoYoSDKJSON;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class OperationSDKManager : GlobalManager, INotifyInterface // TypeDefIndex: 21265
{
	// Fields
	private ConfigChannel _channelConfig; // 0x10
	private JSONNode _payData; // 0x18
	private bool _needInit; // 0x20
	private bool _isCard; // 0x21
	private IOperationSDK _curOprSDK; // 0x28
	public bool _enableFirebase; // 0x30
	public bool DebugFlag; // 0x31
	public static readonly string[] all_tiers; // 0x00
	public static readonly float[] tier_CNY; // 0x08
	public static readonly float[] tier_USD; // 0x10

	// Constructors
	public OperationSDKManager() {} // 0x00000001830FE030-0x00000001830FE0B0
	static OperationSDKManager() {} // 0x00000001830FDC30-0x00000001830FE030

	// Methods
	// [XID] // 0x0000000189A999C0-0x0000000189A999E0
	public override void Init() {} // 0x00000001830FB090-0x00000001830FB130
	// [XID] // 0x0000000189AA0A00-0x0000000189AA0A20
	private bool IsSandbox() => default; // 0x00000001830F90C0-0x00000001830F9190
	// [XID] // 0x00000001896A6B70-0x00000001896A6B90
	private bool IsStarted() => default; // 0x00000001830FA0E0-0x00000001830FA190
	// [XID] // 0x0000000189AAFC70-0x0000000189AAFC90
	private void LoadSDKPrefab() {} // 0x00000001830FA190-0x00000001830FA4F0
	// [XID] // 0x0000000189AB73B0-0x0000000189AB73D0
	private void SetSDKInterface(IOperationSDK sdkEntrance) {} // 0x00000001830F9B20-0x00000001830F9C20
	// [XID] // 0x0000000189ABEE10-0x0000000189ABEE30
	private void InitSDK() {} // 0x00000001830F98E0-0x00000001830F9B20
	// [XID] // 0x0000000189AC6930-0x0000000189AC6950
	public override void Destroy() {} // 0x00000001830F9E00-0x00000001830F9EA0
	// [XID] // 0x0000000189ACE110-0x0000000189ACE130
	public override void ReloadRes() {} // 0x00000001830FDB90-0x00000001830FDC30
	// [XID] // 0x0000000189AD5E40-0x0000000189AD5E60
	public override void ClearOnLevelDestroy() {} // 0x00000001830F94D0-0x00000001830F9570
	// [XID] // 0x0000000189ADD7B0-0x0000000189ADD7D0
	private void RegisterNotify() {} // 0x00000001830FAA50-0x00000001830FAC50
	// [XID] // 0x0000000189AE4FA0-0x0000000189AE4FC0
	public bool OnNotify(Notify ntf) => default; // 0x00000001830FD2E0-0x00000001830FD6E0
	// [XID] // 0x0000000189AEC5E0-0x0000000189AEC600
	private void OnOpenStateChangeNotify(OpenStateType type, bool active) {} // 0x00000001830F9C20-0x00000001830F9D20
	// [XID] // 0x0000000189AF40B0-0x0000000189AF40D0
	private void OnAreaUnlock(uint sceneId, uint areaId, bool isInit) {} // 0x00000001830F8D70-0x00000001830F8EB0
	// [XID] // 0x0000000189AFB860-0x0000000189AFB880
	private void OnGetItem(uint itemId, NewItemType itemType) {} // 0x00000001830FBA00-0x00000001830FBAE0
	// [XID] // 0x0000000189681720-0x0000000189681740
	public bool IsOversea() => default; // 0x00000001830FA860-0x00000001830FAA50
	// [XID] // 0x0000000189B0A6A0-0x0000000189B0A6C0
	public void SDKCreateAvatarInfo(AccountDataItem accountData) {} // 0x00000001830F9340-0x00000001830F94D0
	// [XID] // 0x0000000189B11DC0-0x0000000189B11DE0
	public void OnSDKLoginCB() {} // 0x00000001830F8EB0-0x00000001830F90C0
	// [XID] // 0x0000000189B19010-0x0000000189B19030
	private void SetLog(bool bPrint) {} // 0x00000001830FDAC0-0x00000001830FDB90
	// [XID] // 0x0000000189B20710-0x0000000189B20730
	public void OnReqPay(JSONNode payData, bool isCard) {} // 0x00000001830FD870-0x00000001830FD940
	// [XID] // 0x0000000189B27E10-0x0000000189B27E30
	public void OnPayFinish() {} // 0x00000001830FC1B0-0x00000001830FC2B0
	// [XID] // 0x0000000189B2F130-0x0000000189B2F150
	private void OnEventOWLogin() {} // 0x00000001830FAC50-0x00000001830FAD40
	// [XID] // 0x0000000189B36A10-0x0000000189B36A30
	private void OnUnlockTeleport(uint sceneID, uint pointID) {} // 0x00000001830FA5F0-0x00000001830FA770
	// [XID] // 0x0000000189B3E210-0x0000000189B3E230
	public void OnEventStatue() {} // 0x00000001830FBAE0-0x00000001830FBC00
	// [XID] // 0x0000000189B45F20-0x0000000189B45F40
	private void OnEventGetAmbor() {} // 0x00000001830F97F0-0x00000001830F98E0
	// [XID] // 0x0000000189B4D390-0x0000000189B4D3B0
	private void OnEventUnLockWish() {} // 0x00000001830FA770-0x00000001830FA860
	// [XID] // 0x0000000189B54C50-0x0000000189B54C70
	private void OnEventLogin() {} // 0x00000001830FBC00-0x00000001830FBEF0
	// [XID] // 0x0000000189B5C630-0x0000000189B5C650
	private void OnEventRecharge() {} // 0x00000001830FCC70-0x00000001830FCF90
	// [XID] // 0x0000000189B63CF0-0x0000000189B63D10
	public static bool Convert2Price(string productTier, bool isOversea, out float amount) {
		amount = default;
		return default;
	} // 0x00000001830FC4B0-0x00000001830FC7E0
	// [XID] // 0x0000000189B6B480-0x0000000189B6B4A0
	public static bool EqualTier(string a, string b) => default; // 0x00000001830FD6E0-0x00000001830FD870
	// [XID] // 0x0000000189B72A90-0x0000000189B72AB0
	private void OnEventMonthCard() {} // 0x00000001830FAF70-0x00000001830FB090
	// [XID] // 0x0000000189B7A010-0x0000000189B7A030
	public void ReportOpenShopPage() {} // 0x00000001830FC2B0-0x00000001830FC3A0
	// [XID] // 0x0000000189B81770-0x0000000189B81790
	public void ReportOpenSubShopPage(int firstPageId, uint secondPageId) {} // 0x00000001830FA4F0-0x00000001830FA5F0
	// [XID] // 0x0000000189B88E10-0x0000000189B88E30
	private void OnPlayerLevelUp(uint currLevel) {} // 0x00000001830FC7E0-0x00000001830FCC70
	// [XID] // 0x0000000189B90320-0x0000000189B90340
	private void OnUnlockHandbook() {} // 0x00000001830FCF90-0x00000001830FD080
	// [XID] // 0x0000000189B977D0-0x0000000189B977F0
	private void OnFinishHandbook(int chapter) {} // 0x00000001830FD940-0x00000001830FDAC0
	// [XID] // 0x00000001896B5920-0x00000001896B5940
	public void OnClientVersionUpdate() {} // 0x00000001830F9190-0x00000001830F9270
	// [XID] // 0x0000000189BA6540-0x0000000189BA6560
	public void OnDoGacha(uint count) {} // 0x00000001830F9270-0x00000001830F9340
	// [XID] // 0x00000001898DD050-0x00000001898DD070
	private void PrintLog(string msg) {} // 0x00000001830F9D20-0x00000001830F9E00
	// [XID] // 0x0000000189BB4FE0-0x0000000189BB5000
	public TrackingIOInfo GetReportTrackingIOInfo() => default; // 0x00000001830F9EA0-0x00000001830FA0E0
	// [XID] // 0x0000000189BBC620-0x0000000189BBC640
	public string GetMacAddress() => default; // 0x00000001830FAD40-0x00000001830FAF70
	// [XID] // 0x0000000189BC4280-0x0000000189BC42A0
	public string GetTimeZone() => default; // 0x00000001830FD080-0x00000001830FD2E0
	// [XID] // 0x0000000189BCBC20-0x0000000189BCBC40
	private void ReportFirebaseWithUID(string eventName, string uid) {} // 0x00000001830F9570-0x00000001830F97F0
	// [XID] // 0x0000000189BD3170-0x0000000189BD3190
	private void ReportFirebasePurchase(string eventName, string uid, float amount, string currency) {} // 0x00000001830FB5C0-0x00000001830FBA00
	// [XID] // 0x0000000189BDA9D0-0x0000000189BDA9F0
	private void ReportFireBaseRevenueCount(float amount) {} // 0x00000001830FBEF0-0x00000001830FC1B0
	// [XID] // 0x00000001895E73F0-0x00000001895E7410
	private void ReportFirebaseGacha(uint count) {} // 0x00000001830FB130-0x00000001830FB3A0
	// [XID] // 0x00000001895EED00-0x00000001895EED20
	private void ReportFirebaseEvent(string eventName) {} // 0x00000001830FB3A0-0x00000001830FB5C0
	// [XID] // 0x00000001895F66C0-0x00000001895F66E0
	private void SetFirebaseUID(string uid) {} // 0x00000001830FC3A0-0x00000001830FC4B0
}

