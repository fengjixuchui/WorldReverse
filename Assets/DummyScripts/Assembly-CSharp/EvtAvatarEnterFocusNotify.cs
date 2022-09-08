/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtAvatarEnterFocusNotify : MessageBase, IMessage<EvtAvatarEnterFocusNotify> // TypeDefIndex: 23054
{
	// Fields
	private static readonly MessageParser<EvtAvatarEnterFocusNotify> _parser; // 0x00
	public const int ForwardTypeFieldNumber = 1; // Metadata: 0x00B03133
	private ForwardType forwardType_; // 0x18
	public const int EntityIdFieldNumber = 2; // Metadata: 0x00B03137
	private uint entityId_; // 0x1C
	public const int FastFocusFieldNumber = 3; // Metadata: 0x00B0313B
	private bool fastFocus_; // 0x20
	public const int UseFocusStickyFieldNumber = 4; // Metadata: 0x00B0313F
	private bool useFocusSticky_; // 0x21
	public const int UseAutoFocusFieldNumber = 5; // Metadata: 0x00B03143
	private bool useAutoFocus_; // 0x22
	public const int UseGyroFieldNumber = 6; // Metadata: 0x00B03147
	private bool useGyro_; // 0x23
	public const int CanMoveFieldNumber = 7; // Metadata: 0x00B0314B
	private bool canMove_; // 0x24
	public const int ShowCrossHairFieldNumber = 8; // Metadata: 0x00B0314F
	private bool showCrossHair_; // 0x25
	public const int FocusForwardFieldNumber = 9; // Metadata: 0x00B03153
	private Vector focusForward_; // 0x28
	public const int EnterNormalFocusShootFieldNumber = 10; // Metadata: 0x00B03157
	private bool enterNormalFocusShoot_; // 0x30
	public const int EnterHoldingFocusShootFieldNumber = 11; // Metadata: 0x00B0315B
	private bool enterHoldingFocusShoot_; // 0x31
	public const int DisableAnimFieldNumber = 12; // Metadata: 0x00B0315F
	private bool disableAnim_; // 0x32

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtAvatarEnterFocusNotify> Parser { get => default; } // 0x0000000182F7F690-0x0000000182F7F720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182F7F380-0x0000000182F7F410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182F7ECD0-0x0000000182F7ED50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182F7DBD0-0x0000000182F7DC30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182F802A0-0x0000000182F80390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182F7FC70-0x0000000182F7FCD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182F7F410-0x0000000182F7F500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182F801B0-0x0000000182F80200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182F7EDF0-0x0000000182F7EEE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForwardType ForwardType { get => default; set {} } // 0x0000000182F7EC30-0x0000000182F7ECD0 0x0000000182F7E240-0x0000000182F7E2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000182F7FB30-0x0000000182F7FBD0 0x0000000182F80430-0x0000000182F804D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool FastFocus { get => default; set {} } // 0x0000000182F7DB30-0x0000000182F7DBD0 0x0000000182F7F720-0x0000000182F7F7C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool UseFocusSticky { get => default; set {} } // 0x0000000182F7EAF0-0x0000000182F7EB90 0x0000000182F7DD70-0x0000000182F7DE10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool UseAutoFocus { get => default; set {} } // 0x0000000182F7FCD0-0x0000000182F7FD70 0x0000000182F7F2E0-0x0000000182F7F380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool UseGyro { get => default; set {} } // 0x0000000182F7FA90-0x0000000182F7FB30 0x0000000182F80390-0x0000000182F80430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool CanMove { get => default; set {} } // 0x0000000182F7EB90-0x0000000182F7EC30 0x0000000182F80200-0x0000000182F802A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool ShowCrossHair { get => default; set {} } // 0x0000000182F7DE10-0x0000000182F7DEB0 0x0000000182F7F500-0x0000000182F7F5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector FocusForward { get => default; set {} } // 0x0000000182F7DC30-0x0000000182F7DCD0 0x0000000182F80110-0x0000000182F801B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool EnterNormalFocusShoot { get => default; set {} } // 0x0000000182F7FBD0-0x0000000182F7FC70 0x0000000182F7DCD0-0x0000000182F7DD70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool EnterHoldingFocusShoot { get => default; set {} } // 0x0000000182F7F240-0x0000000182F7F2E0 0x0000000182F7F850-0x0000000182F7F8F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool DisableAnim { get => default; set {} } // 0x0000000182F7F970-0x0000000182F7FA10 0x0000000182F7EA50-0x0000000182F7EAF0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23055
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23056
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 323
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtAvatarEnterFocusNotify() {} // 0x0000000182F80CE0-0x0000000182F80D50
	static EvtAvatarEnterFocusNotify() {} // 0x0000000182F80C20-0x0000000182F80CE0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtAvatarEnterFocusNotify Clone() => default; // 0x0000000182F7F5A0-0x0000000182F7F690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtAvatarEnterFocusNotify ShallowCopy() => default; // 0x0000000182F7ED50-0x0000000182F7EDF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182F7E1C0-0x0000000182F7E240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182F7F8F0-0x0000000182F7F970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182F7FA10-0x0000000182F7FA90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182F7E2E0-0x0000000182F7E490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182F7E490-0x0000000182F7E560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtAvatarEnterFocusNotify other) => default; // 0x0000000182F7E560-0x0000000182F7E7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182F7EEE0-0x0000000182F7F240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182F804D0-0x0000000182F80C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182F7FD70-0x0000000182F80110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182F7E7D0-0x0000000182F7EA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtAvatarEnterFocusNotify other) {} // 0x0000000182F7DEB0-0x0000000182F7E1C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182F7D8C0-0x0000000182F7DB30
}

