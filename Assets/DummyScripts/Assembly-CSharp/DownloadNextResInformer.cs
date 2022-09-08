/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DownloadNextResInformer : DownloadResInformer // TypeDefIndex: 11621
{
	// Fields
	private string _nextScriptVersion; // 0x40

	// Nested types
	public enum NextResDownloadProcessStatus // TypeDefIndex: 11622
	{
		NOT_ENABLE = 0,
		ENABLE_BUT_NOT_START = 1,
		START_BUT_NOT_COMPLETE = 2,
		COMPLETED = 3
	}

	// Constructors
	public DownloadNextResInformer() {} // 0x0000000181A0ABF0-0x0000000181A0AC50

	// Methods
	// [XID] // 0x00000001896E3180-0x00000001896E31A0
	protected override void FreezeRemoteRevision() {} // 0x0000000181A0A950-0x0000000181A0AA90
	// [XID] // 0x0000000189BBA560-0x0000000189BBA580
	public override string GetStreamingVersionFilePath() => default; // 0x0000000181A0A680-0x0000000181A0A740
	// [XID] // 0x0000000189BC2560-0x0000000189BC2580
	public override string GetPersistentPath(string relativePath) => default; // 0x0000000181A0A530-0x0000000181A0A620
	// [XID] // 0x00000001896F90E0-0x00000001896F9100
	public static bool NeedDownloadNextRes() => default; // 0x0000000181A0A490-0x0000000181A0A530
	// [XID] // 0x0000000189BD89A0-0x0000000189BD89C0
	public static bool NeedShowDownloadNextRes() => default; // 0x0000000181A09EB0-0x0000000181A09F50
	// [XID] // 0x0000000189708140-0x0000000189708160
	public static NextResDownloadProcessStatus GetNextResDownloadProcessStatus(int curResRevision, int nextResRevision, string curScriptVersion, string nextScriptVersion) => default; // 0x0000000181A0AA90-0x0000000181A0ABF0
	// [XID] // 0x00000001895ECE80-0x00000001895ECEA0
	public static bool IsCompletedNextDownloadDir(string nextResDir, int nextResRevision) => default; // 0x0000000181A0A210-0x0000000181A0A370
	// [XID] // 0x0000000189716D90-0x0000000189716DB0
	public static string[] GetResFilesInNextResDir(string preResDir) => default; // 0x0000000181A0A740-0x0000000181A0A950
	// [XID] // 0x00000001898FE960-0x00000001898FE980
	public static string GetCurrentEnabledNextScriptVersion() => default; // 0x0000000181A09DE0-0x0000000181A09EB0
	// [XID] // 0x0000000189725F60-0x0000000189725F80
	public static string GetNextResDownloadRootDir() => default; // 0x0000000181A09D10-0x0000000181A09DE0
	// [XID] // 0x000000018972D4F0-0x000000018972D510
	public static string GetNextResDownloadDirName(string scriptVersion) => default; // 0x0000000181A09FC0-0x0000000181A0A190
	// [XID] // 0x0000000189734C10-0x0000000189734C30
	public static string GetNextResDownloadDir(string scriptVersion) => default; // 0x0000000181A0A370-0x0000000181A0A490
}

