/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoArenaChallengeRewardListRow : MonoReusableListItem // TypeDefIndex: 30366
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtDesc; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _completeMask; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _complete; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _inprogress; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _fetchBtn; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _rewardReusableList; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoJoypadSimpleResuableListHandler _joypadRewardListHandler; // 0x58
		private state _curState; // 0x60
		private List<RewardItemConfig> _rewardList; // 0x68
	
		// Properties
		public Animator animator { /* [XID] */ /* 0x000000018986DD80-0x000000018986DDA0 */ get => default; } // 0x0000000184C94FB0-0x0000000184C95050 
		public UnityEngine.UI.Text txtDesc { /* [XID] */ /* 0x0000000189875120-0x0000000189875140 */ get => default; } // 0x0000000184C954B0-0x0000000184C95550 
		public GameObject completeMask { /* [XID] */ /* 0x000000018987CD90-0x000000018987CDB0 */ get => default; } // 0x0000000184C95050-0x0000000184C950F0 
		public GameObject complete { /* [XID] */ /* 0x0000000189883D30-0x0000000189883D50 */ get => default; } // 0x0000000184C950F0-0x0000000184C95190 
		public GameObject inprogress { /* [XID] */ /* 0x000000018988B3D0-0x000000018988B3F0 */ get => default; } // 0x0000000184C952D0-0x0000000184C95370 
		public MonoUIContainer fetchBtn { /* [XID] */ /* 0x0000000189892B10-0x0000000189892B30 */ get => default; } // 0x0000000184C95230-0x0000000184C952D0 
		public MonoSimpleReusableList rewardReusableList { /* [XID] */ /* 0x000000018989A190-0x000000018989A1B0 */ get => default; } // 0x0000000184C95410-0x0000000184C954B0 
		public MonoJoypadSimpleResuableListHandler joypadRewardListHandler { /* [XID] */ /* 0x00000001898A1450-0x00000001898A1470 */ get => default; } // 0x0000000184C95370-0x0000000184C95410 
		public state curState { /* [XID] */ /* 0x00000001898B0640-0x00000001898B0660 */ get => default; } // 0x0000000184C95190-0x0000000184C95230 
		public bool highLighted { /* [XID] */ /* 0x00000001898CE160-0x00000001898CE180 */ set {} } // 0x0000000184C95550-0x0000000184C95680
	
		// Nested types
		public enum state // TypeDefIndex: 30367
		{
			Inprogress = 0,
			ReadyToClaim = 1,
			Finished = 2
		}
	
		// Constructors
		public MonoArenaChallengeRewardListRow() {} // 0x0000000184C94F20-0x0000000184C94FB0
	
		// Methods
		// [XID] // 0x00000001898A8CC0-0x00000001898A8CE0
		public void SetState(state targetState) {} // 0x0000000184C94C70-0x0000000184C94F20
		// [XID] // 0x00000001898B7C30-0x00000001898B7C50
		public void RefreshState(uint watcherId) {} // 0x0000000184C94640-0x0000000184C94C70
		// [XID] // 0x00000001898BF200-0x00000001898BF220
		private void OnSetSelectChange(Transform prevItem, int prevIndex, Transform curItem, int curIndex) {} // 0x0000000184C94320-0x0000000184C94640
		// [XID] // 0x00000001898C6BA0-0x00000001898C6BC0
		private void InitRewardItem(Transform trans, int index) {} // 0x0000000184C93F80-0x0000000184C94320
	}
}
