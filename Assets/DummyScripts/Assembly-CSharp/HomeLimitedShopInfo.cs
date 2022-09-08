/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeLimitedShopInfo : MessageBase, IMessage<HomeLimitedShopInfo> // TypeDefIndex: 23484
{
	// Fields
	private static readonly MessageParser<HomeLimitedShopInfo> _parser; // 0x00
	public const int UidFieldNumber = 1; // Metadata: 0x00B041EF
	private uint uid_; // 0x18
	public const int NextOpenTimeFieldNumber = 3; // Metadata: 0x00B041F3
	private uint nextOpenTime_; // 0x1C
	public const int NextGuestOpenTimeFieldNumber = 4; // Metadata: 0x00B041F7
	private uint nextGuestOpenTime_; // 0x20
	public const int NextCloseTimeFieldNumber = 5; // Metadata: 0x00B041FB
	private uint nextCloseTime_; // 0x24
	public const int DjinnPosFieldNumber = 6; // Metadata: 0x00B041FF
	private Vector djinnPos_; // 0x28
	public const int DjinnRotFieldNumber = 7; // Metadata: 0x00B04203
	private Vector djinnRot_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeLimitedShopInfo> Parser { get => default; } // 0x0000000181F68BE0-0x0000000181F68C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181F686F0-0x0000000181F68780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181F68180-0x0000000181F68200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181F67340-0x0000000181F673A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181F690E0-0x0000000181F691D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181F68E20-0x0000000181F68E80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181F68A00-0x0000000181F68AF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181F69090-0x0000000181F690E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181F682A0-0x0000000181F68390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x0000000181F68040-0x0000000181F680E0 0x0000000181F688C0-0x0000000181F68960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NextOpenTime { get => default; set {} } // 0x0000000181F679F0-0x0000000181F67A90 0x0000000181F68780-0x0000000181F68820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NextGuestOpenTime { get => default; set {} } // 0x0000000181F680E0-0x0000000181F68180 0x0000000181F68650-0x0000000181F686F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NextCloseTime { get => default; set {} } // 0x0000000181F67740-0x0000000181F677E0 0x0000000181F67A90-0x0000000181F67B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector DjinnPos { get => default; set {} } // 0x0000000181F673A0-0x0000000181F67440 0x0000000181F68960-0x0000000181F68A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector DjinnRot { get => default; set {} } // 0x0000000181F672A0-0x0000000181F67340 0x0000000181F68820-0x0000000181F688C0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeLimitedShopInfo() {} // 0x0000000181F69690-0x0000000181F696F0
	static HomeLimitedShopInfo() {} // 0x0000000181F695D0-0x0000000181F69690

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeLimitedShopInfo Clone() => default; // 0x0000000181F68AF0-0x0000000181F68BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeLimitedShopInfo ShallowCopy() => default; // 0x0000000181F68200-0x0000000181F682A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181F676B0-0x0000000181F67740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181F68D00-0x0000000181F68D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181F68D90-0x0000000181F68E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181F677E0-0x0000000181F679F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181F67B30-0x0000000181F67C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeLimitedShopInfo other) => default; // 0x0000000181F67C00-0x0000000181F67DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181F68390-0x0000000181F68650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181F691D0-0x0000000181F695D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181F68E80-0x0000000181F69090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181F67DC0-0x0000000181F68040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeLimitedShopInfo other) {} // 0x0000000181F67440-0x0000000181F676B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181F670B0-0x0000000181F672A0
}

