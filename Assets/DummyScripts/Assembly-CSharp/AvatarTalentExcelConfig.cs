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
public class AvatarTalentExcelConfig : BaseTalentConfig, IAutoAllocRecycle // TypeDefIndex: 14845
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 talentIdRawNum; // 0x28
	protected uint _nameTextMapHash; // 0x2C
	protected uint _descTextMapHash; // 0x30
	protected string _icon; // 0x38
	protected SimpleSafeUInt32 prevTalentRawNum; // 0x40
	protected SimpleSafeUInt32 mainCostItemIdRawNum; // 0x44
	protected SimpleSafeUInt32 mainCostItemCountRawNum; // 0x48
	protected SimpleSafeUInt32 viceCostItemIdRawNum; // 0x4C
	protected SimpleSafeUInt32 viceCostItemCountRawNum; // 0x50

	// Properties
	public override uint talentSkillID { /* [XID] */ /* 0x0000000189B11230-0x0000000189B11250 */ get => default; } // 0x0000000183D79550-0x0000000183D79600 
	public uint talentId { /* [XID] */ /* 0x0000000189B18400-0x0000000189B18420 */ get => default; /* [XID] */ /* 0x0000000189B1FB00-0x0000000189B1FB20 */ protected set {} } // 0x0000000183D7A4C0-0x0000000183D7A590 0x0000000183D77AA0-0x0000000183D77B80
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x0000000189B27380-0x0000000189B273A0 */ get => default; /* [XID] */ /* 0x0000000189B2E4F0-0x0000000189B2E510 */ protected set {} } // 0x0000000183D77EA0-0x0000000183D77F40 0x0000000183D7A630-0x0000000183D7A6E0
	public string name { /* [XID] */ /* 0x0000000189B359C0-0x0000000189B359E0 */ get => default; } // 0x0000000183D7AB60-0x0000000183D7ACE0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189B3D200-0x0000000189B3D220 */ get => default; /* [XID] */ /* 0x0000000189B45010-0x0000000189B45030 */ protected set {} } // 0x0000000183D7A590-0x0000000183D7A630 0x0000000183D77F40-0x0000000183D77FF0
	public string desc { /* [XID] */ /* 0x0000000189B4C7C0-0x0000000189B4C7E0 */ get => default; } // 0x0000000183D79600-0x0000000183D79780 
	public string icon { /* [XID] */ /* 0x0000000189B53EE0-0x0000000189B53F00 */ get => default; /* [XID] */ /* 0x0000000189B5B870-0x0000000189B5B890 */ protected set {} } // 0x0000000183D77B80-0x0000000183D77C20 0x0000000183D7A820-0x0000000183D7A8D0
	public uint prevTalent { /* [XID] */ /* 0x0000000189B62CA0-0x0000000189B62CC0 */ get => default; /* [XID] */ /* 0x0000000189B6A6F0-0x0000000189B6A710 */ protected set {} } // 0x0000000183D7AA90-0x0000000183D7AB60 0x0000000183D7A6E0-0x0000000183D7A7C0
	public uint mainCostItemId { /* [XID] */ /* 0x0000000189B71E90-0x0000000189B71EB0 */ get => default; /* [XID] */ /* 0x0000000189B792A0-0x0000000189B792C0 */ protected set {} } // 0x0000000183D79950-0x0000000183D79A20 0x0000000183D79470-0x0000000183D79550
	public uint mainCostItemCount { /* [XID] */ /* 0x0000000189B806D0-0x0000000189B806F0 */ get => default; /* [XID] */ /* 0x0000000189B88220-0x0000000189B88240 */ protected set {} } // 0x0000000183D793A0-0x0000000183D79470 0x0000000183D7A9B0-0x0000000183D7AA90
	public uint viceCostItemId { /* [XID] */ /* 0x0000000189B8F4F0-0x0000000189B8F510 */ get => default; /* [XID] */ /* 0x0000000189B96970-0x0000000189B96990 */ protected set {} } // 0x0000000183D792D0-0x0000000183D793A0 0x0000000183D79810-0x0000000183D798F0
	public uint viceCostItemCount { /* [XID] */ /* 0x0000000189B9DF00-0x0000000189B9DF20 */ get => default; /* [XID] */ /* 0x0000000189BA5870-0x0000000189BA5890 */ protected set {} } // 0x0000000183D7A3F0-0x0000000183D7A4C0 0x0000000183D7A8D0-0x0000000183D7A9B0

	// Constructors
	public AvatarTalentExcelConfig() {} // 0x0000000183D7AD80-0x0000000183D7ADE0

	// Methods
	// [IDTag] // 0x0000000189BACAB0-0x0000000189BACAF0
	// [XID] // 0x0000000189BACAB0-0x0000000189BACAF0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183D788E0-0x0000000183D79260
	// [IDTag] // 0x0000000189BB7010-0x0000000189BB7050
	// [XID] // 0x0000000189BB7010-0x0000000189BB7050
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183D78050-0x0000000183D788E0
	// [XID] // 0x0000000189BC1F30-0x0000000189BC1F50
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF7A7 */, bool useObjectPool = false /* Metadata: 0x00AEF7AB */) => default; // 0x0000000183D79A20-0x0000000183D7A3F0
	[BlackList] // 0x0000000189BC9420-0x0000000189BC9460
	// [XID] // 0x0000000189BC9420-0x0000000189BC9460
	public override void AutoAllocTypeFields() {} // 0x0000000183D77C20-0x0000000183D77CC0
	[BlackList] // 0x0000000189BD3D50-0x0000000189BD3D90
	// [XID] // 0x0000000189BD3D50-0x0000000189BD3D90
	public override void AutoRecycleTypeFields() {} // 0x0000000183D77CC0-0x0000000183D77E00
	[BlackList] // 0x0000000189BDE700-0x0000000189BDE740
	// [XID] // 0x0000000189BDE700-0x0000000189BDE740
	public override void ReturnToObjectPool() {} // 0x0000000183D7ACE0-0x0000000183D7AD80
}

