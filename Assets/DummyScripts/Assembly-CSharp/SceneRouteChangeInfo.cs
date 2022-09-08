/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneRouteChangeInfo : MessageBase, IMessage<SceneRouteChangeInfo> // TypeDefIndex: 25065
{
	// Fields
	private static readonly MessageParser<SceneRouteChangeInfo> _parser; // 0x00
	public const int RouteIdFieldNumber = 1; // Metadata: 0x00B07E6F
	private uint routeId_; // 0x18
	public const int TypeFieldNumber = 2; // Metadata: 0x00B07E73
	private uint type_; // 0x1C
	public const int IsForwardFieldNumber = 3; // Metadata: 0x00B07E77
	private bool isForward_; // 0x20
	public const int PointListFieldNumber = 4; // Metadata: 0x00B07E7B
	private static readonly FieldCodec<RoutePointChangeInfo> _repeated_pointList_codec; // 0x08
	private readonly RepeatedMessageField<RoutePointChangeInfo> pointList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneRouteChangeInfo> Parser { get => default; } // 0x000000018485B570-0x000000018485B600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018485B1C0-0x000000018485B250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018485AE50-0x000000018485AED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018485A610-0x000000018485A670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018485BB50-0x000000018485BC40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018485B850-0x000000018485B8B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018485B2F0-0x000000018485B3E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018485BA60-0x000000018485BAB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018485AF70-0x000000018485B060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RouteId { get => default; set {} } // 0x000000018485A9D0-0x000000018485AA70 0x000000018485B4D0-0x000000018485B570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Type { get => default; set {} } // 0x000000018485A3D0-0x000000018485A470 0x000000018485BAB0-0x000000018485BB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsForward { get => default; set {} } // 0x000000018485B250-0x000000018485B2F0 0x000000018485B7B0-0x000000018485B850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<RoutePointChangeInfo> PointList { get => default; } // 0x000000018485A670-0x000000018485A6D0 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneRouteChangeInfo() {} // 0x000000018485C050-0x000000018485C0E0
	static SceneRouteChangeInfo() {} // 0x000000018485BF40-0x000000018485C050

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneRouteChangeInfo Clone() => default; // 0x000000018485B3E0-0x000000018485B4D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneRouteChangeInfo ShallowCopy() => default; // 0x000000018485AED0-0x000000018485AF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018485A880-0x000000018485A8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018485B690-0x000000018485B720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018485B720-0x000000018485B7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018485A8D0-0x000000018485A9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018485ABE0-0x000000018485ACB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneRouteChangeInfo other) => default; // 0x000000018485AA70-0x000000018485ABE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018485B060-0x000000018485B1C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018485BC40-0x000000018485BF40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018485B8B0-0x000000018485BA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018485ACB0-0x000000018485AE50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneRouteChangeInfo other) {} // 0x000000018485A6D0-0x000000018485A880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018485A470-0x000000018485A610
}

