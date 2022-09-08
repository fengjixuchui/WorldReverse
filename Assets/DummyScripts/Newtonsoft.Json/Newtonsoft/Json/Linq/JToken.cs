/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
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
	[Preserve] // 0x0000000189ABCFB0-0x0000000189ABD000
	public abstract class JToken : IJEnumerable<JToken>, IJsonLineInfo, ICloneable // TypeDefIndex: 5444
	{
		// Fields
		private static JTokenEqualityComparer _equalityComparer; // 0x00
		private JContainer _parent; // 0x10
		private JToken _previous; // 0x18
		private JToken _next; // 0x20
		private object _annotations; // 0x28
		private static readonly JTokenType[] BooleanTypes; // 0x08
		private static readonly JTokenType[] NumberTypes; // 0x10
		private static readonly JTokenType[] StringTypes; // 0x18
		private static readonly JTokenType[] GuidTypes; // 0x20
		private static readonly JTokenType[] TimeSpanTypes; // 0x28
		private static readonly JTokenType[] UriTypes; // 0x30
		private static readonly JTokenType[] CharTypes; // 0x38
		private static readonly JTokenType[] DateTimeTypes; // 0x40
		private static readonly JTokenType[] BytesTypes; // 0x48
	
		// Properties
		public JContainer Parent { [DebuggerStepThrough] /* 0x0000000189658AA0-0x0000000189658AB0 */ get; internal set; } // 0x0000000186C77F60-0x0000000186C77FC0 0x0000000186C7E610-0x0000000186C7E670
		public JToken Root { get; } // 0x0000000186C782F0-0x0000000186C78440 
		public abstract JTokenType Type { get; }
		public abstract bool HasValues { get; }
		public JToken Next { get; internal set; } // 0x0000000186C77F00-0x0000000186C77F60 0x0000000186C7E5B0-0x0000000186C7E610
		public JToken Previous { get; internal set; } // 0x0000000186C78290-0x0000000186C782F0 0x0000000186C7E670-0x0000000186C7E6D0
		public string Path { get; } // 0x0000000186C77FC0-0x0000000186C78290 
		public virtual JToken this[object key] { get => default; } // 0x0000000186C77D60-0x0000000186C77E30 
		public virtual JToken First { get; } // 0x0000000186C77C90-0x0000000186C77D60 
		public virtual JToken Last { get; } // 0x0000000186C77E30-0x0000000186C77F00 
		int IJsonLineInfo.LineNumber { get; } // 0x0000000186C742F0-0x0000000186C74370 
		int IJsonLineInfo.LinePosition { get; } // 0x0000000186C74370-0x0000000186C743F0 
	
		// Nested types
		private class LineInfoAnnotation // TypeDefIndex: 5445
		{
			// Fields
			internal readonly int LineNumber; // 0x10
			internal readonly int LinePosition; // 0x14
	
			// Constructors
			public LineInfoAnnotation() {} // Dummy constructor
			public LineInfoAnnotation(int lineNumber, int linePosition) {} // 0x0000000186C88830-0x0000000186C888B0
		}
	
		// Constructors
		internal JToken() {} // 0x0000000186C77C30-0x0000000186C77C90
		static JToken() {} // 0x0000000186C773F0-0x0000000186C77C30
	
		// Methods
		internal abstract JToken CloneToken();
		internal abstract bool DeepEquals(JToken node);
		public static bool DeepEquals(JToken t1, JToken t2) => default; // 0x0000000186C73CE0-0x0000000186C73D80
		public virtual JEnumerable<JToken> Children() => default; // 0x0000000186C73B60-0x0000000186C73BF0
		public void Remove() {} // 0x0000000186C74880-0x0000000186C74930
		public void Replace(JToken value) {} // 0x0000000186C74930-0x0000000186C749F0
		public abstract void WriteTo(JsonWriter writer, params /* 0x000000018989F6F0-0x000000018989F700 */ JsonConverter[] converters);
		public override string ToString() => default; // 0x0000000186C770D0-0x0000000186C77160
		public string ToString(Formatting formatting, params /* 0x000000018989F6F0-0x000000018989F700 */ JsonConverter[] converters) => default; // 0x0000000186C77160-0x0000000186C77300
		private static JValue EnsureValue(JToken value) => default; // 0x0000000186C73D80-0x0000000186C73F00
		private static string GetType(JToken token) => default; // 0x0000000186C740F0-0x0000000186C74280
		private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable) => default; // 0x0000000186C77300-0x0000000186C773F0
		public static explicit operator bool(JToken value) => default; // 0x0000000186C7D5B0-0x0000000186C7D810
		public static explicit operator DateTimeOffset(JToken value) => default; // 0x0000000186C79580-0x0000000186C79970
		public static explicit operator bool?(JToken value) => default; // 0x0000000186C7B260-0x0000000186C7B4B0
		public static explicit operator long(JToken value) => default; // 0x0000000186C7DAA0-0x0000000186C7DD00
		public static explicit operator DateTime?(JToken value) => default; // 0x0000000186C79970-0x0000000186C79D10
		public static explicit operator DateTimeOffset?(JToken value) => default; // 0x0000000186C7A6C0-0x0000000186C7AB50
		public static explicit operator decimal?(JToken value) => default; // 0x0000000186C7D310-0x0000000186C7D5B0
		public static explicit operator double?(JToken value) => default; // 0x0000000186C78990-0x0000000186C78C20
		public static explicit operator char?(JToken value) => default; // 0x0000000186C7E1E0-0x0000000186C7E430
		public static explicit operator int(JToken value) => default; // 0x0000000186C7C550-0x0000000186C7C7B0
		public static explicit operator short(JToken value) => default; // 0x0000000186C7D0B0-0x0000000186C7D310
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public static explicit operator ushort(JToken value) => default; // 0x0000000186C7AB50-0x0000000186C7ADB0
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public static explicit operator char(JToken value) => default; // 0x0000000186C7B000-0x0000000186C7B260
		public static explicit operator byte(JToken value) => default; // 0x0000000186C7A1D0-0x0000000186C7A430
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public static explicit operator sbyte(JToken value) => default; // 0x0000000186C7BB70-0x0000000186C7BDD0
		public static explicit operator int?(JToken value) => default; // 0x0000000186C790C0-0x0000000186C79310
		public static explicit operator short?(JToken value) => default; // 0x0000000186C7DF90-0x0000000186C7E1E0
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public static explicit operator ushort?(JToken value) => default; // 0x0000000186C78E70-0x0000000186C790C0
		public static explicit operator byte?(JToken value) => default; // 0x0000000186C7ADB0-0x0000000186C7B000
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public static explicit operator sbyte?(JToken value) => default; // 0x0000000186C7CAE0-0x0000000186C7CD30
		public static explicit operator DateTime(JToken value) => default; // 0x0000000186C7C7B0-0x0000000186C7CAE0
		public static explicit operator long?(JToken value) => default; // 0x0000000186C7A430-0x0000000186C7A6C0
		public static explicit operator float?(JToken value) => default; // 0x0000000186C78C20-0x0000000186C78E70
		public static explicit operator decimal(JToken value) => default; // 0x0000000186C79310-0x0000000186C79580
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public static explicit operator uint?(JToken value) => default; // 0x0000000186C78440-0x0000000186C78690
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public static explicit operator ulong?(JToken value) => default; // 0x0000000186C7DD00-0x0000000186C7DF90
		public static explicit operator double(JToken value) => default; // 0x0000000186C7BDD0-0x0000000186C7C040
		public static explicit operator float(JToken value) => default; // 0x0000000186C7C040-0x0000000186C7C2B0
		public static explicit operator string(JToken value) => default; // 0x0000000186C7C2B0-0x0000000186C7C550
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public static explicit operator uint(JToken value) => default; // 0x0000000186C79D10-0x0000000186C79F70
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public static explicit operator ulong(JToken value) => default; // 0x0000000186C79F70-0x0000000186C7A1D0
		public static explicit operator Guid(JToken value) => default; // 0x0000000186C7CD30-0x0000000186C7D0B0
		public static explicit operator Guid?(JToken value) => default; // 0x0000000186C7B7D0-0x0000000186C7BB70
		public static explicit operator TimeSpan(JToken value) => default; // 0x0000000186C78690-0x0000000186C78990
		public static explicit operator TimeSpan?(JToken value) => default; // 0x0000000186C7B4B0-0x0000000186C7B7D0
		public static explicit operator Uri(JToken value) => default; // 0x0000000186C7D810-0x0000000186C7DAA0
		public static implicit operator JToken(int value) => default; // 0x0000000186C7E4B0-0x0000000186C7E530
		public static implicit operator JToken(float value) => default; // 0x0000000186C7E430-0x0000000186C7E4B0
		public static implicit operator JToken(string value) => default; // 0x0000000186C7E530-0x0000000186C7E5B0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000186C74C40-0x0000000186C74CB0
		IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator() => default; // 0x0000000186C74BB0-0x0000000186C74C40
		internal abstract int GetDeepHashCode();
		public JsonReader CreateReader() => default; // 0x0000000186C73BF0-0x0000000186C73C70
		internal static JToken FromObjectInternal(object o, JsonSerializer jsonSerializer) => default; // 0x0000000186C73F00-0x0000000186C74050
		public static JToken FromObject(object o) => default; // 0x0000000186C74050-0x0000000186C740F0
		public object ToObject(System.Type objectType) => default; // 0x0000000186C74EA0-0x0000000186C770D0
		public object ToObject(System.Type objectType, JsonSerializer jsonSerializer) => default; // 0x0000000186C74D60-0x0000000186C74EA0
		public static JToken ReadFrom(JsonReader reader) => default; // 0x0000000186C747F0-0x0000000186C74880
		public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings) => default; // 0x0000000186C743F0-0x0000000186C747F0
		internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings) {} // 0x0000000186C749F0-0x0000000186C74B00
		internal void SetLineInfo(int lineNumber, int linePosition) {} // 0x0000000186C74B00-0x0000000186C74BB0
		bool IJsonLineInfo.HasLineInfo() => default; // 0x0000000186C74280-0x0000000186C742F0
		object ICloneable.Clone() => default; // 0x0000000186C74CB0-0x0000000186C74D60
		public JToken DeepClone() => default; // 0x0000000186C73C70-0x0000000186C73CE0
		public void AddAnnotation(object annotation) {} // 0x0000000186C738A0-0x0000000186C73B60
		public T Annotation<T>()
			where T : class => default;
	}
}
