/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CancelCityReputationRequestRsp : MessageBase, IMessage<CancelCityReputationRequestRsp> // TypeDefIndex: 24783
{
	// Fields
	private static readonly MessageParser<CancelCityReputationRequestRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B073A3
	private int retcode_; // 0x18
	public const int CityIdFieldNumber = 2; // Metadata: 0x00B073A7
	private uint cityId_; // 0x1C
	public const int RequestIdFieldNumber = 3; // Metadata: 0x00B073AB
	private uint requestId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CancelCityReputationRequestRsp> Parser { get => default; } // 0x0000000182A6B630-0x0000000182A6B6C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182A6B3C0-0x0000000182A6B450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182A6B080-0x0000000182A6B100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182A6A740-0x0000000182A6A7A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182A6BAA0-0x0000000182A6BB90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182A6B890-0x0000000182A6B8F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182A6B450-0x0000000182A6B540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182A6BA50-0x0000000182A6BAA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182A6B1A0-0x0000000182A6B290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182A6AFE0-0x0000000182A6B080 0x0000000182A6ABB0-0x0000000182A6AC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CityId { get => default; set {} } // 0x0000000182A6AA40-0x0000000182A6AAE0 0x0000000182A6B750-0x0000000182A6B7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RequestId { get => default; set {} } // 0x0000000182A6A7A0-0x0000000182A6A840 0x0000000182A6A840-0x0000000182A6A8E0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24784
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24785
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2811
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CancelCityReputationRequestRsp() {} // 0x0000000182A6BEE0-0x0000000182A6BF40
	static CancelCityReputationRequestRsp() {} // 0x0000000182A6BE20-0x0000000182A6BEE0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CancelCityReputationRequestRsp Clone() => default; // 0x0000000182A6B540-0x0000000182A6B630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CancelCityReputationRequestRsp ShallowCopy() => default; // 0x0000000182A6B100-0x0000000182A6B1A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182A6AAE0-0x0000000182A6AB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182A6B7F0-0x0000000182A6B840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182A6B840-0x0000000182A6B890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182A6AB30-0x0000000182A6ABB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182A6AC50-0x0000000182A6AD20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CancelCityReputationRequestRsp other) => default; // 0x0000000182A6AD20-0x0000000182A6AE60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182A6B290-0x0000000182A6B3C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182A6BB90-0x0000000182A6BE20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182A6B8F0-0x0000000182A6BA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182A6AE60-0x0000000182A6AFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CancelCityReputationRequestRsp other) {} // 0x0000000182A6A8E0-0x0000000182A6AA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182A6A630-0x0000000182A6A740
}

