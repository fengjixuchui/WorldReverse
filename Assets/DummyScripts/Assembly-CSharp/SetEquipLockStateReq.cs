/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SetEquipLockStateReq : MessageBase, IMessage<SetEquipLockStateReq> // TypeDefIndex: 23758
{
	// Fields
	private static readonly MessageParser<SetEquipLockStateReq> _parser; // 0x00
	public const int TargetEquipGuidFieldNumber = 1; // Metadata: 0x00B04C2F
	private ulong targetEquipGuid_; // 0x18
	public const int IsLockedFieldNumber = 2; // Metadata: 0x00B04C33
	private bool isLocked_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SetEquipLockStateReq> Parser { get => default; } // 0x00000001840E76B0-0x00000001840E7740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001840E73A0-0x00000001840E7430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001840E7080-0x00000001840E7100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001840E6A00-0x00000001840E6A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001840E7AE0-0x00000001840E7BD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001840E7870-0x00000001840E78D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001840E74D0-0x00000001840E75C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001840E79F0-0x00000001840E7A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001840E71A0-0x00000001840E7290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong TargetEquipGuid { get => default; set {} } // 0x00000001840E7A40-0x00000001840E7AE0 0x00000001840E7430-0x00000001840E74D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsLocked { get => default; set {} } // 0x00000001840E6CF0-0x00000001840E6D90 0x00000001840E6A60-0x00000001840E6B00

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23759
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23760
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 659
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetEquipLockStateReq() {} // 0x00000001840E7E90-0x00000001840E7EF0
	static SetEquipLockStateReq() {} // 0x00000001840E7DD0-0x00000001840E7E90

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetEquipLockStateReq Clone() => default; // 0x00000001840E75C0-0x00000001840E76B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetEquipLockStateReq ShallowCopy() => default; // 0x00000001840E7100-0x00000001840E71A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001840E6C30-0x00000001840E6C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001840E77D0-0x00000001840E7820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001840E7820-0x00000001840E7870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001840E6C80-0x00000001840E6CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001840E6EB0-0x00000001840E6F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SetEquipLockStateReq other) => default; // 0x00000001840E6D90-0x00000001840E6EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001840E7290-0x00000001840E73A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001840E7BD0-0x00000001840E7DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001840E78D0-0x00000001840E79F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001840E6F80-0x00000001840E7080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SetEquipLockStateReq other) {} // 0x00000001840E6B00-0x00000001840E6C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001840E6900-0x00000001840E6A00
}

