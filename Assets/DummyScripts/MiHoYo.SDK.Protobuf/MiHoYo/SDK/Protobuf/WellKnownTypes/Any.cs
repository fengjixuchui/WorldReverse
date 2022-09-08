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
	public sealed class Any : MiHoYo.SDK.Protobuf.IMessage<Any> // TypeDefIndex: 5097
	{
		// Fields
		private static readonly MiHoYo.SDK.Protobuf.MessageParser<Any> _parser; // 0x00
		private string typeUrl_; // 0x10
		private MiHoYo.SDK.Protobuf.ByteString value_; // 0x18
	
		// Properties
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.MessageParser<Any> Parser { get => default; } // 0x0000000187D574F0-0x0000000187D57580 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.Reflection.MessageDescriptor Descriptor { get => default; } // 0x0000000187D573D0-0x0000000187D574F0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		MiHoYo.SDK.Protobuf.Reflection.MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000187D57640-0x0000000187D576C0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string TypeUrl { get => default; set {} } // 0x0000000187D57580-0x0000000187D575E0 0x0000000187D576C0-0x0000000187D57740
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public MiHoYo.SDK.Protobuf.ByteString Value { get => default; set {} } // 0x0000000187D575E0-0x0000000187D57640 0x0000000187D57740-0x0000000187D577C0
	
		// Constructors
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public Any() {} // 0x0000000187D572A0-0x0000000187D57340
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public Any(Any other) {} // 0x0000000187D57340-0x0000000187D573D0
		static Any() {} // 0x0000000187D571A0-0x0000000187D572A0
	
		// Methods
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public Any Clone() => default; // 0x0000000187D56940-0x0000000187D569C0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override bool Equals(object other) => default; // 0x0000000187D569C0-0x0000000187D56A50
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Equals(Any other) => default; // 0x0000000187D56A50-0x0000000187D56BD0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override int GetHashCode() => default; // 0x0000000187D56BD0-0x0000000187D56DB0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override string ToString() => default; // 0x0000000187D56F20-0x0000000187D56FB0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x0000000187D56FB0-0x0000000187D571A0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public int CalculateSize() => default; // 0x0000000187D56750-0x0000000187D56940
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x0000000187D56E50-0x0000000187D56F20
		internal static string GetTypeName(string typeUrl) => default; // 0x0000000187D56DB0-0x0000000187D56E50
	}
}
