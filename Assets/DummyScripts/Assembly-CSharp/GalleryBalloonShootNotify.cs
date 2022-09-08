/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GalleryBalloonShootNotify : MessageBase, IMessage<GalleryBalloonShootNotify> // TypeDefIndex: 23241
{
	// Fields
	private static readonly MessageParser<GalleryBalloonShootNotify> _parser; // 0x00
	public const int GalleryIdFieldNumber = 1; // Metadata: 0x00B03907
	private uint galleryId_; // 0x18
	public const int AddScoreFieldNumber = 2; // Metadata: 0x00B0390B
	private int addScore_; // 0x1C
	public const int ComboFieldNumber = 3; // Metadata: 0x00B0390F
	private uint combo_; // 0x20
	public const int ComboDisableTimeFieldNumber = 4; // Metadata: 0x00B03913
	private ulong comboDisableTime_; // 0x28
	public const int CurScoreFieldNumber = 5; // Metadata: 0x00B03917
	private uint curScore_; // 0x30
	public const int TriggerEntityIdFieldNumber = 6; // Metadata: 0x00B0391B
	private uint triggerEntityId_; // 0x34

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GalleryBalloonShootNotify> Parser { get => default; } // 0x000000018513FA60-0x000000018513FAF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018513F750-0x000000018513F7E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018513F240-0x000000018513F2C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018513E860-0x000000018513E8C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185140170-0x0000000185140260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018513FD60-0x000000018513FDC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018513F7E0-0x000000018513F8D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185140080-0x00000001851400D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018513F400-0x000000018513F4F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GalleryId { get => default; set {} } // 0x000000018513E8C0-0x000000018513E960 0x000000018513E960-0x000000018513EA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int AddScore { get => default; set {} } // 0x000000018513FCC0-0x000000018513FD60 0x000000018513ECD0-0x000000018513ED70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Combo { get => default; set {} } // 0x000000018513FFE0-0x0000000185140080 0x000000018513E7C0-0x000000018513E860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong ComboDisableTime { get => default; set {} } // 0x000000018513F6B0-0x000000018513F750 0x000000018513F9C0-0x000000018513FA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurScore { get => default; set {} } // 0x00000001851400D0-0x0000000185140170 0x000000018513F360-0x000000018513F400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TriggerEntityId { get => default; set {} } // 0x0000000185140260-0x0000000185140300 0x000000018513FC20-0x000000018513FCC0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23242
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23243
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5502
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GalleryBalloonShootNotify() {} // 0x00000001851407F0-0x0000000185140850
	static GalleryBalloonShootNotify() {} // 0x0000000185140730-0x00000001851407F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GalleryBalloonShootNotify Clone() => default; // 0x000000018513F8D0-0x000000018513F9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GalleryBalloonShootNotify ShallowCopy() => default; // 0x000000018513F2C0-0x000000018513F360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018513EBD0-0x000000018513EC20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018513FB80-0x000000018513FBD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018513FBD0-0x000000018513FC20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018513EC20-0x000000018513ECD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018513EF10-0x000000018513EFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GalleryBalloonShootNotify other) => default; // 0x000000018513ED70-0x000000018513EF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018513F4F0-0x000000018513F6B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185140300-0x0000000185140730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018513FDC0-0x000000018513FFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018513EFE0-0x000000018513F240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GalleryBalloonShootNotify other) {} // 0x000000018513EA00-0x000000018513EBD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018513E650-0x000000018513E7C0
}

