/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BalloonPlayerInfo : MessageBase, IMessage<BalloonPlayerInfo> // TypeDefIndex: 23259
{
	// Fields
	private static readonly MessageParser<BalloonPlayerInfo> _parser; // 0x00
	public const int UidFieldNumber = 1; // Metadata: 0x00B039D3
	private uint uid_; // 0x18
	public const int ComboFieldNumber = 3; // Metadata: 0x00B039D7
	private uint combo_; // 0x1C
	public const int ComboDisableTimeFieldNumber = 4; // Metadata: 0x00B039DB
	private uint comboDisableTime_; // 0x20
	public const int CurScoreFieldNumber = 5; // Metadata: 0x00B039DF
	private uint curScore_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BalloonPlayerInfo> Parser { get => default; } // 0x00000001835F3100-0x00000001835F3190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001835F2D50-0x00000001835F2DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001835F28A0-0x00000001835F2920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001835F2150-0x00000001835F21B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001835F3650-0x00000001835F3740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001835F32C0-0x00000001835F3320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001835F2E80-0x00000001835F2F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001835F3560-0x00000001835F35B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001835F2A60-0x00000001835F2B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x00000001835F2800-0x00000001835F28A0 0x00000001835F2DE0-0x00000001835F2E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Combo { get => default; set {} } // 0x00000001835F34C0-0x00000001835F3560 0x00000001835F20B0-0x00000001835F2150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ComboDisableTime { get => default; set {} } // 0x00000001835F2CB0-0x00000001835F2D50 0x00000001835F3060-0x00000001835F3100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurScore { get => default; set {} } // 0x00000001835F35B0-0x00000001835F3650 0x00000001835F29C0-0x00000001835F2A60

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BalloonPlayerInfo() {} // 0x00000001835F3B20-0x00000001835F3B80
	static BalloonPlayerInfo() {} // 0x00000001835F3A60-0x00000001835F3B20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BalloonPlayerInfo Clone() => default; // 0x00000001835F2F70-0x00000001835F3060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BalloonPlayerInfo ShallowCopy() => default; // 0x00000001835F2920-0x00000001835F29C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001835F2330-0x00000001835F2380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001835F3220-0x00000001835F3270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001835F3270-0x00000001835F32C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001835F2380-0x00000001835F2410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001835F2410-0x00000001835F24E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BalloonPlayerInfo other) => default; // 0x00000001835F24E0-0x00000001835F2630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001835F2B50-0x00000001835F2CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001835F3740-0x00000001835F3A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001835F3320-0x00000001835F34C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001835F2630-0x00000001835F2800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BalloonPlayerInfo other) {} // 0x00000001835F21B0-0x00000001835F2330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001835F1F80-0x00000001835F20B0
}

