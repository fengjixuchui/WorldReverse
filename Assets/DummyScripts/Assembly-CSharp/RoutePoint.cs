/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class RoutePoint : MessageBase, IMessage<RoutePoint> // TypeDefIndex: 26020
{
	// Fields
	private static readonly MessageParser<RoutePoint> _parser; // 0x00
	public const int PositionFieldNumber = 1; // Metadata: 0x00B0ABD7
	private Vector position_; // 0x18
	public const int VelocityFieldNumber = 11; // Metadata: 0x00B0ABDB
	public const int TimeFieldNumber = 12; // Metadata: 0x00B0ABDF
	public const int RotationFieldNumber = 21; // Metadata: 0x00B0ABE3
	public const int RotationSpeedFieldNumber = 22; // Metadata: 0x00B0ABE7
	public const int AxisSpeedFieldNumber = 23; // Metadata: 0x00B0ABEB
	private object moveParams_; // 0x20
	private MoveParamsOneofCase moveParamsCase_; // 0x28
	private object rotateParams_; // 0x30
	private RotateParamsOneofCase rotateParamsCase_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<RoutePoint> Parser { get => default; } // 0x000000018594C640-0x000000018594C6D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018594BD40-0x000000018594BDD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018594B710-0x000000018594B790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018594A9F0-0x000000018594AA50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018594CF00-0x000000018594CFF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018594CA80-0x000000018594CAE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018594C110-0x000000018594C200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018594CEB0-0x000000018594CF00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018594B930-0x000000018594BA20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Position { get => default; set {} } // 0x000000018594B890-0x000000018594B930 0x000000018594C3C0-0x000000018594C460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float Velocity { get => default; set {} } // 0x000000018594ADE0-0x000000018594AEC0 0x000000018594C050-0x000000018594C110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float Time { get => default; set {} } // 0x000000018594C560-0x000000018594C640 0x000000018594AA50-0x000000018594AB10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Rotation { get => default; set {} } // 0x000000018594CDE0-0x000000018594CEB0 0x000000018594A8F0-0x000000018594A990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MathQuaternion RotationSpeed { get => default; set {} } // 0x000000018594BC70-0x000000018594BD40 0x000000018594C460-0x000000018594C500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MathQuaternion AxisSpeed { get => default; set {} } // 0x000000018594C2F0-0x000000018594C3C0 0x000000018594CD40-0x000000018594CDE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MoveParamsOneofCase MoveParamsCase { get => default; } // 0x000000018594B790-0x000000018594B7F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RotateParamsOneofCase RotateParamsCase { get => default; } // 0x000000018594A990-0x000000018594A9F0 

	// Nested types
	public enum MoveParamsOneofCase // TypeDefIndex: 26021
	{
		None = 0,
		Velocity = 11,
		Time = 12
	}

	public enum RotateParamsOneofCase // TypeDefIndex: 26022
	{
		None = 0,
		Rotation = 21,
		RotationSpeed = 22,
		AxisSpeed = 23
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RoutePoint() {} // 0x000000018594D580-0x000000018594D5F0
	static RoutePoint() {} // 0x000000018594D4C0-0x000000018594D580

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RoutePoint Clone() => default; // 0x000000018594C200-0x000000018594C2F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RoutePoint ShallowCopy() => default; // 0x000000018594B7F0-0x000000018594B890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018594AEC0-0x000000018594B050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018594C760-0x000000018594C8F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018594C8F0-0x000000018594CA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018594B050-0x000000018594B1E0
	public void resetMoveParams() {} // 0x000000018594CFF0-0x000000018594D070
	public void resetRotateParams() {} // 0x000000018594BDD0-0x000000018594C050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearMoveParams() {} // 0x000000018594CAE0-0x000000018594CB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearRotateParams() {} // 0x000000018594C500-0x000000018594C560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018594B410-0x000000018594B4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(RoutePoint other) => default; // 0x000000018594B1E0-0x000000018594B410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018594BA20-0x000000018594BC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018594D070-0x000000018594D4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018594CB40-0x000000018594CD40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018594B4E0-0x000000018594B710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(RoutePoint other) {} // 0x000000018594AB10-0x000000018594ADE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018594A5F0-0x000000018594A8F0
}

