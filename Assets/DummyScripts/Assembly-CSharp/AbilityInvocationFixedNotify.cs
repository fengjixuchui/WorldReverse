/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityInvocationFixedNotify : MessageBase, IMessage<AbilityInvocationFixedNotify> // TypeDefIndex: 21746
{
	// Fields
	private static readonly MessageParser<AbilityInvocationFixedNotify> _parser; // 0x00
	public const int Invoke1StFieldNumber = 1; // Metadata: 0x00AFFE87
	private AbilityInvokeEntry invoke1St_; // 0x18
	public const int Invoke2NdFieldNumber = 2; // Metadata: 0x00AFFE8B
	private AbilityInvokeEntry invoke2Nd_; // 0x20
	public const int Invoke3RdFieldNumber = 3; // Metadata: 0x00AFFE8F
	private AbilityInvokeEntry invoke3Rd_; // 0x28
	public const int Invoke4ThFieldNumber = 4; // Metadata: 0x00AFFE93
	private AbilityInvokeEntry invoke4Th_; // 0x30
	public const int Invoke5ThFieldNumber = 5; // Metadata: 0x00AFFE97
	private AbilityInvokeEntry invoke5Th_; // 0x38
	public const int Invoke6ThFieldNumber = 6; // Metadata: 0x00AFFE9B
	private AbilityInvokeEntry invoke6Th_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityInvocationFixedNotify> Parser { get => default; } // 0x0000000181E5D150-0x0000000181E5D1E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181E5CC60-0x0000000181E5CCF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181E5C520-0x0000000181E5C5A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181E5B0A0-0x0000000181E5B100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181E5D6E0-0x0000000181E5D7D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181E5D430-0x0000000181E5D490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181E5CD90-0x0000000181E5CE80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181E5D690-0x0000000181E5D6E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181E5C6E0-0x0000000181E5C7D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityInvokeEntry Invoke1St { get => default; set {} } // 0x0000000181E5D0B0-0x0000000181E5D150 0x0000000181E5C480-0x0000000181E5C520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityInvokeEntry Invoke2Nd { get => default; set {} } // 0x0000000181E5C640-0x0000000181E5C6E0 0x0000000181E5CCF0-0x0000000181E5CD90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityInvokeEntry Invoke3Rd { get => default; set {} } // 0x0000000181E5B1A0-0x0000000181E5B240 0x0000000181E5B100-0x0000000181E5B1A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityInvokeEntry Invoke4Th { get => default; set {} } // 0x0000000181E5B000-0x0000000181E5B0A0 0x0000000181E5D010-0x0000000181E5D0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityInvokeEntry Invoke5Th { get => default; set {} } // 0x0000000181E5D7D0-0x0000000181E5D870 0x0000000181E5B240-0x0000000181E5B2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityInvokeEntry Invoke6Th { get => default; set {} } // 0x0000000181E5CF70-0x0000000181E5D010 0x0000000181E5BC40-0x0000000181E5BCE0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21747
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21748
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1101
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityInvocationFixedNotify() {} // 0x0000000181E5DCC0-0x0000000181E5DD20
	static AbilityInvocationFixedNotify() {} // 0x0000000181E5DC00-0x0000000181E5DCC0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityInvocationFixedNotify Clone() => default; // 0x0000000181E5CE80-0x0000000181E5CF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityInvocationFixedNotify ShallowCopy() => default; // 0x0000000181E5C5A0-0x0000000181E5C640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181E5B680-0x0000000181E5B770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E5D270-0x0000000181E5D350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E5D350-0x0000000181E5D430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181E5B770-0x0000000181E5BC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181E5BEE0-0x0000000181E5BFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityInvocationFixedNotify other) => default; // 0x0000000181E5BCE0-0x0000000181E5BEE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181E5C7D0-0x0000000181E5CC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181E5D870-0x0000000181E5DC00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181E5D490-0x0000000181E5D690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181E5BFB0-0x0000000181E5C480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityInvocationFixedNotify other) {} // 0x0000000181E5B2E0-0x0000000181E5B680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181E5AD50-0x0000000181E5B000
}

