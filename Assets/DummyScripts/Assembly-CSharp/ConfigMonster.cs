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
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigMonster : ConfigCharacter, IAutoAllocRecycle // TypeDefIndex: 18028
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigMonsterInitialPose> _initialPoses; // 0x98
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIBeta _aibeta; // 0xA0
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigKeyInput[] _inputKeys; // 0xA8
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigMove _move; // 0xB0
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigMonsterAudio _audio; // 0xB8
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigEmojiBubble _emojiBubble; // 0xC0
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCharacterRendering _characterRendering; // 0xC8
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAnimal _animal; // 0xD0
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigSpecialCamera _cameraAdjust; // 0xD8
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigTrigger _field; // 0xE0

	// Properties
	public Dictionary<string, ConfigMonsterInitialPose> initialPoses { /* [XID] */ /* 0x0000000189A8C350-0x0000000189A8C370 */ get => default; /* [XID] */ /* 0x0000000189A93830-0x0000000189A93850 */ private set {} } // 0x00000001822E2320-0x00000001822E23D0 0x00000001822E3480-0x00000001822E3530
	public ConfigAIBeta aibeta { /* [XID] */ /* 0x0000000189A9B440-0x0000000189A9B460 */ get => default; /* [XID] */ /* 0x0000000189AA2760-0x0000000189AA2780 */ private set {} } // 0x00000001822E2B80-0x00000001822E2C30 0x00000001822E19C0-0x00000001822E1A70
	public ConfigKeyInput[] inputKeys { /* [XID] */ /* 0x0000000189AA9C80-0x0000000189AA9CA0 */ get => default; /* [XID] */ /* 0x0000000189AB1C00-0x0000000189AB1C20 */ private set {} } // 0x00000001822E3530-0x00000001822E35E0 0x00000001822DF870-0x00000001822DF920
	public ConfigMove move { /* [XID] */ /* 0x0000000189AB8F10-0x0000000189AB8F30 */ get => default; /* [XID] */ /* 0x0000000189AC09F0-0x0000000189AC0A10 */ private set {} } // 0x00000001822E2680-0x00000001822E2730 0x00000001822E1CF0-0x00000001822E1DA0
	public ConfigMonsterAudio audio { /* [XID] */ /* 0x0000000189AC83D0-0x0000000189AC83F0 */ get => default; /* [XID] */ /* 0x0000000189ACFB90-0x0000000189ACFBB0 */ private set {} } // 0x00000001822E1E90-0x00000001822E1F40 0x00000001822E18A0-0x00000001822E1950
	public ConfigEmojiBubble emojiBubble { /* [XID] */ /* 0x0000000189AD7860-0x0000000189AD7880 */ get => default; /* [XID] */ /* 0x0000000189ADF370-0x0000000189ADF390 */ private set {} } // 0x00000001822E2AD0-0x00000001822E2B80 0x00000001822E3870-0x00000001822E3920
	public ConfigCharacterRendering characterRendering { /* [XID] */ /* 0x0000000189AE6B90-0x0000000189AE6BB0 */ get => default; /* [XID] */ /* 0x0000000189AEE6C0-0x0000000189AEE6E0 */ private set {} } // 0x00000001822E04F0-0x00000001822E05A0 0x00000001822E1250-0x00000001822E1300
	public ConfigAnimal animal { /* [XID] */ /* 0x0000000189AF5C30-0x0000000189AF5C50 */ get => default; /* [XID] */ /* 0x0000000189AFD1B0-0x0000000189AFD1D0 */ private set {} } // 0x00000001822E2970-0x00000001822E2A20 0x00000001822DFBF0-0x00000001822DFCA0
	public ConfigSpecialCamera cameraAdjust { /* [XID] */ /* 0x0000000189B049A0-0x0000000189B049C0 */ get => default; /* [XID] */ /* 0x0000000189B0C190-0x0000000189B0C1B0 */ private set {} } // 0x00000001822E10A0-0x00000001822E1150 0x00000001822E2A20-0x00000001822E2AD0
	public ConfigTrigger field { /* [XID] */ /* 0x0000000189B13710-0x0000000189B13730 */ get => default; /* [XID] */ /* 0x0000000189B1AE00-0x0000000189B1AE20 */ private set {} } // 0x00000001822E03E0-0x00000001822E0490 0x00000001822E05A0-0x00000001822E0650

	// Constructors
	public ConfigMonster() {} // 0x00000001822E39C0-0x00000001822E3A20

	// Methods
	// [XID] // 0x0000000189B22430-0x0000000189B22450
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001822E35E0-0x00000001822E3870
	// [XID] // 0x0000000189B29940-0x0000000189B29960
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001822E2790-0x00000001822E2970
	// [XID] // 0x0000000189B30F30-0x0000000189B30F50
	public override ConfigEntity Clone(bool useObjectPool = false /* Metadata: 0x00AF8727 */) => default; // 0x00000001822E2240-0x00000001822E2320
	// [XID] // 0x0000000189B385F0-0x0000000189B38610
	public override int GetHashNum() => default; // 0x00000001822E0310-0x00000001822E03E0
	// [XID] // 0x0000000189B40080-0x0000000189B400A0
	public override void InitEmpty() {} // 0x00000001822E1A70-0x00000001822E1C10
	[BlackList] // 0x0000000189B478E0-0x0000000189B47920
	// [XID] // 0x0000000189B478E0-0x0000000189B47920
	public override bool FromJson(JSONNode node) => default; // 0x00000001822E1300-0x00000001822E1680
	// [XID] // 0x0000000189B52000-0x0000000189B52020
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001822DEDC0-0x00000001822DF870
	[BlackList] // 0x0000000189B59900-0x0000000189B59940
	// [XID] // 0x0000000189B59900-0x0000000189B59940
	public static new ConfigMonster ParseFromJson(JSONNode node) => default; // 0x00000001822E2430-0x00000001822E2680
	// [XID] // 0x0000000189B64030-0x0000000189B64050
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8728 */, bool useObjectPool = false /* Metadata: 0x00AF872C */) => default; // 0x00000001822E1F40-0x00000001822E2240
	// [XID] // 0x0000000189B6B7D0-0x0000000189B6B7F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF872D */, bool useObjectPool = false /* Metadata: 0x00AF8731 */) => default; // 0x00000001822E06D0-0x00000001822E10A0
	// [XID] // 0x0000000189B72DD0-0x0000000189B72DF0
	public static new ConfigMonster ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8732 */, bool useObjectPool = false /* Metadata: 0x00AF8736 */) => default; // 0x00000001822E1680-0x00000001822E18A0
	[BlackList] // 0x0000000189B7A390-0x0000000189B7A3D0
	// [XID] // 0x0000000189B7A390-0x0000000189B7A3D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001822DF920-0x00000001822DFBF0
	// [XID] // 0x0000000189B84F50-0x0000000189B84F70
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001822E2C30-0x00000001822E3480
	[BlackList] // 0x0000000189B8BDA0-0x0000000189B8BDE0
	// [XID] // 0x0000000189B8BDA0-0x0000000189B8BDE0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001822E1DA0-0x00000001822E1E90
	[BlackList] // 0x0000000189B96300-0x0000000189B96340
	// [XID] // 0x0000000189B96300-0x0000000189B96340
	public override void AutoAllocTypeFields() {} // 0x00000001822DFCA0-0x00000001822DFD40
	[BlackList] // 0x0000000189BA07F0-0x0000000189BA0830
	// [XID] // 0x0000000189BA07F0-0x0000000189BA0830
	public override void AutoRecycleTypeFields() {} // 0x00000001822DFD40-0x00000001822E01F0
	[BlackList] // 0x0000000189BAAEC0-0x0000000189BAAF00
	// [XID] // 0x0000000189BAAEC0-0x0000000189BAAF00
	public override void ReturnToObjectPool() {} // 0x00000001822E3920-0x00000001822E39C0
}

