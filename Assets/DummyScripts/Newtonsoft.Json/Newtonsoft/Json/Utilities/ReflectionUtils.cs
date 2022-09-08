/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Security;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x0000000189B2BE30-0x0000000189B2BE60
	internal static class ReflectionUtils // TypeDefIndex: 5342
	{
		// Fields
		public static readonly System.Type[] EmptyTypes; // 0x00
	
		// Constructors
		static ReflectionUtils() {} // 0x0000000185E65800-0x0000000185E658A0
	
		// Methods
		public static bool IsPublic(PropertyInfo property) => default; // 0x0000000185E65100-0x0000000185E651E0
		public static System.Type GetObjectType(object v) => default; // 0x0000000185E64020-0x0000000185E64090
		public static string GetTypeName(System.Type t, FormatterAssemblyStyle assemblyFormat, SerializationBinder binder) => default; // 0x0000000185E64330-0x0000000185E64430
		private static string RemoveAssemblyDetails(string fullyQualifiedTypeName) => default; // 0x0000000185E652A0-0x0000000185E65410
		public static bool HasDefaultConstructor(System.Type t, bool nonPublic) => default; // 0x0000000185E64430-0x0000000185E64500
		public static ConstructorInfo GetDefaultConstructor(System.Type t) => default; // 0x0000000185E62CB0-0x0000000185E62D40
		public static ConstructorInfo GetDefaultConstructor(System.Type t, bool nonPublic) => default; // 0x0000000185E62B40-0x0000000185E62CB0
		public static bool IsNullable(System.Type t) => default; // 0x0000000185E64E60-0x0000000185E64F10
		public static bool IsNullableType(System.Type t) => default; // 0x0000000185E64D70-0x0000000185E64E60
		public static System.Type EnsureNotNullableType(System.Type t) => default; // 0x0000000185E61C20-0x0000000185E61CC0
		public static bool IsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition) => default; // 0x0000000185E64B40-0x0000000185E64BE0
		public static bool ImplementsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition) => default; // 0x0000000185E64500-0x0000000185E645B0
		public static bool ImplementsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition, out System.Type implementingType) {
			implementingType = default;
			return default;
		} // 0x0000000185E645B0-0x0000000185E64800
		public static bool InheritsGenericDefinition(System.Type type, System.Type genericClassDefinition) => default; // 0x0000000185E64920-0x0000000185E649D0
		public static bool InheritsGenericDefinition(System.Type type, System.Type genericClassDefinition, out System.Type implementingType) {
			implementingType = default;
			return default;
		} // 0x0000000185E649D0-0x0000000185E64B40
		private static bool InheritsGenericDefinitionInternal(System.Type currentType, System.Type genericClassDefinition, out System.Type implementingType) {
			implementingType = default;
			return default;
		} // 0x0000000185E64800-0x0000000185E64920
		public static System.Type GetCollectionItemType(System.Type type) => default; // 0x0000000185E62860-0x0000000185E62B40
		public static void GetDictionaryKeyValueTypes(System.Type dictionaryType, out System.Type keyType, out System.Type valueType) {
			keyType = default;
			valueType = default;
		} // 0x0000000185E63000-0x0000000185E632D0
		public static System.Type GetMemberUnderlyingType(MemberInfo member) => default; // 0x0000000185E63B80-0x0000000185E63D70
		public static bool IsIndexedProperty(MemberInfo member) => default; // 0x0000000185E64C80-0x0000000185E64D70
		public static bool IsIndexedProperty(PropertyInfo property) => default; // 0x0000000185E64BE0-0x0000000185E64C80
		public static object GetMemberValue(MemberInfo member, object target) => default; // 0x0000000185E63D70-0x0000000185E64020
		public static void SetMemberValue(MemberInfo member, object target, object value) {} // 0x0000000185E65490-0x0000000185E65680
		public static bool CanReadMemberValue(MemberInfo member, bool nonPublic) => default; // 0x0000000185E619D0-0x0000000185E61AE0
		public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly) => default; // 0x0000000185E61AE0-0x0000000185E61C20
		public static List<MemberInfo> GetFieldsAndProperties(System.Type type, BindingFlags bindingAttr) => default; // 0x0000000185E632D0-0x0000000185E637E0
		private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr) => default; // 0x0000000185E64F10-0x0000000185E65100
		public static T GetAttribute<T>(object attributeProvider)
			where T : Attribute => default;
		public static T GetAttribute<T>(object attributeProvider, bool inherit)
			where T : Attribute => default;
		public static T[] GetAttributes<T>(object attributeProvider, bool inherit)
			where T : Attribute => default;
		public static Attribute[] GetAttributes(object attributeProvider, System.Type attributeType, bool inherit) => default; // 0x0000000185E61DA0-0x0000000185E62220
		public static void SplitFullyQualifiedTypeName(string fullyQualifiedTypeName, out string typeName, out string assemblyName) {
			typeName = default;
			assemblyName = default;
		} // 0x0000000185E65680-0x0000000185E65800
		private static int? GetAssemblyDelimiterIndex(string fullyQualifiedTypeName) => default; // 0x0000000185E61CC0-0x0000000185E61DA0
		public static MemberInfo GetMemberInfoFromType(System.Type targetType, MemberInfo memberInfo) => default; // 0x0000000185E63910-0x0000000185E63B80
		public static IEnumerable<FieldInfo> GetFields(System.Type targetType, BindingFlags bindingAttr) => default; // 0x0000000185E637E0-0x0000000185E63910
		private static void GetChildPrivateFields(IList<MemberInfo> initialFields, System.Type targetType, BindingFlags bindingAttr) {} // 0x0000000185E622E0-0x0000000185E62510
		public static IEnumerable<PropertyInfo> GetProperties(System.Type targetType, BindingFlags bindingAttr) => default; // 0x0000000185E64090-0x0000000185E64330
		private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, System.Type targetType, BindingFlags bindingAttr) {} // 0x0000000185E62510-0x0000000185E62860
		public static object GetDefaultValue(System.Type type) => default; // 0x0000000185E62D40-0x0000000185E63000
	
		// Extension methods
		public static bool IsVirtual(this PropertyInfo propertyInfo) => default; // 0x0000000185E651E0-0x0000000185E652A0
		public static MethodInfo GetBaseDefinition(this PropertyInfo propertyInfo) => default; // 0x0000000185E62220-0x0000000185E622E0
		public static BindingFlags RemoveFlag(this BindingFlags bindingAttr, BindingFlags flag) => default; // 0x0000000185E65410-0x0000000185E65490
	}
}
