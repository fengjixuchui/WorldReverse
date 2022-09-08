/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UnfreezeGroupLimitNotify : MessageBase, IMessage<UnfreezeGroupLimitNotify> // TypeDefIndex: 25278
{
	// Fields
	private static readonly MessageParser<UnfreezeGroupLimitNotify> _parser; // 0x00
	public const int PointIdFieldNumber = 1; // Metadata: 0x00B085D3
	private uint pointId_; // 0x18
	public const int SceneIdFieldNumber = 2; // Metadata: 0x00B085D7
	private uint sceneId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UnfreezeGroupLimitNotify> Parser { get => default; } // 0x0000000181D3DF60-0x0000000181D3DFF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181D3DC50-0x0000000181D3DCE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181D3D940-0x0000000181D3D9C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181D3D1F0-0x0000000181D3D250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181D3E2F0-0x0000000181D3E3E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181D3E120-0x0000000181D3E180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181D3DD80-0x0000000181D3DE70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181D3E2A0-0x0000000181D3E2F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181D3DA60-0x0000000181D3DB50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PointId { get => default; set {} } // 0x0000000181D3DCE0-0x0000000181D3DD80 0x0000000181D3D4E0-0x0000000181D3D580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x0000000181D3D440-0x0000000181D3D4E0 0x0000000181D3D8A0-0x0000000181D3D940

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25279
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25280
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3037
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnfreezeGroupLimitNotify() {} // 0x0000000181D3E6A0-0x0000000181D3E700
	static UnfreezeGroupLimitNotify() {} // 0x0000000181D3E5E0-0x0000000181D3E6A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnfreezeGroupLimitNotify Clone() => default; // 0x0000000181D3DE70-0x0000000181D3DF60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnfreezeGroupLimitNotify ShallowCopy() => default; // 0x0000000181D3D9C0-0x0000000181D3DA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181D3D380-0x0000000181D3D3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D3E080-0x0000000181D3E0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D3E0D0-0x0000000181D3E120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181D3D3D0-0x0000000181D3D440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181D3D580-0x0000000181D3D650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(UnfreezeGroupLimitNotify other) => default; // 0x0000000181D3D650-0x0000000181D3D770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181D3DB50-0x0000000181D3DC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181D3E3E0-0x0000000181D3E5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181D3E180-0x0000000181D3E2A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181D3D770-0x0000000181D3D8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(UnfreezeGroupLimitNotify other) {} // 0x0000000181D3D250-0x0000000181D3D380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181D3D0F0-0x0000000181D3D1F0
}

