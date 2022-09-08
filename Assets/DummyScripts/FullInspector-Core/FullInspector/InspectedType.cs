/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector
{
	public sealed class InspectedType // TypeDefIndex: 4832
	{
		// Fields
		private static Dictionary<System.Type, InspectedType> _cachedMetadata; // 0x00
		private bool? _hasDefaultConstructorCache; // 0x10
		private List<InspectedMember> _allMembers; // 0x18
		private Dictionary<IInspectedMemberFilter, List<InspectedMember>> _cachedMembers; // 0x20
		private Dictionary<IInspectedMemberFilter, List<InspectedProperty>> _cachedProperties; // 0x28
		private Dictionary<IInspectedMemberFilter, List<InspectedMethod>> _cachedMethods; // 0x30
		private bool _isArray; // 0x41
		private Dictionary<IInspectedMemberFilter, Dictionary<string, List<InspectedMember>>> _categoryCache; // 0x48
		private Dictionary<string, InspectedProperty> _nameToProperty; // 0x50
		private Dictionary<string, InspectedProperty> _formerlySerializedAsPropertyNames; // 0x58
	
		// Properties
		public bool HasDefaultConstructor { get => default; } // 0x0000000185CF2BE0-0x0000000185CF2D70 
		public System.Type ReflectedType { get; private set; } // 0x0000000185CF2DD0-0x0000000185CF2E30 0x0000000185CF2E90-0x0000000185CF2EF0
		public bool IsCollection { get; private set; } // 0x0000000185CF2D70-0x0000000185CF2DD0 0x0000000185CF2E30-0x0000000185CF2E90
	
		// Constructors
		public InspectedType() {} // Dummy constructor
		static InspectedType() {} // 0x0000000185CF2270-0x0000000185CF2300
		internal InspectedType(System.Type type) {} // 0x0000000185CF2300-0x0000000185CF2BE0
	
		// Methods
		public static InspectedType Get(System.Type type) => default; // 0x0000000185CF1250-0x0000000185CF13A0
		public static void ResetCacheForTesting() {} // 0x0000000185CF2070-0x0000000185CF2120
		public object CreateInstance() => default; // 0x0000000185CEFC50-0x0000000185CF01E0
		public List<InspectedMember> GetMembers(IInspectedMemberFilter filter) => default; // 0x0000000185CF09D0-0x0000000185CF0C30
		public List<InspectedProperty> GetProperties(IInspectedMemberFilter filter) => default; // 0x0000000185CF0EA0-0x0000000185CF1110
		public List<InspectedMethod> GetMethods(IInspectedMemberFilter filter) => default; // 0x0000000185CF0C30-0x0000000185CF0EA0
		private void VerifyNotCollection() {} // 0x0000000185CF2120-0x0000000185CF2270
		public static void StableSort<T>(IList<T> list, Func<T, T, int> comparator) {}
		private static List<InspectedMember> CollectUnorderedLocalMembers(System.Type reflectedType) => default; // 0x0000000185CEF7F0-0x0000000185CEFC50
		public Dictionary<string, List<InspectedMember>> GetCategories(IInspectedMemberFilter filter) => default; // 0x0000000185CF01E0-0x0000000185CF09D0
		public InspectedProperty GetPropertyByName(string name) => default; // 0x0000000185CF11B0-0x0000000185CF1250
		public InspectedProperty GetPropertyByFormerlySerializedName(string name) => default; // 0x0000000185CF1110-0x0000000185CF11B0
		private static void InitializePropertyRemoval() {} // 0x0000000185CF13A0-0x0000000185CF14D0
		public static void RemoveProperty<T>(string propertyName) {}
		private static bool IsSimpleTypeThatUnityCanSerialize(System.Type type) => default; // 0x0000000185CF1F50-0x0000000185CF2070
		private static bool IsPrimitiveSkippedByUnity(System.Type type) => default; // 0x0000000185CF14D0-0x0000000185CF1620
		public static bool IsSerializedByUnity(InspectedProperty property) => default; // 0x0000000185CF1A30-0x0000000185CF1F50
		public static bool IsSerializedByFullInspector(InspectedProperty property) => default; // 0x0000000185CF1620-0x0000000185CF1A30
	}
}
