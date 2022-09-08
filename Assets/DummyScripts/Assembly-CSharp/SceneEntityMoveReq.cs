/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneEntityMoveReq : MessageBase, IMessage<SceneEntityMoveReq> // TypeDefIndex: 24916
{
	// Fields
	private static readonly MessageParser<SceneEntityMoveReq> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B078AF
	private uint entityId_; // 0x18
	public const int MotionInfoFieldNumber = 2; // Metadata: 0x00B078B3
	private MotionInfo motionInfo_; // 0x20
	public const int SceneTimeFieldNumber = 3; // Metadata: 0x00B078B7
	private uint sceneTime_; // 0x28
	public const int ReliableSeqFieldNumber = 4; // Metadata: 0x00B078BB
	private uint reliableSeq_; // 0x2C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneEntityMoveReq> Parser { get => default; } // 0x000000018335BC20-0x000000018335BCB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018335B910-0x000000018335B9A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018335B510-0x000000018335B590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018335ABF0-0x000000018335AC50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018335C3B0-0x000000018335C4A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018335C0C0-0x000000018335C120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018335BA40-0x000000018335BB30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018335C2C0-0x000000018335C310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018335B630-0x000000018335B720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x000000018335BF80-0x000000018335C020 0x000000018335C4A0-0x000000018335C540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MotionInfo MotionInfo { get => default; set {} } // 0x000000018335C020-0x000000018335C0C0 0x000000018335BDE0-0x000000018335BE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneTime { get => default; set {} } // 0x000000018335B9A0-0x000000018335BA40 0x000000018335C310-0x000000018335C3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ReliableSeq { get => default; set {} } // 0x000000018335BD40-0x000000018335BDE0 0x000000018335AE30-0x000000018335AED0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24917
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24918
		{
			None = 0,
			EnetIsReliable = 0,
			EnetChannelId = 1,
			IsAllowClient = 1,
			CmdId = 208
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntityMoveReq() {} // 0x000000018335C900-0x000000018335C960
	static SceneEntityMoveReq() {} // 0x000000018335C840-0x000000018335C900

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntityMoveReq Clone() => default; // 0x000000018335BB30-0x000000018335BC20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntityMoveReq ShallowCopy() => default; // 0x000000018335B590-0x000000018335B630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018335AED0-0x000000018335AF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018335BE80-0x000000018335BF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018335BF00-0x000000018335BF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018335AF50-0x000000018335B0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018335B0A0-0x000000018335B170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneEntityMoveReq other) => default; // 0x000000018335B170-0x000000018335B2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018335B720-0x000000018335B910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018335C540-0x000000018335C840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018335C120-0x000000018335C2C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018335B2E0-0x000000018335B510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneEntityMoveReq other) {} // 0x000000018335AC50-0x000000018335AE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018335AA80-0x000000018335ABF0
}

