/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public abstract class JsonWriter : IDisposable // TypeDefIndex: 5286
	{
		// Fields
		private static readonly State[][] StateArray; // 0x00
		internal static readonly State[][] StateArrayTempate; // 0x08
		private List<JsonPosition> _stack; // 0x10
		private JsonPosition _currentPosition; // 0x18
		private State _currentState; // 0x30
		private Formatting _formatting; // 0x34
		private DateFormatHandling _dateFormatHandling; // 0x3C
		private DateTimeZoneHandling _dateTimeZoneHandling; // 0x40
		private StringEscapeHandling _stringEscapeHandling; // 0x44
		private FloatFormatHandling _floatFormatHandling; // 0x48
		private string _dateFormatString; // 0x50
		private CultureInfo _culture; // 0x58
	
		// Properties
		public bool CloseOutput { get; set; } // 0x0000000186C87C00-0x0000000186C87C60 0x0000000186C883E0-0x0000000186C88440
		protected internal int Top { get; } // 0x0000000186C881A0-0x0000000186C88260 
		public WriteState WriteState { get; } // 0x0000000186C88260-0x0000000186C883E0 
		internal string ContainerPath { get; } // 0x0000000186C87C60-0x0000000186C87D60 
		public string Path { get; } // 0x0000000186C87FD0-0x0000000186C88140 
		public Formatting Formatting { get; set; } // 0x0000000186C87F70-0x0000000186C87FD0 0x0000000186C886E0-0x0000000186C88780
		public DateFormatHandling DateFormatHandling { get; set; } // 0x0000000186C87DF0-0x0000000186C87E50 0x0000000186C884A0-0x0000000186C88540
		public DateTimeZoneHandling DateTimeZoneHandling { get; set; } // 0x0000000186C87EB0-0x0000000186C87F10 0x0000000186C885A0-0x0000000186C88640
		public StringEscapeHandling StringEscapeHandling { get; set; } // 0x0000000186C88140-0x0000000186C881A0 0x0000000186C88780-0x0000000186C88830
		public FloatFormatHandling FloatFormatHandling { get; set; } // 0x0000000186C87F10-0x0000000186C87F70 0x0000000186C88640-0x0000000186C886E0
		public string DateFormatString { get; set; } // 0x0000000186C87E50-0x0000000186C87EB0 0x0000000186C88540-0x0000000186C885A0
		public CultureInfo Culture { get; set; } // 0x0000000186C87D60-0x0000000186C87DF0 0x0000000186C88440-0x0000000186C884A0
	
		// Nested types
		internal enum State // TypeDefIndex: 5287
		{
			Start = 0,
			Property = 1,
			ObjectStart = 2,
			Object = 3,
			ArrayStart = 4,
			Array = 5,
			ConstructorStart = 6,
			Constructor = 7,
			Closed = 8,
			Error = 9
		}
	
		// Constructors
		static JsonWriter() {} // 0x0000000186C86E70-0x0000000186C87B50
		protected JsonWriter() {} // 0x0000000186C87B50-0x0000000186C87C00
	
		// Methods
		internal static State[][] BuildStateArray() => default; // 0x0000000186C81E10-0x0000000186C82210
		internal virtual void OnStringEscapeHandlingChanged() {} // 0x0000000186C82830-0x0000000186C82880
		internal void UpdateScopeWithFinishedValue() {} // 0x0000000186C82BC0-0x0000000186C82C20
		private void Push(JsonContainerType value) {} // 0x0000000186C82A30-0x0000000186C82B40
		private JsonContainerType Pop() => default; // 0x0000000186C828E0-0x0000000186C82A30
		private JsonContainerType Peek() => default; // 0x0000000186C82880-0x0000000186C828E0
		public virtual void Close() {} // 0x0000000186C82210-0x0000000186C82270
		public virtual void WriteStartObject() {} // 0x0000000186C83870-0x0000000186C838E0
		public virtual void WriteEndObject() {} // 0x0000000186C83130-0x0000000186C831E0
		public virtual void WriteStartArray() {} // 0x0000000186C83790-0x0000000186C83800
		public virtual void WriteEndArray() {} // 0x0000000186C82FD0-0x0000000186C83080
		public virtual void WriteStartConstructor(string name) {} // 0x0000000186C83800-0x0000000186C83870
		public virtual void WriteEndConstructor() {} // 0x0000000186C83080-0x0000000186C83130
		public virtual void WritePropertyName(string name) {} // 0x0000000186C83530-0x0000000186C835B0
		public virtual void WritePropertyName(string name, bool escape) {} // 0x0000000186C835B0-0x0000000186C83630
		public virtual void WriteEnd() {} // 0x0000000186C831E0-0x0000000186C83290
		public void WriteToken(JsonReader reader) {} // 0x0000000186C84420-0x0000000186C844A0
		public void WriteToken(JsonReader reader, bool writeChildren) {} // 0x0000000186C83B60-0x0000000186C83C10
		public void WriteToken(JsonToken token, object value) {} // 0x0000000186C83C10-0x0000000186C84420
		internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) {} // 0x0000000186C838E0-0x0000000186C83B60
		private void WriteConstructorDate(JsonReader reader) {} // 0x0000000186C82CD0-0x0000000186C82FD0
		private void WriteEnd(JsonContainerType type) {} // 0x0000000186C83290-0x0000000186C833D0
		private void AutoCompleteAll() {} // 0x0000000186C818B0-0x0000000186C81940
		private JsonToken GetCloseTokenForType(JsonContainerType type) => default; // 0x0000000186C823F0-0x0000000186C82500
		private void AutoCompleteClose(JsonContainerType type) {} // 0x0000000186C81940-0x0000000186C81B80
		protected virtual void WriteEnd(JsonToken token) {} // 0x0000000186C833D0-0x0000000186C83420
		protected virtual void WriteIndent() {} // 0x0000000186C83470-0x0000000186C834C0
		protected virtual void WriteValueDelimiter() {} // 0x0000000186C84510-0x0000000186C84560
		protected virtual void WriteIndentSpace() {} // 0x0000000186C83420-0x0000000186C83470
		internal void AutoComplete(JsonToken tokenBeingWritten) {} // 0x0000000186C81B80-0x0000000186C81E10
		public virtual void WriteNull() {} // 0x0000000186C834C0-0x0000000186C83530
		public virtual void WriteUndefined() {} // 0x0000000186C844A0-0x0000000186C84510
		public virtual void WriteRaw(string json) {} // 0x0000000186C83700-0x0000000186C83790
		public virtual void WriteRawValue(string json) {} // 0x0000000186C83630-0x0000000186C83700
		public virtual void WriteValue(string value) {} // 0x0000000186C847B0-0x0000000186C84820
		public virtual void WriteValue(int value) {} // 0x0000000186C84740-0x0000000186C847B0
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public virtual void WriteValue(uint value) {} // 0x0000000186C84610-0x0000000186C84680
		public virtual void WriteValue(long value) {} // 0x0000000186C86B90-0x0000000186C86C00
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public virtual void WriteValue(ulong value) {} // 0x0000000186C84F70-0x0000000186C84FE0
		public virtual void WriteValue(float value) {} // 0x0000000186C851F0-0x0000000186C85260
		public virtual void WriteValue(double value) {} // 0x0000000186C86CE0-0x0000000186C86D50
		public virtual void WriteValue(bool value) {} // 0x0000000186C84DB0-0x0000000186C84E20
		public virtual void WriteValue(short value) {} // 0x0000000186C85180-0x0000000186C851F0
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public virtual void WriteValue(ushort value) {} // 0x0000000186C84FE0-0x0000000186C85050
		public virtual void WriteValue(char value) {} // 0x0000000186C86800-0x0000000186C86870
		public virtual void WriteValue(byte value) {} // 0x0000000186C86E00-0x0000000186C86E70
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public virtual void WriteValue(sbyte value) {} // 0x0000000186C85050-0x0000000186C850C0
		public virtual void WriteValue(decimal value) {} // 0x0000000186C86C70-0x0000000186C86CE0
		public virtual void WriteValue(DateTime value) {} // 0x0000000186C85260-0x0000000186C852D0
		public virtual void WriteValue(DateTimeOffset value) {} // 0x0000000186C86C00-0x0000000186C86C70
		public virtual void WriteValue(Guid value) {} // 0x0000000186C84BD0-0x0000000186C84C40
		public virtual void WriteValue(TimeSpan value) {} // 0x0000000186C86620-0x0000000186C86690
		public virtual void WriteValue(int? value) {} // 0x0000000186C86870-0x0000000186C86920
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public virtual void WriteValue(uint? value) {} // 0x0000000186C84B20-0x0000000186C84BD0
		public virtual void WriteValue(long? value) {} // 0x0000000186C84680-0x0000000186C84740
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public virtual void WriteValue(ulong? value) {} // 0x0000000186C849B0-0x0000000186C84A70
		public virtual void WriteValue(float? value) {} // 0x0000000186C86750-0x0000000186C86800
		public virtual void WriteValue(double? value) {} // 0x0000000186C86D50-0x0000000186C86E00
		public virtual void WriteValue(bool? value) {} // 0x0000000186C86AE0-0x0000000186C86B90
		public virtual void WriteValue(short? value) {} // 0x0000000186C84C40-0x0000000186C84CF0
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public virtual void WriteValue(ushort? value) {} // 0x0000000186C84A70-0x0000000186C84B20
		public virtual void WriteValue(char? value) {} // 0x0000000186C84820-0x0000000186C848D0
		public virtual void WriteValue(byte? value) {} // 0x0000000186C86570-0x0000000186C86620
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public virtual void WriteValue(sbyte? value) {} // 0x0000000186C84560-0x0000000186C84610
		public virtual void WriteValue(decimal? value) {} // 0x0000000186C86A20-0x0000000186C86AE0
		public virtual void WriteValue(DateTime? value) {} // 0x0000000186C84CF0-0x0000000186C84DB0
		public virtual void WriteValue(DateTimeOffset? value) {} // 0x0000000186C848D0-0x0000000186C849B0
		public virtual void WriteValue(Guid? value) {} // 0x0000000186C86690-0x0000000186C86750
		public virtual void WriteValue(TimeSpan? value) {} // 0x0000000186C84EB0-0x0000000186C84F70
		public virtual void WriteValue(byte[] value) {} // 0x0000000186C84E20-0x0000000186C84EB0
		public virtual void WriteValue(Uri value) {} // 0x0000000186C850C0-0x0000000186C85180
		public virtual void WriteValue(object value) {} // 0x0000000186C86920-0x0000000186C86A20
		public virtual void WriteComment(string text) {} // 0x0000000186C82C20-0x0000000186C82CD0
		void IDisposable.Dispose() {} // 0x0000000186C82B40-0x0000000186C82BC0
		protected virtual void Dispose(bool disposing) {} // 0x0000000186C82360-0x0000000186C823F0
		internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value) {} // 0x0000000186C852D0-0x0000000186C86570
		private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value) => default; // 0x0000000186C82270-0x0000000186C82360
		internal void InternalWriteEnd(JsonContainerType container) {} // 0x0000000186C82570-0x0000000186C825E0
		internal void InternalWritePropertyName(string name) {} // 0x0000000186C825E0-0x0000000186C82660
		internal void InternalWriteRaw() {} // 0x0000000186C82660-0x0000000186C826B0
		internal void InternalWriteStart(JsonToken token, JsonContainerType container) {} // 0x0000000186C826B0-0x0000000186C82780
		internal void InternalWriteValue(JsonToken token) {} // 0x0000000186C82780-0x0000000186C82830
		internal void InternalWriteComment() {} // 0x0000000186C82500-0x0000000186C82570
	}
}
