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
	internal sealed class SourceCodeInfo : MiHoYo.SDK.Protobuf.IMessage<SourceCodeInfo> // TypeDefIndex: 5170
	{
		// Fields
		private static readonly MiHoYo.SDK.Protobuf.MessageParser<SourceCodeInfo> _parser; // 0x00
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<Types.Location> _repeated_location_codec; // 0x08
		private readonly RepeatedField<Types.Location> location_; // 0x10
	
		// Properties
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.MessageParser<SourceCodeInfo> Parser { get => default; } // 0x0000000187D69CF0-0x0000000187D69D80 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000187D69BD0-0x0000000187D69CF0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000187D69D80-0x0000000187D69E00 
	
		// Nested types
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static class Types // TypeDefIndex: 5171
		{
			// Nested types
			internal sealed class Location : MiHoYo.SDK.Protobuf.IMessage<Location> // TypeDefIndex: 5172
			{
				// Fields
				private static readonly MiHoYo.SDK.Protobuf.MessageParser<Location> _parser; // 0x00
				private static readonly MiHoYo.SDK.Protobuf.FieldCodec<int> _repeated_path_codec; // 0x08
				private readonly RepeatedField<int> path_; // 0x10
				private static readonly MiHoYo.SDK.Protobuf.FieldCodec<int> _repeated_span_codec; // 0x10
				private readonly RepeatedField<int> span_; // 0x18
				private string leadingComments_; // 0x20
				private string trailingComments_; // 0x28
				private static readonly MiHoYo.SDK.Protobuf.FieldCodec<string> _repeated_leadingDetachedComments_codec; // 0x18
				private readonly RepeatedField<string> leadingDetachedComments_; // 0x30
	
				// Properties
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public static MiHoYo.SDK.Protobuf.MessageParser<Location> Parser { get => default; } // 0x0000000187D5D3F0-0x0000000187D5D480 
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public static MessageDescriptor Descriptor { get => default; } // 0x0000000187D5D240-0x0000000187D5D390 
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000187D5D4E0-0x0000000187D5D560 
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public string LeadingComments { get => default; set {} } // 0x0000000187D5D390-0x0000000187D5D3F0 0x0000000187D5D560-0x0000000187D5D5E0
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public string TrailingComments { get => default; set {} } // 0x0000000187D5D480-0x0000000187D5D4E0 0x0000000187D5D5E0-0x0000000187D5D660
	
				// Constructors
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public Location() {} // 0x0000000187D5D060-0x0000000187D5D150
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public Location(Location other) {} // 0x0000000187D5D150-0x0000000187D5D240
				static Location() {} // 0x0000000187D5CF00-0x0000000187D5D060
	
				// Methods
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public Location Clone() => default; // 0x0000000187D5C460-0x0000000187D5C4E0
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public override bool Equals(object other) => default; // 0x0000000187D5C690-0x0000000187D5C720
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public bool Equals(Location other) => default; // 0x0000000187D5C4E0-0x0000000187D5C690
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public override int GetHashCode() => default; // 0x0000000187D5C720-0x0000000187D5C970
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public override string ToString() => default; // 0x0000000187D5CBB0-0x0000000187D5CC40
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x0000000187D5CC40-0x0000000187D5CF00
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public int CalculateSize() => default; // 0x0000000187D5C190-0x0000000187D5C460
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x0000000187D5C970-0x0000000187D5CBB0
			}
		}
	
		// Constructors
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public SourceCodeInfo() {} // 0x0000000187D69AA0-0x0000000187D69B30
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public SourceCodeInfo(SourceCodeInfo other) {} // 0x0000000187D69B30-0x0000000187D69BD0
		static SourceCodeInfo() {} // 0x0000000187D69950-0x0000000187D69AA0
	
		// Methods
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public SourceCodeInfo Clone() => default; // 0x0000000187D694D0-0x0000000187D69550
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override bool Equals(object other) => default; // 0x0000000187D695F0-0x0000000187D69680
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Equals(SourceCodeInfo other) => default; // 0x0000000187D69550-0x0000000187D695F0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override int GetHashCode() => default; // 0x0000000187D69680-0x0000000187D69700
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override string ToString() => default; // 0x0000000187D69800-0x0000000187D69890
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x0000000187D69890-0x0000000187D69950
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public int CalculateSize() => default; // 0x0000000187D69420-0x0000000187D694D0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x0000000187D69700-0x0000000187D69800
	}
}
