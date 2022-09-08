/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AcceptCityReputationRequestReq : MessageBase, IMessage<AcceptCityReputationRequestReq> // TypeDefIndex: 24774
{
	// Fields
	private static readonly MessageParser<AcceptCityReputationRequestReq> _parser; // 0x00
	public const int CityIdFieldNumber = 1; // Metadata: 0x00B0734F
	private uint cityId_; // 0x18
	public const int RequestIdFieldNumber = 2; // Metadata: 0x00B07353
	private uint requestId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AcceptCityReputationRequestReq> Parser { get => default; } // 0x0000000181CEEB10-0x0000000181CEEBA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181CEE8A0-0x0000000181CEE930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181CEE590-0x0000000181CEE610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181CEDE40-0x0000000181CEDEA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181CEEF40-0x0000000181CEF030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181CEED70-0x0000000181CEEDD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181CEE930-0x0000000181CEEA20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181CEEEF0-0x0000000181CEEF40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181CEE6B0-0x0000000181CEE7A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CityId { get => default; set {} } // 0x0000000181CEE110-0x0000000181CEE1B0 0x0000000181CEEC30-0x0000000181CEECD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RequestId { get => default; set {} } // 0x0000000181CEDEA0-0x0000000181CEDF40 0x0000000181CEDF40-0x0000000181CEDFE0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24775
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24776
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2808
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AcceptCityReputationRequestReq() {} // 0x0000000181CEF2F0-0x0000000181CEF3D0
	static AcceptCityReputationRequestReq() {} // 0x0000000181CEF230-0x0000000181CEF2F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AcceptCityReputationRequestReq Clone() => default; // 0x0000000181CEEA20-0x0000000181CEEB10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AcceptCityReputationRequestReq ShallowCopy() => default; // 0x0000000181CEE610-0x0000000181CEE6B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181CEE1B0-0x0000000181CEE200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181CEECD0-0x0000000181CEED20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181CEED20-0x0000000181CEED70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181CEE200-0x0000000181CEE270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181CEE270-0x0000000181CEE340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AcceptCityReputationRequestReq other) => default; // 0x0000000181CEE340-0x0000000181CEE460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181CEE7A0-0x0000000181CEE8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181CEF030-0x0000000181CEF230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181CEEDD0-0x0000000181CEEEF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181CEE460-0x0000000181CEE590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AcceptCityReputationRequestReq other) {} // 0x0000000181CEDFE0-0x0000000181CEE110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181CEDD40-0x0000000181CEDE40
}

