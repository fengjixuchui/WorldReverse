/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetHuntingOfferRewardReq : MessageBase, IMessage<GetHuntingOfferRewardReq> // TypeDefIndex: 23541
{
	// Fields
	private static readonly MessageParser<GetHuntingOfferRewardReq> _parser; // 0x00
	public const int CityIdFieldNumber = 1; // Metadata: 0x00B043E7
	private uint cityId_; // 0x18
	public const int HuntingPairFieldNumber = 2; // Metadata: 0x00B043EB
	private HuntingPair huntingPair_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetHuntingOfferRewardReq> Parser { get => default; } // 0x00000001824E26A0-0x00000001824E2730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001824E2430-0x00000001824E24C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001824E20A0-0x00000001824E2120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001824E1830-0x00000001824E1890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001824E2B30-0x00000001824E2C20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001824E2960-0x00000001824E29C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001824E24C0-0x00000001824E25B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001824E2AE0-0x00000001824E2B30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001824E21C0-0x00000001824E22B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CityId { get => default; set {} } // 0x00000001824E1A10-0x00000001824E1AB0 0x00000001824E27C0-0x00000001824E2860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingPair HuntingPair { get => default; set {} } // 0x00000001824E1AB0-0x00000001824E1B50 0x00000001824E1650-0x00000001824E16F0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23542
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23543
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4305
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetHuntingOfferRewardReq() {} // 0x00000001824E2EC0-0x00000001824E2F20
	static GetHuntingOfferRewardReq() {} // 0x00000001824E2E00-0x00000001824E2EC0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetHuntingOfferRewardReq Clone() => default; // 0x00000001824E25B0-0x00000001824E26A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetHuntingOfferRewardReq ShallowCopy() => default; // 0x00000001824E2120-0x00000001824E21C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001824E1B50-0x00000001824E1BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001824E2860-0x00000001824E28E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001824E28E0-0x00000001824E2960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001824E1BD0-0x00000001824E1D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001824E1D00-0x00000001824E1DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetHuntingOfferRewardReq other) => default; // 0x00000001824E1DD0-0x00000001824E1F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001824E22B0-0x00000001824E2430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001824E2C20-0x00000001824E2E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001824E29C0-0x00000001824E2AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001824E1F00-0x00000001824E20A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetHuntingOfferRewardReq other) {} // 0x00000001824E1890-0x00000001824E1A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001824E16F0-0x00000001824E1830
}

