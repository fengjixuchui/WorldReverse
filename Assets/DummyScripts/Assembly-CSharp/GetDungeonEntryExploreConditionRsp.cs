/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetDungeonEntryExploreConditionRsp : MessageBase, IMessage<GetDungeonEntryExploreConditionRsp> // TypeDefIndex: 25275
{
	// Fields
	private static readonly MessageParser<GetDungeonEntryExploreConditionRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B085BB
	private int retcode_; // 0x18
	public const int DungeonEntryCondFieldNumber = 2; // Metadata: 0x00B085BF
	private DungeonEntryCond dungeonEntryCond_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetDungeonEntryExploreConditionRsp> Parser { get => default; } // 0x00000001829A4230-0x00000001829A42C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001829A3FC0-0x00000001829A4050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001829A3C30-0x00000001829A3CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001829A33C0-0x00000001829A3420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001829A4620-0x00000001829A4710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001829A4450-0x00000001829A44B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001829A4050-0x00000001829A4140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001829A45D0-0x00000001829A4620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001829A3D50-0x00000001829A3E40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001829A3B90-0x00000001829A3C30 0x00000001829A3750-0x00000001829A37F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonEntryCond DungeonEntryCond { get => default; set {} } // 0x00000001829A47B0-0x00000001829A4850 0x00000001829A4710-0x00000001829A47B0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25276
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25277
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3036
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetDungeonEntryExploreConditionRsp() {} // 0x00000001829A4AF0-0x00000001829A4B50
	static GetDungeonEntryExploreConditionRsp() {} // 0x00000001829A4A30-0x00000001829A4AF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetDungeonEntryExploreConditionRsp Clone() => default; // 0x00000001829A4140-0x00000001829A4230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetDungeonEntryExploreConditionRsp ShallowCopy() => default; // 0x00000001829A3CB0-0x00000001829A3D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001829A35A0-0x00000001829A3620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001829A4350-0x00000001829A43D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001829A43D0-0x00000001829A4450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001829A3620-0x00000001829A3750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001829A37F0-0x00000001829A38C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetDungeonEntryExploreConditionRsp other) => default; // 0x00000001829A38C0-0x00000001829A39F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001829A3E40-0x00000001829A3FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001829A4850-0x00000001829A4A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001829A44B0-0x00000001829A45D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001829A39F0-0x00000001829A3B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetDungeonEntryExploreConditionRsp other) {} // 0x00000001829A3420-0x00000001829A35A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001829A3280-0x00000001829A33C0
}

