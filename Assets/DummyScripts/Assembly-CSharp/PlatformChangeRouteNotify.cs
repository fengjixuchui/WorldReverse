/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlatformChangeRouteNotify : MessageBase, IMessage<PlatformChangeRouteNotify> // TypeDefIndex: 25075
{
	// Fields
	private static readonly MessageParser<PlatformChangeRouteNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B07ED3
	private uint entityId_; // 0x18
	public const int PlatformFieldNumber = 2; // Metadata: 0x00B07ED7
	private PlatformInfo platform_; // 0x20
	public const int SceneTimeFieldNumber = 3; // Metadata: 0x00B07EDB
	private uint sceneTime_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlatformChangeRouteNotify> Parser { get => default; } // 0x0000000180DDC330-0x0000000180DDC3C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000180DDC020-0x0000000180DDC0B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000180DDBBC0-0x0000000180DDBC40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000180DDB350-0x0000000180DDB3B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000180DDC8A0-0x0000000180DDC990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000180DDC5F0-0x0000000180DDC650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000180DDC150-0x0000000180DDC240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000180DDC7B0-0x0000000180DDC800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000180DDBCE0-0x0000000180DDBDD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000180DDC550-0x0000000180DDC5F0 0x0000000180DDC990-0x0000000180DDCA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlatformInfo Platform { get => default; set {} } // 0x0000000180DDBF80-0x0000000180DDC020 0x0000000180DDB3B0-0x0000000180DDB450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneTime { get => default; set {} } // 0x0000000180DDC0B0-0x0000000180DDC150 0x0000000180DDC800-0x0000000180DDC8A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25076
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25077
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 260
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlatformChangeRouteNotify() {} // 0x0000000180DDCD60-0x0000000180DDCDC0
	static PlatformChangeRouteNotify() {} // 0x0000000180DDCCA0-0x0000000180DDCD60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlatformChangeRouteNotify Clone() => default; // 0x0000000180DDC240-0x0000000180DDC330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlatformChangeRouteNotify ShallowCopy() => default; // 0x0000000180DDBC40-0x0000000180DDBCE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000180DDB600-0x0000000180DDB680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180DDC450-0x0000000180DDC4D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180DDC4D0-0x0000000180DDC550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000180DDB680-0x0000000180DDB7C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000180DDB7C0-0x0000000180DDB890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlatformChangeRouteNotify other) => default; // 0x0000000180DDB890-0x0000000180DDB9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000180DDBDD0-0x0000000180DDBF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000180DDCA30-0x0000000180DDCCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000180DDC650-0x0000000180DDC7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000180DDB9E0-0x0000000180DDBBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlatformChangeRouteNotify other) {} // 0x0000000180DDB450-0x0000000180DDB600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000180DDB1F0-0x0000000180DDB350
}

