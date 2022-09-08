/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MistTrialSelectAvatarAndEnterDungeonReq : MessageBase, IMessage<MistTrialSelectAvatarAndEnterDungeonReq> // TypeDefIndex: 22334
{
	// Fields
	private static readonly MessageParser<MistTrialSelectAvatarAndEnterDungeonReq> _parser; // 0x00
	public const int SelectTrialAvatarIdListFieldNumber = 1; // Metadata: 0x00B015AF
	private static readonly FieldCodec<uint> _repeated_selectTrialAvatarIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> selectTrialAvatarIdList_; // 0x18
	public const int TrialIdFieldNumber = 2; // Metadata: 0x00B015B3
	private uint trialId_; // 0x20
	public const int EnterPointIdFieldNumber = 3; // Metadata: 0x00B015B7
	private uint enterPointId_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MistTrialSelectAvatarAndEnterDungeonReq> Parser { get => default; } // 0x000000018346A5F0-0x000000018346A680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018346A1A0-0x000000018346A230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183469E10-0x0000000183469E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001834696E0-0x0000000183469740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018346A9E0-0x000000018346AAD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018346A7B0-0x000000018346A810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018346A230-0x000000018346A320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018346A990-0x000000018346A9E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183469F30-0x000000018346A020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> SelectTrialAvatarIdList { get => default; } // 0x000000018346A140-0x000000018346A1A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TrialId { get => default; set {} } // 0x000000018346A550-0x000000018346A5F0 0x0000000183469D70-0x0000000183469E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EnterPointId { get => default; set {} } // 0x000000018346A4B0-0x000000018346A550 0x000000018346A410-0x000000018346A4B0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22335
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22336
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 8021
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MistTrialSelectAvatarAndEnterDungeonReq() {} // 0x000000018346AE20-0x000000018346AEB0
	static MistTrialSelectAvatarAndEnterDungeonReq() {} // 0x000000018346AD40-0x000000018346AE20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MistTrialSelectAvatarAndEnterDungeonReq Clone() => default; // 0x000000018346A320-0x000000018346A410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MistTrialSelectAvatarAndEnterDungeonReq ShallowCopy() => default; // 0x0000000183469E90-0x0000000183469F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001834698A0-0x00000001834698F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018346A710-0x000000018346A760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018346A760-0x000000018346A7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001834698F0-0x00000001834699D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001834699D0-0x0000000183469AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MistTrialSelectAvatarAndEnterDungeonReq other) => default; // 0x0000000183469AA0-0x0000000183469BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018346A020-0x000000018346A140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018346AAD0-0x000000018346AD40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018346A810-0x000000018346A990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183469BE0-0x0000000183469D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MistTrialSelectAvatarAndEnterDungeonReq other) {} // 0x0000000183469740-0x00000001834698A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183469560-0x00000001834696E0
}

