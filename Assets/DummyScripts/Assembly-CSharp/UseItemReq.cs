/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UseItemReq : MessageBase, IMessage<UseItemReq> // TypeDefIndex: 23624
{
	// Fields
	private static readonly MessageParser<UseItemReq> _parser; // 0x00
	public const int GuidFieldNumber = 1; // Metadata: 0x00B046FF
	private ulong guid_; // 0x18
	public const int CountFieldNumber = 2; // Metadata: 0x00B04703
	private uint count_; // 0x20
	public const int TargetGuidFieldNumber = 3; // Metadata: 0x00B04707
	private ulong targetGuid_; // 0x28
	public const int OptionIdxFieldNumber = 4; // Metadata: 0x00B0470B
	private uint optionIdx_; // 0x30
	public const int IsEnterMpDungeonTeamFieldNumber = 5; // Metadata: 0x00B0470F
	private bool isEnterMpDungeonTeam_; // 0x34

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UseItemReq> Parser { get => default; } // 0x0000000182C69E40-0x0000000182C69ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182C69BD0-0x0000000182C69C60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182C69830-0x0000000182C698B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182C68DE0-0x0000000182C68E40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182C6A510-0x0000000182C6A600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182C6A1E0-0x0000000182C6A240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182C69C60-0x0000000182C69D50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182C6A4C0-0x0000000182C6A510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182C69950-0x0000000182C69A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong Guid { get => default; set {} } // 0x0000000182C68FF0-0x0000000182C69090 0x0000000182C69220-0x0000000182C692C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Count { get => default; set {} } // 0x0000000182C69F60-0x0000000182C6A000 0x0000000182C68D40-0x0000000182C68DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong TargetGuid { get => default; set {} } // 0x0000000182C6A140-0x0000000182C6A1E0 0x0000000182C69790-0x0000000182C69830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OptionIdx { get => default; set {} } // 0x0000000182C69090-0x0000000182C69130 0x0000000182C6A420-0x0000000182C6A4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsEnterMpDungeonTeam { get => default; set {} } // 0x0000000182C6A0A0-0x0000000182C6A140 0x0000000182C696F0-0x0000000182C69790

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23625
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23626
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 608
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UseItemReq() {} // 0x0000000182C6AA70-0x0000000182C6AAD0
	static UseItemReq() {} // 0x0000000182C6A9B0-0x0000000182C6AA70

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UseItemReq Clone() => default; // 0x0000000182C69D50-0x0000000182C69E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UseItemReq ShallowCopy() => default; // 0x0000000182C698B0-0x0000000182C69950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182C69130-0x0000000182C69180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C6A000-0x0000000182C6A050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C6A050-0x0000000182C6A0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182C69180-0x0000000182C69220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182C692C0-0x0000000182C69390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(UseItemReq other) => default; // 0x0000000182C69390-0x0000000182C69510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182C69A40-0x0000000182C69BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182C6A600-0x0000000182C6A9B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182C6A240-0x0000000182C6A420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182C69510-0x0000000182C696F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(UseItemReq other) {} // 0x0000000182C68E40-0x0000000182C68FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182C68BF0-0x0000000182C68D40
}

