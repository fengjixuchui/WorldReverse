/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ProudSkillChangeNotify : MessageBase, IMessage<ProudSkillChangeNotify> // TypeDefIndex: 25507
{
	// Fields
	private static readonly MessageParser<ProudSkillChangeNotify> _parser; // 0x00
	public const int AvatarGuidFieldNumber = 1; // Metadata: 0x00B08EAF
	private ulong avatarGuid_; // 0x18
	public const int EntityIdFieldNumber = 2; // Metadata: 0x00B08EB3
	private uint entityId_; // 0x20
	public const int SkillDepotIdFieldNumber = 3; // Metadata: 0x00B08EB7
	private uint skillDepotId_; // 0x24
	public const int ProudSkillListFieldNumber = 4; // Metadata: 0x00B08EBB
	private static readonly FieldCodec<uint> _repeated_proudSkillList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> proudSkillList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ProudSkillChangeNotify> Parser { get => default; } // 0x000000018437D400-0x000000018437D490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018437D0F0-0x000000018437D180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018437CCE0-0x000000018437CD60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018437C520-0x000000018437C580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018437D9D0-0x000000018437DAC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018437D6C0-0x000000018437D720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018437D220-0x000000018437D310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018437D980-0x000000018437D9D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018437CEA0-0x000000018437CF90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x000000018437D180-0x000000018437D220 0x000000018437C700-0x000000018437C7A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x000000018437D620-0x000000018437D6C0 0x000000018437DAC0-0x000000018437DB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SkillDepotId { get => default; set {} } // 0x000000018437D720-0x000000018437D7C0 0x000000018437CE00-0x000000018437CEA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ProudSkillList { get => default; } // 0x000000018437D520-0x000000018437D580 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25508
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25509
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1011
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ProudSkillChangeNotify() {} // 0x000000018437DF40-0x000000018437DFD0
	static ProudSkillChangeNotify() {} // 0x000000018437DE60-0x000000018437DF40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ProudSkillChangeNotify Clone() => default; // 0x000000018437D310-0x000000018437D400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ProudSkillChangeNotify ShallowCopy() => default; // 0x000000018437CD60-0x000000018437CE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018437C7A0-0x000000018437C7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018437D580-0x000000018437D5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018437D5D0-0x000000018437D620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018437C7F0-0x000000018437C8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018437C8D0-0x000000018437C9A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ProudSkillChangeNotify other) => default; // 0x000000018437C9A0-0x000000018437CB00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018437CF90-0x000000018437D0F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018437DB60-0x000000018437DE60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018437D7C0-0x000000018437D980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018437CB00-0x000000018437CCE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ProudSkillChangeNotify other) {} // 0x000000018437C580-0x000000018437C700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018437C380-0x000000018437C520
}

