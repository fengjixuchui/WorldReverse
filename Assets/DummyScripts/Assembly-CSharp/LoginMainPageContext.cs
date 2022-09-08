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
using MoleMole;
using SimpleJSON;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LoginMainPageContext : BasePageContext // TypeDefIndex: 30006
{
	// Fields
	private const LoginState defaultState = LoginState.Agreement; // Metadata: 0x00B106E4
	public LoginState loginState; // 0x190
	public PanelState panelState; // 0x194
	private PanelSubState subPanelState; // 0x198
	private string scenePrefabPath; // 0x1A0
	private uint scenePrefabHandler; // 0x1A8
	private string enviroProfilePath; // 0x1B0
	private string enviroWeatherPath; // 0x1B8
	public GameObject _homeLoadScene; // 0x1C0
	public MonoLoginMainPage _pageMono; // 0x1C8
	public MonoLoginScene _monoLoginScene; // 0x1D0
	private string accountName; // 0x1D8
	private string realAccountName; // 0x1E0
	private RegionInfo _addressRegion; // 0x1E8
	private int _waitPressState; // 0x1F0
	public GeneralLocalDataItem _curGeneralLocalData; // 0x1F8
	private ServerConfigAddress _currentSelectServerConfig; // 0x200
	public bool needLoginSDK; // 0x208
	private float _lastReportTime; // 0x20C
	private long _lastDownloadSize; // 0x210
	private const float REPORT_DOWNLOAD_INTERVAL = 60f; // Metadata: 0x00B106E8
	private bool _startReportDownloadInfo; // 0x218
	private int _prevConfirmFrame; // 0x21C
	private float _confirmStartTime; // 0x220
	private const float _checkDialogInterval = 0.2f; // Metadata: 0x00B106EC
	private bool _haveShowChat; // 0x224
	private bool _haveShowUGC; // 0x225
	private bool _haveInitDialog; // 0x226
	private bool _checkTRCDialogs; // 0x227
	private float _curCheckDialogTime; // 0x228

	// Nested types
	public enum PanelState // TypeDefIndex: 30007
	{
		None = 0,
		Login = 1,
		DebugServer = 2,
		SwitchServer = 3,
		SelectGlobalDPServer = 4,
		SelectServer = 5,
		ConfirmServer = 6,
		WaitEnter = 7
	}

	private enum PanelSubState // TypeDefIndex: 30008
	{
		None = 0,
		SelectAccount = 1,
		SelectPassword = 2
	}

	private enum WaitPressState // TypeDefIndex: 30009
	{
		None = 0,
		AfterDownLoad = 1,
		AfterShowDoor = 2,
		Complete = 3
	}

	public enum LoginState // TypeDefIndex: 30010
	{
		Agreement = 0,
		PreInit = 1,
		WaitInit = 2,
		GlobalDP = 3,
		Prelogin = 4,
		Login = 5,
		WaitToken = 6,
		ShowServerList = 7,
		ChooseServer = 8,
		DownloadBunddle = 9,
		WaitingPress = 10,
		OpenDoor = 11,
		Finish = 12
	}

	// Constructors
	public LoginMainPageContext() {} // 0x000000018181C2B0-0x000000018181C4D0

	// Methods
	// [XID] // 0x00000001898957A0-0x00000001898957C0
	public override bool OnNotify(Notify ntf) => default; // 0x000000018181B370-0x000000018181B5C0
	// [XID] // 0x000000018989CF00-0x000000018989CF20
	private void SetUIStateForExam() {} // 0x0000000181813440-0x00000001818134E0
	// [XID] // 0x00000001898A46C0-0x00000001898A46E0
	public override void SetupView() {} // 0x000000018181BFD0-0x000000018181C1F0
	// [XID] // 0x00000001898ABB80-0x00000001898ABBA0
	public void InitDebugLoginDialog() {} // 0x0000000181814270-0x0000000181814380
	// [XID] // 0x00000001898B3330-0x00000001898B3350
	private void InitBeforeGP() {} // 0x00000001818114A0-0x00000001818115B0
	// [XID] // 0x00000001898BB030-0x00000001898BB050
	public override void UpdateView() {} // 0x000000018181C1F0-0x000000018181C2B0
	// [XID] // 0x00000001898C23A0-0x00000001898C23C0
	public override void ClearView() {} // 0x00000001818118F0-0x00000001818119A0
	// [XID] // 0x00000001898C9DC0-0x00000001898C9DE0
	protected override void BindViewCallbacks() {} // 0x0000000181810170-0x0000000181810690
	// [XID] // 0x00000001898D13C0-0x00000001898D13E0
	private void InitLoginPanel() {} // 0x0000000181814E90-0x0000000181815340
	// [XID] // 0x00000001898D8C80-0x00000001898D8CA0
	private void SetProgressTargetValue(float progress, long downloadSize = 0 /* Metadata: 0x00B106CA */, long totalSize = 0 /* Metadata: 0x00B106D2 */, long downloadSpeed = 0 /* Metadata: 0x00B106DA */) {} // 0x0000000181814870-0x0000000181814B80
	// [XID] // 0x00000001898E0950-0x00000001898E0970
	private void SetDescText(string info) {} // 0x000000018181A210-0x000000018181A320
	// [XID] // 0x00000001898E84B0-0x00000001898E84D0
	private void ShowNotificationBar(bool show) {} // 0x0000000181816490-0x0000000181816540
	// [XID] // 0x00000001898EFC30-0x00000001898EFC50
	private void CheckState() {} // 0x0000000181819AA0-0x0000000181819C00
	// [XID] // 0x00000001898F7470-0x00000001898F7490
	private bool IsOversea() => default; // 0x00000001818144E0-0x00000001818145C0
	// [XID] // 0x00000001898FEBE0-0x00000001898FEC00
	private void OnAgreement() {} // 0x0000000181812C30-0x0000000181812F60
	// [XID] // 0x0000000189906360-0x0000000189906380
	private void OnShowUserAgreementResult(string responseString) {} // 0x000000018181A8A0-0x000000018181ABB0
	// [XID] // 0x000000018990DDE0-0x000000018990DE00
	private void OnPreInit() {} // 0x000000018181A320-0x000000018181A6B0
	// [XID] // 0x0000000189915570-0x0000000189915590
	private void OnGetLocalData(string responseString) {} // 0x0000000181817D30-0x0000000181817E30
	// [XID] // 0x000000018991CFC0-0x000000018991CFE0
	private void OnLogin() {} // 0x0000000181811B10-0x0000000181811C50
	// [XID] // 0x0000000189924850-0x0000000189924870
	private void ShowSDK() {} // 0x000000018181AD80-0x000000018181AEF0
	// [XID] // 0x000000018992BE00-0x000000018992BE20
	private void ShowNotice() {} // 0x0000000181812A50-0x0000000181812C30
	// [XID] // 0x0000000189933330-0x0000000189933350
	private void OnUserAgrPS4BtnClick() {} // 0x0000000181812090-0x0000000181812170
	// [XID] // 0x000000018993AEC0-0x000000018993AEE0
	private void OnPrivacyPS4BtnClick() {} // 0x0000000181814010-0x00000001818140F0
	// [XID] // 0x0000000189941F30-0x0000000189941F50
	private void OnDetailsPS4BtnClick() {} // 0x0000000181810C40-0x0000000181810D50
	// [XID] // 0x0000000189949A10-0x0000000189949A30
	private void OnInitResponse(string responseString) {} // 0x000000018181AFC0-0x000000018181B2E0
	// [XID] // 0x0000000189951420-0x0000000189951440
	private void OnSDKLoginCB(string responseString) {} // 0x000000018180ECB0-0x000000018180F8D0
	// [XID] // 0x0000000189958A70-0x0000000189958A90
	private void TryCheckPS4Net(bool set) {} // 0x000000018181A030-0x000000018181A210
	// [XID] // 0x00000001899600B0-0x00000001899600D0
	private void ShowPS4NetDisableDialog() {} // 0x0000000181812F60-0x00000001818130B0
	// [XID] // 0x0000000189967B50-0x0000000189967B70
	private void TryCheckPS5Net(bool set) {} // 0x000000018181B8D0-0x000000018181BCF0
	// [XID] // 0x000000018996ED10-0x000000018996ED30
	private void ShowPS5NetDisableDialog() {} // 0x0000000181816A10-0x0000000181816B60
	// [XID] // 0x0000000189976910-0x0000000189976930
	private void InitServerDispatch() {} // 0x00000001818145C0-0x0000000181814870
	// [XID] // 0x000000018997DD30-0x000000018997DD50
	private void ShowSelectDispatchPanel(List<ConfigDispatchUrl> configs) {} // 0x0000000181815EB0-0x0000000181816150
	// [XID] // 0x00000001899856E0-0x0000000189985700
	private void OnGlobalDP() {} // 0x000000018180FF60-0x0000000181810170
	// [XID] // 0x000000018998D4B0-0x000000018998D4D0
	private void ShowServerPanel() {} // 0x00000001818109A0-0x0000000181810A60
	// [XID] // 0x0000000189994F30-0x0000000189994F50
	public void CheckShowServerList() {} // 0x0000000181816260-0x0000000181816490
	// [XID] // 0x000000018999C810-0x000000018999C830
	private List<ServerConfigAddress> GetAllList() => default; // 0x0000000181810F50-0x0000000181811030
	// [XID] // 0x00000001899A42A0-0x00000001899A42C0
	private ServerConfigAddress GetDefaultServer() => default; // 0x0000000181818A20-0x0000000181819550
	// [XID] // 0x00000001899ABC60-0x00000001899ABC80
	private void OnSwitchServer() {} // 0x0000000181813160-0x0000000181813250
	// [XID] // 0x00000001899B35B0-0x00000001899B35D0
	private void OnEnterServer() {} // 0x000000018181B7E0-0x000000018181B8D0
	// [XID] // 0x00000001899BA970-0x00000001899BA990
	private void ShowServerList(ServerConfigAddress config) {} // 0x0000000181816B60-0x0000000181816D40
	// [XID] // 0x00000001899C2290-0x00000001899C22B0
	private void OnSelectServerBack() {} // 0x0000000181813E00-0x0000000181813EE0
	// [XID] // 0x00000001899C99C0-0x00000001899C99E0
	private void OnSelectServerConfirm() {} // 0x0000000181813250-0x0000000181813380
	// [XID] // 0x00000001899D11D0-0x00000001899D11F0
	private void InitTouchScroll() {} // 0x0000000181815650-0x0000000181815850
	// [XID] // 0x00000001899D86C0-0x00000001899D86E0
	private void ShowServerSelectDialog(ServerConfigAddress selectAdr) {} // 0x000000018180F970-0x000000018180FA60
	// [XID] // 0x00000001899DFD70-0x00000001899DFD90
	private void OnConfirmSelectServer() {} // 0x00000001818137E0-0x0000000181813890
	// [XID] // 0x00000001899E7780-0x00000001899E77A0
	private void OnConfirmCancel() {} // 0x000000018181AEF0-0x000000018181AFC0
	// [XID] // 0x00000001899EED30-0x00000001899EED50
	private void ConfirmSelectServer() {} // 0x0000000181819D50-0x0000000181819F70
	// [XID] // 0x00000001899F65F0-0x00000001899F6610
	public void OnChooseServer(ServerConfigAddress serverAddress) {} // 0x0000000181816EB0-0x0000000181817200
	// [XID] // 0x00000001899FDB30-0x00000001899FDB50
	private void OnDownloadBunddleFinish(RegionInfo ip) {} // 0x0000000181817800-0x00000001818179D0
	// [XID] // 0x0000000189A05570-0x0000000189A05590
	private void AfterOnBundleLoadFinish() {} // 0x0000000181814430-0x00000001818144E0
	// [XID] // 0x0000000189A0C890-0x0000000189A0C8B0
	private void AftreShowDoor() {} // 0x0000000181816150-0x0000000181816200
	// [XID] // 0x0000000189A14200-0x0000000189A14220
	private void HideProgressPanel() {} // 0x0000000181817200-0x0000000181817460
	// [XID] // 0x0000000189A1B470-0x0000000189A1B490
	private void ShowProgressPanel() {} // 0x0000000181817AE0-0x0000000181817D30
	// [XID] // 0x0000000189A22D70-0x0000000189A22D90
	public void ReportAfterDownload() {} // 0x0000000181819F70-0x000000018181A030
	// [XID] // 0x0000000189A2A040-0x0000000189A2A060
	private bool CheckToWaitingPress() => default; // 0x0000000181818630-0x0000000181818890
	// [XID] // 0x0000000189A31520-0x0000000189A31540
	private void StartGlobalManager() {} // 0x0000000181812680-0x00000001818128F0
	// [XID] // 0x0000000189A38FD0-0x0000000189A38FF0
	public void InitDebugUserId() {} // 0x0000000181812170-0x00000001818125C0
	[DebuggerHidden] // 0x0000000189A40790-0x0000000189A407D0
	// [XID] // 0x0000000189A40790-0x0000000189A407D0
	public IEnumerator OnBundleLoadFinish(Action callback) => default; // 0x000000018181BDD0-0x000000018181BEB0
	// [XID] // 0x0000000189A4AD90-0x0000000189A4ADB0
	private void RefreshDataLoad(float progress) {} // 0x000000018180E9A0-0x000000018180EB40
	// [XID] // 0x0000000189A524B0-0x0000000189A524D0
	private void OnClickContinue() {} // 0x00000001818199B0-0x0000000181819AA0
	// [XID] // 0x0000000189A59E00-0x0000000189A59E20
	private void OnOpenDoor() {} // 0x000000018181B6D0-0x000000018181B7E0
	// [XID] // 0x0000000189A615B0-0x0000000189A615D0
	private void AfterOpenDoor() {} // 0x0000000181810A60-0x0000000181810C40
	[DebuggerHidden] // 0x0000000189A69470-0x0000000189A694B0
	// [XID] // 0x0000000189A69470-0x0000000189A694B0
	private IEnumerator AfterResourceInter() => default; // 0x00000001818140F0-0x00000001818141C0
	// [XID] // 0x0000000189A737E0-0x0000000189A73800
	public void RefreshAccountName(bool isLogin = false /* Metadata: 0x00B106E2 */) {} // 0x0000000181811D30-0x0000000181812090
	// [XID] // 0x0000000189A7B2E0-0x0000000189A7B300
	private void RefreshVersion() {} // 0x0000000181813D20-0x0000000181813E00
	// [XID] // 0x0000000189A82A00-0x0000000189A82A20
	public void EnableSelectServerPanel(bool enable) {} // 0x0000000181818890-0x0000000181818A20
	// [XID] // 0x0000000189A8A3F0-0x0000000189A8A410
	private void OnRepair() {} // 0x0000000181818440-0x0000000181818630
	// [XID] // 0x0000000189A91BB0-0x0000000189A91BD0
	private void OnLogout() {} // 0x0000000181813EE0-0x0000000181814010
	// [XID] // 0x0000000189A996A0-0x0000000189A996C0
	private void RealLogout() {} // 0x0000000181810690-0x00000001818109A0
	// [XID] // 0x0000000189AA0710-0x0000000189AA0730
	private void OnLogoutResponse(string responseString) {} // 0x0000000181815340-0x00000001818155F0
	// [XID] // 0x0000000189AA7D10-0x0000000189AA7D30
	private bool CheckJSONNode(JSONNode res, string msg) => default; // 0x000000018181B5C0-0x000000018181B6D0
	// [XID] // 0x0000000189AAF7E0-0x0000000189AAF800
	private void ReportDownLoadInfo(bool force = false /* Metadata: 0x00B106E3 */) {} // 0x0000000181813A50-0x0000000181813D20
	// [XID] // 0x0000000189AB7060-0x0000000189AB7080
	private void ReportBuriedPointState(BuriedPointState state) {} // 0x0000000181815CB0-0x0000000181815EB0
	// [XID] // 0x0000000189ABEA80-0x0000000189ABEAA0
	private void ReportBuriedLanguageSetting() {} // 0x00000001818134E0-0x00000001818137E0
	[DebuggerHidden] // 0x0000000189AC6650-0x0000000189AC6690
	// [XID] // 0x0000000189AC6650-0x0000000189AC6690
	private IEnumerator AndroidSyncShaderLoading() => default; // 0x0000000181810E90-0x0000000181810F50
	// [XID] // 0x0000000189AD0D20-0x0000000189AD0D40
	public void CreateStage() {} // 0x0000000181811030-0x00000001818114A0
	// [XID] // 0x0000000189AD8920-0x0000000189AD8940
	public void DestroyStage() {} // 0x00000001818115B0-0x0000000181811840
	// [XID] // 0x0000000189AE0580-0x0000000189AE05A0
	public override void SetActive(bool enable) {} // 0x000000018181BEB0-0x000000018181BFD0
	// [XID] // 0x0000000189AE7AD0-0x0000000189AE7AF0
	private void OnQuit() {} // 0x000000018181BCF0-0x000000018181BDD0
	// [XID] // 0x0000000189AEF810-0x0000000189AEF830
	private void OnScanCode() {} // 0x00000001818167A0-0x0000000181816880
	// [XID] // 0x0000000189AF6D50-0x0000000189AF6D70
	private void UpdateLoginPanel(PanelSubState state) {} // 0x0000000181817E30-0x00000001818181F0
	// [XID] // 0x0000000189AFE240-0x0000000189AFE260
	private bool HandleLoginConfirmState() => default; // 0x0000000181814B80-0x0000000181814CD0
	// [XID] // 0x0000000189B05A70-0x0000000189B05A90
	private bool HandleLoginMoveState(ContextEventType contextEventType) => default; // 0x000000018180EB40-0x000000018180EC60
	// [XID] // 0x0000000189B0D1C0-0x0000000189B0D1E0
	private bool HandleConfirm() => default; // 0x000000018180FBB0-0x000000018180FF60
	// [XID] // 0x0000000189B147A0-0x0000000189B147C0
	private bool HandleBack() => default; // 0x0000000181815960-0x0000000181815A30
	// [XID] // 0x0000000189B1BF70-0x0000000189B1BF90
	private bool HandleMenuLeft() => default; // 0x00000001818128F0-0x0000000181812A50
	// [XID] // 0x0000000189B23710-0x0000000189B23730
	private bool HandleMenuUp() => default; // 0x0000000181819C00-0x0000000181819D50
	// [XID] // 0x0000000189B2A970-0x0000000189B2A990
	private bool HandleLeftTrigger() => default; // 0x000000018180FA60-0x000000018180FBB0
	// [XID] // 0x0000000189B31EE0-0x0000000189B31F00
	private bool HandleRightTrigger() => default; // 0x000000018180F8D0-0x000000018180F970
	// [XID] // 0x0000000189B396A0-0x0000000189B396C0
	private bool HandleBacking() => default; // 0x00000001818125C0-0x0000000181812680
	// [XID] // 0x0000000189B40FF0-0x0000000189B41010
	private bool HandleBackingEnd() => default; // 0x0000000181813380-0x0000000181813440
	// [XID] // 0x0000000189B48960-0x0000000189B48980
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181815A30-0x0000000181815CB0
	// [XID] // 0x0000000189B500D0-0x0000000189B500F0
	private void OnConfirmingLogout() {} // 0x00000001818181F0-0x0000000181818440
	// [XID] // 0x0000000189B57900-0x0000000189B57920
	private void OnConfirmLogoutEnd() {} // 0x0000000181815850-0x0000000181815960
	// [XID] // 0x0000000189B5F250-0x0000000189B5F270
	private void OpenInputDialog(GameObject obj) {} // 0x0000000181816540-0x00000001818167A0
	// [XID] // 0x0000000189B66860-0x0000000189B66880
	private void DirectLogin() {} // 0x00000001818179D0-0x0000000181817AE0
	// [XID] // 0x0000000189B6DD80-0x0000000189B6DDA0
	private void SetLoginBtnState(bool show) {} // 0x0000000181816D40-0x0000000181816EB0
	// [XID] // 0x0000000189B75470-0x0000000189B75490
	private void SetLogoutBtnState(bool show) {} // 0x00000001818119A0-0x0000000181811B10
	// [XID] // 0x0000000189B7C8C0-0x0000000189B7C8E0
	private void SetNoticeBtnState(bool show) {} // 0x000000018181A710-0x000000018181A8A0
	// [XID] // 0x0000000189B84720-0x0000000189B84740
	private void SetRepairBtnState(bool show) {} // 0x0000000181810D50-0x0000000181810E90
	// [XID] // 0x0000000189B8B5B0-0x0000000189B8B5D0
	private void InitDownloadPackageStyle() {} // 0x0000000181817460-0x0000000181817800
	// [XID] // 0x0000000189B92CE0-0x0000000189B92D00
	private void SetGlobalDisableIOSDownload() {} // 0x0000000181811C50-0x0000000181811D30
	// [XID] // 0x0000000189B9A2C0-0x0000000189B9A2E0
	private void SetDownloadBtnState(bool show) {} // 0x00000001818168E0-0x0000000181816A10
	// [XID] // 0x0000000189BA1990-0x0000000189BA19B0
	private bool NeedDownloadAllRes() => default; // 0x000000018181ABB0-0x000000018181AD20
	// [XID] // 0x0000000189BA8DB0-0x0000000189BA8DD0
	private bool NeedShowDownloadPreRes() => default; // 0x00000001818130B0-0x0000000181813160
	// [XID] // 0x0000000189BB0540-0x0000000189BB0560
	private bool NeedDownloadPreRes() => default; // 0x0000000181811840-0x00000001818118F0
	// [XID] // 0x0000000189BB7940-0x0000000189BB7960
	private void OnDownloadPackageBtnClick() {} // 0x0000000181819550-0x0000000181819830
	// [XID] // 0x0000000189BBEFA0-0x0000000189BBEFC0
	private void StartCheckTRCDialogs() {} // 0x0000000181814380-0x0000000181814430
	// [XID] // 0x0000000189BC6C30-0x0000000189BC6C50
	private void TryShowPS4TRCDialogs() {} // 0x0000000181814CD0-0x0000000181814E90
	// [XID] // 0x0000000189BCE920-0x0000000189BCE940
	private void TryShowPS5TRCDialogs() {} // 0x0000000181819830-0x00000001818199B0
	// [XID] // 0x0000000189BD5BE0-0x0000000189BD5C00
	private void ReleasePS4TRC() {} // 0x00000001818139A0-0x0000000181813A50
	// [XID] // 0x0000000189BDD890-0x0000000189BDD8B0
	private void ReleasePS5TRC() {} // 0x00000001818141C0-0x0000000181814270
}

