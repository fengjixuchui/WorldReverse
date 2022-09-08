/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MonsterRoute : MessageBase, IMessage<MonsterRoute> // TypeDefIndex: 26024
{
	// Fields
	private static readonly MessageParser<MonsterRoute> _parser; // 0x00
	public const int RoutePointsFieldNumber = 1; // Metadata: 0x00B0AC13
	private static readonly FieldCodec<RoutePoint> _repeated_routePoints_codec; // 0x08
	private readonly RepeatedMessageField<RoutePoint> routePoints_; // 0x18
	public const int SpeedLevelFieldNumber = 2; // Metadata: 0x00B0AC17
	private uint speedLevel_; // 0x20
	public const int RouteTypeFieldNumber = 3; // Metadata: 0x00B0AC1B
	private uint routeType_; // 0x24
	public const int ArriveRangeFieldNumber = 4; // Metadata: 0x00B0AC1F
	private float arriveRange_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MonsterRoute> Parser { get => default; } // 0x00000001820A3EE0-0x00000001820A3F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001820A3B30-0x00000001820A3BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001820A36B0-0x00000001820A3730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001820A2EB0-0x00000001820A2F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001820A44E0-0x00000001820A45D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001820A4120-0x00000001820A4180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001820A3C60-0x00000001820A3D50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001820A4490-0x00000001820A44E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001820A3830-0x00000001820A3920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<RoutePoint> RoutePoints { get => default; } // 0x00000001820A37D0-0x00000001820A3830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SpeedLevel { get => default; set {} } // 0x00000001820A3BC0-0x00000001820A3C60 0x00000001820A3E40-0x00000001820A3EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RouteType { get => default; set {} } // 0x00000001820A4180-0x00000001820A4220 0x00000001820A3A90-0x00000001820A3B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float ArriveRange { get => default; set {} } // 0x00000001820A3120-0x00000001820A31C0 0x00000001820A43F0-0x00000001820A4490

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MonsterRoute() {} // 0x00000001820A49E0-0x00000001820A4A70
	static MonsterRoute() {} // 0x00000001820A48D0-0x00000001820A49E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MonsterRoute Clone() => default; // 0x00000001820A3D50-0x00000001820A3E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MonsterRoute ShallowCopy() => default; // 0x00000001820A3730-0x00000001820A37D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001820A30D0-0x00000001820A3120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001820A4000-0x00000001820A4090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001820A4090-0x00000001820A4120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001820A31C0-0x00000001820A32C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001820A32C0-0x00000001820A3390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MonsterRoute other) => default; // 0x00000001820A3390-0x00000001820A3500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001820A3920-0x00000001820A3A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001820A45D0-0x00000001820A48D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001820A4220-0x00000001820A43F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001820A3500-0x00000001820A36B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MonsterRoute other) {} // 0x00000001820A2F10-0x00000001820A30D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001820A2D10-0x00000001820A2EB0
}

