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
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigAvatarControllerAssembly : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17734
{
	// Fields
	private string _controllerPath; // 0x10
	private string _normalMoveSubs; // 0x18
	private string _weaponMoveSubs; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAvatarControllerAssemblySkillSubs _skillSubs; // 0x28

	// Properties
	public string controllerPath { /* [XID] */ /* 0x000000018961C200-0x000000018961C220 */ get => default; /* [XID] */ /* 0x0000000189623640-0x0000000189623660 */ private set {} } // 0x0000000184AB21B0-0x0000000184AB2250 0x0000000184AB28F0-0x0000000184AB29A0
	public string normalMoveSubs { /* [XID] */ /* 0x000000018962AF80-0x000000018962AFA0 */ get => default; /* [XID] */ /* 0x00000001896326E0-0x0000000189632700 */ private set {} } // 0x0000000184AB29A0-0x0000000184AB2A40 0x0000000184AB1BA0-0x0000000184AB1C50
	public string weaponMoveSubs { /* [XID] */ /* 0x000000018963A170-0x000000018963A190 */ get => default; /* [XID] */ /* 0x0000000189641760-0x0000000189641780 */ private set {} } // 0x0000000184AB25C0-0x0000000184AB2660 0x0000000184AB2050-0x0000000184AB2100
	public ConfigAvatarControllerAssemblySkillSubs skillSubs { /* [XID] */ /* 0x00000001896490E0-0x0000000189649100 */ get => default; /* [XID] */ /* 0x0000000189650710-0x0000000189650730 */ private set {} } // 0x0000000184AB1780-0x0000000184AB1820 0x0000000184AB2100-0x0000000184AB21B0

	// Constructors
	public ConfigAvatarControllerAssembly() {} // 0x0000000184AB2AE0-0x0000000184AB2B40

	// Methods
	// [XID] // 0x0000000189658070-0x0000000189658090
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184AB2660-0x0000000184AB27B0
	// [XID] // 0x000000018965F5C0-0x000000018965F5E0
	public void InitEmpty() {} // 0x0000000184AB1C50-0x0000000184AB1D50
	[BlackList] // 0x0000000189666F10-0x0000000189666F50
	// [XID] // 0x0000000189666F10-0x0000000189666F50
	public bool FromJson(JSONNode node) => default; // 0x0000000184AB1820-0x0000000184AB1BA0
	// [XID] // 0x0000000189671CE0-0x0000000189671D00
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184AB0A30-0x0000000184AB0EC0
	// [XID] // 0x0000000189679550-0x0000000189679570
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7A23 */, bool useObjectPool = false /* Metadata: 0x00AF7A27 */) => default; // 0x0000000184AB1D50-0x0000000184AB2050
	// [XID] // 0x0000000189680C40-0x0000000189680C60
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7A28 */, bool useObjectPool = false /* Metadata: 0x00AF7A2C */) => default; // 0x0000000184AB1360-0x0000000184AB1780
	[BlackList] // 0x00000001896886A0-0x00000001896886E0
	// [XID] // 0x00000001896886A0-0x00000001896886E0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184AB0EC0-0x0000000184AB1190
	// [XID] // 0x00000001896932E0-0x0000000189693300
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184AB2250-0x0000000184AB25C0
	[BlackList] // 0x000000018969A550-0x000000018969A590
	// [XID] // 0x000000018969A550-0x000000018969A590
	public virtual void AutoAllocTypeFields() {} // 0x0000000184AB1190-0x0000000184AB1230
	[BlackList] // 0x00000001896A4920-0x00000001896A4960
	// [XID] // 0x00000001896A4920-0x00000001896A4960
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184AB1230-0x0000000184AB1360
	[BlackList] // 0x00000001896AEE30-0x00000001896AEE70
	// [XID] // 0x00000001896AEE30-0x00000001896AEE70
	public virtual void ReturnToObjectPool() {} // 0x0000000184AB2A40-0x0000000184AB2AE0
	[BlackList] // 0x00000001896B9270-0x00000001896B92B0
	// [XID] // 0x00000001896B9270-0x00000001896B92B0
	public virtual void OnPoolAllocated() {} // 0x0000000184AB2850-0x0000000184AB28F0
	[BlackList] // 0x00000001896C3540-0x00000001896C3580
	// [XID] // 0x00000001896C3540-0x00000001896C3580
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184AB27B0-0x0000000184AB2850
}

