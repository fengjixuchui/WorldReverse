/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Any : MessageBase, IMessage<Any> // TypeDefIndex: 26434
{
	// Fields
	private static readonly MessageParser<Any> _parser; // 0x00
	public const int TypeUrlFieldNumber = 1; // Metadata: 0x00B0C15D
	private string typeUrl_; // 0x18
	public const int ValueFieldNumber = 2; // Metadata: 0x00B0C161
	private ByteString value_; // 0x20
	private const string DefaultPrefix = "type.googleapis.com"; // Metadata: 0x00B0C165

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Any> Parser { /* [XID] */ /* 0x0000000189857F20-0x0000000189857F40 */ get => default; } // 0x0000000180DE8AC0-0x0000000180DE8B90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x000000018985F050-0x000000018985F070 */ get => default; } // 0x0000000180DE8640-0x0000000180DE8730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189866840-0x0000000189866860 */ get => default; } // 0x0000000180DE7FA0-0x0000000180DE8070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x000000018986E140-0x000000018986E160 */ get => default; } // 0x0000000180DE7640-0x0000000180DE76E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x00000001898755F0-0x0000000189875610 */ get => default; } // 0x0000000180DE9220-0x0000000180DE9320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x000000018987D140-0x000000018987D160 */ get => default; } // 0x0000000180DE8F50-0x0000000180DE8FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x00000001898840A0-0x00000001898840C0 */ get => default; } // 0x0000000180DE8890-0x0000000180DE8990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x000000018988B800-0x000000018988B820 */ get => default; } // 0x0000000180DE9180-0x0000000180DE9220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x0000000189892F00-0x0000000189892F20 */ get => default; } // 0x0000000180DE8150-0x0000000180DE8250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string TypeUrl { /* [XID] */ /* 0x00000001898D8F50-0x00000001898D8F70 */ get => default; /* [XID] */ /* 0x00000001898E0C40-0x00000001898E0C60 */ set {} } // 0x0000000180DE8CD0-0x0000000180DE8DB0 0x0000000180DE83E0-0x0000000180DE84D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ByteString Value { /* [XID] */ /* 0x00000001898E8750-0x00000001898E8770 */ get => default; /* [XID] */ /* 0x00000001898EFED0-0x00000001898EFEF0 */ set {} } // 0x0000000180DE87B0-0x0000000180DE8890 0x0000000180DE8DB0-0x0000000180DE8EA0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Any() {} // 0x0000000180DE9930-0x0000000180DE99D0
	static Any() {} // 0x0000000180DE9870-0x0000000180DE9930

	// Methods
	[DebuggerNonUserCode] // 0x000000018989A570-0x000000018989A5B0
	// [XID] // 0x000000018989A570-0x000000018989A5B0
	public Any Clone() => default; // 0x0000000180DE8990-0x0000000180DE8AC0
	[DebuggerNonUserCode] // 0x00000001898A4940-0x00000001898A4980
	// [XID] // 0x00000001898A4940-0x00000001898A4980
	public Any ShallowCopy() => default; // 0x0000000180DE8070-0x0000000180DE8150
	[DebuggerNonUserCode] // 0x00000001898AF120-0x00000001898AF160
	// [XID] // 0x00000001898AF120-0x00000001898AF160
	protected override void InternalSetInPool(bool value) {} // 0x0000000180DE7900-0x0000000180DE79B0
	[DebuggerNonUserCode] // 0x00000001898B9C90-0x00000001898B9CD0
	// [XID] // 0x00000001898B9C90-0x00000001898B9CD0
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180DE8C20-0x0000000180DE8CD0
	[DebuggerNonUserCode] // 0x00000001898C3F60-0x00000001898C3FA0
	// [XID] // 0x00000001898C3F60-0x00000001898C3FA0
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180DE8EA0-0x0000000180DE8F50
	[DebuggerNonUserCode] // 0x00000001898CE520-0x00000001898CE560
	// [XID] // 0x00000001898CE520-0x00000001898CE560
	public override void Reset() {} // 0x0000000180DE79B0-0x0000000180DE7A90
	[DebuggerNonUserCode] // 0x00000001898F7770-0x00000001898F77C0
	// [IDTag] // 0x00000001898F7770-0x00000001898F77C0
	// [XID] // 0x00000001898F7770-0x00000001898F77C0
	public override bool Equals(object other) => default; // 0x0000000180DE7B00-0x0000000180DE7C10
	[DebuggerNonUserCode] // 0x00000001899050A0-0x00000001899050F0
	// [IDTag] // 0x00000001899050A0-0x00000001899050F0
	// [XID] // 0x00000001899050A0-0x00000001899050F0
	public bool Equals(Any other) => default; // 0x0000000180DE7C10-0x0000000180DE7DF0
	[DebuggerNonUserCode] // 0x0000000189912A70-0x0000000189912AB0
	// [XID] // 0x0000000189912A70-0x0000000189912AB0
	public override int GetHashCode() => default; // 0x0000000180DE8250-0x0000000180DE83E0
	[DebuggerNonUserCode] // 0x000000018991D1C0-0x000000018991D200
	// [XID] // 0x000000018991D1C0-0x000000018991D200
	public override string ToString() => default; // 0x0000000180DE9670-0x0000000180DE9870
	[DebuggerNonUserCode] // 0x0000000189927860-0x00000001899278A0
	// [XID] // 0x0000000189927860-0x00000001899278A0
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000180DE8FF0-0x0000000180DE9180
	[DebuggerNonUserCode] // 0x0000000189931F90-0x0000000189931FD0
	// [XID] // 0x0000000189931F90-0x0000000189931FD0
	public override int CalculateSize() => default; // 0x0000000180DE7DF0-0x0000000180DE7FA0
	[DebuggerNonUserCode] // 0x000000018993C940-0x000000018993C980
	// [XID] // 0x000000018993C940-0x000000018993C980
	public void CopyFrom(Any other) {} // 0x0000000180DE7750-0x0000000180DE7900
	[DebuggerNonUserCode] // 0x0000000189946E40-0x0000000189946E80
	// [XID] // 0x0000000189946E40-0x0000000189946E80
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000180DE7500-0x0000000180DE7640
	// [XID] // 0x0000000189951680-0x00000001899516A0
	private static string GetTypeUrl(MessageDescriptor descriptor, string prefix) => default; // 0x0000000180DE84D0-0x0000000180DE8640
	// [XID] // 0x0000000189958C50-0x0000000189958C70
	public static string GetTypeName(string typeUrl) => default; // 0x0000000180DE9580-0x0000000180DE9670
	public T Unpack<T>()
		where T : IMessage, new() => default;
	public bool TryUnpack<T>(out T result)
		where T : IMessage, new() {
		result = default;
		return default;
	}
	// [IDTag] // 0x0000000189960350-0x0000000189960390
	// [XID] // 0x0000000189960350-0x0000000189960390
	public static Any Pack(IMessage message) => default; // 0x0000000180DE94B0-0x0000000180DE9580
	// [IDTag] // 0x000000018996A9F0-0x000000018996AA30
	// [XID] // 0x000000018996A9F0-0x000000018996AA30
	public static Any Pack(IMessage message, string typeUrlPrefix) => default; // 0x0000000180DE9320-0x0000000180DE94B0
}

