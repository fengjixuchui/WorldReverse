/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AcceptCityReputationRequestRsp : MessageBase, IMessage<AcceptCityReputationRequestRsp> // TypeDefIndex: 24777
{
	// Fields
	private static readonly MessageParser<AcceptCityReputationRequestRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0736B
	private int retcode_; // 0x18
	public const int CityIdFieldNumber = 2; // Metadata: 0x00B0736F
	private uint cityId_; // 0x1C
	public const int RequestIdFieldNumber = 3; // Metadata: 0x00B07373
	private uint requestId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AcceptCityReputationRequestRsp> Parser { get => default; } // 0x0000000180F7C850-0x0000000180F7C8E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000180F7C5E0-0x0000000180F7C670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000180F7C2A0-0x0000000180F7C320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000180F7B960-0x0000000180F7B9C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000180F7CCC0-0x0000000180F7CDB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000180F7CAB0-0x0000000180F7CB10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000180F7C670-0x0000000180F7C760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000180F7CC70-0x0000000180F7CCC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000180F7C3C0-0x0000000180F7C4B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000180F7C200-0x0000000180F7C2A0 0x0000000180F7BDD0-0x0000000180F7BE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CityId { get => default; set {} } // 0x0000000180F7BC60-0x0000000180F7BD00 0x0000000180F7C970-0x0000000180F7CA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RequestId { get => default; set {} } // 0x0000000180F7B9C0-0x0000000180F7BA60 0x0000000180F7BA60-0x0000000180F7BB00

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24778
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24779
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2809
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AcceptCityReputationRequestRsp() {} // 0x0000000180F7D100-0x0000000180F7D160
	static AcceptCityReputationRequestRsp() {} // 0x0000000180F7D040-0x0000000180F7D100

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AcceptCityReputationRequestRsp Clone() => default; // 0x0000000180F7C760-0x0000000180F7C850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AcceptCityReputationRequestRsp ShallowCopy() => default; // 0x0000000180F7C320-0x0000000180F7C3C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000180F7BD00-0x0000000180F7BD50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180F7CA10-0x0000000180F7CA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180F7CA60-0x0000000180F7CAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000180F7BD50-0x0000000180F7BDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000180F7BE70-0x0000000180F7BF40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AcceptCityReputationRequestRsp other) => default; // 0x0000000180F7BF40-0x0000000180F7C080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000180F7C4B0-0x0000000180F7C5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000180F7CDB0-0x0000000180F7D040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000180F7CB10-0x0000000180F7CC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000180F7C080-0x0000000180F7C200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AcceptCityReputationRequestRsp other) {} // 0x0000000180F7BB00-0x0000000180F7BC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000180F7B850-0x0000000180F7B960
}

