/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TrialAvatarGrantRecord : MessageBase, IMessage<TrialAvatarGrantRecord> // TypeDefIndex: 26061
{
	// Fields
	private static readonly MessageParser<TrialAvatarGrantRecord> _parser; // 0x00
	public const int GrantReasonFieldNumber = 1; // Metadata: 0x00B0AF0B
	private uint grantReason_; // 0x18
	public const int FromParentQuestIdFieldNumber = 2; // Metadata: 0x00B0AF0F
	private uint fromParentQuestId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TrialAvatarGrantRecord> Parser { get => default; } // 0x0000000182E9BDA0-0x0000000182E9BE30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182E9BB30-0x0000000182E9BBC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182E9B820-0x0000000182E9B8A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182E9B170-0x0000000182E9B1D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182E9C1D0-0x0000000182E9C2C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182E9C000-0x0000000182E9C060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182E9BBC0-0x0000000182E9BCB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182E9C180-0x0000000182E9C1D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182E9B940-0x0000000182E9BA30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GrantReason { get => default; set {} } // 0x0000000182E9BE30-0x0000000182E9BED0 0x0000000182E9B350-0x0000000182E9B3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FromParentQuestId { get => default; set {} } // 0x0000000182E9B0D0-0x0000000182E9B170 0x0000000182E9B460-0x0000000182E9B500

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 26062
	{
		// Nested types
		public enum GrantReason // TypeDefIndex: 26063
		{
			Invalid = 0,
			GrantByQuest = 1,
			GrantByTrialAvatarActivity = 2,
			GrantByDungeonElementChallenge = 3,
			GrantByMistTrialActivity = 4
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TrialAvatarGrantRecord() {} // 0x0000000182E9C580-0x0000000182E9C5E0
	static TrialAvatarGrantRecord() {} // 0x0000000182E9C4C0-0x0000000182E9C580

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TrialAvatarGrantRecord Clone() => default; // 0x0000000182E9BCB0-0x0000000182E9BDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TrialAvatarGrantRecord ShallowCopy() => default; // 0x0000000182E9B8A0-0x0000000182E9B940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182E9B300-0x0000000182E9B350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182E9BF60-0x0000000182E9BFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182E9BFB0-0x0000000182E9C000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182E9B3F0-0x0000000182E9B460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182E9B500-0x0000000182E9B5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TrialAvatarGrantRecord other) => default; // 0x0000000182E9B5D0-0x0000000182E9B6F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182E9BA30-0x0000000182E9BB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182E9C2C0-0x0000000182E9C4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182E9C060-0x0000000182E9C180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182E9B6F0-0x0000000182E9B820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TrialAvatarGrantRecord other) {} // 0x0000000182E9B1D0-0x0000000182E9B300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182E9AFD0-0x0000000182E9B0D0
}

