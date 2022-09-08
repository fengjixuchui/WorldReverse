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

public static class OpeUtil // TypeDefIndex: 31802
{
	// Fields
	private static string SIGN_TYPE_NAME; // 0x00
	private static string AUTH_KEY_VERSION_NAME; // 0x08
	private static string AUTH_APP_ID_NAME; // 0x10
	private static string AUTH_KEY_NAME; // 0x18
	private static string LANGUAGE_TYPE_NAME; // 0x20
	private static string DEVICE_TYPE_NAME; // 0x28
	private static string GAEME_BIZ; // 0x30
	private static string EXT_INFO; // 0x38
	private static string REGION; // 0x40
	private static string GAME_VERSION; // 0x48
	private static string cpsInfo; // 0x50
	private static bool isCPSLoaded; // 0x58

	// Constructors
	static OpeUtil() {} // 0x0000000183774BE0-0x0000000183774D50

	// Methods
	// [XID] // 0x0000000189ADB720-0x0000000189ADB740
	public static string GetMihoyoAndroidCPS() => default; // 0x0000000183774A90-0x0000000183774BE0
	// [XID] // 0x0000000189AE2F70-0x0000000189AE2F90
	public static bool TryRedirectToChannelUri(string channelApkName, string channelUrlScheme) => default; // 0x00000001837742E0-0x00000001837746B0
	// [XID] // 0x0000000189AEA9B0-0x0000000189AEA9D0
	public static void ConvertGachaWebUrl(string sourceUrl, Action<string> callback) {} // 0x00000001837746B0-0x0000000183774790
	// [XID] // 0x0000000189AF22A0-0x0000000189AF22C0
	public static void ConvertWebUrl(string sourceUrl, Action<string> callback) {} // 0x00000001837733F0-0x00000001837734D0
	// [XID] // 0x0000000189AF9C00-0x0000000189AF9C20
	private static void InnerConvertWebUrl(string sourceUrl, Action<string> callback, bool addRegionParam) {} // 0x0000000183773970-0x00000001837742E0
	// [XID] // 0x0000000189B010D0-0x0000000189B010F0
	public static void ParseUrl(string url, out string baseUrl, out Dictionary<string, string> paramDict) {
		baseUrl = default;
		paramDict = default;
	} // 0x00000001837734D0-0x0000000183773830
	// [XID] // 0x0000000189B086A0-0x0000000189B086C0
	private static string GeneralUrlParamString(Dictionary<string, string> paramDict) => default; // 0x0000000183774790-0x0000000183774A90
	// [XID] // 0x0000000189B0FF80-0x0000000189B0FFA0
	public static string GeneralUrl(string baseUrl, Dictionary<string, string> paramDict) => default; // 0x0000000183773830-0x0000000183773970
}

