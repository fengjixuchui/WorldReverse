/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;
using Rewired;
using Rewired.Utils.Attributes;
using Rewired.Utils.Interfaces;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Utils.Classes.Data
{
	[CustomClassObfuscation] // 0x000000018964FB00-0x000000018964FB80
	[CustomObfuscation] // 0x000000018964FB00-0x000000018964FB80
	[Preserve] // 0x000000018964FB00-0x000000018964FB80
	internal sealed class SerializedObject : IEnumerable<SerializedObject.Field>, IAddValue<object>, IAddKeyValue<string, object>, IExportToXml, IExportToJson // TypeDefIndex: 4331
	{
		// Fields
		private readonly IndexedDictionary<string, Entry> mxzBQunVokqPuzPaXadbiKiQQDn; // 0x10
		private XmlInfo oyRwzqHrrNTWvVBSqmfVwErntqp; // 0x18
		private System.Type iaFziOmGetWMviBsUmpNhLnTJKt; // 0x20
		private ObjectType fTTIFxKJIdubQrjfLjEltEHWSLl; // 0x28
		private static readonly Dictionary<System.Type, Dictionary<string, FieldInfo>> qYckNrBSyujMzyehMpRjtDcTIDIi; // 0x00
		private static readonly Dictionary<System.Type, Dictionary<string, PropertyInfo>> KOvzKrYXYIdzJcnlYhhJBslYfOB; // 0x08
	
		// Properties
		private bool allowDuplicateKeys { get => default; } // 0x0000000185573590-0x00000001855735F0 
		public ObjectType objectType { set {} } // 0x0000000185573940-0x0000000185573A20
		public System.Type type { get => default; } // 0x0000000185573670-0x00000001855736D0 
		public XmlInfo xmlInfo { get => default; set {} } // 0x00000001855736D0-0x0000000185573730 0x0000000185573A20-0x0000000185573A80
		public int count { get => default; } // 0x00000001855735F0-0x0000000185573670 
		public Field this[int index] { get => default; } // 0x0000000185573460-0x0000000185573590 
		bool IExportToXml.writesOwnElementTag { get => default; } // 0x0000000185567F70-0x0000000185567FC0 
	
		// Nested types
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public enum ObjectType // TypeDefIndex: 4332
		{
			Object = 0,
			List = 1
		}
	
		[CustomObfuscation] // 0x00000001896B9D70-0x00000001896B9DB0
		[Flags] // 0x00000001896B9D70-0x00000001896B9DB0
		public enum FieldOptions // TypeDefIndex: 4333
		{
			None = 0,
			ExculdeFromXml = 1
		}
	
		private struct Entry // TypeDefIndex: 4334
		{
			// Fields
			public System.Type type; // 0x00
			public object value; // 0x08
			public FieldOptions options; // 0x10
	
			// Constructors
			public Entry(System.Type type, object value, FieldOptions options) {
				this.type = default;
				this.value = default;
				this.options = default;
			} // 0x00000001862E2880-0x00000001862E28B0
	
			// Methods
			public override string ToString() => default; // 0x00000001862E27F0-0x00000001862E2880
		}
	
		[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
		[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
		public struct Field // TypeDefIndex: 4335
		{
			// Fields
			public string name; // 0x00
			public object value; // 0x08
			public System.Type type; // 0x10
			public FieldOptions options; // 0x18
	
			// Constructors
			public Field(string name, object value, System.Type type, FieldOptions options) {
				this.name = default;
				this.value = default;
				this.type = default;
				this.options = default;
			} // 0x00000001862E35A0-0x00000001862E35D0
	
			// Methods
			public override string ToString() => default; // 0x00000001862E3500-0x00000001862E35A0
		}
	
		[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
		[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
		public class XmlInfo // TypeDefIndex: 4336
		{
			// Fields
			private List<XmlAttribute> GJHtXewcRYthYfwNaufiDGXRdSu; // 0x10
	
			// Properties
			public List<XmlAttribute> attributes { get => default; } // 0x00000001863037F0-0x0000000186303880 
	
			// Nested types
			public abstract class XmlAttribute // TypeDefIndex: 4337
			{
				// Constructors
				protected XmlAttribute() {} // 0x0000000186302D20-0x0000000186302D80
			}
	
			public class XmlStringAttribute : XmlAttribute // TypeDefIndex: 4338
			{
				// Fields
				public string prefix; // 0x10
				public string localName; // 0x18
				public string ns; // 0x20
				public string value; // 0x28
	
				// Constructors
				public XmlStringAttribute() {} // 0x00000001863039B0-0x0000000186303A50
	
				// Methods
				public override string ToString() => default; // 0x0000000186303880-0x00000001863039B0
			}
	
			// Constructors
			public XmlInfo() {} // 0x0000000186303790-0x00000001863037F0
	
			// Methods
			public override string ToString() => default; // 0x0000000186303610-0x0000000186303790
		}
	
		[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
		[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
		public struct Enumerator : IEnumerator<Field> // TypeDefIndex: 4339
		{
			// Fields
			private IndexedDictionary<string, Entry> LbwQyRfKuLNxSjFIaAsDJTuLixL; // 0x00
			private Field xbRrcEKKIAKiQkVzQCekOswVHrJ; // 0x08
			private IEnumerator<KeyValuePair<string, Entry>> IkPdsmfCAFYyoVaHwofaSiapYaf; // 0x28
	
			// Properties
			public Field Current { get => default; } // 0x00000001862E2E10-0x00000001862E2EC0 
			object IEnumerator.Current { get => default; } // 0x00000001862E2D00-0x00000001862E2E00 
	
			// Constructors
			internal Enumerator(object dictionary) : this() {
				LbwQyRfKuLNxSjFIaAsDJTuLixL = default;
				xbRrcEKKIAKiQkVzQCekOswVHrJ = default;
				IkPdsmfCAFYyoVaHwofaSiapYaf = default;
			} // 0x00000001862E2E00-0x00000001862E2E10
	
			// Methods
			public bool MoveNext() => default; // 0x00000001862E2BD0-0x00000001862E2C70
			public void Dispose() {} // 0x00000001862E2970-0x00000001862E2BD0
			void IEnumerator.Reset() {} // 0x00000001862E2C70-0x00000001862E2D00
		}
	
		private class XmlDocument // TypeDefIndex: 4340
		{
			// Fields
			private readonly Element _root; // 0x10
	
			// Properties
			public Element root { get => default; } // 0x00000001863035B0-0x0000000186303610 
			public bool isValid { get => default; } // 0x0000000186303550-0x00000001863035B0 
	
			// Nested types
			public class Element // TypeDefIndex: 4341
			{
				// Fields
				public readonly string name; // 0x10
				public readonly Element parent; // 0x18
				public string content; // 0x20
				public Dictionary<string, string> attributes; // 0x28
				public List<Element> children; // 0x30
	
				// Properties
				public int childCount { get => default; } // 0x00000001862E2420-0x00000001862E27F0 
				public int attributeCount { get => default; } // 0x00000001862E23A0-0x00000001862E2420 
	
				// Constructors
				public Element() {} // Dummy constructor
				public Element(string name, Element parent) {} // 0x00000001862E2300-0x00000001862E23A0
	
				// Methods
				public void AddChild(Element element) {} // 0x00000001862E1090-0x00000001862E1180
				public void AddAttribute(string key, string value) {} // 0x00000001862E0F20-0x00000001862E1090
				public Element FindChild(string name) => default; // 0x00000001862E1180-0x00000001862E1380
				public object GetSerializedObject() => default; // 0x00000001862E1380-0x00000001862E1540
				public override string ToString() => default; // 0x00000001862E1540-0x00000001862E15B0
				private string ToString(string s, int indent) => default; // 0x00000001862E15B0-0x00000001862E2300
			}
	
			// Constructors
			public XmlDocument() {} // Dummy constructor
			public XmlDocument(string xml) {} // 0x0000000186303320-0x0000000186303550
	
			// Methods
			private void ReadAll(XmlReader reader) {} // 0x0000000186302D80-0x0000000186303280
			public override string ToString() => default; // 0x0000000186303280-0x0000000186303320
		}
	
		// Constructors
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private SerializedObject() {} // 0x0000000185573200-0x0000000185573270
		private SerializedObject(int capacity) {} // 0x0000000185573270-0x0000000185573320
		public SerializedObject(System.Type type, ObjectType objectType) {} // 0x0000000185573170-0x0000000185573200
		public SerializedObject(System.Type type, ObjectType objectType, int capacity) {} // 0x00000001855730E0-0x0000000185573170
		static SerializedObject() {} // 0x0000000185573020-0x00000001855730E0
	
		// Methods
		public void Add<T>(string fieldName, T value, FieldOptions options = FieldOptions.None /* Metadata: 0x00AC4EE8 */) {}
		public void Add(System.Type type, string fieldName, object value, FieldOptions options = FieldOptions.None /* Metadata: 0x00AC4EEC */) {} // 0x00000001855670B0-0x00000001855673F0
		public void Add(string fieldName, object value) {} // 0x0000000185566FF0-0x00000001855670B0
		public bool TryGetDeserializedValue<T>(string fieldName, out T value) {
			value = default;
			return default;
		}
		public bool TryGetDeserializedValue<T>(int index, out T value) {
			value = default;
			return default;
		}
		public bool TryGetDeserializedValueByRef<T>(string fieldName, ref T value) => default;
		public string ToXmlString(bool writeDocumentTag) => default; // 0x0000000185568590-0x00000001855687F0
		public override string ToString() => default; // 0x0000000185568160-0x0000000185568590
		private void WriteXml(XmlWriter writer) {} // 0x0000000185572EE0-0x0000000185573020
		private void WriteXml_Value(XmlWriter writer) {} // 0x00000001855727E0-0x0000000185572EE0
		void IExportToXml.WriteXml(XmlWriter writer) {} // 0x0000000185567EF0-0x0000000185567F70
		void IExportToJson.WriteJson(StringBuilder stringBuilder, Action<StringBuilder, object> appendValueDelegate) {} // 0x0000000185567A80-0x0000000185567EF0
		void IAddValue<object>.Add(object value) {} // 0x0000000185567A00-0x0000000185567A80
		void IAddKeyValue<string, object>.Add(string key, object value) {} // 0x0000000185567970-0x0000000185567A00
		IEnumerator<Field> System.Collections.Generic.IEnumerable<Rewired.Utils.Classes.Data.SerializedObject.Field>.GetEnumerator() => default; // 0x0000000185567FC0-0x0000000185568090
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000185568090-0x0000000185568160
		private static bool TryConvertOrCreateObject<T>(object obj, out T result, NumberStyles numberStyle = NumberStyles.None | NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent | NumberStyles.AllowCurrencySymbol | NumberStyles.Integer | NumberStyles.Number | NumberStyles.Float | NumberStyles.Currency | NumberStyles.Any /* Metadata: 0x00AC4EF0 */, CultureInfo cultureInfo = null) {
			result = default;
			return default;
		}
		private static bool TryConvertOrCreateObject(System.Type targetType, object obj, out object result, NumberStyles numberStyle = NumberStyles.None | NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent | NumberStyles.AllowCurrencySymbol | NumberStyles.Integer | NumberStyles.Number | NumberStyles.Float | NumberStyles.Currency | NumberStyles.Any /* Metadata: 0x00AC4EF4 */, CultureInfo cultureInfo = null) {
			result = default;
			return default;
		} // 0x00000001855687F0-0x0000000185571CB0
		private static bool TryCreateObject(System.Type type, SerializedObject serializedObject, out object result, NumberStyles numberStyle = NumberStyles.None | NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent | NumberStyles.AllowCurrencySymbol | NumberStyles.Integer | NumberStyles.Number | NumberStyles.Float | NumberStyles.Currency | NumberStyles.Any /* Metadata: 0x00AC4EF8 */, CultureInfo cultureInfo = null) {
			result = default;
			return default;
		} // 0x0000000185571CB0-0x00000001855727E0
		public static SerializedObject FromXml(System.Type type, string xmlString) => default; // 0x00000001855673F0-0x0000000185567760
	}
}
