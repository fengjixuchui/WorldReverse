/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerConfirmMatchReq : MessageBase, IMessage<PlayerConfirmMatchReq> // TypeDefIndex: 23848
{
	// Fields
	private static readonly MessageParser<PlayerConfirmMatchReq> _parser; // 0x00
	public const int MatchTypeFieldNumber = 1; // Metadata: 0x00B04F93
	private MatchType matchType_; // 0x18
	public const int IsAgreedFieldNumber = 2; // Metadata: 0x00B04F97
	private bool isAgreed_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerConfirmMatchReq> Parser { get => default; } // 0x0000000185497180-0x0000000185497210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185496E70-0x0000000185496F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000185496B10-0x0000000185496B90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000185496530-0x0000000185496590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185497650-0x0000000185497740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185497480-0x00000001854974E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185496F00-0x0000000185496FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185497600-0x0000000185497650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185496C30-0x0000000185496D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MatchType MatchType { get => default; set {} } // 0x00000001854970E0-0x0000000185497180 0x0000000185497390-0x0000000185497430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAgreed { get => default; set {} } // 0x0000000185496590-0x0000000185496630 0x0000000185497210-0x00000001854972B0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23849
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23850
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4158
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerConfirmMatchReq() {} // 0x0000000185497A00-0x0000000185497A70
	static PlayerConfirmMatchReq() {} // 0x0000000185497940-0x0000000185497A00

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerConfirmMatchReq Clone() => default; // 0x0000000185496FF0-0x00000001854970E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerConfirmMatchReq ShallowCopy() => default; // 0x0000000185496B90-0x0000000185496C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185496760-0x00000001854967B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185497340-0x0000000185497390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185497430-0x0000000185497480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001854967B0-0x0000000185496820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185496940-0x0000000185496A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerConfirmMatchReq other) => default; // 0x0000000185496820-0x0000000185496940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000185496D20-0x0000000185496E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185497740-0x0000000185497940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001854974E0-0x0000000185497600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185496A10-0x0000000185496B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerConfirmMatchReq other) {} // 0x0000000185496630-0x0000000185496760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185496440-0x0000000185496530
}

