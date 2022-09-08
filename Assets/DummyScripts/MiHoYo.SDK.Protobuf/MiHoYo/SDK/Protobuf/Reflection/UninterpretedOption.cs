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
	internal sealed class UninterpretedOption : MiHoYo.SDK.Protobuf.IMessage<UninterpretedOption> // TypeDefIndex: 5165
	{
		// Fields
		private static readonly MiHoYo.SDK.Protobuf.MessageParser<UninterpretedOption> _parser; // 0x00
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<Types.NamePart> _repeated_name_codec; // 0x08
		private readonly RepeatedField<Types.NamePart> name_; // 0x10
		private string identifierValue_; // 0x18
		private ulong positiveIntValue_; // 0x20
		private long negativeIntValue_; // 0x28
		private double doubleValue_; // 0x30
		private MiHoYo.SDK.Protobuf.ByteString stringValue_; // 0x38
		private string aggregateValue_; // 0x40
	
		// Properties
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.MessageParser<UninterpretedOption> Parser { get => default; } // 0x0000000187D71BE0-0x0000000187D71C70 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000187D71990-0x0000000187D71AB0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000187D71D30-0x0000000187D71DB0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string IdentifierValue { get => default; set {} } // 0x0000000187D71B20-0x0000000187D71B80 0x0000000187D71EA0-0x0000000187D71F20
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public ulong PositiveIntValue { get => default; set {} } // 0x0000000187D71C70-0x0000000187D71CD0 0x0000000187D71F80-0x0000000187D71FE0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public long NegativeIntValue { get => default; set {} } // 0x0000000187D71B80-0x0000000187D71BE0 0x0000000187D71F20-0x0000000187D71F80
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public double DoubleValue { get => default; set {} } // 0x0000000187D71AB0-0x0000000187D71B20 0x0000000187D71E30-0x0000000187D71EA0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public MiHoYo.SDK.Protobuf.ByteString StringValue { get => default; set {} } // 0x0000000187D71CD0-0x0000000187D71D30 0x0000000187D71FE0-0x0000000187D72060
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string AggregateValue { get => default; set {} } // 0x0000000187D71930-0x0000000187D71990 0x0000000187D71DB0-0x0000000187D71E30
	
		// Nested types
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static class Types // TypeDefIndex: 5166
		{
			// Nested types
			internal sealed class NamePart : MiHoYo.SDK.Protobuf.IMessage<NamePart> // TypeDefIndex: 5167
			{
				// Fields
				private static readonly MiHoYo.SDK.Protobuf.MessageParser<NamePart> _parser; // 0x00
				private string namePart_; // 0x10
				private bool isExtension_; // 0x18
	
				// Properties
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public static MiHoYo.SDK.Protobuf.MessageParser<NamePart> Parser { get => default; } // 0x0000000187D63E80-0x0000000187D63F10 
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public static MessageDescriptor Descriptor { get => default; } // 0x0000000187D63C70-0x0000000187D63DC0 
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000187D63F10-0x0000000187D63F90 
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public string NamePart_ { get => default; set {} } // 0x0000000187D63E20-0x0000000187D63E80 0x0000000187D63FF0-0x0000000187D64070
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public bool IsExtension { get => default; set {} } // 0x0000000187D63DC0-0x0000000187D63E20 0x0000000187D63F90-0x0000000187D63FF0
	
				// Constructors
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public NamePart() {} // 0x0000000187D63B20-0x0000000187D63B90
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public NamePart(NamePart other) {} // 0x0000000187D63B90-0x0000000187D63C70
				static NamePart() {} // 0x0000000187D63A20-0x0000000187D63B20
	
				// Methods
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public NamePart Clone() => default; // 0x0000000187D632E0-0x0000000187D63360
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public override bool Equals(object other) => default; // 0x0000000187D63360-0x0000000187D633F0
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public bool Equals(NamePart other) => default; // 0x0000000187D633F0-0x0000000187D63540
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public override int GetHashCode() => default; // 0x0000000187D63540-0x0000000187D636F0
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public override string ToString() => default; // 0x0000000187D637C0-0x0000000187D63850
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x0000000187D63850-0x0000000187D63A20
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public int CalculateSize() => default; // 0x0000000187D63170-0x0000000187D632E0
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x0000000187D636F0-0x0000000187D637C0
			}
		}
	
		// Constructors
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public UninterpretedOption() {} // 0x0000000187D71860-0x0000000187D71930
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public UninterpretedOption(UninterpretedOption other) {} // 0x0000000187D71790-0x0000000187D71860
		static UninterpretedOption() {} // 0x0000000187D71640-0x0000000187D71790
	
		// Methods
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public UninterpretedOption Clone() => default; // 0x0000000187D70730-0x0000000187D707B0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override bool Equals(object other) => default; // 0x0000000187D709D0-0x0000000187D70A60
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Equals(UninterpretedOption other) => default; // 0x0000000187D707B0-0x0000000187D709D0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override int GetHashCode() => default; // 0x0000000187D70A60-0x0000000187D70EE0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override string ToString() => default; // 0x0000000187D710C0-0x0000000187D71150
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x0000000187D71150-0x0000000187D71640
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public int CalculateSize() => default; // 0x0000000187D70280-0x0000000187D70730
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x0000000187D70EE0-0x0000000187D710C0
	}
}
