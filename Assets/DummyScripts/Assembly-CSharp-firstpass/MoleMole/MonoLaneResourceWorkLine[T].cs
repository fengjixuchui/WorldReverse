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
	public class MonoLaneResourceWorkLine<T> : QueueResourceWorkLine<T> // TypeDefIndex: 7411
		where T : ResourceJob
	{
		// Fields
		private readonly Queue<T> _waitQueue;
		private readonly int _workerCount;
	
		// Constructors
		public MonoLaneResourceWorkLine() {} // Dummy constructor
		public MonoLaneResourceWorkLine(int workerCount) {}
	
		// Methods
		public override void AddJob(T job) {}
		public override void Tick() {}
	}
}
