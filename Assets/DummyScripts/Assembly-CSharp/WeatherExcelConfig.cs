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
public class WeatherExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16276
{
	// Fields
	protected SimpleSafeUInt32 areaIDRawNum; // 0x10
	protected SimpleSafeUInt32 weatherAreaIdRawNum; // 0x14
	protected string _maxHeightStr; // 0x18
	protected SimpleSafeUInt32 gadgetIDRawNum; // 0x20
	protected bool _isDefaultValid; // 0x24
	protected string _templateName; // 0x28
	protected SimpleSafeUInt32 priorityRawNum; // 0x30
	protected string _profileName; // 0x38
	protected ClimateType _defaultClimate; // 0x40
	protected bool _isUseDefault; // 0x44
	protected SimpleSafeUInt32 sceneIDRawNum; // 0x48

	// Properties
	public uint areaID { /* [XID] */ /* 0x0000000189A41350-0x0000000189A41370 */ get => default; /* [XID] */ /* 0x0000000189A489B0-0x0000000189A489D0 */ protected set {} } // 0x000000018341CD10-0x000000018341CDE0 0x000000018341C7A0-0x000000018341C880
	public uint weatherAreaId { /* [XID] */ /* 0x0000000189A50140-0x0000000189A50160 */ get => default; /* [XID] */ /* 0x0000000189A576D0-0x0000000189A576F0 */ protected set {} } // 0x000000018341DAB0-0x000000018341DB80 0x000000018341C880-0x000000018341C960
	public string maxHeightStr { /* [XID] */ /* 0x0000000189A5F210-0x0000000189A5F230 */ get => default; /* [XID] */ /* 0x0000000189A66AA0-0x0000000189A66AC0 */ protected set {} } // 0x000000018341D930-0x000000018341D9D0 0x000000018341DC50-0x000000018341DD00
	public uint gadgetID { /* [XID] */ /* 0x0000000189A6E400-0x0000000189A6E420 */ get => default; /* [XID] */ /* 0x0000000189A75A70-0x0000000189A75A90 */ protected set {} } // 0x000000018341DB80-0x000000018341DC50 0x000000018341D9D0-0x000000018341DAB0
	public bool isDefaultValid { /* [XID] */ /* 0x0000000189A7D6D0-0x0000000189A7D6F0 */ get => default; /* [XID] */ /* 0x0000000189A84E80-0x0000000189A84EA0 */ protected set {} } // 0x000000018341C700-0x000000018341C7A0 0x000000018341C650-0x000000018341C700
	public string templateName { /* [XID] */ /* 0x0000000189A8C790-0x0000000189A8C7B0 */ get => default; /* [XID] */ /* 0x0000000189A93B90-0x0000000189A93BB0 */ protected set {} } // 0x000000018341DE40-0x000000018341DEE0 0x000000018341CB10-0x000000018341CBC0
	public uint priority { /* [XID] */ /* 0x0000000189A9B660-0x0000000189A9B680 */ get => default; /* [XID] */ /* 0x0000000189AA2980-0x0000000189AA29A0 */ protected set {} } // 0x000000018341D7B0-0x000000018341D880 0x000000018341C960-0x000000018341CA40
	public string profileName { /* [XID] */ /* 0x0000000189AAA080-0x0000000189AAA0A0 */ get => default; /* [XID] */ /* 0x0000000189AB1E60-0x0000000189AB1E80 */ protected set {} } // 0x000000018341B8C0-0x000000018341B960 0x000000018341DEE0-0x000000018341DF90
	public ClimateType defaultClimate { /* [XID] */ /* 0x0000000189AB9110-0x0000000189AB9130 */ get => default; /* [XID] */ /* 0x0000000189AC0CF0-0x0000000189AC0D10 */ protected set {} } // 0x000000018341CDE0-0x000000018341CE80 0x000000018341CBC0-0x000000018341CC70
	public bool isUseDefault { /* [XID] */ /* 0x0000000189AC8730-0x0000000189AC8750 */ get => default; /* [XID] */ /* 0x0000000189ACFE10-0x0000000189ACFE30 */ protected set {} } // 0x000000018341CC70-0x000000018341CD10 0x000000018341D880-0x000000018341D930
	public uint sceneID { /* [XID] */ /* 0x0000000189AD7C40-0x0000000189AD7C60 */ get => default; /* [XID] */ /* 0x0000000189ADF730-0x0000000189ADF750 */ protected set {} } // 0x000000018341CA40-0x000000018341CB10 0x000000018341B7E0-0x000000018341B8C0

	// Constructors
	public WeatherExcelConfig() {} // 0x000000018341E030-0x000000018341E090

	// Methods
	// [IDTag] // 0x0000000189AE6F10-0x0000000189AE6F50
	// [XID] // 0x0000000189AE6F10-0x0000000189AE6F50
	public virtual bool ParseFromLine(string line) => default; // 0x000000018341B960-0x000000018341BFD0
	// [IDTag] // 0x0000000189AF19B0-0x0000000189AF19F0
	// [XID] // 0x0000000189AF19B0-0x0000000189AF19F0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018341BFD0-0x000000018341C650
	// [XID] // 0x0000000189AFBC60-0x0000000189AFBC80
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3630 */, bool useObjectPool = false /* Metadata: 0x00AF3634 */) => default; // 0x000000018341CE80-0x000000018341D7B0
	[BlackList] // 0x0000000189B03450-0x0000000189B03490
	// [XID] // 0x0000000189B03450-0x0000000189B03490
	public virtual void AutoAllocTypeFields() {} // 0x000000018341B610-0x000000018341B6B0
	[BlackList] // 0x0000000189B0DD50-0x0000000189B0DD90
	// [XID] // 0x0000000189B0DD50-0x0000000189B0DD90
	public virtual void AutoRecycleTypeFields() {} // 0x000000018341B6B0-0x000000018341B7E0
	[BlackList] // 0x0000000189B181A0-0x0000000189B181E0
	// [XID] // 0x0000000189B181A0-0x0000000189B181E0
	public virtual void ReturnToObjectPool() {} // 0x000000018341DF90-0x000000018341E030
	[BlackList] // 0x0000000189B22850-0x0000000189B22890
	// [XID] // 0x0000000189B22850-0x0000000189B22890
	public virtual void OnPoolAllocated() {} // 0x000000018341DDA0-0x000000018341DE40
	[BlackList] // 0x0000000189B2CBB0-0x0000000189B2CBF0
	// [XID] // 0x0000000189B2CBB0-0x0000000189B2CBF0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018341DD00-0x000000018341DDA0
}

