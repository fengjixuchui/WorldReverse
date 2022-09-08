/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SetUpAvatarTeamRsp : MessageBase, IMessage<SetUpAvatarTeamRsp> // TypeDefIndex: 22393
{
	// Fields
	private static readonly MessageParser<SetUpAvatarTeamRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0179F
	private int retcode_; // 0x18
	public const int TeamIdFieldNumber = 2; // Metadata: 0x00B017A3
	private uint teamId_; // 0x1C
	public const int AvatarTeamGuidListFieldNumber = 3; // Metadata: 0x00B017A7
	private static readonly FieldCodec<ulong> _repeated_avatarTeamGuidList_codec; // 0x08
	private readonly RepeatedPrimitiveField<ulong> avatarTeamGuidList_; // 0x20
	public const int CurAvatarGuidFieldNumber = 4; // Metadata: 0x00B017AB
	private ulong curAvatarGuid_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SetUpAvatarTeamRsp> Parser { get => default; } // 0x0000000183D19610-0x0000000183D196A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183D19340-0x0000000183D193D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183D18F30-0x0000000183D18FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183D186C0-0x0000000183D18720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183D19C20-0x0000000183D19D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183D199B0-0x0000000183D19A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183D19430-0x0000000183D19520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183D19BD0-0x0000000183D19C20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183D19050-0x0000000183D19140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183D18E90-0x0000000183D18F30 0x0000000183D189E0-0x0000000183D18A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TeamId { get => default; set {} } // 0x0000000183D192A0-0x0000000183D19340 0x0000000183D19910-0x0000000183D199B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<ulong> AvatarTeamGuidList { get => default; } // 0x0000000183D193D0-0x0000000183D19430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong CurAvatarGuid { get => default; set {} } // 0x0000000183D19740-0x0000000183D197E0 0x0000000183D196A0-0x0000000183D19740

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22394
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22395
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1704
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetUpAvatarTeamRsp() {} // 0x0000000183D1A0F0-0x0000000183D1A180
	static SetUpAvatarTeamRsp() {} // 0x0000000183D1A010-0x0000000183D1A0F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetUpAvatarTeamRsp Clone() => default; // 0x0000000183D19520-0x0000000183D19610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetUpAvatarTeamRsp ShallowCopy() => default; // 0x0000000183D18FB0-0x0000000183D19050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183D188A0-0x0000000183D188F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D19870-0x0000000183D198C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D198C0-0x0000000183D19910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183D188F0-0x0000000183D189E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183D18A80-0x0000000183D18B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SetUpAvatarTeamRsp other) => default; // 0x0000000183D18B50-0x0000000183D18CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183D19140-0x0000000183D192A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183D19D10-0x0000000183D1A010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183D19A10-0x0000000183D19BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183D18CB0-0x0000000183D18E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SetUpAvatarTeamRsp other) {} // 0x0000000183D18720-0x0000000183D188A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183D18520-0x0000000183D186C0
}

