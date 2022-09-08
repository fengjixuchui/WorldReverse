/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Linq
{
	// [DefaultMember] // 0x0000000189B45780-0x0000000189B457C0
	[Preserve] // 0x0000000189B45780-0x0000000189B457C0
	public struct JEnumerable<T> : IJEnumerable<T>, IEquatable<Newtonsoft.Json.Linq.JEnumerable<T>> // TypeDefIndex: 5437
		where T : JToken
	{
		// Fields
		public static readonly JEnumerable<T> Empty;
		private readonly IEnumerable<T> _enumerable;
	
		// Constructors
		public JEnumerable(IEnumerable<T> enumerable) {
			_enumerable = default;
		}
		static JEnumerable() {
			Empty = default;
		}
	
		// Methods
		public IEnumerator<T> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public bool Equals(JEnumerable<T> other) => default;
		public override bool Equals(object obj) => default;
		public override int GetHashCode() => default;
	}
}
