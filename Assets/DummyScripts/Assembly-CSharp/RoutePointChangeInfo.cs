/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class RoutePointChangeInfo : MessageBase, IMessage<RoutePointChangeInfo> // TypeDefIndex: 25064
{
	// Fields
	private static readonly MessageParser<RoutePointChangeInfo> _parser; // 0x00
	public const int PointIndexFieldNumber = 1; // Metadata: 0x00B07E63
	private uint pointIndex_; // 0x18
	public const int TargetVelocityFieldNumber = 2; // Metadata: 0x00B07E67
	private float targetVelocity_; // 0x1C
	public const int WaitTimeFieldNumber = 3; // Metadata: 0x00B07E6B
	private float waitTime_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<RoutePointChangeInfo> Parser { get => default; } // 0x0000000182CAD490-0x0000000182CAD520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182CAD0E0-0x0000000182CAD170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182CACD80-0x0000000182CACE00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182CAC7A0-0x0000000182CAC800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182CADAF0-0x0000000182CADBE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182CAD6F0-0x0000000182CAD750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182CAD210-0x0000000182CAD300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182CADAA0-0x0000000182CADAF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182CACEA0-0x0000000182CACF90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PointIndex { get => default; set {} } // 0x0000000182CAD650-0x0000000182CAD6F0 0x0000000182CAD7F0-0x0000000182CAD890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float TargetVelocity { get => default; set {} } // 0x0000000182CAD750-0x0000000182CAD7F0 0x0000000182CAD3F0-0x0000000182CAD490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float WaitTime { get => default; set {} } // 0x0000000182CAD170-0x0000000182CAD210 0x0000000182CADA00-0x0000000182CADAA0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RoutePointChangeInfo() {} // 0x0000000182CADF30-0x0000000182CADF90
	static RoutePointChangeInfo() {} // 0x0000000182CADE70-0x0000000182CADF30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RoutePointChangeInfo Clone() => default; // 0x0000000182CAD300-0x0000000182CAD3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RoutePointChangeInfo ShallowCopy() => default; // 0x0000000182CACE00-0x0000000182CACEA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182CAC970-0x0000000182CAC9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182CAD5B0-0x0000000182CAD600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182CAD600-0x0000000182CAD650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182CAC9C0-0x0000000182CACA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182CACA40-0x0000000182CACB10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(RoutePointChangeInfo other) => default; // 0x0000000182CACB10-0x0000000182CACC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182CACF90-0x0000000182CAD0E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182CADBE0-0x0000000182CADE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182CAD890-0x0000000182CADA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182CACC60-0x0000000182CACD80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(RoutePointChangeInfo other) {} // 0x0000000182CAC800-0x0000000182CAC970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182CAC690-0x0000000182CAC7A0
}

