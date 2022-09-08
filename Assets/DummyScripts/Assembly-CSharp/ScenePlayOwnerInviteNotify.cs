/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ScenePlayOwnerInviteNotify : MessageBase, IMessage<ScenePlayOwnerInviteNotify> // TypeDefIndex: 25381
{
	// Fields
	private static readonly MessageParser<ScenePlayOwnerInviteNotify> _parser; // 0x00
	public const int PlayIdFieldNumber = 1; // Metadata: 0x00B089B7
	private uint playId_; // 0x18
	public const int InviteCdFieldNumber = 2; // Metadata: 0x00B089BB
	private uint inviteCd_; // 0x1C
	public const int IsRemainRewardFieldNumber = 3; // Metadata: 0x00B089BF
	private bool isRemainReward_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ScenePlayOwnerInviteNotify> Parser { get => default; } // 0x0000000185092EE0-0x0000000185092F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185092BD0-0x0000000185092C60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001850927F0-0x0000000185092870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001850920C0-0x0000000185092120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185093350-0x0000000185093440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001850930A0-0x0000000185093100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185092D00-0x0000000185092DF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185093300-0x0000000185093350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185092910-0x0000000185092A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayId { get => default; set {} } // 0x0000000185092750-0x00000001850927F0 0x0000000185092B30-0x0000000185092BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint InviteCd { get => default; set {} } // 0x0000000185093100-0x00000001850931A0 0x0000000185093440-0x00000001850934E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsRemainReward { get => default; set {} } // 0x00000001850926B0-0x0000000185092750 0x0000000185092C60-0x0000000185092D00

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25382
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25383
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4356
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayOwnerInviteNotify() {} // 0x0000000185093830-0x0000000185093890
	static ScenePlayOwnerInviteNotify() {} // 0x0000000185093770-0x0000000185093830

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayOwnerInviteNotify Clone() => default; // 0x0000000185092DF0-0x0000000185092EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayOwnerInviteNotify ShallowCopy() => default; // 0x0000000185092870-0x0000000185092910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185092280-0x00000001850922D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185093000-0x0000000185093050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185093050-0x00000001850930A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001850922D0-0x0000000185092350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185092490-0x0000000185092560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ScenePlayOwnerInviteNotify other) => default; // 0x0000000185092350-0x0000000185092490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000185092A00-0x0000000185092B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001850934E0-0x0000000185093770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001850931A0-0x0000000185093300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185092560-0x00000001850926B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ScenePlayOwnerInviteNotify other) {} // 0x0000000185092120-0x0000000185092280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185091FB0-0x00000001850920C0
}

