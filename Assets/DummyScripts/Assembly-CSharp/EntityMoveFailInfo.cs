/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityMoveFailInfo : MessageBase, IMessage<EntityMoveFailInfo> // TypeDefIndex: 25200
{
	// Fields
	private static readonly MessageParser<EntityMoveFailInfo> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B08323
	private int retcode_; // 0x18
	public const int EntityIdFieldNumber = 2; // Metadata: 0x00B08327
	private uint entityId_; // 0x1C
	public const int FailMotionFieldNumber = 3; // Metadata: 0x00B0832B
	private MotionInfo failMotion_; // 0x20
	public const int SceneTimeFieldNumber = 4; // Metadata: 0x00B0832F
	private uint sceneTime_; // 0x28
	public const int ReliableSeqFieldNumber = 5; // Metadata: 0x00B08333
	private uint reliableSeq_; // 0x2C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EntityMoveFailInfo> Parser { get => default; } // 0x0000000184D02730-0x0000000184D027C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184D02420-0x0000000184D024B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184D02000-0x0000000184D02080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184D01470-0x0000000184D014D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184D02E50-0x0000000184D02F40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184D02B30-0x0000000184D02B90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184D02550-0x0000000184D02640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184D02D60-0x0000000184D02DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184D02120-0x0000000184D02210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184D01F60-0x0000000184D02000 0x0000000184D019F0-0x0000000184D01A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000184D02A90-0x0000000184D02B30 0x0000000184D02F40-0x0000000184D02FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MotionInfo FailMotion { get => default; set {} } // 0x0000000184D029F0-0x0000000184D02A90 0x0000000184D014D0-0x0000000184D01570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneTime { get => default; set {} } // 0x0000000184D024B0-0x0000000184D02550 0x0000000184D02DB0-0x0000000184D02E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ReliableSeq { get => default; set {} } // 0x0000000184D02850-0x0000000184D028F0 0x0000000184D01770-0x0000000184D01810

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityMoveFailInfo() {} // 0x0000000184D03430-0x0000000184D03490
	static EntityMoveFailInfo() {} // 0x0000000184D03370-0x0000000184D03430

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityMoveFailInfo Clone() => default; // 0x0000000184D02640-0x0000000184D02730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityMoveFailInfo ShallowCopy() => default; // 0x0000000184D02080-0x0000000184D02120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184D01810-0x0000000184D01890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184D028F0-0x0000000184D02970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184D02970-0x0000000184D029F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184D01890-0x0000000184D019F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184D01C20-0x0000000184D01CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EntityMoveFailInfo other) => default; // 0x0000000184D01A90-0x0000000184D01C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184D02210-0x0000000184D02420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184D02FE0-0x0000000184D03370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184D02B90-0x0000000184D02D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184D01CF0-0x0000000184D01F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EntityMoveFailInfo other) {} // 0x0000000184D01570-0x0000000184D01770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184D012D0-0x0000000184D01470
}

