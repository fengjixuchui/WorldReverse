/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LifeStateChangeNotify : MessageBase, IMessage<LifeStateChangeNotify> // TypeDefIndex: 24528
{
	// Fields
	private static readonly MessageParser<LifeStateChangeNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B06A1B
	private uint entityId_; // 0x18
	public const int LifeStateFieldNumber = 2; // Metadata: 0x00B06A1F
	private uint lifeState_; // 0x1C
	public const int SourceEntityIdFieldNumber = 3; // Metadata: 0x00B06A23
	private uint sourceEntityId_; // 0x20
	public const int AttackTagFieldNumber = 4; // Metadata: 0x00B06A27
	private string attackTag_; // 0x28
	public const int DieTypeFieldNumber = 5; // Metadata: 0x00B06A2B
	private PlayerDieType dieType_; // 0x30
	public const int MoveReliableSeqFieldNumber = 6; // Metadata: 0x00B06A2F
	private uint moveReliableSeq_; // 0x34

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<LifeStateChangeNotify> Parser { get => default; } // 0x000000018308D1E0-0x000000018308D270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018308CED0-0x000000018308CF60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018308C940-0x000000018308C9C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018308BE60-0x000000018308BEC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018308D880-0x000000018308D970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018308D4E0-0x000000018308D540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018308D000-0x000000018308D0F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018308D830-0x000000018308D880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018308CA60-0x000000018308CB50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x000000018308D440-0x000000018308D4E0 0x000000018308DA10-0x000000018308DAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LifeState { get => default; set {} } // 0x000000018308C140-0x000000018308C1E0 0x000000018308D970-0x000000018308DA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SourceEntityId { get => default; set {} } // 0x000000018308BEC0-0x000000018308BF60 0x000000018308C8A0-0x000000018308C940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string AttackTag { get => default; set {} } // 0x000000018308CF60-0x000000018308D000 0x000000018308D540-0x000000018308D5F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerDieType DieType { get => default; set {} } // 0x000000018308CE30-0x000000018308CED0 0x000000018308C2E0-0x000000018308C380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MoveReliableSeq { get => default; set {} } // 0x000000018308CD90-0x000000018308CE30 0x000000018308D350-0x000000018308D3F0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24529
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24530
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1202
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public LifeStateChangeNotify() {} // 0x000000018308DF80-0x000000018308E000
	static LifeStateChangeNotify() {} // 0x000000018308DEC0-0x000000018308DF80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public LifeStateChangeNotify Clone() => default; // 0x000000018308D0F0-0x000000018308D1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public LifeStateChangeNotify ShallowCopy() => default; // 0x000000018308C9C0-0x000000018308CA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018308C1E0-0x000000018308C230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018308D300-0x000000018308D350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018308D3F0-0x000000018308D440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018308C230-0x000000018308C2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018308C380-0x000000018308C450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(LifeStateChangeNotify other) => default; // 0x000000018308C450-0x000000018308C620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018308CB50-0x000000018308CD90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018308DAB0-0x000000018308DEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018308D5F0-0x000000018308D830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018308C620-0x000000018308C8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(LifeStateChangeNotify other) {} // 0x000000018308BF60-0x000000018308C140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018308BD00-0x000000018308BE60
}

