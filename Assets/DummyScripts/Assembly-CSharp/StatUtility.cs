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

public static class StatUtility // TypeDefIndex: 27841
{
	// Fields
	public static string statRootLogFolder; // 0x00
	public static string entityTickStatFolder; // 0x08
	public const string entityTickStatSuffix = "ets"; // Metadata: 0x00B0D023
	public const string frameTickModuleStatSuffix = "ftms"; // Metadata: 0x00B0D02A
	public const string historyTickModuleStatSuffix = "htms"; // Metadata: 0x00B0D032
	public const string memoryDumpStatSuffix = "mds"; // Metadata: 0x00B0D03A
	public const string defaultStr = "default"; // Metadata: 0x00B0D041

	// Constructors
	static StatUtility() {} // 0x0000000181D5C760-0x0000000181D5C880

	// Methods
	// [XID] // 0x0000000189B75690-0x0000000189B756B0
	public static void ParseFileName(string inFullFilePath, ref string oDirName, ref string oFileName) {} // 0x0000000181D5C660-0x0000000181D5C760
	// [XID] // 0x0000000189B7CAE0-0x0000000189B7CB00
	public static void SaveTimeStampLog(string folderName, string suffix, string logContent) {} // 0x0000000181D5C4D0-0x0000000181D5C660
	public static void DescendingInsert<T>(List<T> children, Func<T, T, bool> lessCompareFunc, T inNode) {}
}

