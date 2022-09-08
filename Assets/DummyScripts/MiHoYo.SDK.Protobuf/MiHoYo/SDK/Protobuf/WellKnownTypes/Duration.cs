/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using MiHoYo.SDK.Protobuf;
using MiHoYo.SDK.Protobuf.Reflection;

// Image 46: MiHoYo.SDK.Protobuf.dll - Assembly: MiHoYo.SDK.Protobuf, Version=3.0.0.0, Culture=neutral, PublicKeyToken=a7d26565bac4d604 - Types 5068-5227

namespace MiHoYo.SDK.Protobuf.WellKnownTypes
{
	public sealed class Duration : MiHoYo.SDK.Protobuf.IMessage<Duration>, MiHoYo.SDK.Protobuf.ICustomDiagnosticMessage // TypeDefIndex: 5100
	{
		// Fields
		private static readonly MiHoYo.SDK.Protobuf.MessageParser<Duration> _parser; // 0x00
		private long seconds_; // 0x10
		private int nanos_; // 0x18
	
		// Properties
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.MessageParser<Duration> Parser { get => default; } // 0x0000000187D59060-0x0000000187D590F0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.Reflection.MessageDescriptor Descriptor { get => default; } // 0x0000000187D58EE0-0x0000000187D59000 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		MiHoYo.SDK.Protobuf.Reflection.MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000187D59150-0x0000000187D591D0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public long Seconds { get => default; set {} } // 0x0000000187D590F0-0x0000000187D59150 0x0000000187D59230-0x0000000187D59290
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public int Nanos { get => default; set {} } // 0x0000000187D59000-0x0000000187D59060 0x0000000187D591D0-0x0000000187D59230
	
		// Constructors
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public Duration() {} // 0x0000000187D58DB0-0x0000000187D58E10
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public Duration(Duration other) {} // 0x0000000187D58E10-0x0000000187D58EE0
		static Duration() {} // 0x0000000187D58CB0-0x0000000187D58DB0
	
		// Methods
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public Duration Clone() => default; // 0x0000000187D580B0-0x0000000187D58130
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override bool Equals(object other) => default; // 0x0000000187D58130-0x0000000187D581C0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Equals(Duration other) => default; // 0x0000000187D581C0-0x0000000187D582E0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override int GetHashCode() => default; // 0x0000000187D582E0-0x0000000187D58470
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override string ToString() => default; // 0x0000000187D58A70-0x0000000187D58B00
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x0000000187D58B00-0x0000000187D58CB0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public int CalculateSize() => default; // 0x0000000187D57F00-0x0000000187D580B0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x0000000187D58540-0x0000000187D58610
		internal static bool IsNormalized(long seconds, int nanoseconds) => default; // 0x0000000187D58470-0x0000000187D58540
		internal static string ToJson(long seconds, int nanoseconds, bool diagnosticOnly) => default; // 0x0000000187D58730-0x0000000187D58A70
		public string ToDiagnosticString() => default; // 0x0000000187D58610-0x0000000187D58730
		internal static void AppendNanoseconds(StringBuilder builder, int nanos) {} // 0x0000000187D57D80-0x0000000187D57F00
	}
}
