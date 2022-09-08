/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarExpeditionInfo : MessageBase, IMessage<AvatarExpeditionInfo> // TypeDefIndex: 26068
{
	// Fields
	private static readonly MessageParser<AvatarExpeditionInfo> _parser; // 0x00
	public const int StateFieldNumber = 1; // Metadata: 0x00B0AF63
	private AvatarExpeditionState state_; // 0x18
	public const int ExpIdFieldNumber = 2; // Metadata: 0x00B0AF67
	private uint expId_; // 0x1C
	public const int HourTimeFieldNumber = 3; // Metadata: 0x00B0AF6B
	private uint hourTime_; // 0x20
	public const int StartTimeFieldNumber = 4; // Metadata: 0x00B0AF6F
	private uint startTime_; // 0x24
	public const int ShortenRatioFieldNumber = 5; // Metadata: 0x00B0AF73
	private float shortenRatio_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarExpeditionInfo> Parser { get => default; } // 0x0000000183368CA0-0x0000000183368D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183368850-0x00000001833688E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183368440-0x00000001833684C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001833679F0-0x0000000183367A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183369190-0x0000000183369280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183368F00-0x0000000183368F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183368AC0-0x0000000183368BB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183369140-0x0000000183369190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183368560-0x0000000183368650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarExpeditionState State { get => default; set {} } // 0x0000000183368300-0x00000001833683A0 0x00000001833683A0-0x0000000183368440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ExpId { get => default; set {} } // 0x0000000183367E30-0x0000000183367ED0 0x0000000183367AF0-0x0000000183367B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint HourTime { get => default; set {} } // 0x0000000183368980-0x0000000183368A20 0x0000000183367A50-0x0000000183367AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StartTime { get => default; set {} } // 0x0000000183369280-0x0000000183369320 0x0000000183368A20-0x0000000183368AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float ShortenRatio { get => default; set {} } // 0x00000001833688E0-0x0000000183368980 0x0000000183368DC0-0x0000000183368E60

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarExpeditionInfo() {} // 0x0000000183369790-0x0000000183369800
	static AvatarExpeditionInfo() {} // 0x00000001833696D0-0x0000000183369790

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarExpeditionInfo Clone() => default; // 0x0000000183368BB0-0x0000000183368CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarExpeditionInfo ShallowCopy() => default; // 0x00000001833684C0-0x0000000183368560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183367D40-0x0000000183367D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183368E60-0x0000000183368EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183368EB0-0x0000000183368F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183367D90-0x0000000183367E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183367ED0-0x0000000183367FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarExpeditionInfo other) => default; // 0x0000000183367FA0-0x0000000183368120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183368650-0x0000000183368850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183369320-0x00000001833696D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183368F60-0x0000000183369140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183368120-0x0000000183368300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarExpeditionInfo other) {} // 0x0000000183367B90-0x0000000183367D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001833678A0-0x00000001833679F0
}

