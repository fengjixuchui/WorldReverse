/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeBasicInfo : MessageBase, IMessage<HomeBasicInfo> // TypeDefIndex: 23318
{
	// Fields
	private static readonly MessageParser<HomeBasicInfo> _parser; // 0x00
	public const int CurModuleIdFieldNumber = 1; // Metadata: 0x00B03C03
	private uint curModuleId_; // 0x18
	public const int CurRoomSceneIdFieldNumber = 2; // Metadata: 0x00B03C07
	private uint curRoomSceneId_; // 0x1C
	public const int IsInEditModeFieldNumber = 3; // Metadata: 0x00B03C0B
	private bool isInEditMode_; // 0x20
	public const int ExpFieldNumber = 4; // Metadata: 0x00B03C0F
	private ulong exp_; // 0x28
	public const int LevelFieldNumber = 5; // Metadata: 0x00B03C13
	private uint level_; // 0x30
	public const int HomeOwnerUidFieldNumber = 6; // Metadata: 0x00B03C17
	private uint homeOwnerUid_; // 0x34
	public const int LimitedShopInfoFieldNumber = 7; // Metadata: 0x00B03C1B
	private HomeLimitedShopInfo limitedShopInfo_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeBasicInfo> Parser { get => default; } // 0x00000001827F0080-0x00000001827F0110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001827EFD70-0x00000001827EFE00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001827EF7D0-0x00000001827EF850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001827EE970-0x00000001827EE9D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001827F0790-0x00000001827F0880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001827F03E0-0x00000001827F0440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001827EFEA0-0x00000001827EFF90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001827F0740-0x00000001827F0790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001827EFA30-0x00000001827EFB20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurModuleId { get => default; set {} } // 0x00000001827EEA70-0x00000001827EEB10 0x00000001827EF850-0x00000001827EF8F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurRoomSceneId { get => default; set {} } // 0x00000001827EE6F0-0x00000001827EE790 0x00000001827EFE00-0x00000001827EFEA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsInEditMode { get => default; set {} } // 0x00000001827F0340-0x00000001827F03E0 0x00000001827EEDF0-0x00000001827EEE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong Exp { get => default; set {} } // 0x00000001827EF080-0x00000001827EF120 0x00000001827F01A0-0x00000001827F0240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Level { get => default; set {} } // 0x00000001827EED50-0x00000001827EEDF0 0x00000001827EF990-0x00000001827EFA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint HomeOwnerUid { get => default; set {} } // 0x00000001827EE9D0-0x00000001827EEA70 0x00000001827F06A0-0x00000001827F0740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeLimitedShopInfo LimitedShopInfo { get => default; set {} } // 0x00000001827EF120-0x00000001827EF1C0 0x00000001827EF730-0x00000001827EF7D0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeBasicInfo() {} // 0x00000001827F0DE0-0x00000001827F0E40
	static HomeBasicInfo() {} // 0x00000001827F0D20-0x00000001827F0DE0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeBasicInfo Clone() => default; // 0x00000001827EFF90-0x00000001827F0080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeBasicInfo ShallowCopy() => default; // 0x00000001827EF8F0-0x00000001827EF990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001827EEE90-0x00000001827EEF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001827F0240-0x00000001827F02C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001827F02C0-0x00000001827F0340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001827EEF10-0x00000001827EF080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001827EF1C0-0x00000001827EF290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeBasicInfo other) => default; // 0x00000001827EF290-0x00000001827EF460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001827EFB20-0x00000001827EFD70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001827F0880-0x00000001827F0D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001827F0440-0x00000001827F06A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001827EF460-0x00000001827EF730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeBasicInfo other) {} // 0x00000001827EEB10-0x00000001827EED50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001827EE790-0x00000001827EE970
}

