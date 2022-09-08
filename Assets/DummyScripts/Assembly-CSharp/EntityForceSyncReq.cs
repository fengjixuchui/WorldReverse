/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityForceSyncReq : MessageBase, IMessage<EntityForceSyncReq> // TypeDefIndex: 24999
{
	// Fields
	private static readonly MessageParser<EntityForceSyncReq> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B07BD3
	private uint entityId_; // 0x18
	public const int MotionInfoFieldNumber = 2; // Metadata: 0x00B07BD7
	private MotionInfo motionInfo_; // 0x20
	public const int SceneTimeFieldNumber = 3; // Metadata: 0x00B07BDB
	private uint sceneTime_; // 0x28
	public const int RoomIdFieldNumber = 4; // Metadata: 0x00B07BDF
	private uint roomId_; // 0x2C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EntityForceSyncReq> Parser { get => default; } // 0x0000000181849A20-0x0000000181849AB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181849670-0x0000000181849700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181849270-0x00000001818492F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181848950-0x00000001818489B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018184A110-0x000000018184A200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181849E20-0x0000000181849E80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181849840-0x0000000181849930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018184A020-0x000000018184A070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181849390-0x0000000181849480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000181849CE0-0x0000000181849D80 0x000000018184A200-0x000000018184A2A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MotionInfo MotionInfo { get => default; set {} } // 0x0000000181849D80-0x0000000181849E20 0x0000000181849B40-0x0000000181849BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneTime { get => default; set {} } // 0x0000000181849700-0x00000001818497A0 0x000000018184A070-0x000000018184A110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RoomId { get => default; set {} } // 0x00000001818489B0-0x0000000181848A50 0x00000001818497A0-0x0000000181849840

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25000
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25001
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 235
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityForceSyncReq() {} // 0x000000018184A660-0x000000018184A6C0
	static EntityForceSyncReq() {} // 0x000000018184A5A0-0x000000018184A660

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityForceSyncReq Clone() => default; // 0x0000000181849930-0x0000000181849A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityForceSyncReq ShallowCopy() => default; // 0x00000001818492F0-0x0000000181849390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181848C30-0x0000000181848CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181849BE0-0x0000000181849C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181849C60-0x0000000181849CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181848CB0-0x0000000181848E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181848F70-0x0000000181849040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EntityForceSyncReq other) => default; // 0x0000000181848E00-0x0000000181848F70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181849480-0x0000000181849670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018184A2A0-0x000000018184A5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181849E80-0x000000018184A020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181849040-0x0000000181849270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EntityForceSyncReq other) {} // 0x0000000181848A50-0x0000000181848C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001818487E0-0x0000000181848950
}

