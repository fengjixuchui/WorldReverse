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
	public class MonoChannellerSlabCampRow : MonoBehaviour, IJoypadSelect // TypeDefIndex: 30044
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _campDesc; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _processTrans; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _lockedTrans; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _lockedImgTrans; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _completeTrans; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _rewardList; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _selectTrans; // 0x50
	
		// Properties
		public UnityEngine.UI.Text campDesc { /* [XID] */ /* 0x000000018986B050-0x000000018986B070 */ get => default; } // 0x00000001848097D0-0x0000000184809870 
		public MonoSimpleReusableList rewardList { /* [XID] */ /* 0x0000000189872420-0x0000000189872440 */ get => default; } // 0x0000000184809870-0x0000000184809910 
	
		// Constructors
		public MonoChannellerSlabCampRow() {} // 0x0000000184809740-0x00000001848097D0
	
		// Methods
		// [XID] // 0x000000018987A030-0x000000018987A050
		public void SetState(int state) {} // 0x0000000184809610-0x0000000184809740
		// [XID] // 0x00000001898811B0-0x00000001898811D0
		public void SetSelected(bool bSelected) {} // 0x0000000184809530-0x0000000184809610
		// [XID] // 0x00000001898887A0-0x00000001898887C0
		public void SetAnimatorState(bool bShow) {} // 0x0000000184809420-0x0000000184809530
	}
}
