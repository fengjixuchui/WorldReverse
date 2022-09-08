/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SetUpAvatarTeamReq : MessageBase, IMessage<SetUpAvatarTeamReq> // TypeDefIndex: 22390
{
	// Fields
	private static readonly MessageParser<SetUpAvatarTeamReq> _parser; // 0x00
	public const int TeamIdFieldNumber = 1; // Metadata: 0x00B0177F
	private uint teamId_; // 0x18
	public const int AvatarTeamGuidListFieldNumber = 2; // Metadata: 0x00B01783
	private static readonly FieldCodec<ulong> _repeated_avatarTeamGuidList_codec; // 0x08
	private readonly RepeatedPrimitiveField<ulong> avatarTeamGuidList_; // 0x20
	public const int CurAvatarGuidFieldNumber = 3; // Metadata: 0x00B01787
	private ulong curAvatarGuid_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SetUpAvatarTeamReq> Parser { get => default; } // 0x0000000184C044C0-0x0000000184C04550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184C041F0-0x0000000184C04280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184C03E10-0x0000000184C03E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184C03780-0x0000000184C037E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184C04A90-0x0000000184C04B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184C04860-0x0000000184C048C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184C042E0-0x0000000184C043D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184C04A40-0x0000000184C04A90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184C03F30-0x0000000184C04020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TeamId { get => default; set {} } // 0x0000000184C04150-0x0000000184C041F0 0x0000000184C047C0-0x0000000184C04860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<ulong> AvatarTeamGuidList { get => default; } // 0x0000000184C04280-0x0000000184C042E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong CurAvatarGuid { get => default; set {} } // 0x0000000184C045F0-0x0000000184C04690 0x0000000184C04550-0x0000000184C045F0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22391
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22392
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1703
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetUpAvatarTeamReq() {} // 0x0000000184C04ED0-0x0000000184C04F60
	static SetUpAvatarTeamReq() {} // 0x0000000184C04DF0-0x0000000184C04ED0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetUpAvatarTeamReq Clone() => default; // 0x0000000184C043D0-0x0000000184C044C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetUpAvatarTeamReq ShallowCopy() => default; // 0x0000000184C03E90-0x0000000184C03F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184C03940-0x0000000184C03990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184C04720-0x0000000184C04770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184C04770-0x0000000184C047C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184C03990-0x0000000184C03A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184C03A70-0x0000000184C03B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SetUpAvatarTeamReq other) => default; // 0x0000000184C03B40-0x0000000184C03C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184C04020-0x0000000184C04150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184C04B80-0x0000000184C04DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184C048C0-0x0000000184C04A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184C03C80-0x0000000184C03E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SetUpAvatarTeamReq other) {} // 0x0000000184C037E0-0x0000000184C03940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184C03600-0x0000000184C03780
}

