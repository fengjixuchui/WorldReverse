/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WearEquipRsp : MessageBase, IMessage<WearEquipRsp> // TypeDefIndex: 23639
{
	// Fields
	private static readonly MessageParser<WearEquipRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B047A7
	private int retcode_; // 0x18
	public const int AvatarGuidFieldNumber = 2; // Metadata: 0x00B047AB
	private ulong avatarGuid_; // 0x20
	public const int EquipGuidFieldNumber = 3; // Metadata: 0x00B047AF
	private ulong equipGuid_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WearEquipRsp> Parser { get => default; } // 0x0000000181F4BFD0-0x0000000181F4C060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181F4BCC0-0x0000000181F4BD50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181F4B970-0x0000000181F4B9F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181F4B0C0-0x0000000181F4B120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181F4C440-0x0000000181F4C530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181F4C190-0x0000000181F4C1F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181F4BDF0-0x0000000181F4BEE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181F4C3F0-0x0000000181F4C440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181F4BA90-0x0000000181F4BB80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181F4B830-0x0000000181F4B8D0 0x0000000181F4B3F0-0x0000000181F4B490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x0000000181F4BD50-0x0000000181F4BDF0 0x0000000181F4B280-0x0000000181F4B320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong EquipGuid { get => default; set {} } // 0x0000000181F4B8D0-0x0000000181F4B970 0x0000000181F4C1F0-0x0000000181F4C290

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23640
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23641
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 615
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WearEquipRsp() {} // 0x0000000181F4C880-0x0000000181F4C8E0
	static WearEquipRsp() {} // 0x0000000181F4C7C0-0x0000000181F4C880

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WearEquipRsp Clone() => default; // 0x0000000181F4BEE0-0x0000000181F4BFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WearEquipRsp ShallowCopy() => default; // 0x0000000181F4B9F0-0x0000000181F4BA90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181F4B320-0x0000000181F4B370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181F4C0F0-0x0000000181F4C140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181F4C140-0x0000000181F4C190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181F4B370-0x0000000181F4B3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181F4B490-0x0000000181F4B560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WearEquipRsp other) => default; // 0x0000000181F4B560-0x0000000181F4B6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181F4BB80-0x0000000181F4BCC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181F4C530-0x0000000181F4C7C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181F4C290-0x0000000181F4C3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181F4B6A0-0x0000000181F4B830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WearEquipRsp other) {} // 0x0000000181F4B120-0x0000000181F4B280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181F4AFB0-0x0000000181F4B0C0
}

