/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityMixinShieldBar : MessageBase, IMessage<AbilityMixinShieldBar> // TypeDefIndex: 21782
{
	// Fields
	private static readonly MessageParser<AbilityMixinShieldBar> _parser; // 0x00
	public const int ElementTypeFieldNumber = 1; // Metadata: 0x00AFFFD7
	private uint elementType_; // 0x18
	public const int ShieldFieldNumber = 2; // Metadata: 0x00AFFFDB
	private float shield_; // 0x1C
	public const int MaxShieldFieldNumber = 3; // Metadata: 0x00AFFFDF
	private float maxShield_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityMixinShieldBar> Parser { get => default; } // 0x00000001840974D0-0x0000000184097560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184097080-0x0000000184097110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184096C80-0x0000000184096D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001840966A0-0x0000000184096700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001840979F0-0x0000000184097AE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184097690-0x00000001840976F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184097250-0x0000000184097340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001840979A0-0x00000001840979F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184096E40-0x0000000184096F30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ElementType { get => default; set {} } // 0x00000001840971B0-0x0000000184097250 0x00000001840976F0-0x0000000184097790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float Shield { get => default; set {} } // 0x0000000184097900-0x00000001840979A0 0x0000000184097110-0x00000001840971B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float MaxShield { get => default; set {} } // 0x0000000184096DA0-0x0000000184096E40 0x0000000184097430-0x00000001840974D0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinShieldBar() {} // 0x0000000184097E30-0x0000000184097E90
	static AbilityMixinShieldBar() {} // 0x0000000184097D70-0x0000000184097E30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinShieldBar Clone() => default; // 0x0000000184097340-0x0000000184097430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinShieldBar ShallowCopy() => default; // 0x0000000184096D00-0x0000000184096DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184096870-0x00000001840968C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001840975F0-0x0000000184097640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184097640-0x0000000184097690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001840968C0-0x0000000184096940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184096940-0x0000000184096A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityMixinShieldBar other) => default; // 0x0000000184096A10-0x0000000184096B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184096F30-0x0000000184097080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184097AE0-0x0000000184097D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184097790-0x0000000184097900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184096B60-0x0000000184096C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityMixinShieldBar other) {} // 0x0000000184096700-0x0000000184096870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184096590-0x00000001840966A0
}

