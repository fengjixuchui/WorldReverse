/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using FullSerializer.Internal;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullSerializer
{
	public class fsMetaType // TypeDefIndex: 4736
	{
		// Fields
		private static Dictionary<fsConfig, Dictionary<System.Type, fsMetaType>> _configMetaTypes; // 0x00
		public System.Type ReflectedType; // 0x10
		private bool _hasEmittedAotData; // 0x18
		private bool? _hasDefaultConstructorCache; // 0x28
		private bool _isDefaultConstructorPublic; // 0x2A
	
		// Properties
		public fsMetaProperty[] Properties { get; private set; } // 0x0000000185D111D0-0x0000000185D11230 0x0000000185D11230-0x0000000185D11290
		public bool HasDefaultConstructor { get => default; } // 0x0000000185D10FF0-0x0000000185D111D0 
	
		// Constructors
		public fsMetaType() {} // Dummy constructor
		private fsMetaType(fsConfig config, System.Type reflectedType) {} // 0x0000000185D10EC0-0x0000000185D10FF0
		static fsMetaType() {} // 0x0000000185D10E30-0x0000000185D10EC0
	
		// Methods
		public static fsMetaType Get(fsConfig config, System.Type type) => default; // 0x0000000185D10AB0-0x0000000185D10C80
		public static void ClearCache() {} // 0x0000000185D0FE50-0x0000000185D0FF00
		private static void CollectProperties(fsConfig config, List<fsMetaProperty> properties, System.Type reflectedType) {} // 0x0000000185D0FF00-0x0000000185D10460
		private static bool IsAutoProperty(PropertyInfo property, MemberInfo[] members) => default; // 0x0000000185D10C80-0x0000000185D10E30
		private static bool CanSerializeProperty(fsConfig config, PropertyInfo property, MemberInfo[] members, bool annotationFreeValue) => default; // 0x0000000185D0FB40-0x0000000185D0FE50
		private static bool CanSerializeField(fsConfig config, FieldInfo field, bool annotationFreeValue) => default; // 0x0000000185D0F910-0x0000000185D0FB40
		public bool EmitAotData() => default; // 0x0000000185D10900-0x0000000185D10AB0
		public object CreateInstance() => default; // 0x0000000185D10460-0x0000000185D10900
	}
}
