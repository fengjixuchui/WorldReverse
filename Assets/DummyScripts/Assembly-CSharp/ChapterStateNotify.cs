/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChapterStateNotify : MessageBase, IMessage<ChapterStateNotify> // TypeDefIndex: 24605
{
	// Fields
	private static readonly MessageParser<ChapterStateNotify> _parser; // 0x00
	public const int ChapterIdFieldNumber = 1; // Metadata: 0x00B06D17
	private uint chapterId_; // 0x18
	public const int ChapterStateFieldNumber = 2; // Metadata: 0x00B06D1B
	private ChapterState chapterState_; // 0x1C
	public const int NeedPlayerLevelFieldNumber = 3; // Metadata: 0x00B06D1F
	private Types.NeedPlayerLevel needPlayerLevel_; // 0x20
	public const int NeedBeginTimeFieldNumber = 4; // Metadata: 0x00B06D23
	private Types.NeedBeginTime needBeginTime_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChapterStateNotify> Parser { get => default; } // 0x00000001849C9860-0x00000001849C98F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001849C95F0-0x00000001849C9680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001849C9130-0x00000001849C91B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001849C82E0-0x00000001849C8340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001849C9D80-0x00000001849C9E70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001849C9B40-0x00000001849C9BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001849C9680-0x00000001849C9770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001849C9D30-0x00000001849C9D80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001849C9250-0x00000001849C9340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChapterId { get => default; set {} } // 0x00000001849C9090-0x00000001849C9130 0x00000001849C9980-0x00000001849C9A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChapterState ChapterState { get => default; set {} } // 0x00000001849C83E0-0x00000001849C8480 0x00000001849C8B10-0x00000001849C8BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.NeedPlayerLevel NeedPlayerLevel { get => default; set {} } // 0x00000001849C86A0-0x00000001849C8740 0x00000001849C89D0-0x00000001849C8A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.NeedBeginTime NeedBeginTime { get => default; set {} } // 0x00000001849C8340-0x00000001849C83E0 0x00000001849C8A70-0x00000001849C8B10

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24606
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24607
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 416
		}

		public sealed class NeedPlayerLevel : MessageBase, IMessage<NeedPlayerLevel> // TypeDefIndex: 24608
		{
			// Fields
			private static readonly MessageParser<NeedPlayerLevel> _parser; // 0x00
			public const int IsLimitFieldNumber = 1; // Metadata: 0x00B06D37
			private bool isLimit_; // 0x18
			public const int ConfigNeedPlayerLevelFieldNumber = 2; // Metadata: 0x00B06D3B
			private uint configNeedPlayerLevel_; // 0x1C

			// Properties
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageParser<NeedPlayerLevel> Parser { get => default; } // 0x0000000183D57810-0x0000000183D578A0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183D57500-0x0000000183D57590 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override MessageDescriptor Descriptor { get => default; } // 0x0000000183D570A0-0x0000000183D57120 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticClassName { get => default; } // 0x0000000183D56B60-0x0000000183D56BC0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ClassName { get => default; } // 0x0000000183D57C40-0x0000000183D57D30 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticFullClassName { get => default; } // 0x0000000183D579D0-0x0000000183D57A30 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string FullClassName { get => default; } // 0x0000000183D57590-0x0000000183D57680 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static ushort StaticCmdId { get => default; } // 0x0000000183D57BF0-0x0000000183D57C40 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override ushort CmdId { get => default; } // 0x0000000183D57260-0x0000000183D57350 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public bool IsLimit { get => default; set {} } // 0x0000000183D57A30-0x0000000183D57AD0 0x0000000183D571C0-0x0000000183D57260
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public uint ConfigNeedPlayerLevel { get => default; set {} } // 0x0000000183D57770-0x0000000183D57810 0x0000000183D57460-0x0000000183D57500

			// Constructors
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public NeedPlayerLevel() {} // 0x0000000183D57FF0-0x0000000183D58050
			static NeedPlayerLevel() {} // 0x0000000183D57F30-0x0000000183D57FF0

			// Methods
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public NeedPlayerLevel Clone() => default; // 0x0000000183D57680-0x0000000183D57770
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public NeedPlayerLevel ShallowCopy() => default; // 0x0000000183D57120-0x0000000183D571C0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalSetInPool(bool value) {} // 0x0000000183D56CF0-0x0000000183D56D40
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D57930-0x0000000183D57980
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D57980-0x0000000183D579D0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void Reset() {} // 0x0000000183D56D40-0x0000000183D56DB0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override bool Equals(object other) => default; // 0x0000000183D56DB0-0x0000000183D56E80
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public bool Equals(NeedPlayerLevel other) => default; // 0x0000000183D56E80-0x0000000183D56FA0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int GetHashCode() => default; // 0x0000000183D57350-0x0000000183D57460
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ToString() => default; // 0x0000000183D57D30-0x0000000183D57F30
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void WriteTo(CodedOutputStream output) {} // 0x0000000183D57AD0-0x0000000183D57BF0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int CalculateSize() => default; // 0x0000000183D56FA0-0x0000000183D570A0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public void CopyFrom(NeedPlayerLevel other) {} // 0x0000000183D56BC0-0x0000000183D56CF0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void MergeFrom(CodedInputStream input) {} // 0x0000000183D56A60-0x0000000183D56B60
		}

		public sealed class NeedBeginTime : MessageBase, IMessage<NeedBeginTime> // TypeDefIndex: 24609
		{
			// Fields
			private static readonly MessageParser<NeedBeginTime> _parser; // 0x00
			public const int IsLimitFieldNumber = 1; // Metadata: 0x00B06D3F
			private bool isLimit_; // 0x18
			public const int ConfigNeedBeginTimeFieldNumber = 2; // Metadata: 0x00B06D43
			private uint configNeedBeginTime_; // 0x1C

			// Properties
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageParser<NeedBeginTime> Parser { get => default; } // 0x0000000183D378C0-0x0000000183D37950 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183D37650-0x0000000183D376E0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override MessageDescriptor Descriptor { get => default; } // 0x0000000183D371F0-0x0000000183D37270 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticClassName { get => default; } // 0x0000000183D36CB0-0x0000000183D36D10 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ClassName { get => default; } // 0x0000000183D37CF0-0x0000000183D37DE0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticFullClassName { get => default; } // 0x0000000183D37A80-0x0000000183D37AE0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string FullClassName { get => default; } // 0x0000000183D376E0-0x0000000183D377D0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static ushort StaticCmdId { get => default; } // 0x0000000183D37CA0-0x0000000183D37CF0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override ushort CmdId { get => default; } // 0x0000000183D37450-0x0000000183D37540 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public bool IsLimit { get => default; set {} } // 0x0000000183D37AE0-0x0000000183D37B80 0x0000000183D37310-0x0000000183D373B0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public uint ConfigNeedBeginTime { get => default; set {} } // 0x0000000183D373B0-0x0000000183D37450 0x0000000183D36C10-0x0000000183D36CB0

			// Constructors
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public NeedBeginTime() {} // 0x0000000183D380A0-0x0000000183D38100
			static NeedBeginTime() {} // 0x0000000183D37FE0-0x0000000183D380A0

			// Methods
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public NeedBeginTime Clone() => default; // 0x0000000183D377D0-0x0000000183D378C0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public NeedBeginTime ShallowCopy() => default; // 0x0000000183D37270-0x0000000183D37310
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalSetInPool(bool value) {} // 0x0000000183D36E40-0x0000000183D36E90
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D379E0-0x0000000183D37A30
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D37A30-0x0000000183D37A80
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void Reset() {} // 0x0000000183D36E90-0x0000000183D36F00
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override bool Equals(object other) => default; // 0x0000000183D37020-0x0000000183D370F0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public bool Equals(NeedBeginTime other) => default; // 0x0000000183D36F00-0x0000000183D37020
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int GetHashCode() => default; // 0x0000000183D37540-0x0000000183D37650
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ToString() => default; // 0x0000000183D37DE0-0x0000000183D37FE0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void WriteTo(CodedOutputStream output) {} // 0x0000000183D37B80-0x0000000183D37CA0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int CalculateSize() => default; // 0x0000000183D370F0-0x0000000183D371F0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public void CopyFrom(NeedBeginTime other) {} // 0x0000000183D36D10-0x0000000183D36E40
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void MergeFrom(CodedInputStream input) {} // 0x0000000183D36B10-0x0000000183D36C10
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChapterStateNotify() {} // 0x00000001849CA210-0x00000001849CA280
	static ChapterStateNotify() {} // 0x00000001849CA150-0x00000001849CA210

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChapterStateNotify Clone() => default; // 0x00000001849C9770-0x00000001849C9860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChapterStateNotify ShallowCopy() => default; // 0x00000001849C91B0-0x00000001849C9250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001849C8740-0x00000001849C87D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001849C9A20-0x00000001849C9AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001849C9AB0-0x00000001849C9B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001849C87D0-0x00000001849C89D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001849C8D30-0x00000001849C8E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChapterStateNotify other) => default; // 0x00000001849C8BB0-0x00000001849C8D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001849C9340-0x00000001849C95F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001849C9E70-0x00000001849CA150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001849C9BA0-0x00000001849C9D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001849C8E00-0x00000001849C9090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChapterStateNotify other) {} // 0x00000001849C8480-0x00000001849C86A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001849C8140-0x00000001849C82E0
}

