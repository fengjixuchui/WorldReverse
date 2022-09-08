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
public class ConfigGlobalCollision : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18096
{
	// Fields
	private SimpleSafeFloat highSpdThresholdRawNum; // 0x10

	// Properties
	public float highSpdThreshold { /* [XID] */ /* 0x000000018961D870-0x000000018961D890 */ get => default; /* [XID] */ /* 0x0000000189624CB0-0x0000000189624CD0 */ private set {} } // 0x0000000181E07210-0x0000000181E072F0 0x0000000181E07670-0x0000000181E07750

	// Constructors
	public ConfigGlobalCollision() {} // 0x0000000181E07FA0-0x0000000181E08000

	// Methods
	// [XID] // 0x000000018962C450-0x000000018962C470
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181E07CD0-0x0000000181E07DC0
	// [XID] // 0x0000000189634010-0x0000000189634030
	public void InitEmpty() {} // 0x0000000181E07750-0x0000000181E07820
	[BlackList] // 0x000000018963B840-0x000000018963B880
	// [XID] // 0x000000018963B840-0x000000018963B880
	public bool FromJson(JSONNode node) => default; // 0x0000000181E072F0-0x0000000181E07670
	// [XID] // 0x0000000189645EA0-0x0000000189645EC0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181E06990-0x0000000181E06BC0
	// [XID] // 0x000000018964D7C0-0x000000018964D7E0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8AD7 */, bool useObjectPool = false /* Metadata: 0x00AF8ADB */) => default; // 0x0000000181E07820-0x0000000181E07B20
	// [XID] // 0x0000000189654F60-0x0000000189654F80
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8ADC */, bool useObjectPool = false /* Metadata: 0x00AF8AE0 */) => default; // 0x0000000181E07000-0x0000000181E07210
	[BlackList] // 0x000000018965C740-0x000000018965C780
	// [XID] // 0x000000018965C740-0x000000018965C780
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181E06BC0-0x0000000181E06E90
	// [XID] // 0x0000000189666E10-0x0000000189666E30
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181E07B20-0x0000000181E07CD0
	[BlackList] // 0x000000018966E580-0x000000018966E5C0
	// [XID] // 0x000000018966E580-0x000000018966E5C0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181E06E90-0x0000000181E06F30
	[BlackList] // 0x0000000189679470-0x00000001896794B0
	// [XID] // 0x0000000189679470-0x00000001896794B0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181E06F30-0x0000000181E07000
	[BlackList] // 0x00000001896838F0-0x0000000189683930
	// [XID] // 0x00000001896838F0-0x0000000189683930
	public virtual void ReturnToObjectPool() {} // 0x0000000181E07F00-0x0000000181E07FA0
	[BlackList] // 0x000000018968E750-0x000000018968E790
	// [XID] // 0x000000018968E750-0x000000018968E790
	public virtual void OnPoolAllocated() {} // 0x0000000181E07E60-0x0000000181E07F00
	[BlackList] // 0x0000000189698F00-0x0000000189698F40
	// [XID] // 0x0000000189698F00-0x0000000189698F40
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181E07DC0-0x0000000181E07E60
}

