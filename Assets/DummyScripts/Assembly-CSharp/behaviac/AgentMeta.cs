/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace behaviac
{
	public class AgentMeta // TypeDefIndex: 27364
	{
		// Fields
		private Dictionary<uint, IProperty> _memberProperties; // 0x10
		private Dictionary<uint, ICustomizedProperty> _customizedProperties; // 0x18
		private Dictionary<uint, ICustomizedProperty> _customizedStaticProperties; // 0x20
		private Dictionary<uint, IInstantiatedVariable> _customizedStaticVars; // 0x28
		private Dictionary<uint, IMethod> _methods; // 0x30
		private static Dictionary<uint, AgentMeta> _agentMetas; // 0x00
		private static Dictionary<string, TypeCreator> _Creators; // 0x08
		private static Dictionary<string, System.Type> _typesRegistered; // 0x10
		private static uint _totalSignature; // 0x18
		private uint _signature; // 0x38
		private static BehaviorLoader _behaviorLoader; // 0x20
	
		// Properties
		public static uint TotalSignature { get => default; set {} } // 0x00000001860A2850-0x00000001860A28E0 0x00000001860A3FB0-0x00000001860A4040
		public uint Signature { get => default; } // 0x00000001860A27F0-0x00000001860A2850 
		public static Dictionary<uint, AgentMeta> _AgentMetas_ { get => default; } // 0x00000001860A28E0-0x00000001860A2970 
		public static BehaviorLoader _BehaviorLoader_ { set {} } // 0x00000001860A4040-0x00000001860A41F0
	
		// Nested types
		private class TypeCreator // TypeDefIndex: 27365
		{
			// Fields
			private PropertyCreator _propertyCreator; // 0x10
			private ArrayItemPropertyCreator _arrayItemPropertyCreator; // 0x18
			private InstancePropertyCreator _instancePropertyCreator; // 0x20
			private InstanceConstCreator _instanceConstCreator; // 0x28
			private CustomizedPropertyCreator _customizedPropertyCreator; // 0x30
			private CustomizedArrayItemPropertyCreator _customizedArrayItemPropertyCreator; // 0x38
	
			// Nested types
			public delegate ICustomizedProperty PropertyCreator(uint propId, string propName, string valueStr); // TypeDefIndex: 27366; 0x00000001860B93D0-0x00000001860B95B0
	
			public delegate ICustomizedProperty ArrayItemPropertyCreator(uint parentId, string parentName); // TypeDefIndex: 27367; 0x00000001860A50A0-0x00000001860A5260
	
			public delegate IInstanceMember InstancePropertyCreator(string instance, IInstanceMember indexMember, uint id); // TypeDefIndex: 27368; 0x00000001860B8F20-0x00000001860B9210
	
			public delegate IInstanceMember InstanceConstCreator(string typeName, string valueStr); // TypeDefIndex: 27369; 0x00000001860B8AC0-0x00000001860B8D70
	
			public delegate ICustomizedProperty CustomizedPropertyCreator(uint id, string name, string valueStr); // TypeDefIndex: 27370; 0x00000001860B8750-0x00000001860B8930
	
			public delegate ICustomizedProperty CustomizedArrayItemPropertyCreator(uint id, string name); // TypeDefIndex: 27371; 0x00000001860B83D0-0x00000001860B8590
	
			// Constructors
			public TypeCreator() {} // Dummy constructor
			public TypeCreator(PropertyCreator propCreator, ArrayItemPropertyCreator arrayItemPropCreator, InstancePropertyCreator instancePropertyCreator, InstanceConstCreator instanceConstCreator, CustomizedPropertyCreator customizedPropertyCreator, CustomizedArrayItemPropertyCreator customizedArrayItemPropertyCreator) {} // 0x00000001860B9FA0-0x00000001860BA040
	
			// Methods
			public ICustomizedProperty CreateProperty(uint propId, string propName, string valueStr) => default; // 0x00000001860B9F00-0x00000001860B9FA0
			public ICustomizedProperty CreateArrayItemProperty(uint parentId, string parentName) => default; // 0x00000001860B9BE0-0x00000001860B9C80
			public IInstanceMember CreateInstanceProperty(string instance, IInstanceMember indexMember, uint id) => default; // 0x00000001860B9E60-0x00000001860B9F00
			public IInstanceMember CreateInstanceConst(string typeName, string valueStr) => default; // 0x00000001860B9DC0-0x00000001860B9E60
			public ICustomizedProperty CreateCustomizedProperty(uint id, string name, string valueStr) => default; // 0x00000001860B9D20-0x00000001860B9DC0
			public ICustomizedProperty CreateCustomizedArrayItemProperty(uint id, string name) => default; // 0x00000001860B9C80-0x00000001860B9D20
		}
	
		// Constructors
		public AgentMeta() {} // Dummy constructor
		public AgentMeta(uint signature = 0 /* Metadata: 0x00B0C8DC */) {} // 0x00000001860A25F0-0x00000001860A2700
		static AgentMeta() {} // 0x00000001860A24F0-0x00000001860A25F0
	
		// Methods
		public static void Register() {} // 0x00000001860A1DF0-0x00000001860A2010
		public static void UnRegister() {} // 0x00000001860A23A0-0x00000001860A24F0
		public static System.Type GetTypeFromName(string typeName) => default; // 0x000000018609FC60-0x000000018609FD60
		public static AgentMeta GetMeta(uint classId) => default; // 0x000000018609F990-0x000000018609FA90
		public Dictionary<uint, IInstantiatedVariable> InstantiateCustomizedProperties() => default; // 0x000000018609FDF0-0x00000001860A0280
		public void RegisterMemberProperty(uint propId, IProperty property) {} // 0x00000001860A1C10-0x00000001860A1CB0
		public void RegisterCustomizedProperty(uint propId, ICustomizedProperty property) {} // 0x00000001860A1B70-0x00000001860A1C10
		public void RegisterStaticCustomizedProperty(uint propId, ICustomizedProperty property) {} // 0x00000001860A1D50-0x00000001860A1DF0
		public void RegisterMethod(uint methodId, IMethod method) {} // 0x00000001860A1CB0-0x00000001860A1D50
		public IProperty GetProperty(uint propId) => default; // 0x000000018609FB40-0x000000018609FC60
		public IProperty GetMemberProperty(uint propId) => default; // 0x000000018609F8E0-0x000000018609F990
		public Dictionary<uint, IProperty> GetMemberProperties() => default; // 0x000000018609F880-0x000000018609F8E0
		public IMethod GetMethod(uint methodId) => default; // 0x000000018609FA90-0x000000018609FB40
		public static string GetTypeName(string typeName) => default; // 0x000000018609FD60-0x000000018609FDF0
		public static ICustomizedProperty CreateProperty(string typeName, uint propId, string propName, string valueStr) => default; // 0x000000018609F730-0x000000018609F880
		public static ICustomizedProperty CreateArrayItemProperty(string typeName, uint parentId, string parentName) => default; // 0x000000018609F0B0-0x000000018609F200
		public static IInstanceMember CreateInstanceProperty(string typeName, string instance, IInstanceMember indexMember, uint varId) => default; // 0x000000018609F5E0-0x000000018609F730
		public static IInstanceMember CreateInstanceConst(string typeName, string valueStr) => default; // 0x000000018609F4A0-0x000000018609F5E0
		public static ICustomizedProperty CreateCustomizedProperty(string typeName, uint id, string name, string valueStr) => default; // 0x000000018609F350-0x000000018609F4A0
		public static ICustomizedProperty CreateCustomizedArrayItemProperty(string typeName, uint id, string name) => default; // 0x000000018609F200-0x000000018609F350
		public static object ParseTypeValue(string typeName, string valueStr) => default; // 0x00000001860A1640-0x00000001860A17E0
		public static string ParseInstanceNameProperty(string fullName, ref string instanceName, ref string agentType) => default; // 0x00000001860A0A50-0x00000001860A0BB0
		public static ICustomizedProperty CreatorProperty<T>(uint propId, string propName, string valueStr) => default;
		public static ICustomizedProperty CreatorArrayItemProperty<T>(uint parentId, string parentName) => default;
		public static IInstanceMember CreatorInstanceProperty<T>(string instance, IInstanceMember indexMember, uint varId) => default;
		public static IInstanceMember CreatorInstanceConst<T>(string typeName, string valueStr) => default;
		public static ICustomizedProperty CreateCustomizedProperty<T>(uint id, string name, string valueStr) => default;
		public static ICustomizedProperty CreateCustomizedArrayItemProperty<T>(uint id, string name) => default;
		public static bool Register<T>(string typeName) => default;
		public static void UnRegister<T>(string typeName) {}
		private static void RegisterBasicTypes() {} // 0x00000001860A17E0-0x00000001860A1B70
		private static void UnRegisterBasicTypes() {} // 0x00000001860A2010-0x00000001860A23A0
		public static IInstanceMember ParseProperty<T>(string value) => default;
		public static IInstanceMember ParseProperty(string value, List<string> tokens = null) => default; // 0x00000001860A1010-0x00000001860A1640
		public static IMethod ParseMethod(string valueStr, ref string methodName) => default; // 0x00000001860A0CE0-0x00000001860A0F70
		public static IMethod ParseMethod(string valueStr) => default; // 0x00000001860A0F70-0x00000001860A1010
		private static int ParseMethodNames(string fullName, ref string agentIntanceName, ref string agentClassName, ref string methodName) => default; // 0x00000001860A0BB0-0x00000001860A0CE0
		private static List<string> ParseForParams(string tsrc) => default; // 0x00000001860A08E0-0x00000001860A0A50
		private static void LoadAllMetaFiles() {} // 0x00000001860A0280-0x00000001860A08E0
		private static void registerCustomizedProperty(AgentMeta meta, string propName, string typeName, string valueStr, bool isStatic) {} // 0x00000001860A3C20-0x00000001860A3FB0
		private static bool checkSignature(string signatureStr) => default; // 0x00000001860A2700-0x00000001860A27F0
		private static bool load_xml(byte[] pBuffer) => default; // 0x00000001860A3240-0x00000001860A3C20
		private static bool load_bson(byte[] pBuffer) => default; // 0x00000001860A2E90-0x00000001860A30A0
		private static bool load_agent(int version, BsonDeserizer d) => default; // 0x00000001860A2970-0x00000001860A2E90
		private static void load_methods(BsonDeserizer d, string agentType, BsonDeserizer.BsonTypes type) {} // 0x00000001860A30A0-0x00000001860A3240
	}
}
