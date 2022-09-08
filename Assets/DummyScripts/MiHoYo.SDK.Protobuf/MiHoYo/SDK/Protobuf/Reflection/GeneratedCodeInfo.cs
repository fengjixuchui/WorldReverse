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
	internal sealed class GeneratedCodeInfo : MiHoYo.SDK.Protobuf.IMessage<GeneratedCodeInfo> // TypeDefIndex: 5175
	{
		// Fields
		private static readonly MiHoYo.SDK.Protobuf.MessageParser<GeneratedCodeInfo> _parser; // 0x00
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<Types.Annotation> _repeated_annotation_codec; // 0x08
		private readonly RepeatedField<Types.Annotation> annotation_; // 0x10
	
		// Properties
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.MessageParser<GeneratedCodeInfo> Parser { get => default; } // 0x0000000187D5B610-0x0000000187D5B6A0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000187D5B4F0-0x0000000187D5B610 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000187D5B6A0-0x0000000187D5B720 
	
		// Nested types
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static class Types // TypeDefIndex: 5176
		{
			// Nested types
			internal sealed class Annotation : MiHoYo.SDK.Protobuf.IMessage<Annotation> // TypeDefIndex: 5177
			{
				// Fields
				private static readonly MiHoYo.SDK.Protobuf.MessageParser<Annotation> _parser; // 0x00
				private static readonly MiHoYo.SDK.Protobuf.FieldCodec<int> _repeated_path_codec; // 0x08
				private readonly RepeatedField<int> path_; // 0x10
				private string sourceFile_; // 0x18
				private int begin_; // 0x20
				private int end_; // 0x24
	
				// Properties
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public static MiHoYo.SDK.Protobuf.MessageParser<Annotation> Parser { get => default; } // 0x0000000187D55F30-0x0000000187D55FC0 
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public static MessageDescriptor Descriptor { get => default; } // 0x0000000187D55D80-0x0000000187D55ED0 
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000187D56020-0x0000000187D560A0 
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public string SourceFile { get => default; set {} } // 0x0000000187D55FC0-0x0000000187D56020 0x0000000187D56160-0x0000000187D561E0
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public int Begin { get => default; set {} } // 0x0000000187D55D20-0x0000000187D55D80 0x0000000187D560A0-0x0000000187D56100
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public int End { get => default; set {} } // 0x0000000187D55ED0-0x0000000187D55F30 0x0000000187D56100-0x0000000187D56160
	
				// Constructors
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public Annotation() {} // 0x0000000187D55C80-0x0000000187D55D20
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public Annotation(Annotation other) {} // 0x0000000187D55BD0-0x0000000187D55C80
				static Annotation() {} // 0x0000000187D55AB0-0x0000000187D55BD0
	
				// Methods
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public Annotation Clone() => default; // 0x0000000187D55140-0x0000000187D551C0
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public override bool Equals(object other) => default; // 0x0000000187D55300-0x0000000187D55390
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public bool Equals(Annotation other) => default; // 0x0000000187D551C0-0x0000000187D55300
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public override int GetHashCode() => default; // 0x0000000187D55390-0x0000000187D555F0
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public override string ToString() => default; // 0x0000000187D55760-0x0000000187D557F0
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x0000000187D557F0-0x0000000187D55AB0
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public int CalculateSize() => default; // 0x0000000187D54E70-0x0000000187D55140
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x0000000187D555F0-0x0000000187D55760
			}
		}
	
		// Constructors
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public GeneratedCodeInfo() {} // 0x0000000187D5B3C0-0x0000000187D5B450
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public GeneratedCodeInfo(GeneratedCodeInfo other) {} // 0x0000000187D5B450-0x0000000187D5B4F0
		static GeneratedCodeInfo() {} // 0x0000000187D5B270-0x0000000187D5B3C0
	
		// Methods
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public GeneratedCodeInfo Clone() => default; // 0x0000000187D5ADF0-0x0000000187D5AE70
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override bool Equals(object other) => default; // 0x0000000187D5AF10-0x0000000187D5AFA0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Equals(GeneratedCodeInfo other) => default; // 0x0000000187D5AE70-0x0000000187D5AF10
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override int GetHashCode() => default; // 0x0000000187D5AFA0-0x0000000187D5B020
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override string ToString() => default; // 0x0000000187D5B120-0x0000000187D5B1B0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x0000000187D5B1B0-0x0000000187D5B270
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public int CalculateSize() => default; // 0x0000000187D5AD40-0x0000000187D5ADF0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x0000000187D5B020-0x0000000187D5B120
	}
}
