/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MechanicusUnlockGearReq : MessageBase, IMessage<MechanicusUnlockGearReq> // TypeDefIndex: 23895
{
	// Fields
	private static readonly MessageParser<MechanicusUnlockGearReq> _parser; // 0x00
	public const int MechanicusIdFieldNumber = 1; // Metadata: 0x00B05137
	private uint mechanicusId_; // 0x18
	public const int GearIdFieldNumber = 2; // Metadata: 0x00B0513B
	private uint gearId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MechanicusUnlockGearReq> Parser { get => default; } // 0x000000018552F420-0x000000018552F4B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018552F110-0x000000018552F1A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018552ED60-0x000000018552EDE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018552E750-0x000000018552E7B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018552F850-0x000000018552F940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018552F680-0x000000018552F6E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018552F240-0x000000018552F330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018552F800-0x000000018552F850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018552EF20-0x000000018552F010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MechanicusId { get => default; set {} } // 0x000000018552F1A0-0x000000018552F240 0x000000018552E9A0-0x000000018552EA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GearId { get => default; set {} } // 0x000000018552F5E0-0x000000018552F680 0x000000018552EE80-0x000000018552EF20

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23896
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23897
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 3907
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MechanicusUnlockGearReq() {} // 0x000000018552FC00-0x000000018552FC60
	static MechanicusUnlockGearReq() {} // 0x000000018552FB40-0x000000018552FC00

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MechanicusUnlockGearReq Clone() => default; // 0x000000018552F330-0x000000018552F420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MechanicusUnlockGearReq ShallowCopy() => default; // 0x000000018552EDE0-0x000000018552EE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018552E8E0-0x000000018552E930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018552F540-0x000000018552F590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018552F590-0x000000018552F5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018552E930-0x000000018552E9A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018552EA40-0x000000018552EB10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MechanicusUnlockGearReq other) => default; // 0x000000018552EB10-0x000000018552EC30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018552F010-0x000000018552F110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018552F940-0x000000018552FB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018552F6E0-0x000000018552F800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018552EC30-0x000000018552ED60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MechanicusUnlockGearReq other) {} // 0x000000018552E7B0-0x000000018552E8E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018552E650-0x000000018552E750
}

