/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarTeamUpdateNotify : MessageBase, IMessage<AvatarTeamUpdateNotify> // TypeDefIndex: 22426
{
	// Fields
	private static readonly MessageParser<AvatarTeamUpdateNotify> _parser; // 0x00
	public const int AvatarTeamMapFieldNumber = 1; // Metadata: 0x00B018BB
	private static readonly MapField<uint, AvatarTeam> _map_avatarTeamMap_codec; // 0x08
	private readonly MapField<uint, AvatarTeam> avatarTeamMap_; // 0x18
	public const int TempAvatarGuidListFieldNumber = 2; // Metadata: 0x00B018BF
	private static readonly FieldCodec<ulong> _repeated_tempAvatarGuidList_codec; // 0x10
	private readonly RepeatedPrimitiveField<ulong> tempAvatarGuidList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarTeamUpdateNotify> Parser { get => default; } // 0x00000001840CCAF0-0x00000001840CCB80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001840CC880-0x00000001840CC910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001840CC4F0-0x00000001840CC570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001840CBE60-0x00000001840CBEC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001840CCEF0-0x00000001840CCFE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001840CCCB0-0x00000001840CCD10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001840CC910-0x00000001840CCA00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001840CCEA0-0x00000001840CCEF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001840CC610-0x00000001840CC700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, AvatarTeam> AvatarTeamMap { get => default; } // 0x00000001840CC820-0x00000001840CC880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<ulong> TempAvatarGuidList { get => default; } // 0x00000001840CCD10-0x00000001840CCD70 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22427
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22428
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1715
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarTeamUpdateNotify() {} // 0x00000001840CD320-0x00000001840CD3D0
	static AvatarTeamUpdateNotify() {} // 0x00000001840CD1A0-0x00000001840CD320

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarTeamUpdateNotify Clone() => default; // 0x00000001840CCA00-0x00000001840CCAF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarTeamUpdateNotify ShallowCopy() => default; // 0x00000001840CC570-0x00000001840CC610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001840CBFF0-0x00000001840CC040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001840CCC10-0x00000001840CCC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001840CCC60-0x00000001840CCCB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001840CC040-0x00000001840CC150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001840CC150-0x00000001840CC220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarTeamUpdateNotify other) => default; // 0x00000001840CC220-0x00000001840CC3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001840CC700-0x00000001840CC820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001840CCFE0-0x00000001840CD1A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001840CCD70-0x00000001840CCEA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001840CC3D0-0x00000001840CC4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarTeamUpdateNotify other) {} // 0x00000001840CBEC0-0x00000001840CBFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001840CBCB0-0x00000001840CBE60
}

