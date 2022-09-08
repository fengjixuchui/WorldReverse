/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityForceSyncRsp : MessageBase, IMessage<EntityForceSyncRsp> // TypeDefIndex: 25002
{
	// Fields
	private static readonly MessageParser<EntityForceSyncRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B07BF7
	private int retcode_; // 0x18
	public const int EntityIdFieldNumber = 2; // Metadata: 0x00B07BFB
	private uint entityId_; // 0x1C
	public const int FailMotionFieldNumber = 3; // Metadata: 0x00B07BFF
	private MotionInfo failMotion_; // 0x20
	public const int SceneTimeFieldNumber = 4; // Metadata: 0x00B07C03
	private uint sceneTime_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EntityForceSyncRsp> Parser { get => default; } // 0x00000001816687A0-0x0000000181668830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181668490-0x0000000181668520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181668090-0x0000000181668110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181667630-0x0000000181667690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181668DF0-0x0000000181668EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181668B00-0x0000000181668B60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001816685C0-0x00000001816686B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181668D00-0x0000000181668D50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001816681B0-0x00000001816682A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181667FF0-0x0000000181668090 0x0000000181667AE0-0x0000000181667B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000181668A60-0x0000000181668B00 0x0000000181668EE0-0x0000000181668F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MotionInfo FailMotion { get => default; set {} } // 0x00000001816689C0-0x0000000181668A60 0x0000000181667690-0x0000000181667730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneTime { get => default; set {} } // 0x0000000181668520-0x00000001816685C0 0x0000000181668D50-0x0000000181668DF0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25003
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25004
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 236
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityForceSyncRsp() {} // 0x0000000181669340-0x00000001816693A0
	static EntityForceSyncRsp() {} // 0x0000000181669280-0x0000000181669340

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityForceSyncRsp Clone() => default; // 0x00000001816686B0-0x00000001816687A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityForceSyncRsp ShallowCopy() => default; // 0x0000000181668110-0x00000001816681B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181667910-0x0000000181667990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001816688C0-0x0000000181668940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181668940-0x00000001816689C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181667990-0x0000000181667AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181667B80-0x0000000181667C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EntityForceSyncRsp other) => default; // 0x0000000181667C50-0x0000000181667DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001816682A0-0x0000000181668490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181668F80-0x0000000181669280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181668B60-0x0000000181668D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181667DC0-0x0000000181667FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EntityForceSyncRsp other) {} // 0x0000000181667730-0x0000000181667910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001816674B0-0x0000000181667630
}

