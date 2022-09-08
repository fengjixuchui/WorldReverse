/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GalleryBulletHitNotify : MessageBase, IMessage<GalleryBulletHitNotify> // TypeDefIndex: 23281
{
	// Fields
	private static readonly MessageParser<GalleryBulletHitNotify> _parser; // 0x00
	public const int GalleryIdFieldNumber = 1; // Metadata: 0x00B03ACF
	private uint galleryId_; // 0x18
	public const int HitCountFieldNumber = 2; // Metadata: 0x00B03AD3
	private uint hitCount_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GalleryBulletHitNotify> Parser { get => default; } // 0x0000000182814670-0x0000000182814700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182814400-0x0000000182814490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182814050-0x00000001828140D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001828139A0-0x0000000182813A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182814A00-0x0000000182814AF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182814830-0x0000000182814890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182814490-0x0000000182814580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001828149B0-0x0000000182814A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182814210-0x0000000182814300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GalleryId { get => default; set {} } // 0x0000000182813A00-0x0000000182813AA0 0x0000000182813AA0-0x0000000182813B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint HitCount { get => default; set {} } // 0x0000000182814170-0x0000000182814210 0x0000000182813900-0x00000001828139A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23282
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23283
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5511
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GalleryBulletHitNotify() {} // 0x0000000182814DB0-0x0000000182814E10
	static GalleryBulletHitNotify() {} // 0x0000000182814CF0-0x0000000182814DB0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GalleryBulletHitNotify Clone() => default; // 0x0000000182814580-0x0000000182814670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GalleryBulletHitNotify ShallowCopy() => default; // 0x00000001828140D0-0x0000000182814170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182813C70-0x0000000182813CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182814790-0x00000001828147E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001828147E0-0x0000000182814830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182813CC0-0x0000000182813D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182813E50-0x0000000182813F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GalleryBulletHitNotify other) => default; // 0x0000000182813D30-0x0000000182813E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182814300-0x0000000182814400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182814AF0-0x0000000182814CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182814890-0x00000001828149B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182813F20-0x0000000182814050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GalleryBulletHitNotify other) {} // 0x0000000182813B40-0x0000000182813C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182813800-0x0000000182813900
}

