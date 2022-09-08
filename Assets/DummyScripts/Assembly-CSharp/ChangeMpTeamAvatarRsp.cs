/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChangeMpTeamAvatarRsp : MessageBase, IMessage<ChangeMpTeamAvatarRsp> // TypeDefIndex: 22483
{
	// Fields
	private static readonly MessageParser<ChangeMpTeamAvatarRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B01ABF
	private int retcode_; // 0x18
	public const int AvatarGuidListFieldNumber = 2; // Metadata: 0x00B01AC3
	private static readonly FieldCodec<ulong> _repeated_avatarGuidList_codec; // 0x08
	private readonly RepeatedPrimitiveField<ulong> avatarGuidList_; // 0x20
	public const int CurAvatarGuidFieldNumber = 3; // Metadata: 0x00B01AC7
	private ulong curAvatarGuid_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChangeMpTeamAvatarRsp> Parser { get => default; } // 0x00000001817670F0-0x0000000181767180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181766E20-0x0000000181766EB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181766AE0-0x0000000181766B60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181766310-0x0000000181766370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181767620-0x0000000181767710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001817673F0-0x0000000181767450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181766EB0-0x0000000181766FA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001817675D0-0x0000000181767620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181766C00-0x0000000181766CF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181766A40-0x0000000181766AE0 0x0000000181766600-0x00000001817666A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<ulong> AvatarGuidList { get => default; } // 0x0000000181767090-0x00000001817670F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong CurAvatarGuid { get => default; set {} } // 0x0000000181767220-0x00000001817672C0 0x0000000181767180-0x0000000181767220

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22484
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22485
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1735
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChangeMpTeamAvatarRsp() {} // 0x0000000181767A60-0x0000000181767AF0
	static ChangeMpTeamAvatarRsp() {} // 0x0000000181767980-0x0000000181767A60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChangeMpTeamAvatarRsp Clone() => default; // 0x0000000181766FA0-0x0000000181767090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChangeMpTeamAvatarRsp ShallowCopy() => default; // 0x0000000181766B60-0x0000000181766C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001817664D0-0x0000000181766520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181767350-0x00000001817673A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001817673A0-0x00000001817673F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181766520-0x0000000181766600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001817667E0-0x00000001817668B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChangeMpTeamAvatarRsp other) => default; // 0x00000001817666A0-0x00000001817667E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181766CF0-0x0000000181766E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181767710-0x0000000181767980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181767450-0x00000001817675D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001817668B0-0x0000000181766A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChangeMpTeamAvatarRsp other) {} // 0x0000000181766370-0x00000001817664D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181766190-0x0000000181766310
}

