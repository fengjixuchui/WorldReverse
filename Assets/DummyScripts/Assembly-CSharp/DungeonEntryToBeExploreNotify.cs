/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DungeonEntryToBeExploreNotify : MessageBase, IMessage<DungeonEntryToBeExploreNotify> // TypeDefIndex: 25268
{
	// Fields
	private static readonly MessageParser<DungeonEntryToBeExploreNotify> _parser; // 0x00
	public const int DungeonEntryScenePointIdFieldNumber = 1; // Metadata: 0x00B08577
	private uint dungeonEntryScenePointId_; // 0x18
	public const int DungeonEntryConfigIdFieldNumber = 2; // Metadata: 0x00B0857B
	private uint dungeonEntryConfigId_; // 0x1C
	public const int SceneIdFieldNumber = 3; // Metadata: 0x00B0857F
	private uint sceneId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DungeonEntryToBeExploreNotify> Parser { get => default; } // 0x00000001849A8680-0x00000001849A8710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001849A82D0-0x00000001849A8360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001849A7F90-0x00000001849A8010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001849A7790-0x00000001849A77F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001849A8AF0-0x00000001849A8BE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001849A8840-0x00000001849A88A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001849A8400-0x00000001849A84F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001849A8AA0-0x00000001849A8AF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001849A80B0-0x00000001849A81A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonEntryScenePointId { get => default; set {} } // 0x00000001849A88A0-0x00000001849A8940 0x00000001849A85E0-0x00000001849A8680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonEntryConfigId { get => default; set {} } // 0x00000001849A7E50-0x00000001849A7EF0 0x00000001849A8360-0x00000001849A8400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x00000001849A7A20-0x00000001849A7AC0 0x00000001849A7EF0-0x00000001849A7F90

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25269
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25270
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3024
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonEntryToBeExploreNotify() {} // 0x00000001849A8F30-0x00000001849A8F90
	static DungeonEntryToBeExploreNotify() {} // 0x00000001849A8E70-0x00000001849A8F30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonEntryToBeExploreNotify Clone() => default; // 0x00000001849A84F0-0x00000001849A85E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonEntryToBeExploreNotify ShallowCopy() => default; // 0x00000001849A8010-0x00000001849A80B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001849A7950-0x00000001849A79A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001849A87A0-0x00000001849A87F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001849A87F0-0x00000001849A8840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001849A79A0-0x00000001849A7A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001849A7AC0-0x00000001849A7B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DungeonEntryToBeExploreNotify other) => default; // 0x00000001849A7B90-0x00000001849A7CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001849A81A0-0x00000001849A82D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001849A8BE0-0x00000001849A8E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001849A8940-0x00000001849A8AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001849A7CD0-0x00000001849A7E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DungeonEntryToBeExploreNotify other) {} // 0x00000001849A77F0-0x00000001849A7950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001849A7680-0x00000001849A7790
}

