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

namespace Newtonsoft.Json.Bson
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public class BsonWriter : JsonWriter // TypeDefIndex: 5523
	{
		// Fields
		private readonly BsonBinaryWriter _writer; // 0x60
		private BsonToken _root; // 0x68
		private BsonToken _parent; // 0x70
		private string _propertyName; // 0x78
	
		// Constructors
		public BsonWriter() {} // Dummy constructor
	
		// Methods
		protected override void WriteEnd(Newtonsoft.Json.JsonToken token) {} // 0x0000000185CBE490-0x0000000185CBE540
		public override void WriteComment(string text) {} // 0x0000000185CBE410-0x0000000185CBE490
		public override void WriteStartConstructor(string name) {} // 0x0000000185CBE9D0-0x0000000185CBEA50
		public override void WriteRaw(string json) {} // 0x0000000185CBE7A0-0x0000000185CBE820
		public override void WriteRawValue(string json) {} // 0x0000000185CBE720-0x0000000185CBE7A0
		public override void WriteStartArray() {} // 0x0000000185CBE8F0-0x0000000185CBE9D0
		public override void WriteStartObject() {} // 0x0000000185CBEA50-0x0000000185CBEB30
		public override void WritePropertyName(string name) {} // 0x0000000185CBE6A0-0x0000000185CBE720
		public override void Close() {} // 0x0000000185CBE2E0-0x0000000185CBE360
		private void AddParent(BsonToken container) {} // 0x0000000185CBDF80-0x0000000185CBE000
		private void RemoveParent() {} // 0x0000000185CBE360-0x0000000185CBE410
		private void AddValue(object value, BsonType type) {} // 0x0000000185CBE230-0x0000000185CBE2E0
		internal void AddToken(BsonToken token) {} // 0x0000000185CBE000-0x0000000185CBE230
		public override void WriteValue(object value) {} // 0x0000000185CBF320-0x0000000185CBF3A0
		public override void WriteNull() {} // 0x0000000185CBE540-0x0000000185CBE5B0
		public override void WriteUndefined() {} // 0x0000000185CBEB30-0x0000000185CBEBA0
		public override void WriteValue(string value) {} // 0x0000000185CBF530-0x0000000185CBF5F0
		public override void WriteValue(int value) {} // 0x0000000185CBEFB0-0x0000000185CBF050
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public override void WriteValue(uint value) {} // 0x0000000185CBF950-0x0000000185CBFA20
		public override void WriteValue(long value) {} // 0x0000000185CBFA20-0x0000000185CBFAC0
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public override void WriteValue(ulong value) {} // 0x0000000185CBF3A0-0x0000000185CBF480
		public override void WriteValue(float value) {} // 0x0000000185CBEF10-0x0000000185CBEFB0
		public override void WriteValue(double value) {} // 0x0000000185CBF5F0-0x0000000185CBF690
		public override void WriteValue(bool value) {} // 0x0000000185CBF1E0-0x0000000185CBF280
		public override void WriteValue(short value) {} // 0x0000000185CBF280-0x0000000185CBF320
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public override void WriteValue(ushort value) {} // 0x0000000185CBF050-0x0000000185CBF0F0
		public override void WriteValue(char value) {} // 0x0000000185CBF0F0-0x0000000185CBF1E0
		public override void WriteValue(byte value) {} // 0x0000000185CBEC60-0x0000000185CBED00
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public override void WriteValue(sbyte value) {} // 0x0000000185CBEDB0-0x0000000185CBEE50
		public override void WriteValue(decimal value) {} // 0x0000000185CBED00-0x0000000185CBEDB0
		public override void WriteValue(DateTime value) {} // 0x0000000185CBF830-0x0000000185CBF950
		public override void WriteValue(DateTimeOffset value) {} // 0x0000000185CBF760-0x0000000185CBF830
		public override void WriteValue(byte[] value) {} // 0x0000000185CBF480-0x0000000185CBF530
		public override void WriteValue(Guid value) {} // 0x0000000185CBEE50-0x0000000185CBEF10
		public override void WriteValue(TimeSpan value) {} // 0x0000000185CBEBA0-0x0000000185CBEC60
		public override void WriteValue(Uri value) {} // 0x0000000185CBF690-0x0000000185CBF760
		public void WriteObjectId(byte[] value) {} // 0x0000000185CBE5B0-0x0000000185CBE6A0
		public void WriteRegex(string pattern, string options) {} // 0x0000000185CBE820-0x0000000185CBE8F0
	}
}
