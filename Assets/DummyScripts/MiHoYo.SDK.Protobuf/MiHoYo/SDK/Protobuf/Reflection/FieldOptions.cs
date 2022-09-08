/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using MiHoYo.SDK.Protobuf;
using MiHoYo.SDK.Protobuf.Collections;

// Image 46: MiHoYo.SDK.Protobuf.dll - Assembly: MiHoYo.SDK.Protobuf, Version=3.0.0.0, Culture=neutral, PublicKeyToken=a7d26565bac4d604 - Types 5068-5227

namespace MiHoYo.SDK.Protobuf.Reflection
{
	internal sealed class FieldOptions : MiHoYo.SDK.Protobuf.IMessage<FieldOptions> // TypeDefIndex: 5150
	{
		// Fields
		private static readonly MiHoYo.SDK.Protobuf.MessageParser<FieldOptions> _parser; // 0x00
		private Types.CType ctype_; // 0x10
		private bool packed_; // 0x14
		private Types.JSType jstype_; // 0x18
		private bool lazy_; // 0x1C
		private bool deprecated_; // 0x1D
		private bool weak_; // 0x1E
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x08
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x20
	
		// Properties
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.MessageParser<FieldOptions> Parser { get => default; } // 0x0000000186501980-0x0000000186501A10 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000186501710-0x0000000186501860 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000186501A70-0x0000000186501AF0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public Types.CType Ctype { get => default; } // 0x0000000186501650-0x00000001865016B0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Packed { get => default; set {} } // 0x0000000186501920-0x0000000186501980 0x0000000186501BB0-0x0000000186501C10
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public Types.JSType Jstype { get => default; } // 0x0000000186501860-0x00000001865018C0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Lazy { get => default; set {} } // 0x00000001865018C0-0x0000000186501920 0x0000000186501B50-0x0000000186501BB0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Deprecated { get => default; set {} } // 0x00000001865016B0-0x0000000186501710 0x0000000186501AF0-0x0000000186501B50
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Weak { get => default; set {} } // 0x0000000186501A10-0x0000000186501A70 0x0000000186501C10-0x0000000186501C70
	
		// Nested types
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static class Types // TypeDefIndex: 5151
		{
			// Nested types
			internal enum CType // TypeDefIndex: 5152
			{
				String = 0,
				Cord = 1,
				StringPiece = 2
			}
	
			internal enum JSType // TypeDefIndex: 5153
			{
				JsNormal = 0,
				JsString = 1,
				JsNumber = 2
			}
		}
	
		// Constructors
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public FieldOptions() {} // 0x00000001865014F0-0x0000000186501590
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public FieldOptions(FieldOptions other) {} // 0x0000000186501590-0x0000000186501650
		static FieldOptions() {} // 0x00000001865013A0-0x00000001865014F0
	
		// Methods
		private void OnConstruction() {} // 0x0000000186500C80-0x0000000186500D10
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public FieldOptions Clone() => default; // 0x0000000186500390-0x0000000186500410
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override bool Equals(object other) => default; // 0x0000000186500410-0x00000001865004A0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Equals(FieldOptions other) => default; // 0x00000001865004A0-0x0000000186500670
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override int GetHashCode() => default; // 0x0000000186500670-0x0000000186500AA0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override string ToString() => default; // 0x0000000186500D10-0x0000000186500DA0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x0000000186500DA0-0x00000001865013A0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public int CalculateSize() => default; // 0x0000000186500070-0x0000000186500390
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x0000000186500AA0-0x0000000186500C80
	}
}
