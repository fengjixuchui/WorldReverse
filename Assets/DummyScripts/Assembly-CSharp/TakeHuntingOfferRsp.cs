/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeHuntingOfferRsp : MessageBase, IMessage<TakeHuntingOfferRsp> // TypeDefIndex: 23531
{
	// Fields
	private static readonly MessageParser<TakeHuntingOfferRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0437F
	private int retcode_; // 0x18
	public const int CityIdFieldNumber = 2; // Metadata: 0x00B04383
	private uint cityId_; // 0x1C
	public const int HuntingPairFieldNumber = 3; // Metadata: 0x00B04387
	private HuntingPair huntingPair_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeHuntingOfferRsp> Parser { get => default; } // 0x0000000182F6C280-0x0000000182F6C310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182F6C010-0x0000000182F6C0A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182F6BC50-0x0000000182F6BCD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182F6B200-0x0000000182F6B260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182F6C750-0x0000000182F6C840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182F6C540-0x0000000182F6C5A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182F6C0A0-0x0000000182F6C190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182F6C700-0x0000000182F6C750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182F6BD70-0x0000000182F6BE60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182F6BBB0-0x0000000182F6BC50 0x0000000182F6B710-0x0000000182F6B7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CityId { get => default; set {} } // 0x0000000182F6B410-0x0000000182F6B4B0 0x0000000182F6C3A0-0x0000000182F6C440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingPair HuntingPair { get => default; set {} } // 0x0000000182F6B4B0-0x0000000182F6B550 0x0000000182F6B000-0x0000000182F6B0A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23532
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23533
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4302
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeHuntingOfferRsp() {} // 0x0000000182F6CB70-0x0000000182F6CBD0
	static TakeHuntingOfferRsp() {} // 0x0000000182F6CAB0-0x0000000182F6CB70

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeHuntingOfferRsp Clone() => default; // 0x0000000182F6C190-0x0000000182F6C280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeHuntingOfferRsp ShallowCopy() => default; // 0x0000000182F6BCD0-0x0000000182F6BD70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182F6B550-0x0000000182F6B5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182F6C440-0x0000000182F6C4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182F6C4C0-0x0000000182F6C540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182F6B5D0-0x0000000182F6B710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182F6B900-0x0000000182F6B9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeHuntingOfferRsp other) => default; // 0x0000000182F6B7B0-0x0000000182F6B900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182F6BE60-0x0000000182F6C010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182F6C840-0x0000000182F6CAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182F6C5A0-0x0000000182F6C700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182F6B9D0-0x0000000182F6BBB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeHuntingOfferRsp other) {} // 0x0000000182F6B260-0x0000000182F6B410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182F6B0A0-0x0000000182F6B200
}

