/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DungeonRestartRsp : MessageBase, IMessage<DungeonRestartRsp> // TypeDefIndex: 22964
{
	// Fields
	private static readonly MessageParser<DungeonRestartRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B02C2B
	private int retcode_; // 0x18
	public const int PointIdFieldNumber = 2; // Metadata: 0x00B02C2F
	private uint pointId_; // 0x1C
	public const int DungeonIdFieldNumber = 3; // Metadata: 0x00B02C33
	private uint dungeonId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DungeonRestartRsp> Parser { get => default; } // 0x0000000183494D80-0x0000000183494E10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183494A70-0x0000000183494B00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183494690-0x0000000183494710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183493E90-0x0000000183493EF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001834951F0-0x00000001834952E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183494F40-0x0000000183494FA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183494BA0-0x0000000183494C90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001834951A0-0x00000001834951F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183494850-0x0000000183494940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001834945F0-0x0000000183494690 0x0000000183494120-0x00000001834941C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PointId { get => default; set {} } // 0x0000000183494B00-0x0000000183494BA0 0x00000001834941C0-0x0000000183494260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonId { get => default; set {} } // 0x00000001834947B0-0x0000000183494850 0x0000000183495100-0x00000001834951A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22965
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22966
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 952
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonRestartRsp() {} // 0x0000000183495630-0x0000000183495690
	static DungeonRestartRsp() {} // 0x0000000183495570-0x0000000183495630

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonRestartRsp Clone() => default; // 0x0000000183494C90-0x0000000183494D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonRestartRsp ShallowCopy() => default; // 0x0000000183494710-0x00000001834947B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183494050-0x00000001834940A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183494EA0-0x0000000183494EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183494EF0-0x0000000183494F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001834940A0-0x0000000183494120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183494260-0x0000000183494330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DungeonRestartRsp other) => default; // 0x0000000183494330-0x0000000183494470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183494940-0x0000000183494A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001834952E0-0x0000000183495570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183494FA0-0x0000000183495100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183494470-0x00000001834945F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DungeonRestartRsp other) {} // 0x0000000183493EF0-0x0000000183494050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183493D80-0x0000000183493E90
}

