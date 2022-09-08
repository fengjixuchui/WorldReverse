/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeResourceNotify : MessageBase, IMessage<HomeResourceNotify> // TypeDefIndex: 23512
{
	// Fields
	private static readonly MessageParser<HomeResourceNotify> _parser; // 0x00
	public const int HomeCoinFieldNumber = 1; // Metadata: 0x00B042EB
	private HomeResource homeCoin_; // 0x18
	public const int FetterExpFieldNumber = 2; // Metadata: 0x00B042EF
	private HomeResource fetterExp_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeResourceNotify> Parser { get => default; } // 0x000000018161E5C0-0x000000018161E650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018161E2B0-0x000000018161E340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018161DEB0-0x000000018161DF30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018161D4A0-0x000000018161D500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018161E9C0-0x000000018161EAB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018161E800-0x000000018161E860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018161E340-0x000000018161E430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018161E970-0x000000018161E9C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018161DFD0-0x000000018161E0C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeResource HomeCoin { get => default; set {} } // 0x000000018161D950-0x000000018161D9F0 0x000000018161D400-0x000000018161D4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeResource FetterExp { get => default; set {} } // 0x000000018161D9F0-0x000000018161DA90 0x000000018161E520-0x000000018161E5C0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23513
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23514
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4700
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeResourceNotify() {} // 0x000000018161ED30-0x000000018161ED90
	static HomeResourceNotify() {} // 0x000000018161EC70-0x000000018161ED30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeResourceNotify Clone() => default; // 0x000000018161E430-0x000000018161E520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeResourceNotify ShallowCopy() => default; // 0x000000018161DF30-0x000000018161DFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018161D6E0-0x000000018161D770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018161E6E0-0x000000018161E770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018161E770-0x000000018161E800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018161D770-0x000000018161D950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018161DBD0-0x000000018161DCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeResourceNotify other) => default; // 0x000000018161DA90-0x000000018161DBD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018161E0C0-0x000000018161E2B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018161EAB0-0x000000018161EC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018161E860-0x000000018161E970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018161DCA0-0x000000018161DEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeResourceNotify other) {} // 0x000000018161D500-0x000000018161D6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018161D290-0x000000018161D400
}

