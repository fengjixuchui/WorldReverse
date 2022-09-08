/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	internal class ThreadSafeStore<TKey, TValue> // TypeDefIndex: 5315
	{
		// Fields
		private readonly object _lock;
		private Dictionary<TKey, TValue> _store;
		private readonly Func<TKey, TValue> _creator;
	
		// Constructors
		public ThreadSafeStore() {} // Dummy constructor
		[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
		public ThreadSafeStore(Func<TKey, TValue> creator) {}
	
		// Methods
		[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
		public TValue Get(TKey key) => default;
		[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
		private TValue AddValue(TKey key) => default;
	}
}
