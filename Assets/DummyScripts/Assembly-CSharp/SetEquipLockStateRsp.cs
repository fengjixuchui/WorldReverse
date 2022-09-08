/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SetEquipLockStateRsp : MessageBase, IMessage<SetEquipLockStateRsp> // TypeDefIndex: 23761
{
	// Fields
	private static readonly MessageParser<SetEquipLockStateRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B04C4B
	private int retcode_; // 0x18
	public const int TargetEquipGuidFieldNumber = 2; // Metadata: 0x00B04C4F
	private ulong targetEquipGuid_; // 0x20
	public const int IsLockedFieldNumber = 3; // Metadata: 0x00B04C53
	private bool isLocked_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SetEquipLockStateRsp> Parser { get => default; } // 0x0000000181E3E590-0x0000000181E3E620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181E3E280-0x0000000181E3E310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181E3DF30-0x0000000181E3DFB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181E3D6C0-0x0000000181E3D720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181E3EA00-0x0000000181E3EAF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181E3E750-0x0000000181E3E7B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181E3E3B0-0x0000000181E3E4A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181E3E910-0x0000000181E3E960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181E3E050-0x0000000181E3E140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181E3DE90-0x0000000181E3DF30 0x0000000181E3DA90-0x0000000181E3DB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong TargetEquipGuid { get => default; set {} } // 0x0000000181E3E960-0x0000000181E3EA00 0x0000000181E3E310-0x0000000181E3E3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsLocked { get => default; set {} } // 0x0000000181E3D9F0-0x0000000181E3DA90 0x0000000181E3D720-0x0000000181E3D7C0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23762
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23763
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 660
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetEquipLockStateRsp() {} // 0x0000000181E3EE40-0x0000000181E3EEA0
	static SetEquipLockStateRsp() {} // 0x0000000181E3ED80-0x0000000181E3EE40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetEquipLockStateRsp Clone() => default; // 0x0000000181E3E4A0-0x0000000181E3E590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetEquipLockStateRsp ShallowCopy() => default; // 0x0000000181E3DFB0-0x0000000181E3E050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181E3D920-0x0000000181E3D970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E3E6B0-0x0000000181E3E700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E3E700-0x0000000181E3E750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181E3D970-0x0000000181E3D9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181E3DC70-0x0000000181E3DD40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SetEquipLockStateRsp other) => default; // 0x0000000181E3DB30-0x0000000181E3DC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181E3E140-0x0000000181E3E280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181E3EAF0-0x0000000181E3ED80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181E3E7B0-0x0000000181E3E910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181E3DD40-0x0000000181E3DE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SetEquipLockStateRsp other) {} // 0x0000000181E3D7C0-0x0000000181E3D920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181E3D5B0-0x0000000181E3D6C0
}

