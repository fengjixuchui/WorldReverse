/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DungeonInterruptChallengeReq : MessageBase, IMessage<DungeonInterruptChallengeReq> // TypeDefIndex: 22952
{
	// Fields
	private static readonly MessageParser<DungeonInterruptChallengeReq> _parser; // 0x00
	public const int ChallengeIdFieldNumber = 1; // Metadata: 0x00B02BC3
	private uint challengeId_; // 0x18
	public const int ChallengeIndexFieldNumber = 2; // Metadata: 0x00B02BC7
	private uint challengeIndex_; // 0x1C
	public const int GroupIdFieldNumber = 3; // Metadata: 0x00B02BCB
	private uint groupId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DungeonInterruptChallengeReq> Parser { get => default; } // 0x0000000181E29D90-0x0000000181E29E20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181E29940-0x0000000181E299D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181E29560-0x0000000181E295E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181E28E00-0x0000000181E28E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181E2A160-0x0000000181E2A250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181E29F50-0x0000000181E29FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181E29A70-0x0000000181E29B60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181E2A110-0x0000000181E2A160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181E29680-0x0000000181E29770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeId { get => default; set {} } // 0x0000000181E298A0-0x0000000181E29940 0x0000000181E29CF0-0x0000000181E29D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeIndex { get => default; set {} } // 0x0000000181E29090-0x0000000181E29130 0x0000000181E299D0-0x0000000181E29A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GroupId { get => default; set {} } // 0x0000000181E29B60-0x0000000181E29C00 0x0000000181E294C0-0x0000000181E29560

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22953
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22954
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 948
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonInterruptChallengeReq() {} // 0x0000000181E2A5A0-0x0000000181E2A600
	static DungeonInterruptChallengeReq() {} // 0x0000000181E2A4E0-0x0000000181E2A5A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonInterruptChallengeReq Clone() => default; // 0x0000000181E29C00-0x0000000181E29CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonInterruptChallengeReq ShallowCopy() => default; // 0x0000000181E295E0-0x0000000181E29680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181E28FC0-0x0000000181E29010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E29EB0-0x0000000181E29F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E29F00-0x0000000181E29F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181E29010-0x0000000181E29090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181E29270-0x0000000181E29340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DungeonInterruptChallengeReq other) => default; // 0x0000000181E29130-0x0000000181E29270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181E29770-0x0000000181E298A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181E2A250-0x0000000181E2A4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181E29FB0-0x0000000181E2A110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181E29340-0x0000000181E294C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DungeonInterruptChallengeReq other) {} // 0x0000000181E28E60-0x0000000181E28FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181E28CF0-0x0000000181E28E00
}

