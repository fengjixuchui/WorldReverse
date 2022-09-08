/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BundleDownloadJobSystem : BundleDownloadBaseSystem // TypeDefIndex: 11606
{
	// Fields
	public static Queue<BundleDownloadJobSystem> _jobSystems; // 0x00
	private bool needDownloadRes; // 0x10
	private bool needDownloadData; // 0x11
	private bool needDownloadSilence; // 0x12
	private bool pickCheckMd5; // 0x13
	private List<FilePickInfo> resDownloadList; // 0x18
	private List<FilePickInfo> dataDownloadList; // 0x20
	private List<FilePickInfo> silenceDownloadList; // 0x28
	private DownloadVersionMap remoteResVersion; // 0x30
	private DownloadVersionMap persistResVersion; // 0x38
	private DownloadVersionMap streamingResVersion; // 0x40
	private DownloadVersionMap remoteDataVersion; // 0x48
	private DownloadVersionMap persistDataVersion; // 0x50
	private DownloadVersionMap streamingDataVersion; // 0x58
	private DownloadVersionMap remoteSilenceVersion; // 0x60
	private DownloadVersionMap persistSilenceVersion; // 0x68
	private DownloadVersionMap streamingSilenceVersion; // 0x70
	private FilesDownloadPipe downloadPipe; // 0x78
	private BundleDownloadGlobalSetting.Phase displayPhase; // 0x80
	private BundleDownloadGlobalSetting.Phase phase; // 0x84
	private uint phaseStep; // 0x88
	private float progress; // 0x8C
	private float displayProgress; // 0x90
	private long totalFileSize; // 0x98
	private long downloadedSize; // 0xA0
	private long displayDownloadedSize; // 0xA8
	private long downloadSpeed; // 0xB0
	private bool waitUserDecision; // 0xB8
	private long startDownloadSize; // 0xC0
	private int totalFileNumInRemoteVersion; // 0xC8
	private int verifiedFileNumInRemoteVersion; // 0xCC
	private int verifyRetryCnt; // 0xD0
	private string remoteResVersionFileMd5; // 0xD8
	private string remoteDataVersionFileMd5; // 0xE0
	private string remoteSilenceVersionFileMd5; // 0xE8
	private string defaultDisplayErrMsg; // 0xF0
	private string displayErrMsg_restartGame; // 0xF8
	private Queue<ExceptionInfo> exceptions; // 0x100
	private DownloadResInformer resInformer; // 0x108
	private DownloadDataInformer dataInformer; // 0x110
	private DownloadSilenceDataInformer silenceInformer; // 0x118
	private DownloadBasePicker picker; // 0x120
	public JobType jobType; // 0x128
	public bool onlyWantSize; // 0x12C
	private bool _enable; // 0x12D
	private bool errorQuit; // 0x12E
	private bool _alreadyOutlet; // 0x12F
	public Action<bool, bool, bool> onStartDownloadCallback; // 0x130
	public Action<bool, bool, bool> beforeDownLoadCallback; // 0x138
	public Action<bool, bool, bool> onFinishDownloadCallback; // 0x140
	public Action<byte> onFinishDownloadSilenceDataCallback; // 0x148
	public Action<long, long> onFinishGetSizeCallback; // 0x150
	public Action onCancelDownloadCallback; // 0x158
	public Action onErrorCallback; // 0x160
	public Action onQuitDownloadCallback; // 0x168
	public Action outletCallback; // 0x170
	private GeneralDialogContext carrierNetworkDialog; // 0x178

	// Properties
	private long deltaSize { /* [XID] */ /* 0x000000018972D510-0x000000018972D530 */ get => default; } // 0x0000000183FABBD0-0x0000000183FABC90 
	public bool downloadThroughCarrierNetwork { /* [XID] */ /* 0x0000000189734C30-0x0000000189734C50 */ get => default; /* [XID] */ /* 0x000000018973C800-0x000000018973C820 */ set {} } // 0x0000000183FA4720-0x0000000183FA47D0 0x0000000183FA8FF0-0x0000000183FA90A0
	public bool enableFinishNotification { /* [XID] */ /* 0x0000000189919C70-0x0000000189919C90 */ get => default; /* [XID] */ /* 0x000000018974B850-0x000000018974B870 */ set {} } // 0x0000000183FA2370-0x0000000183FA2420 0x0000000183FA9640-0x0000000183FA96F0
	public bool isVerifyingMd5 { /* [XID] */ /* 0x0000000189752C90-0x0000000189752CB0 */ get => default; } // 0x0000000183FA9940-0x0000000183FA9A00 
	public bool isResUpdate { /* [XID] */ /* 0x0000000189759F80-0x0000000189759FA0 */ get => default; } // 0x0000000183FA4D80-0x0000000183FA4E20 
	public bool isDataUpdate { /* [XID] */ /* 0x0000000189761D20-0x0000000189761D40 */ get => default; } // 0x0000000183FA22D0-0x0000000183FA2370 
	public bool isSilenceDataUpdate { /* [XID] */ /* 0x0000000189769110-0x0000000189769130 */ get => default; } // 0x0000000183FA4BB0-0x0000000183FA4C50 
	public bool pause { /* [XID] */ /* 0x00000001897707F0-0x0000000189770810 */ get => default; /* [XID] */ /* 0x0000000189778030-0x0000000189778050 */ set {} } // 0x0000000183FA87C0-0x0000000183FA8880 0x0000000183FA29F0-0x0000000183FA2AC0

	// Constructors
	public BundleDownloadJobSystem() {} // Dummy constructor
	public BundleDownloadJobSystem(JobType jobType = JobType.Normal /* Metadata: 0x00AEA35A */, Dictionary<string, string> extParam = null) {} // 0x0000000183FABDC0-0x0000000183FABFC0
	static BundleDownloadJobSystem() {} // 0x0000000183FABD30-0x0000000183FABDC0

	// Methods
	// [XID] // 0x0000000189968BB0-0x0000000189968BD0
	private void CreateInformer() {} // 0x0000000183FA6280-0x0000000183FA6460
	// [XID] // 0x0000000189786F20-0x0000000189786F40
	private void CreatePicker(Dictionary<string, string> extParam) {} // 0x0000000183FAB580-0x0000000183FAB9E0
	// [XID] // 0x000000018978E5E0-0x000000018978E600
	private void MoveToNextStep() {} // 0x0000000183FABC90-0x0000000183FABD30
	// [XID] // 0x0000000189795CE0-0x0000000189795D00
	private void MoveToNextPhase() {} // 0x0000000183FA6800-0x0000000183FA68B0
	// [XID] // 0x000000018979DF50-0x000000018979DF70
	private void ForceSetPhase(BundleDownloadGlobalSetting.Phase val) {} // 0x0000000183FAB0A0-0x0000000183FAB160
	// [XID] // 0x00000001897A5430-0x00000001897A5450
	private void NotifyError(string messageTextMapKey, string messageToUpload, ReportErrorCode err) {} // 0x0000000183FA8E10-0x0000000183FA8FF0
	// [XID] // 0x00000001897ACAC0-0x00000001897ACAE0
	private void CheckCanReachNetwork() {} // 0x0000000183FA1D40-0x0000000183FA1E30
	// [XID] // 0x00000001897B48C0-0x00000001897B48E0
	private void CheckWritable() {} // 0x0000000183FA86A0-0x0000000183FA87C0
	// [XID] // 0x00000001897BC790-0x00000001897BC7B0
	private void CheckMobileEnvironment() {} // 0x0000000183FA2930-0x0000000183FA29F0
	// [XID] // 0x00000001897C3C70-0x00000001897C3C90
	private void CheckSpaceEnough() {} // 0x0000000183FA24C0-0x0000000183FA2650
	// [XID] // 0x0000000189A26CA0-0x0000000189A26CC0
	private void Finish() {} // 0x0000000183FAABA0-0x0000000183FAAE40
	// [XID] // 0x00000001897D2CA0-0x00000001897D2CC0
	public override void Cancel() {} // 0x0000000183FA4C50-0x0000000183FA4D80
	// [XID] // 0x00000001897DAA00-0x00000001897DAA20
	private void QuitPassively(bool withError) {} // 0x0000000183FA5960-0x0000000183FA5AB0
	// [XID] // 0x00000001897E1E00-0x00000001897E1E20
	public override void Init() {} // 0x0000000183FA5360-0x0000000183FA5400
	// [XID] // 0x00000001897E9590-0x00000001897E95B0
	public override void Tick() {} // 0x0000000183FA5400-0x0000000183FA5760
	// [XID] // 0x00000001897F1180-0x00000001897F11A0
	private void CheckProgress() {} // 0x0000000183FA89B0-0x0000000183FA8D70
	// [XID] // 0x0000000189B348F0-0x0000000189B34910
	public string GetProgressDescription(BundleDownloadGlobalSetting.Phase phase) => default; // 0x0000000183FA5160-0x0000000183FA52C0
	// [XID] // 0x0000000189B3C1F0-0x0000000189B3C210
	private static void NotifyUI(float process, string desc, long donwloadedSize, long totalSize, long downloadSpeed) {} // 0x0000000183FA2650-0x0000000183FA2840
	// [XID] // 0x00000001898077C0-0x00000001898077E0
	private void ShowErrorTip(string error) {} // 0x0000000183FA6EF0-0x0000000183FA70F0
	// [XID] // 0x000000018980EE80-0x000000018980EEA0
	private void DownloadFSM() {} // 0x0000000183FAAA70-0x0000000183FAABA0
	// [XID] // 0x0000000189816530-0x0000000189816550
	private void CheckIsMyTurn() {} // 0x0000000183FA3180-0x0000000183FA3240
	// [XID] // 0x000000018981DEB0-0x000000018981DED0
	private void DownloadRemoteVersionFile() {} // 0x0000000183FA3820-0x0000000183FA4720
	// [XID] // 0x000000018968C0A0-0x000000018968C0C0
	private void InDownloadingRemoteVersionFile() {} // 0x0000000183FAB160-0x0000000183FAB200
	// [XID] // 0x000000018982CC30-0x000000018982CC50
	private void AssureDownloadedRemoteVersionFilesCorrect() {} // 0x0000000183FA9ED0-0x0000000183FAA0A0
	// [XID] // 0x000000018969B030-0x000000018969B050
	private bool CheckRemoteVersionFileCorrect(string remoteVersionFile, string expectMd5) => default; // 0x0000000183FAAE40-0x0000000183FAB0A0
	// [XID] // 0x00000001896C7310-0x00000001896C7330
	private void StartPickDownloadsTask() {} // 0x0000000183FA90A0-0x0000000183FA9310
	// [XID] // 0x0000000189843130-0x0000000189843150
	private void Step_PickDownload() {} // 0x0000000183FA3240-0x0000000183FA3820
	// [XID] // 0x000000018974D310-0x000000018974D330
	private void InPickingDownloads() {} // 0x0000000183FA52C0-0x0000000183FA5360
	// [XID] // 0x0000000189851950-0x0000000189851970
	private void DidPickDownloads() {} // 0x0000000183FA8450-0x0000000183FA86A0
	// [XID] // 0x00000001898590D0-0x00000001898590F0
	private void CheckUpdate_New() {} // 0x0000000183FABAF0-0x0000000183FABBD0
	// [XID] // 0x00000001898602B0-0x00000001898602D0
	private void Phase_PickDownloads() {} // 0x0000000183FA4AD0-0x0000000183FA4BB0
	// [XID] // 0x0000000189867930-0x0000000189867950
	private void DeleteUnusedRes() {} // 0x0000000183FA4F70-0x0000000183FA5160
	// [XID] // 0x000000018976AD90-0x000000018976ADB0
	private void DownloadEverything() {} // 0x0000000183FA5830-0x0000000183FA5900
	// [XID] // 0x0000000189772380-0x00000001897723A0
	private void StartDownload() {} // 0x0000000183FA68B0-0x0000000183FA6EF0
	// [XID] // 0x000000018987E150-0x000000018987E170
	private void InDownloadingEverything() {} // 0x0000000183FA2C70-0x0000000183FA3110
	// [XID] // 0x0000000189885180-0x00000001898851A0
	private void VerifyAllMd5() {} // 0x0000000183FA9A00-0x0000000183FA9AD0
	// [XID] // 0x000000018988C740-0x000000018988C760
	private void StartMd5VerifyTask() {} // 0x0000000183FA4E20-0x0000000183FA4F70
	// [XID] // 0x0000000189886D20-0x0000000189886D40
	private void InVerifyingMd5() {} // 0x0000000183FA8D70-0x0000000183FA8E10
	// [XID] // 0x000000018989B3B0-0x000000018989B3D0
	private bool VerifyFilesInRemoteVersion(DownloadVersionMap remoteVersion, DownloadVersionMap streamingVersion, List<ExceptionInfo> errorList) => default; // 0x0000000183FAA0A0-0x0000000183FAAA70
	// [XID] // 0x00000001898A2830-0x00000001898A2850
	private void DidDownload() {} // 0x0000000183FA5CA0-0x0000000183FA6280
	// [XID] // 0x00000001898AB600-0x00000001898AB620
	private bool WritePersistRevision() => default; // 0x0000000183FA9C40-0x0000000183FA9ED0
	// [XID] // 0x00000001898B1810-0x00000001898B1830
	private void DeleteAllResFilesNotInPersistVersion() {} // 0x0000000183FA70F0-0x0000000183FA8380
	// [XID] // 0x00000001898B9160-0x00000001898B9180
	private string GetDownloadCachedFilePath() => default; // 0x0000000183FAB200-0x0000000183FAB350
	// [XID] // 0x00000001896F37A0-0x00000001896F37C0
	private string GetBadBundleFilePath() => default; // 0x0000000183FA6730-0x0000000183FA6800
	// [XID] // 0x00000001897AE530-0x00000001897AE550
	private bool IsAnythingUpdated() => default; // 0x0000000183FA8380-0x0000000183FA8450
	// [XID] // 0x00000001896D5CE0-0x00000001896D5D00
	private int GetTotalFileNumInRemoteVersion() => default; // 0x0000000183FA8880-0x0000000183FA89B0
	// [IDTag] // 0x00000001898D6F90-0x00000001898D6FD0
	// [XID] // 0x00000001898D6F90-0x00000001898D6FD0
	private void GenError(ReportErrorCode code, string errMsgToUpload, string errMsgToDisplay = "" /* Metadata: 0x00AEA35E */) {} // 0x0000000183FA96F0-0x0000000183FA97F0
	// [IDTag] // 0x00000001898E1B20-0x00000001898E1B60
	// [XID] // 0x00000001898E1B20-0x00000001898E1B60
	private void GenError(ExceptionInfo errorInfo) {} // 0x0000000183FA97F0-0x0000000183FA9940
	// [XID] // 0x00000001898EC370-0x00000001898EC390
	private ExceptionInfo CreateErrorInfo(ReportErrorCode code, string errMsgToUpload, string errMsgToDisplay = "" /* Metadata: 0x00AEA362 */) => default; // 0x0000000183FA9AD0-0x0000000183FA9C40
	// [XID] // 0x0000000189877E90-0x0000000189877EB0
	private void JumpToPickPhase() {} // 0x0000000183FA2030-0x0000000183FA2140
	// [XID] // 0x000000018991CCB0-0x000000018991CCD0
	public override void Destroy() {} // 0x0000000183FA2B20-0x0000000183FA2C70
	// [XID] // 0x0000000189902EC0-0x0000000189902EE0
	private void EnqueueJobSystem() {} // 0x0000000183FA2140-0x0000000183FA22D0
	// [XID] // 0x0000000189AF80B0-0x0000000189AF80D0
	private bool DequeueJobSystem() => default; // 0x0000000183FA47D0-0x0000000183FA4A60
	// [XID] // 0x0000000189B67E10-0x0000000189B67E30
	private BundleDownloadJobSystem peekCurrentJobSys() => default; // 0x0000000183FA93E0-0x0000000183FA9590
	// [XID] // 0x000000018992BAA0-0x000000018992BAC0
	public static bool IsDownloadingAnything() => default; // 0x0000000183FA5AB0-0x0000000183FA5CA0
	// [XID] // 0x0000000189920F10-0x0000000189920F30
	public long GetDownloadedSize() => default; // 0x0000000183FA9590-0x0000000183FA9640
	// [XID] // 0x000000018993AAD0-0x000000018993AAF0
	public long GetTotalFileSize() => default; // 0x0000000183FAB9E0-0x0000000183FABA90
	// [XID] // 0x000000018992FD90-0x000000018992FDB0
	public float GetProgress() => default; // 0x0000000183FA1E30-0x0000000183FA1EE0
	// [XID] // 0x0000000189949710-0x0000000189949730
	public BundleDownloadGlobalSetting.Phase GetPhase() => default; // 0x0000000183FA2420-0x0000000183FA24C0
}

