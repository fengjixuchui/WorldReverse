/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeResourceTakeFetterExpRsp : MessageBase, IMessage<HomeResourceTakeFetterExpRsp> // TypeDefIndex: 23524
{
	// Fields
	private static readonly MessageParser<HomeResourceTakeFetterExpRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B04343
	private int retcode_; // 0x18
	public const int FetterExpFieldNumber = 2; // Metadata: 0x00B04347
	private HomeResource fetterExp_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeResourceTakeFetterExpRsp> Parser { get => default; } // 0x0000000181CA8540-0x0000000181CA85D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181CA8230-0x0000000181CA82C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181CA7EA0-0x0000000181CA7F20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181CA7590-0x0000000181CA75F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181CA8930-0x0000000181CA8A20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181CA8760-0x0000000181CA87C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181CA82C0-0x0000000181CA83B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181CA88E0-0x0000000181CA8930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181CA7FC0-0x0000000181CA80B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181CA7E00-0x0000000181CA7EA0 0x0000000181CA7920-0x0000000181CA79C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeResource FetterExp { get => default; set {} } // 0x0000000181CA79C0-0x0000000181CA7A60 0x0000000181CA84A0-0x0000000181CA8540

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23525
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23526
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4704
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeResourceTakeFetterExpRsp() {} // 0x0000000181CA8CC0-0x0000000181CA8D20
	static HomeResourceTakeFetterExpRsp() {} // 0x0000000181CA8C00-0x0000000181CA8CC0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeResourceTakeFetterExpRsp Clone() => default; // 0x0000000181CA83B0-0x0000000181CA84A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeResourceTakeFetterExpRsp ShallowCopy() => default; // 0x0000000181CA7F20-0x0000000181CA7FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181CA7770-0x0000000181CA77F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181CA8660-0x0000000181CA86E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181CA86E0-0x0000000181CA8760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181CA77F0-0x0000000181CA7920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181CA7A60-0x0000000181CA7B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeResourceTakeFetterExpRsp other) => default; // 0x0000000181CA7B30-0x0000000181CA7C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181CA80B0-0x0000000181CA8230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181CA8A20-0x0000000181CA8C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181CA87C0-0x0000000181CA88E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181CA7C60-0x0000000181CA7E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeResourceTakeFetterExpRsp other) {} // 0x0000000181CA75F0-0x0000000181CA7770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181CA7450-0x0000000181CA7590
}

