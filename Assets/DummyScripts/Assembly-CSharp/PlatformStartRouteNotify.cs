/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlatformStartRouteNotify : MessageBase, IMessage<PlatformStartRouteNotify> // TypeDefIndex: 25069
{
	// Fields
	private static readonly MessageParser<PlatformStartRouteNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B07E9B
	private uint entityId_; // 0x18
	public const int PlatformFieldNumber = 2; // Metadata: 0x00B07E9F
	private PlatformInfo platform_; // 0x20
	public const int SceneTimeFieldNumber = 3; // Metadata: 0x00B07EA3
	private uint sceneTime_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlatformStartRouteNotify> Parser { get => default; } // 0x0000000182187A10-0x0000000182187AA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182187700-0x0000000182187790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001821872A0-0x0000000182187320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182186A30-0x0000000182186A90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182187F80-0x0000000182188070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182187CD0-0x0000000182187D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182187830-0x0000000182187920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182187E90-0x0000000182187EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001821873C0-0x00000001821874B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000182187C30-0x0000000182187CD0 0x0000000182188070-0x0000000182188110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlatformInfo Platform { get => default; set {} } // 0x0000000182187660-0x0000000182187700 0x0000000182186A90-0x0000000182186B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneTime { get => default; set {} } // 0x0000000182187790-0x0000000182187830 0x0000000182187EE0-0x0000000182187F80

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25070
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25071
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 258
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlatformStartRouteNotify() {} // 0x0000000182188440-0x00000001821884A0
	static PlatformStartRouteNotify() {} // 0x0000000182188380-0x0000000182188440

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlatformStartRouteNotify Clone() => default; // 0x0000000182187920-0x0000000182187A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlatformStartRouteNotify ShallowCopy() => default; // 0x0000000182187320-0x00000001821873C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182186CE0-0x0000000182186D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182187B30-0x0000000182187BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182187BB0-0x0000000182187C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182186D60-0x0000000182186EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182186FF0-0x00000001821870C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlatformStartRouteNotify other) => default; // 0x0000000182186EA0-0x0000000182186FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001821874B0-0x0000000182187660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182188110-0x0000000182188380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182187D30-0x0000000182187E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001821870C0-0x00000001821872A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlatformStartRouteNotify other) {} // 0x0000000182186B30-0x0000000182186CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001821868D0-0x0000000182186A30
}

