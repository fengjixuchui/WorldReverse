/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoTools;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LocalizationManager : GlobalManager // TypeDefIndex: 21040
{
	// Fields
	private const string LANGUAGE_FONT_CONFIG_ASSET_PATH = "Data/UI/DefaultFontConfig"; // Metadata: 0x00AFED38
	private static FontConfig _fontConfig; // 0x00
	public VoiceLanguageType downloadingVoiceLanguage; // 0x10
	private BundleDownloadJobSystem _downloadSystem; // 0x18
	private Action<bool> _downloadFinishCallback; // 0x20
	private Dictionary<VoiceLanguageType, KeyValuePair<long, long>> _voiceBundleSize; // 0x28
	private Coroutine _coroGetVoiceBundleSizes; // 0x30
	private static IntPtr curWindowHandle; // 0x08
	private CultureInfo _cultureInfo; // 0x40

	// Properties
	public bool isFirstSetTextLanguage { /* [XID] */ /* 0x000000018976FA10-0x000000018976FA50 */ get; /* [XID] */ /* 0x000000018977A1C0-0x000000018977A200 */ private set; } // 0x00000001815C7490-0x00000001815C74F0 0x00000001815C61B0-0x00000001815C6210
	public bool isFirstSetVoiceLanguage { /* [XID] */ /* 0x0000000189784C40-0x0000000189784C80 */ get; /* [XID] */ /* 0x000000018978F000-0x000000018978F040 */ private set; } // 0x00000001815C5BF0-0x00000001815C5C50 0x00000001815C5C50-0x00000001815C5CB0
	private BundleDownloadJobSystem curVoiceDownloadSystem { /* [XID] */ /* 0x00000001897995D0-0x00000001897995F0 */ get => default; } // 0x00000001815C7BA0-0x00000001815C7C40 
	public Dictionary<VoiceLanguageType, KeyValuePair<long, long>> voiceBundleSize { /* [XID] */ /* 0x00000001897A1480-0x00000001897A14A0 */ get => default; } // 0x00000001815C5850-0x00000001815C58F0 
	public CultureInfo cultureInfo { /* [XID] */ /* 0x00000001897F0380-0x00000001897F03A0 */ get => default; } // 0x00000001815C74F0-0x00000001815C7590 

	// Nested types
	private delegate bool WNDENUMPROC(IntPtr hwnd, uint lParam); // TypeDefIndex: 21041; 0x00000001815D1710-0x00000001815D18D0

	// Constructors
	public LocalizationManager() {} // 0x00000001815C8C30-0x00000001815C8CE0
	static LocalizationManager() {} // 0x00000001815C8BC0-0x00000001815C8C30

	// Methods
	private static extern bool SetWindowTextW(IntPtr hwnd, string title); // 0x00000001815C7A90-0x00000001815C7BA0
	private static extern bool EnumWindows(WNDENUMPROC lpEnumFunc, uint lParam); // 0x00000001815C5670-0x00000001815C5780
	private static extern IntPtr GetParent(IntPtr hWnd); // 0x00000001815C80C0-0x00000001815C81B0
	private static extern uint GetWindowThreadProcessId(IntPtr hWnd, ref uint lpdwProcessId); // 0x00000001815C6BE0-0x00000001815C6CE0
	[MonoPInvokeCallback] // 0x00000001897A8C00-0x00000001897A8C40
	// [XID] // 0x00000001897A8C00-0x00000001897A8C40
	private static bool EnumWindowsCallback(IntPtr hwnd, uint lParam) => default; // 0x00000001815C5E80-0x00000001815C5FF0
	// [XID] // 0x00000001897B3960-0x00000001897B3980
	public override void Init() {} // 0x00000001815C6DC0-0x00000001815C7070
	// [XID] // 0x00000001897BB770-0x00000001897BB790
	public override void Destroy() {} // 0x00000001815C5D90-0x00000001815C5E80
	// [XID] // 0x00000001897C2FD0-0x00000001897C2FF0
	public override void ClearOnLevelDestroy() {} // 0x00000001815C5B50-0x00000001815C5BF0
	// [XID] // 0x00000001897CA870-0x00000001897CA890
	public override void Tick() {} // 0x00000001815C8B10-0x00000001815C8BC0
	// [XID] // 0x00000001897D1E30-0x00000001897D1E50
	public override void ReloadRes() {} // 0x00000001815C89D0-0x00000001815C8B10
	// [XID] // 0x00000001897D9C90-0x00000001897D9CB0
	public void SetGameDefaultLanguage() {} // 0x00000001815C81B0-0x00000001815C8520
	// [XID] // 0x00000001897E0FC0-0x00000001897E0FE0
	public void InitGameVoiceLanguage() {} // 0x00000001815C6480-0x00000001815C66D0
	// [XID] // 0x00000001897E86F0-0x00000001897E8710
	public void ChangeLanguage(LanguageType lanType) {} // 0x00000001815C67F0-0x00000001815C6BE0
	// [XID] // 0x00000001897F7AF0-0x00000001897F7B10
	private void UpdateThreadCultureInfo(LanguageType lanType) {} // 0x00000001815C5CB0-0x00000001815C5D90
	// [XID] // 0x00000001897FF170-0x00000001897FF190
	private static void LoadFontConfig() {} // 0x00000001815C5FF0-0x00000001815C6150
	// [XID] // 0x00000001898068B0-0x00000001898068D0
	public static void UnloadFontConfig() {} // 0x00000001815C6320-0x00000001815C6480
	// [XID] // 0x000000018980E090-0x000000018980E0B0
	public static string GetLanguageFontName(TextFontType textType, LanguageType lanType) => default; // 0x00000001815C8860-0x00000001815C89D0
	// [XID] // 0x0000000189815770-0x0000000189815790
	public static string GetLocalizationAssetPathById(uint id, LanguageType lanType) => default; // 0x00000001815C6210-0x00000001815C6320
	// [XID] // 0x000000018981D160-0x000000018981D180
	public static string GetLocalizationAssetPathByDefaultPath(string path, LanguageType lanType) => default; // 0x00000001815C7170-0x00000001815C7280
	// [XID] // 0x00000001898245C0-0x00000001898245E0
	private static string GetLocalizationAssetPathByConfig(LocalizationExcelConfig config, LanguageType lanType) => default; // 0x00000001815C7C40-0x00000001815C7E40
	public static T LoadObjectByPathLocalized<T>(string path, out uint handler)
		where T : UnityEngine.Object {
		handler = default;
		return default;
	}
	public static T LoadObjectByIdLocalized<T>(uint localizationId, out uint handler)
		where T : UnityEngine.Object {
		handler = default;
		return default;
	}
	// [XID] // 0x000000018982C090-0x000000018982C0B0
	public static void DismissObjectLocalized(uint handler) {} // 0x00000001815C5780-0x00000001815C5850
	// [XID] // 0x0000000189833560-0x0000000189833580
	public bool AsyncGetVoiceBundleSize(VoiceLanguageType langType, Action<long, long> onGetSize, Action<bool> onFinish) => default; // 0x00000001815C7640-0x00000001815C78B0
	// [XID] // 0x000000018983AA40-0x000000018983AA60
	public void AysncGetVoiceBundleSizes(Action<VoiceLanguageType> onGetSize) {} // 0x00000001815C7F60-0x00000001815C80C0
	[DebuggerHidden] // 0x0000000189842080-0x00000001898420C0
	// [XID] // 0x0000000189842080-0x00000001898420C0
	private IEnumerator CoroGetAllVoiceBundleSize(Action<VoiceLanguageType> onGetSize) => default; // 0x00000001815C7E40-0x00000001815C7F60
	// [XID] // 0x000000018984C6C0-0x000000018984C6E0
	public bool StartVoiceBundleDownload(VoiceLanguageType langType, Action<bool> onFinishOrQuit) => default; // 0x00000001815C58F0-0x00000001815C5B50
	// [XID] // 0x0000000189853740-0x0000000189853760
	public bool CancelVoiceBundleDownload() => default; // 0x00000001815C54C0-0x00000001815C5580
	// [XID] // 0x000000018985B1F0-0x000000018985B210
	public void CancelAysncGetVoiceBundleSizes() {} // 0x00000001815C5580-0x00000001815C5670
	// [XID] // 0x0000000189862730-0x0000000189862750
	private void OnVoiceBundleDownloadFinish() {} // 0x00000001815C6CE0-0x00000001815C6DC0
	// [XID] // 0x0000000189869B00-0x0000000189869B20
	private void OnVoiceBundleDownloadCancelOrQuit() {} // 0x00000001815C66D0-0x00000001815C6790
	// [XID] // 0x0000000189870E80-0x0000000189870EA0
	public void ChangeVoiceLanguage(VoiceLanguageType langType) {} // 0x00000001815C78B0-0x00000001815C7A90
	// [XID] // 0x0000000189878830-0x0000000189878850
	public static bool IsChinaArea() => default; // 0x00000001815C7070-0x00000001815C7170
	// [XID] // 0x000000018987FDE0-0x000000018987FE00
	public static string GetUrlWithLangTag(string url) => default; // 0x00000001815C8520-0x00000001815C8800
	// [XID] // 0x00000001898873E0-0x0000000189887400
	private void ChangeWindowTitle(string title) {} // 0x00000001815C7280-0x00000001815C7490
	// [XID] // 0x000000018988E560-0x000000018988E580
	public void ResetWindowTitle() {} // 0x00000001815C7590-0x00000001815C7640
}

