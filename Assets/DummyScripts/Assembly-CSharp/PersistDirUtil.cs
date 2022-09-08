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

public class PersistDirUtil // TypeDefIndex: 11634
{
	// Fields
	public static string persistDirRoot; // 0x00

	// Constructors
	public PersistDirUtil() {} // 0x00000001825CC0B0-0x00000001825CC110
	static PersistDirUtil() {} // 0x00000001825CC000-0x00000001825CC0B0

	// Methods
	// [XID] // 0x0000000189A64230-0x0000000189A64250
	public static string SplitRelativePathInPersistDir(string fullPath) => default; // 0x00000001825C74F0-0x00000001825C7640
	// [XID] // 0x00000001897E2060-0x00000001897E2080
	private static string GetScriptVersionFilePathInPersistDir() => default; // 0x00000001825C7BF0-0x00000001825C7CF0
	// [XID] // 0x0000000189A73360-0x0000000189A73380
	private static string GetChannelNameFilePathInPersistDir() => default; // 0x00000001825C7640-0x00000001825C7740
	// [XID] // 0x00000001897F1480-0x00000001897F14A0
	private static string GetBaseResVersionHashFilePathInPersistDir() => default; // 0x00000001825CB1F0-0x00000001825CB2F0
	// [XID] // 0x0000000189A82420-0x0000000189A82440
	private static string GetTextLangFilePathInPersistDir() => default; // 0x00000001825C7040-0x00000001825C7140
	// [XID] // 0x0000000189A89D60-0x0000000189A89D80
	private static string GetAudioLangFilePathInPersistDir() => default; // 0x00000001825CB7F0-0x00000001825CB8F0
	// [XID] // 0x0000000189A914C0-0x0000000189A914E0
	public static string GetNormalDownloadingFlagFilePathInPersistDir() => default; // 0x00000001825C7E30-0x00000001825C7F00
	// [XID] // 0x0000000189A99030-0x0000000189A99050
	public static string GetMergeNextResFilePathInPersistDir() => default; // 0x00000001825CA970-0x00000001825CAA40
	// [XID] // 0x00000001898002C0-0x00000001898002E0
	private static void WriteScriptVersionToPersistDir() {} // 0x00000001825C7280-0x00000001825C73B0
	// [XID] // 0x0000000189807960-0x0000000189807980
	private static void WriteChannelNameToPersistDir() {} // 0x00000001825C6F10-0x00000001825C7040
	// [XID] // 0x0000000189AAF1B0-0x0000000189AAF1D0
	private static void WriteBaseResVersionHashToPersistDir() {} // 0x00000001825C9E00-0x00000001825C9F20
	// [XID] // 0x00000001898167E0-0x0000000189816800
	public static void WriteNormalDownloadingFlagFileToPersistDir() {} // 0x00000001825CBCC0-0x00000001825CBDB0
	// [XID] // 0x0000000189ABE540-0x0000000189ABE560
	private static void WriteAvailableTextLangsToPersistDir(List<string> langs) {} // 0x00000001825CA630-0x00000001825CA970
	// [XID] // 0x0000000189A21020-0x0000000189A21040
	private static void WriteAvailableAudioLangsToPersistDir(List<string> langs) {} // 0x00000001825C6C70-0x00000001825C6F10
	// [XID] // 0x000000018981E0A0-0x000000018981E0C0
	private static string ReadScriptVersionFromPersistDir() => default; // 0x00000001825C8460-0x00000001825C8550
	// [XID] // 0x0000000189825580-0x00000001898255A0
	private static string ReadChannelNameFromPersistDir() => default; // 0x00000001825CA540-0x00000001825CA630
	// [XID] // 0x0000000189ADCDB0-0x0000000189ADCDD0
	private static string ReadBaseResVersionHashFromPersistDir() => default; // 0x00000001825C86D0-0x00000001825C87C0
	// [XID] // 0x0000000189AE45E0-0x0000000189AE4600
	public static List<string> ReadAvailableTextLangsFromPersistDir() => default; // 0x00000001825C9A60-0x00000001825C9D20
	// [XID] // 0x0000000189947EF0-0x0000000189947F10
	public static List<string> ReadAvailableAudioLangsFromPersistDir() => default; // 0x00000001825CA2F0-0x00000001825CA540
	// [XID] // 0x0000000189AF37A0-0x0000000189AF37C0
	private static bool IsScriptVersionInPersistDirChanged() => default; // 0x00000001825CB660-0x00000001825CB7F0
	// [XID] // 0x0000000189AFB000-0x0000000189AFB020
	private static bool IsChannelNameInPersistDirChanged() => default; // 0x00000001825C9F20-0x00000001825CA0B0
	// [XID] // 0x0000000189B025E0-0x0000000189B02600
	private static bool IsBaseResVersionHashChanged() => default; // 0x00000001825CB8F0-0x00000001825CBA80
	// [XID] // 0x0000000189B09BA0-0x0000000189B09BC0
	private static bool IsAnythingWrong() => default; // 0x00000001825C7F00-0x00000001825C7FA0
	// [XID] // 0x0000000189B11660-0x0000000189B11680
	private static void ClearBundlesInPersistDir() {} // 0x00000001825C95E0-0x00000001825C96C0
	// [XID] // 0x0000000189859410-0x0000000189859430
	private static void ClearAudiosInPersistDir() {} // 0x00000001825CBF20-0x00000001825CC000
	// [XID] // 0x0000000189860490-0x00000001898604B0
	private static void ClearVideosInPersistDir() {} // 0x00000001825C9D20-0x00000001825C9E00
	// [XID] // 0x0000000189867B30-0x0000000189867B50
	private static void ClearDownloadTempFile() {} // 0x00000001825CBDB0-0x00000001825CBF20
	// [XID] // 0x0000000189B2E880-0x0000000189B2E8A0
	public static void ClearDownloadCacheFile() {} // 0x00000001825CAC40-0x00000001825CAE90
	// [XID] // 0x0000000189B35F50-0x0000000189B35F70
	public static void ClearStreamingResAssetsInPersistDir() {} // 0x00000001825CAE90-0x00000001825CB1F0
	// [XID] // 0x00000001898766B0-0x00000001898766D0
	public static void ClearStreamingDataAssetsInPersistDir() {} // 0x00000001825CB420-0x00000001825CB660
	// [XID] // 0x000000018987E3B0-0x000000018987E3D0
	public static void ClearStreamingSilenceAssetsInPersistDir() {} // 0x00000001825C7FA0-0x00000001825C81E0
	// [XID] // 0x0000000189B4CA90-0x0000000189B4CAB0
	public static void ClearResInPersistDir() {} // 0x00000001825C87C0-0x00000001825C89B0
	// [XID] // 0x0000000189B541E0-0x0000000189B54200
	public static void ClearStateFilesInPersistDir() {} // 0x00000001825C7AA0-0x00000001825C7BF0
	// [XID] // 0x0000000189B5BC60-0x0000000189B5BC80
	public static void ClearRevisionFilesInPersistDir() {} // 0x00000001825C7990-0x00000001825C7AA0
	// [XID] // 0x000000018988C9B0-0x000000018988C9D0
	public static void ClearVersionFilesInPersistDir() {} // 0x00000001825C8350-0x00000001825C8460
	// [XID] // 0x000000018989B5D0-0x000000018989B5F0
	private static bool NeedClearResInPersistDir() => default; // 0x00000001825C78F0-0x00000001825C7990
	// [XID] // 0x0000000189B72200-0x0000000189B72220
	public static void CheckClearResInPersistDir_BeforeCreateGlobalManager() {} // 0x00000001825CBA80-0x00000001825CBCC0
	// [XID] // 0x0000000189B795F0-0x0000000189B79610
	public static void CheckClearResInPersistDir_AfterCreateGlobalManager() {} // 0x00000001825CAA40-0x00000001825CAC40
	// [XID] // 0x0000000189B80990-0x0000000189B809B0
	public static void CheckCopyCTableFileFromStreamingToPersistDir() {} // 0x00000001825C7CF0-0x00000001825C7E30
	// [XID] // 0x0000000189B885E0-0x0000000189B88600
	public static void CheckMultiLangFiles() {} // 0x00000001825C8550-0x00000001825C86D0
	// [XID] // 0x0000000189B61960-0x0000000189B61980
	public static void ResetAudioLangFile() {} // 0x00000001825CA0B0-0x00000001825CA2F0
	// [XID] // 0x00000001897083D0-0x00000001897083F0
	public static bool AddNewTextLangToFile(string languageCode) => default; // 0x00000001825C73B0-0x00000001825C74F0
	// [XID] // 0x00000001898B9480-0x00000001898B94A0
	public static void RemoveTextLangFromFile(string languageCode) {} // 0x00000001825C94B0-0x00000001825C95E0
	// [XID] // 0x0000000189A19A20-0x0000000189A19A40
	public static bool AddNewAudioLangToFile(string audioLanguage) => default; // 0x00000001825C7140-0x00000001825C7280
	// [XID] // 0x0000000189BACE20-0x0000000189BACE40
	public static void RemoveAudioLangFromFile(string audioLanguage) {} // 0x00000001825CB2F0-0x00000001825CB420
	// [XID] // 0x0000000189BB4730-0x0000000189BB4750
	public static bool IsAlreadlyDownloadExternal() => default; // 0x00000001825C6B80-0x00000001825C6C70
	// [XID] // 0x0000000189BBBCF0-0x0000000189BBBD10
	public static bool IsMediumPackageTrialState() => default; // 0x00000001825C81E0-0x00000001825C8350
	// [XID] // 0x00000001898A9FC0-0x00000001898A9FE0
	private static void MergeNextRes() {} // 0x00000001825C8E80-0x00000001825C94B0
	// [XID] // 0x0000000189BCB360-0x0000000189BCB380
	public static long GetTotalAudioFileSizeOfSpecificLang(string lang) => default; // 0x00000001825C7740-0x00000001825C78F0
	// [XID] // 0x0000000189BD2910-0x0000000189BD2930
	public static void DeleteAudioFilesOfSpecficLang(string lang) {} // 0x00000001825C89B0-0x00000001825C8E80
	// [XID] // 0x0000000189BD9E70-0x0000000189BD9E90
	public static void DeleteAllMultiLangAudioFilesExceptSpecficLangs(string[] langs) {} // 0x00000001825C96C0-0x00000001825C9A60
}

