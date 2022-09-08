/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using behaviac;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.UAuto
{
	public sealed class CharacterAgent : Agent // TypeDefIndex: 27189
	{
		// Fields
		private AttackState attackState; // 0x58
		private uint attackTargetId; // 0x5C
		public float findMonsterRange; // 0x60
		private bool isInit; // 0x64
		public int maxNoFoundCount; // 0x68
		public bool needRecovery; // 0x6C
		private int noFoundCount; // 0x70
		private int normalAttackTime; // 0x74
		private int Skill1CDTime; // 0x78
		private int skill2CDTime; // 0x7C
		private int skill4CDTime; // 0x80
		public int skillTime; // 0x84
		private AvatarEntity _avatarEntity; // 0x88
		private LCAvatarCombat _lcAvatarCombat; // 0x90
		private VCAvatarCombat _vcAvatarCombat; // 0x98
		private VCBaseMove _avatarVM; // 0xA0
		private VCLocalInputController _avatarVCBaseInput; // 0xA8
		private int firstIndex; // 0xB0
		private MonsterEntity targetMonster; // 0xB8
		private Vector3 beginPos; // 0xC0
		private uint skillId; // 0xCC
		private Vector3 beginMonsterPos; // 0xD0
		private GameManager gameManager; // 0xE0
		public int skillMask; // 0xE8
		public float attackRange; // 0xEC
		private Vector3 lastAvatarPos; // 0xF0
		private float recordDistTime; // 0xFC
		private float recordDistDeltaTime; // 0x100
		private EBTStatus _status; // 0x104
	
		// Properties
		private AvatarEntity avatarEntity { get => default; set {} } // 0x000000018105AB80-0x000000018105ABF0 0x000000018105ADF0-0x000000018105AE60
		private VCAvatarCombat vcAvatarCombat { get => default; set {} } // 0x000000018105AD70-0x000000018105ADF0 0x000000018105AFB0-0x000000018105B020
		private LCAvatarCombat lcAvatarCombat { get => default; set {} } // 0x000000018105ACF0-0x000000018105AD70 0x000000018105AF40-0x000000018105AFB0
		private VCBaseMove avatarVM { get => default; set {} } // 0x000000018105AC70-0x000000018105ACF0 0x000000018105AED0-0x000000018105AF40
		private VCLocalInputController avatarVCBaseInput { get => default; set {} } // 0x000000018105ABF0-0x000000018105AC70 0x000000018105AE60-0x000000018105AED0
	
		// Constructors
		public CharacterAgent() {} // 0x000000018105A440-0x000000018105A570
	
		// Methods
		public void _set_attackState(AttackState value) {} // 0x000000018105A8D0-0x000000018105A930
		public AttackState _get_attackState() => default; // 0x000000018105A5D0-0x000000018105A630
		public void _set_attackTargetId(uint value) {} // 0x000000018105A930-0x000000018105A990
		public uint _get_attackTargetId() => default; // 0x000000018105A630-0x000000018105A690
		public void _set_isInit(bool value) {} // 0x000000018105A990-0x000000018105A9F0
		public bool _get_isInit() => default; // 0x000000018105A690-0x000000018105A6F0
		public void _set_noFoundCount(int value) {} // 0x000000018105A9F0-0x000000018105AA50
		public int _get_noFoundCount() => default; // 0x000000018105A6F0-0x000000018105A750
		public void _set_normalAttackTime(int value) {} // 0x000000018105AA50-0x000000018105AAB0
		public int _get_normalAttackTime() => default; // 0x000000018105A750-0x000000018105A7B0
		public void _set_Skill1CDTime(int value) {} // 0x000000018105A870-0x000000018105A8D0
		public int _get_Skill1CDTime() => default; // 0x000000018105A570-0x000000018105A5D0
		public void _set_skill2CDTime(int value) {} // 0x000000018105AAB0-0x000000018105AB10
		public int _get_skill2CDTime() => default; // 0x000000018105A7B0-0x000000018105A810
		public void _set_skill4CDTime(int value) {} // 0x000000018105AB10-0x000000018105AB80
		public int _get_skill4CDTime() => default; // 0x000000018105A810-0x000000018105A870
		public EBTStatus AttackTarget() => default; // 0x0000000181056320-0x0000000181056370
		public void BeginCastSkill() {} // 0x0000000181056370-0x0000000181056400
		public bool CanCastSkill(int skillIndex) => default; // 0x0000000181056400-0x0000000181056480
		public EBTStatus CanDoSkill() => default; // 0x0000000181056480-0x0000000181056520
		public EBTStatus ChangeNextAvatar() => default; // 0x0000000181056520-0x00000001810566B0
		public void DoSkill() {} // 0x00000001810567F0-0x0000000181056880
		public void EndCastSkill() {} // 0x0000000181056880-0x0000000181056910
		public void FaceToForward() {} // 0x0000000181056910-0x0000000181056C90
		public bool FoundNearByEntity(float circle) => default; // 0x0000000181056C90-0x0000000181057580
		public EBTStatus InitPlayerAvatar() => default; // 0x0000000181057960-0x0000000181057BB0
		public bool IsPlayerAlive() => default; // 0x0000000181057D50-0x0000000181057E70
		public bool IsPlayerOutOfRange(float range) => default; // 0x0000000181057E70-0x0000000181058050
		public bool IsTargetMonsterAlive() => default; // 0x0000000181058050-0x00000001810580F0
		public bool IsTargetMonterInRange() => default; // 0x00000001810580F0-0x0000000181058290
		public EBTStatus Jump() => default; // 0x0000000181058290-0x0000000181058440
		public void KillTargetMonster() {} // 0x0000000181058440-0x0000000181058530
		public void MonsterAI(bool isOpen) {} // 0x0000000181058530-0x00000001810585C0
		public void MonsterGod(bool MonsterDebugInv) {} // 0x00000001810585C0-0x0000000181058710
		public bool MonsterIsOutInitPos(float range) => default; // 0x0000000181058710-0x0000000181058840
		public void MonsterReturnToInitePos() {} // 0x0000000181058840-0x0000000181058960
		public EBTStatus MoveToInitePos() => default; // 0x0000000181058960-0x0000000181058E40
		public EBTStatus MoveToTargetMonster() => default; // 0x0000000181058E40-0x0000000181059550
		public EBTStatus PickItems() => default; // 0x0000000181059550-0x00000001810595A0
		public void RecordInitePos() {} // 0x00000001810595A0-0x00000001810596E0
		public void RecordMonsterPos() {} // 0x00000001810596E0-0x0000000181059780
		public void RecoveryCharacter() {} // 0x0000000181059780-0x0000000181059830
		public void ReturnToInitePos() {} // 0x0000000181059C90-0x0000000181059E30
		public void ReturnToInitePosXZ() {} // 0x0000000181059A80-0x0000000181059C90
		public void RunGM(string value) {} // 0x0000000181059E30-0x0000000181059EC0
		public void Say(string value) {} // 0x0000000181059EC0-0x0000000181059F50
		public void SetAttackTarget(uint targetId) {} // 0x0000000181059F50-0x000000018105A040
		public void SetCastSkill(int skillIndex) {} // 0x000000018105A040-0x000000018105A130
		public void SetSkillNoCD(bool isOn) {} // 0x000000018105A130-0x000000018105A1C0
		public void Stop() {} // 0x000000018105A1C0-0x000000018105A230
		public EBTStatus WaitLevelLoaded() => default; // 0x000000018105A2B0-0x000000018105A440
		private void CheckLocalAvatar() {} // 0x00000001810566B0-0x00000001810567F0
		public float GetMonsterDist() => default; // 0x0000000181057580-0x0000000181057960
		public bool IsMonsterInvalid(BaseEntity monster) => default; // 0x0000000181057BB0-0x0000000181057D50
		public void ResetPlayerAvatar() {} // 0x0000000181059830-0x0000000181059A80
		public EBTStatus Update() => default; // 0x000000018105A230-0x000000018105A2B0
	}
}
