/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UnlockAvatarTalentReq : MessageBase, IMessage<UnlockAvatarTalentReq> // TypeDefIndex: 25477
{
	// Fields
	private static readonly MessageParser<UnlockAvatarTalentReq> _parser; // 0x00
	public const int AvatarGuidFieldNumber = 1; // Metadata: 0x00B08D83
	private ulong avatarGuid_; // 0x18
	public const int TalentIdFieldNumber = 2; // Metadata: 0x00B08D87
	private uint talentId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UnlockAvatarTalentReq> Parser { get => default; } // 0x0000000184D45220-0x0000000184D452B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184D44F10-0x0000000184D44FA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184D44BF0-0x0000000184D44C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184D44540-0x0000000184D445A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184D455B0-0x0000000184D456A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184D453E0-0x0000000184D45440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184D45040-0x0000000184D45130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184D45560-0x0000000184D455B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184D44D10-0x0000000184D44E00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x0000000184D44FA0-0x0000000184D45040 0x0000000184D44770-0x0000000184D44810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TalentId { get => default; set {} } // 0x0000000184D445A0-0x0000000184D44640 0x0000000184D456A0-0x0000000184D45740

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25478
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25479
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1001
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnlockAvatarTalentReq() {} // 0x0000000184D45A00-0x0000000184D45A60
	static UnlockAvatarTalentReq() {} // 0x0000000184D45940-0x0000000184D45A00

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnlockAvatarTalentReq Clone() => default; // 0x0000000184D45130-0x0000000184D45220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnlockAvatarTalentReq ShallowCopy() => default; // 0x0000000184D44C70-0x0000000184D44D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184D44810-0x0000000184D44860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184D45340-0x0000000184D45390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184D45390-0x0000000184D453E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184D44860-0x0000000184D448D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184D449F0-0x0000000184D44AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(UnlockAvatarTalentReq other) => default; // 0x0000000184D448D0-0x0000000184D449F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184D44E00-0x0000000184D44F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184D45740-0x0000000184D45940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184D45440-0x0000000184D45560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184D44AC0-0x0000000184D44BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(UnlockAvatarTalentReq other) {} // 0x0000000184D44640-0x0000000184D44770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184D44440-0x0000000184D44540
}

