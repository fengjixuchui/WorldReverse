/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HuntingOfferData : MessageBase, IMessage<HuntingOfferData> // TypeDefIndex: 23534
{
	// Fields
	private static readonly MessageParser<HuntingOfferData> _parser; // 0x00
	public const int HuntingPairFieldNumber = 1; // Metadata: 0x00B0439B
	private HuntingPair huntingPair_; // 0x18
	public const int CityIdFieldNumber = 2; // Metadata: 0x00B0439F
	private uint cityId_; // 0x20
	public const int StateFieldNumber = 3; // Metadata: 0x00B043A3
	private HuntingOfferState state_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HuntingOfferData> Parser { get => default; } // 0x0000000183B0FB70-0x0000000183B0FC00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183B0F900-0x0000000183B0F990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183B0F510-0x0000000183B0F590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183B0EAC0-0x0000000183B0EB20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183B10040-0x0000000183B10130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183B0FE30-0x0000000183B0FE90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183B0F990-0x0000000183B0FA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183B0FFF0-0x0000000183B10040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183B0F630-0x0000000183B0F720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingPair HuntingPair { get => default; set {} } // 0x0000000183B0ED70-0x0000000183B0EE10 0x0000000183B0E8D0-0x0000000183B0E970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CityId { get => default; set {} } // 0x0000000183B0ECD0-0x0000000183B0ED70 0x0000000183B0FC90-0x0000000183B0FD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingOfferState State { get => default; set {} } // 0x0000000183B0F3D0-0x0000000183B0F470 0x0000000183B0F470-0x0000000183B0F510

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingOfferData() {} // 0x0000000183B10460-0x0000000183B104D0
	static HuntingOfferData() {} // 0x0000000183B103A0-0x0000000183B10460

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingOfferData Clone() => default; // 0x0000000183B0FA80-0x0000000183B0FB70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingOfferData ShallowCopy() => default; // 0x0000000183B0F590-0x0000000183B0F630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183B0EE10-0x0000000183B0EE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183B0FD30-0x0000000183B0FDB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183B0FDB0-0x0000000183B0FE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183B0EE90-0x0000000183B0EFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183B0EFD0-0x0000000183B0F0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HuntingOfferData other) => default; // 0x0000000183B0F0A0-0x0000000183B0F1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183B0F720-0x0000000183B0F900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183B10130-0x0000000183B103A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183B0FE90-0x0000000183B0FFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183B0F1F0-0x0000000183B0F3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HuntingOfferData other) {} // 0x0000000183B0EB20-0x0000000183B0ECD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183B0E970-0x0000000183B0EAC0
}

