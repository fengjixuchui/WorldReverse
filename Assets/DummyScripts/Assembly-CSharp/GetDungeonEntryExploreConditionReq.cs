/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetDungeonEntryExploreConditionReq : MessageBase, IMessage<GetDungeonEntryExploreConditionReq> // TypeDefIndex: 25271
{
	// Fields
	private static readonly MessageParser<GetDungeonEntryExploreConditionReq> _parser; // 0x00
	public const int DungeonEntryScenePointIdFieldNumber = 1; // Metadata: 0x00B08593
	private uint dungeonEntryScenePointId_; // 0x18
	public const int DungeonEntryConfigIdFieldNumber = 2; // Metadata: 0x00B08597
	private uint dungeonEntryConfigId_; // 0x1C
	public const int SceneIdFieldNumber = 3; // Metadata: 0x00B0859B
	private uint sceneId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetDungeonEntryExploreConditionReq> Parser { get => default; } // 0x000000018221B540-0x000000018221B5D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018221B190-0x000000018221B220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018221AE50-0x000000018221AED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018221A650-0x000000018221A6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018221B9B0-0x000000018221BAA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018221B700-0x000000018221B760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018221B2C0-0x000000018221B3B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018221B960-0x000000018221B9B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018221AF70-0x000000018221B060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonEntryScenePointId { get => default; set {} } // 0x000000018221B760-0x000000018221B800 0x000000018221B4A0-0x000000018221B540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonEntryConfigId { get => default; set {} } // 0x000000018221AD10-0x000000018221ADB0 0x000000018221B220-0x000000018221B2C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x000000018221A8E0-0x000000018221A980 0x000000018221ADB0-0x000000018221AE50

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25272
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25273
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 3035
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetDungeonEntryExploreConditionReq() {} // 0x000000018221BDF0-0x000000018221BE50
	static GetDungeonEntryExploreConditionReq() {} // 0x000000018221BD30-0x000000018221BDF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetDungeonEntryExploreConditionReq Clone() => default; // 0x000000018221B3B0-0x000000018221B4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetDungeonEntryExploreConditionReq ShallowCopy() => default; // 0x000000018221AED0-0x000000018221AF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018221A810-0x000000018221A860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018221B660-0x000000018221B6B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018221B6B0-0x000000018221B700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018221A860-0x000000018221A8E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018221A980-0x000000018221AA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetDungeonEntryExploreConditionReq other) => default; // 0x000000018221AA50-0x000000018221AB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018221B060-0x000000018221B190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018221BAA0-0x000000018221BD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018221B800-0x000000018221B960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018221AB90-0x000000018221AD10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetDungeonEntryExploreConditionReq other) {} // 0x000000018221A6B0-0x000000018221A810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018221A540-0x000000018221A650
}

