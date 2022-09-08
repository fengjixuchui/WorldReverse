/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ClientAbilitiesInitFinishCombineNotify : MessageBase, IMessage<ClientAbilitiesInitFinishCombineNotify> // TypeDefIndex: 21802
{
	// Fields
	private static readonly MessageParser<ClientAbilitiesInitFinishCombineNotify> _parser; // 0x00
	public const int EntityInvokeListFieldNumber = 1; // Metadata: 0x00B0006F
	private static readonly FieldCodec<EntityAbilityInvokeEntry> _repeated_entityInvokeList_codec; // 0x08
	private readonly RepeatedMessageField<EntityAbilityInvokeEntry> entityInvokeList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ClientAbilitiesInitFinishCombineNotify> Parser { get => default; } // 0x000000018226B5D0-0x000000018226B660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018226B360-0x000000018226B3F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018226B090-0x000000018226B110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018226AAB0-0x000000018226AB10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018226B9C0-0x000000018226BAB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018226B810-0x000000018226B870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018226B3F0-0x000000018226B4E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018226B970-0x000000018226B9C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018226B1B0-0x000000018226B2A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<EntityAbilityInvokeEntry> EntityInvokeList { get => default; } // 0x000000018226AD60-0x000000018226ADC0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21803
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21804
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1107
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientAbilitiesInitFinishCombineNotify() {} // 0x000000018226BD10-0x000000018226BDA0
	static ClientAbilitiesInitFinishCombineNotify() {} // 0x000000018226BC00-0x000000018226BD10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientAbilitiesInitFinishCombineNotify Clone() => default; // 0x000000018226B4E0-0x000000018226B5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientAbilitiesInitFinishCombineNotify ShallowCopy() => default; // 0x000000018226B110-0x000000018226B1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018226AC40-0x000000018226AC90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018226B6F0-0x000000018226B780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018226B780-0x000000018226B810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018226AC90-0x000000018226AD60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018226ADC0-0x000000018226AE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ClientAbilitiesInitFinishCombineNotify other) => default; // 0x000000018226AE90-0x000000018226AFA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018226B2A0-0x000000018226B360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018226BAB0-0x000000018226BC00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018226B870-0x000000018226B970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018226AFA0-0x000000018226B090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ClientAbilitiesInitFinishCombineNotify other) {} // 0x000000018226AB10-0x000000018226AC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018226A980-0x000000018226AAB0
}

