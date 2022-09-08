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
	public class QueueResourceWorkLine<T> : IResourceWorkLine // TypeDefIndex: 7414
		where T : ResourceJob
	{
		// Fields
		protected readonly Queue<T> _jobQueue;
		private int _watch;
	
		// Properties
		public virtual bool idle { get => default; }
		public virtual int activeCount { get => default; }
		public virtual int queueCount { get => default; }
		public virtual int count { get => default; }
		public string activeJobAndJobQueueInfo { get => default; }
	
		// Constructors
		public QueueResourceWorkLine() {} // Dummy constructor
		public QueueResourceWorkLine(float maxTime = 0f /* Metadata: 0x00ADE9A4 */) {}
	
		// Methods
		public virtual void AddJob(T job) {}
		public virtual void Terminate() {}
		public virtual void Tick() {}
		public TResult[] MapUndergoingJobs<TResult>(Func<T, TResult> selector) => default;
	}
}
