/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class ExtensionRangeOptions : MessageBase, IMessage<ExtensionRangeOptions> // TypeDefIndex: 26361
{
	// Fields
	private static readonly MessageParser<ExtensionRangeOptions> _parser; // 0x00
	public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x00B0BF29
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x08
	private readonly RepeatedMessageField<UninterpretedOption> uninterpretedOption_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ExtensionRangeOptions> Parser { /* [XID] */ /* 0x000000018966FCC0-0x000000018966FCE0 */ get => default; } // 0x0000000182962740-0x0000000182962810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x00000001896774E0-0x0000000189677500 */ get => default; } // 0x00000001829623A0-0x0000000182962490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x000000018967EA70-0x000000018967EA90 */ get => default; } // 0x0000000182961FF0-0x00000001829620C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x0000000189686380-0x00000001896863A0 */ get => default; } // 0x0000000182961730-0x00000001829617D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x000000018968E1F0-0x000000018968E210 */ get => default; } // 0x0000000182962CC0-0x0000000182962DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x0000000189695AA0-0x0000000189695AC0 */ get => default; } // 0x0000000182962A40-0x0000000182962AE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x000000018969D190-0x000000018969D1B0 */ get => default; } // 0x0000000182962510-0x0000000182962610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x00000001896A4320-0x00000001896A4340 */ get => default; } // 0x0000000182962C20-0x0000000182962CC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x00000001896AB9F0-0x00000001896ABA10 */ get => default; } // 0x00000001829621A0-0x00000001829622A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<UninterpretedOption> UninterpretedOption { /* [XID] */ /* 0x00000001896F0AB0-0x00000001896F0AD0 */ get => default; } // 0x0000000182961E20-0x0000000182961EC0 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExtensionRangeOptions() {} // 0x0000000182963060-0x00000001829630F0
	static ExtensionRangeOptions() {} // 0x0000000182962F50-0x0000000182963060

	// Methods
	[DebuggerNonUserCode] // 0x00000001896B2BC0-0x00000001896B2C00
	// [XID] // 0x00000001896B2BC0-0x00000001896B2C00
	public ExtensionRangeOptions Clone() => default; // 0x0000000182962610-0x0000000182962740
	[DebuggerNonUserCode] // 0x00000001896BD230-0x00000001896BD270
	// [XID] // 0x00000001896BD230-0x00000001896BD270
	public ExtensionRangeOptions ShallowCopy() => default; // 0x00000001829620C0-0x00000001829621A0
	[DebuggerNonUserCode] // 0x00000001896C78C0-0x00000001896C7900
	// [XID] // 0x00000001896C78C0-0x00000001896C7900
	protected override void InternalSetInPool(bool value) {} // 0x00000001829619C0-0x0000000182961A70
	[DebuggerNonUserCode] // 0x00000001896D1B70-0x00000001896D1BB0
	// [XID] // 0x00000001896D1B70-0x00000001896D1BB0
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001829628A0-0x0000000182962970
	[DebuggerNonUserCode] // 0x00000001896DC190-0x00000001896DC1D0
	// [XID] // 0x00000001896DC190-0x00000001896DC1D0
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182962970-0x0000000182962A40
	[DebuggerNonUserCode] // 0x00000001896E6790-0x00000001896E67D0
	// [XID] // 0x00000001896E6790-0x00000001896E67D0
	public override void Reset() {} // 0x0000000182961A70-0x0000000182961B50
	[DebuggerNonUserCode] // 0x00000001896F82A0-0x00000001896F82F0
	// [IDTag] // 0x00000001896F82A0-0x00000001896F82F0
	// [XID] // 0x00000001896F82A0-0x00000001896F82F0
	public override bool Equals(object other) => default; // 0x0000000182961BC0-0x0000000182961CD0
	[DebuggerNonUserCode] // 0x0000000189705980-0x00000001897059D0
	// [IDTag] // 0x0000000189705980-0x00000001897059D0
	// [XID] // 0x0000000189705980-0x00000001897059D0
	public bool Equals(ExtensionRangeOptions other) => default; // 0x0000000182961CD0-0x0000000182961E20
	[DebuggerNonUserCode] // 0x0000000189713330-0x0000000189713370
	// [XID] // 0x0000000189713330-0x0000000189713370
	public override int GetHashCode() => default; // 0x00000001829622A0-0x00000001829623A0
	[DebuggerNonUserCode] // 0x000000018971DA30-0x000000018971DA70
	// [XID] // 0x000000018971DA30-0x000000018971DA70
	public override string ToString() => default; // 0x0000000182962DC0-0x0000000182962F50
	[DebuggerNonUserCode] // 0x0000000189727FE0-0x0000000189728020
	// [XID] // 0x0000000189727FE0-0x0000000189728020
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182962AE0-0x0000000182962C20
	[DebuggerNonUserCode] // 0x00000001897325B0-0x00000001897325F0
	// [XID] // 0x00000001897325B0-0x00000001897325F0
	public override int CalculateSize() => default; // 0x0000000182961EC0-0x0000000182961FF0
	[DebuggerNonUserCode] // 0x000000018973CF80-0x000000018973CFC0
	// [XID] // 0x000000018973CF80-0x000000018973CFC0
	public void CopyFrom(ExtensionRangeOptions other) {} // 0x0000000182961840-0x00000001829619C0
	[DebuggerNonUserCode] // 0x00000001897477C0-0x0000000189747800
	// [XID] // 0x00000001897477C0-0x0000000189747800
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001829615B0-0x0000000182961730
}

