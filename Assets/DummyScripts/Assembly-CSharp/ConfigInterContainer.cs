/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigInterContainer : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18375
{
	// Fields
	private string _luaDataPath; // 0x10
	private bool _isSimpleTalk; // 0x18
	private bool _dontUseDefaultFinish; // 0x19
	private bool _attackModeRecover; // 0x1A
	private bool _pauseActor; // 0x1B
	private bool _hidePickableEntity; // 0x1C
	private float _startBlackKeepTime; // 0x20
	private string _entityBan; // 0x28
	private bool _isKeyInteraction; // 0x30
	private bool _disableNpcLod; // 0x31
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigInterFade _startFade; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigInterFade _endFade; // 0x40
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigInterActor[] _actors; // 0x48
	private ConfigBaseInterAction[][] _group; // 0x50
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigInterGrpId[] _groupId; // 0x58
	private Dictionary<uint, int[]> _freeStyleDic; // 0x60

	// Properties
	public string luaDataPath { /* [XID] */ /* 0x00000001896838B0-0x00000001896838D0 */ get => default; /* [XID] */ /* 0x000000018968B590-0x000000018968B5B0 */ private set {} } // 0x00000001842070D0-0x0000000184207170 0x0000000184203A40-0x0000000184203AF0
	public bool isSimpleTalk { /* [XID] */ /* 0x00000001896931E0-0x0000000189693200 */ get => default; /* [XID] */ /* 0x000000018969A3D0-0x000000018969A3F0 */ private set {} } // 0x0000000184203AF0-0x0000000184203B90 0x0000000184206B30-0x0000000184206BE0
	public bool dontUseDefaultFinish { /* [XID] */ /* 0x00000001897FE710-0x00000001897FE730 */ get => default; /* [XID] */ /* 0x00000001896A90E0-0x00000001896A9100 */ private set {} } // 0x00000001842067E0-0x0000000184206880 0x0000000184205E40-0x0000000184205EF0
	public bool attackModeRecover { /* [XID] */ /* 0x0000000189BCB460-0x0000000189BCB480 */ get => default; /* [XID] */ /* 0x00000001896B7B70-0x00000001896B7B90 */ private set {} } // 0x0000000184207EE0-0x0000000184207F80 0x00000001842051D0-0x0000000184205280
	public bool pauseActor { /* [XID] */ /* 0x00000001896BEB30-0x00000001896BEB50 */ get => default; /* [XID] */ /* 0x00000001896C6550-0x00000001896C6570 */ private set {} } // 0x0000000184205DA0-0x0000000184205E40 0x0000000184206BE0-0x0000000184206C90
	public bool hidePickableEntity { /* [XID] */ /* 0x00000001897EFA50-0x00000001897EFA70 */ get => default; /* [XID] */ /* 0x00000001896D50E0-0x00000001896D5100 */ private set {} } // 0x0000000184206F90-0x0000000184207030 0x0000000184205FA0-0x0000000184206050
	public float startBlackKeepTime { /* [XID] */ /* 0x000000018992CF60-0x000000018992CF80 */ get => default; /* [XID] */ /* 0x00000001896E3F30-0x00000001896E3F50 */ private set {} } // 0x0000000184206930-0x00000001842069E0 0x0000000184206880-0x0000000184206930
	public string entityBan { /* [XID] */ /* 0x00000001896EB380-0x00000001896EB3A0 */ get => default; /* [XID] */ /* 0x00000001896F26F0-0x00000001896F2710 */ private set {} } // 0x0000000184208360-0x0000000184208400 0x00000001842065D0-0x0000000184206680
	public bool isKeyInteraction { /* [XID] */ /* 0x00000001896FA030-0x00000001896FA050 */ get => default; /* [XID] */ /* 0x0000000189701840-0x0000000189701860 */ private set {} } // 0x0000000184207170-0x0000000184207210 0x0000000184205080-0x0000000184205130
	public bool disableNpcLod { /* [XID] */ /* 0x00000001897090C0-0x00000001897090E0 */ get => default; /* [XID] */ /* 0x0000000189710990-0x00000001897109B0 */ private set {} } // 0x0000000184207030-0x00000001842070D0 0x0000000184206100-0x00000001842061B0
	public ConfigInterFade startFade { /* [XID] */ /* 0x0000000189717CF0-0x0000000189717D10 */ get => default; /* [XID] */ /* 0x000000018971F730-0x000000018971F750 */ private set {} } // 0x0000000184207210-0x00000001842072B0 0x0000000184206050-0x0000000184206100
	public ConfigInterFade endFade { /* [XID] */ /* 0x0000000189726D00-0x0000000189726D20 */ get => default; /* [XID] */ /* 0x000000018972E2B0-0x000000018972E2D0 */ private set {} } // 0x0000000184205130-0x00000001842051D0 0x0000000184206730-0x00000001842067E0
	public ConfigInterActor[] actors { /* [XID] */ /* 0x0000000189A3A290-0x0000000189A3A2B0 */ get => default; /* [XID] */ /* 0x000000018973D510-0x000000018973D530 */ private set {} } // 0x0000000184204C20-0x0000000184204CC0 0x0000000184204CC0-0x0000000184204D70
	public ConfigBaseInterAction[][] group { /* [XID] */ /* 0x0000000189744990-0x00000001897449B0 */ get => default; /* [XID] */ /* 0x000000018974C6E0-0x000000018974C700 */ private set {} } // 0x00000001842061B0-0x0000000184206250 0x0000000184206680-0x0000000184206730
	public ConfigInterGrpId[] groupId { /* [XID] */ /* 0x00000001897D1400-0x00000001897D1420 */ get => default; /* [XID] */ /* 0x000000018975AF60-0x000000018975AF80 */ private set {} } // 0x00000001842072B0-0x0000000184207350 0x0000000184207350-0x0000000184207400
	public Dictionary<uint, int[]> freeStyleDic { /* [XID] */ /* 0x0000000189A12530-0x0000000189A12550 */ get => default; /* [XID] */ /* 0x0000000189769F10-0x0000000189769F30 */ private set {} } // 0x0000000184204FE0-0x0000000184205080 0x0000000184205EF0-0x0000000184205FA0

	// Constructors
	public ConfigInterContainer() {} // 0x00000001842084A0-0x0000000184208520

	// Methods
	// [XID] // 0x0000000189771710-0x0000000189771730
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184207F80-0x0000000184208220
	// [XID] // 0x0000000189778E80-0x0000000189778EA0
	public void InitEmpty() {} // 0x00000001842069E0-0x0000000184206B30
	[BlackList] // 0x0000000189780540-0x0000000189780580
	// [XID] // 0x0000000189780540-0x0000000189780580
	public bool FromJson(JSONNode node) => default; // 0x0000000184206250-0x00000001842065D0
	// [XID] // 0x000000018978AD60-0x000000018978AD80
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184203B90-0x0000000184204950
	// [XID] // 0x000000018992CF80-0x000000018992CFA0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF969F */, bool useObjectPool = false /* Metadata: 0x00AF96A3 */) => default; // 0x0000000184206C90-0x0000000184206F90
	// [XID] // 0x0000000189934650-0x0000000189934670
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF96A4 */, bool useObjectPool = false /* Metadata: 0x00AF96A8 */) => default; // 0x0000000184205280-0x0000000184205DA0
	[BlackList] // 0x00000001897A1740-0x00000001897A1780
	// [XID] // 0x00000001897A1740-0x00000001897A1780
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184204950-0x0000000184204C20
	// [XID] // 0x00000001897ABE60-0x00000001897ABE80
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184207400-0x0000000184207EE0
	[BlackList] // 0x00000001897B3DF0-0x00000001897B3E30
	// [XID] // 0x00000001897B3DF0-0x00000001897B3E30
	public virtual void AutoAllocTypeFields() {} // 0x0000000184204D70-0x0000000184204E10
	[BlackList] // 0x00000001897BEE70-0x00000001897BEEB0
	// [XID] // 0x00000001897BEE70-0x00000001897BEEB0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184204E10-0x0000000184204FE0
	[BlackList] // 0x00000001897C9560-0x00000001897C95A0
	// [XID] // 0x00000001897C9560-0x00000001897C95A0
	public virtual void ReturnToObjectPool() {} // 0x0000000184208400-0x00000001842084A0
	[BlackList] // 0x00000001897D3A60-0x00000001897D3AA0
	// [XID] // 0x00000001897D3A60-0x00000001897D3AA0
	public virtual void OnPoolAllocated() {} // 0x00000001842082C0-0x0000000184208360
	[BlackList] // 0x00000001897DE1D0-0x00000001897DE210
	// [XID] // 0x00000001897DE1D0-0x00000001897DE210
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184208220-0x00000001842082C0
}

