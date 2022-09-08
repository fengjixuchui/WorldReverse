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
	public class JsonArrayContract : JsonContainerContract // TypeDefIndex: 5383
	{
		// Fields
		private readonly System.Type _genericCollectionDefinitionType; // 0xD0
		private System.Type _genericWrapperType; // 0xD8
		private ObjectConstructor<object> _genericWrapperCreator; // 0xE0
		private Func<object> _genericTemporaryCollectionCreator; // 0xE8
		private readonly ConstructorInfo _parameterizedConstructor; // 0xF8
		private ObjectConstructor<object> _parameterizedCreator; // 0x100
		private ObjectConstructor<object> _overrideCreator; // 0x108
	
		// Properties
		public System.Type CollectionItemType { get; private set; } // 0x00000001863500A0-0x0000000186350100 0x00000001863504D0-0x0000000186350540
		public bool IsMultidimensionalArray { get; private set; } // 0x0000000186350280-0x00000001863502E0 0x0000000186350620-0x0000000186350690
		internal bool IsArray { get; private set; } // 0x0000000186350220-0x0000000186350280 0x00000001863505B0-0x0000000186350620
		internal bool ShouldCreateWrapper { get; private set; } // 0x0000000186350400-0x0000000186350460 0x0000000186350740-0x00000001863507B0
		internal bool CanDeserialize { get; private set; } // 0x0000000186350040-0x00000001863500A0 0x0000000186350460-0x00000001863504D0
		internal ObjectConstructor<object> ParameterizedCreator { get => default; } // 0x0000000186350340-0x0000000186350400 
		public ObjectConstructor<object> OverrideCreator { get => default; set {} } // 0x00000001863502E0-0x0000000186350340 0x0000000186350690-0x0000000186350740
		public bool HasParameterizedCreator { get; set; } // 0x00000001863501C0-0x0000000186350220 0x0000000186350540-0x00000001863505B0
		internal bool HasParameterizedCreatorInternal { get => default; } // 0x0000000186350100-0x00000001863501C0 
	
		// Constructors
		public JsonArrayContract() {} // Dummy constructor
		public JsonArrayContract(System.Type underlyingType) {} // 0x000000018634F180-0x0000000186350040
	
		// Methods
		internal IWrappedCollection CreateWrapper(object list) => default; // 0x000000018634EC80-0x000000018634F180
		internal IList CreateTemporaryCollection() => default; // 0x000000018634E9B0-0x000000018634EC80
	}
}
