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
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class StatLoad // TypeDefIndex: 27907
{
	// Fields
	private static int _remainingCountSyncLoadRequestCount; // 0x00
	private static StatLog.TimestampLogger _currentStateSyncLoadLogger; // 0x08
	private static FrameStat _currentStat; // 0x10
	private static EffectStat _curEffectStat; // 0x18

	// Nested types
	private class LoadStat // TypeDefIndex: 27908
	{
		// Fields
		public int totalLoadCount; // 0x10
		public int thisFrameLoadCount; // 0x14
		public int workFrameCount; // 0x18
		public int totalFrameCount; // 0x1C
		public int minCount; // 0x20
		public int maxCount; // 0x24
		public MMAField _timeMMA; // 0x28
		public Dictionary<string, int> _stackTraceCountMap; // 0x50

		// Properties
		public float averageLoadCountPerWorkFrame { /* [XID] */ /* 0x0000000189A93360-0x0000000189A93380 */ get => default; } // 0x000000018271E7F0-0x000000018271E8C0 
		public float workFramePercent { /* [XID] */ /* 0x0000000189A12610-0x0000000189A12630 */ get => default; } // 0x000000018271E730-0x000000018271E7F0 

		// Constructors
		public LoadStat() {} // Dummy constructor
		public LoadStat(bool uselessParam) {} // 0x000000018271EA70-0x000000018271EB60

		// Methods
		// [XID] // 0x0000000189AA2150-0x0000000189AA2170
		public void OnLoadFileWithStackTrace(string filePath, string stackTraceStr) {} // 0x000000018271E8C0-0x000000018271EA70
		// [XID] // 0x0000000189AA9670-0x0000000189AA9690
		public void OnLoadFile(string filePath, float milliSeconds) {} // 0x000000018271E460-0x000000018271E660
		// [XID] // 0x0000000189A10C10-0x0000000189A10C30
		public void OnFrameEnd() {} // 0x000000018271E660-0x000000018271E730
		// [XID] // 0x0000000189AB87C0-0x0000000189AB87E0
		public void Log(StatLog.IBufferLogger logger) {} // 0x000000018271DEA0-0x000000018271E460
	}

	private class InstantiateSnapshot // TypeDefIndex: 27909
	{
		// Fields
		public double totalTime; // 0x10
		public List<KeyValuePair<string, MMAField>> _insList; // 0x18

		// Constructors
		public InstantiateSnapshot() {} // Dummy constructor
		public InstantiateSnapshot(List<KeyValuePair<string, MMAField>> inInsList) {} // 0x00000001827208B0-0x0000000182720B30

		// Methods
		// [XID] // 0x0000000189AC7E20-0x0000000189AC7E40
		public void Log(StatLog.IBufferLogger inLogger) {} // 0x0000000182720730-0x00000001827208B0
	}

	private class InstantiateStat // TypeDefIndex: 27910
	{
		// Fields
		public MMAField _timeMMA; // 0x10
		private double _lastFrameInsTime; // 0x38
		private MMAField _framePercentMMA; // 0x40
		public MMAField _validTimeMMA; // 0x68
		private MMAField _validFramePercentMMA; // 0x90
		private MMAField _countMMA; // 0xB8
		public Dictionary<string, MMAField> _stackTraceInsMap; // 0xE0
		public Dictionary<string, MMAField> _overviewStackTraceInsMap; // 0xE8

		// Constructors
		public InstantiateStat() {} // 0x00000001826F66C0-0x00000001826F68D0

		// Methods
		// [XID] // 0x0000000189AD7230-0x0000000189AD7250
		public void Clear() {} // 0x00000001826F6370-0x00000001826F6460
		// [XID] // 0x0000000189ADEC90-0x0000000189ADECB0
		public List<KeyValuePair<string, MMAField>> AccumulateFrameData(InstantiateStat inFrameStat) => default; // 0x00000001826F6460-0x00000001826F66C0
		// [XID] // 0x0000000189AE65E0-0x0000000189AE6600
		public void OnInstantiateObject(UnityEngine.Object original, float milliSeconds) {} // 0x00000001826F60B0-0x00000001826F6370
		// [XID] // 0x0000000189AEDE90-0x0000000189AEDEB0
		public void Log(StatLog.IBufferLogger logger) {} // 0x00000001826F5EC0-0x00000001826F60B0
	}

	private class LoadGameTimeFormulaGenerator // TypeDefIndex: 27911
	{
		// Fields
		public float thresholdTime; // 0x10
		public double syncM; // 0x18
		public double syncB; // 0x20
		public double asyncM; // 0x28
		public double asyncB; // 0x30
		public double totalM; // 0x38
		public double totalB; // 0x40

		// Constructors
		public LoadGameTimeFormulaGenerator() {} // Dummy constructor
		public LoadGameTimeFormulaGenerator(float inThresholdTime) {} // 0x00000001826F87F0-0x00000001826F8870

		// Methods
		// [XID] // 0x0000000189A29C00-0x0000000189A29C20
		public void AnalyzeInsantiate(float[] frameInsTimes, float[] frameFrameTimes) {} // 0x00000001826F85D0-0x00000001826F87F0
		// [XID] // 0x0000000189AFCB50-0x0000000189AFCB70
		public void Analyze(int[] frameSyncLoadCounts, int[] frameASyncLoadCounts, float[] frameFrameTimes) {} // 0x00000001826F7F10-0x00000001826F81F0
		// [XID] // 0x0000000189A0C4F0-0x0000000189A0C510
		public void Log(StatLog.IBufferLogger logger) {} // 0x00000001826F81F0-0x00000001826F85D0
	}

	private class FrameStat // TypeDefIndex: 27912
	{
		// Fields
		public Stack<float> frameFrameTimes; // 0x10
		public LoadStat syncLoadStat; // 0x18
		public Stack<int> frameSyncLoadCounts; // 0x20
		public LoadStat asyncLoadStat; // 0x28
		public Stack<int> frameAsyncLoadCounts; // 0x30
		public LoadStat threadObjectLoadStat; // 0x38
		private InstantiateStat _frameInsStat; // 0x40
		private Stack<float> _frameInstantiateTimes; // 0x48
		private InstantiateStat _overviewInsStat; // 0x50
		private List<InstantiateSnapshot> _instantiateSnapshots; // 0x58
		private Dictionary<string, MMAField> _detailInsStatMap; // 0x60
		private static readonly double[] frameTimeHistogramInitArray; // 0x00
		private FHistogram _insFrameHistogram; // 0x68
		private LoadGameTimeFormulaGenerator[] _loadTimeFormulas; // 0x70
		private LoadGameTimeFormulaGenerator[] _instantiateTimeFormulas; // 0x78
		private const int watchCount = 20; // Metadata: 0x00B0D132
		private string _caseName; // 0x80

		// Constructors
		public FrameStat() {} // Dummy constructor
		public FrameStat(string inCaseName) {} // 0x00000001826F7C50-0x00000001826F7F10
		static FrameStat() {} // 0x00000001826F7BB0-0x00000001826F7C50

		// Methods
		// [XID] // 0x0000000189B0BB50-0x0000000189B0BB70
		public void OnAnalyzeFrame(ref StatFrameData inFrameData) {} // 0x00000001826F7750-0x00000001826F7BB0
		// [XID] // 0x00000001897A0CF0-0x00000001897A0D10
		public void Start() {} // 0x00000001826F7160-0x00000001826F7750
		// [XID] // 0x0000000189B1A7B0-0x0000000189B1A7D0
		public void Stop() {} // 0x00000001826F68D0-0x00000001826F7160
	}

	public class EffectLoadStruct // TypeDefIndex: 27913
	{
		// Fields
		public string prefabPath; // 0x10
		public MMAField syncLoadTime; // 0x18
		public MMAField asyncLoadTime; // 0x40
		public MMAField instantiateTime; // 0x68
		public MMAField effectInstanciateDistance; // 0x90
		public MMAField setActiveTime; // 0xB8
		public float memoryBytes; // 0xE0

		// Constructors
		public EffectLoadStruct() {} // 0x000000018271DCB0-0x000000018271DEA0
	}

	private class EffectStat // TypeDefIndex: 27914
	{
		// Fields
		public Dictionary<string, EffectLoadStruct> _prefabSyncLoadTimeMap; // 0x10

		// Constructors
		public EffectStat() {} // 0x00000001827205E0-0x0000000182720670

		// Methods
		// [XID] // 0x0000000189B21DC0-0x0000000189B21DE0
		public void Clear() {} // 0x000000018271F7E0-0x000000018271F890
		// [XID] // 0x0000000189AB8300-0x0000000189AB8320
		public void OnSyncLoadEffect(string prefabPath, float milliSeconds) {} // 0x0000000182720210-0x0000000182720440
		// [XID] // 0x000000018981C840-0x000000018981C860
		public void OnAsyncLoadEffect(string prefabPath, float milliSeconds) {} // 0x000000018271FC20-0x000000018271FE50
		// [XID] // 0x0000000189B380B0-0x0000000189B380D0
		public void OnInstantiateObject(UnityEngine.Object original, float milliSeconds) {} // 0x000000018271F5F0-0x000000018271F7E0
		// [XID] // 0x00000001898DD220-0x00000001898DD240
		public void OnEffectInit(string prefabPath, Vector3 pos, float milliseconds) {} // 0x000000018271FE50-0x0000000182720210
		// [XID] // 0x0000000189B47320-0x0000000189B47340
		public void OnSetActiveTime(string prefabPath, float milliseconds) {} // 0x000000018271FA50-0x000000018271FC20
		// [XID] // 0x0000000189B4EBA0-0x0000000189B4EBC0
		public void OnSetMemorySize(string prefabPath, float memoryBytes) {} // 0x000000018271F890-0x000000018271FA50
		// [XID] // 0x0000000189B563E0-0x0000000189B56400
		public void ToTextFile() {} // 0x000000018271EFA0-0x000000018271F1C0
		// [XID] // 0x0000000189B5DBB0-0x0000000189B5DBD0
		public void ToCSVFile() {} // 0x0000000182720440-0x00000001827205E0
		// [XID] // 0x0000000189B65160-0x0000000189B65180
		public void Start() {} // 0x000000018271F1C0-0x000000018271F5F0
		// [XID] // 0x0000000189A095E0-0x0000000189A09600
		public void Stop() {} // 0x000000018271EB60-0x000000018271EFA0
	}

	// Constructors
	static StatLoad() {} // 0x0000000182703020-0x0000000182703090

	// Methods
	// [XID] // 0x00000001899DA090-0x00000001899DA0B0
	public static void FindLinearLeastSquaresFit(List<Vector2> points, out double m, out double b) {
		m = default;
		b = default;
	} // 0x0000000182702110-0x0000000182702490
	// [IDTag] // 0x00000001899E1A50-0x00000001899E1A90
	// [XID] // 0x00000001899E1A50-0x00000001899E1A90
	public static List<Vector2> GenListVec2By2Array(float[] x, float[] y, float yThreshold) => default; // 0x0000000182701DA0-0x0000000182701F50
	// [IDTag] // 0x00000001899EBEC0-0x00000001899EBF00
	// [XID] // 0x00000001899EBEC0-0x00000001899EBF00
	public static List<Vector2> GenListVec2By2Array(int[] x, float[] y, float yThreshold) => default; // 0x0000000182701F50-0x0000000182702110
	// [XID] // 0x00000001899F67F0-0x00000001899F6810
	public static List<Vector2> GenListVec2By3Array(int[] x, int[] x2, float[] y, float yThreshold) => default; // 0x00000001827016C0-0x00000001827018E0
	// [XID] // 0x00000001899FDDD0-0x00000001899FDDF0
	public static void TestLSF() {} // 0x0000000182700CB0-0x0000000182700EE0
	// [XID] // 0x00000001897D1540-0x00000001897D1560
	public static void StartStatSyncLoadRequest() {} // 0x0000000182700FA0-0x00000001827013D0
	// [XID] // 0x0000000189A0CA30-0x0000000189A0CA50
	private static void OnStatSyncLoadRequest(string inPath, float milliSeconds) {} // 0x00000001827027E0-0x0000000182702B40
	// [XID] // 0x0000000189798DD0-0x0000000189798DF0
	public static void StartStatLoading(string caseName = null) {} // 0x0000000182701C20-0x0000000182701DA0
	// [XID] // 0x000000018971BCA0-0x000000018971BCC0
	public static void StopStatLoading() {} // 0x0000000182702490-0x00000001827025F0
	// [XID] // 0x0000000189A3A830-0x0000000189A3A850
	public static void StartStatEffect() {} // 0x00000001827018E0-0x0000000182701A50
	// [XID] // 0x0000000189A421A0-0x0000000189A421C0
	public static void StopStatEffect() {} // 0x0000000182700B50-0x0000000182700CB0

	// Extension methods
	// [IDTag] // 0x000000018999CAD0-0x000000018999CB20
	// [XID] // 0x000000018999CAD0-0x000000018999CB20
	public static void Log(this Dictionary<string, int> strCountMap, StatLog.IBufferLogger logger, int maxCount = 20 /* Metadata: 0x00B0D11A */) {} // 0x0000000182700320-0x0000000182700620
	// [IDTag] // 0x00000001899AA3E0-0x00000001899AA430
	// [XID] // 0x00000001899AA3E0-0x00000001899AA430
	public static void Log(this List<KeyValuePair<string, MMAField>> kvpList, StatLog.IBufferLogger logger, int maxCount = 10 /* Metadata: 0x00B0D11E */, bool bSortByTotal = true /* Metadata: 0x00B0D122 */) {} // 0x0000000182700740-0x0000000182700B50
	// [XID] // 0x00000001899B7A20-0x00000001899B7A60
	public static List<string> ToStringList(this List<KeyValuePair<string, MMAField>> kvpList, int maxCount = 10 /* Metadata: 0x00B0D123 */, bool bSortByTotal = true /* Metadata: 0x00B0D127 */, Func<string, string> onGetAdditionalInfo = null, bool csvStrFormat = false /* Metadata: 0x00B0D128 */) => default; // 0x0000000182702B40-0x0000000182703020
	// [IDTag] // 0x00000001899C2430-0x00000001899C2480
	// [XID] // 0x00000001899C2430-0x00000001899C2480
	public static void Log(this Dictionary<string, MMAField> strCountMap, StatLog.IBufferLogger logger, int maxCount = 10 /* Metadata: 0x00B0D129 */, bool bSortByTotal = true /* Metadata: 0x00B0D12D */) {} // 0x0000000182700620-0x0000000182700740
	// [XID] // 0x00000001899CFC60-0x00000001899CFCA0
	public static void Accumulate(this Dictionary<string, MMAField> _stackTraceInsMap, string stackTraceStr, float milliSeconds) {} // 0x0000000182701A50-0x0000000182701C20
	// [IDTag] // 0x0000000189A22FB0-0x0000000189A23000
	// [XID] // 0x0000000189A22FB0-0x0000000189A23000
	public static void Log(this Dictionary<string, EffectLoadStruct> strCountMap, StatLog.IBufferLogger logger, int maxCount = 10 /* Metadata: 0x00B0D12E */) {} // 0x00000001826FFF60-0x0000000182700320
	// [XID] // 0x0000000189A300B0-0x0000000189A300F0
	public static void LogCSV(this Dictionary<string, EffectLoadStruct> strCountMap, StatLog.IBufferLogger logger) {} // 0x00000001826FF800-0x00000001826FFF60
}

