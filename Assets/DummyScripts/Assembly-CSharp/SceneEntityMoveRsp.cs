/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneEntityMoveRsp : MessageBase, IMessage<SceneEntityMoveRsp> // TypeDefIndex: 24919
{
	// Fields
	private static readonly MessageParser<SceneEntityMoveRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B078D3
	private int retcode_; // 0x18
	public const int EntityIdFieldNumber = 2; // Metadata: 0x00B078D7
	private uint entityId_; // 0x1C
	public const int FailMotionFieldNumber = 3; // Metadata: 0x00B078DB
	private MotionInfo failMotion_; // 0x20
	public const int SceneTimeFieldNumber = 4; // Metadata: 0x00B078DF
	private uint sceneTime_; // 0x28
	public const int ReliableSeqFieldNumber = 5; // Metadata: 0x00B078E3
	private uint reliableSeq_; // 0x2C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneEntityMoveRsp> Parser { get => default; } // 0x00000001845C4400-0x00000001845C4490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001845C40F0-0x00000001845C4180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001845C3CD0-0x00000001845C3D50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001845C3140-0x00000001845C31A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001845C4B20-0x00000001845C4C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001845C4800-0x00000001845C4860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001845C4220-0x00000001845C4310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001845C4A30-0x00000001845C4A80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001845C3DF0-0x00000001845C3EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001845C3C30-0x00000001845C3CD0 0x00000001845C36C0-0x00000001845C3760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x00000001845C4760-0x00000001845C4800 0x00000001845C4C10-0x00000001845C4CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MotionInfo FailMotion { get => default; set {} } // 0x00000001845C46C0-0x00000001845C4760 0x00000001845C31A0-0x00000001845C3240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneTime { get => default; set {} } // 0x00000001845C4180-0x00000001845C4220 0x00000001845C4A80-0x00000001845C4B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ReliableSeq { get => default; set {} } // 0x00000001845C4520-0x00000001845C45C0 0x00000001845C3440-0x00000001845C34E0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24920
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24921
		{
			None = 0,
			EnetChannelId = 1,
			EnetIsReliable = 1,
			CmdId = 209
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntityMoveRsp() {} // 0x00000001845C5100-0x00000001845C52B0
	static SceneEntityMoveRsp() {} // 0x00000001845C5040-0x00000001845C5100

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntityMoveRsp Clone() => default; // 0x00000001845C4310-0x00000001845C4400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntityMoveRsp ShallowCopy() => default; // 0x00000001845C3D50-0x00000001845C3DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001845C34E0-0x00000001845C3560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001845C45C0-0x00000001845C4640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001845C4640-0x00000001845C46C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001845C3560-0x00000001845C36C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001845C38F0-0x00000001845C39C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneEntityMoveRsp other) => default; // 0x00000001845C3760-0x00000001845C38F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001845C3EE0-0x00000001845C40F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001845C4CB0-0x00000001845C5040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001845C4860-0x00000001845C4A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001845C39C0-0x00000001845C3C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneEntityMoveRsp other) {} // 0x00000001845C3240-0x00000001845C3440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001845C2FA0-0x00000001845C3140
}

