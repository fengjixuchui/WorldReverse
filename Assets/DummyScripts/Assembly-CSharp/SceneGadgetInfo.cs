/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneGadgetInfo : MessageBase, IMessage<SceneGadgetInfo> // TypeDefIndex: 26041
{
	// Fields
	private static readonly MessageParser<SceneGadgetInfo> _parser; // 0x00
	public const int GadgetIdFieldNumber = 1; // Metadata: 0x00B0AD1F
	private uint gadgetId_; // 0x18
	public const int GroupIdFieldNumber = 2; // Metadata: 0x00B0AD23
	private uint groupId_; // 0x1C
	public const int ConfigIdFieldNumber = 3; // Metadata: 0x00B0AD27
	private uint configId_; // 0x20
	public const int OwnerEntityIdFieldNumber = 4; // Metadata: 0x00B0AD2B
	private uint ownerEntityId_; // 0x24
	public const int BornTypeFieldNumber = 5; // Metadata: 0x00B0AD2F
	private GadgetBornType bornType_; // 0x28
	public const int GadgetStateFieldNumber = 6; // Metadata: 0x00B0AD33
	private uint gadgetState_; // 0x2C
	public const int GadgetTypeFieldNumber = 7; // Metadata: 0x00B0AD37
	private uint gadgetType_; // 0x30
	public const int IsShowCutsceneFieldNumber = 8; // Metadata: 0x00B0AD3B
	private bool isShowCutscene_; // 0x34
	public const int AuthorityPeerIdFieldNumber = 9; // Metadata: 0x00B0AD3F
	private uint authorityPeerId_; // 0x38
	public const int IsEnableInteractFieldNumber = 10; // Metadata: 0x00B0AD43
	private bool isEnableInteract_; // 0x3C
	public const int InteractIdFieldNumber = 11; // Metadata: 0x00B0AD47
	private uint interactId_; // 0x40
	public const int TrifleItemFieldNumber = 12; // Metadata: 0x00B0AD4B
	public const int GatherGadgetFieldNumber = 13; // Metadata: 0x00B0AD4F
	public const int WorktopFieldNumber = 14; // Metadata: 0x00B0AD53
	public const int ClientGadgetFieldNumber = 15; // Metadata: 0x00B0AD57
	public const int WeatherFieldNumber = 17; // Metadata: 0x00B0AD5B
	public const int AbilityGadgetFieldNumber = 18; // Metadata: 0x00B0AD5F
	public const int StatueGadgetFieldNumber = 19; // Metadata: 0x00B0AD63
	public const int BossChestFieldNumber = 20; // Metadata: 0x00B0AD67
	public const int BlossomChestFieldNumber = 41; // Metadata: 0x00B0AD6B
	public const int MpPlayRewardFieldNumber = 42; // Metadata: 0x00B0AD6F
	public const int GeneralRewardFieldNumber = 43; // Metadata: 0x00B0AD73
	public const int OfferingInfoFieldNumber = 44; // Metadata: 0x00B0AD77
	public const int FoundationInfoFieldNumber = 45; // Metadata: 0x00B0AD7B
	public const int MarkFlagFieldNumber = 21; // Metadata: 0x00B0AD7F
	private uint markFlag_; // 0x44
	public const int PropOwnerEntityIdFieldNumber = 22; // Metadata: 0x00B0AD83
	private uint propOwnerEntityId_; // 0x48
	public const int PlatformFieldNumber = 23; // Metadata: 0x00B0AD87
	private PlatformInfo platform_; // 0x50
	public const int InteractUidListFieldNumber = 24; // Metadata: 0x00B0AD8B
	private static readonly FieldCodec<uint> _repeated_interactUidList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> interactUidList_; // 0x58
	public const int DraftIdFieldNumber = 25; // Metadata: 0x00B0AD8F
	private uint draftId_; // 0x60
	public const int GadgetTalkStateFieldNumber = 26; // Metadata: 0x00B0AD93
	private uint gadgetTalkState_; // 0x64
	public const int PlayInfoFieldNumber = 100; // Metadata: 0x00B0AD97
	private GadgetPlayInfo playInfo_; // 0x68
	private object content_; // 0x70
	private ContentOneofCase contentCase_; // 0x78

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneGadgetInfo> Parser { get => default; } // 0x0000000185208D20-0x0000000185208DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185208030-0x00000001852080C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000185206A00-0x0000000185206A80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001852037F0-0x0000000185203850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018520A770-0x000000018520A860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185209CF0-0x0000000185209D50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001852084E0-0x00000001852085D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018520A720-0x000000018520A770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185207530-0x0000000185207620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetId { get => default; set {} } // 0x00000001852065A0-0x0000000185206640 0x0000000185207EF0-0x0000000185207F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GroupId { get => default; set {} } // 0x00000001852085D0-0x0000000185208670 0x0000000185206960-0x0000000185206A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ConfigId { get => default; set {} } // 0x0000000185208300-0x00000001852083A0 0x0000000185203850-0x00000001852038F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OwnerEntityId { get => default; set {} } // 0x0000000185203BA0-0x0000000185203C40 0x00000001852081C0-0x0000000185208260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetBornType BornType { get => default; set {} } // 0x0000000185208260-0x0000000185208300 0x0000000185209B10-0x0000000185209BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetState { get => default; set {} } // 0x0000000185205170-0x0000000185205210 0x0000000185206820-0x00000001852068C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetType { get => default; set {} } // 0x0000000185206500-0x00000001852065A0 0x00000001852080C0-0x0000000185208160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsShowCutscene { get => default; set {} } // 0x0000000185203A60-0x0000000185203B00 0x00000001852035B0-0x0000000185203650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AuthorityPeerId { get => default; set {} } // 0x0000000185208DB0-0x0000000185208E50 0x0000000185208A40-0x0000000185208AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsEnableInteract { get => default; set {} } // 0x00000001852050D0-0x0000000185205170 0x0000000185206640-0x00000001852066E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint InteractId { get => default; set {} } // 0x0000000185203D40-0x0000000185203DE0 0x0000000185209BB0-0x0000000185209C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Item TrifleItem { get => default; set {} } // 0x0000000185208830-0x0000000185208900 0x0000000185208440-0x00000001852084E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GatherGadgetInfo GatherGadget { get => default; set {} } // 0x0000000185205000-0x00000001852050D0 0x0000000185204D80-0x0000000185204E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorktopInfo Worktop { get => default; set {} } // 0x0000000185209D50-0x0000000185209E20 0x00000001852066E0-0x0000000185206780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientGadgetInfo ClientGadget { get => default; set {} } // 0x0000000185208760-0x0000000185208830 0x0000000185207E50-0x0000000185207EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WeatherInfo Weather { get => default; set {} } // 0x0000000185203990-0x0000000185203A60 0x0000000185204EC0-0x0000000185204F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityGadgetInfo AbilityGadget { get => default; set {} } // 0x0000000185208C50-0x0000000185208D20 0x00000001852089A0-0x0000000185208A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StatueGadgetInfo StatueGadget { get => default; set {} } // 0x0000000185205210-0x00000001852052E0 0x0000000185208900-0x00000001852089A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BossChestInfo BossChest { get => default; set {} } // 0x0000000185206430-0x0000000185206500 0x0000000185203B00-0x0000000185203BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlossomChestInfo BlossomChest { get => default; set {} } // 0x000000018520A650-0x000000018520A720 0x00000001852038F0-0x0000000185203990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MpPlayRewardInfo MpPlayReward { get => default; set {} } // 0x0000000185203720-0x00000001852037F0 0x00000001852062F0-0x0000000185206390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetGeneralRewardInfo GeneralReward { get => default; set {} } // 0x0000000185208AE0-0x0000000185208BB0 0x00000001852068C0-0x0000000185206960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OfferingInfo OfferingInfo { get => default; set {} } // 0x0000000185203650-0x0000000185203720 0x00000001852083A0-0x0000000185208440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FoundationInfo FoundationInfo { get => default; set {} } // 0x0000000185209490-0x0000000185209560 0x0000000185207DB0-0x0000000185207E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MarkFlag { get => default; set {} } // 0x0000000185206390-0x0000000185206430 0x0000000185208BB0-0x0000000185208C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PropOwnerEntityId { get => default; set {} } // 0x0000000185209A70-0x0000000185209B10 0x0000000185206780-0x0000000185206820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlatformInfo Platform { get => default; set {} } // 0x0000000185207F90-0x0000000185208030 0x0000000185203CA0-0x0000000185203D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> InteractUidList { get => default; } // 0x0000000185208160-0x00000001852081C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DraftId { get => default; set {} } // 0x0000000185204F60-0x0000000185205000 0x00000001852093F0-0x0000000185209490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetTalkState { get => default; set {} } // 0x0000000185209C50-0x0000000185209CF0 0x0000000185204E20-0x0000000185204EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetPlayInfo PlayInfo { get => default; set {} } // 0x0000000185206A80-0x0000000185206B20 0x0000000185202A80-0x0000000185202B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ContentOneofCase ContentCase { get => default; } // 0x000000018520A860-0x000000018520A8C0 

	// Nested types
	public enum ContentOneofCase // TypeDefIndex: 26042
	{
		None = 0,
		TrifleItem = 12,
		GatherGadget = 13,
		Worktop = 14,
		ClientGadget = 15,
		Weather = 17,
		AbilityGadget = 18,
		StatueGadget = 19,
		BossChest = 20,
		BlossomChest = 41,
		MpPlayReward = 42,
		GeneralReward = 43,
		OfferingInfo = 44,
		FoundationInfo = 45
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGadgetInfo() {} // 0x000000018520BDA0-0x000000018520BE40
	static SceneGadgetInfo() {} // 0x000000018520BCC0-0x000000018520BDA0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGadgetInfo Clone() => default; // 0x0000000185208670-0x0000000185208760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGadgetInfo ShallowCopy() => default; // 0x0000000185206B20-0x0000000185206BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185204540-0x0000000185204A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185208EE0-0x00000001852093F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185209560-0x0000000185209A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185204A70-0x0000000185204D80
	public void resetContent() {} // 0x0000000185206BC0-0x0000000185207530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearContent() {} // 0x0000000185203C40-0x0000000185203CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185205890-0x0000000185205960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneGadgetInfo other) => default; // 0x00000001852052E0-0x0000000185205890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000185207620-0x0000000185207DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018520A8C0-0x000000018520BCC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185209E20-0x000000018520A650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185205960-0x00000001852062F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneGadgetInfo other) {} // 0x0000000185203DE0-0x0000000185204540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185202B20-0x00000001852035B0
}

