/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FleurFairMusicGameSettleReq : MessageBase, IMessage<FleurFairMusicGameSettleReq> // TypeDefIndex: 22222
{
	// Fields
	private static readonly MessageParser<FleurFairMusicGameSettleReq> _parser; // 0x00
	public const int MusicBasicIdFieldNumber = 1; // Metadata: 0x00B01147
	private uint musicBasicId_; // 0x18
	public const int ScoreFieldNumber = 2; // Metadata: 0x00B0114B
	private uint score_; // 0x1C
	public const int ComboFieldNumber = 3; // Metadata: 0x00B0114F
	private uint combo_; // 0x20
	public const int CorrectHitFieldNumber = 4; // Metadata: 0x00B01153
	private uint correctHit_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FleurFairMusicGameSettleReq> Parser { get => default; } // 0x00000001835D3860-0x00000001835D38F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001835D34B0-0x00000001835D3540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001835D3140-0x00000001835D31C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001835D28B0-0x00000001835D2910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001835D3DB0-0x00000001835D3EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001835D3AC0-0x00000001835D3B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001835D3680-0x00000001835D3770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001835D3D60-0x00000001835D3DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001835D3260-0x00000001835D3350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MusicBasicId { get => default; set {} } // 0x00000001835D29B0-0x00000001835D2A50 0x00000001835D2BD0-0x00000001835D2C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Score { get => default; set {} } // 0x00000001835D35E0-0x00000001835D3680 0x00000001835D2910-0x00000001835D29B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Combo { get => default; set {} } // 0x00000001835D3CC0-0x00000001835D3D60 0x00000001835D2810-0x00000001835D28B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CorrectHit { get => default; set {} } // 0x00000001835D3540-0x00000001835D35E0 0x00000001835D3980-0x00000001835D3A20

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22223
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22224
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2183
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairMusicGameSettleReq() {} // 0x00000001835D4280-0x00000001835D42E0
	static FleurFairMusicGameSettleReq() {} // 0x00000001835D41C0-0x00000001835D4280

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairMusicGameSettleReq Clone() => default; // 0x00000001835D3770-0x00000001835D3860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairMusicGameSettleReq ShallowCopy() => default; // 0x00000001835D31C0-0x00000001835D3260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001835D2C70-0x00000001835D2CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001835D3A20-0x00000001835D3A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001835D3A70-0x00000001835D3AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001835D2CC0-0x00000001835D2D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001835D2D50-0x00000001835D2E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FleurFairMusicGameSettleReq other) => default; // 0x00000001835D2E20-0x00000001835D2F70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001835D3350-0x00000001835D34B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001835D3EA0-0x00000001835D41C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001835D3B20-0x00000001835D3CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001835D2F70-0x00000001835D3140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FleurFairMusicGameSettleReq other) {} // 0x00000001835D2A50-0x00000001835D2BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001835D26E0-0x00000001835D2810
}

