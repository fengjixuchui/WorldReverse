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
	public class MonoActivityFlightChallengeListRow : MonoBehaviour // TypeDefIndex: 30338
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _hintText; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _rewardList; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _completeMaskTrans; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _completeTrans; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _inProgressTrans; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _actionBtn; // 0x48
		private bool _hightlighted; // 0x50
	
		// Properties
		public MonoGridScroller rewardList { /* [XID] */ /* 0x00000001896576A0-0x00000001896576C0 */ get => default; } // 0x0000000186317130-0x00000001863171D0 
		public UnityEngine.UI.Text hintText { /* [XID] */ /* 0x000000018965ED00-0x000000018965ED20 */ get => default; } // 0x0000000186317090-0x0000000186317130 
		public Button actionBtn { /* [XID] */ /* 0x00000001896663A0-0x00000001896663C0 */ get => default; } // 0x0000000186316F40-0x0000000186316FF0 
		public bool highlight { /* [XID] */ /* 0x000000018967D270-0x000000018967D290 */ get => default; /* [XID] */ /* 0x0000000189684940-0x0000000189684960 */ set {} } // 0x0000000186316FF0-0x0000000186317090 0x00000001863171D0-0x0000000186317380
	
		// Nested types
		public enum EProgressState // TypeDefIndex: 30339
		{
			CanNotTaken = 0,
			CanTake = 1,
			Taken = 2
		}
	
		// Constructors
		public MonoActivityFlightChallengeListRow() {} // 0x0000000186316EB0-0x0000000186316F40
	
		// Methods
		// [XID] // 0x000000018966DBA0-0x000000018966DBC0
		public void SetState(EProgressState tState) {} // 0x0000000186316D80-0x0000000186316EB0
		// [XID] // 0x0000000189675940-0x0000000189675960
		public void SetSelectedState(bool selected) {} // 0x0000000186316C80-0x0000000186316D80
	}
}
