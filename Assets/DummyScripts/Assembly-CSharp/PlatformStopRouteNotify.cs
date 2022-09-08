/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlatformStopRouteNotify : MessageBase, IMessage<PlatformStopRouteNotify> // TypeDefIndex: 25072
{
	// Fields
	private static readonly MessageParser<PlatformStopRouteNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B07EB7
	private uint entityId_; // 0x18
	public const int SceneTimeFieldNumber = 2; // Metadata: 0x00B07EBB
	private uint sceneTime_; // 0x1C
	public const int PlatformFieldNumber = 3; // Metadata: 0x00B07EBF
	private PlatformInfo platform_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlatformStopRouteNotify> Parser { get => default; } // 0x00000001833F3690-0x00000001833F3720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001833F3380-0x00000001833F3410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001833F2F20-0x00000001833F2FA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001833F26B0-0x00000001833F2710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001833F3C00-0x00000001833F3CF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001833F3950-0x00000001833F39B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001833F34B0-0x00000001833F35A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001833F3B10-0x00000001833F3B60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001833F3040-0x00000001833F3130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x00000001833F38B0-0x00000001833F3950 0x00000001833F3CF0-0x00000001833F3D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneTime { get => default; set {} } // 0x00000001833F3410-0x00000001833F34B0 0x00000001833F3B60-0x00000001833F3C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlatformInfo Platform { get => default; set {} } // 0x00000001833F32E0-0x00000001833F3380 0x00000001833F2710-0x00000001833F27B0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25073
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25074
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 259
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlatformStopRouteNotify() {} // 0x00000001833F40C0-0x00000001833F4120
	static PlatformStopRouteNotify() {} // 0x00000001833F4000-0x00000001833F40C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlatformStopRouteNotify Clone() => default; // 0x00000001833F35A0-0x00000001833F3690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlatformStopRouteNotify ShallowCopy() => default; // 0x00000001833F2FA0-0x00000001833F3040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001833F2960-0x00000001833F29E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001833F37B0-0x00000001833F3830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001833F3830-0x00000001833F38B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001833F29E0-0x00000001833F2B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001833F2C70-0x00000001833F2D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlatformStopRouteNotify other) => default; // 0x00000001833F2B20-0x00000001833F2C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001833F3130-0x00000001833F32E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001833F3D90-0x00000001833F4000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001833F39B0-0x00000001833F3B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001833F2D40-0x00000001833F2F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlatformStopRouteNotify other) {} // 0x00000001833F27B0-0x00000001833F2960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001833F2550-0x00000001833F26B0
}

