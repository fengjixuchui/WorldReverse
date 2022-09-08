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

public class BMSliceFrameJobScheduler // TypeDefIndex: 27619
{
	// Fields
	public List<Job> jobs; // 0x10
	private const float totalWorkloadUpgrade = 65f; // Metadata: 0x00B0CA95
	private JobWorkload[] testLeastWorkloadUpgrade1; // 0x18
	private JobWorkload[] testLeastWorkloadVariance1; // 0x20

	// Nested types
	public class JobWorkload // TypeDefIndex: 27620
	{
		// Fields
		public int count; // 0x10
		public int singleMS; // 0x14
		public int remainingCount; // 0x18

		// Constructors
		public JobWorkload() {} // Dummy constructor
		public JobWorkload(int inCount, int inSingleMS) {} // 0x00000001826CCAC0-0x00000001826CCB50

		// Methods
		// [XID] // 0x0000000189909730-0x0000000189909750
		public bool HasJobToDo() => default; // 0x00000001826CC670-0x00000001826CC720
		// [XID] // 0x0000000189910C60-0x0000000189910C80
		public bool FetchOneJob() => default; // 0x00000001826CC7C0-0x00000001826CC870
		// [XID] // 0x00000001899187E0-0x0000000189918800
		public void Reset() {} // 0x00000001826CC720-0x00000001826CC7C0
		// [XID] // 0x000000018991FF80-0x000000018991FFA0
		public override string ToString() => default; // 0x00000001826CC970-0x00000001826CCAC0
		// [XID] // 0x00000001899277E0-0x0000000189927800
		public static bool IsAllWorkloadFinished(JobWorkload[] inWorkloads) => default; // 0x00000001826CC870-0x00000001826CC970
	}

	public class Job : IDisposable // TypeDefIndex: 27621
	{
		// Fields
		public string name; // 0x10
		public float budget; // 0x18
		public int watchHandle; // 0x1C
		private bool forceFinshAllJob; // 0x20

		// Properties
		public double remainMS { /* [XID] */ /* 0x00000001899363D0-0x00000001899363F0 */ get => default; } // 0x00000001826AB6D0-0x00000001826AB7F0 

		// Constructors
		public Job() {} // Dummy constructor
		public Job(string inName, float inBudget, int inWatchHandle = 0 /* Metadata: 0x00B0CA99 */, bool inforceFinshAllJob = false /* Metadata: 0x00B0CA9D */) {} // 0x00000001826ABB20-0x00000001826ABC00

		// Methods
		// [XID] // 0x000000018992EFA0-0x000000018992EFC0
		public void Dispose() {} // 0x00000001826AB600-0x00000001826AB6D0
		// [XID] // 0x000000018993DE00-0x000000018993DE20
		public int ExecuteWorkload(JobWorkload inWorkload, bool forceSyncPass, bool consumeWorkload) => default; // 0x00000001826AB7F0-0x00000001826ABA10
		// [XID] // 0x00000001899454D0-0x00000001899454F0
		public override string ToString() => default; // 0x00000001826ABA10-0x00000001826ABB20
	}

	public class WatchCollector // TypeDefIndex: 27622
	{
		// Fields
		private HashSet<int> _collectedHandles; // 0x10

		// Properties
		public double TotalWatch { /* [XID] */ /* 0x000000018995B9D0-0x000000018995B9F0 */ get => default; } // 0x00000001826CC2A0-0x00000001826CC4A0 

		// Constructors
		public WatchCollector() {} // 0x00000001826CC570-0x00000001826CC600

		// Methods
		// [XID] // 0x000000018994CA40-0x000000018994CA60
		public void CollectWatch(int watchHandle) {} // 0x00000001826CC4A0-0x00000001826CC570
		// [XID] // 0x0000000189954100-0x0000000189954120
		public void CollectWatches(IEnumerable<Job> inJobs) {} // 0x00000001826CC0C0-0x00000001826CC2A0
	}

	public class JobExecutionFrameHistory // TypeDefIndex: 27623
	{
		// Fields
		public double configedWatchMS; // 0x10
		public double totalMS; // 0x18

		// Constructors
		public JobExecutionFrameHistory() {} // 0x00000001826CCF60-0x00000001826CCFC0

		// Methods
		// [XID] // 0x0000000189963540-0x0000000189963560
		public static void CheckFrameHistory(List<JobExecutionFrameHistory> histories) {} // 0x00000001826CCB50-0x00000001826CCF60
	}

	// Constructors
	public BMSliceFrameJobScheduler() {} // 0x00000001826CA5B0-0x00000001826CACA0

	// Methods
	// [XID] // 0x000000018989FD70-0x000000018989FD90
	private void Execute(JobWorkload[] inWorkloads, int round, bool forceSyncPass, bool consumeWorkload, WatchCollector inCollector, JobExecutionFrameHistory history = null) {} // 0x00000001826C8050-0x00000001826C86D0
	// [XID] // 0x00000001898A7720-0x00000001898A7740
	private static void DebugPrintCaseEntry(string name, float totalWorkloadUpgrade) {} // 0x00000001826C86D0-0x00000001826C8820
	// [XID] // 0x00000001898AF0C0-0x00000001898AF0E0
	private IEnumerable<Job> GenerateJobCluster(params /* 0x000000018989F6F0-0x000000018989F700 */ Job[] inJobs) => default; // 0x00000001826C8DA0-0x00000001826C8E90
	// [XID] // 0x00000001898BDDE0-0x00000001898BDE00
	private WatchCollector PrepareTest(IEnumerable<Job> toAddNewJobs, float inTotalWorkloadUpgrade, string inCaseName) => default; // 0x00000001826C8E90-0x00000001826C9010
	// [XID] // 0x00000001898C5680-0x00000001898C56A0
	private void SimulateEveryFrameExecuteJobs(int iterCount, JobWorkload[] workloads, bool forceSyncPass, bool consumeWorkload, WatchCollector collector) {} // 0x00000001826C93E0-0x00000001826C9690
	// [XID] // 0x00000001898CCCC0-0x00000001898CCCE0
	private void TestLeastWorkloadUpgrade() {} // 0x00000001826C9830-0x00000001826C9B40
	// [XID] // 0x00000001898D4620-0x00000001898D4640
	private void TestLeastWorkloadUpgradeSharedWatch(bool forceSyncPass) {} // 0x00000001826C9010-0x00000001826C93E0
	// [XID] // 0x00000001898DBF40-0x00000001898DBF60
	private void DiposeAllJobs() {} // 0x00000001826C8820-0x00000001826C89D0
	// [XID] // 0x00000001898E39C0-0x00000001898E39E0
	private void TestWatchUpgrade() {} // 0x00000001826C9690-0x00000001826C9740
	// [XID] // 0x00000001898EB5E0-0x00000001898EB600
	private void TestOverheadWorkloadWithVarianceStatMore() {} // 0x00000001826C89D0-0x00000001826C8DA0
	// [XID] // 0x00000001898F2E10-0x00000001898F2E30
	private void TestOverheadWorkloadWithVarianceStatLess() {} // 0x00000001826CA190-0x00000001826CA5B0
	// [XID] // 0x00000001898FA4F0-0x00000001898FA510
	private void TestScopeWatch() {} // 0x00000001826C9B40-0x00000001826CA190
	// [XID] // 0x0000000189901EE0-0x0000000189901F00
	public void Benchmark(int mode) {} // 0x00000001826C9740-0x00000001826C9830
}

