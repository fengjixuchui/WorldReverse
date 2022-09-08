/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public static class StatExtension // TypeDefIndex: 10088
	{
		// Fields
		public const int StatLODDetail = 0; // Metadata: 0x00AE6F19
		public const int StatLODComponent = 1; // Metadata: 0x00AE6F1D
		public const int StatLODModule = 2; // Metadata: 0x00AE6F21
		public const int StatLODManager = 3; // Metadata: 0x00AE6F25
		public const int StatLODMute = 4; // Metadata: 0x00AE6F29
		public const int StatLODTotal = 5; // Metadata: 0x00AE6F2D
		public static readonly string[] StatLODName; // 0x00
		public static int StatLOD; // 0x08
		public static int RequestStatLOD; // 0x0C
		private static int thisFrameStatCount; // 0x10
		private static MMAField sampleStatMMA; // 0x18
		private static int targetSampleStatFrameCount; // 0x40
		private static int currentSampleStatFrameCount; // 0x44
		private static Stopwatch _gStopWatch; // 0x48
		private static double millisecondsOverTick; // 0x50
		public static Action<UnityEngine.Object, float> onInstantiateObject; // 0x58
	
		// Properties
		public static long CycleTicks { /* [XID] */ /* 0x00000001896EA7C0-0x00000001896EA7E0 */ get; } // 0x00000001868AB940-0x00000001868ABA20 
		public static string EnvironmentStackTrace { /* [XID] */ /* 0x00000001899568E0-0x0000000189956900 */ get; } // 0x00000001868ABA20-0x00000001868ABB50 
	
		// Nested types
		public struct ScopeUnityProfilerSample : IDisposable // TypeDefIndex: 10089
		{
			// Fields
			private int _statLOD; // 0x00
	
			// Constructors
			public ScopeUnityProfilerSample(string sampleName, int inStatLOD = 0 /* Metadata: 0x00AE6F31 */) {
				_statLOD = default;
			} // 0x00000001868A17D0-0x00000001868A17E0
	
			// Methods
			// [XID] // 0x0000000189766210-0x0000000189766230
			public void Dispose() {} // 0x00000001868A16F0-0x00000001868A17D0
		}
	
		public struct ScopeUnityDoubleProfilerSample : IDisposable // TypeDefIndex: 10090
		{
			// Fields
			private int _statLOD; // 0x00
	
			// Constructors
			public ScopeUnityDoubleProfilerSample(string sampleName1, string sampleName2, int inStatLOD = 0 /* Metadata: 0x00AE6F35 */) {
				_statLOD = default;
			} // 0x00000001868A1400-0x00000001868A14D0
	
			// Methods
			// [XID] // 0x000000018976DAA0-0x000000018976DAC0
			public void Dispose() {} // 0x00000001868A1300-0x00000001868A1400
		}
	
		public struct ScopeUnityProfilerSampleThreadSafe : IDisposable // TypeDefIndex: 10091
		{
			// Fields
			private bool _hasSampled; // 0x00
	
			// Constructors
			public ScopeUnityProfilerSampleThreadSafe(string sampleName, int inStatLOD = 0 /* Metadata: 0x00AE6F39 */) {
				_hasSampled = default;
			} // 0x00000001868A15F0-0x00000001868A16F0
	
			// Methods
			// [XID] // 0x0000000189774F20-0x0000000189774F40
			public void Dispose() {} // 0x00000001868A14D0-0x00000001868A15F0
		}
	
		public struct ScopeUnityDoubleProfilerSampleThreadSafe : IDisposable // TypeDefIndex: 10092
		{
			// Fields
			private bool _hasSampled; // 0x00
	
			// Constructors
			public ScopeUnityDoubleProfilerSampleThreadSafe(string sampleName1, string sampleName2, int inStatLOD = 0 /* Metadata: 0x00AE6F3D */) {
				_hasSampled = default;
			} // 0x00000001868A11E0-0x00000001868A1300
	
			// Methods
			// [XID] // 0x000000018977C7C0-0x000000018977C7E0
			public void Dispose() {} // 0x00000001868A10D0-0x00000001868A11E0
		}
	
		public struct ScopeInstantiateSampler : IDisposable // TypeDefIndex: 10093
		{
			// Fields
			private UnityEngine.Object _original; // 0x00
			private long _cycleTicks; // 0x08
	
			// Constructors
			public ScopeInstantiateSampler(UnityEngine.Object original) {
				_original = default;
				_cycleTicks = default;
			} // 0x00000001868A0620-0x00000001868A0790
	
			// Methods
			// [XID] // 0x000000018999E910-0x000000018999E930
			public void Dispose() {} // 0x00000001868A0580-0x00000001868A0620
		}
	
		// Constructors
		static StatExtension() {} // 0x00000001868AB580-0x00000001868AB940
	
		// Methods
		// [XID] // 0x00000001898B9100-0x00000001898B9120
		public static void SwitchToNextLOD() {} // 0x00000001868AB300-0x00000001868AB3E0
		// [XID] // 0x0000000189837210-0x0000000189837230
		public static void SyncStatLOD() {} // 0x00000001868AB3E0-0x00000001868AB4A0
		// [XID] // 0x0000000189698510-0x0000000189698530
		public static bool ShouldSampleStat(int inStatLOD) => default; // 0x00000001868AB230-0x00000001868AB300
		// [XID] // 0x00000001899D5120-0x00000001899D5140
		private static void OnBeginSample() {} // 0x00000001868AAF80-0x00000001868AB040
		// [XID] // 0x00000001896A6A20-0x00000001896A6A40
		public static void OnFrameStart() {} // 0x00000001868AB040-0x00000001868AB230
		// [XID] // 0x00000001896B5660-0x00000001896B5680
		public static void ForceBeginSample(string sampleName) {} // 0x00000001868A9CA0-0x00000001868A9D70
		// [XID] // 0x00000001896B5740-0x00000001896B5760
		public static void ForceEndSample() {} // 0x00000001868A9D70-0x00000001868A9E10
		// [XID] // 0x00000001896BCAC0-0x00000001896BCAE0
		public static void BeginSample(string sampleName) {} // 0x00000001868A9AD0-0x00000001868A9BC0
		// [XID] // 0x00000001897F1220-0x00000001897F1240
		public static void EndSample() {} // 0x00000001868A9BC0-0x00000001868A9CA0
		// [XID] // 0x000000018992CE30-0x000000018992CE50
		public static long MillisecondsToTick(float inMS) => default; // 0x00000001868AAE70-0x00000001868AAF80
		// [IDTag] // 0x00000001896F17B0-0x00000001896F17F0
		// [XID] // 0x00000001896F17B0-0x00000001896F17F0
		public static long GetDeltaTicks(long inStartTick) => default; // 0x00000001868AA2D0-0x00000001868AA3B0
		// [IDTag] // 0x00000001896FC610-0x00000001896FC650
		// [XID] // 0x00000001896FC610-0x00000001896FC650
		public static long GetDeltaTicks(ref long inStartTick) => default; // 0x00000001868AA1F0-0x00000001868AA2D0
		// [IDTag] // 0x00000001897069C0-0x0000000189706A00
		// [XID] // 0x00000001897069C0-0x0000000189706A00
		public static double GetDeltaMilliseconds(Action inAction) => default; // 0x00000001868AA010-0x00000001868AA110
		// [XID] // 0x00000001897115C0-0x00000001897115E0
		public static double TickToMilliseconds(long inTick) => default; // 0x00000001868AB4A0-0x00000001868AB580
		// [IDTag] // 0x0000000189718A20-0x0000000189718A60
		// [XID] // 0x0000000189718A20-0x0000000189718A60
		public static double GetDeltaMilliseconds(long inStartTick) => default; // 0x00000001868A9E10-0x00000001868A9EF0
		// [XID] // 0x0000000189722F00-0x0000000189722F20
		public static double GetDeltaSeconds(long inStartTick) => default; // 0x00000001868AA110-0x00000001868AA1F0
		public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation)
			where T : UnityEngine.Object => default;
		public static T Instantiate<T>(T original, Transform parent, bool worldPositionStays)
			where T : UnityEngine.Object => default;
		public static T Instantiate<T>(T original, Transform parent)
			where T : UnityEngine.Object => default;
		public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, Transform parent)
			where T : UnityEngine.Object => default;
		public static T Instantiate<T>(T original)
			where T : UnityEngine.Object => default;
		// [IDTag] // 0x000000018972A610-0x000000018972A650
		// [XID] // 0x000000018972A610-0x000000018972A650
		public static UnityEngine.Object Instantiate(UnityEngine.Object original, Vector3 position, Quaternion rotation, Transform parent) => default; // 0x00000001868AA3B0-0x00000001868AA600
		// [IDTag] // 0x0000000189734D50-0x0000000189734D90
		// [XID] // 0x0000000189734D50-0x0000000189734D90
		public static UnityEngine.Object Instantiate(UnityEngine.Object original, Transform parent) => default; // 0x00000001868AABD0-0x00000001868AAD90
		// [IDTag] // 0x000000018973FBA0-0x000000018973FBE0
		// [XID] // 0x000000018973FBA0-0x000000018973FBE0
		public static UnityEngine.Object Instantiate(UnityEngine.Object original) => default; // 0x00000001868AA600-0x00000001868AA7C0
		// [IDTag] // 0x000000018974A150-0x000000018974A190
		// [XID] // 0x000000018974A150-0x000000018974A190
		public static UnityEngine.Object Instantiate(UnityEngine.Object original, Vector3 position, Quaternion rotation) => default; // 0x00000001868AA7C0-0x00000001868AA9F0
		// [IDTag] // 0x0000000189754810-0x0000000189754850
		// [XID] // 0x0000000189754810-0x0000000189754850
		public static UnityEngine.Object Instantiate(UnityEngine.Object original, Transform parent, bool instantiateInWorldSpace) => default; // 0x00000001868AA9F0-0x00000001868AABD0
	
		// Extension methods
		// [IDTag] // 0x00000001896CB410-0x00000001896CB460
		// [XID] // 0x00000001896CB410-0x00000001896CB460
		public static double GetDeltaMilliseconds(this Stopwatch sw, long inStartTick) => default; // 0x00000001868A9EF0-0x00000001868AA010
		// [XID] // 0x00000001896E0410-0x00000001896E0450
		public static bool IsDeltaTickLargerThanTarget(this Stopwatch sw, long inStartTick, long inTargetTick) => default; // 0x00000001868AAD90-0x00000001868AAE70
	}
}
