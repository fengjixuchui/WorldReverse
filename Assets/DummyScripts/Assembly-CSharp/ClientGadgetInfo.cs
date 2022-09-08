/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ClientGadgetInfo : MessageBase, IMessage<ClientGadgetInfo> // TypeDefIndex: 26026
{
	// Fields
	private static readonly MessageParser<ClientGadgetInfo> _parser; // 0x00
	public const int CampIdFieldNumber = 1; // Metadata: 0x00B0AC27
	private uint campId_; // 0x18
	public const int CampTypeFieldNumber = 2; // Metadata: 0x00B0AC2B
	private uint campType_; // 0x1C
	public const int GuidFieldNumber = 3; // Metadata: 0x00B0AC2F
	private ulong guid_; // 0x20
	public const int OwnerEntityIdFieldNumber = 4; // Metadata: 0x00B0AC33
	private uint ownerEntityId_; // 0x28
	public const int TargetEntityIdFieldNumber = 5; // Metadata: 0x00B0AC37
	private uint targetEntityId_; // 0x2C
	public const int AsyncLoadFieldNumber = 6; // Metadata: 0x00B0AC3B
	private bool asyncLoad_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ClientGadgetInfo> Parser { get => default; } // 0x000000018589F4B0-0x000000018589F540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018589EF20-0x000000018589EFB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018589EB50-0x000000018589EBD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018589E100-0x000000018589E160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018589FB20-0x000000018589FC10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018589F710-0x000000018589F770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018589F230-0x000000018589F320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018589FA30-0x000000018589FA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018589EC70-0x000000018589ED60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CampId { get => default; set {} } // 0x000000018589E610-0x000000018589E6B0 0x000000018589F410-0x000000018589F4B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CampType { get => default; set {} } // 0x000000018589EFB0-0x000000018589F050 0x000000018589F050-0x000000018589F0F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong Guid { get => default; set {} } // 0x000000018589E3D0-0x000000018589E470 0x000000018589E570-0x000000018589E610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OwnerEntityId { get => default; set {} } // 0x000000018589E160-0x000000018589E200 0x000000018589F0F0-0x000000018589F190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetEntityId { get => default; set {} } // 0x000000018589FA80-0x000000018589FB20 0x000000018589F670-0x000000018589F710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool AsyncLoad { get => default; set {} } // 0x000000018589F990-0x000000018589FA30 0x000000018589F190-0x000000018589F230

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientGadgetInfo() {} // 0x00000001858A0100-0x00000001858A0160
	static ClientGadgetInfo() {} // 0x00000001858A0040-0x00000001858A0100

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientGadgetInfo Clone() => default; // 0x000000018589F320-0x000000018589F410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientGadgetInfo ShallowCopy() => default; // 0x000000018589EBD0-0x000000018589EC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018589E470-0x000000018589E4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018589F5D0-0x000000018589F620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018589F620-0x000000018589F670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018589E4C0-0x000000018589E570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018589E850-0x000000018589E920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ClientGadgetInfo other) => default; // 0x000000018589E6B0-0x000000018589E850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018589ED60-0x000000018589EF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018589FC10-0x00000001858A0040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018589F770-0x000000018589F990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018589E920-0x000000018589EB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ClientGadgetInfo other) {} // 0x000000018589E200-0x000000018589E3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018589DF90-0x000000018589E100
}

