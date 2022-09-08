/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Mixin : MessageBase, IMessage<Mixin> // TypeDefIndex: 26438
{
	// Fields
	private static readonly MessageParser<Mixin> _parser; // 0x00
	public const int NameFieldNumber = 1; // Metadata: 0x00B0C1B4
	private string name_; // 0x18
	public const int RootFieldNumber = 2; // Metadata: 0x00B0C1B8
	private string root_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Mixin> Parser { /* [XID] */ /* 0x000000018975A980-0x000000018975A9A0 */ get => default; } // 0x0000000182781E10-0x0000000182781EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189762500-0x0000000189762520 */ get => default; } // 0x0000000182781980-0x0000000182781A70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189769B70-0x0000000189769B90 */ get => default; } // 0x0000000182781540-0x0000000182781610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x00000001897711D0-0x00000001897711F0 */ get => default; } // 0x0000000182780A30-0x0000000182780AD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x00000001897789F0-0x0000000189778A10 */ get => default; } // 0x0000000182782480-0x0000000182782580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x000000018977FF90-0x000000018977FFB0 */ get => default; } // 0x00000001827820D0-0x0000000182782170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x0000000189787800-0x0000000189787820 */ get => default; } // 0x0000000182781AF0-0x0000000182781BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x000000018978EED0-0x000000018978EEF0 */ get => default; } // 0x00000001827823E0-0x0000000182782480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x0000000189796710-0x0000000189796730 */ get => default; } // 0x00000001827816F0-0x00000001827817F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Name { /* [XID] */ /* 0x00000001897DDD40-0x00000001897DDD60 */ get => default; /* [XID] */ /* 0x00000001897E5770-0x00000001897E5790 */ set {} } // 0x0000000182781460-0x0000000182781540 0x0000000182780ED0-0x0000000182780FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Root { /* [XID] */ /* 0x00000001897ED200-0x00000001897ED220 */ get => default; /* [XID] */ /* 0x00000001897F49D0-0x00000001897F49F0 */ set {} } // 0x0000000182782300-0x00000001827823E0 0x0000000182781D20-0x0000000182781E10

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Mixin() {} // 0x0000000182782840-0x00000001827828C0
	static Mixin() {} // 0x0000000182782780-0x0000000182782840

	// Methods
	[DebuggerNonUserCode] // 0x000000018979E7C0-0x000000018979E800
	// [XID] // 0x000000018979E7C0-0x000000018979E800
	public Mixin Clone() => default; // 0x0000000182781BF0-0x0000000182781D20
	[DebuggerNonUserCode] // 0x00000001897A8A40-0x00000001897A8A80
	// [XID] // 0x00000001897A8A40-0x00000001897A8A80
	public Mixin ShallowCopy() => default; // 0x0000000182781610-0x00000001827816F0
	[DebuggerNonUserCode] // 0x00000001897B3750-0x00000001897B3790
	// [XID] // 0x00000001897B3750-0x00000001897B3790
	protected override void InternalSetInPool(bool value) {} // 0x0000000182780CF0-0x0000000182780DA0
	[DebuggerNonUserCode] // 0x00000001897BEA50-0x00000001897BEA90
	// [XID] // 0x00000001897BEA50-0x00000001897BEA90
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182781F70-0x0000000182782020
	[DebuggerNonUserCode] // 0x00000001897C9060-0x00000001897C90A0
	// [XID] // 0x00000001897C9060-0x00000001897C90A0
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182782020-0x00000001827820D0
	[DebuggerNonUserCode] // 0x00000001897D3610-0x00000001897D3650
	// [XID] // 0x00000001897D3610-0x00000001897D3650
	public override void Reset() {} // 0x0000000182780DA0-0x0000000182780E60
	[DebuggerNonUserCode] // 0x00000001897FC450-0x00000001897FC4A0
	// [IDTag] // 0x00000001897FC450-0x00000001897FC4A0
	// [XID] // 0x00000001897FC450-0x00000001897FC4A0
	public override bool Equals(object other) => default; // 0x0000000182780FC0-0x00000001827810D0
	[DebuggerNonUserCode] // 0x0000000189809690-0x00000001898096E0
	// [IDTag] // 0x0000000189809690-0x00000001898096E0
	// [XID] // 0x0000000189809690-0x00000001898096E0
	public bool Equals(Mixin other) => default; // 0x00000001827810D0-0x00000001827812B0
	[DebuggerNonUserCode] // 0x0000000189816EE0-0x0000000189816F20
	// [XID] // 0x0000000189816EE0-0x0000000189816F20
	public override int GetHashCode() => default; // 0x00000001827817F0-0x0000000182781980
	[DebuggerNonUserCode] // 0x0000000189821820-0x0000000189821860
	// [XID] // 0x0000000189821820-0x0000000189821860
	public override string ToString() => default; // 0x0000000182782580-0x0000000182782780
	[DebuggerNonUserCode] // 0x000000018982BF00-0x000000018982BF40
	// [XID] // 0x000000018982BF00-0x000000018982BF40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182782170-0x0000000182782300
	[DebuggerNonUserCode] // 0x0000000189836380-0x00000001898363C0
	// [XID] // 0x0000000189836380-0x00000001898363C0
	public override int CalculateSize() => default; // 0x00000001827812B0-0x0000000182781460
	[DebuggerNonUserCode] // 0x0000000189840760-0x00000001898407A0
	// [XID] // 0x0000000189840760-0x00000001898407A0
	public void CopyFrom(Mixin other) {} // 0x0000000182780B40-0x0000000182780CF0
	[DebuggerNonUserCode] // 0x000000018984AD20-0x000000018984AD60
	// [XID] // 0x000000018984AD20-0x000000018984AD60
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001827808F0-0x0000000182780A30
}

