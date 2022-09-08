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
public class BaseTalentConfig : IAutoAllocRecycle // TypeDefIndex: 14844
{
	// Fields
	protected string _openConfig; // 0x10
	protected PropValConfig[] _addProps; // 0x18
	protected SimpleSafeFloat[] _paramList; // 0x20

	// Properties
	public virtual uint talentSkillID { /* [XID] */ /* 0x0000000189A91130-0x0000000189A91150 */ get => default; } // 0x0000000184FB19A0-0x0000000184FB1A40 
	public string openConfig { /* [XID] */ /* 0x00000001896CB4F0-0x00000001896CB510 */ get => default; /* [XID] */ /* 0x0000000189A9FE50-0x0000000189A9FE70 */ protected set {} } // 0x0000000184FB12C0-0x0000000184FB1360 0x0000000184FB1E50-0x0000000184FB1F00
	public PropValConfig[] addProps { /* [XID] */ /* 0x00000001899E5DE0-0x00000001899E5E00 */ get => default; /* [XID] */ /* 0x0000000189AAECC0-0x0000000189AAECE0 */ protected set {} } // 0x0000000184FB1F00-0x0000000184FB1FA0 0x0000000184FB18F0-0x0000000184FB19A0
	public SimpleSafeFloat[] paramList { /* [XID] */ /* 0x0000000189AB6680-0x0000000189AB66A0 */ get => default; /* [XID] */ /* 0x0000000189ABE1B0-0x0000000189ABE1D0 */ protected set {} } // 0x0000000184FB1360-0x0000000184FB1400 0x0000000184FB1840-0x0000000184FB18F0

	// Constructors
	public BaseTalentConfig() {} // 0x0000000184FB2180-0x0000000184FB21E0

	// Methods
	// [XID] // 0x0000000189AC5D50-0x0000000189AC5D70
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184FB1400-0x0000000184FB1840
	// [XID] // 0x0000000189ACD280-0x0000000189ACD2A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF7A2 */, bool useObjectPool = false /* Metadata: 0x00AEF7A6 */) => default; // 0x0000000184FB1A40-0x0000000184FB1E50
	[BlackList] // 0x0000000189AD5040-0x0000000189AD5080
	// [XID] // 0x0000000189AD5040-0x0000000189AD5080
	public virtual void AutoAllocTypeFields() {} // 0x0000000184FB1170-0x0000000184FB1210
	[BlackList] // 0x0000000189ADFAF0-0x0000000189ADFB30
	// [XID] // 0x0000000189ADFAF0-0x0000000189ADFB30
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184FB1210-0x0000000184FB12C0
	[BlackList] // 0x0000000189AE9F10-0x0000000189AE9F50
	// [XID] // 0x0000000189AE9F10-0x0000000189AE9F50
	public virtual void ReturnToObjectPool() {} // 0x0000000184FB20E0-0x0000000184FB2180
	[BlackList] // 0x0000000189AF4990-0x0000000189AF49D0
	// [XID] // 0x0000000189AF4990-0x0000000189AF49D0
	public virtual void OnPoolAllocated() {} // 0x0000000184FB2040-0x0000000184FB20E0
	[BlackList] // 0x0000000189AFF090-0x0000000189AFF0D0
	// [XID] // 0x0000000189AFF090-0x0000000189AFF0D0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184FB1FA0-0x0000000184FB2040
}

