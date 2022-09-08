/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public sealed class ThreadDispatcher // TypeDefIndex: 8832
	{
		// Fields
		public static readonly ThreadDispatcher Instance; // 0x00
		private MainThreadDispatcher mainThreadDispatcher; // 0x10
	
		// Nested types
		private sealed class MainThreadDispatcher : MonoBehaviour // TypeDefIndex: 8833
		{
			// Fields
			private object locker; // 0x18
			private List<Action> actions; // 0x20
	
			// Constructors
			public MainThreadDispatcher() {} // 0x0000000185A781B0-0x0000000185A78260
	
			// Methods
			// [XID] // 0x0000000189826F80-0x0000000189826FA0
			public void DispatchToMainThread(Action action) {} // 0x0000000185A77E10-0x0000000185A77F50
			// [XID] // 0x000000018982E4F0-0x000000018982E510
			private void Update() {} // 0x0000000185A77F50-0x0000000185A781B0
		}
	
		// Constructors
		private ThreadDispatcher() {} // 0x0000000185A8A930-0x0000000185A8A9F0
		static ThreadDispatcher() {} // 0x0000000185A8A8B0-0x0000000185A8A930
	
		// Methods
		// [IDTag] // 0x000000018980A8D0-0x000000018980A910
		// [XID] // 0x000000018980A8D0-0x000000018980A910
		public void RunAsync(Action action) {} // 0x0000000185A8A6A0-0x0000000185A8A7F0
		// [IDTag] // 0x0000000189814D30-0x0000000189814D70
		// [XID] // 0x0000000189814D30-0x0000000189814D70
		public void RunAsync(Action<object> action, object state) {} // 0x0000000185A8A530-0x0000000185A8A6A0
		// [XID] // 0x000000018981F8D0-0x000000018981F8F0
		public void RunOnMainThread(Action action) {} // 0x0000000185A8A7F0-0x0000000185A8A8B0
	}
}
