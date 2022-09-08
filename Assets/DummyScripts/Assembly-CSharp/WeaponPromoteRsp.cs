/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WeaponPromoteRsp : MessageBase, IMessage<WeaponPromoteRsp> // TypeDefIndex: 23660
{
	// Fields
	private static readonly MessageParser<WeaponPromoteRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B04883
	private int retcode_; // 0x18
	public const int TargetWeaponGuidFieldNumber = 2; // Metadata: 0x00B04887
	private ulong targetWeaponGuid_; // 0x20
	public const int OldPromoteLevelFieldNumber = 3; // Metadata: 0x00B0488B
	private uint oldPromoteLevel_; // 0x28
	public const int CurPromoteLevelFieldNumber = 4; // Metadata: 0x00B0488F
	private uint curPromoteLevel_; // 0x2C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WeaponPromoteRsp> Parser { get => default; } // 0x00000001822452F0-0x0000000182245380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182244EA0-0x0000000182244F30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182244B30-0x0000000182244BB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182244280-0x00000001822442E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182245840-0x0000000182245930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001822455F0-0x0000000182245650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182244FD0-0x00000001822450C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001822457F0-0x0000000182245840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182244C50-0x0000000182244D40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182244A90-0x0000000182244B30 0x0000000182244550-0x00000001822445F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong TargetWeaponGuid { get => default; set {} } // 0x0000000182245410-0x00000001822454B0 0x00000001822445F0-0x0000000182244690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OldPromoteLevel { get => default; set {} } // 0x0000000182244F30-0x0000000182244FD0 0x0000000182245250-0x00000001822452F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurPromoteLevel { get => default; set {} } // 0x00000001822451B0-0x0000000182245250 0x0000000182245500-0x00000001822455A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23661
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23662
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 622
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WeaponPromoteRsp() {} // 0x0000000182245D10-0x0000000182245D70
	static WeaponPromoteRsp() {} // 0x0000000182245C50-0x0000000182245D10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WeaponPromoteRsp Clone() => default; // 0x00000001822450C0-0x00000001822451B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WeaponPromoteRsp ShallowCopy() => default; // 0x0000000182244BB0-0x0000000182244C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182244470-0x00000001822444C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001822454B0-0x0000000182245500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001822455A0-0x00000001822455F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001822444C0-0x0000000182244550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182244690-0x0000000182244760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WeaponPromoteRsp other) => default; // 0x0000000182244760-0x00000001822448C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182244D40-0x0000000182244EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182245930-0x0000000182245C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182245650-0x00000001822457F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001822448C0-0x0000000182244A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WeaponPromoteRsp other) {} // 0x00000001822442E0-0x0000000182244470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182244150-0x0000000182244280
}

