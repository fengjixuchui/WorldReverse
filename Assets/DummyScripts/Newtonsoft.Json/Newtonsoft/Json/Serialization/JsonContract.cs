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
using System.Security;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public abstract class JsonContract // TypeDefIndex: 5389
	{
		// Fields
		internal bool IsNullable; // 0x10
		internal bool IsConvertable; // 0x11
		internal bool IsEnum; // 0x12
		internal System.Type NonNullableUnderlyingType; // 0x18
		internal ReadType InternalReadType; // 0x20
		internal JsonContractType ContractType; // 0x24
		internal bool IsReadOnlyOrFixedSize; // 0x28
		internal bool IsSealed; // 0x29
		internal bool IsInstantiable; // 0x2A
		private List<SerializationCallback> _onDeserializedCallbacks; // 0x30
		private IList<SerializationCallback> _onDeserializingCallbacks; // 0x38
		private IList<SerializationCallback> _onSerializedCallbacks; // 0x40
		private IList<SerializationCallback> _onSerializingCallbacks; // 0x48
		private IList<SerializationErrorCallback> _onErrorCallbacks; // 0x50
		private System.Type _createdType; // 0x58
	
		// Properties
		public System.Type UnderlyingType { get; private set; } // 0x0000000186351F10-0x0000000186351F70 0x0000000186352220-0x0000000186352280
		public System.Type CreatedType { get; set; } // 0x0000000186351A60-0x0000000186351AC0 0x0000000186351FD0-0x0000000186352080
		public bool? IsReference { get; set; } // 0x0000000186351BE0-0x0000000186351C40 0x00000001863521C0-0x0000000186352220
		public JsonConverter Converter { get; set; } // 0x0000000186351A00-0x0000000186351A60 0x0000000186351F70-0x0000000186351FD0
		internal JsonConverter InternalConverter { get; set; } // 0x0000000186351B80-0x0000000186351BE0 0x0000000186352160-0x00000001863521C0
		public IList<SerializationCallback> OnDeserializedCallbacks { get; } // 0x0000000186351C40-0x0000000186351CD0 
		public IList<SerializationCallback> OnDeserializingCallbacks { get; } // 0x0000000186351CD0-0x0000000186351D60 
		public IList<SerializationCallback> OnSerializedCallbacks { get; } // 0x0000000186351DF0-0x0000000186351E80 
		public IList<SerializationCallback> OnSerializingCallbacks { get; } // 0x0000000186351E80-0x0000000186351F10 
		public IList<SerializationErrorCallback> OnErrorCallbacks { get; } // 0x0000000186351D60-0x0000000186351DF0 
		public Func<object> DefaultCreator { get; set; } // 0x0000000186351B20-0x0000000186351B80 0x00000001863520F0-0x0000000186352160
		public bool DefaultCreatorNonPublic { get; set; } // 0x0000000186351AC0-0x0000000186351B20 0x0000000186352080-0x00000001863520F0
	
		// Constructors
		protected JsonContract() {} // Dummy constructor
		internal JsonContract(System.Type underlyingType) {} // 0x0000000186351870-0x0000000186351A00
	
		// Methods
		internal void InvokeOnSerializing(object o, StreamingContext context) {} // 0x00000001863516C0-0x0000000186351870
		internal void InvokeOnSerialized(object o, StreamingContext context) {} // 0x0000000186351510-0x00000001863516C0
		internal void InvokeOnDeserializing(object o, StreamingContext context) {} // 0x0000000186351190-0x0000000186351340
		internal void InvokeOnDeserialized(object o, StreamingContext context) {} // 0x0000000186351030-0x0000000186351190
		internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext) {} // 0x0000000186351340-0x0000000186351510
		internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo) => default; // 0x0000000186350E30-0x0000000186350F30
		internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo) => default; // 0x0000000186350F30-0x0000000186351030
	}
}
