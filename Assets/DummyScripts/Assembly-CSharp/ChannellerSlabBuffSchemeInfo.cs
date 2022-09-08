/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChannellerSlabBuffSchemeInfo : MessageBase, IMessage<ChannellerSlabBuffSchemeInfo> // TypeDefIndex: 22265
{
	// Fields
	private static readonly MessageParser<ChannellerSlabBuffSchemeInfo> _parser; // 0x00
	public const int SlotMapFieldNumber = 1; // Metadata: 0x00B012FB
	private static readonly MapField<uint, uint> _map_slotMap_codec; // 0x08
	private readonly MapField<uint, uint> slotMap_; // 0x18
	public const int TotalEnergyFieldNumber = 2; // Metadata: 0x00B012FF
	private uint totalEnergy_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChannellerSlabBuffSchemeInfo> Parser { get => default; } // 0x00000001833B4180-0x00000001833B4210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001833B3F10-0x00000001833B3FA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001833B3BD0-0x00000001833B3C50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001833B33D0-0x00000001833B3430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001833B4530-0x00000001833B4620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001833B4340-0x00000001833B43A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001833B3FA0-0x00000001833B4090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001833B44E0-0x00000001833B4530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001833B3CF0-0x00000001833B3DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> SlotMap { get => default; } // 0x00000001833B3430-0x00000001833B3490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TotalEnergy { get => default; set {} } // 0x00000001833B3490-0x00000001833B3530 0x00000001833B3780-0x00000001833B3820

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabBuffSchemeInfo() {} // 0x00000001833B4930-0x00000001833B4BA0
	static ChannellerSlabBuffSchemeInfo() {} // 0x00000001833B4800-0x00000001833B4930

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabBuffSchemeInfo Clone() => default; // 0x00000001833B4090-0x00000001833B4180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabBuffSchemeInfo ShallowCopy() => default; // 0x00000001833B3C50-0x00000001833B3CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001833B3660-0x00000001833B36B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001833B42A0-0x00000001833B42F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001833B42F0-0x00000001833B4340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001833B36B0-0x00000001833B3780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001833B3820-0x00000001833B38F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChannellerSlabBuffSchemeInfo other) => default; // 0x00000001833B38F0-0x00000001833B3A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001833B3DE0-0x00000001833B3F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001833B4620-0x00000001833B4800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001833B43A0-0x00000001833B44E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001833B3A90-0x00000001833B3BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChannellerSlabBuffSchemeInfo other) {} // 0x00000001833B3530-0x00000001833B3660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001833B3270-0x00000001833B33D0
}

