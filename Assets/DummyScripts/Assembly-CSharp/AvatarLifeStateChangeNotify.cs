/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarLifeStateChangeNotify : MessageBase, IMessage<AvatarLifeStateChangeNotify> // TypeDefIndex: 24546
{
	// Fields
	private static readonly MessageParser<AvatarLifeStateChangeNotify> _parser; // 0x00
	public const int AvatarGuidFieldNumber = 1; // Metadata: 0x00B06ACB
	private ulong avatarGuid_; // 0x18
	public const int LifeStateFieldNumber = 2; // Metadata: 0x00B06ACF
	private uint lifeState_; // 0x20
	public const int SourceEntityIdFieldNumber = 3; // Metadata: 0x00B06AD3
	private uint sourceEntityId_; // 0x24
	public const int AttackTagFieldNumber = 4; // Metadata: 0x00B06AD7
	private string attackTag_; // 0x28
	public const int DieTypeFieldNumber = 5; // Metadata: 0x00B06ADB
	private PlayerDieType dieType_; // 0x30
	public const int MoveReliableSeqFieldNumber = 6; // Metadata: 0x00B06ADF
	private uint moveReliableSeq_; // 0x34

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarLifeStateChangeNotify> Parser { get => default; } // 0x0000000184B35760-0x0000000184B357F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184B353B0-0x0000000184B35440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184B34E20-0x0000000184B34EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184B34290-0x0000000184B342F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184B35D60-0x0000000184B35E50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184B359C0-0x0000000184B35A20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184B35580-0x0000000184B35670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184B35D10-0x0000000184B35D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184B34F40-0x0000000184B35030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x0000000184B35440-0x0000000184B354E0 0x0000000184B34580-0x0000000184B34620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LifeState { get => default; set {} } // 0x0000000184B34620-0x0000000184B346C0 0x0000000184B35E50-0x0000000184B35EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SourceEntityId { get => default; set {} } // 0x0000000184B342F0-0x0000000184B34390 0x0000000184B34D80-0x0000000184B34E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string AttackTag { get => default; set {} } // 0x0000000184B354E0-0x0000000184B35580 0x0000000184B35A20-0x0000000184B35AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerDieType DieType { get => default; set {} } // 0x0000000184B35310-0x0000000184B353B0 0x0000000184B347C0-0x0000000184B34860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MoveReliableSeq { get => default; set {} } // 0x0000000184B35270-0x0000000184B35310 0x0000000184B358D0-0x0000000184B35970

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24547
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24548
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1208
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarLifeStateChangeNotify() {} // 0x0000000184B363D0-0x0000000184B36450
	static AvatarLifeStateChangeNotify() {} // 0x0000000184B36310-0x0000000184B363D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarLifeStateChangeNotify Clone() => default; // 0x0000000184B35670-0x0000000184B35760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarLifeStateChangeNotify ShallowCopy() => default; // 0x0000000184B34EA0-0x0000000184B34F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184B346C0-0x0000000184B34710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184B35880-0x0000000184B358D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184B35970-0x0000000184B359C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184B34710-0x0000000184B347C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184B34860-0x0000000184B34930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarLifeStateChangeNotify other) => default; // 0x0000000184B34930-0x0000000184B34B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184B35030-0x0000000184B35270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184B35EF0-0x0000000184B36310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184B35AD0-0x0000000184B35D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184B34B00-0x0000000184B34D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarLifeStateChangeNotify other) {} // 0x0000000184B34390-0x0000000184B34580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184B34120-0x0000000184B34290
}

