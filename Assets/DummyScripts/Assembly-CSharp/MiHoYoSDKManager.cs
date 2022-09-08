/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MiHoYoSDKJSON;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MiHoYoSDKManager : GlobalManager // TypeDefIndex: 21172
{
	// Fields
	private static string EVENT; // 0x00
	private static string PARAM; // 0x08
	public string regionName; // 0x10
	public string regionTitle; // 0x18
	public bool isOnPlayerDataNotify; // 0x20
	public bool isOnPlayerLoginRsp; // 0x21
	public bool isInputDeviceChanged; // 0x22
	private bool _isShowNotice; // 0x23
	private bool _isShowPopImage; // 0x24
	public bool _isUniwebviewGameGoto; // 0x25
	public bool _isNoticeRedPoint; // 0x26
	public string paymenCallbackUrl; // 0x28
	private bool _getProductListSuccess; // 0x30
	private string _currency; // 0x38
	private Dictionary<string, int> _productID2RealPrice; // 0x40
	private Dictionary<string, string> _productID2ShowPrice; // 0x48
	private Dictionary<string, string> _productID2ProductDesc; // 0x50
	private JSONObject _productListJson; // 0x58
	private int _getProductListRetryTimes; // 0x60
	private Coroutine _getProductListRetryCoroutine; // 0x68
	private bool _isShowPSStoreIcon; // 0x70
	private SdkInvokeData _sdkInvokeData; // 0x78
	private SdkInvokeTask _sdkInvokeTask; // 0x80
	private string _queryOnlineId; // 0x88
	private static readonly float TOP_TIPS_BAR_SHOW_TIME; // 0x10
	private const string KOREA_NEED_REALNAME_OK_BUTTON = "\uC2E4\uFFFD"; // Metadata: 0x00AFEF26
	private const string KOREA_NEED_GUARDIAN_OK_BUTTON = "\uBCF4\uD638\uC790"; // Metadata: 0x00AFEF36
	private TopTipsBarWidgetContext _topTipsBarContext; // 0x90
	private bool _tryOpenNotificationSetting; // 0x98
	private Action _closeNotificationCallback; // 0xA0
	private bool _resinNotification; // 0xA8
	private bool _exploreNotification; // 0xA9
	private string _tmpImagePath; // 0xB0
	private SharePlatform _sharePlatform; // 0xB8

	// Properties
	public bool isShowNotice { /* [XID] */ /* 0x000000018960CD40-0x000000018960CD60 */ get => default; } // 0x0000000184393F90-0x0000000184394030 
	public bool isShowPopImage { /* [XID] */ /* 0x0000000189614250-0x0000000189614270 */ get => default; } // 0x0000000184399DB0-0x0000000184399E50 
	public bool isNoticeRedPoint { /* [XID] */ /* 0x000000018961BC70-0x000000018961BC90 */ get => default; /* [XID] */ /* 0x00000001896231E0-0x0000000189623200 */ set {} } // 0x000000018439C450-0x000000018439C4F0 0x00000001843945F0-0x0000000184394740
	public bool getProductListSuccess { /* [XID] */ /* 0x000000018972F7B0-0x000000018972F7D0 */ get => default; } // 0x0000000184395AB0-0x0000000184395B50 
	public bool resinNotification { /* [XID] */ /* 0x0000000189933600-0x0000000189933620 */ get => default; /* [XID] */ /* 0x000000018992C180-0x000000018992C1A0 */ set {} } // 0x0000000184395D50-0x0000000184395E00 0x000000018439C1C0-0x000000018439C350
	public bool exploreNotification { /* [XID] */ /* 0x00000001899423C0-0x00000001899423E0 */ get => default; /* [XID] */ /* 0x000000018993B290-0x000000018993B2B0 */ set {} } // 0x0000000184395210-0x00000001843952C0 0x0000000184399930-0x0000000184399AC0

	// Nested types
	private enum GameGotoType // TypeDefIndex: 21173
	{
		None = 0,
		Gacha = 1,
		Mall = 2,
		Activity = 3,
		BattlePass = 4
	}

	public enum SharePlatform // TypeDefIndex: 21174
	{
		None = 0,
		SINA_WEIBO = 1,
		QQ_FRIENDS = 2,
		WECHAT_FRIENDS = 3,
		TWITTER = 4,
		KAKAO_STORY = 5,
		QQ_ZONE = 6,
		WECHAT_TIMELINE = 7,
		FACEBOOK = 8,
		INSTAGRAM = 9,
		WHATSAPP = 10,
		MESSENGER = 11
	}

	// Constructors
	public MiHoYoSDKManager() {} // 0x000000018439DFF0-0x000000018439E180
	static MiHoYoSDKManager() {} // 0x000000018439DF60-0x000000018439DFF0

	// Methods
	// [XID] // 0x000000018962A9E0-0x000000018962AA00
	public override void Init() {} // 0x0000000184396DD0-0x00000001843971D0
	// [XID] // 0x0000000189632160-0x0000000189632180
	public override void Destroy() {} // 0x0000000184392C70-0x0000000184392D10
	// [XID] // 0x0000000189639C10-0x0000000189639C30
	public override void ReloadRes() {} // 0x000000018439DEC0-0x000000018439DF60
	// [XID] // 0x0000000189641140-0x0000000189641160
	public override void ClearOnLevelDestroy() {} // 0x0000000184392850-0x0000000184392900
	// [XID] // 0x0000000189648A40-0x0000000189648A60
	public override void ClearOnDisconnect() {} // 0x0000000184392790-0x0000000184392850
	// [XID] // 0x0000000189650120-0x0000000189650140
	public override void ClearOnBackHome(bool forceClear = true /* Metadata: 0x00AFEF21 */) {} // 0x0000000184392680-0x0000000184392790
	// [XID] // 0x0000000189657A10-0x0000000189657A30
	public void OnApplicationPause(bool isPause) {} // 0x00000001843933D0-0x0000000184393480
	// [XID] // 0x000000018965F100-0x000000018965F120
	public void OnApplicationQuit() {} // 0x0000000184392180-0x0000000184392220
	// [XID] // 0x00000001896668F0-0x0000000189666910
	public void SDKInit(Action<string> initCallback = null) {} // 0x000000018439CFC0-0x000000018439D2E0
	// [XID] // 0x000000018966DFF0-0x000000018966E010
	public void InitPayUrl(string url) {} // 0x0000000184391980-0x0000000184391A30
	// [XID] // 0x0000000189675E60-0x0000000189675E80
	public void InitBGMForIOSExam() {} // 0x00000001843918E0-0x0000000184391980
	// [XID] // 0x000000018967D700-0x000000018967D720
	public void SDKSetPSClientID(string clientID) {} // 0x0000000184391E10-0x0000000184391EC0
	// [XID] // 0x0000000189684D20-0x0000000189684D40
	public void SDKInitPS4Trophy() {} // 0x0000000184398AE0-0x0000000184398B80
	// [XID] // 0x000000018968C820-0x000000018968C840
	public void SDKSetPS4Trophy(string trophyId) {} // 0x0000000184392A30-0x0000000184392AE0
	// [XID] // 0x0000000189694390-0x00000001896943B0
	public void SDKLogin(Action<string> callback = null) {} // 0x000000018439C4F0-0x000000018439C5F0
	// [XID] // 0x000000018969B930-0x000000018969B950
	public void SDKLogout(Action<string> callback = null) {} // 0x0000000184390E90-0x0000000184390F90
	// [XID] // 0x00000001896A3020-0x00000001896A3040
	public void SDKLogoutWithoutConfirm(Action<string> callback) {} // 0x0000000184392D10-0x0000000184392E10
	// [XID] // 0x00000001896AA470-0x00000001896AA490
	public void SDKSwitchRole(Action<string> callback) {} // 0x0000000184394AA0-0x0000000184394BA0
	// [XID] // 0x00000001896B1350-0x00000001896B1370
	public void SDKLoginBind(Action<string> OnBindResponse) {} // 0x0000000184397670-0x0000000184397770
	// [XID] // 0x00000001896B8E10-0x00000001896B8E30
	public void SDKUserBindAccount() {} // 0x0000000184399E50-0x0000000184399F80
	// [XID] // 0x00000001896C0130-0x00000001896C0150
	public void SDKSetLanguage() {} // 0x000000018439D5D0-0x000000018439D6F0
	// [XID] // 0x00000001896C7950-0x00000001896C7970
	public string SDKGetAsteriskName() => default; // 0x00000001843966A0-0x0000000184396790
	// [XID] // 0x00000001896CF1C0-0x00000001896CF1E0
	public string SDKGetDeviceID() => default; // 0x00000001843959C0-0x0000000184395AB0
	// [XID] // 0x000000018985E720-0x000000018985E740
	public string SDKGetChannelID() => default; // 0x0000000184392FE0-0x00000001843930D0
	// [XID] // 0x00000001897E66B0-0x00000001897E66D0
	public string SDKGetSubChannelID() => default; // 0x000000018439C350-0x000000018439C450
	// [XID] // 0x00000001896E51F0-0x00000001896E5210
	public void SDKLaunchAPP(string url) {} // 0x0000000184397EB0-0x0000000184397FB0
	// [XID] // 0x00000001896EC740-0x00000001896EC760
	public void SetGameParameters(string gameBiz) {} // 0x0000000184399AC0-0x0000000184399C80
	// [XID] // 0x00000001896F3EE0-0x00000001896F3F00
	public bool Pay(string productID, string productName, string productTier, bool isCard) => default; // 0x0000000184396790-0x0000000184396DD0
	// [XID] // 0x00000001896FB730-0x00000001896FB750
	public void SDKShowUserAgreement(Action<int> onShowUserAgreementResult) {} // 0x0000000184391510-0x0000000184391680
	// [XID] // 0x0000000189702D90-0x0000000189702DB0
	private void PayFinishedCallBack(string response) {} // 0x0000000184397810-0x0000000184397E10
	// [XID] // 0x000000018970A440-0x000000018970A460
	private void OnUserBindAccountResponse(string response) {} // 0x0000000184394CF0-0x0000000184394E30
	// [XID] // 0x0000000189711F50-0x0000000189711F70
	public void ClosePay() {} // 0x000000018439B0C0-0x000000018439B1B0
	// [XID] // 0x00000001897194F0-0x0000000189719510
	public void CloseUserCenter() {} // 0x0000000184395120-0x0000000184395210
	// [XID] // 0x0000000189720A90-0x0000000189720AB0
	public void ShowEmptyStoreDialog() {} // 0x000000018439B8F0-0x000000018439BA80
	// [XID] // 0x00000001897280D0-0x00000001897280F0
	private void OnCloseEmptyStoreDialog(string responseString) {} // 0x000000018439AFC0-0x000000018439B0C0
	// [XID] // 0x00000001897371E0-0x0000000189737200
	public void PrepareProductList(List<string> productIDList, List<string> priceTierList) {} // 0x000000018439D7D0-0x000000018439DAC0
	// [XID] // 0x000000018973ED40-0x000000018973ED60
	public void GetProductList() {} // 0x0000000184391370-0x0000000184391510
	// [XID] // 0x0000000189745FC0-0x0000000189745FE0
	public void GetProductListRetry() {} // 0x000000018439B1B0-0x000000018439B320
	// [XID] // 0x000000018974DA70-0x000000018974DA90
	private void GetProductListRetryCallback(bool success) {} // 0x00000001843956D0-0x00000001843959C0
	// [XID] // 0x00000001897550C0-0x00000001897550E0
	private void OnGetProductListResponse(string response) {} // 0x0000000184394030-0x00000001843945F0
	// [XID] // 0x000000018975C270-0x000000018975C290
	public int GetRealPriceByProductID(string productID) => default; // 0x000000018439D6F0-0x000000018439D7D0
	// [XID] // 0x0000000189763C40-0x0000000189763C60
	public string GetShowPriceByProductID(string productID) => default; // 0x0000000184399F80-0x000000018439A0A0
	// [XID] // 0x000000018976B3E0-0x000000018976B400
	public string GetProductDescByProductID(string productID) => default; // 0x0000000184397FB0-0x00000001843980D0
	// [XID] // 0x0000000189772A20-0x0000000189772A40
	public bool HasProduct(string productID) => default; // 0x0000000184391680-0x0000000184391820
	// [XID] // 0x000000018977A160-0x000000018977A180
	public bool HasAnyProduct() => default; // 0x0000000184391820-0x00000001843918E0
	// [XID] // 0x0000000189781D60-0x0000000189781D80
	public void ShowPSStoreIconCenter() {} // 0x0000000184393480-0x0000000184393520
	// [XID] // 0x0000000189789180-0x00000001897891A0
	public void ShowPSStoreIconLeft() {} // 0x00000001843973D0-0x0000000184397470
	// [XID] // 0x0000000189790790-0x00000001897907B0
	public void ShowPSStoreIconRight() {} // 0x0000000184395E00-0x0000000184395EA0
	// [XID] // 0x00000001897980A0-0x00000001897980C0
	public void HidePSStoreIcon() {} // 0x0000000184397470-0x0000000184397510
	// [XID] // 0x000000018979FF30-0x000000018979FF50
	public string GetPersistentUUID() => default; // 0x0000000184394BA0-0x0000000184394CF0
	// [XID] // 0x00000001897A7480-0x00000001897A74A0
	public void SDKExit() {} // 0x000000018439B6F0-0x000000018439B820
	// [XID] // 0x00000001897AEF10-0x00000001897AEF30
	private void DoQuit(string response) {} // 0x0000000184391A30-0x0000000184391BB0
	// [XID] // 0x00000001897B6C20-0x00000001897B6C40
	public bool SDKHasScanFunc() => default; // 0x000000018439BA80-0x000000018439BB90
	// [XID] // 0x00000001897BEC70-0x00000001897BEC90
	public void SDKScanCode() {} // 0x0000000184391270-0x0000000184391370
	// [XID] // 0x00000001897C6110-0x00000001897C6130
	public void SDKCreateAvatarInfo(AccountDataItem accountData) {} // 0x00000001843923B0-0x0000000184392590
	// [XID] // 0x00000001897CD9C0-0x00000001897CD9E0
	public void SDKUploadEnterInfo(AccountDataItem accountData, ulong serverCurTime) {} // 0x000000018439B320-0x000000018439B6F0
	// [XID] // 0x00000001897D4EF0-0x00000001897D4F10
	private void OnWillEnterGameCallback(string responseString) {} // 0x000000018439CA90-0x000000018439CFC0
	// [XID] // 0x00000001897DC690-0x00000001897DC6B0
	public void SDKUploadLevelInfo(uint level) {} // 0x000000018439D2E0-0x000000018439D480
	// [XID] // 0x00000001897E40B0-0x00000001897E40D0
	public void SDKShowNotice() {} // 0x0000000184393E60-0x0000000184393F90
	// [XID] // 0x00000001897EBBE0-0x00000001897EBC00
	public void SDKPreShowNotice(bool isPopNotice) {} // 0x00000001843993F0-0x0000000184399500
	// [XID] // 0x00000001897F34B0-0x00000001897F34D0
	public bool SDKShowPopNotice() => default; // 0x0000000184394F40-0x0000000184395090
	// [XID] // 0x00000001897FAEB0-0x00000001897FAED0
	public bool SDKShowPopImage() => default; // 0x0000000184391CA0-0x0000000184391E10
	// [XID] // 0x00000001898023B0-0x00000001898023D0
	private void SDKPreShowPopImage() {} // 0x0000000184399340-0x00000001843993F0
	// [XID] // 0x00000001898097E0-0x0000000189809800
	public void SDKSetServerID(string serverID) {} // 0x00000001843971D0-0x00000001843972D0
	// [XID] // 0x0000000189810F70-0x0000000189810F90
	private void SDKSetJoypad() {} // 0x0000000184396340-0x00000001843966A0
	// [XID] // 0x0000000189818B10-0x0000000189818B30
	public void ShowPrivacyProtocl() {} // 0x0000000184397E10-0x0000000184397EB0
	// [XID] // 0x0000000189820330-0x0000000189820350
	public void ShowUserAgreement() {} // 0x0000000184397770-0x0000000184397810
	// [XID] // 0x00000001898279B0-0x00000001898279D0
	public void OpenUrl(string url) {} // 0x0000000184392AE0-0x0000000184392C70
	// [XID] // 0x000000018982EBD0-0x000000018982EBF0
	public void ClearOnWebViewClose() {} // 0x0000000184392590-0x0000000184392680
	// [XID] // 0x0000000189836570-0x0000000189836590
	public void CheckAndLeaveJoypadMod() {} // 0x0000000184395FE0-0x0000000184396170
	// [XID] // 0x000000018983D960-0x000000018983D980
	public void CheckAndResumeJoypadMod() {} // 0x0000000184393AC0-0x0000000184393C50
	// [XID] // 0x00000001898451F0-0x0000000189845210
	private void OnGetCloudGameInputTextNotification(string str) {} // 0x0000000184394830-0x0000000184394900
	// [XID] // 0x000000018984C660-0x000000018984C680
	private void InitTask() {} // 0x0000000184391BB0-0x0000000184391CA0
	// [XID] // 0x00000001898536E0-0x0000000189853700
	private void TaskClearOnDisconnect() {} // 0x0000000184396260-0x0000000184396340
	// [XID] // 0x000000018985B1D0-0x000000018985B1F0
	public void SDKCloudGameSaveImageThread(byte[] image, string path) {} // 0x000000018439C8D0-0x000000018439CA90
	// [XID] // 0x0000000189862710-0x0000000189862730
	private string SDKCloudGameSaveImageExecute(ArrayList arrayList) => default; // 0x000000018439AD90-0x000000018439AFC0
	// [XID] // 0x0000000189869AE0-0x0000000189869B00
	private void SDKCloudGameSaveImageFlush(string jsonData) {} // 0x0000000184392E10-0x0000000184392FE0
	// [XID] // 0x0000000189870E60-0x0000000189870E80
	private void OnSDKCloudGameSaveImage(string response) {} // 0x0000000184394E30-0x0000000184394F40
	// [XID] // 0x0000000189878810-0x0000000189878830
	public string SDKGetPSAccountID() => default; // 0x0000000184394900-0x0000000184394AA0
	// [XID] // 0x000000018987FDC0-0x000000018987FDE0
	public void SDKGetOnlinePlayerInfoReq(string onlineID) {} // 0x000000018439DB60-0x000000018439DCB0
	// [XID] // 0x00000001898873C0-0x00000001898873E0
	private void OnGetAccountIDByOnlineID(string responseString) {} // 0x000000018439C5F0-0x000000018439C8D0
	// [XID] // 0x000000018988E540-0x000000018988E560
	public void SDKUpdatePSFriendList() {} // 0x00000001843952C0-0x00000001843953F0
	// [XID] // 0x0000000189895B40-0x0000000189895B60
	private void OnGetFriendList(string responseString) {} // 0x00000001843953F0-0x00000001843956D0
	// [XID] // 0x000000018989D200-0x000000018989D220
	public void SDKUpdatePSBlockList() {} // 0x0000000184391EC0-0x0000000184391FF0
	// [XID] // 0x00000001898A4B60-0x00000001898A4B80
	private void OnGetBlockList(string responseString) {} // 0x0000000184390F90-0x0000000184391270
	// [XID] // 0x00000001898AC020-0x00000001898AC040
	public void RegisterFriendUpdate() {} // 0x00000001843932A0-0x00000001843933D0
	// [XID] // 0x00000001898B36E0-0x00000001898B3700
	private void OnFriendListUpdate(string retCodeString) {} // 0x000000018439DCB0-0x000000018439DEC0
	// [XID] // 0x00000001898BB510-0x00000001898BB530
	public void UnregisterFriendUpdate() {} // 0x0000000184394740-0x0000000184394830
	// [XID] // 0x00000001898C2780-0x00000001898C27A0
	public void RegisterBlockUpdate() {} // 0x0000000184392900-0x0000000184392A30
	// [XID] // 0x00000001898CA1E0-0x00000001898CA200
	private void OnBlockListUpdate(string retCodeString) {} // 0x0000000184393C50-0x0000000184393E60
	// [XID] // 0x00000001898D1930-0x00000001898D1950
	public void UnregisterBlockUpdate() {} // 0x000000018439ACA0-0x000000018439AD90
	// [XID] // 0x00000001898D90F0-0x00000001898D9110
	private void OnKoreaNotification(string jsonString) {} // 0x0000000184398670-0x0000000184398A60
	// [XID] // 0x00000001898E0DD0-0x00000001898E0DF0
	public void OnKoreaDestroy() {} // 0x000000018439C100-0x000000018439C1C0
	// [XID] // 0x00000001898E88C0-0x00000001898E88E0
	public void OnHintAntiAddiction(string msg) {} // 0x0000000184399780-0x0000000184399930
	// [XID] // 0x00000001898EFFE0-0x00000001898F0000
	private void SDKAddLocalNotification(long id, string title, string content, int deltaTime, string ext = "" /* Metadata: 0x00AFEF22 */) {} // 0x0000000184398B80-0x0000000184398E30
	// [XID] // 0x00000001898F78B0-0x00000001898F78D0
	private void SDKRemoveLocalNotification(string id) {} // 0x000000018439A4D0-0x000000018439A5D0
	// [XID] // 0x00000001898FEF50-0x00000001898FEF70
	private void SDKClearLocalNotification() {} // 0x0000000184396170-0x0000000184396260
	// [XID] // 0x0000000189906730-0x0000000189906750
	public bool SDKIsNotificationOpen() => default; // 0x0000000184399100-0x0000000184399230
	// [XID] // 0x000000018990E1D0-0x000000018990E1F0
	public void SDKOpenNotificationSetting() {} // 0x000000018439D480-0x000000018439D570
	// [XID] // 0x0000000189915980-0x00000001899159A0
	private void OnApplicationPauseLocalNotification(bool isPause) {} // 0x0000000184392220-0x00000001843923B0
	// [XID] // 0x000000018991D310-0x000000018991D330
	private void ShowOpenNotificationDialog() {} // 0x0000000184391FF0-0x0000000184392180
	// [XID] // 0x0000000189924C80-0x0000000189924CA0
	private void AddLocalNotifications() {} // 0x0000000184399500-0x0000000184399780
	// [XID] // 0x0000000189949CC0-0x0000000189949CE0
	private void InitNotificationStatus() {} // 0x00000001843980D0-0x00000001843981D0
	// [XID] // 0x0000000189951840-0x0000000189951860
	private void OnNotification(string jsonString) {} // 0x00000001843981D0-0x0000000184398670
	// [XID] // 0x0000000189958DF0-0x0000000189958E10
	private void CloseBulletin() {} // 0x00000001843930D0-0x00000001843932A0
	// [XID] // 0x00000001899604C0-0x00000001899604E0
	private void ClosePopImage() {} // 0x0000000184395EA0-0x0000000184395FE0
	// [XID] // 0x0000000189967E80-0x0000000189967EA0
	private void HandleUniwebViewNotification(string param) {} // 0x000000018439A5D0-0x000000018439ACA0
	// [XID] // 0x000000018996F0E0-0x000000018996F100
	private string GetUniwebviewParam(string param) => default; // 0x0000000184399230-0x0000000184399340
	// [XID] // 0x0000000189976C30-0x0000000189976C50
	private void OnGameGoto(GameGotoType gameGotoType, string param) {} // 0x000000018439BB90-0x000000018439C100
	// [XID] // 0x000000018997E0A0-0x000000018997E0C0
	private bool IsOpenActivity(uint activityId) => default; // 0x00000001843972D0-0x00000001843973D0
	// [XID] // 0x0000000189985BB0-0x0000000189985BD0
	private string GetSDKSharePlatform(SharePlatform sharePlatform) => default; // 0x0000000184397510-0x0000000184397670
	// [XID] // 0x000000018998D7E0-0x000000018998D800
	public void SDKShareImage(SharePlatform sharePlatform, string imagePath) {} // 0x0000000184393520-0x0000000184393A50
	// [XID] // 0x0000000189995250-0x0000000189995270
	private void OnShareNotification(string responseString) {} // 0x000000018439A0A0-0x000000018439A4D0
	// [XID] // 0x000000018999CD50-0x000000018999CD70
	private void ClearTmpShareImage() {} // 0x0000000184398E30-0x0000000184398F90
}

