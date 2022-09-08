/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetCityHuntingOfferReq : MessageBase, IMessage<GetCityHuntingOfferReq> // TypeDefIndex: 23535
{
	// Fields
	private static readonly MessageParser<GetCityHuntingOfferReq> _parser; // 0x00
	public const int CityIdFieldNumber = 1; // Metadata: 0x00B043A7
	private uint cityId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetCityHuntingOfferReq> Parser { get => default; } // 0x0000000181F19810-0x0000000181F198A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181F195A0-0x0000000181F19630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181F192B0-0x0000000181F19330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181F18D20-0x0000000181F18D80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181F19C00-0x0000000181F19CF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181F19A70-0x0000000181F19AD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181F19630-0x0000000181F19720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181F19BB0-0x0000000181F19C00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181F193D0-0x0000000181F194C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CityId { get => default; set {} } // 0x0000000181F18E90-0x0000000181F18F30 0x0000000181F19930-0x0000000181F199D0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23536
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23537
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4303
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetCityHuntingOfferReq() {} // 0x0000000181F19F20-0x0000000181F19F80
	static GetCityHuntingOfferReq() {} // 0x0000000181F19E60-0x0000000181F19F20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetCityHuntingOfferReq Clone() => default; // 0x0000000181F19720-0x0000000181F19810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetCityHuntingOfferReq ShallowCopy() => default; // 0x0000000181F19330-0x0000000181F193D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181F18F30-0x0000000181F18F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181F199D0-0x0000000181F19A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181F19A20-0x0000000181F19A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181F18F80-0x0000000181F18FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181F190F0-0x0000000181F191C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetCityHuntingOfferReq other) => default; // 0x0000000181F18FF0-0x0000000181F190F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181F194C0-0x0000000181F195A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181F19CF0-0x0000000181F19E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181F19AD0-0x0000000181F19BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181F191C0-0x0000000181F192B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetCityHuntingOfferReq other) {} // 0x0000000181F18D80-0x0000000181F18E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181F18C40-0x0000000181F18D20
}

