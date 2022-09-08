/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia.FullSerializer.Internal
{
	public struct fsOption<T> // TypeDefIndex: 9265
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
