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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class OpActivityExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15928
{
	// Fields
	protected SimpleSafeUInt32 opActivityIdRawNum; // 0x10
	protected OpActivityBonusType _bonusType; // 0x14
	protected SimpleSafeUInt32 bonusValueRawNum; // 0x18
	protected SimpleSafeUInt32[] _bonusList; // 0x20
	protected SimpleSafeUInt32 iconRawNum; // 0x28
	protected string _tabText; // 0x30
	protected string[] _textMapIdList; // 0x38

	// Properties
	public uint opActivityId { /* [XID] */ /* 0x0000000189676560-0x0000000189676580 */ get => default; /* [XID] */ /* 0x000000018967DD60-0x000000018967DD80 */ protected set {} } // 0x00000001825AF960-0x00000001825AFA30 0x00000001825AF880-0x00000001825AF960
	public OpActivityBonusType bonusType { /* [XID] */ /* 0x0000000189685420-0x0000000189685440 */ get => default; /* [XID] */ /* 0x000000018968CF60-0x000000018968CF80 */ protected set {} } // 0x00000001825AFA30-0x00000001825AFAD0 0x00000001825AE8D0-0x00000001825AE980
	public uint bonusValue { /* [XID] */ /* 0x0000000189694A80-0x0000000189694AA0 */ get => default; /* [XID] */ /* 0x000000018969C240-0x000000018969C260 */ protected set {} } // 0x00000001825AE5C0-0x00000001825AE690 0x00000001825B0590-0x00000001825B0670
	public SimpleSafeUInt32[] bonusList { /* [XID] */ /* 0x00000001896A3760-0x00000001896A3780 */ get => default; /* [XID] */ /* 0x00000001896AABD0-0x00000001896AABF0 */ protected set {} } // 0x00000001825AE3A0-0x00000001825AE440 0x00000001825AFAD0-0x00000001825AFB80
	public uint icon { /* [XID] */ /* 0x00000001896B1B50-0x00000001896B1B70 */ get => default; /* [XID] */ /* 0x00000001896B95B0-0x00000001896B95D0 */ protected set {} } // 0x00000001825AE440-0x00000001825AE510 0x00000001825B02C0-0x00000001825B03A0
	public string tabText { /* [XID] */ /* 0x00000001896C0920-0x00000001896C0940 */ get => default; /* [XID] */ /* 0x00000001896C80F0-0x00000001896C8110 */ protected set {} } // 0x00000001825AE830-0x00000001825AE8D0 0x00000001825B03A0-0x00000001825B0450
	public string[] textMapIdList { /* [XID] */ /* 0x00000001896CF9D0-0x00000001896CF9F0 */ get => default; /* [XID] */ /* 0x00000001896D6C40-0x00000001896D6C60 */ protected set {} } // 0x00000001825B0220-0x00000001825B02C0 0x00000001825AE510-0x00000001825AE5C0

	// Constructors
	public OpActivityExcelConfig() {} // 0x00000001825B0710-0x00000001825B0770

	// Methods
	// [IDTag] // 0x00000001896DE3C0-0x00000001896DE400
	// [XID] // 0x00000001896DE3C0-0x00000001896DE400
	public virtual bool ParseFromLine(string line) => default; // 0x00000001825AF0F0-0x00000001825AF880
	// [IDTag] // 0x00000001896E87E0-0x00000001896E8820
	// [XID] // 0x00000001896E87E0-0x00000001896E8820
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001825AE980-0x00000001825AF0F0
	// [XID] // 0x00000001896F2CF0-0x00000001896F2D10
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2B63 */, bool useObjectPool = false /* Metadata: 0x00AF2B67 */) => default; // 0x00000001825AFB80-0x00000001825B0220
	[BlackList] // 0x00000001896FA5B0-0x00000001896FA5F0
	// [XID] // 0x00000001896FA5B0-0x00000001896FA5F0
	public virtual void AutoAllocTypeFields() {} // 0x00000001825AE690-0x00000001825AE730
	[BlackList] // 0x0000000189704C30-0x0000000189704C70
	// [XID] // 0x0000000189704C30-0x0000000189704C70
	public virtual void AutoRecycleTypeFields() {} // 0x00000001825AE730-0x00000001825AE830
	[BlackList] // 0x000000018970F600-0x000000018970F640
	// [XID] // 0x000000018970F600-0x000000018970F640
	public virtual void ReturnToObjectPool() {} // 0x00000001825B0670-0x00000001825B0710
	[BlackList] // 0x0000000189719D50-0x0000000189719D90
	// [XID] // 0x0000000189719D50-0x0000000189719D90
	public virtual void OnPoolAllocated() {} // 0x00000001825B04F0-0x00000001825B0590
	[BlackList] // 0x0000000189723F70-0x0000000189723FB0
	// [XID] // 0x0000000189723F70-0x0000000189723FB0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001825B0450-0x00000001825B04F0
}

