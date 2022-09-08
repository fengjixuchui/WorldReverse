/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityMetaModifierDurabilityChange : MessageBase, IMessage<AbilityMetaModifierDurabilityChange> // TypeDefIndex: 21761
{
	// Fields
	private static readonly MessageParser<AbilityMetaModifierDurabilityChange> _parser; // 0x00
	public const int ReduceDurabilityFieldNumber = 1; // Metadata: 0x00AFFF23
	private float reduceDurability_; // 0x18
	public const int RemainDurabilityFieldNumber = 2; // Metadata: 0x00AFFF27
	private float remainDurability_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityMetaModifierDurabilityChange> Parser { get => default; } // 0x00000001828D3050-0x00000001828D30E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001828D2CA0-0x00000001828D2D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001828D2970-0x00000001828D29F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001828D2380-0x00000001828D23E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001828D3490-0x00000001828D3580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001828D3210-0x00000001828D3270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001828D2D30-0x00000001828D2E20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001828D3440-0x00000001828D3490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001828D2A90-0x00000001828D2B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float ReduceDurability { get => default; set {} } // 0x00000001828D2F10-0x00000001828D2FB0 0x00000001828D3270-0x00000001828D3310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float RemainDurability { get => default; set {} } // 0x00000001828D2FB0-0x00000001828D3050 0x00000001828D27F0-0x00000001828D2890

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMetaModifierDurabilityChange() {} // 0x00000001828D3850-0x00000001828D38B0
	static AbilityMetaModifierDurabilityChange() {} // 0x00000001828D3790-0x00000001828D3850

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMetaModifierDurabilityChange Clone() => default; // 0x00000001828D2E20-0x00000001828D2F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMetaModifierDurabilityChange ShallowCopy() => default; // 0x00000001828D29F0-0x00000001828D2A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001828D2530-0x00000001828D2580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001828D3170-0x00000001828D31C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001828D31C0-0x00000001828D3210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001828D2580-0x00000001828D2600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001828D2600-0x00000001828D26D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityMetaModifierDurabilityChange other) => default; // 0x00000001828D26D0-0x00000001828D27F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001828D2B80-0x00000001828D2CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001828D3580-0x00000001828D3790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001828D3310-0x00000001828D3440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001828D2890-0x00000001828D2970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityMetaModifierDurabilityChange other) {} // 0x00000001828D23E0-0x00000001828D2530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001828D2280-0x00000001828D2380
}

