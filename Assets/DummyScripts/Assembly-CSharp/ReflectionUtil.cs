/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class ReflectionUtil // TypeDefIndex: 31821
{
	// Fields
	private static Dictionary<System.Type, FieldInfo[]> _reflectionFieldCache; // 0x00
	private static Dictionary<System.Type, PropertyInfo[]> _reflectionPropertyCache; // 0x08

	// Constructors
	public ReflectionUtil() {} // 0x00000001810BC020-0x00000001810BC080
	static ReflectionUtil() {} // 0x00000001810BBF60-0x00000001810BC020

	// Methods
	// [XID] // 0x00000001897D02C0-0x00000001897D02E0
	public static void SetValue(object instance, string propertyName, object value) {} // 0x00000001810BB630-0x00000001810BB820
	// [XID] // 0x00000001897D7F40-0x00000001897D7F60
	public static object GetValue(object instance, string propertyName) => default; // 0x00000001810BBD80-0x00000001810BBF60
	// [XID] // 0x00000001897DF100-0x00000001897DF120
	public static System.Type GetValueType(object instance, string propertyName) => default; // 0x00000001810BBBB0-0x00000001810BBD80
	// [XID] // 0x00000001897E69E0-0x00000001897E6A00
	private static FieldInfo TryGetFieldValue(object instance, string propertyName) => default; // 0x00000001810BB9E0-0x00000001810BBBB0
	// [XID] // 0x00000001897EE500-0x00000001897EE520
	private static PropertyInfo TryGetPropertyValue(object instance, string propertyName) => default; // 0x00000001810BB2A0-0x00000001810BB470
	// [XID] // 0x00000001897F5C30-0x00000001897F5C50
	private static FieldInfo[] GetFieldsWithCache(System.Type type) => default; // 0x00000001810BB820-0x00000001810BB9E0
	// [XID] // 0x00000001897FD450-0x00000001897FD470
	private static PropertyInfo[] GetPropertysWithCache(System.Type type) => default; // 0x00000001810BB470-0x00000001810BB630
}

