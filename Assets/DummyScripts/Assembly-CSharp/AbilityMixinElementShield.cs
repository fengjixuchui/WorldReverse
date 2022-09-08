/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityMixinElementShield : MessageBase, IMessage<AbilityMixinElementShield> // TypeDefIndex: 21780
{
	// Fields
	private static readonly MessageParser<AbilityMixinElementShield> _parser; // 0x00
	public const int SubShieldFieldNumber = 1; // Metadata: 0x00AFFFAF
	private float subShield_; // 0x18
	public const int IsShieldBrokenFieldNumber = 2; // Metadata: 0x00AFFFB3
	private bool isShieldBroken_; // 0x1C
	public const int ShieldFieldNumber = 3; // Metadata: 0x00AFFFB7
	private float shield_; // 0x20
	public const int MaxShieldFieldNumber = 4; // Metadata: 0x00AFFFBB
	private float maxShield_; // 0x24
	public const int AbsorbTypeFieldNumber = 5; // Metadata: 0x00AFFFBF
	private uint absorbType_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityMixinElementShield> Parser { get => default; } // 0x00000001830406B0-0x0000000183040740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183040300-0x0000000183040390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018303FD40-0x000000018303FDC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018303F550-0x000000018303F5B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183040D00-0x0000000183040DF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001830409B0-0x0000000183040A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183040430-0x0000000183040520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183040CB0-0x0000000183040D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018303FFA0-0x0000000183040090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float SubShield { get => default; set {} } // 0x0000000183040910-0x00000001830409B0 0x0000000183040740-0x00000001830407E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsShieldBroken { get => default; set {} } // 0x000000018303F860-0x000000018303F900 0x000000018303FDC0-0x000000018303FE60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float Shield { get => default; set {} } // 0x0000000183040C10-0x0000000183040CB0 0x0000000183040390-0x0000000183040430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float MaxShield { get => default; set {} } // 0x000000018303FF00-0x000000018303FFA0 0x0000000183040610-0x00000001830406B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AbsorbType { get => default; set {} } // 0x000000018303FCA0-0x000000018303FD40 0x0000000183040260-0x0000000183040300

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinElementShield() {} // 0x0000000183041260-0x00000001830412C0
	static AbilityMixinElementShield() {} // 0x00000001830411A0-0x0000000183041260

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinElementShield Clone() => default; // 0x0000000183040520-0x0000000183040610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinElementShield ShallowCopy() => default; // 0x000000018303FE60-0x000000018303FF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018303F770-0x000000018303F7C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183040870-0x00000001830408C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001830408C0-0x0000000183040910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018303F7C0-0x000000018303F860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018303F900-0x000000018303F9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityMixinElementShield other) => default; // 0x000000018303F9D0-0x000000018303FB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183040090-0x0000000183040260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183040DF0-0x00000001830411A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183040A10-0x0000000183040C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018303FB60-0x000000018303FCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityMixinElementShield other) {} // 0x000000018303F5B0-0x000000018303F770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018303F3C0-0x000000018303F550
}

