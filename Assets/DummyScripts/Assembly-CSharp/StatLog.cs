/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class StatLog // TypeDefIndex: 27915
{
	// Fields
	public const string braceStartAtEnd = "\t{"; // Metadata: 0x00B0D174
	public const string braceEndAtStart = "}"; // Metadata: 0x00B0D17A
	public const string SIZE_PREFIX = " Size: "; // Metadata: 0x00B0D17F
	public const string COUNT_PREFIX = " Count: "; // Metadata: 0x00B0D18A
	public const string TYPE_PREFIX = " Type: "; // Metadata: 0x00B0D196
	private static int ftmFrameCount; // 0x00
	private static Dictionary<string, Action> _dumpAction; // 0x08
	private static MonoECPDebugInfo _ecpDebugInfo; // 0x10
	private static Dictionary<string, List<Func<string[], bool>>> _consoleCommandHandlers; // 0x18

	// Nested types
	public interface IBufferLogger // TypeDefIndex: 27916
	{
		// Methods
		void Log(string inStr);
	}

	public class TimestampLogger : IBufferLogger // TypeDefIndex: 27917
	{
		// Fields
		public string fileName; // 0x10
		public static bool flushInstently; // 0x00
		private int flushLineCount; // 0x18
		private bool bAppendMode; // 0x1C
		private int currentLineCount; // 0x20
		private StringBuilder sb; // 0x28
		public static readonly string rootFolderPath; // 0x08
		public static string lastGeneratedFile; // 0x10
		private int _currentItemCount; // 0x30
		public static bool shouldUploadToServer; // 0x18

		// Nested types
		public struct ScopeLogger : IDisposable // TypeDefIndex: 27918
		{
			// Fields
			public TimestampLogger _ts; // 0x00
			private bool openFolder; // 0x08

			// Constructors
			public ScopeLogger(string folderPath, string fileType, string filePrefixName, bool inOpenFolder = true /* Metadata: 0x00B0D1A6 */) {
				_ts = default;
				openFolder = default;
			} // 0x0000000181BA92D0-0x0000000181BA9310

			// Methods
			// [XID] // 0x000000018978A5D0-0x000000018978A5F0
			public void Log(string inLog) {} // 0x0000000181BA90E0-0x0000000181BA91C0
			// [XID] // 0x0000000189791D50-0x0000000189791D70
			public void Dispose() {} // 0x0000000181BA91C0-0x0000000181BA92D0
		}

		// Constructors
		public TimestampLogger() {} // Dummy constructor
		public TimestampLogger(string folderPath) {} // 0x0000000181BC7C60-0x0000000181BC7FA0
		public TimestampLogger(string folderPath, string suffix, string filePrefixName = "" /* Metadata: 0x00B0D1A1 */, bool bDisableAutoTimeStamp = false /* Metadata: 0x00B0D1A5 */) {} // 0x0000000181BC7B70-0x0000000181BC7C60
		static TimestampLogger() {} // 0x0000000181BC7A80-0x0000000181BC7B70

		// Methods
		// [XID] // 0x000000018971C2D0-0x000000018971C2F0
		public void SetFlushLineCount(int inLineCount) {} // 0x0000000181BC6F10-0x0000000181BC6FC0
		// [XID] // 0x0000000189723740-0x0000000189723760
		public static string GetCurrentPlatform() => default; // 0x0000000181BC7440-0x0000000181BC7500
		// [XID] // 0x0000000189A92EB0-0x0000000189A92ED0
		public static string GetTimeStampString() => default; // 0x0000000181BC7350-0x0000000181BC7440
		// [XID] // 0x0000000189732530-0x0000000189732550
		protected static string GenUniqueNameSuffix() => default; // 0x0000000181BC7110-0x0000000181BC71D0
		// [XID] // 0x0000000189739CA0-0x0000000189739CC0
		public static string GetDumpFolderPath(string folderPath) => default; // 0x0000000181BC75B0-0x0000000181BC76D0
		// [XID] // 0x0000000189741820-0x0000000189741840
		public static string GenerateUniqueFullFilePath(ref string folderPath, string suffix, string filePrefixName, bool bDisableAutoTimeStamp) => default; // 0x0000000181BC6A10-0x0000000181BC6D90
		// [XID] // 0x0000000189749140-0x0000000189749160
		private void Init(string folderPath, string suffix, string filePrefixName, bool bDisableAutoTimeStamp) {} // 0x0000000181BC6FC0-0x0000000181BC7110
		// [XID] // 0x0000000189750670-0x0000000189750690
		public void Log(string inStr) {} // 0x0000000181BC6D90-0x0000000181BC6F10
		// [XID] // 0x0000000189AB3BE0-0x0000000189AB3C00
		public void LogItem(List<string> inStrs) {} // 0x0000000181BC71D0-0x0000000181BC7350
		// [IDTag] // 0x000000018975F590-0x000000018975F5D0
		// [XID] // 0x000000018975F590-0x000000018975F5D0
		public void OpenFolderInExplorer() {} // 0x0000000181BC7770-0x0000000181BC7840
		// [IDTag] // 0x0000000189769A20-0x0000000189769A60
		// [XID] // 0x0000000189769A20-0x0000000189769A60
		public static void OpenFolderInExplorer(string inFileName) {} // 0x0000000181BC76D0-0x0000000181BC7770
		// [XID] // 0x0000000189773EF0-0x0000000189773F10
		private void WriteToLog(bool bAppend, StringBuilder inSB) {} // 0x0000000181BC7840-0x0000000181BC7980
		// [XID] // 0x000000018977B5A0-0x000000018977B5C0
		public void Flush() {} // 0x0000000181BC7500-0x0000000181BC75B0
		// [XID] // 0x0000000189783120-0x0000000189783140
		public void FlushAndOpenInExplorer() {} // 0x0000000181BC7980-0x0000000181BC7A80
	}

	private struct StatIDCount // TypeDefIndex: 27919
	{
		// Fields
		public string id; // 0x00
		public int count; // 0x08

		// Constructors
		public StatIDCount(string inId, int inCount) {
			id = default;
			count = default;
		} // 0x0000000181BC8330-0x0000000181BC84B0
		public StatIDCount(System.Type inId, int inCount) {
			id = default;
			count = default;
		} // 0x0000000181BC82B0-0x0000000181BC8330

		// Methods
		// [XID] // 0x00000001897A3CB0-0x00000001897A3CD0
		public override string ToString() => default; // 0x0000000181BC8200-0x0000000181BC82B0
	}

	private struct UnityObjectsEnableInfo // TypeDefIndex: 27920
	{
		// Fields
		public int selfEnableCount; // 0x00
		public int reallyEnableCount; // 0x04

		// Methods
		// [XID] // 0x00000001897A1330-0x00000001897A1350
		public int IncreaseReallyEnableCount() => default; // 0x0000000181BC8060-0x0000000181BC8100
		// [XID] // 0x00000001897A8900-0x00000001897A8920
		public int IncreaseSelfEnableCount() => default; // 0x0000000181BC7FA0-0x0000000181BC8060
	}

	// Constructors
	static StatLog() {} // 0x000000018158D760-0x000000018158D840

	// Methods
	// [XID] // 0x0000000189BBF140-0x0000000189BBF160
	public static string GetDebugFullCSVTitle() => default; // 0x000000018158A050-0x000000018158A0F0
	// [XID] // 0x0000000189BD19F0-0x0000000189BD1A10
	public static void RegisterConsoleCommandToReporter() {} // 0x0000000181586EC0-0x0000000181587080
	// [XID] // 0x0000000189BD8FE0-0x0000000189BD9000
	public static string GetIndentStringByCount(int indentCount) => default; // 0x0000000181587F00-0x0000000181588010
	// [XID] // 0x00000001895E5BA0-0x00000001895E5BC0
	public static string GetBraceEndByIndent(int indentCount) => default; // 0x0000000181589360-0x0000000181589460
	// [XID] // 0x0000000189608480-0x00000001896084A0
	public static int GetIndentCountByString(string inStr) => default; // 0x0000000181587D70-0x0000000181587E50
	private static Dictionary<string, List<T>> GenerateTypeIDObjectListMap<T>(T[] inObjectArray) => default;
	private static Dictionary<string, List<T>> GenerateNamedUnityObjectListMap<T>(T[] inObjectArray)
		where T : UnityEngine.Object => default;
	private static List<StatIDCount> GenerateSortedStatIDCountListByStatIDListMap<T>(Dictionary<string, List<T>> inTypeObjListMap, out int totalCount, int sortMode = 0 /* Metadata: 0x00B0D136 */) {
		totalCount = default;
		return default;
	}
	private static string GenerateSortedTypeCountLog<T>(Dictionary<System.Type, List<T>> inTypeObjListMap, string prefix = "" /* Metadata: 0x00B0D13A */) => default;
	// [XID] // 0x000000018960FD60-0x000000018960FD80
	public static TimestampLogger BeginLog(string folderName, string suffix, string filePrefixName = "" /* Metadata: 0x00B0D13E */, bool bDisableAutoTimestampLog = false /* Metadata: 0x00B0D142 */) => default; // 0x0000000181587080-0x0000000181587190
	// [XID] // 0x0000000189805EC0-0x0000000189805EE0
	private static void LogSectionStatIDCountList(TimestampLogger inLogger, string sectionName, List<StatIDCount> inList, int inTotalCount, bool bCoalesed, int maxLogCount = 20 /* Metadata: 0x00B0D143 */) {} // 0x0000000181588E40-0x00000001815890C0
	public static List<string> GenerateSortedAssetInfoByUnityObjects_CSVStr<T>(IEnumerable<T> inEnum, out int count, out int totalEnableCount)
		where T : UnityEngine.Object {
		count = default;
		totalEnableCount = default;
		return default;
	}
	public static List<string> GenerateSortedAssetInfoByUnityObjects<T>(IEnumerable<T> inEnum, out int count)
		where T : UnityEngine.Object {
		count = default;
		return default;
	}
	public static List<string> GenerateSortedAssetInfo<T>(out int count)
		where T : UnityEngine.Object {
		count = default;
		return default;
	}
	// [XID] // 0x00000001898FCF40-0x00000001898FCF60
	public static void LogSectionStringList(IBufferLogger inLogger, string sectionName, List<string> inList, int inTotalCount, bool bCoalesed, int maxLogCount = 20 /* Metadata: 0x00B0D147 */) {} // 0x000000018158BA40-0x000000018158BE00
	// [XID] // 0x0000000189626000-0x0000000189626020
	public static void LogSectionStringListCSV(IBufferLogger inLogger, string sectionName, List<string> inList, int inTotalCount, int enableCount, bool bCoalesed, int maxLogCount = 20 /* Metadata: 0x00B0D14B */) {} // 0x000000018158A0F0-0x000000018158A520
	public static void LogSectionAssetInfo<T>(IBufferLogger inLogger)
		where T : UnityEngine.Object {}
	public static void LogSectionAssetInfoByUnityObjectsCSV<T>(IEnumerable<T> inEnum, IBufferLogger inLogger)
		where T : UnityEngine.Object {}
	public static string DumpUnityObjectMemory<T>(IEnumerable<T> inEnum, bool upload, bool openExplorer)
		where T : UnityEngine.Object => default;
	// [XID] // 0x000000018962D9E0-0x000000018962DA00
	private static void FinishLog(TimestampLogger inLogger) {} // 0x0000000181587E50-0x0000000181587F00
	private static void StatLogTypedObjectCount<T>(T[] typedObjetList) {}
	// [XID] // 0x00000001896355C0-0x00000001896355E0
	public static string MakeTimestampLog(string folderName, string suffix, string content, string filePrefixName = "" /* Metadata: 0x00B0D14F */, bool bDisableAutoTimeStamp = false /* Metadata: 0x00B0D153 */) => default; // 0x0000000181589F00-0x000000018158A050
	// [XID] // 0x000000018963CC40-0x000000018963CC60
	public static string MakeTimestampLogByStringList(string folderName, string suffix, List<string> content, string filePrefixName = "" /* Metadata: 0x00B0D154 */, bool bDisableAutoTimeStamp = false /* Metadata: 0x00B0D158 */) => default; // 0x0000000181587590-0x00000001815877C0
	public static void LogUnityObjectDetailInfoSection<T>(TimestampLogger ts, string sectionName, int maxLogCount = 20 /* Metadata: 0x00B0D159 */)
		where T : UnityEngine.Object {}
	// [XID] // 0x0000000189644240-0x0000000189644260
	private static void StatLogGameplayTick(List<CycleStatLogNode> inCycleStatLog) {} // 0x000000018158BE00-0x000000018158C5A0
	// [XID] // 0x000000018964B9D0-0x000000018964B9F0
	public static void DummpMemoryOverviewStatInfo() {} // 0x00000001815885B0-0x0000000181588750
	// [XID] // 0x0000000189653180-0x00000001896531A0
	private static void StatFrameTickModule(List<CycleStatLogNode> inCycleStatLog) {} // 0x0000000181587B30-0x0000000181587D70
	// [XID] // 0x0000000189B3ACB0-0x0000000189B3ACD0
	private static bool OnHandleToggleCommand(string[] strs) => default; // 0x000000018158C7B0-0x000000018158CFA0
	// [XID] // 0x0000000189B58FA0-0x0000000189B58FC0
	private static void CMToggleNPCMoveLOD(int inLOD) {} // 0x000000018158A790-0x000000018158AAF0
	// [XID] // 0x00000001897D5EF0-0x00000001897D5F10
	private static void CMToggleMeshColliderUseConvex(bool bOn) {} // 0x0000000181588870-0x00000001815889A0
	// [XID] // 0x0000000189671640-0x0000000189671660
	public static void LogStringListWithAutoIndex(TimestampLogger inLogger, List<string> inStringList, bool bCoalesed = true /* Metadata: 0x00B0D15D */) {} // 0x0000000181588160-0x0000000181588280
	// [XID] // 0x0000000189678E40-0x0000000189678E60
	public static List<string> ParseCurrentStackTrace(List<string> stackLog, int inStartStackDepth, int inMaxStackDepth) => default; // 0x0000000181588BB0-0x0000000181588E40
	// [XID] // 0x0000000189680610-0x0000000189680630
	public static string GetCurrentStackTrace() => default; // 0x0000000181586C70-0x0000000181586EC0
	// [XID] // 0x0000000189688090-0x00000001896880B0
	private static bool OnHandleCallCommand(string[] strs) => default; // 0x000000018158C5A0-0x000000018158C7B0
	// [XID] // 0x000000018968FA50-0x000000018968FA70
	public static void RegisterDumpAction(string action, Action inAction) {} // 0x0000000181588750-0x0000000181588870
	// [XID] // 0x0000000189697470-0x0000000189697490
	private static bool InternalTryHandleWithRegisteredDumpAction(Dictionary<string, Action> inActionMap, string inAction) => default; // 0x000000018158D3D0-0x000000018158D4F0
	// [XID] // 0x00000001896B5940-0x00000001896B5960
	private static bool TryHandleWithRegisteredDumpAction(string inAction) => default; // 0x000000018158D160-0x000000018158D240
	// [XID] // 0x00000001896A5A10-0x00000001896A5A30
	private static bool OnHandleDumpCommand(string[] strs) => default; // 0x000000018158AAF0-0x000000018158BA40
	public static string DumpUnityObjectMemory<T>()
		where T : UnityEngine.Object => default;
	// [XID] // 0x00000001895E6B90-0x00000001895E6BB0
	public static string DumpGameplayDetailMemory(string prefix = "GM_" /* Metadata: 0x00B0D15E */, string sessionID = "Default" /* Metadata: 0x00B0D165 */, string suffix = "" /* Metadata: 0x00B0D170 */) => default; // 0x00000001815877C0-0x0000000181587A80
	// [XID] // 0x00000001896B48E0-0x00000001896B4900
	public static bool OnHandleStatUnit(string[] strs) => default; // 0x0000000181589460-0x0000000181589F00
	// [XID] // 0x0000000189B12CC0-0x0000000189B12CE0
	public static void RegisterConsoleCommand(string categoryName, Func<string[], bool> inHandler) {} // 0x00000001815873C0-0x0000000181587590
	// [XID] // 0x00000001896C2FD0-0x00000001896C2FF0
	public static void UnregisterConsoleCommand(string categoryName, Func<string[], bool> inHandler) {} // 0x0000000181588010-0x0000000181588160
	// [XID] // 0x00000001896CA480-0x00000001896CA4A0
	private static bool TryExecuteConsoleCommand(string[] inCommand) => default; // 0x000000018158A520-0x000000018158A790
	// [XID] // 0x00000001896D1AF0-0x00000001896D1B10
	public static bool OnConsoleCommand(string command) => default; // 0x00000001815889A0-0x0000000181588BB0
	// [XID] // 0x00000001896D9320-0x00000001896D9340
	public static void PrintAllPersistentDataPath() {} // 0x000000018158CFA0-0x000000018158D160
	// [XID] // 0x00000001896E0BC0-0x00000001896E0BE0
	public static void UploadFile(string fileName) {} // 0x0000000181587A80-0x0000000181587B30
	// [XID] // 0x00000001896E7DC0-0x00000001896E7DE0
	public static void UploadAllFile(string folderName) {} // 0x0000000181588280-0x00000001815885B0
	// [XID] // 0x00000001896EF530-0x00000001896EF550
	public static void DeleteAllFile(string folderName) {} // 0x000000018158D240-0x000000018158D3D0

	// Extension methods
	// [XID] // 0x0000000189BA0220-0x0000000189BA0260
	public static bool IgnoreCaseEqual(this string a, string b) => default; // 0x0000000181586BA0-0x0000000181586C70
	// [XID] // 0x0000000189BAA8B0-0x0000000189BAA8F0
	public static string GetDebugFullHierarchyName(this UnityEngine.Object o) => default; // 0x0000000181587190-0x00000001815873C0
	// [XID] // 0x0000000189BB4DF0-0x0000000189BB4E30
	public static string GetDebugFullName(this UnityEngine.Object o) => default; // 0x00000001815890C0-0x0000000181589210
	// [XID] // 0x0000000189BC6E10-0x0000000189BC6E50
	public static string GetDebugFullCSVStr(this UnityEngine.Object o) => default; // 0x0000000181589210-0x0000000181589360
	// [IDTag] // 0x00000001895ED4D0-0x00000001895ED520
	// [XID] // 0x00000001895ED4D0-0x00000001895ED520
	public static string ToCSVString(this Vector3 v) => default; // 0x000000018158D4F0-0x000000018158D660
	// [IDTag] // 0x00000001895FAAC0-0x00000001895FAB10
	// [XID] // 0x00000001895FAAC0-0x00000001895FAB10
	public static string ToCSVString(this Quaternion r) => default; // 0x000000018158D660-0x000000018158D760
}

