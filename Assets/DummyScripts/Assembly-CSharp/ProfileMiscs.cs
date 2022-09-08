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

public static class ProfileMiscs // TypeDefIndex: 27835
{
	// Nested types
	public struct MemoryProfilerTagger : IDisposable // TypeDefIndex: 27836
	{
		// Fields
		private long _startCount; // 0x00
		private long _threshold; // 0x08

		// Constructors
		public MemoryProfilerTagger(string inSectionName, long inThreshold = 0 /* Metadata: 0x00B0D00B */) {
			_startCount = default;
			_threshold = default;
		} // 0x0000000182F6AEF0-0x0000000182F6AF00

		// Methods
		// [XID] // 0x0000000189B5F470-0x0000000189B5F490
		public void Dispose() {} // 0x0000000182F6AE40-0x0000000182F6AEF0
	}

	public interface IMemorySizeFetcher // TypeDefIndex: 27837
	{
		// Methods
		long GetMemorySize();
	}

	public class MemorySizeFetcher_MonoTotal : IMemorySizeFetcher // TypeDefIndex: 27838
	{
		// Constructors
		public MemorySizeFetcher_MonoTotal() {} // 0x0000000182F8B580-0x0000000182F8B5E0

		// Methods
		// [XID] // 0x0000000189B66B00-0x0000000189B66B20
		public long GetMemorySize() => default; // 0x0000000182F8B4D0-0x0000000182F8B580
	}

	public class MemoryWatcher<T> : IDisposable // TypeDefIndex: 27839
		where T : IMemorySizeFetcher, new()
	{
		// Fields
		private long _startCount;
		private long _endCount;
		private long _thresholdCount;
		private string _sectionName;
		private long _currentIndentCount;
		private List<MemoryWatcher<T>> children;
		private static Stack<MemoryWatcher<T>> watcherStack;
		private static T memSizeFetcher;

		// Properties
		private long _deltaCount { get => default; }
		private long _selfCount { get => default; }
		private bool bOnlyProfilerMode { get => default; }

		// Constructors
		public MemoryWatcher() {} // Dummy constructor
		public MemoryWatcher(string inSectionName, long inThreshold = 0 /* Metadata: 0x00B0D013 */) {}
		static MemoryWatcher() {}

		// Methods
		private static long GetMonoMemory() => default;
		private static string JoinStr(params /* 0x000000018989F6F0-0x000000018989F700 */ string[] strs) => default;
		private string GetIndentStr() => default;
		private static string GetKBFromB(long inB) => default;
		private string GetDebugStr() => default;
		private void Print() {}
		public void Dispose() {}
	}

	public class MonoMemoryWatcher : MemoryWatcher<MemorySizeFetcher_MonoTotal> // TypeDefIndex: 27840
	{
		// Constructors
		public MonoMemoryWatcher() {} // Dummy constructor
		public MonoMemoryWatcher(string inSectionName, long inThreshold = 0 /* Metadata: 0x00B0D01B */) {} // 0x0000000182F68C00-0x0000000182F68CB0
	}

	// Methods
	// [XID] // 0x0000000189B45DB0-0x0000000189B45DD0
	public static int ListSortCompareDoubleDescending(double d1, double d2) => default; // 0x0000000182F7B5A0-0x0000000182F7B6E0
	// [XID] // 0x0000000189B4D1D0-0x0000000189B4D1F0
	public static int ListSortCompareFloatDescending(float d1, float d2) => default; // 0x0000000182F7B6E0-0x0000000182F7B810

	// Extension methods
	// [XID] // 0x0000000189B54A20-0x0000000189B54A60
	public static string GetTypeName(this object inObj) => default; // 0x0000000182F7B810-0x0000000182F7B8E0
}

