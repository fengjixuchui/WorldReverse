/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory // TypeDefIndex: 5299
	{
		// Fields
		private static readonly LateBoundReflectionDelegateFactory _instance; // 0x00
	
		// Properties
		internal static ReflectionDelegateFactory Instance { get => default; } // 0x0000000185E5EBC0-0x0000000185E5EC50 
	
		// Constructors
		public LateBoundReflectionDelegateFactory() {} // 0x0000000185E5EB20-0x0000000185E5EBC0
		static LateBoundReflectionDelegateFactory() {} // 0x0000000185E5EAA0-0x0000000185E5EB20
	
		// Methods
		public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method) => default; // 0x0000000185E5E930-0x0000000185E5EAA0
		public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method) => default;
		public override Func<T> CreateDefaultConstructor<T>(System.Type type) => default;
		public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo) => default;
		public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo) => default;
		public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo) => default;
		public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo) => default;
	}
}
