/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AnchorPointData : MessageBase, IMessage<AnchorPointData> // TypeDefIndex: 25801
{
	// Fields
	private static readonly MessageParser<AnchorPointData> _parser; // 0x00
	public const int AnchorPointIdFieldNumber = 1; // Metadata: 0x00B0999B
	private uint anchorPointId_; // 0x18
	public const int PosFieldNumber = 2; // Metadata: 0x00B0999F
	private Vector pos_; // 0x20
	public const int RotFieldNumber = 3; // Metadata: 0x00B099A3
	private Vector rot_; // 0x28
	public const int EndTimeFieldNumber = 4; // Metadata: 0x00B099A7
	private uint endTime_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AnchorPointData> Parser { get => default; } // 0x0000000182240170-0x0000000182240200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018223FDC0-0x000000018223FE50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018223F960-0x000000018223F9E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018223EE30-0x000000018223EE90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001822407D0-0x00000001822408C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001822404F0-0x0000000182240550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018223FEF0-0x000000018223FFE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182240780-0x00000001822407D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018223FA80-0x000000018223FB70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AnchorPointId { get => default; set {} } // 0x000000018223EBE0-0x000000018223EC80 0x000000018223F3E0-0x000000018223F480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x00000001822403B0-0x0000000182240450 0x00000001822406E0-0x0000000182240780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Rot { get => default; set {} } // 0x000000018223FE50-0x000000018223FEF0 0x000000018223EE90-0x000000018223EF30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EndTime { get => default; set {} } // 0x00000001822400D0-0x0000000182240170 0x0000000182240450-0x00000001822404F0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AnchorPointData() {} // 0x0000000182240C60-0x0000000182240CC0
	static AnchorPointData() {} // 0x0000000182240BA0-0x0000000182240C60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AnchorPointData Clone() => default; // 0x000000018223FFE0-0x00000001822400D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AnchorPointData ShallowCopy() => default; // 0x000000018223F9E0-0x000000018223FA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018223F150-0x000000018223F1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182240290-0x0000000182240320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182240320-0x00000001822403B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018223F1E0-0x000000018223F3E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018223F600-0x000000018223F6D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AnchorPointData other) => default; // 0x000000018223F480-0x000000018223F600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018223FB70-0x000000018223FDC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001822408C0-0x0000000182240BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182240550-0x00000001822406E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018223F6D0-0x000000018223F960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AnchorPointData other) {} // 0x000000018223EF30-0x000000018223F150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018223EC80-0x000000018223EE30
}

