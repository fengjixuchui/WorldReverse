/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public abstract class ResourceWorkLine<T> : IResourceWorkLine // TypeDefIndex: 7417
		where T : ResourceJob
	{
		// Fields
		protected const int DEFAULT_JOB_START_LIMIT = 120; // Metadata: 0x00ADE9A8
		protected const int MINIMUM_JOB_START_LIMIT = 1; // Metadata: 0x00ADE9AC
		protected const float DEFAULT_TICK_TIME_LIMIT = -1f; // Metadata: 0x00ADE9B0
		protected const float TARGET_MAX_PROCESS_TIME = 0.033f; // Metadata: 0x00ADE9B4
		private readonly T[] _undergoingJobs;
		protected readonly HashList<T> _asyncJobs;
		private SliceFrameWatch _sliceFrameWatch;
		private int _maxJobStartPerFrame;
		private int _activeJobCount;
		private int _lastTickCount;
		private int _shareWatch;
	
		// Properties
		public int shareWatch { get; }
		public virtual bool idle { get; }
		protected abstract bool noJobWaiting { get; }
		protected T[] undergoingJobs { get; }
		protected HashList<T> asyncJobs { get; }
		public virtual int activeCount { get; }
		public abstract int queueCount { get; }
		public virtual int count { get; }
		public string activeJobAndJobQueueInfo { get; }
	
		// Constructors
		protected ResourceWorkLine() {} // Dummy constructor
		public ResourceWorkLine(int workerCount, int maxJobStartPerFrame, float minTickTimeLimit, float maxTickTimeLimit) {}
		public ResourceWorkLine(int workerCount, int maxJobStartPerFrame) {}
		public ResourceWorkLine(int workerCount, float minTickTimeLimit, float maxTickTimeLimit) {}
		public ResourceWorkLine(int workerCount) {}
	
		// Methods
		public void AddBefore(T prev, T job) {}
		public virtual void Tick() {}
		private void Work(SliceFrameWatch targetSliceFrameWatch) {}
		public virtual void Terminate() {}
		public virtual void Sync(T job) {}
		public abstract void DropQueued();
		protected abstract bool StartNextTickingJob(out T job, int nJobStartAllow, SliceFrameWatch stopwatch, out int nJobStarted, out bool hasExceedTime);
		public TResult[] MapUndergoingJobs<TResult>(Func<T, TResult> selector) => default;
	}
}
