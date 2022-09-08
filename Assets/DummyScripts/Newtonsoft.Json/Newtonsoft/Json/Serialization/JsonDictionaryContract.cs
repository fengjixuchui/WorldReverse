/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public class JsonDictionaryContract : JsonContainerContract // TypeDefIndex: 5392
	{
		// Fields
		private readonly System.Type _genericCollectionDefinitionType; // 0xE0
		private System.Type _genericWrapperType; // 0xE8
		private ObjectConstructor<object> _genericWrapperCreator; // 0xF0
		private Func<object> _genericTemporaryDictionaryCreator; // 0xF8
		private readonly ConstructorInfo _parameterizedConstructor; // 0x108
		private ObjectConstructor<object> _overrideCreator; // 0x110
		private ObjectConstructor<object> _parameterizedCreator; // 0x118
	
		// Properties
		public Func<string, string> DictionaryKeyResolver { get; set; } // 0x0000000186353360-0x00000001863533C0 0x0000000186353780-0x00000001863537F0
		public System.Type DictionaryKeyType { get; private set; } // 0x00000001863533C0-0x0000000186353420 0x00000001863537F0-0x0000000186353860
		public System.Type DictionaryValueType { get; private set; } // 0x0000000186353420-0x0000000186353480 0x0000000186353860-0x00000001863538D0
		internal JsonContract KeyContract { get; set; } // 0x00000001863535A0-0x0000000186353600 0x0000000186353940-0x00000001863539B0
		internal bool ShouldCreateWrapper { get; private set; } // 0x0000000186353720-0x0000000186353780 0x0000000186353A20-0x0000000186353A90
		internal ObjectConstructor<object> ParameterizedCreator { get => default; } // 0x0000000186353660-0x0000000186353720 
		public ObjectConstructor<object> OverrideCreator { get => default; set {} } // 0x0000000186353600-0x0000000186353660 0x00000001863539B0-0x0000000186353A20
		public bool HasParameterizedCreator { get; set; } // 0x0000000186353540-0x00000001863535A0 0x00000001863538D0-0x0000000186353940
		internal bool HasParameterizedCreatorInternal { get => default; } // 0x0000000186353480-0x0000000186353540 
	
		// Constructors
		public JsonDictionaryContract() {} // Dummy constructor
		public JsonDictionaryContract(System.Type underlyingType) {} // 0x0000000186352990-0x0000000186353360
	
		// Methods
		internal IWrappedDictionary CreateWrapper(object dictionary) => default; // 0x00000001863525C0-0x0000000186352990
		internal IDictionary CreateTemporaryDictionary() => default; // 0x0000000186352280-0x00000001863525C0
	}
}
