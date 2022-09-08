/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UseMiracleRingReq : MessageBase, IMessage<UseMiracleRingReq> // TypeDefIndex: 23919
{
	// Fields
	private static readonly MessageParser<UseMiracleRingReq> _parser; // 0x00
	public const int MiracleRingOpTypeFieldNumber = 1; // Metadata: 0x00B05217
	private uint miracleRingOpType_; // 0x18
	public const int PosFieldNumber = 2; // Metadata: 0x00B0521B
	private Vector pos_; // 0x20
	public const int RotFieldNumber = 3; // Metadata: 0x00B0521F
	private Vector rot_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UseMiracleRingReq> Parser { get => default; } // 0x00000001838FA670-0x00000001838FA700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001838FA2C0-0x00000001838FA350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001838F9E90-0x00000001838F9F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001838F9490-0x00000001838F94F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001838FAC90-0x00000001838FAD80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001838FA950-0x00000001838FA9B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001838FA490-0x00000001838FA580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001838FAC40-0x00000001838FAC90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001838F9FB0-0x00000001838FA0A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MiracleRingOpType { get => default; set {} } // 0x00000001838FABA0-0x00000001838FAC40 0x00000001838FA350-0x00000001838FA3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x00000001838FA8B0-0x00000001838FA950 0x00000001838FAB00-0x00000001838FABA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Rot { get => default; set {} } // 0x00000001838FA3F0-0x00000001838FA490 0x00000001838F94F0-0x00000001838F9590

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23920
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23921
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 5201
		}

		public enum MiracleRingOpType // TypeDefIndex: 23922
		{
			MiracleRingOpNone = 0,
			MiracleRingOpPlace = 1,
			MiracleRingOpRetract = 2
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UseMiracleRingReq() {} // 0x00000001838FB0A0-0x00000001838FB1A0
	static UseMiracleRingReq() {} // 0x00000001838FAFE0-0x00000001838FB0A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UseMiracleRingReq Clone() => default; // 0x00000001838FA580-0x00000001838FA670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UseMiracleRingReq ShallowCopy() => default; // 0x00000001838F9F10-0x00000001838F9FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001838F9790-0x00000001838F9820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001838FA790-0x00000001838FA820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001838FA820-0x00000001838FA8B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001838F9820-0x00000001838F9A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001838F9B70-0x00000001838F9C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(UseMiracleRingReq other) => default; // 0x00000001838F9A10-0x00000001838F9B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001838FA0A0-0x00000001838FA2C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001838FAD80-0x00000001838FAFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001838FA9B0-0x00000001838FAB00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001838F9C40-0x00000001838F9E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(UseMiracleRingReq other) {} // 0x00000001838F9590-0x00000001838F9790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001838F9300-0x00000001838F9490
}

