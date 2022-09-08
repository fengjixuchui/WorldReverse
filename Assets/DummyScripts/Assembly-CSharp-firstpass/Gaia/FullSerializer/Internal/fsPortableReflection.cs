/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia.FullSerializer.Internal
{
	public static class fsPortableReflection // TypeDefIndex: 9267
	{
		// Fields
		public static System.Type[] EmptyTypes; // 0x00
		private static IDictionary<AttributeQuery, Attribute> _cachedAttributeQueries; // 0x08
		private static BindingFlags DeclaredFlags; // 0x10
	
		// Nested types
		private struct AttributeQuery // TypeDefIndex: 9268
		{
			// Fields
			public MemberInfo MemberInfo; // 0x00
			public System.Type AttributeType; // 0x08
		}
	
		private class AttributeQueryComparator : IEqualityComparer<AttributeQuery> // TypeDefIndex: 9269
		{
			// Constructors
			public AttributeQueryComparator() {} // 0x00000001865870C0-0x0000000186587140
	
			// Methods
			// [XID] // 0x00000001899FAA30-0x00000001899FAA50
			public bool Equals(AttributeQuery x, AttributeQuery y) => default; // 0x0000000186586ED0-0x0000000186586FC0
			// [XID] // 0x0000000189A01B80-0x0000000189A01BA0
			public int GetHashCode(AttributeQuery obj) => default; // 0x0000000186586FC0-0x00000001865870C0
		}
	
		// Constructors
		static fsPortableReflection() {} // 0x000000018659F2F0-0x000000018659F420
	
		// Methods
		// [XID] // 0x000000018993EF80-0x000000018993EFA0
		public static bool HasAttribute(MemberInfo element, System.Type attributeType) => default; // 0x000000018659F070-0x000000018659F160
		public static bool HasAttribute<TAttribute>(MemberInfo element) => default;
		// [XID] // 0x000000018990F030-0x000000018990F050
		public static Attribute GetAttribute(MemberInfo element, System.Type attributeType, bool shouldCache) => default; // 0x000000018659D9F0-0x000000018659DCD0
		public static TAttribute GetAttribute<TAttribute>(MemberInfo element, bool shouldCache)
			where TAttribute : Attribute => default;
		public static TAttribute GetAttribute<TAttribute>(MemberInfo element)
			where TAttribute : Attribute => default;
		// [XID] // 0x0000000189943430-0x0000000189943450
		public static MemberInfo AsMemberInfo(System.Type type) => default; // 0x000000018659D8A0-0x000000018659D940
		// [XID] // 0x00000001899E10A0-0x00000001899E10C0
		public static bool IsType(MemberInfo member) => default; // 0x000000018659F160-0x000000018659F250
		// [XID] // 0x00000001899E8B70-0x00000001899E8B90
		public static System.Type AsType(MemberInfo member) => default; // 0x000000018659D940-0x000000018659D9F0
	
		// Extension methods
		// [XID] // 0x000000018994DC80-0x000000018994DCC0
		public static PropertyInfo GetDeclaredProperty(this System.Type type, string propertyName) => default; // 0x000000018659E6D0-0x000000018659E880
		// [XID] // 0x0000000189958640-0x0000000189958680
		public static MethodInfo GetDeclaredMethod(this System.Type type, string methodName) => default; // 0x000000018659E340-0x000000018659E4F0
		// [XID] // 0x0000000189962F80-0x0000000189962FC0
		public static ConstructorInfo GetDeclaredConstructor(this System.Type type, System.Type[] parameters) => default; // 0x000000018659DCD0-0x000000018659DEC0
		// [XID] // 0x000000018996D310-0x000000018996D350
		public static ConstructorInfo[] GetDeclaredConstructors(this System.Type type) => default; // 0x000000018659DEC0-0x000000018659DFB0
		// [XID] // 0x00000001899780C0-0x0000000189978100
		public static MemberInfo[] GetFlattenedMember(this System.Type type, string memberName) => default; // 0x000000018659E880-0x000000018659EB00
		// [XID] // 0x00000001899827E0-0x0000000189982820
		public static MethodInfo GetFlattenedMethod(this System.Type type, string methodName) => default; // 0x000000018659EB00-0x000000018659ED20
		[DebuggerHidden] // 0x000000018998CD40-0x000000018998CD80
		// [XID] // 0x000000018998CD40-0x000000018998CD80
		public static IEnumerable<MethodInfo> GetFlattenedMethods(this System.Type type, string methodName) => default; // 0x000000018659ED20-0x000000018659EE50
		// [XID] // 0x000000018999ACD0-0x000000018999AD10
		public static PropertyInfo GetFlattenedProperty(this System.Type type, string propertyName) => default; // 0x000000018659EE50-0x000000018659F070
		// [XID] // 0x00000001899A54F0-0x00000001899A5530
		public static MemberInfo GetDeclaredMember(this System.Type type, string memberName) => default; // 0x000000018659E0A0-0x000000018659E250
		// [XID] // 0x00000001899AFE30-0x00000001899AFE70
		public static MethodInfo[] GetDeclaredMethods(this System.Type type) => default; // 0x000000018659E4F0-0x000000018659E5E0
		// [XID] // 0x00000001899BA360-0x00000001899BA3A0
		public static PropertyInfo[] GetDeclaredProperties(this System.Type type) => default; // 0x000000018659E5E0-0x000000018659E6D0
		// [XID] // 0x00000001899C4E90-0x00000001899C4ED0
		public static FieldInfo[] GetDeclaredFields(this System.Type type) => default; // 0x000000018659DFB0-0x000000018659E0A0
		// [XID] // 0x00000001899CF5E0-0x00000001899CF620
		public static MemberInfo[] GetDeclaredMembers(this System.Type type) => default; // 0x000000018659E250-0x000000018659E340
		// [XID] // 0x00000001899F0340-0x00000001899F0380
		public static System.Type Resolve(this System.Type type) => default; // 0x000000018659F250-0x000000018659F2F0
	}
}
