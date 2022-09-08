/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetBargainDataRsp : MessageBase, IMessage<GetBargainDataRsp> // TypeDefIndex: 24645
{
	// Fields
	private static readonly MessageParser<GetBargainDataRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B06E97
	private int retcode_; // 0x18
	public const int BargainIdFieldNumber = 2; // Metadata: 0x00B06E9B
	private uint bargainId_; // 0x1C
	public const int SnapshotFieldNumber = 3; // Metadata: 0x00B06E9F
	private BargainSnapshot snapshot_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetBargainDataRsp> Parser { get => default; } // 0x00000001831A1D30-0x00000001831A1DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001831A1A20-0x00000001831A1AB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001831A1660-0x00000001831A16E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001831A0C10-0x00000001831A0C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001831A2160-0x00000001831A2250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001831A1F50-0x00000001831A1FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001831A1AB0-0x00000001831A1BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001831A2110-0x00000001831A2160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001831A1780-0x00000001831A1870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001831A15C0-0x00000001831A1660 0x00000001831A1080-0x00000001831A1120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BargainId { get => default; set {} } // 0x00000001831A2250-0x00000001831A22F0 0x00000001831A0FE0-0x00000001831A1080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BargainSnapshot Snapshot { get => default; set {} } // 0x00000001831A1120-0x00000001831A11C0 0x00000001831A1C90-0x00000001831A1D30

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24646
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24647
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 428
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetBargainDataRsp() {} // 0x00000001831A2620-0x00000001831A2680
	static GetBargainDataRsp() {} // 0x00000001831A2560-0x00000001831A2620

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetBargainDataRsp Clone() => default; // 0x00000001831A1BA0-0x00000001831A1C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetBargainDataRsp ShallowCopy() => default; // 0x00000001831A16E0-0x00000001831A1780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001831A0E20-0x00000001831A0EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831A1E50-0x00000001831A1ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831A1ED0-0x00000001831A1F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001831A0EA0-0x00000001831A0FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001831A1310-0x00000001831A13E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetBargainDataRsp other) => default; // 0x00000001831A11C0-0x00000001831A1310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001831A1870-0x00000001831A1A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001831A22F0-0x00000001831A2560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001831A1FB0-0x00000001831A2110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001831A13E0-0x00000001831A15C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetBargainDataRsp other) {} // 0x00000001831A0C70-0x00000001831A0E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001831A0AB0-0x00000001831A0C10
}

