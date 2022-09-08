/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtCreateGadgetNotify : MessageBase, IMessage<EvtCreateGadgetNotify> // TypeDefIndex: 23006
{
	// Fields
	private static readonly MessageParser<EvtCreateGadgetNotify> _parser; // 0x00
	public const int ForwardTypeFieldNumber = 1; // Metadata: 0x00B02EAF
	private ForwardType forwardType_; // 0x18
	public const int EntityIdFieldNumber = 2; // Metadata: 0x00B02EB3
	private uint entityId_; // 0x1C
	public const int ConfigIdFieldNumber = 3; // Metadata: 0x00B02EB7
	private uint configId_; // 0x20
	public const int CampIdFieldNumber = 4; // Metadata: 0x00B02EBB
	private uint campId_; // 0x24
	public const int CampTypeFieldNumber = 5; // Metadata: 0x00B02EBF
	private uint campType_; // 0x28
	public const int InitPosFieldNumber = 6; // Metadata: 0x00B02EC3
	private Vector initPos_; // 0x30
	public const int InitEulerAnglesFieldNumber = 7; // Metadata: 0x00B02EC7
	private Vector initEulerAngles_; // 0x38
	public const int GuidFieldNumber = 8; // Metadata: 0x00B02ECB
	private ulong guid_; // 0x40
	public const int OwnerEntityIdFieldNumber = 9; // Metadata: 0x00B02ECF
	private uint ownerEntityId_; // 0x48
	public const int TargetEntityIdFieldNumber = 10; // Metadata: 0x00B02ED3
	private uint targetEntityId_; // 0x4C
	public const int IsAsyncLoadFieldNumber = 11; // Metadata: 0x00B02ED7
	private bool isAsyncLoad_; // 0x50
	public const int TargetLockPointIndexFieldNumber = 12; // Metadata: 0x00B02EDB
	private uint targetLockPointIndex_; // 0x54
	public const int RoomIdFieldNumber = 13; // Metadata: 0x00B02EDF
	private uint roomId_; // 0x58
	public const int PropOwnerEntityIdFieldNumber = 14; // Metadata: 0x00B02EE3
	private uint propOwnerEntityId_; // 0x5C
	public const int SightGroupWithOwnerFieldNumber = 15; // Metadata: 0x00B02EE7
	private bool sightGroupWithOwner_; // 0x60

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtCreateGadgetNotify> Parser { get => default; } // 0x000000018540F930-0x000000018540F9C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018540F120-0x000000018540F1B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018540EA00-0x000000018540EA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018540D260-0x000000018540D2C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185410430-0x0000000185410520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018540FDF0-0x000000018540FE50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018540F610-0x000000018540F700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185410340-0x0000000185410390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018540EBC0-0x000000018540ECB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForwardType ForwardType { get => default; set {} } // 0x000000018540E960-0x000000018540EA00 0x000000018540DA30-0x000000018540DAD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x000000018540FD50-0x000000018540FDF0 0x00000001854105C0-0x0000000185410660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ConfigId { get => default; set {} } // 0x000000018540F4D0-0x000000018540F570 0x000000018540D360-0x000000018540D400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CampId { get => default; set {} } // 0x000000018540DE00-0x000000018540DEA0 0x000000018540F890-0x000000018540F930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CampType { get => default; set {} } // 0x000000018540F250-0x000000018540F2F0 0x000000018540F2F0-0x000000018540F390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector InitPos { get => default; set {} } // 0x000000018540F430-0x000000018540F4D0 0x0000000185410520-0x00000001854105C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector InitEulerAngles { get => default; set {} } // 0x000000018540EA80-0x000000018540EB20 0x000000018540E780-0x000000018540E820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong Guid { get => default; set {} } // 0x000000018540D900-0x000000018540D9A0 0x000000018540DD60-0x000000018540DE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OwnerEntityId { get => default; set {} } // 0x000000018540D4A0-0x000000018540D540 0x000000018540F390-0x000000018540F430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetEntityId { get => default; set {} } // 0x0000000185410390-0x0000000185410430 0x000000018540FCB0-0x000000018540FD50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAsyncLoad { get => default; set {} } // 0x000000018540FB70-0x000000018540FC10 0x000000018540E820-0x000000018540E8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetLockPointIndex { get => default; set {} } // 0x000000018540F1B0-0x000000018540F250 0x000000018540D400-0x000000018540D4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RoomId { get => default; set {} } // 0x000000018540D2C0-0x000000018540D360 0x000000018540F570-0x000000018540F610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PropOwnerEntityId { get => default; set {} } // 0x000000018540FC10-0x000000018540FCB0 0x000000018540E8C0-0x000000018540E960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool SightGroupWithOwner { get => default; set {} } // 0x000000018540F7F0-0x000000018540F890 0x000000018540FE50-0x000000018540FEF0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23007
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23008
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 305
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtCreateGadgetNotify() {} // 0x0000000185410FF0-0x0000000185411060
	static EvtCreateGadgetNotify() {} // 0x0000000185410F30-0x0000000185410FF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtCreateGadgetNotify Clone() => default; // 0x000000018540F700-0x000000018540F7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtCreateGadgetNotify ShallowCopy() => default; // 0x000000018540EB20-0x000000018540EBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018540D9A0-0x000000018540DA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018540FA50-0x000000018540FAE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018540FAE0-0x000000018540FB70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018540DAD0-0x000000018540DD60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018540E170-0x000000018540E240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtCreateGadgetNotify other) => default; // 0x000000018540DEA0-0x000000018540E170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018540ECB0-0x000000018540F120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185410660-0x0000000185410F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018540FEF0-0x0000000185410340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018540E240-0x000000018540E780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtCreateGadgetNotify other) {} // 0x000000018540D540-0x000000018540D900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018540CF80-0x000000018540D260
}

