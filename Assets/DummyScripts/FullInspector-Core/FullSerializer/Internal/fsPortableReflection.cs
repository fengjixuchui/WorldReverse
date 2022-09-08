/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullSerializer.Internal
{
	public static class fsPortableReflection // TypeDefIndex: 4759
	{
		// Fields
		public static System.Type[] EmptyTypes; // 0x00
		private static IDictionary<AttributeQuery, Attribute> _cachedAttributeQueries; // 0x08
		private static BindingFlags DeclaredFlags; // 0x10
	
		// Nested types
		private struct AttributeQuery // TypeDefIndex: 4760
		{
			// Fields
			public MemberInfo MemberInfo; // 0x00
			public System.Type AttributeType; // 0x08
		}
	
		private class AttributeQueryComparator : IEqualityComparer<AttributeQuery> // TypeDefIndex: 4761
		{
			// Constructors
			public AttributeQueryComparator() {} // 0x0000000188DC5330-0x0000000188DC5390
	
			// Methods
			public bool Equals(AttributeQuery x, AttributeQuery y) => default; // 0x0000000188DC51D0-0x0000000188DC5270
			public int GetHashCode(AttributeQuery obj) => default; // 0x0000000188DC5270-0x0000000188DC5330
		}
	
		// Constructors
		static fsPortableReflection() {} // 0x0000000188DD8920-0x0000000188DD8A50
	
		// Methods
		public static bool HasAttribute(MemberInfo element, System.Type attributeType) => default; // 0x0000000188DD8770-0x0000000188DD8820
		public static bool HasAttribute<TAttribute>(MemberInfo element) => default;
		public static Attribute GetAttribute(MemberInfo element, System.Type attributeType, bool shouldCache) => default; // 0x0000000188DD7540-0x0000000188DD77D0
		public static TAttribute GetAttribute<TAttribute>(MemberInfo element, bool shouldCache)
			where TAttribute : Attribute => default;
		public static TAttribute GetAttribute<TAttribute>(MemberInfo element)
			where TAttribute : Attribute => default;
		public static MemberInfo AsMemberInfo(System.Type type) => default; // 0x0000000188DD7420-0x0000000188DD7480
		public static bool IsType(MemberInfo member) => default; // 0x0000000188DD8820-0x0000000188DD88C0
		public static System.Type AsType(MemberInfo member) => default; // 0x0000000188DD7480-0x0000000188DD7540
	
		// Extension methods
		public static PropertyInfo GetDeclaredProperty(this System.Type type, string propertyName) => default; // 0x0000000188DD7FA0-0x0000000188DD8100
		public static MethodInfo GetDeclaredMethod(this System.Type type, string methodName) => default; // 0x0000000188DD7CE0-0x0000000188DD7E40
		public static ConstructorInfo GetDeclaredConstructor(this System.Type type, System.Type[] parameters) => default; // 0x0000000188DD77D0-0x0000000188DD7970
		public static ConstructorInfo[] GetDeclaredConstructors(this System.Type type) => default; // 0x0000000188DD7970-0x0000000188DD7A20
		public static MemberInfo[] GetFlattenedMember(this System.Type type, string memberName) => default; // 0x0000000188DD8100-0x0000000188DD8320
		public static MethodInfo GetFlattenedMethod(this System.Type type, string methodName) => default; // 0x0000000188DD8320-0x0000000188DD84F0
		public static IEnumerable<MethodInfo> GetFlattenedMethods(this System.Type type, string methodName) => default; // 0x0000000188DD84F0-0x0000000188DD85A0
		public static PropertyInfo GetFlattenedProperty(this System.Type type, string propertyName) => default; // 0x0000000188DD85A0-0x0000000188DD8770
		public static MemberInfo GetDeclaredMember(this System.Type type, string memberName) => default; // 0x0000000188DD7AD0-0x0000000188DD7C30
		public static MethodInfo[] GetDeclaredMethods(this System.Type type) => default; // 0x0000000188DD7E40-0x0000000188DD7EF0
		public static PropertyInfo[] GetDeclaredProperties(this System.Type type) => default; // 0x0000000188DD7EF0-0x0000000188DD7FA0
		public static FieldInfo[] GetDeclaredFields(this System.Type type) => default; // 0x0000000188DD7A20-0x0000000188DD7AD0
		public static MemberInfo[] GetDeclaredMembers(this System.Type type) => default; // 0x0000000188DD7C30-0x0000000188DD7CE0
		public static System.Type Resolve(this System.Type type) => default; // 0x0000000188DD88C0-0x0000000188DD8920
	}
}
