/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UniRx;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class BenchmarkCommon // TypeDefIndex: 27627
{
	// Nested types
	private class GlobalElementDurabilityTestSpawner : IObjectPoolAllocator<GlobalElementDurability> // TypeDefIndex: 27628
	{
		// Constructors
		public GlobalElementDurabilityTestSpawner() {} // 0x0000000182E02670-0x0000000182E026D0

		// Methods
		// [XID] // 0x0000000189A1FEC0-0x0000000189A1FEE0
		public GlobalElementDurability Allocate() => default; // 0x0000000182E025B0-0x0000000182E02670
	}

	private class ElementDurabilityTestSpawner : IObjectPoolAllocator<ElementDurability> // TypeDefIndex: 27629
	{
		// Constructors
		public ElementDurabilityTestSpawner() {} // 0x0000000182E21400-0x0000000182E21460

		// Methods
		// [XID] // 0x0000000189A271F0-0x0000000189A27210
		public ElementDurability Allocate() => default; // 0x0000000182E21340-0x0000000182E21400
	}

	private class ActorModifierTestSpawner : IObjectPoolAllocator<ActorModifier> // TypeDefIndex: 27630
	{
		// Constructors
		public ActorModifierTestSpawner() {} // 0x0000000182E02550-0x0000000182E025B0

		// Methods
		// [XID] // 0x0000000189A2EA90-0x0000000189A2EAB0
		public ActorModifier Allocate() => default; // 0x0000000182E02490-0x0000000182E02550
	}

	private class AIKnowledgeTestSpawner : IObjectPoolAllocator<AIKnowledge> // TypeDefIndex: 27631
	{
		// Constructors
		public AIKnowledgeTestSpawner() {} // 0x0000000182E02310-0x0000000182E02370

		// Methods
		// [XID] // 0x0000000189A36380-0x0000000189A363A0
		public AIKnowledge Allocate() => default; // 0x0000000182E02250-0x0000000182E02310
	}

	private class List_Tuple_ActorModifier_TimerReceiver_TestSpawner : IObjectPoolAllocator<List<Tuple<ActorModifier, TimerReceiver>?>> // TypeDefIndex: 27632
	{
		// Constructors
		public List_Tuple_ActorModifier_TimerReceiver_TestSpawner() {} // 0x0000000182E02430-0x0000000182E02490

		// Methods
		// [XID] // 0x0000000189A3D940-0x0000000189A3D960
		public List<Tuple<ActorModifier, TimerReceiver>?> Allocate() => default; // 0x0000000182E02370-0x0000000182E02430
	}

	private class List_int_TestSpawner : IObjectPoolAllocator<List<int>> // TypeDefIndex: 27633
	{
		// Constructors
		public List_int_TestSpawner() {} // 0x0000000182E029D0-0x0000000182E02A30

		// Methods
		// [XID] // 0x0000000189A450A0-0x0000000189A450C0
		public List<int> Allocate() => default; // 0x0000000182E02910-0x0000000182E029D0
	}

	private class Dictionary_int_int_TestSpawner : IObjectPoolAllocator<Dictionary<int, int>> // TypeDefIndex: 27634
	{
		// Constructors
		public Dictionary_int_int_TestSpawner() {} // 0x0000000182E02790-0x0000000182E027F0

		// Methods
		// [XID] // 0x0000000189A4C800-0x0000000189A4C820
		public Dictionary<int, int> Allocate() => default; // 0x0000000182E026D0-0x0000000182E02790
	}

	private class HashSet_TimerReceiver_TestSpawner : IObjectPoolAllocator<HashSet<TimerReceiver>> // TypeDefIndex: 27635
	{
		// Constructors
		public HashSet_TimerReceiver_TestSpawner() {} // 0x0000000182E21D80-0x0000000182E21DE0

		// Methods
		// [XID] // 0x0000000189A53FE0-0x0000000189A54000
		public HashSet<TimerReceiver> Allocate() => default; // 0x0000000182E21CC0-0x0000000182E21D80
	}

	private class Dictionary_string_DynamicActorValue_float_TestSpawner : IObjectPoolAllocator<Dictionary<string, DynamicActorValue<float>>> // TypeDefIndex: 27636
	{
		// Constructors
		public Dictionary_string_DynamicActorValue_float_TestSpawner() {} // 0x0000000182E028B0-0x0000000182E02910

		// Methods
		// [XID] // 0x0000000189A5B9D0-0x0000000189A5B9F0
		public Dictionary<string, DynamicActorValue<float>> Allocate() => default; // 0x0000000182E027F0-0x0000000182E028B0
	}

	private struct GenericNewBenchmark // TypeDefIndex: 27637
	{
		// Fields
		public string typeName; // 0x00
		public double GenNewAndAllocateTime; // 0x08
		public double GenNewAndAllocateTimeWithAllocator; // 0x10
		public double DeallocateTime; // 0x18
		public double NewTime; // 0x20
		public double GenNewTime; // 0x28
		public double PureAllocateTime; // 0x30

		// Methods
		// [XID] // 0x0000000189A630C0-0x0000000189A630E0
		public static string ToCSVTitle() => default; // 0x0000000182E01950-0x0000000182E01DA0
		// [XID] // 0x0000000189A6AC40-0x0000000189A6AC60
		public string ToCSVString() => default; // 0x0000000182E01DA0-0x0000000182E01E70
	}

	public static class TestStaticClassSync<T> // TypeDefIndex: 27638
	{
		// Fields
		public static int k;
		public static T val;

		// Constructors
		static TestStaticClassSync() {}
	}

	public static class TestStaticClassNoSync<T> // TypeDefIndex: 27639
	{
		// Fields
		public static int k;
		public static T val;

		// Constructors
		static TestStaticClassNoSync() {}
	}

	public struct BenchmarkStaticLockCtorClass // TypeDefIndex: 27640
	{
		// Fields
		public bool bLock; // 0x00
		public double ms_100000; // 0x08
		public double ms_1000000; // 0x10

		// Methods
		// [XID] // 0x0000000189A722E0-0x0000000189A72300
		public static string ToCSVTitle() => default; // 0x0000000182E21AC0-0x0000000182E21CB0
		// [XID] // 0x0000000189A79F80-0x0000000189A79FA0
		public string ToCSVString() => default; // 0x0000000182E21CB0-0x0000000182E21CC0
		// [XID] // 0x0000000189A81420-0x0000000189A81440
		public static void Benchmark() {} // 0x0000000182E217B0-0x0000000182E21AC0
	}

	public struct BenchmarkSubType // TypeDefIndex: 27642
	{
		// Fields
		public bool AssignFrom; // 0x00
		public double ms_100000; // 0x08
		public double ms_1000000; // 0x10

		// Methods
		// [XID] // 0x0000000189AB5A90-0x0000000189AB5AB0
		public static string ToCSVTitle() => default; // 0x0000000182E20DD0-0x0000000182E20FC0
		// [XID] // 0x0000000189ABD4B0-0x0000000189ABD4D0
		public string ToCSVString() => default; // 0x0000000182E20FC0-0x0000000182E21010
		// [XID] // 0x0000000189AC4EC0-0x0000000189AC4EE0
		public static bool Benchmark() => default; // 0x0000000182E20AC0-0x0000000182E20DD0
	}

	public class TestAmortizeTick : IAmortizedTicker // TypeDefIndex: 27644
	{
		// Fields
		public static Func<int> _getFrameCount; // 0x00
		public static Action<int, IAmortizedTicker> injectFuncion; // 0x08
		private int _id; // 0x14
		public bool forbidInjectFunction; // 0x18

		// Properties
		public float lastTickTime { get; set; } // 0x0000000182E21260-0x0000000182E212D0 0x0000000182E212D0-0x0000000182E21340

		// Constructors
		public TestAmortizeTick() {} // Dummy constructor
		public TestAmortizeTick(int inID) {} // 0x0000000182E211E0-0x0000000182E21260

		// Methods
		// [XID] // 0x0000000189B13060-0x0000000189B13080
		public void AmortizedTick(float inDeltaTime) {} // 0x0000000182E21010-0x0000000182E211E0
	}

	// Methods
	// [XID] // 0x00000001899A75D0-0x00000001899A75F0
	private static void StatSamplerTester(int depth, int nodeStatCount, string statInfo) {} // 0x0000000182E17F20-0x0000000182E18090
	private static void TestReflection<T>(int count)
		where T : LCBase, new() {}
	private static T TestGenericNew<T>(int count, IObjectPoolAllocator<T> inSpawner, out GenericNewBenchmark inGBM)
		where T : class, new() {
		inGBM = default;
		return default;
	}
	// [XID] // 0x00000001899AEDC0-0x00000001899AEDE0
	public static void StartRecordProfilerData() {} // 0x0000000182E1A560-0x0000000182E1A610
	// [XID] // 0x00000001899B6140-0x00000001899B6160
	public static void StopRecordProfilerData() {} // 0x0000000182E1A4C0-0x0000000182E1A560
	// [XID] // 0x00000001899BDE60-0x00000001899BDE80
	private static string DumpProfilerDataToFile(string fileName) => default; // 0x0000000182E18AF0-0x0000000182E18C80
	// [XID] // 0x00000001899C55E0-0x00000001899C5600
	public static string DumpProfilerDataToLocalDisk() => default; // 0x0000000182E18090-0x0000000182E18190
	[DebuggerHidden] // 0x00000001899CCC70-0x00000001899CCCB0
	// [XID] // 0x00000001899CCC70-0x00000001899CCCB0
	public static IEnumerator DumpMultiContinousProfilerData(string profilerUID, int seconds, Action<string> onProcessFile) => default; // 0x0000000182E17DE0-0x0000000182E17F20
	// [XID] // 0x00000001899D7050-0x00000001899D7070
	public static void TestCaseSliceframeWatch(int testCount = 5 /* Metadata: 0x00B0CA9E */) {} // 0x0000000182E18360-0x0000000182E18AF0
	// [XID] // 0x00000001899DE580-0x00000001899DE5A0
	public static void TestEnumGC() {} // 0x0000000182E19DB0-0x0000000182E1A360
	// [XID] // 0x00000001899E6280-0x00000001899E62A0
	public static void TestSetLeveLStat(int i) {} // 0x0000000182E18190-0x0000000182E18280
	// [XID] // 0x00000001899ED650-0x00000001899ED670
	public static void TestPlayVideo(string videoPath) {} // 0x0000000182E18280-0x0000000182E18360
	// [XID] // 0x00000001899F51E0-0x00000001899F5200
	public static void TestStopVideo() {} // 0x0000000182E1B4F0-0x0000000182E1B5C0
	// [XID] // 0x00000001899FC7B0-0x00000001899FC7D0
	public static void TestAmortizeTickList() {} // 0x0000000182E1A610-0x0000000182E1B4F0
	// [XID] // 0x0000000189A03D60-0x0000000189A03D80
	public static bool OnConsoleCommand(string[] strs) => default; // 0x0000000182E18DE0-0x0000000182E19DB0
}

