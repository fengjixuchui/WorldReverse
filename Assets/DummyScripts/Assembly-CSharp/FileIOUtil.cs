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

public class FileIOUtil // TypeDefIndex: 11633
{
	// Fields
	public static string streamingDirRoot; // 0x00

	// Constructors
	public FileIOUtil() {} // 0x000000018162F5A0-0x000000018162F600
	static FileIOUtil() {} // 0x000000018162F530-0x000000018162F5A0

	// Methods
	// [XID] // 0x00000001898E7F80-0x00000001898E7FA0
	internal static string GetPersistentPath(string relativePath) => default; // 0x000000018162D450-0x000000018162D560
	// [XID] // 0x00000001898EF660-0x00000001898EF680
	internal static string GetPersistentBundlePath(string relativePath) => default; // 0x000000018162EF80-0x000000018162F0A0
	// [XID] // 0x00000001899EB6D0-0x00000001899EB6F0
	internal static string GetStreamingPath(string relativePath) => default; // 0x000000018162F420-0x000000018162F530
	// [XID] // 0x0000000189B0FDC0-0x0000000189B0FDE0
	internal static string GetStreamingBundlePath(string relativePath) => default; // 0x000000018162AF90-0x000000018162B0A0
	// [XID] // 0x0000000189736730-0x0000000189736750
	public static string GetStreamingAudioPath(string pathInVersionFile) => default; // 0x000000018162A5F0-0x000000018162A710
	// [XID] // 0x000000018973E500-0x000000018973E520
	public static string GetAudioPlatformNameInStreamingDir() => default; // 0x000000018162EA40-0x000000018162EC10
	// [XID] // 0x0000000189914EB0-0x0000000189914ED0
	internal static string GetContent(string fullPath) => default; // 0x00000001816292C0-0x0000000181629400
	// [XID] // 0x0000000189743F20-0x0000000189743F40
	internal static string ReadFromFile(string path) => default; // 0x000000018162DF90-0x000000018162E2B0
	// [XID] // 0x0000000189726140-0x0000000189726160
	internal static void SaveToFile(string path, byte[] content) {} // 0x000000018162ECE0-0x000000018162EF80
	// [XID] // 0x000000018992B8A0-0x000000018992B8C0
	internal static bool Exists(string filePath) => default; // 0x0000000181629F80-0x000000018162A050
	// [XID] // 0x0000000189933040-0x0000000189933060
	internal static bool ExistsInStreamingAssets(string pathInStreamingAssets) => default; // 0x000000018162BC30-0x000000018162BD00
	// [XID] // 0x000000018993A8E0-0x000000018993A900
	internal static void DeleteIfExist(string filePath) {} // 0x000000018162D900-0x000000018162DA80
	// [XID] // 0x00000001899419B0-0x00000001899419D0
	internal static bool ChangeReadOnlyAndDeleteIfExist(string filePath) => default; // 0x000000018162B0A0-0x000000018162B290
	// [XID] // 0x0000000189949490-0x00000001899494B0
	internal static void ChangeFileReadOnlyAccess(string filePath, bool isReadOnly = false /* Metadata: 0x00AEA38F */) {} // 0x000000018162C060-0x000000018162C220
	// [XID] // 0x0000000189950D30-0x0000000189950D50
	internal static void AssureDirectoryExists(string dirPath) {} // 0x000000018162C620-0x000000018162C710
	// [XID] // 0x0000000189958530-0x0000000189958550
	internal static void CopyFile(string from, string to) {} // 0x000000018162DCE0-0x000000018162DF90
	// [XID] // 0x0000000189734EF0-0x0000000189734F10
	internal static void CopyFile_Bytes(string from, string to) {} // 0x000000018162E3F0-0x000000018162E840
	// [XID] // 0x00000001899674D0-0x00000001899674F0
	internal static void CopyFileIfSourceFileExist(string from, string to, bool changeReadOnly) {} // 0x000000018162A490-0x000000018162A5F0
	// [XID] // 0x000000018996E700-0x000000018996E720
	public static void WriteToFile(string path, string content) {} // 0x000000018162B290-0x000000018162B5E0
	// [XID] // 0x0000000189976270-0x0000000189976290
	public static void AppendStringToFile(string path, string content, bool newLine = true /* Metadata: 0x00AEA390 */) {} // 0x000000018162CFF0-0x000000018162D340
	// [XID] // 0x000000018997D4E0-0x000000018997D500
	internal static List<string> ReadAssetListFromFile(string filePath) => default; // 0x000000018162C710-0x000000018162CA20
	// [XID] // 0x000000018978E800-0x000000018978E820
	internal static int[] GetRevisionsFromFile(string filePath) => default; // 0x0000000181629030-0x00000001816292C0
	// [XID] // 0x000000018998CC40-0x000000018998CC60
	internal static int ReadRevisionFromFile(string filePath) => default; // 0x000000018162CDD0-0x000000018162CFF0
	// [XID] // 0x0000000189994900-0x0000000189994920
	internal static string ReadSuffixFromFile(string filePath) => default; // 0x000000018162C220-0x000000018162C420
	// [XID] // 0x000000018999C150-0x000000018999C170
	internal static string GetFileName(string path) => default; // 0x000000018162EC10-0x000000018162ECE0
	// [XID] // 0x00000001899A3A80-0x00000001899A3AA0
	public static string GetParentDirNameInVersionFile(string pathInVersionFile, bool isLocalPath = false /* Metadata: 0x00AEA391 */) => default; // 0x000000018162A050-0x000000018162A360
	// [IDTag] // 0x00000001899AB570-0x00000001899AB5B0
	// [XID] // 0x00000001899AB570-0x00000001899AB5B0
	public static void CheckUnsavedNewRes() {} // 0x000000018162ABA0-0x000000018162ACE0
	// [IDTag] // 0x00000001899B5A80-0x00000001899B5AC0
	// [XID] // 0x00000001899B5A80-0x00000001899B5AC0
	public static void CheckUnsavedNewRes(string dirPath) {} // 0x000000018162A710-0x000000018162ABA0
	// [XID] // 0x00000001899C0370-0x00000001899C0390
	public static void CheckUnzippedNewRes(string dirPath) {} // 0x0000000181629400-0x0000000181629790
	// [XID] // 0x00000001899150D0-0x00000001899150F0
	public static void ClearDirectory(string dirPath, bool deleteTop, bool changeReadOnly) {} // 0x000000018162B5E0-0x000000018162BC30
	// [XID] // 0x00000001899CF3B0-0x00000001899CF3D0
	public static uint ReadRemoteResCurRevision() => default; // 0x0000000181629D70-0x0000000181629EC0
	// [XID] // 0x00000001899D68B0-0x00000001899D68D0
	public static uint ReadRemoteDataCurRevision() => default; // 0x000000018162E2B0-0x000000018162E3F0
	// [XID] // 0x0000000189787230-0x0000000189787250
	public static uint ReadRemoteSilenceCurRevision() => default; // 0x000000018162D7C0-0x000000018162D900
	// [XID] // 0x00000001899E5C90-0x00000001899E5CB0
	public static uint ReadRemoteRevision(string url) => default; // 0x000000018162F0A0-0x000000018162F420
	// [XID] // 0x00000001899ECD40-0x00000001899ECD60
	public static string[] ReadBaseTextLanguage() => default; // 0x000000018162E840-0x000000018162EA40
	// [XID] // 0x000000018979E170-0x000000018979E190
	public static string[] ReadBaseAudioLanguage() => default; // 0x000000018162C420-0x000000018162C620
	// [XID] // 0x00000001897A5740-0x00000001897A5760
	public static GlobalVars.PackageType ReadPkgType() => default; // 0x000000018162ACE0-0x000000018162AE80
	// [XID] // 0x0000000189A034F0-0x0000000189A03510
	public static void UnzipFile(string filePath, string outputFolder) {} // 0x0000000181629910-0x0000000181629D70
	// [XID] // 0x0000000189A0AB70-0x0000000189A0AB90
	public static string GetTextFromTextMap(string key) => default; // 0x0000000181629790-0x0000000181629910
	// [XID] // 0x0000000189A12360-0x0000000189A12380
	public static string FormatSlash(string path) => default; // 0x000000018162A360-0x000000018162A490
	// [XID] // 0x0000000189A197D0-0x0000000189A197F0
	public static bool IsValidPath(string path) => default; // 0x000000018162BD00-0x000000018162BE20
	// [XID] // 0x0000000189A20E30-0x0000000189A20E50
	public static void CheckPackageType() {} // 0x000000018162DBF0-0x000000018162DCE0
	// [XID] // 0x0000000189A28120-0x0000000189A28140
	public static long GetFileSize(string filePath) => default; // 0x000000018162D340-0x000000018162D450
	// [XID] // 0x0000000189A2F8D0-0x0000000189A2F8F0
	public static long GetDirectorySize(string dirPath) => default; // 0x000000018162D560-0x000000018162D7C0
	// [XID] // 0x00000001899E42D0-0x00000001899E42F0
	public static string GetFileMd5(string filePath) => default; // 0x000000018162CB00-0x000000018162CDD0
	// [XID] // 0x00000001897D2E70-0x00000001897D2E90
	public static string GetContentMd5(string content) => default; // 0x000000018162BE20-0x000000018162C060
	// [XID] // 0x0000000189A46080-0x0000000189A460A0
	public static string SplitRelativePath(string fullPath, string prefixPath) => default; // 0x000000018162DA80-0x000000018162DBF0
	// [XID] // 0x0000000189A4D7D0-0x0000000189A4D7F0
	public static bool IsAssetBundleFile(string filePath) => default; // 0x000000018162CA20-0x000000018162CB00
	// [XID] // 0x0000000189A55050-0x0000000189A55070
	public static bool IsVideoFile(string filePath) => default; // 0x000000018162AE80-0x000000018162AF90
	// [XID] // 0x0000000189A5C940-0x0000000189A5C960
	public static bool IsAudioFile(string filePath) => default; // 0x0000000181629EC0-0x0000000181629F80
}

