/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UnlockAvatarTalentRsp : MessageBase, IMessage<UnlockAvatarTalentRsp> // TypeDefIndex: 25480
{
	// Fields
	private static readonly MessageParser<UnlockAvatarTalentRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B08D9F
	private int retcode_; // 0x18
	public const int AvatarGuidFieldNumber = 2; // Metadata: 0x00B08DA3
	private ulong avatarGuid_; // 0x20
	public const int TalentIdFieldNumber = 3; // Metadata: 0x00B08DA7
	private uint talentId_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UnlockAvatarTalentRsp> Parser { get => default; } // 0x0000000183FBF860-0x0000000183FBF8F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183FBF550-0x0000000183FBF5E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183FBF200-0x0000000183FBF280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183FBE960-0x0000000183FBE9C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183FBFC30-0x0000000183FBFD20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183FBFA20-0x0000000183FBFA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183FBF680-0x0000000183FBF770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183FBFBE0-0x0000000183FBFC30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183FBF320-0x0000000183FBF410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183FBF160-0x0000000183FBF200 0x0000000183FBED30-0x0000000183FBEDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x0000000183FBF5E0-0x0000000183FBF680 0x0000000183FBEBC0-0x0000000183FBEC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TalentId { get => default; set {} } // 0x0000000183FBE9C0-0x0000000183FBEA60 0x0000000183FBFD20-0x0000000183FBFDC0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25481
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25482
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1002
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnlockAvatarTalentRsp() {} // 0x0000000183FC0110-0x0000000183FC0170
	static UnlockAvatarTalentRsp() {} // 0x0000000183FC0050-0x0000000183FC0110

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnlockAvatarTalentRsp Clone() => default; // 0x0000000183FBF770-0x0000000183FBF860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnlockAvatarTalentRsp ShallowCopy() => default; // 0x0000000183FBF280-0x0000000183FBF320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183FBEC60-0x0000000183FBECB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183FBF980-0x0000000183FBF9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183FBF9D0-0x0000000183FBFA20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183FBECB0-0x0000000183FBED30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183FBEF10-0x0000000183FBEFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(UnlockAvatarTalentRsp other) => default; // 0x0000000183FBEDD0-0x0000000183FBEF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183FBF410-0x0000000183FBF550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183FBFDC0-0x0000000183FC0050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183FBFA80-0x0000000183FBFBE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183FBEFE0-0x0000000183FBF160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(UnlockAvatarTalentRsp other) {} // 0x0000000183FBEA60-0x0000000183FBEBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183FBE850-0x0000000183FBE960
}

