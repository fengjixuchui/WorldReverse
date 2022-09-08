/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WearEquipReq : MessageBase, IMessage<WearEquipReq> // TypeDefIndex: 23636
{
	// Fields
	private static readonly MessageParser<WearEquipReq> _parser; // 0x00
	public const int AvatarGuidFieldNumber = 1; // Metadata: 0x00B0478B
	private ulong avatarGuid_; // 0x18
	public const int EquipGuidFieldNumber = 2; // Metadata: 0x00B0478F
	private ulong equipGuid_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WearEquipReq> Parser { get => default; } // 0x0000000185180260-0x00000001851802F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018517FF50-0x000000018517FFE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018517FC30-0x000000018517FCB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018517F560-0x000000018517F5C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185180690-0x0000000185180780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185180420-0x0000000185180480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185180080-0x0000000185180170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185180640-0x0000000185180690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018517FD50-0x000000018517FE40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x000000018517FFE0-0x0000000185180080 0x000000018517F700-0x000000018517F7A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong EquipGuid { get => default; set {} } // 0x000000018517FB90-0x000000018517FC30 0x0000000185180480-0x0000000185180520

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23637
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23638
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 614
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WearEquipReq() {} // 0x0000000185180A40-0x0000000185180B30
	static WearEquipReq() {} // 0x0000000185180980-0x0000000185180A40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WearEquipReq Clone() => default; // 0x0000000185180170-0x0000000185180260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WearEquipReq ShallowCopy() => default; // 0x000000018517FCB0-0x000000018517FD50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018517F7A0-0x000000018517F7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185180380-0x00000001851803D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001851803D0-0x0000000185180420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018517F7F0-0x000000018517F860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018517F860-0x000000018517F930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WearEquipReq other) => default; // 0x000000018517F930-0x000000018517FA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018517FE40-0x000000018517FF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185180780-0x0000000185180980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185180520-0x0000000185180640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018517FA50-0x000000018517FB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WearEquipReq other) {} // 0x000000018517F5C0-0x000000018517F700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018517F460-0x000000018517F560
}

