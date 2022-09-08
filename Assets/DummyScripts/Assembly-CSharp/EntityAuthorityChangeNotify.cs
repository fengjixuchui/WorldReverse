/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityAuthorityChangeNotify : MessageBase, IMessage<EntityAuthorityChangeNotify> // TypeDefIndex: 23064
{
	// Fields
	private static readonly MessageParser<EntityAuthorityChangeNotify> _parser; // 0x00
	public const int AuthorityChangeListFieldNumber = 1; // Metadata: 0x00B031C3
	private static readonly FieldCodec<AuthorityChange> _repeated_authorityChangeList_codec; // 0x08
	private readonly RepeatedMessageField<AuthorityChange> authorityChangeList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EntityAuthorityChangeNotify> Parser { get => default; } // 0x0000000183C3F390-0x0000000183C3F420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183C3F120-0x0000000183C3F1B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183C3EE50-0x0000000183C3EED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183C3E8D0-0x0000000183C3E930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183C3F780-0x0000000183C3F870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183C3F5D0-0x0000000183C3F630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183C3F1B0-0x0000000183C3F2A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183C3F730-0x0000000183C3F780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183C3EF70-0x0000000183C3F060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<AuthorityChange> AuthorityChangeList { get => default; } // 0x0000000183C3F870-0x0000000183C3F8D0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23065
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23066
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 326
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityAuthorityChangeNotify() {} // 0x0000000183C3FB30-0x0000000183C3FBC0
	static EntityAuthorityChangeNotify() {} // 0x0000000183C3FA20-0x0000000183C3FB30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityAuthorityChangeNotify Clone() => default; // 0x0000000183C3F2A0-0x0000000183C3F390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityAuthorityChangeNotify ShallowCopy() => default; // 0x0000000183C3EED0-0x0000000183C3EF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183C3EA60-0x0000000183C3EAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183C3F4B0-0x0000000183C3F540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183C3F540-0x0000000183C3F5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183C3EAB0-0x0000000183C3EB80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183C3EB80-0x0000000183C3EC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EntityAuthorityChangeNotify other) => default; // 0x0000000183C3EC50-0x0000000183C3ED60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183C3F060-0x0000000183C3F120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183C3F8D0-0x0000000183C3FA20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183C3F630-0x0000000183C3F730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183C3ED60-0x0000000183C3EE50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EntityAuthorityChangeNotify other) {} // 0x0000000183C3E930-0x0000000183C3EA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183C3E7A0-0x0000000183C3E8D0
}

