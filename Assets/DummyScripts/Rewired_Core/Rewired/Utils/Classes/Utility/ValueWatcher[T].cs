/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
	[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
	internal sealed class ValueWatcher<T> : ValueWatcher // TypeDefIndex: 4406
	{
		// Fields
		private static IEqualityComparer<T> RwMbRKuOdanOLkRGMSxgLZQPfw;
		private bool hJRNrDQZRVunSwslcVFpjuAEhcL;
		private T FAoORBrTWqKCGNyMiKXRtudTOgk;
		private bool ZfkrYaysGyJEDcOwJpSxzjCUQKy;
		private Func<T> qCNjWQjjyXaFJLnKeFHRLSgIIuze;
		private Action<T> uUlXBBxcvOZIgMswkbNgOjHWaug;
	
		// Properties
		public Func<T> getValueDelegate { set {} }
		public T value { get => default; }
	
		// Events
		public event Action<T> ChangedEvent;
	
		// Constructors
		public ValueWatcher() {} // Dummy constructor
		public ValueWatcher(T initialValue, bool autoTriggerEvent) {}
		public ValueWatcher(T initialValue, Func<T> getValueDelegate, bool autoTriggerEvent) {}
		static ValueWatcher() {}
	
		// Methods
		public override bool Update() => default;
		public override bool Use() => default;
		public override bool TriggerEvent() => default;
		public bool Set(T value) => default;
	}
}
