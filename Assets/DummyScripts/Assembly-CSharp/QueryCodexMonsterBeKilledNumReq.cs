/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QueryCodexMonsterBeKilledNumReq : MessageBase, IMessage<QueryCodexMonsterBeKilledNumReq> // TypeDefIndex: 22662
{
	// Fields
	private static readonly MessageParser<QueryCodexMonsterBeKilledNumReq> _parser; // 0x00
	public const int CodexIdListFieldNumber = 1; // Metadata: 0x00B02187
	private static readonly FieldCodec<uint> _repeated_codexIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> codexIdList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<QueryCodexMonsterBeKilledNumReq> Parser { get => default; } // 0x0000000182C66870-0x0000000182C66900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182C66600-0x0000000182C66690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182C66330-0x0000000182C663B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182C65DF0-0x0000000182C65E50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182C66C40-0x0000000182C66D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182C66A30-0x0000000182C66A90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182C66690-0x0000000182C66780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182C66BF0-0x0000000182C66C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182C66450-0x0000000182C66540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> CodexIdList { get => default; } // 0x0000000182C66B90-0x0000000182C66BF0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22663
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22664
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4203
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QueryCodexMonsterBeKilledNumReq() {} // 0x0000000182C66F60-0x0000000182C66FF0
	static QueryCodexMonsterBeKilledNumReq() {} // 0x0000000182C66E80-0x0000000182C66F60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QueryCodexMonsterBeKilledNumReq Clone() => default; // 0x0000000182C66780-0x0000000182C66870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QueryCodexMonsterBeKilledNumReq ShallowCopy() => default; // 0x0000000182C663B0-0x0000000182C66450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182C65F60-0x0000000182C65FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C66990-0x0000000182C669E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C669E0-0x0000000182C66A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182C65FB0-0x0000000182C66070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182C66070-0x0000000182C66140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(QueryCodexMonsterBeKilledNumReq other) => default; // 0x0000000182C66140-0x0000000182C66240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182C66540-0x0000000182C66600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182C66D30-0x0000000182C66E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182C66A90-0x0000000182C66B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182C66240-0x0000000182C66330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(QueryCodexMonsterBeKilledNumReq other) {} // 0x0000000182C65E50-0x0000000182C65F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182C65CB0-0x0000000182C65DF0
}

