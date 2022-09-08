/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ModifierDurability : MessageBase, IMessage<ModifierDurability> // TypeDefIndex: 25997
{
	// Fields
	private static readonly MessageParser<ModifierDurability> _parser; // 0x00
	public const int ReduceRatioFieldNumber = 1; // Metadata: 0x00B0A9AB
	private float reduceRatio_; // 0x18
	public const int RemainingDurabilityFieldNumber = 2; // Metadata: 0x00B0A9AF
	private float remainingDurability_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ModifierDurability> Parser { get => default; } // 0x0000000184BE3E50-0x0000000184BE3EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184BE3BE0-0x0000000184BE3C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184BE38B0-0x0000000184BE3930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184BE3180-0x0000000184BE31E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184BE41F0-0x0000000184BE42E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184BE4010-0x0000000184BE4070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184BE3C70-0x0000000184BE3D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184BE41A0-0x0000000184BE41F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184BE39D0-0x0000000184BE3AC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float ReduceRatio { get => default; set {} } // 0x0000000184BE30E0-0x0000000184BE3180 0x0000000184BE3810-0x0000000184BE38B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float RemainingDurability { get => default; set {} } // 0x0000000184BE31E0-0x0000000184BE3280 0x0000000184BE34A0-0x0000000184BE3540

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ModifierDurability() {} // 0x0000000184BE45B0-0x0000000184BE4610
	static ModifierDurability() {} // 0x0000000184BE44F0-0x0000000184BE45B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ModifierDurability Clone() => default; // 0x0000000184BE3D60-0x0000000184BE3E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ModifierDurability ShallowCopy() => default; // 0x0000000184BE3930-0x0000000184BE39D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184BE33D0-0x0000000184BE3420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184BE3F70-0x0000000184BE3FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184BE3FC0-0x0000000184BE4010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184BE3420-0x0000000184BE34A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184BE3540-0x0000000184BE3610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ModifierDurability other) => default; // 0x0000000184BE3610-0x0000000184BE3730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184BE3AC0-0x0000000184BE3BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184BE42E0-0x0000000184BE44F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184BE4070-0x0000000184BE41A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184BE3730-0x0000000184BE3810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ModifierDurability other) {} // 0x0000000184BE3280-0x0000000184BE33D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184BE2FE0-0x0000000184BE30E0
}

