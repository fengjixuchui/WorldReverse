/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class OneofOptions : MessageBase, IMessage<OneofOptions> // TypeDefIndex: 26379
{
	// Fields
	private static readonly MessageParser<OneofOptions> _parser; // 0x00
	internal CustomOptions CustomOptions; // 0x18
	public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x00B0C08D
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x08
	private readonly RepeatedMessageField<UninterpretedOption> uninterpretedOption_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<OneofOptions> Parser { /* [XID] */ /* 0x0000000189651890-0x00000001896518B0 */ get => default; } // 0x00000001820C0F70-0x00000001820C1040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189659160-0x0000000189659180 */ get => default; } // 0x00000001820C0BD0-0x00000001820C0CC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189660820-0x0000000189660840 */ get => default; } // 0x00000001820C0820-0x00000001820C08F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x0000000189668220-0x0000000189668240 */ get => default; } // 0x00000001820BFF60-0x00000001820C0000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x000000018966FCA0-0x000000018966FCC0 */ get => default; } // 0x00000001820C14F0-0x00000001820C15F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x00000001896774C0-0x00000001896774E0 */ get => default; } // 0x00000001820C1270-0x00000001820C1310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x000000018967EA50-0x000000018967EA70 */ get => default; } // 0x00000001820C0D40-0x00000001820C0E40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x0000000189686360-0x0000000189686380 */ get => default; } // 0x00000001820C1450-0x00000001820C14F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x000000018968E1D0-0x000000018968E1F0 */ get => default; } // 0x00000001820C09D0-0x00000001820C0AD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<UninterpretedOption> UninterpretedOption { /* [XID] */ /* 0x00000001896D3090-0x00000001896D30B0 */ get => default; } // 0x00000001820C0650-0x00000001820C06F0 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OneofOptions() {} // 0x00000001820C1890-0x00000001820C1960
	static OneofOptions() {} // 0x00000001820C1780-0x00000001820C1890

	// Methods
	[DebuggerNonUserCode] // 0x0000000189695A60-0x0000000189695AA0
	// [XID] // 0x0000000189695A60-0x0000000189695AA0
	public OneofOptions Clone() => default; // 0x00000001820C0E40-0x00000001820C0F70
	[DebuggerNonUserCode] // 0x000000018969FFF0-0x00000001896A0030
	// [XID] // 0x000000018969FFF0-0x00000001896A0030
	public OneofOptions ShallowCopy() => default; // 0x00000001820C08F0-0x00000001820C09D0
	[DebuggerNonUserCode] // 0x00000001896AA3E0-0x00000001896AA420
	// [XID] // 0x00000001896AA3E0-0x00000001896AA420
	protected override void InternalSetInPool(bool value) {} // 0x00000001820C01F0-0x00000001820C02A0
	[DebuggerNonUserCode] // 0x00000001896B4960-0x00000001896B49A0
	// [XID] // 0x00000001896B4960-0x00000001896B49A0
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001820C10D0-0x00000001820C11A0
	[DebuggerNonUserCode] // 0x00000001896BE7A0-0x00000001896BE7E0
	// [XID] // 0x00000001896BE7A0-0x00000001896BE7E0
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001820C11A0-0x00000001820C1270
	[DebuggerNonUserCode] // 0x00000001896C8C30-0x00000001896C8C70
	// [XID] // 0x00000001896C8C30-0x00000001896C8C70
	public override void Reset() {} // 0x00000001820C02A0-0x00000001820C0380
	[DebuggerNonUserCode] // 0x00000001896DAC20-0x00000001896DAC70
	// [IDTag] // 0x00000001896DAC20-0x00000001896DAC70
	// [XID] // 0x00000001896DAC20-0x00000001896DAC70
	public override bool Equals(object other) => default; // 0x00000001820C03F0-0x00000001820C0500
	[DebuggerNonUserCode] // 0x00000001896E7E20-0x00000001896E7E70
	// [IDTag] // 0x00000001896E7E20-0x00000001896E7E70
	// [XID] // 0x00000001896E7E20-0x00000001896E7E70
	public bool Equals(OneofOptions other) => default; // 0x00000001820C0500-0x00000001820C0650
	[DebuggerNonUserCode] // 0x00000001896F5560-0x00000001896F55A0
	// [XID] // 0x00000001896F5560-0x00000001896F55A0
	public override int GetHashCode() => default; // 0x00000001820C0AD0-0x00000001820C0BD0
	[DebuggerNonUserCode] // 0x00000001896FFC20-0x00000001896FFC60
	// [XID] // 0x00000001896FFC20-0x00000001896FFC60
	public override string ToString() => default; // 0x00000001820C15F0-0x00000001820C1780
	[DebuggerNonUserCode] // 0x000000018970A3B0-0x000000018970A3F0
	// [XID] // 0x000000018970A3B0-0x000000018970A3F0
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001820C1310-0x00000001820C1450
	[DebuggerNonUserCode] // 0x0000000189714880-0x00000001897148C0
	// [XID] // 0x0000000189714880-0x00000001897148C0
	public override int CalculateSize() => default; // 0x00000001820C06F0-0x00000001820C0820
	[DebuggerNonUserCode] // 0x000000018971F230-0x000000018971F270
	// [XID] // 0x000000018971F230-0x000000018971F270
	public void CopyFrom(OneofOptions other) {} // 0x00000001820C0070-0x00000001820C01F0
	[DebuggerNonUserCode] // 0x00000001897295A0-0x00000001897295E0
	// [XID] // 0x00000001897295A0-0x00000001897295E0
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001820BFDD0-0x00000001820BFF60
}

