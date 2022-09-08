/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BuildingInfo : MessageBase, IMessage<BuildingInfo> // TypeDefIndex: 26039
{
	// Fields
	private static readonly MessageParser<BuildingInfo> _parser; // 0x00
	public const int BuildingIdFieldNumber = 1; // Metadata: 0x00B0ACE3
	private uint buildingId_; // 0x18
	public const int PointConfigIdFieldNumber = 2; // Metadata: 0x00B0ACE7
	private uint pointConfigId_; // 0x1C
	public const int CostFieldNumber = 3; // Metadata: 0x00B0ACEB
	private uint cost_; // 0x20
	public const int LevelFieldNumber = 4; // Metadata: 0x00B0ACEF
	private uint level_; // 0x24
	public const int RefundFieldNumber = 5; // Metadata: 0x00B0ACF3
	private uint refund_; // 0x28
	public const int OwnerUidFieldNumber = 6; // Metadata: 0x00B0ACF7
	private uint ownerUid_; // 0x2C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BuildingInfo> Parser { get => default; } // 0x000000018342CBC0-0x000000018342CC50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018342C8B0-0x000000018342C940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018342C3A0-0x000000018342C420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018342B890-0x000000018342B8F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018342D2D0-0x000000018342D3C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018342CEC0-0x000000018342CF20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018342C9E0-0x000000018342CAD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018342D280-0x000000018342D2D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018342C560-0x000000018342C650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BuildingId { get => default; set {} } // 0x000000018342CE20-0x000000018342CEC0 0x000000018342CF20-0x000000018342CFC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PointConfigId { get => default; set {} } // 0x000000018342C810-0x000000018342C8B0 0x000000018342B8F0-0x000000018342B990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Cost { get => default; set {} } // 0x000000018342D1E0-0x000000018342D280 0x000000018342B990-0x000000018342BA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Level { get => default; set {} } // 0x000000018342BC00-0x000000018342BCA0 0x000000018342C4C0-0x000000018342C560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Refund { get => default; set {} } // 0x000000018342C0A0-0x000000018342C140 0x000000018342C940-0x000000018342C9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OwnerUid { get => default; set {} } // 0x000000018342CD80-0x000000018342CE20 0x000000018342BDA0-0x000000018342BE40

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BuildingInfo() {} // 0x000000018342D8B0-0x000000018342D910
	static BuildingInfo() {} // 0x000000018342D7F0-0x000000018342D8B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BuildingInfo Clone() => default; // 0x000000018342CAD0-0x000000018342CBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BuildingInfo ShallowCopy() => default; // 0x000000018342C420-0x000000018342C4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018342BCA0-0x000000018342BCF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018342CCE0-0x000000018342CD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018342CD30-0x000000018342CD80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018342BCF0-0x000000018342BDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018342BFD0-0x000000018342C0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BuildingInfo other) => default; // 0x000000018342BE40-0x000000018342BFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018342C650-0x000000018342C810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018342D3C0-0x000000018342D7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018342CFC0-0x000000018342D1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018342C140-0x000000018342C3A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BuildingInfo other) {} // 0x000000018342BA30-0x000000018342BC00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018342B720-0x000000018342B890
}

