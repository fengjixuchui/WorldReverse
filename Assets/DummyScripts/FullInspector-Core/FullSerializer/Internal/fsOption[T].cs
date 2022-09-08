/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullSerializer.Internal
{
	public struct fsOption<T> // TypeDefIndex: 4757
	{
		// Fields
		private bool _hasValue;
		private T _value;
		public static fsOption<T> Empty;
	
		// Properties
		public bool HasValue { get => default; }
		public bool IsEmpty { get => default; }
		public T Value { get => default; }
	
		// Constructors
		public fsOption(T value) : this() {
			_hasValue = default;
			_value = default;
		}
	}
}
