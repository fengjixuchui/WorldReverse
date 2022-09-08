/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarDataNotify : MessageBase, IMessage<AvatarDataNotify> // TypeDefIndex: 22429
{
	// Fields
	private static readonly MessageParser<AvatarDataNotify> _parser; // 0x00
	public const int AvatarListFieldNumber = 1; // Metadata: 0x00B018D3
	private static readonly FieldCodec<AvatarInfo> _repeated_avatarList_codec; // 0x08
	private readonly RepeatedMessageField<AvatarInfo> avatarList_; // 0x18
	public const int AvatarTeamMapFieldNumber = 2; // Metadata: 0x00B018D7
	private static readonly MapField<uint, AvatarTeam> _map_avatarTeamMap_codec; // 0x10
	private readonly MapField<uint, AvatarTeam> avatarTeamMap_; // 0x20
	public const int CurAvatarTeamIdFieldNumber = 3; // Metadata: 0x00B018DB
	private uint curAvatarTeamId_; // 0x28
	public const int ChooseAvatarGuidFieldNumber = 4; // Metadata: 0x00B018DF
	private ulong chooseAvatarGuid_; // 0x30
	public const int TempAvatarGuidListFieldNumber = 5; // Metadata: 0x00B018E3
	private static readonly FieldCodec<ulong> _repeated_tempAvatarGuidList_codec; // 0x18
	private readonly RepeatedPrimitiveField<ulong> tempAvatarGuidList_; // 0x38
	public const int OwnedFlycloakListFieldNumber = 6; // Metadata: 0x00B018E7
	private static readonly FieldCodec<uint> _repeated_ownedFlycloakList_codec; // 0x20
	private readonly RepeatedPrimitiveField<uint> ownedFlycloakList_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarDataNotify> Parser { get => default; } // 0x0000000181891870-0x0000000181891900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181891500-0x0000000181891590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001818910C0-0x0000000181891140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181890680-0x00000001818906E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181891EA0-0x0000000181891F90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181891AB0-0x0000000181891B10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181891630-0x0000000181891720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181891E50-0x0000000181891EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001818911E0-0x00000001818912D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<AvatarInfo> AvatarList { get => default; } // 0x0000000181891810-0x0000000181891870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, AvatarTeam> AvatarTeamMap { get => default; } // 0x00000001818914A0-0x0000000181891500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurAvatarTeamId { get => default; set {} } // 0x00000001818905E0-0x0000000181890680 0x0000000181891DB0-0x0000000181891E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong ChooseAvatarGuid { get => default; set {} } // 0x0000000181891590-0x0000000181891630 0x00000001818906E0-0x0000000181890780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<ulong> TempAvatarGuidList { get => default; } // 0x0000000181891B10-0x0000000181891B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> OwnedFlycloakList { get => default; } // 0x00000001818902B0-0x0000000181890310 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22430
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22431
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1716
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarDataNotify() {} // 0x0000000181892550-0x0000000181892650
	static AvatarDataNotify() {} // 0x0000000181892360-0x0000000181892550

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarDataNotify Clone() => default; // 0x0000000181891720-0x0000000181891810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarDataNotify ShallowCopy() => default; // 0x0000000181891140-0x00000001818911E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181890970-0x00000001818909C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181891990-0x0000000181891A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181891A20-0x0000000181891AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001818909C0-0x0000000181890BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181890DA0-0x0000000181890E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarDataNotify other) => default; // 0x0000000181890BC0-0x0000000181890DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001818912D0-0x00000001818914A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181891F90-0x0000000181892360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181891B70-0x0000000181891DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181890E70-0x00000001818910C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarDataNotify other) {} // 0x0000000181890780-0x0000000181890970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181890310-0x00000001818905E0
}

