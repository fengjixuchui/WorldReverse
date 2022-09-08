/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoActivityFlightChallengeSettle : MonoUIProxy // TypeDefIndex: 30340
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _scoreText; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _timeText; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _collectText; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _tipsText; // 0x60
		// [Header] // 0x00000001896B0E90-0x00000001896B0EE0
		[SerializeField] // 0x00000001896B0E90-0x00000001896B0EE0
		private float _timeBeginEvent; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _timeCollectEvent; // 0x6C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int _leftAnimCount; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _leftTimeAnimDelta; // 0x74
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _collectAnimDeltaTime; // 0x78
		// [Header] // 0x00000001896DA910-0x00000001896DA960
		[SerializeField] // 0x00000001896DA910-0x00000001896DA960
		private Transform _medal1; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _medal2; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _medal3; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _newTag; // 0x98
		private int SuccessHash; // 0xA0
		public Action onScoreBegin; // 0xA8
		public Action onCollectBegin; // 0xB0
		private bool _isSuccess; // 0xB8
		private bool _triggerLeftTimeEvent; // 0xB9
		private bool _triggerCollectEvent; // 0xBA
		private float _timer; // 0xBC
	
		// Properties
		public UnityEngine.UI.Text scoreText { /* [XID] */ /* 0x00000001896FB1E0-0x00000001896FB200 */ get => default; } // 0x0000000186317E00-0x0000000186317EA0 
		public UnityEngine.UI.Text timeText { /* [XID] */ /* 0x0000000189702960-0x0000000189702980 */ get => default; } // 0x0000000186317EA0-0x0000000186317F40 
		public UnityEngine.UI.Text collectText { /* [XID] */ /* 0x000000018970A0F0-0x000000018970A110 */ get => default; } // 0x0000000186317B50-0x0000000186317BF0 
		public UnityEngine.UI.Text tipsText { /* [XID] */ /* 0x0000000189711B70-0x0000000189711B90 */ get => default; } // 0x0000000186317F40-0x0000000186317FE0 
		public int leftAnimCount { /* [XID] */ /* 0x0000000189719010-0x0000000189719030 */ get => default; } // 0x0000000186317BF0-0x0000000186317C90 
		public float leftTimeAnimDelta { /* [XID] */ /* 0x00000001897206D0-0x00000001897206F0 */ get => default; } // 0x0000000186317C90-0x0000000186317D40 
		public float collectAnimDeltaTime { /* [XID] */ /* 0x0000000189727CA0-0x0000000189727CC0 */ get => default; } // 0x0000000186317AA0-0x0000000186317B50 
		public Button quitBtn { /* [XID] */ /* 0x000000018972F320-0x000000018972F340 */ get => default; } // 0x0000000186317D40-0x0000000186317E00 
		public Button againButton { /* [XID] */ /* 0x0000000189736D00-0x0000000189736D20 */ get => default; } // 0x00000001863179E0-0x0000000186317AA0 
	
		// Constructors
		public MonoActivityFlightChallengeSettle() {} // 0x00000001863178E0-0x00000001863179E0
	
		// Methods
		// [XID] // 0x000000018973E860-0x000000018973E880
		public void SetResult(bool isSuccess) {} // 0x00000001863176E0-0x00000001863177D0
		// [XID] // 0x0000000189745BA0-0x0000000189745BC0
		public void SetMedal(uint lev) {} // 0x00000001863174E0-0x0000000186317600
		// [XID] // 0x000000018974D670-0x000000018974D690
		public void SetNewTag(bool isNew) {} // 0x0000000186317600-0x00000001863176E0
		// [XID] // 0x0000000189754C90-0x0000000189754CB0
		public void ScoreEventBegin() {} // 0x0000000186317430-0x00000001863174E0
		// [XID] // 0x000000018975BE40-0x000000018975BE60
		public void CollectEventBegin() {} // 0x0000000186317380-0x0000000186317430
		// [XID] // 0x0000000189763810-0x0000000189763830
		private void Update() {} // 0x00000001863177D0-0x00000001863178E0
	}
}
