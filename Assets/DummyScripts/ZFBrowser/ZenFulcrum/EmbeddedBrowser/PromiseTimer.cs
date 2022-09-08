/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.EmbeddedBrowser
{
	public class PromiseTimer : IPromiseTimer // TypeDefIndex: 6145
	{
		// Fields
		private float curTime; // 0x10
		private List<PredicateWait> waiting; // 0x18
	
		// Constructors
		public PromiseTimer() {} // 0x00000001856B9900-0x00000001856B9990
	
		// Methods
		public IPromise WaitFor(float seconds) => default; // 0x00000001856B9590-0x00000001856B96C0
		public IPromise WaitWhile(Func<TimeData, bool> predicate) => default; // 0x00000001856B97F0-0x00000001856B9900
		public IPromise WaitUntil(Func<TimeData, bool> predicate) => default; // 0x00000001856B96C0-0x00000001856B97F0
		public void Update(float deltaTime) {} // 0x00000001856B93B0-0x00000001856B9590
	}
}
