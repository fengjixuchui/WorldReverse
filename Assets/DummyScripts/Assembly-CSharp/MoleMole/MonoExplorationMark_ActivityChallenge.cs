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
	public class MonoExplorationMark_ActivityChallenge : MonoBehaviour // TypeDefIndex: 30465
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _button; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _unlock; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _complete; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _selected; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _locking; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lockingTime; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtLockingTime; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform redPointContainer; // 0x50
		private ExpeditionChallengeInfo _challengeInfo; // 0x58
		private List<ElementType> _upElements; // 0x60
		private TimeSpan lastTimeSpan; // 0x68
		private MonoNoticeContainer _redPoint; // 0x70
	
		// Properties
		public Animator animator { /* [XID] */ /* 0x0000000189732370-0x0000000189732390 */ get => default; } // 0x000000018562B2E0-0x000000018562B3A0 
		public Button button { /* [XID] */ /* 0x0000000189739A60-0x0000000189739A80 */ get => default; } // 0x000000018562B3A0-0x000000018562B440 
		public GameObject locking { /* [XID] */ /* 0x0000000189741620-0x0000000189741640 */ get => default; } // 0x000000018562B6E0-0x000000018562B780 
		public GameObject lockingTime { /* [XID] */ /* 0x0000000189748EE0-0x0000000189748F00 */ get => default; } // 0x000000018562B640-0x000000018562B6E0 
		public UnityEngine.UI.Text txtLockingTime { /* [XID] */ /* 0x0000000189750390-0x00000001897503B0 */ get => default; } // 0x000000018562B8D0-0x000000018562B970 
		public GameObject unlock { /* [XID] */ /* 0x0000000189757930-0x0000000189757950 */ get => default; } // 0x000000018562B970-0x000000018562BA10 
		public GameObject complete { /* [XID] */ /* 0x000000018975F350-0x000000018975F370 */ get => default; } // 0x000000018562B5A0-0x000000018562B640 
		public bool selected { /* [XID] */ /* 0x00000001897667E0-0x0000000189766800 */ set {} } // 0x000000018562BB10-0x000000018562BC00
		public ExpeditionChallengeInfo challengeInfo { /* [XID] */ /* 0x00000001897847B0-0x00000001897847D0 */ get => default; } // 0x000000018562B500-0x000000018562B5A0 
		public ExpeditionChallengeExcelConfig challengeCfg { /* [XID] */ /* 0x00000001897931F0-0x0000000189793210 */ get => default; } // 0x000000018562B440-0x000000018562B500 
		public List<ElementType> upElements { /* [XID] */ /* 0x00000001897A2980-0x00000001897A29A0 */ get => default; } // 0x000000018562BA10-0x000000018562BB10 
		public MonoNoticeContainer redPoint { /* [XID] */ /* 0x00000001897B18B0-0x00000001897B18D0 */ get => default; } // 0x000000018562B780-0x000000018562B8D0 
	
		// Constructors
		public MonoExplorationMark_ActivityChallenge() {} // 0x000000018562B270-0x000000018562B2E0
	
		// Methods
		// [XID] // 0x000000018976DDF0-0x000000018976DE10
		public void SetMarkerLocking() {} // 0x000000018562AA90-0x000000018562AC00
		// [XID] // 0x0000000189775530-0x0000000189775550
		public void SetMarkerComplete() {} // 0x000000018562A920-0x000000018562AA90
		// [XID] // 0x000000018977CD90-0x000000018977CDB0
		public void SetMarkerUnlock() {} // 0x000000018562AC00-0x000000018562AD70
		// [XID] // 0x000000018978BD40-0x000000018978BD60
		public void SetChallengeInfo(ExpeditionChallengeInfo challengeInfo) {} // 0x000000018562A800-0x000000018562A920
		// [XID] // 0x000000018979B4C0-0x000000018979B4E0
		private List<ElementType> ParseElement(string superElement) => default; // 0x000000018562A620-0x000000018562A800
		// [XID] // 0x00000001897A9E80-0x00000001897A9EA0
		public void UpdateTime() {} // 0x000000018562AD70-0x000000018562B270
	}
}
