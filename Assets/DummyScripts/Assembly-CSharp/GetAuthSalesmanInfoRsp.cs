/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetAuthSalesmanInfoRsp : MessageBase, IMessage<GetAuthSalesmanInfoRsp> // TypeDefIndex: 21963
{
	// Fields
	private static readonly MessageParser<GetAuthSalesmanInfoRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0074F
	private int retcode_; // 0x18
	public const int ScheduleIdFieldNumber = 2; // Metadata: 0x00B00753
	private uint scheduleId_; // 0x1C
	public const int DayRewardIdFieldNumber = 3; // Metadata: 0x00B00757
	private uint dayRewardId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetAuthSalesmanInfoRsp> Parser { get => default; } // 0x00000001843FD860-0x00000001843FD8F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001843FD5F0-0x00000001843FD680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001843FD210-0x00000001843FD290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001843FC970-0x00000001843FC9D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001843FDCD0-0x00000001843FDDC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001843FDA20-0x00000001843FDA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001843FD680-0x00000001843FD770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001843FDC80-0x00000001843FDCD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001843FD330-0x00000001843FD420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001843FD170-0x00000001843FD210 0x00000001843FCD40-0x00000001843FCDE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleId { get => default; set {} } // 0x00000001843FCCA0-0x00000001843FCD40 0x00000001843FDA80-0x00000001843FDB20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DayRewardId { get => default; set {} } // 0x00000001843FC9D0-0x00000001843FCA70 0x00000001843FD550-0x00000001843FD5F0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21964
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21965
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2039
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetAuthSalesmanInfoRsp() {} // 0x00000001843FE110-0x00000001843FE170
	static GetAuthSalesmanInfoRsp() {} // 0x00000001843FE050-0x00000001843FE110

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetAuthSalesmanInfoRsp Clone() => default; // 0x00000001843FD770-0x00000001843FD860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetAuthSalesmanInfoRsp ShallowCopy() => default; // 0x00000001843FD290-0x00000001843FD330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001843FCBD0-0x00000001843FCC20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001843FD980-0x00000001843FD9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001843FD9D0-0x00000001843FDA20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001843FCC20-0x00000001843FCCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001843FCF20-0x00000001843FCFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetAuthSalesmanInfoRsp other) => default; // 0x00000001843FCDE0-0x00000001843FCF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001843FD420-0x00000001843FD550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001843FDDC0-0x00000001843FE050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001843FDB20-0x00000001843FDC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001843FCFF0-0x00000001843FD170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetAuthSalesmanInfoRsp other) {} // 0x00000001843FCA70-0x00000001843FCBD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001843FC860-0x00000001843FC970
}

