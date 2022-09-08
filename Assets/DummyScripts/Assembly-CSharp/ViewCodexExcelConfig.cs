/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ViewCodexExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15321
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 IdRawNum; // 0x10
	protected SimpleSafeUInt32 gadgetIdRawNum; // 0x14
	protected SimpleSafeUInt32 sceneIdRawNum; // 0x18
	protected SimpleSafeUInt32 groupIdRawNum; // 0x1C
	protected SimpleSafeUInt32 configIdRawNum; // 0x20
	protected uint _nameTextMapHash; // 0x24
	protected uint _descTextMapHash; // 0x28
	protected string _image; // 0x30
	protected SimpleSafeUInt32 cityIdRawNum; // 0x38
	protected SimpleSafeUInt32 worldAreaIdRawNum; // 0x3C
	protected SimpleSafeUInt32 SortOrderRawNum; // 0x40
	protected bool _isDisuse; // 0x44
	protected bool _showOnlyUnlocked; // 0x45

	// Properties
	public uint Id { /* [XID] */ /* 0x00000001896F8C80-0x00000001896F8CA0 */ get => default; /* [XID] */ /* 0x0000000189700440-0x0000000189700460 */ protected set {} } // 0x0000000183EC1EB0-0x0000000183EC1F80 0x0000000183EC3350-0x0000000183EC3430
	public uint gadgetId { /* [XID] */ /* 0x0000000189707CB0-0x0000000189707CD0 */ get => default; /* [XID] */ /* 0x000000018970F7E0-0x000000018970F800 */ protected set {} } // 0x0000000183EC2440-0x0000000183EC2510 0x0000000183EC21E0-0x0000000183EC22C0
	public uint sceneId { /* [XID] */ /* 0x0000000189716A60-0x0000000189716A80 */ get => default; /* [XID] */ /* 0x000000018971E480-0x000000018971E4A0 */ protected set {} } // 0x0000000183EC25E0-0x0000000183EC26B0 0x0000000183EC3270-0x0000000183EC3350
	public uint groupId { /* [XID] */ /* 0x0000000189725A40-0x0000000189725A60 */ get => default; /* [XID] */ /* 0x000000018972D000-0x000000018972D020 */ protected set {} } // 0x0000000183EC35B0-0x0000000183EC3680 0x0000000183EC3680-0x0000000183EC3760
	public uint configId { /* [XID] */ /* 0x0000000189734790-0x00000001897347B0 */ get => default; /* [XID] */ /* 0x000000018973C160-0x000000018973C180 */ protected set {} } // 0x0000000183EC2510-0x0000000183EC25E0 0x0000000183EC3430-0x0000000183EC3510
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x00000001897438D0-0x00000001897438F0 */ get => default; /* [XID] */ /* 0x000000018974B460-0x000000018974B480 */ protected set {} } // 0x0000000183EC0B90-0x0000000183EC0C30 0x0000000183EC31C0-0x0000000183EC3270
	public string name { /* [XID] */ /* 0x0000000189752670-0x0000000189752690 */ get => default; } // 0x0000000183EC3A20-0x0000000183EC3BA0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189759BC0-0x0000000189759BE0 */ get => default; /* [XID] */ /* 0x0000000189761810-0x0000000189761830 */ protected set {} } // 0x0000000183EC3120-0x0000000183EC31C0 0x0000000183EC0D10-0x0000000183EC0DC0
	public string desc { /* [XID] */ /* 0x0000000189768BE0-0x0000000189768C00 */ get => default; } // 0x0000000183EC22C0-0x0000000183EC2440 
	public string image { /* [XID] */ /* 0x00000001897702D0-0x00000001897702F0 */ get => default; /* [XID] */ /* 0x0000000189777990-0x00000001897779B0 */ protected set {} } // 0x0000000183EC0820-0x0000000183EC08C0 0x0000000183EC2130-0x0000000183EC21E0
	public uint cityId { /* [XID] */ /* 0x000000018977F080-0x000000018977F0A0 */ get => default; /* [XID] */ /* 0x0000000189786A40-0x0000000189786A60 */ protected set {} } // 0x0000000183EC3810-0x0000000183EC38E0 0x0000000183EC1F80-0x0000000183EC2060
	public uint worldAreaId { /* [XID] */ /* 0x000000018978E170-0x000000018978E190 */ get => default; /* [XID] */ /* 0x0000000189795820-0x0000000189795840 */ protected set {} } // 0x0000000183EC08C0-0x0000000183EC0990 0x0000000183EC0C30-0x0000000183EC0D10
	public uint SortOrder { /* [XID] */ /* 0x000000018979DC90-0x000000018979DCB0 */ get => default; /* [XID] */ /* 0x00000001897A4FB0-0x00000001897A4FD0 */ protected set {} } // 0x0000000183EC2060-0x0000000183EC2130 0x0000000183EC1DD0-0x0000000183EC1EB0
	public bool isDisuse { /* [XID] */ /* 0x00000001897AC540-0x00000001897AC560 */ get => default; /* [XID] */ /* 0x00000001897B44D0-0x00000001897B44F0 */ protected set {} } // 0x0000000183EC3510-0x0000000183EC35B0 0x0000000183EC3760-0x0000000183EC3810
	public bool showOnlyUnlocked { /* [XID] */ /* 0x00000001897BC270-0x00000001897BC290 */ get => default; /* [XID] */ /* 0x00000001897C3930-0x00000001897C3950 */ protected set {} } // 0x0000000183EC0DC0-0x0000000183EC0E60 0x0000000183EC0E60-0x0000000183EC0F10

	// Constructors
	public ViewCodexExcelConfig() {} // 0x0000000183EC3C40-0x0000000183EC3CA0

	// Methods
	// [IDTag] // 0x00000001897CB0B0-0x00000001897CB0F0
	// [XID] // 0x00000001897CB0B0-0x00000001897CB0F0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183EC0F10-0x0000000183EC1660
	// [IDTag] // 0x00000001897D57D0-0x00000001897D5810
	// [XID] // 0x00000001897D57D0-0x00000001897D5810
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183EC1660-0x0000000183EC1DD0
	// [XID] // 0x00000001897E0130-0x00000001897E0150
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF077C */, bool useObjectPool = false /* Metadata: 0x00AF0780 */) => default; // 0x0000000183EC26B0-0x0000000183EC3120
	[BlackList] // 0x00000001897E77B0-0x00000001897E77F0
	// [XID] // 0x00000001897E77B0-0x00000001897E77F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183EC0990-0x0000000183EC0A30
	[BlackList] // 0x00000001897F26B0-0x00000001897F26F0
	// [XID] // 0x00000001897F26B0-0x00000001897F26F0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183EC0A30-0x0000000183EC0B90
	[BlackList] // 0x00000001897FCD20-0x00000001897FCD60
	// [XID] // 0x00000001897FCD20-0x00000001897FCD60
	public virtual void ReturnToObjectPool() {} // 0x0000000183EC3BA0-0x0000000183EC3C40
	[BlackList] // 0x00000001898072F0-0x0000000189807330
	// [XID] // 0x00000001898072F0-0x0000000189807330
	public virtual void OnPoolAllocated() {} // 0x0000000183EC3980-0x0000000183EC3A20
	[BlackList] // 0x0000000189811880-0x00000001898118C0
	// [XID] // 0x0000000189811880-0x00000001898118C0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183EC38E0-0x0000000183EC3980
}

