/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	internal class DynamicReflectionDelegateFactory : ReflectionDelegateFactory // TypeDefIndex: 5292
	{
		// Fields
		public static DynamicReflectionDelegateFactory Instance; // 0x00
	
		// Constructors
		public DynamicReflectionDelegateFactory() {} // 0x0000000185E53D80-0x0000000185E53E20
		static DynamicReflectionDelegateFactory() {} // 0x0000000185E53D00-0x0000000185E53D80
	
		// Methods
		private static DynamicMethod CreateDynamicMethod(string name, System.Type returnType, System.Type[] parameterTypes, System.Type owner) => default; // 0x0000000185E52760-0x0000000185E52890
		public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method) => default; // 0x0000000185E52890-0x0000000185E52AC0
		public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method) => default;
		private void GenerateCreateMethodCallIL(MethodBase method, ILGenerator generator, int argsIndex) {} // 0x0000000185E53040-0x0000000185E539D0
		public override Func<T> CreateDefaultConstructor<T>(System.Type type) => default;
		private void GenerateCreateDefaultConstructorIL(System.Type type, ILGenerator generator) {} // 0x0000000185E52AC0-0x0000000185E52D30
		public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo) => default;
		private void GenerateCreateGetPropertyIL(PropertyInfo propertyInfo, ILGenerator generator) {} // 0x0000000185E52EA0-0x0000000185E53040
		public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo) => default;
		private void GenerateCreateGetFieldIL(FieldInfo fieldInfo, ILGenerator generator) {} // 0x0000000185E52D30-0x0000000185E52EA0
		public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo) => default;
		internal static void GenerateCreateSetFieldIL(FieldInfo fieldInfo, ILGenerator generator) {} // 0x0000000185E539D0-0x0000000185E53B90
		public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo) => default;
		internal static void GenerateCreateSetPropertyIL(PropertyInfo propertyInfo, ILGenerator generator) {} // 0x0000000185E53B90-0x0000000185E53D00
	}
}
