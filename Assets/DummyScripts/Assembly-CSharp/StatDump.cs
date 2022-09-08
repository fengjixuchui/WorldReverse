/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class StatDump // TypeDefIndex: 27826
{
	// Nested types
	public class ObjectLogNode // TypeDefIndex: 27827
	{
		// Fields
		public object obj; // 0x10
		public List<string> logContent; // 0x18
		public List<ObjectLogNode> children; // 0x20

		// Constructors
		public ObjectLogNode() {} // Dummy constructor
		public ObjectLogNode(object o, ObjectLogNode parent = null) {} // 0x0000000183EC60F0-0x0000000183EC61D0

		// Methods
		// [XID] // 0x0000000189BC3CD0-0x0000000189BC3CF0
		public bool ContainsAnyLog() => default; // 0x0000000183EC5EC0-0x0000000183EC6020
		// [XID] // 0x0000000189A18820-0x0000000189A18840
		public void AddChildren(ObjectLogNode inNode) {} // 0x0000000183EC6020-0x0000000183EC60F0
		// [XID] // 0x0000000189A1FEA0-0x0000000189A1FEC0
		public void Log(StatLog.TimestampLogger ts, int nestLevel) {} // 0x0000000183EC5C20-0x0000000183EC5EC0
	}

	public enum EDumpRequestType // TypeDefIndex: 27828
	{
		EDRT_None = 0,
		EDRT_BenchmarkDaily = 1,
		EDRT_BenchmarkDurationReport = 2,
		EDRT_EntityDetailInfo = 3
	}

	public struct DumpRequest // TypeDefIndex: 27829
	{
		// Fields
		public EDumpRequestType requestType; // 0x00
		public string sessionID; // 0x08
		public int requestDumpFrameCount; // 0x10
	}

	public class DumpRequestManager // TypeDefIndex: 27830
	{
		// Fields
		private DumpRequest _currentHandlingRequest; // 0x10
		private string _sharedPrefix; // 0x28
		private int _tickCount; // 0x30
		private Queue<DumpRequest> _dumpRequests; // 0x38
		public const int defaultTickModuleTickCount = 200; // Metadata: 0x00B0CFEB
		private const float ECPDetailTMCount = 60f; // Metadata: 0x00B0CFEF
		private const string tickModuleTimeLogPrefix = "TMT_"; // Metadata: 0x00B0CFF3
		private const string memoryStatInfoLogPrefix = "MIS_"; // Metadata: 0x00B0CFFB
		private bool bCallbackTriggeredHandleLogicFinished; // 0x40
		private static DumpRequestManager _instance; // 0x00
		private float _targetDurationTime; // 0x44
		private float _curretDurationTime; // 0x48
		private const float _targetHitchFrameTime = 0.0396f; // Metadata: 0x00B0D003
		private const int _failContinousHitchFrameCount = 30; // Metadata: 0x00B0D007
		private int _currentContinousHitchFrameCount; // 0x4C

		// Properties
		private bool _bHandlingDumpingRequest { /* [XID] */ /* 0x0000000189864C70-0x0000000189864C90 */ get => default; } // 0x0000000183EC47B0-0x0000000183EC4860 

		// Constructors
		private DumpRequestManager() {} // 0x0000000183EC5AF0-0x0000000183EC5C20
		static DumpRequestManager() {} // 0x0000000183EC5A90-0x0000000183EC5AF0

		// Methods
		// [XID] // 0x0000000189A2EA50-0x0000000189A2EA70
		public static string GetGeneralDumpPrefix() => default; // 0x0000000183EC4B20-0x0000000183EC4CD0
		// [XID] // 0x0000000189A36320-0x0000000189A36340
		public static string GenGUIDDumpFileNamePrefix(string inSessionID) => default; // 0x0000000183EC4650-0x0000000183EC47B0
		// [XID] // 0x0000000189A3D920-0x0000000189A3D940
		public void ConditionalStopTMTMSI() {} // 0x0000000183EC5930-0x0000000183EC59E0
		// [XID] // 0x000000018986C200-0x000000018986C220
		private void OnStartHandlingDumpRequest(DumpRequest inRequest) {} // 0x0000000183EC53F0-0x0000000183EC55C0
		// [XID] // 0x0000000189A4C7E0-0x0000000189A4C800
		private void OnFinishHandlingDumpRequest() {} // 0x0000000183EC4560-0x0000000183EC4650
		// [XID] // 0x0000000189706AC0-0x0000000189706AE0
		public void RequestDump(EDumpRequestType inRequestType, string inSessionID, int inTotalDumpFrameCount = 200 /* Metadata: 0x00B0CFE7 */) {} // 0x0000000183EC52D0-0x0000000183EC53F0
		// [XID] // 0x000000018993C210-0x000000018993C230
		private void OnECPProfilerFrameTick(List<CycleStatLogNode> inCycleStatLog) {} // 0x0000000183EC5870-0x0000000183EC5930
		// [XID] // 0x0000000189882300-0x0000000189882320
		private void StartECPProfiler() {} // 0x0000000183EC4FC0-0x0000000183EC50C0
		// [XID] // 0x0000000189A6AC20-0x0000000189A6AC40
		private void StopECPProfiler() {} // 0x0000000183EC51D0-0x0000000183EC52D0
		// [XID] // 0x000000018969E320-0x000000018969E340
		private bool IsECPStarted() => default; // 0x0000000183EC57A0-0x0000000183EC5870
		// [XID] // 0x0000000189943690-0x00000001899436B0
		private void OnHandleEntityDetialDump(List<CycleStatLogNode> _cycleStatLog) {} // 0x0000000183EC4970-0x0000000183EC4B20
		// [XID] // 0x0000000189A813C0-0x0000000189A813E0
		private bool OnHandleCurrentDailyDump(int inRequestTotalTickCount) => default; // 0x0000000183EC4CD0-0x0000000183EC4FC0
		// [XID] // 0x0000000189A88E40-0x0000000189A88E60
		private void OnHandleCurrentDump() {} // 0x0000000183EC55C0-0x0000000183EC5690
		// [XID] // 0x0000000189A90570-0x0000000189A90590
		public static DumpRequestManager GetInstance() => default; // 0x0000000183EC4220-0x0000000183EC4430
		// [XID] // 0x0000000189A97DE0-0x0000000189A97E00
		public bool IsDumpingDuration() => default; // 0x0000000183EC59E0-0x0000000183EC5A90
		// [XID] // 0x0000000189A9F1F0-0x0000000189A9F210
		public void RequestDurationDump(float inTargetDurationTime) {} // 0x0000000183EC50C0-0x0000000183EC51D0
		// [XID] // 0x0000000189AA6A70-0x0000000189AA6A90
		private void OnAnalyzeFrame(ref StatFrameData inFrameData) {} // 0x0000000183EC5690-0x0000000183EC57A0
		// [XID] // 0x0000000189AAE160-0x0000000189AAE180
		private void StartDurationReport() {} // 0x0000000183EC4430-0x0000000183EC4560
		// [XID] // 0x0000000189AB5A50-0x0000000189AB5A70
		private void StopDurationReport(bool bSuccess) {} // 0x0000000183EC3F80-0x0000000183EC4220
		[DebuggerHidden] // 0x0000000189ABD430-0x0000000189ABD470
		// [XID] // 0x0000000189ABD430-0x0000000189ABD470
		private IEnumerator Tick() => default; // 0x0000000183EC4860-0x0000000183EC4970
	}

	// Methods
	// [XID] // 0x00000001899CE320-0x00000001899CE340
	public static List<FieldInfo> GetAllDelegateOfObject(object inObject) => default; // 0x0000000183ED0C20-0x0000000183ED0E10
	// [XID] // 0x000000018964B120-0x000000018964B140
	public static string GenDelegateInfo(Delegate inDel, int inNestLevel) => default; // 0x0000000183ECF530-0x0000000183ECF9E0
	// [XID] // 0x0000000189B330F0-0x0000000189B33110
	private static void DumpDelegateInfos(string fieldName, Delegate inDelegate, List<string> inDelegateInfos, int nestLevel) {} // 0x0000000183ED0880-0x0000000183ED0C20
	// [XID] // 0x00000001899E4A30-0x00000001899E4A50
	public static void DumpObjectDelegateInfos(StatLog.TimestampLogger ts, ObjectLogNode inNode, int nestLevel) {} // 0x0000000183ED04E0-0x0000000183ED0740
	// [XID] // 0x0000000189AE8BF0-0x0000000189AE8C10
	public static void DumpGameplayECPDelegateInfo() {} // 0x0000000183ECFBB0-0x0000000183ED04E0
	// [XID] // 0x00000001899F3930-0x00000001899F3950
	public static void StartDurationReport() {} // 0x0000000183ECF9E0-0x0000000183ECFAB0
	// [XID] // 0x0000000189742560-0x0000000189742580
	public static void StartDailyBenchmarkReport(int caseID) {} // 0x0000000183ED0740-0x0000000183ED0880
	// [XID] // 0x00000001896BCBE0-0x00000001896BCC00
	public static void StartTMTMSIBenchmarkReport(string caseName, int inTotalDumpFrameCount = -1 /* Metadata: 0x00B0CFD3 */) {} // 0x0000000183ECFAB0-0x0000000183ECFBB0
	// [XID] // 0x0000000189A09C50-0x0000000189A09C70
	public static void StopTMTMSIBenchmarkReport() {} // 0x0000000183ED0E10-0x0000000183ED0EE0
}

