/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public class DynamicValueProvider : IValueProvider // TypeDefIndex: 5363
	{
		// Fields
		private readonly MemberInfo _memberInfo; // 0x10
		private Func<object, object> _getter; // 0x18
		private Action<object, object> _setter; // 0x20
	
		// Constructors
		public DynamicValueProvider() {} // Dummy constructor
		public DynamicValueProvider(MemberInfo memberInfo) {} // 0x0000000186348DE0-0x0000000186348E70
	
		// Methods
		public void SetValue(object target, object value) {} // 0x0000000186348C20-0x0000000186348DE0
		public object GetValue(object target) => default; // 0x0000000186348A60-0x0000000186348C20
	}
}
