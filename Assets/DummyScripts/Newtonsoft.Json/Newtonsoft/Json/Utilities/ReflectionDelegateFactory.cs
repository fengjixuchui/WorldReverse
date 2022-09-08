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
	internal abstract class ReflectionDelegateFactory // TypeDefIndex: 5298
	{
		// Constructors
		protected ReflectionDelegateFactory() {} // 0x0000000185E608E0-0x0000000185E60940
	
		// Methods
		public Func<T, object> CreateGet<T>(MemberInfo memberInfo) => default;
		public Action<T, object> CreateSet<T>(MemberInfo memberInfo) => default;
		public abstract MethodCall<T, object> CreateMethodCall<T>(MethodBase method);
		public abstract ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method);
		public abstract Func<T> CreateDefaultConstructor<T>(System.Type type);
		public abstract Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);
		public abstract Func<T, object> CreateGet<T>(FieldInfo fieldInfo);
		public abstract Action<T, object> CreateSet<T>(FieldInfo fieldInfo);
		public abstract Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);
	}
}
