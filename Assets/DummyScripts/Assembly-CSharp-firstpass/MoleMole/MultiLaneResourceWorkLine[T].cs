/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class MultiLaneResourceWorkLine<T> : ResourceWorkLine<T> // TypeDefIndex: 7412
		where T : ResourceJob
	{
		// Fields
		private readonly Dictionary<int, Queue<T>> _queueLut;
		private readonly LinkedQueue _queueHead;
	
		// Properties
		protected override bool noJobWaiting { get => default; }
		public override int queueCount { get => default; }
	
		// Nested types
		private class LinkedQueue // TypeDefIndex: 7413
		{
			// Fields
			private readonly Queue<T> _queue;
	
			// Properties
			public Queue<T> queue { get => default; }
			public LinkedQueue<T> next { get; set; }
	
			// Constructors
			public LinkedQueue() {}
		}
	
		// Constructors
		public MultiLaneResourceWorkLine() {} // Dummy constructor
		public MultiLaneResourceWorkLine(int workerCount, int maxJobStartPerFrame, float minTickTimeLimit, float maxTickTimeLimit, System.Type priorityEnumType) {}
		public MultiLaneResourceWorkLine(int workerCount, int maxJobStartPerFrame, System.Type priorityEnumType) {}
		public MultiLaneResourceWorkLine(int workerCount, float minTickTimeLimit, float maxTickTimeLimit, System.Type priorityEnumType) {}
		public MultiLaneResourceWorkLine(int workerCount, System.Type priorityEnumType) {}
	
		// Methods
		public bool CheckHandle(uint handle) => default;
		public void AddJob(T job, int priority) {}
		public override void DropQueued() {}
		protected override bool StartNextTickingJob(out T job, int nJobStartAllow, SliceFrameWatch stopwatch, out int nJobStarted, out bool hasExceedTime) {
			job = default;
			nJobStarted = default;
			hasExceedTime = default;
			return default;
		}
	}
}
