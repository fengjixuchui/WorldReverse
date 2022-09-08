/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Linq
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public class JTokenWriter : JsonWriter // TypeDefIndex: 5443
	{
		// Fields
		private JContainer _token; // 0x60
		private JContainer _parent; // 0x68
		private JValue _value; // 0x70
		private JToken _current; // 0x78
	
		// Properties
		public JToken Token { get => default; } // 0x000000018634B6B0-0x000000018634B720 
	
		// Constructors
		public JTokenWriter() {} // 0x000000018634B630-0x000000018634B6B0
	
		// Methods
		public override void Close() {} // 0x0000000186349F60-0x0000000186349FC0
		public override void WriteStartObject() {} // 0x000000018634A4F0-0x000000018634A590
		private void AddParent(JContainer container) {} // 0x0000000186349D20-0x0000000186349DB0
		private void RemoveParent() {} // 0x0000000186349FC0-0x000000018634A070
		public override void WriteStartArray() {} // 0x000000018634A3A0-0x000000018634A440
		public override void WriteStartConstructor(string name) {} // 0x000000018634A440-0x000000018634A4F0
		protected override void WriteEnd(Newtonsoft.Json.JsonToken token) {} // 0x000000018634A100-0x000000018634A160
		public override void WritePropertyName(string name) {} // 0x000000018634A1E0-0x000000018634A2F0
		private void AddValue(object value, Newtonsoft.Json.JsonToken token) {} // 0x0000000186349DB0-0x0000000186349E60
		internal void AddValue(JValue value, Newtonsoft.Json.JsonToken token) {} // 0x0000000186349E60-0x0000000186349F60
		public override void WriteValue(object value) {} // 0x000000018634AC30-0x000000018634ACB0
		public override void WriteNull() {} // 0x000000018634A160-0x000000018634A1E0
		public override void WriteUndefined() {} // 0x000000018634A7F0-0x000000018634A870
		public override void WriteRaw(string json) {} // 0x000000018634A2F0-0x000000018634A3A0
		public override void WriteComment(string text) {} // 0x000000018634A070-0x000000018634A100
		public override void WriteValue(string value) {} // 0x000000018634ABA0-0x000000018634AC30
		public override void WriteValue(int value) {} // 0x000000018634B450-0x000000018634B4F0
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public override void WriteValue(uint value) {} // 0x000000018634AB00-0x000000018634ABA0
		public override void WriteValue(long value) {} // 0x000000018634B310-0x000000018634B3B0
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public override void WriteValue(ulong value) {} // 0x000000018634AFC0-0x000000018634B060
		public override void WriteValue(float value) {} // 0x000000018634B590-0x000000018634B630
		public override void WriteValue(double value) {} // 0x000000018634A990-0x000000018634AA30
		public override void WriteValue(bool value) {} // 0x000000018634AE70-0x000000018634AF10
		public override void WriteValue(short value) {} // 0x000000018634B3B0-0x000000018634B450
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public override void WriteValue(ushort value) {} // 0x000000018634B110-0x000000018634B1B0
		public override void WriteValue(char value) {} // 0x000000018634B250-0x000000018634B310
		public override void WriteValue(byte value) {} // 0x000000018634B4F0-0x000000018634B590
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public override void WriteValue(sbyte value) {} // 0x000000018634ACB0-0x000000018634AD50
		public override void WriteValue(decimal value) {} // 0x000000018634B060-0x000000018634B110
		public override void WriteValue(DateTime value) {} // 0x000000018634AD50-0x000000018634AE70
		public override void WriteValue(DateTimeOffset value) {} // 0x000000018634AA30-0x000000018634AB00
		public override void WriteValue(byte[] value) {} // 0x000000018634A900-0x000000018634A990
		public override void WriteValue(TimeSpan value) {} // 0x000000018634B1B0-0x000000018634B250
		public override void WriteValue(Guid value) {} // 0x000000018634AF10-0x000000018634AFC0
		public override void WriteValue(Uri value) {} // 0x000000018634A870-0x000000018634A900
		internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) {} // 0x000000018634A590-0x000000018634A7F0
	}
}
