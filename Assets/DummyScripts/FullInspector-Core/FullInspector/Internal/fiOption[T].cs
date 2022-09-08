/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector.Internal
{
	public struct fiOption<T> // TypeDefIndex: 5002
	{
		// Fields
		private bool _hasValue;
		private T _value;
		public static fiOption<T> Empty;
	
		// Properties
		public bool HasValue { get => default; }
		public bool IsEmpty { get => default; }
		public T Value { get => default; }
	
		// Constructors
		public fiOption(T value) : this() {
			_hasValue = default;
			_value = default;
		}
		static fiOption() {
			Empty = default;
		}
	}
}
