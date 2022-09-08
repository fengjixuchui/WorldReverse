/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DraftGuestReplyTwiceConfirmNotify : MessageBase, IMessage<DraftGuestReplyTwiceConfirmNotify> // TypeDefIndex: 22797
{
	// Fields
	private static readonly MessageParser<DraftGuestReplyTwiceConfirmNotify> _parser; // 0x00
	public const int DraftIdFieldNumber = 1; // Metadata: 0x00B02637
	private uint draftId_; // 0x18
	public const int GuestUidFieldNumber = 2; // Metadata: 0x00B0263B
	private uint guestUid_; // 0x1C
	public const int IsAgreeFieldNumber = 3; // Metadata: 0x00B0263F
	private bool isAgree_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DraftGuestReplyTwiceConfirmNotify> Parser { get => default; } // 0x0000000181962DD0-0x0000000181962E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181962AC0-0x0000000181962B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001819626E0-0x0000000181962760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181962050-0x00000001819620B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181963380-0x0000000181963470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001819630D0-0x0000000181963130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181962B50-0x0000000181962C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181963330-0x0000000181963380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181962800-0x00000001819628F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DraftId { get => default; set {} } // 0x00000001819622E0-0x0000000181962380 0x0000000181962FE0-0x0000000181963080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GuestUid { get => default; set {} } // 0x0000000181962A20-0x0000000181962AC0 0x0000000181963290-0x0000000181963330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAgree { get => default; set {} } // 0x0000000181962D30-0x0000000181962DD0 0x0000000181962E60-0x0000000181962F00

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22798
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22799
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5414
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftGuestReplyTwiceConfirmNotify() {} // 0x00000001819637C0-0x0000000181963820
	static DraftGuestReplyTwiceConfirmNotify() {} // 0x0000000181963700-0x00000001819637C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftGuestReplyTwiceConfirmNotify Clone() => default; // 0x0000000181962C40-0x0000000181962D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftGuestReplyTwiceConfirmNotify ShallowCopy() => default; // 0x0000000181962760-0x0000000181962800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181962210-0x0000000181962260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181962F90-0x0000000181962FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181963080-0x00000001819630D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181962260-0x00000001819622E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181962380-0x0000000181962450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DraftGuestReplyTwiceConfirmNotify other) => default; // 0x0000000181962450-0x0000000181962590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001819628F0-0x0000000181962A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181963470-0x0000000181963700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181963130-0x0000000181963290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181962590-0x00000001819626E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DraftGuestReplyTwiceConfirmNotify other) {} // 0x00000001819620B0-0x0000000181962210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181961F40-0x0000000181962050
}

