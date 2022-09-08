/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GalleryFallCatchNotify : MessageBase, IMessage<GalleryFallCatchNotify> // TypeDefIndex: 23252
{
	// Fields
	private static readonly MessageParser<GalleryFallCatchNotify> _parser; // 0x00
	public const int GalleryIdFieldNumber = 1; // Metadata: 0x00B03987
	private uint galleryId_; // 0x18
	public const int AddScoreFieldNumber = 2; // Metadata: 0x00B0398B
	private uint addScore_; // 0x1C
	public const int CurScoreFieldNumber = 3; // Metadata: 0x00B0398F
	private uint curScore_; // 0x20
	public const int BallCatchCountMapFieldNumber = 4; // Metadata: 0x00B03993
	private static readonly MapField<uint, uint> _map_ballCatchCountMap_codec; // 0x08
	private readonly MapField<uint, uint> ballCatchCountMap_; // 0x28
	public const int IsGroundFieldNumber = 5; // Metadata: 0x00B03997
	private bool isGround_; // 0x30
	public const int TimeCostFieldNumber = 6; // Metadata: 0x00B0399B
	private uint timeCost_; // 0x34

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GalleryFallCatchNotify> Parser { get => default; } // 0x0000000185516E90-0x0000000185516F20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185516A40-0x0000000185516AD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000185516590-0x0000000185516610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000185515B10-0x0000000185515B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185517520-0x0000000185517610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185517190-0x00000001855171F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185516C10-0x0000000185516D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185517430-0x0000000185517480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185516750-0x0000000185516840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GalleryId { get => default; set {} } // 0x0000000185515B70-0x0000000185515C10 0x0000000185515C10-0x0000000185515CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AddScore { get => default; set {} } // 0x00000001855170F0-0x0000000185517190 0x0000000185516030-0x00000001855160D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurScore { get => default; set {} } // 0x0000000185517480-0x0000000185517520 0x00000001855166B0-0x0000000185516750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> BallCatchCountMap { get => default; } // 0x0000000185515FD0-0x0000000185516030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsGround { get => default; set {} } // 0x0000000185516B70-0x0000000185516C10 0x0000000185516DF0-0x0000000185516E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TimeCost { get => default; set {} } // 0x0000000185517050-0x00000001855170F0 0x0000000185516AD0-0x0000000185516B70

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23253
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23254
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5505
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GalleryFallCatchNotify() {} // 0x0000000185517B50-0x0000000185517BE0
	static GalleryFallCatchNotify() {} // 0x0000000185517A20-0x0000000185517B50

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GalleryFallCatchNotify Clone() => default; // 0x0000000185516D00-0x0000000185516DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GalleryFallCatchNotify ShallowCopy() => default; // 0x0000000185516610-0x00000001855166B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185515E80-0x0000000185515ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185516FB0-0x0000000185517000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185517000-0x0000000185517050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185515ED0-0x0000000185515FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001855160D0-0x00000001855161A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GalleryFallCatchNotify other) => default; // 0x00000001855161A0-0x0000000185516360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000185516840-0x0000000185516A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185517610-0x0000000185517A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001855171F0-0x0000000185517430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185516360-0x0000000185516590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GalleryFallCatchNotify other) {} // 0x0000000185515CB0-0x0000000185515E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185515930-0x0000000185515B10
}

