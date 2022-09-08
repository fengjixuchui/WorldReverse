/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeoffEquipReq : MessageBase, IMessage<TakeoffEquipReq> // TypeDefIndex: 23642
{
	// Fields
	private static readonly MessageParser<TakeoffEquipReq> _parser; // 0x00
	public const int AvatarGuidFieldNumber = 1; // Metadata: 0x00B047C3
	private ulong avatarGuid_; // 0x18
	public const int SlotFieldNumber = 2; // Metadata: 0x00B047C7
	private uint slot_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeoffEquipReq> Parser { get => default; } // 0x0000000184A9B100-0x0000000184A9B190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184A9AD50-0x0000000184A9ADE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184A9AA30-0x0000000184A9AAB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184A9A420-0x0000000184A9A480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184A9B530-0x0000000184A9B620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184A9B360-0x0000000184A9B3C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184A9AE80-0x0000000184A9AF70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184A9B4E0-0x0000000184A9B530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184A9AB50-0x0000000184A9AC40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x0000000184A9ADE0-0x0000000184A9AE80 0x0000000184A9A5B0-0x0000000184A9A650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Slot { get => default; set {} } // 0x0000000184A9B2C0-0x0000000184A9B360 0x0000000184A9B060-0x0000000184A9B100

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23643
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23644
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 616
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeoffEquipReq() {} // 0x0000000184A9B8E0-0x0000000184A9B940
	static TakeoffEquipReq() {} // 0x0000000184A9B820-0x0000000184A9B8E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeoffEquipReq Clone() => default; // 0x0000000184A9AF70-0x0000000184A9B060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeoffEquipReq ShallowCopy() => default; // 0x0000000184A9AAB0-0x0000000184A9AB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184A9A650-0x0000000184A9A6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184A9B220-0x0000000184A9B270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184A9B270-0x0000000184A9B2C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184A9A6A0-0x0000000184A9A710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184A9A710-0x0000000184A9A7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeoffEquipReq other) => default; // 0x0000000184A9A7E0-0x0000000184A9A900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184A9AC40-0x0000000184A9AD50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184A9B620-0x0000000184A9B820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184A9B3C0-0x0000000184A9B4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184A9A900-0x0000000184A9AA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeoffEquipReq other) {} // 0x0000000184A9A480-0x0000000184A9A5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184A9A320-0x0000000184A9A420
}

