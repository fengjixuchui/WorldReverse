/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlatformInfo : MessageBase, IMessage<PlatformInfo> // TypeDefIndex: 26019
{
	// Fields
	private static readonly MessageParser<PlatformInfo> _parser; // 0x00
	public const int RouteIdFieldNumber = 1; // Metadata: 0x00B0AB9F
	private uint routeId_; // 0x18
	public const int StartIndexFieldNumber = 2; // Metadata: 0x00B0ABA3
	private int startIndex_; // 0x1C
	public const int StartRouteTimeFieldNumber = 3; // Metadata: 0x00B0ABA7
	private uint startRouteTime_; // 0x20
	public const int StartSceneTimeFieldNumber = 4; // Metadata: 0x00B0ABAB
	private uint startSceneTime_; // 0x24
	public const int StartPosFieldNumber = 7; // Metadata: 0x00B0ABAF
	private Vector startPos_; // 0x28
	public const int IsStartedFieldNumber = 8; // Metadata: 0x00B0ABB3
	private bool isStarted_; // 0x30
	public const int StartRotFieldNumber = 9; // Metadata: 0x00B0ABB7
	private MathQuaternion startRot_; // 0x38
	public const int StopSceneTimeFieldNumber = 10; // Metadata: 0x00B0ABBB
	private uint stopSceneTime_; // 0x40
	public const int PosOffsetFieldNumber = 11; // Metadata: 0x00B0ABBF
	private Vector posOffset_; // 0x48
	public const int RotOffsetFieldNumber = 12; // Metadata: 0x00B0ABC3
	private MathQuaternion rotOffset_; // 0x50
	public const int MovingPlatformTypeFieldNumber = 13; // Metadata: 0x00B0ABC7
	private MovingPlatformType movingPlatformType_; // 0x58
	public const int IsActiveFieldNumber = 14; // Metadata: 0x00B0ABCB
	private bool isActive_; // 0x5C
	public const int RouteFieldNumber = 15; // Metadata: 0x00B0ABCF
	private Route route_; // 0x60
	public const int PointIdFieldNumber = 16; // Metadata: 0x00B0ABD3
	private uint pointId_; // 0x68

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlatformInfo> Parser { get => default; } // 0x00000001817C8A90-0x00000001817C8B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001817C83C0-0x00000001817C8450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001817C7AD0-0x00000001817C7B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001817C5E80-0x00000001817C5EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001817C9520-0x00000001817C9610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001817C8FD0-0x00000001817C9030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001817C8810-0x00000001817C8900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001817C94D0-0x00000001817C9520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001817C7C90-0x00000001817C7D80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RouteId { get => default; set {} } // 0x00000001817C6DC0-0x00000001817C6E60 0x00000001817C89F0-0x00000001817C8A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int StartIndex { get => default; set {} } // 0x00000001817C8320-0x00000001817C83C0 0x00000001817C8E90-0x00000001817C8F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StartRouteTime { get => default; set {} } // 0x00000001817C64A0-0x00000001817C6540 0x00000001817C8450-0x00000001817C84F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StartSceneTime { get => default; set {} } // 0x00000001817C8C50-0x00000001817C8CF0 0x00000001817C5EE0-0x00000001817C5F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector StartPos { get => default; set {} } // 0x00000001817C6C80-0x00000001817C6D20 0x00000001817C7BF0-0x00000001817C7C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsStarted { get => default; set {} } // 0x00000001817C78F0-0x00000001817C7990 0x00000001817C66B0-0x00000001817C6750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MathQuaternion StartRot { get => default; set {} } // 0x00000001817C6610-0x00000001817C66B0 0x00000001817C8590-0x00000001817C8630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StopSceneTime { get => default; set {} } // 0x00000001817C7990-0x00000001817C7A30 0x00000001817C7A30-0x00000001817C7AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector PosOffset { get => default; set {} } // 0x00000001817C6D20-0x00000001817C6DC0 0x00000001817C8630-0x00000001817C86D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MathQuaternion RotOffset { get => default; set {} } // 0x00000001817C5F80-0x00000001817C6020 0x00000001817C86D0-0x00000001817C8770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MovingPlatformType MovingPlatformType { get => default; set {} } // 0x00000001817C8770-0x00000001817C8810 0x00000001817C6BE0-0x00000001817C6C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsActive { get => default; set {} } // 0x00000001817C8F30-0x00000001817C8FD0 0x00000001817C9030-0x00000001817C90D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Route Route { get => default; set {} } // 0x00000001817C8BB0-0x00000001817C8C50 0x00000001817C5DE0-0x00000001817C5E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PointId { get => default; set {} } // 0x00000001817C84F0-0x00000001817C8590 0x00000001817C6E60-0x00000001817C6F00

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlatformInfo() {} // 0x00000001817C9EF0-0x00000001817C9F60
	static PlatformInfo() {} // 0x00000001817C9E30-0x00000001817C9EF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlatformInfo Clone() => default; // 0x00000001817C8900-0x00000001817C89F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlatformInfo ShallowCopy() => default; // 0x00000001817C7B50-0x00000001817C7BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001817C6540-0x00000001817C6610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001817C8CF0-0x00000001817C8DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001817C8DC0-0x00000001817C8E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001817C6750-0x00000001817C6BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001817C71E0-0x00000001817C72B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlatformInfo other) => default; // 0x00000001817C6F00-0x00000001817C71E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001817C7D80-0x00000001817C8320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001817C9610-0x00000001817C9E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001817C90D0-0x00000001817C94D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001817C72B0-0x00000001817C78F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlatformInfo other) {} // 0x00000001817C6020-0x00000001817C64A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001817C5A60-0x00000001817C5DE0
}

