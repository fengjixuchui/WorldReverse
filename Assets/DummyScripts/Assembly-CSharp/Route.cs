/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Route : MessageBase, IMessage<Route> // TypeDefIndex: 26023
{
	// Fields
	private static readonly MessageParser<Route> _parser; // 0x00
	public const int RoutePointsFieldNumber = 1; // Metadata: 0x00B0AC0B
	private static readonly FieldCodec<RoutePoint> _repeated_routePoints_codec; // 0x08
	private readonly RepeatedMessageField<RoutePoint> routePoints_; // 0x18
	public const int RouteTypeFieldNumber = 2; // Metadata: 0x00B0AC0F
	private uint routeType_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Route> Parser { get => default; } // 0x0000000183B2B190-0x0000000183B2B220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183B2AF20-0x0000000183B2AFB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183B2AB10-0x0000000183B2AB90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183B2A4E0-0x0000000183B2A540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183B2B660-0x0000000183B2B750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183B2B3D0-0x0000000183B2B430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183B2AFB0-0x0000000183B2B0A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183B2B610-0x0000000183B2B660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183B2AC90-0x0000000183B2AD80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<RoutePoint> RoutePoints { get => default; } // 0x0000000183B2AC30-0x0000000183B2AC90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RouteType { get => default; set {} } // 0x0000000183B2B430-0x0000000183B2B4D0 0x0000000183B2AE80-0x0000000183B2AF20

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Route() {} // 0x0000000183B2BA40-0x0000000183B2BAD0
	static Route() {} // 0x0000000183B2B930-0x0000000183B2BA40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Route Clone() => default; // 0x0000000183B2B0A0-0x0000000183B2B190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Route ShallowCopy() => default; // 0x0000000183B2AB90-0x0000000183B2AC30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183B2A6B0-0x0000000183B2A700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183B2B2B0-0x0000000183B2B340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183B2B340-0x0000000183B2B3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183B2A700-0x0000000183B2A7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183B2A900-0x0000000183B2A9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(Route other) => default; // 0x0000000183B2A7E0-0x0000000183B2A900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183B2AD80-0x0000000183B2AE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183B2B750-0x0000000183B2B930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183B2B4D0-0x0000000183B2B610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183B2A9D0-0x0000000183B2AB10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(Route other) {} // 0x0000000183B2A540-0x0000000183B2A6B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183B2A380-0x0000000183B2A4E0
}

