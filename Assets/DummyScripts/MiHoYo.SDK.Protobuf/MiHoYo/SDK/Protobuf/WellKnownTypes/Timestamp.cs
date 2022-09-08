/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using MiHoYo.SDK.Protobuf;
using MiHoYo.SDK.Protobuf.Reflection;

// Image 46: MiHoYo.SDK.Protobuf.dll - Assembly: MiHoYo.SDK.Protobuf, Version=3.0.0.0, Culture=neutral, PublicKeyToken=a7d26565bac4d604 - Types 5068-5227

namespace MiHoYo.SDK.Protobuf.WellKnownTypes
{
	public sealed class Timestamp : MiHoYo.SDK.Protobuf.IMessage<Timestamp>, MiHoYo.SDK.Protobuf.ICustomDiagnosticMessage // TypeDefIndex: 5115
	{
		// Fields
		private static readonly MiHoYo.SDK.Protobuf.MessageParser<Timestamp> _parser; // 0x00
		private long seconds_; // 0x10
		private int nanos_; // 0x18
		private static readonly DateTime UnixEpoch; // 0x08
	
		// Properties
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.MessageParser<Timestamp> Parser { get => default; } // 0x0000000187D6CED0-0x0000000187D6CF60 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.Reflection.MessageDescriptor Descriptor { get => default; } // 0x0000000187D6CD50-0x0000000187D6CE70 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		MiHoYo.SDK.Protobuf.Reflection.MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000187D6CFC0-0x0000000187D6D040 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public long Seconds { get => default; set {} } // 0x0000000187D6CF60-0x0000000187D6CFC0 0x0000000187D6D0A0-0x0000000187D6D100
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public int Nanos { get => default; set {} } // 0x0000000187D6CE70-0x0000000187D6CED0 0x0000000187D6D040-0x0000000187D6D0A0
	
		// Constructors
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public Timestamp() {} // 0x0000000187D6CC20-0x0000000187D6CC80
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public Timestamp(Timestamp other) {} // 0x0000000187D6CC80-0x0000000187D6CD50
		static Timestamp() {} // 0x0000000187D6CAC0-0x0000000187D6CC20
	
		// Methods
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public Timestamp Clone() => default; // 0x0000000187D6BEB0-0x0000000187D6BF30
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override bool Equals(object other) => default; // 0x0000000187D6C050-0x0000000187D6C0E0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Equals(Timestamp other) => default; // 0x0000000187D6BF30-0x0000000187D6C050
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override int GetHashCode() => default; // 0x0000000187D6C0E0-0x0000000187D6C270
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override string ToString() => default; // 0x0000000187D6C880-0x0000000187D6C910
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x0000000187D6C910-0x0000000187D6CAC0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public int CalculateSize() => default; // 0x0000000187D6BD00-0x0000000187D6BEB0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x0000000187D6C300-0x0000000187D6C3D0
		private static bool IsNormalized(long seconds, int nanoseconds) => default; // 0x0000000187D6C270-0x0000000187D6C300
		internal static string ToJson(long seconds, int nanoseconds, bool diagnosticOnly) => default; // 0x0000000187D6C4F0-0x0000000187D6C880
		public string ToDiagnosticString() => default; // 0x0000000187D6C3D0-0x0000000187D6C4F0
	}
}
