/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using SimpleJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class AssetBundleSettings // TypeDefIndex: 19888
{
	// Fields
	public const string SETTINGS_FILE = "asb_settings.json"; // Metadata: 0x00AFD010
	public const string DEFAULT_VARIANCE = "dev"; // Metadata: 0x00AFD025
	public const string VARIANCE_KEY = "variance"; // Metadata: 0x00AFD02C
	public const string RELEASE_KEY = "release"; // Metadata: 0x00AFD038
	public const string DOWNLOAD_KEY = "enable_download"; // Metadata: 0x00AFD043

	// Properties
	public static string variance { /* [XID] */ /* 0x0000000189958EF0-0x0000000189958F30 */ get; /* [XID] */ /* 0x00000001899638E0-0x0000000189963920 */ private set; } // 0x0000000183FE2E10-0x0000000183FE2E70 0x0000000183FE3010-0x0000000183FE3070
	public static bool release { /* [XID] */ /* 0x000000018996DB50-0x000000018996DB90 */ get; /* [XID] */ /* 0x0000000189978C50-0x0000000189978C90 */ private set; } // 0x0000000183FE2ED0-0x0000000183FE2F40 0x0000000183FE2E70-0x0000000183FE2ED0
	public static bool enableDownload { /* [XID] */ /* 0x0000000189983230-0x0000000189983270 */ get; /* [XID] */ /* 0x000000018998D960-0x000000018998D9A0 */ private set; } // 0x0000000183FE2F40-0x0000000183FE2FB0 0x0000000183FE2FB0-0x0000000183FE3010

	// Methods
	// [XID] // 0x0000000189998430-0x0000000189998450
	public static void Load() {} // 0x0000000183FE29A0-0x0000000183FE2B90
	// [XID] // 0x000000018999FC30-0x000000018999FC50
	private static void Reset() {} // 0x0000000183FE2B90-0x0000000183FE2CC0
	// [XID] // 0x00000001899A78C0-0x00000001899A78E0
	private static string LoadSettingsFromFile() => default; // 0x0000000183FE3070-0x0000000183FE3230
	// [XID] // 0x00000001899AF170-0x00000001899AF190
	private static bool TryGetBooleanValue(JSONClass obj, string key, bool defaultValue) => default; // 0x0000000183FE2CC0-0x0000000183FE2E10
	// [XID] // 0x00000001899B64D0-0x00000001899B64F0
	private static string TryGetStringValue(JSONClass obj, string key, string defaultValue) => default; // 0x0000000183FE2850-0x0000000183FE29A0
}

