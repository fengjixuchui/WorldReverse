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

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public abstract class JsonReader : IDisposable // TypeDefIndex: 5276
	{
		// Fields
		private JsonToken _tokenType; // 0x10
		private object _value; // 0x18
		internal char _quoteChar; // 0x20
		internal State _currentState; // 0x24
		private JsonPosition _currentPosition; // 0x28
		private CultureInfo _culture; // 0x40
		private DateTimeZoneHandling _dateTimeZoneHandling; // 0x48
		private int? _maxDepth; // 0x4C
		private bool _hasExceededMaxDepth; // 0x54
		internal DateParseHandling _dateParseHandling; // 0x58
		internal FloatParseHandling _floatParseHandling; // 0x5C
		private string _dateFormatString; // 0x60
		private List<JsonPosition> _stack; // 0x68
	
		// Properties
		protected State CurrentState { get; } // 0x0000000185CC8E70-0x0000000185CC8ED0 
		public bool CloseInput { get; set; } // 0x0000000185CC8D80-0x0000000185CC8DE0 0x0000000185CC9460-0x0000000185CC94C0
		public bool SupportMultipleContent { get; set; } // 0x0000000185CC92D0-0x0000000185CC9330 0x0000000185CC9830-0x0000000185CC9890
		public DateTimeZoneHandling DateTimeZoneHandling { get; set; } // 0x0000000185CC8F90-0x0000000185CC8FF0 0x0000000185CC9620-0x0000000185CC96C0
		public DateParseHandling DateParseHandling { get; set; } // 0x0000000185CC8F30-0x0000000185CC8F90 0x0000000185CC9580-0x0000000185CC9620
		public FloatParseHandling FloatParseHandling { get; set; } // 0x0000000185CC90A0-0x0000000185CC9100 0x0000000185CC96C0-0x0000000185CC9760
		public string DateFormatString { get; set; } // 0x0000000185CC8ED0-0x0000000185CC8F30 0x0000000185CC9520-0x0000000185CC9580
		public int? MaxDepth { get; set; } // 0x0000000185CC9100-0x0000000185CC9160 0x0000000185CC9760-0x0000000185CC9830
		public virtual JsonToken TokenType { get; } // 0x0000000185CC9330-0x0000000185CC9390 
		public virtual object Value { get; } // 0x0000000185CC9400-0x0000000185CC9460 
		public virtual System.Type ValueType { get; } // 0x0000000185CC9390-0x0000000185CC9400 
		public virtual int Depth { get; } // 0x0000000185CC8FF0-0x0000000185CC90A0 
		public virtual string Path { get; } // 0x0000000185CC9160-0x0000000185CC92D0 
		public CultureInfo Culture { get; set; } // 0x0000000185CC8DE0-0x0000000185CC8E70 0x0000000185CC94C0-0x0000000185CC9520
	
		// Nested types
		protected internal enum State // TypeDefIndex: 5277
		{
			Start = 0,
			Complete = 1,
			Property = 2,
			ObjectStart = 3,
			Object = 4,
			ArrayStart = 5,
			Array = 6,
			Closed = 7,
			PostValue = 8,
			ConstructorStart = 9,
			Constructor = 10,
			Error = 11,
			Finished = 12
		}
	
		// Constructors
		protected JsonReader() {} // 0x0000000185CC8CD0-0x0000000185CC8D80
	
		// Methods
		internal JsonPosition GetPosition(int depth) => default; // 0x0000000185CC4570-0x0000000185CC4660
		private void Push(JsonContainerType value) {} // 0x0000000185CC4A30-0x0000000185CC4CA0
		private JsonContainerType Pop() => default; // 0x0000000185CC4880-0x0000000185CC4A30
		private JsonContainerType Peek() => default; // 0x0000000185CC4820-0x0000000185CC4880
		public abstract bool Read();
		public virtual int? ReadAsInt32() => default; // 0x0000000185CC6630-0x0000000185CC6940
		internal int? ReadInt32String(string s) => default; // 0x0000000185CC7DA0-0x0000000185CC8040
		public virtual string ReadAsString() => default; // 0x0000000185CC6940-0x0000000185CC6C50
		public virtual byte[] ReadAsBytes() => default; // 0x0000000185CC5370-0x0000000185CC5890
		internal byte[] ReadArrayIntoByteArray() => default; // 0x0000000185CC4DC0-0x0000000185CC5040
		public virtual double? ReadAsDouble() => default; // 0x0000000185CC62D0-0x0000000185CC6630
		internal double? ReadDoubleString(string s) => default; // 0x0000000185CC7AF0-0x0000000185CC7DA0
		public virtual bool? ReadAsBoolean() => default; // 0x0000000185CC5040-0x0000000185CC5370
		internal bool? ReadBooleanString(string s) => default; // 0x0000000185CC6C50-0x0000000185CC6EF0
		public virtual decimal? ReadAsDecimal() => default; // 0x0000000185CC5F80-0x0000000185CC62D0
		internal decimal? ReadDecimalString(string s) => default; // 0x0000000185CC7800-0x0000000185CC7AF0
		public virtual DateTime? ReadAsDateTime() => default; // 0x0000000185CC5C10-0x0000000185CC5F80
		internal DateTime? ReadDateTimeString(string s) => default; // 0x0000000185CC7340-0x0000000185CC7800
		public virtual DateTimeOffset? ReadAsDateTimeOffset() => default; // 0x0000000185CC5890-0x0000000185CC5C10
		internal DateTimeOffset? ReadDateTimeOffsetString(string s) => default; // 0x0000000185CC6EF0-0x0000000185CC7340
		internal void ReaderReadAndAssert() {} // 0x0000000185CC82F0-0x0000000185CC8380
		internal JsonReaderException CreateUnexpectedEndException() => default; // 0x0000000185CC4360-0x0000000185CC4430
		internal void ReadIntoWrappedTypeObject() {} // 0x0000000185CC8040-0x0000000185CC82F0
		public void Skip() {} // 0x0000000185CC8960-0x0000000185CC8A60
		protected void SetToken(JsonToken newToken) {} // 0x0000000185CC88E0-0x0000000185CC8960
		protected void SetToken(JsonToken newToken, object value) {} // 0x0000000185CC86B0-0x0000000185CC8740
		internal void SetToken(JsonToken newToken, object value, bool updateIndex) {} // 0x0000000185CC8740-0x0000000185CC88E0
		internal void SetPostValueState(bool updateIndex) {} // 0x0000000185CC8430-0x0000000185CC8540
		private void UpdateScopeWithFinishedValue() {} // 0x0000000185CC8AE0-0x0000000185CC8B40
		private void ValidateEnd(JsonToken endToken) {} // 0x0000000185CC8B40-0x0000000185CC8CD0
		protected void SetStateBasedOnCurrent() {} // 0x0000000185CC8540-0x0000000185CC86B0
		private void SetFinished() {} // 0x0000000185CC8380-0x0000000185CC8430
		private JsonContainerType GetTypeForCloseToken(JsonToken token) => default; // 0x0000000185CC4660-0x0000000185CC4780
		void IDisposable.Dispose() {} // 0x0000000185CC8A60-0x0000000185CC8AE0
		protected virtual void Dispose(bool disposing) {} // 0x0000000185CC4430-0x0000000185CC44C0
		public virtual void Close() {} // 0x0000000185CC4300-0x0000000185CC4360
		internal void ReadAndAssert() {} // 0x0000000185CC4CA0-0x0000000185CC4D40
		internal bool ReadAndMoveToContent() => default; // 0x0000000185CC4D40-0x0000000185CC4DC0
		internal bool MoveToContent() => default; // 0x0000000185CC4780-0x0000000185CC4820
		private JsonToken GetContentToken() => default; // 0x0000000185CC44C0-0x0000000185CC4570
	}
}
